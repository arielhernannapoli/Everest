Imports System.Text
Imports System.Collections.Generic
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.IO
Imports MyExcel = Microsoft.Office.Interop.Excel
Imports System.Linq
Imports System.Collections
Imports System.Drawing.Imaging
Imports StdType

Public Class frmFormulaOne
    Inherits System.Windows.Forms.Form
    Dim Grilladmin As New GrillAdmin


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Grilla As AxVCF150.AxF1Book
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents img16 As System.Windows.Forms.ImageList
    Friend WithEvents toolImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents toolExportar As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulaOne))
        Me.Grilla = New AxVCF150.AxF1Book
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.toolImprimir = New System.Windows.Forms.ToolBarButton
        Me.toolExportar = New System.Windows.Forms.ToolBarButton
        Me.img16 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grilla
        '
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.Location = New System.Drawing.Point(0, 28)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.OcxState = CType(resources.GetObject("Grilla.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Grilla.Size = New System.Drawing.Size(992, 469)
        Me.Grilla.TabIndex = 0
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolImprimir, Me.toolExportar})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.img16
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(992, 28)
        Me.ToolBar1.TabIndex = 1
        '
        'toolImprimir
        '
        Me.toolImprimir.ImageIndex = 1
        Me.toolImprimir.Name = "toolImprimir"
        Me.toolImprimir.Tag = "imprimir"
        '
        'toolExportar
        '
        Me.toolExportar.ImageIndex = 0
        Me.toolExportar.Name = "toolExportar"
        Me.toolExportar.Tag = "exportar"
        '
        'img16
        '
        Me.img16.ImageStream = CType(resources.GetObject("img16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img16.TransparentColor = System.Drawing.Color.Lime
        Me.img16.Images.SetKeyName(0, "")
        Me.img16.Images.SetKeyName(1, "")
        '
        'frmFormulaOne
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 497)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "frmFormulaOne"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim Universo As Double
    Dim Target As String
    Dim sAlternativa As String
    Dim FechaDesde As Date
    Dim FechaHasta As Date
    Dim FOne As New AdminFormulaOne
    Dim Spots As DataTable
    Dim SpotsTotales As DataTable
    Dim mCancelar As Boolean = False
    Dim totalInversionNetaTodosMedios As Decimal
    Dim totalTotalTodosMedios As Decimal

    Dim TotalTRP As Decimal
    Dim TotalNeto As Decimal
    Dim TotalSegundos As Decimal
    Dim TotalNetoFinal As Decimal
    Dim TotalesFranja As New Hashtable
    Dim HashServicioAgenciaImporte As Hashtable
    Dim HashServicioAgenciaTipo As Hashtable
    Dim HashTitulosServicioAgencia As Hashtable

    Dim UltimaColumna As Integer
    Dim TipoRating As String

    Dim CalDiario As String
    Dim ResumenEconomico As String
    Dim ResumenPrograma As String
    Dim ReporteTarifa As String
    Dim SemanaNatural As Boolean
    Dim TotalAcumulado As New ArrayList
    Dim TotalDiscreto As New ArrayList
    Dim Tasa As Double
    Dim mDescripcion As String
    Private Const MedioRadio As Integer = 6
    Dim ControlReporteCPR As Boolean

    Dim CalendarioConNumeros As Boolean

    Dim TotalesSpots As List(Of String) = New List(Of String)
    Dim TotalesTrps As List(Of String) = New List(Of String)
    Dim TotalesNetos As List(Of String) = New List(Of String)

    'AS 2015/03 =======================================================================
    Private _nroPresupuesto As String

    Public Property NroPresupuesto() As String
        Get
            Return _nroPresupuesto
        End Get
        Set(ByVal value As String)
            _nroPresupuesto = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property



    Public Property Cancelar() As Boolean
        Get
            Return mCancelar
        End Get
        Set(ByVal Value As Boolean)
            mCancelar = Value
        End Set
    End Property

    Public Sub CargarReporteResumenEconomicoRadio(ByVal IDPlaza As Integer, ByVal Plaza As String, Optional ByVal idSistema As Integer = 0)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle
        Dim Fran As New Franjas_Detalle
        Dim Fila As Integer = 17
        Dim Col As Integer
        Dim Datos As DataTable

        Me.Text = "Resumen Económico"

        FOne.Grilla = Me.Grilla

        'carga el template
        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economicoAre_radio.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economicoProx_radio.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economico_radio.vts")
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\resumen_economicoAre_radio.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\resumen_economicoProx_radio.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\resumen_economico_radio.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\resumen_economicoFwd_radio.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\resumen_economicoScl_radio.vts") 'AG Unificacon 08/06/2015
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\resumen_economicoHsp_radio.vts") 'AG Unificacon 08/06/2015
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendario(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltrarResumenEconomico(Me.FechaDesde, Me.FechaHasta)

        F.ShowDialog()

        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        'lee los datos
        Spots = S.ReporteCalendarioDiario(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        'encabezado
        Me.CargarEncebezadoResumenEconomico(Spots, IDPlaza, Plaza)

        'resumen por cadena
        Datos = S.ResumenEconomico_Cadena(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Me.CargarDatosResumenEconomico(Datos, "soporte", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'temas
        Fila += 2
        Datos = S.ResumenEconomico_Temas(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Me.CargarDatosResumenEconomico(Datos, "tema", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'dias
        Fila += 2
        Datos = S.ResumenEconomico_Dias(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Me.CargarDatosResumenEconomico(Datos, "dia", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'semanas (CARGA LOS TOTALES DE TRP'S, NETO Y SEGUNDOS PARA USARLOS EN FRANJAS)
        Fila += 2
        Datos = S.ResumenEconomico_Semana(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Me.CargarDatosResumenEconomico(Datos, "semana", Fila)

        Dim Aux As DataTable
        Dim HDesde As String
        Dim HHasta As String

        '*** totales
        Fila += 1

        Datos = S.ResumenEconomico_Cadena(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'total spots
        FOne.CargarDato(Datos.Compute("sum(spots)", ""), Fila, 3)

        'total TRP
        FOne.CargarDato(Datos.Compute("sum(trp)", ""), Fila, 4)
        'total % TRP
        FOne.CargarDato("100,0%", Fila, 5)

        'total neto
        FOne.CargarDato("$ " & Format(Datos.Compute("sum(neto)", ""), "#,##0.00"), Fila, 6)
        'total % neto
        FOne.CargarDato("100,0%", Fila, 7)

        'total segundos
        FOne.CargarDato(Datos.Compute("sum(segundos)", "") & """", Fila, 8)
        'total % segundos
        FOne.CargarDato("100%", Fila, 9)

        'total CPR
        Try
            FOne.CargarDato("$ " & Format(Datos.Compute("sum(neto)", "") / (Datos.Compute("sum(segundos)", "") / Datos.Compute("sum(spots)", "")) / Datos.Compute("sum(trp)", ""), "#,##0.00"), Fila, 10)
        Catch ex As DivideByZeroException
            FOne.CargarDato("$ " & 0, Fila, 10)
        End Try
        '***


        Dim FilaAux As Integer = Fila
        Dim ColAux As Integer = 3

        'llena 
        Dim Soportes As New Hashtable
        Try

            If Me.UltimaColumna > 0 Then
                FOne.CargarBorde(Fila, 3, Me.UltimaColumna - 1, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.BordeFino, TipoBorde.SinBorde, -1)
            End If

            'If Me.UltimaColumna = 0 Then
            'Me.UltimaColumna = 11 'DateDiff(DateInterval.Day, F.dtpFechaDesde.Value, F.dtpFechaHasta.Value) - 2
            ' End If
            '***

            FOne.Grilla.MaxRow = Fila + 1


            FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(10) & "$" & FOne.Grilla.MaxRow

            FOne.Grilla.PrintRowHeading = False
            FOne.Grilla.PrintGridLines = False
            FOne.Grilla.PrintLandscape = False
            FOne.Grilla.PrintLeftMargin = 0.8
            FOne.Grilla.PrintRightMargin = 0.2
            FOne.Grilla.PrintBottomMargin = 0.2
            FOne.Grilla.PrintHeaderMargin = 0.5
            FOne.Grilla.PrintTopMargin = 0.5
            FOne.Grilla.PrintHeader = ""
            FOne.Grilla.PrintHCenter = False
            FOne.Grilla.PrintVCenter = False
            FOne.Grilla.PrintScaleFitHPages = 1
            FOne.Grilla.PrintScale = 100

            FOne.Grilla.SetSelection(1, 1, 1, 1)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub CargarReporteResumenEconomico(ByVal IDPlaza As Integer, ByVal Plaza As String, Optional ByVal idSistema As Integer = 0)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle
        Dim Fran As New Franjas_Detalle
        Dim Fila As Integer = 17
        Dim Col As Integer
        Dim Datos As DataTable
        Dim DatosCPR As DataTable

        Me.Text = "Resumen Económico"

        FOne.Grilla = Me.Grilla

        ''carga el template
        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economico.vts")
        'Else
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economicoAre.vts")
        'End If

        'carga el template
        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++++++++++
        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economicoAre.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economicoProx.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_economico.vts")
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\resumen_economicoAre.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\resumen_economicoProx.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\resumen_economico.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\resumen_economicoFwd.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\resumen_economicoScl.vts") 'AG Unificacon 08/06/2015
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\resumen_economicoHsp.vts") 'AG Unificacon 08/06/2015
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendario(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltrarResumenEconomico(Me.FechaDesde, Me.FechaHasta)

        F.ShowDialog()

        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        'JJP
        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        'lee los datos
        Spots = S.ReporteCalendarioDiario(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        'encabezado
        Me.CargarEncebezadoResumenEconomico(Spots, IDPlaza, Plaza)

        'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++
        ControlReporteCPR = S.ControlReporteCPR(Activo.IDCampaña, Activo.IDAlternativa)
        '+++++++++++++++++++++++++++++++++++++++++++++++

        'resumen por cadena
        ''CAMBIO PARA UTILIZAR FECHA DE FILTRO //DCAIME 06/07/2010
        ''Datos = S.ResumenEconomico_Cadena(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Datos = S.ResumenEconomico_Cadena2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)

        'AG 04/02/2013 +++++++++++++++++++++++++++++++++++++
        'If ControlReporteCPR = True Then
        Datos = CalculoCPRPromedioXCadenaResumenEconomico(Datos)
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++
        Me.CargarDatosResumenEconomico(Datos, "soporte", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'temas
        Fila += 2
        ''Datos = S.ResumenEconomico_Temas(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Datos = S.ResumenEconomico_Temas2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        'AG 04/02/2013 +++++++++++++++++++++++++++++++++
        'If ControlReporteCPR = True Then
        Datos = CalculoCPRPromedioXTemaResumenEconomico(Datos)
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++
        Me.CargarDatosResumenEconomico(Datos, "tema", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'dias
        Fila += 2
        ''Datos = S.ResumenEconomico_Dias(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        Datos = S.ResumenEconomico_Dias2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        'AG 15/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DatosCPR = S.ResumenEconomico_Dias3(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        Datos = CalculoCPRPromedioXDiaResumenEconomico(Datos, DatosCPR)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Me.CargarDatosResumenEconomico(Datos, "dia", Fila)

        TotalTRP = 0
        TotalNeto = 0
        TotalSegundos = 0

        'semanas (CARGA LOS TOTALES DE TRP'S, NETO Y SEGUNDOS PARA USARLOS EN FRANJAS)
        Fila += 2
        ''Datos = S.ResumenEconomico_Semana(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)
        ''dcaime
        Datos = S.ResumenEconomico_Semana2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        DatosCPR = S.ResumenEconomico_Semana3(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        Datos = CalculoCPRPromedioXSemanaResumenEconomico(Datos, DatosCPR)
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Me.CargarDatosResumenEconomico(Datos, "semana", Fila)

        'franjas
        Fila += 2

        Dim Aux As DataTable
        Dim HDesde As String
        Dim HHasta As String

        Aux = Fran.ObtenerFranjasSistema(Activo.IDCampaña, idSistema) 'S.ResumenEconomico_Ver_Franjas(Activo.IDCampaña)

        For i As Integer = 0 To Aux.Rows.Count - 1
            Dim Dr As DataRow = Aux.Rows(i)

            HDesde = Format(Dr("h_desde"), "00") & Format(Dr("m_desde"), "00")
            HHasta = Format(Dr("h_hasta"), "00") & Format(Dr("m_hasta"), "00")
            ''dcaime
            ''Datos = S.ResumenEconomico_Franjas(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Dr("id_franja"), HDesde, HHasta)

            Datos = S.ResumenEconomico_Franjas2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Dr("id_franja"), HDesde, HHasta, Me.FechaDesde, Me.FechaHasta)
            'AG 15/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            DatosCPR = S.ResumenEconomico_Franjas3(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Dr("id_franja"), HDesde, HHasta, Me.FechaDesde, Me.FechaHasta)
            Datos = CalculoCPRPromedioXFranjaResumenEconomico(Datos, DatosCPR)
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Dim EsUltimoRegistro As Boolean = IIf(i = Aux.Rows.Count - 1, True, False)
            Me.CargarDatosResumenEconomicoFranja(Datos, Dr("descripcion"), Fila, EsUltimoRegistro)
        Next

        '*** totales
        Fila += 1
        ''dcaime
        ''Datos = S.ResumenEconomico_Cadena(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Datos = S.ResumenEconomico_Cadena2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Me.FechaDesde, Me.FechaHasta)
        Datos = CalculoCPRPromedioXCadenaResumenEconomico(Datos)
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'total spots
        FOne.CargarDato(Datos.Compute("sum(spots)", ""), Fila, 3)

        'total TRP
        FOne.CargarDato(Datos.Compute("sum(trp)", ""), Fila, 4)
        'total % TRP
        FOne.CargarDato("100,0%", Fila, 5)

        'total neto
        FOne.CargarDato("$ " & Format(Datos.Compute("sum(neto)", ""), "#,##0.00"), Fila, 6)
        'total % neto
        FOne.CargarDato("100,0%", Fila, 7)

        'total segundos
        FOne.CargarDato(Datos.Compute("sum(segundos)", "") & """", Fila, 8)
        'total % segundos
        FOne.CargarDato("100%", Fila, 9)

        'total CPR
        Try
            'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            FOne.CargarDato("$ " & Format(CalculoCPRPromedioCompletoResumenEconomico(), "#,##0.00"), Fila, 10)
            'FOne.CargarDato("$ " & Format(Datos.Compute("sum(neto)", "") / (Datos.Compute("sum(segundos)", "") / Datos.Compute("sum(spots)", "")) / Datos.Compute("sum(trp)", ""), "#,##0.00"), Fila, 10)
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Catch ex As DivideByZeroException
            FOne.CargarDato("$ " & 0, Fila, 10)
        End Try
        '***

        '*** franjas por soporte
        Fila += 2
        Col = 3

        Dim FilaAux As Integer = Fila
        Dim ColAux As Integer = 3

        'llena 
        Dim Soportes As New Hashtable

        'recorro las franjas
        For Each Franja As DataRow In Aux.Rows
            Fila = Fila + 2

            'descripcion de la franja
            FOne.CargarDato(Franja("descripcion"), Fila, Col)
            FOne.CargarBorde(Fila, Col, Col + 3, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

            Fila += 1

            'titulos
            FOne.CargarDato("Spots", Fila, Col)
            Col += 1
            FOne.CargarDato("TRPs", Fila, Col)
            Col += 1
            FOne.CargarDato("%H", Fila, Col)
            Col += 1
            FOne.CargarDato("CPR", Fila, Col)
            FOne.CargarBorde(Fila, Col - 3, Col, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)
            Col += 1

            Fila = FilaAux
            '***

            HDesde = Format(Franja("h_desde"), "00") & Format(Franja("m_desde"), "00")
            HHasta = Format(Franja("h_hasta"), "00") & Format(Franja("m_hasta"), "00")

            ''dcaime
            ''Datos = S.ResumenEconomico_Franjas2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Franja("id_franja"), HDesde, HHasta, Me.FechaDesde, Me.FechaHasta)
            Datos = S.ResumenEconomico_Franjas2(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Franja("id_franja"), HDesde, HHasta, Me.FechaDesde, Me.FechaHasta)
            'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            DatosCPR = S.ResumenEconomico_Franjas3(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Franja("id_franja"), HDesde, HHasta, Me.FechaDesde, Me.FechaHasta)
            Datos = CalculoCPRPromedioXFranjaResumenEconomico(Datos, DatosCPR)
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'guarda los totales por franja que se muestran en el desglose
            Dim D As New DatosDesgloseFranjas

            D.TRPs = Valores.CastDBNull(Datos.Compute("sum(TRP)", ""))
            D.Spots = Valores.CastDBNull(Datos.Compute("sum(spots)", ""))
            If D.TRPs = 0 Or D.Spots = 0 Then
                D.CPR = 0
            Else
                'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                If Datos.Rows.Count > 0 Then
                    D.CPR = Datos.Compute("sum(cpr)", "") / Datos.Rows.Count
                End If
                'D.CPR = Datos.Compute("sum(neto)", "") / (Datos.Compute("sum(segundos)", "") / Datos.Compute("sum(spots)", "")) / Datos.Compute("sum(trp)", "")
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            End If
            'End If



            'Dim neto As Single
            'Dim durprom As Single
            'Dim trp As Single

            'neto = Datos.Compute("sum(neto)", "")
            'trp = Datos.Compute("sum(trp)", "")
            'durprom = Datos.Compute("avg(segundos)", "")

            'd.CPR = neto / trp / durprom
            If Not TotalesFranja.ContainsKey(Franja("descripcion")) Then
                If Not TotalesFranja.ContainsValue(D) Then
                    Me.TotalesFranja.Add(Franja("descripcion"), D)
                End If

            End If

            '***

            'recorre los soportes
            For Each Dr As DataRow In Datos.Rows
                D = New DatosDesgloseFranjas

                D.Franja = Franja("descripcion")

                D.Spots = Dr("spots")
                D.TRPs = Dr("trp")
                'D.CPR = dr("cpr")
                Try
                    'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++
                    D.CPR = Format(CDec(Dr("CPR")), "#,##0.0")
                    'D.CPR = Format(CDec(Dr("neto") / (Dr("segundos") / Dr("spots")) / Dr("trp")), "#,##0.0")
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                Catch ex As DivideByZeroException
                    D.CPR = 0
                End Try

                Dim A As ArrayList

                If Soportes.Contains(Dr("soporte")) Then
                    A = Soportes.Item(Dr("soporte"))

                    A.Add(D)
                Else
                    A = New ArrayList

                    A.Add(D)

                    Soportes.Add(Dr("soporte"), A)
                End If
            Next
        Next

        Fila += 4
        Col = ColAux

        'recorre los soportes
        Dim j As Integer = 0

        'carga los datos del desglose
        For Each Soporte As String In Soportes.Keys
            Me.CargarDatosDesgloseFranja2(DirectCast(Soportes.Item(Soporte), ArrayList), Soporte, Fila, Col, Col, j)

            Fila += 1
            Col = ColAux
            j += 1
        Next

        '*** totales del desglose de franjas
        Col = ColAux

        'recorre las franjas
        For Each Dr As DataRow In Aux.Rows
            Dim D As DatosDesgloseFranjas = Me.TotalesFranja.Item(Dr("descripcion"))

            'SPOTS
            FOne.CargarDato(D.Spots, Fila, Col)
            Col += 1

            'TPRs
            FOne.CargarDato(D.TRPs, Fila, Col)
            Col += 1

            '%H
            FOne.CargarDato(Math.Round(D.TRPs / TotalTRP * 100, 2) & "%", Fila, Col)
            Col += 1

            'CPR 1"
            FOne.CargarDato("$ " & Math.Round(Valores.CastDBNull(D.CPR), 2), Fila, Col)
            Col += 1
        Next

        'ingresa la palabra TOTAL
        FOne.CargarDato("TOTAL", Fila, 1)
        Try

            If Me.UltimaColumna > 0 Then
                FOne.CargarBorde(Fila, 3, Me.UltimaColumna - 1, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.BordeFino, TipoBorde.SinBorde, -1)
            End If

            'If Me.UltimaColumna = 0 Then
            'Me.UltimaColumna = 11 'DateDiff(DateInterval.Day, F.dtpFechaDesde.Value, F.dtpFechaHasta.Value) - 2
            ' End If
            '***

            FOne.Grilla.MaxRow = Fila + 1


            'FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(10) & "$" & FOne.Grilla.MaxRow
            FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(Col) & "$" & FOne.Grilla.MaxRow

            FOne.Grilla.PrintRowHeading = False
            FOne.Grilla.PrintGridLines = False
            FOne.Grilla.PrintLandscape = False
            FOne.Grilla.PrintLeftMargin = 0.8
            FOne.Grilla.PrintRightMargin = 0.2
            FOne.Grilla.PrintBottomMargin = 0.2
            FOne.Grilla.PrintHeaderMargin = 0.5
            FOne.Grilla.PrintTopMargin = 0.5
            FOne.Grilla.PrintHeader = ""
            FOne.Grilla.PrintHCenter = False
            FOne.Grilla.PrintVCenter = False
            FOne.Grilla.PrintScaleFitHPages = 1
            FOne.Grilla.PrintScale = 100
            FOne.Grilla.MaxCol = Col

            FOne.Grilla.SetSelection(1, 1, 1, 1)

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub CargarDatosDesgloseFranja2(ByVal Datos As ArrayList, ByVal Soporte As String, ByVal Fila As Integer, ByVal Col As Integer, ByVal ColAux As Integer, ByVal ContSoporte As Integer)
        Dim TotalTRPHoriz As Decimal
        Dim Spots As Integer
        Dim TRP As Single
        Dim CPR As Decimal
        Dim ContFranja As Integer = 0

        For Each D As DatosDesgloseFranjas In Datos
            TotalTRPHoriz += D.TRPs
        Next

        'recore las franjas
        For Each D As DatosDesgloseFranjas In Datos
            'si es la franja correcta, carga los datos, si no, van en Cero
            Dim FranjaActual As String

            'lee la franja que ya se cargo en el reporte
            FranjaActual = FOne.LeerDato(Fila - 2 - ContSoporte, 3 + (ContFranja * 4))

            'si la franja actual no coincide con la franja del desglose que ya se cargo en el reporte,
            'ingresa un registro en blanco
            Do While FranjaActual <> D.Franja
                If FOne.LeerDato(Fila, 2) = "" Then
                    'SOPORTE
                    FOne.CargarDato(Soporte, Fila, 2)
                End If

                'SPOTS
                FOne.CargarDato("", Fila, Col)
                Col += 1

                'TPRs
                FOne.CargarDato("", Fila, Col)
                Col += 1

                '%H
                FOne.CargarDato("", Fila, Col)
                Col += 1

                'CPR a 1"
                FOne.CargarDato("", Fila, Col)
                Col += 1

                FOne.CargarBorde(Fila, Col - 4, Col - 4, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                FOne.CargarBorde(Fila, Col - 1, Col - 1, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                ContFranja += 1
                FranjaActual = FOne.LeerDato(Fila - 2 - ContSoporte, 3 + (ContFranja * 4))
            Loop

            'carga los datos del soporte en el reporte
            If FOne.LeerDato(Fila, 2) = "" Then
                'SOPORTE
                FOne.CargarDato(Soporte, Fila, 2)
            End If

            'SPOTS
            FOne.CargarDato(D.Spots, Fila, Col)
            Col += 1

            'TPRs
            FOne.CargarDato(D.TRPs, Fila, Col)
            Col += 1

            '%H
            If TotalTRPHoriz > 0 Then
                FOne.CargarDato(Math.Round(D.TRPs * 100 / TotalTRPHoriz, 2) & "%", Fila, Col)
            Else
                FOne.CargarDato(0, Fila, Col)
            End If
            Col += 1

            'CPR a 1"
            FOne.CargarDato("$ " & Valores.CastDBNull(D.CPR), Fila, Col)
            Col += 1

            FOne.CargarBorde(Fila, Col - 4, Col - 4, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
            FOne.CargarBorde(Fila, Col - 1, Col - 1, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

            'guarda la ultima columna 
            Me.UltimaColumna = Col

            ContFranja += 1
        Next
    End Sub

    Private Sub CargarDatosResumenEconomicoFranja(ByVal Datos As DataTable, ByVal Descripcion As String, ByRef Fila As Integer, ByVal EsUltimoRegistro As Boolean)
        Dim Col As Integer = 2
        Dim Spots, Segundos As Integer
        Dim TRP, Neto As Decimal
        Dim CPR As Decimal
        Dim CantRegistros As Integer

        For Each Dr As DataRow In Datos.Rows
            'spots
            Spots += Dr("spots")

            'trps
            TRP += Dr("trp")

            'neto
            Neto += Dr("neto")

            'segundos
            Segundos += Dr("segundos")

            'AG 15/02/2013 +++++++++++
            CPR += Dr("CPR")
            CantRegistros = Datos.Rows.Count
            '++++++++++++++++++++++
        Next

        'descripcion
        FOne.CargarDato(Descripcion, Fila, Col)

        'spots
        FOne.CargarDato(Spots, Fila, Col + 1)

        'trps
        FOne.CargarDato(TRP, Fila, Col + 2)
        '% trps
        If TotalTRP > 0 Then
            FOne.CargarDato(Math.Round(TRP * 100 / TotalTRP, 1) & "%", Fila, Col + 3)
        Else
            FOne.CargarDato("0%", Fila, Col + 3)
        End If

        'neto
        FOne.CargarDato("$ " & Format(Neto, "#,##0.00"), Fila, Col + 4)
        '% neto
        If TotalNeto > 0 Then
            FOne.CargarDato(Math.Round(Neto * 100 / TotalNeto, 1) & "%", Fila, Col + 5)
        Else
            FOne.CargarDato("0%", Fila, Col + 5)
        End If

        'segundos
        FOne.CargarDato(Segundos & """", Fila, Col + 6)
        '% segundos
        If TotalSegundos > 0 Then
            FOne.CargarDato(Math.Round(Segundos * 100 / TotalSegundos, 1) & "%", Fila, Col + 7)
        Else
            FOne.CargarDato("0%", Fila, Col + 7)
        End If

        'cpr
        If Segundos = 0 Or Spots = 0 Or TRP = 0 Then
            FOne.CargarDato("$ " & 0, Fila, Col + 8)
        Else
            'AG 15/02/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'FOne.CargarDato("$ " & Format(CPR / CantRegistros, "#,##0.00"), Fila, Col + 8)
            'LC 21/08/2014 Resumen Economico Calculo CPR por Franja
            FOne.CargarDato("$ " & Format(Neto / (Segundos / Spots) / TRP, "#,##0.00"), Fila, Col + 8)
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        End If

        Fila += 1

        If Not EsUltimoRegistro Then
            FOne.DuplicarFila(Fila, 1, 10)
        End If
    End Sub

    Private Sub CargarDatosResumenEconomico(ByVal Datos As DataTable, ByVal Descripcion As String, ByRef Fila As Integer, Optional ByVal Franja As String = "")
        Dim Col As Integer = 2
        Dim Dr As DataRow

        'calcula los totales para sacar los porcentajes
        TotalTRP = Valores.CastDBNull(Datos.Compute("sum(TRP)", ""))
        TotalNeto = Valores.CastDBNull(Datos.Compute("sum(neto)", ""))
        TotalSegundos = Valores.CastDBNull(Datos.Compute("sum(segundos)", ""))

        For i As Integer = 0 To Datos.Rows.Count - 1
            Dr = Datos.Rows(i)

            'descripcion
            Select Case Descripcion.ToLower
                Case "semana"
                    FOne.CargarDato("Semana del Año Nº ", Fila, Col)
                    FOne.CargarDato(Dr(Descripcion), Fila, Col, True)

                Case "cargar_franja"
                    If Activo.IDMedio <> MedioRadio Then
                        FOne.CargarDato(Franja, Fila, Col)
                    End If
                Case Else
                    FOne.CargarDato(Dr(Descripcion), Fila, Col)

            End Select

            'spots
            FOne.CargarDato(Dr("spots"), Fila, Col + 1)

            'trps
            FOne.CargarDato(Dr("TRP"), Fila, Col + 2)
            '% trps
            If TotalTRP > 0 Then
                FOne.CargarDato(Math.Round(Dr("TRP") * 100 / TotalTRP, 1) & "%", Fila, Col + 3)
            Else
                FOne.CargarDato(0 & "%", Fila, Col + 3)
            End If

            'neto
            FOne.CargarDato("$ " & Format(Dr("neto"), "#,##0.00"), Fila, Col + 4)
            '% neto
            FOne.CargarDato(Math.Round(Dr("neto") * 100 / TotalNeto, 1) & "%", Fila, Col + 5)

            'segundos
            FOne.CargarDato(Dr("segundos") & """", Fila, Col + 6)
            '% segundos
            FOne.CargarDato(Math.Round(Dr("segundos") * 100 / TotalSegundos, 2) & "%", Fila, Col + 7)

            'cpr
            Try
                'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                FOne.CargarDato("$ " & Format(Dr("CPR"), "#,##0.00"), Fila, Col + 8)
                'FOne.CargarDato("$ " & Format(Dr("neto") / (Dr("segundos") / Dr("spots")) / Dr("trp"), "#,##0.00"), Fila, Col + 8)
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Catch ex As DivideByZeroException
                FOne.CargarDato("$ " & 0, Fila, Col + 8)
            End Try

            If i < Datos.Rows.Count - 1 Then
                FOne.DuplicarFila(Fila, 1, 10)
            End If

            Fila += 1
        Next
    End Sub

    Private Sub CargarEncebezadoResumenEconomico(ByVal Spots As DataTable, ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ColSegundaColumna As Integer = 8

        'empresa / cliente
        FOne.CargarDato(Activo.Cliente, 3, 2)
        FOne.CargarDato(Activo.Cliente, 4, 2)

        'producto
        '*** se carga en CargarEtiquetasTemas

        'campaña
        FOne.CargarDato(Activo.Campaña, 6, 2)

        'periodo
        FOne.CargarDato(FechaDesde & " al " & FechaHasta, 7, 2)

        'fuente
        FOne.CargarDato("Procesamiento Ibope (Nautilus), Sigeme", 5, ColSegundaColumna, True)
        'FOne.CambiarFuente(3, ColSegundaColumna, "Arial", 10, True, False)

        'plaza
        FOne.CargarDato(Plaza, 8, 2, True)

        ' FOne.CargarDato("Alternativa:", 9, 1)
        ' FOne.CambiarFuente(9, 1, True)
        FOne.CargarDato(mDescripcion, 9, 2)



        Dim S As New Spots_detalle
        Dim Dt As DataTable
        Dim Separador As String = " / "

        Dt = S.ObtenerCalendarioEncabezado(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Activo.IDMedio, FechaDesde, FechaHasta)

        For Each Dr As DataRow In Dt.Rows
            If Dr Is Dt.Rows(Dt.Rows.Count - 1) Then
                Separador = ""
            End If

            'target
            FOne.CargarDato(Dr("target") & Separador, 3, ColSegundaColumna, True)

            'periodo de medicion
            FOne.CargarDato(Dr("f_inicio_aud") & " al " & Dr("f_fin_aud") & IIf(Separador = " / ", " * ", ""), 6, ColSegundaColumna, True)

            'tipo rating
            Select Case Dr("tipo_rating").ToString.ToLower
                Case "p"
                    TipoRating = "Programa"
                Case "t"
                    TipoRating = "Tanda"
                Case "f"
                    TipoRating = "Franja"
            End Select

            FOne.CargarDato(Dr("tipo_soporte") & " - " & TipoRating & Separador, 7, ColSegundaColumna, True)
        Next
    End Sub

    Public Sub CargarReporteResumenPrograma(ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ultimaColumaCalendario As Integer
        Dim ultimaFilaProgramas As Integer

        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle

        Me.Text = "Resumen por Programa"

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendario(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltrarResumenPrograma(Me.FechaDesde, Me.FechaHasta)

        F.ShowDialog()

        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If

        'lee los datos
        Spots = S.ReporteCalendarioDiario(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla


        'carga el template
        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_por_programa.vts")
        'Else
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_por_programaAre.vts")

        'End If

        'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++
        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_por_programaAre.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_por_programa.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\resumen_por_programa.vts")
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++	
        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\resumen_por_programaAre.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\resumen_por_programaProx.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\resumen_por_programa.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\resumen_por_programaFwd.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\resumen_por_programaScl.vts") 'AG Unificacon 08/06/2015
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\resumen_por_programaHsp.vts") 'AG Unificacon 08/06/2015
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendario(6)
        ultimaColumaCalendario = MaxCol - 4

        'devuelve un array de objetos Registro Calendario con los datos finales del reporte
        'agrupa por Cadena, Hora, Programa y Rating
        Dim Datos As ArrayList = Me.AplicarCorteControl(False)

        Fila = 12
        Me.CargarDatosResumenPrograma(Datos, 1, MaxCol, Fila, F.MostrarNeto, F.AgruparTemas, "Cadena", "Hora", "Programa", "Rating")
        ultimaFilaProgramas = Fila

        Fila += 2

        Me.CargarEncebezadoResumenPrograma(Spots, IDPlaza, Plaza)
        Me.CargarPromediosFinales(Fila, 0, 0, 4, False)
        Me.CargarSpotsSemana(Fila, MaxCol, 6)
        Me.CargarTotalesFinales(Fila, MaxCol, True)
        Me.CargarTotalesTRPS(Fila, MaxCol, 6, False)
        Me.CargarEtiquetasTemas(Fila + 10, 1, Activo.IDCampaña, Activo.IDAlternativa)

        If Not F.MostrarNeto Then ' Elimina la columna de neto
            FOne.Grilla.DeleteRange(Fila, MaxCol, Fila, MaxCol, VCF150.F1ShiftTypeConstants.F1ShiftCols)

            ' Pone el borde derecho a las filas
            For i As Integer = 12 To Fila
                '' la ante ultima fila no tiene valores, es solo un espacio y no debe tener borde lateral
                If i <> Fila - 1 Then
                    FOne.CargarBorde(i, MaxCol - 1, MaxCol - 1, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                End If
            Next

            FOne.Grilla.MaxCol -= 1
        End If


        FOne.Grilla.MaxRow = Fila + 8
        FOne.Grilla.MaxCol -= 10


        FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow

        FOne.Grilla.PrintRowHeading = False
        FOne.Grilla.PrintGridLines = False
        FOne.Grilla.PrintLandscape = True
        FOne.Grilla.PrintLeftMargin = 0.8
        FOne.Grilla.PrintRightMargin = 0.2
        FOne.Grilla.PrintBottomMargin = 0.2
        FOne.Grilla.PrintHeaderMargin = 0.5
        FOne.Grilla.PrintTopMargin = 0.5
        FOne.Grilla.PrintHeader = ""
        FOne.Grilla.PrintHCenter = False
        FOne.Grilla.PrintVCenter = False
        FOne.Grilla.PrintScaleFitHPages = 1
        FOne.Grilla.PrintScale = 100

        FOne.Grilla.SetSelection(1, 1, 1, 1)

        Me.Cursor = Cursors.Default

        ' Corrijo algunos bordes:
        ' Borde de 1er titulo 
        FOne.CargarBorde(9, 1, 1, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio, -1)

        ' Quita los bordes de las filas separadoras
        For i As Integer = 9 To Fila
            ' la ante ultima fila no tiene valores, es solo un espacio y no debe tener borde lateral
            ' Antes de comenzar el calendario
            FOne.CargarBorde(i, 5, 5, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinBorde, TipoBorde.SinBorde, -1)
            ' Al terminar el calendario
            FOne.CargarBorde(i, ultimaColumaCalendario + 1, ultimaColumaCalendario + 1, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinBorde, TipoBorde.SinBorde, -1)

            ' Si terminaba con domingo, pone borde derecho fino
            If i <= ultimaFilaProgramas Then
                FOne.CargarBorde(i, ultimaColumaCalendario, ultimaColumaCalendario, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
            End If
        Next

    End Sub

    Public Sub CargarReporteCalendarioDiarioNew(ByVal IDPlaza As List(Of Integer), ByVal Plaza As List(Of String), ByVal Alternativa As String)

        Me.Cursor = Cursors.WaitCursor

        Dim calDiario As Calendarios.CalendarioDiario
        Dim S As New Spots_detalle

        Me.Text = "Calendario Diario"

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendario(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza(0))

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        FOne.Grilla = Me.Grilla

        Dim F As New frmFiltroCalendario(Me.FechaDesde, Me.FechaHasta)
        F.ShowDialog()
        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If
        
        If F.MostrarNumeros Then
            calDiario = New Calendarios.TVRadio.CalendarioDiarioConNumerosTVRadio(FOne, IDPlaza, Plaza, Activo.IDCampaña, Activo.IDAlternativa, Activo.IDCompaniaMMS, Activo.IDMedio, Alternativa, F.SemanaNatural, F.CalcularIVA, F.CalcularIVANetoAgencia, True)
        Else
            calDiario = New Calendarios.TVRadio.CalendarioDiarioConLetrasTVRadio(FOne, IDPlaza, Plaza, Activo.IDCampaña, Activo.IDAlternativa, Activo.IDCompaniaMMS, Activo.IDMedio, Alternativa, F.SemanaNatural, F.CalcularIVA, F.CalcularIVANetoAgencia, True)
        End If



    End Sub

    Public Sub CargarReporteCalendarioDiario(ByVal IDPlaza As Integer, ByVal Plaza As String)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle

        Me.Text = "Calendario Diario"

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendario(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltroCalendario(Me.FechaDesde, Me.FechaHasta)
        F.ShowDialog()
        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If

        'SETEO VALOR SI ELIGIO CALENDARIO NUMERICO
        Me.CalendarioConNumeros = F.MostrarNumeros

        'totales de spots
        SpotsTotales = S.ReporteCalendarioDiarioTotales(Activo.IDCampaña, Activo.IDAlternativa, F.FechaDesde, F.FechaHasta, IDPlaza)
        SpotsTotales = New DataView(SpotsTotales, "", "Cadena ASC, Factor DESC", DataViewRowState.CurrentRows).ToTable

        'lee los datos
        Spots = S.ReporteCalendarioDiario(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.CargarFacotres()

        ''Warning: Jsperk - El ordenamiento esta seteado por el campo Cadena de manera Asc.
        Dim dv As DataView
        Spots = New DataView(Spots, "", "Cadena ASC, Factor DESC", DataViewRowState.CurrentRows).ToTable

        ''

        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        Me.SemanaNatural = F.SemanaNatural

        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla

        'carga el template
        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevo.vts")
        'Else ' es ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoAre.vts")
        'End If

        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++++++
        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoAre.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoProx.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevo.vts")
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++	
        'If Activo.IDCompaniaMMS = 36 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\ARE\caldiarionuevoAre.vts")  'AG Unificacon 25/03/2013
        'ElseIf Activo.IDCompaniaMMS = 38 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\PRX\caldiarionuevoProx.vts")  'AG Unificacon 25/03/2013
        'ElseIf Activo.IDCompaniaMMS = 35 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\MPG\caldiarionuevo.vts")  'AG Unificacon 25/03/2013
        'ElseIf Activo.IDCompaniaMMS = 41 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\FWD\caldiarionuevoFwd.vts")  'AG Unificacon 25/03/2013
        'ElseIf Activo.IDCompaniaMMS = 42 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\SCL\caldiarionuevoScl.vts")  'AG Unificacon 08/06/2015
        'ElseIf Activo.IDCompaniaMMS = 39 Then
        '    FOne.CargarTemplate(Application.StartupPath & "\HSP\caldiarionuevoHsp.vts")  'AG Unificacon 08/06/2015
        'End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'UN UNICO TEMPLATE
        FOne.CargarTemplate(Application.StartupPath & "\MPG\caldiarionuevo.vts")

        'BLANQUEO OBJETOS SELECCIONADOS
        FOne.Grilla.SetSelection(1, 25, 1, 25)

        'CUAL IMAGEN MOSTRAR
        Try
            Select Case Activo.IDCompaniaMMS
                Case 35, 39
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoMPG"), 17, 4, 22, 6)
                    FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoMPG"), 17, 1, 22, 3)
                Case 36
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoARE"), 17, 4, 22, 6)
                    FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoARE"), 17, 1, 22, 3)
                Case 38
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoPRX"), 17, 4, 22, 6)
                    FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoPRX"), 17, 1, 22, 3)
                Case 41
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoSCL"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoFWD"), 17, 4, 22, 6)
                    FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoFWD"), 17, 1, 22, 3)
                Case 42
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoMPG"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoARE"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoFWD"))
                    FOne.Grilla.ObjAddSelection(FOne.Grilla.ObjNameToID("LogoPRX"))
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoSCL"), 17, 4, 22, 6)
                    FOne.Grilla.EditClear(VCF150.F1ClearTypeConstants.F1ClearAll)
                    FOne.Grilla.ObjSetPos(FOne.Grilla.ObjNameToID("LogoSCL"), 17, 1, 22, 3)
            End Select

        Catch e As Exception

        End Try

        Dim columnaInicioCalendario As Integer = 18

        ' COPIADO DE RANGOS DE FILAS Y COLUMNAS: IMPORTANTE!!!! --> LOS PRIMEROS RANGOS SON EL DESTINO Y LOS ULTIMOS SON EL ORIGEN
        'FOne.Grilla.CopyRange(1, 1, 2, 1, FOne.Grilla.SS, 3, 1, 4, 1)

        'ELIMINO COLUMNA DE TEMA SI LA VISUALIZACION ES EN LETRAS
        If Not Me.CalendarioConNumeros Then
            FOne.Grilla.ClearRange(1, 16, FOne.Grilla.MaxRow, 16, VCF150.F1ClearTypeConstants.F1ClearValues)
            FOne.Grilla.ClearRange(1, 16, FOne.Grilla.MaxRow, 16, VCF150.F1ClearTypeConstants.F1ClearFormats)
            FOne.Grilla.SetColHidden(16, 16, True)
        End If

        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendarioTVRD(columnaInicioCalendario)

        'devuelve un array de objetos Registro Calendario con los datos finales del reporte
        Dim Datos As ArrayList = Me.AplicarCorteControl()

        Fila = 14

        Me.CargarEncebezadoCalendarioDiario(Spots, IDPlaza, Plaza)

        Fila = 12

        'carga los datos
        Me.CargarDatosCalendario(Datos, 1, MaxCol, Fila, columnaInicioCalendario, "Cadena", "Dia", _
        "Hora", "Programa", "TarifaBruta", "D1", "D2", "D3", "D4", "D5", "TarifaNeta", "Dur", _
        "CostoSpot", "Rating", "CPR")

        Fila += 2

        Dim totalTemas As Integer = 0

        Me.CargarPromediosFinales(Fila, 7, 11, 15)
        Me.CargarSpotsSemana(Fila, MaxCol, columnaInicioCalendario)
        Me.CargarTotalesFinales(Fila, MaxCol)
        Me.CargarTotalesTRPS(Fila, MaxCol, columnaInicioCalendario)
        Me.CargarTotalesGenerales(Fila, MaxCol, F.CalcularIVA, F.CalcularIVANetoAgencia)
        totalTemas = Me.CargarEtiquetasTemas(Fila + 2, 4, Activo.IDCampaña, Activo.IDAlternativa)

        If totalTemas > 8 Then
            FOne.Grilla.MaxRow = Fila + 9 + (Math.Abs(totalTemas - 8))
        Else
            FOne.Grilla.MaxRow = Fila + 8
        End If

        FOne.Grilla.MaxCol -= 1

        FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow


        FOne.Grilla.PrintRowHeading = False
        FOne.Grilla.PrintGridLines = False
        FOne.Grilla.PrintLandscape = True

        FOne.Grilla.PrintLeftMargin = 0.8
        FOne.Grilla.PrintRightMargin = 0.2
        FOne.Grilla.PrintBottomMargin = 0.2
        FOne.Grilla.PrintHeaderMargin = 0.5
        FOne.Grilla.PrintTopMargin = 0.5
        FOne.Grilla.PrintHeader = ""
        FOne.Grilla.PrintHCenter = False
        FOne.Grilla.PrintScaleFitHPages = 1
        FOne.Grilla.PrintScale = 100

        FOne.Grilla.SetSelection(1, 1, 1, 1)

        'FOne.Grilla.Sort( Jsperk

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarFacotres()
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Dim S As New Spots_detalle
        Dim factor As DataTable
        Dim i As Integer = 0
        Dim codigoOrdenesMMS As String
        Dim columnaFactor As DataColumn
        columnaFactor = New DataColumn("Factor", GetType(Integer))
        columnaFactor.DefaultValue = 1
        Spots.Columns.Add(columnaFactor)
        For Each Dr As DataRow In Spots.Rows
            If Dr("id_orden_sigeme").ToString() <> String.Empty Then
                codigoOrdenesMMS += Dr("id_orden_sigeme").ToString() + ","
            Else
                Dr("Factor") = 1
            End If
            If (i = 100 Or i = Spots.Rows.Count - 1) And codigoOrdenesMMS <> String.Empty Then
                codigoOrdenesMMS = codigoOrdenesMMS.Substring(0, codigoOrdenesMMS.Length - 1)
                factor = S.ObtenerFactor(codigoOrdenesMMS, Activo.IDCompaniaMMS, Activo.IDMedio)
                For Each factorDr As DataRow In factor.Rows
                    Dim codigoOrdenMMS As Integer = Convert.ToInt32(factorDr("cod_orden").ToString())
                    For Each spotDr As DataRow In Spots.Rows
                        If spotDr("id_orden_sigeme").ToString() <> String.Empty Then
                            If spotDr("id_orden_sigeme") = factorDr("cod_orden") Then
                                spotDr("Factor") = factorDr("Factor")
                            End If
                        End If
                    Next
                Next
                i = 0
                codigoOrdenesMMS = String.Empty
            ElseIf i < 1000 Then
                i = i + 1
            End If
        Next
    End Sub

    Private Sub CargarFacotresInternet()
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Dim S As New Spots_detalle
        Dim factor As DataTable
        Dim i As Integer = 0
        Dim codigoOrdenesMMS As String
        Dim columnaFactor As DataColumn
        columnaFactor = New DataColumn("Factor", GetType(Integer))
        columnaFactor.DefaultValue = 1
        Spots.Columns.Add(columnaFactor)
        For Each Dr As DataRow In Spots.Rows
            If Dr("id_orden_mms").ToString() <> String.Empty Then
                codigoOrdenesMMS += Dr("id_orden_mms").ToString() + ","
            Else
                Dr("Factor") = 1
            End If
            If i = 100 Or i = Spots.Rows.Count - 1 Then
                codigoOrdenesMMS = codigoOrdenesMMS.Substring(0, codigoOrdenesMMS.Length - 1)
                factor = S.ObtenerFactor(codigoOrdenesMMS, Activo.IDCompaniaMMS, Activo.IDMedio)
                For Each factorDr As DataRow In factor.Rows
                    Dim codigoOrdenMMS As Integer = Convert.ToInt32(factorDr("cod_orden").ToString())
                    For Each spotDr As DataRow In Spots.Rows
                        If spotDr("id_orden_mms").ToString() <> String.Empty Then
                            If spotDr("id_orden_mms") = factorDr("cod_orden") Then
                                spotDr("Factor") = factorDr("Factor")
                            End If
                        End If
                    Next
                Next
                i = 0
                codigoOrdenesMMS = String.Empty
            ElseIf i < 1000 Then
                i = i + 1
            End If
        Next
    End Sub

    Public Sub CargarReporteCalendarioDiarioInternet(ByVal IDPlaza As Integer, ByVal Plaza As String)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle
        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendarioInternet(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_inicio asc")(0).Item("f_inicio")
        Me.FechaHasta = Spots.Select("", "f_fin desc")(0).Item("f_fin")

        Me.Text = "Calendario Diario"

        Dim F As New frmFiltroCalendario(Me.FechaDesde, Me.FechaHasta)
        F.ShowDialog()
        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If

        'lee los datos
        Spots = S.ReporteCalendarioDiarioInternet(Activo.IDCampaña, Activo.IDAlternativa, F.FechaDesde, F.FechaHasta, IDPlaza)

        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.CargarFacotresInternet()

        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        Me.SemanaNatural = F.SemanaNatural

        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla

        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\caldiarionuevoAreint.vts")
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\caldiarionuevoProxint.vts")
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\caldiarionuevoint.vts")
        ElseIf Activo.IDCompaniaMMS = 37 Then
            FOne.CargarTemplate(Application.StartupPath & "\MC\caldiarionuevoint.vts")
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\caldiarionuevoFwdint.vts")
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\caldiarionuevoSclint.vts")
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\caldiarionuevoHspint.vts")
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendario(8)

        If MaxCol > 0 Then

            'Aguzzardi ------------------------
            MaxCol = MaxCol - 1
            '-------------------------------------

            'devuelve un array de objetos Registro Calendario con los datos finales del reporte
            Dim Datos As ArrayList = Me.AplicarCorteControlInternet()

            Fila = 14

            Me.CargarEncebezadoCalendarioDiarioInternet(Spots, IDPlaza, Plaza)

            Fila = 12

            'carga los datos
            Me.CargarDatosCalendarioInternet(Datos, 1, MaxCol, Fila, "PROVEEDOR", "SOPORTE", _
            "TIPO_SOPORTE", "UBICACION", "TIPO_FORMATO", "FORMATO", "TIPO_COMPRA", "CANTIDAD_DIAS", _
            "CANTIDAD_HORAS", "BRUTO", "DCTO1", "DCTO2", "NETO", "INVERSION", "IMPRESIONES", "CLICKS", _
            "VIEWS", "SHAR", "PORSAG", "IMPSAG", "TOTAL")

            Fila += 2

            'Me.CargarPromediosFinalesPrensa(Fila, 7, 11, 12)
            'Me.CargarSpotsSemanaPrensa(Fila, MaxCol, 14)
            'Me.CargarTotalesFinalesPrensa(Fila, MaxCol)
            'Me.CargarTotalesTRPsPR(Fila, MaxCol, 14)
            'Me.CargarTotalesGeneralesPrensa(Fila, MaxCol, F.CalcularIVA, F.CalcularIVANetoAgencia)

            FOne.CargarDato("Total Medios", Fila, MaxCol + 5)
            FOne.CargarDato("$ " & Format(totalInversionNetaTodosMedios, "#,##0.00"), Fila, MaxCol + 6)
            FOne.Grilla.SetSelection(Fila, MaxCol + 5, Fila, MaxCol + 6)
            FOne.Grilla.FontBold = True

            FOne.CargarDato("Total", Fila, MaxCol + 12)
            FOne.CargarDato("$ " & Format(TotalNetoFinal, "#,##0.00"), Fila, MaxCol + 13)
            FOne.Grilla.SetSelection(Fila, MaxCol + 12, Fila, MaxCol + 13)
            FOne.Grilla.FontBold = True

            FOne.Grilla.MaxRow = Fila + 8
            FOne.Grilla.MaxCol -= 1

            FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow


            FOne.Grilla.PrintRowHeading = False
            FOne.Grilla.PrintGridLines = False
            FOne.Grilla.PrintLandscape = True

            FOne.Grilla.PrintLeftMargin = 0.8
            FOne.Grilla.PrintRightMargin = 0.2
            FOne.Grilla.PrintBottomMargin = 0.2
            FOne.Grilla.PrintHeaderMargin = 0.5
            FOne.Grilla.PrintTopMargin = 0.5
            FOne.Grilla.PrintHeader = ""
            FOne.Grilla.PrintHCenter = False
            FOne.Grilla.PrintScaleFitHPages = 1
            FOne.Grilla.PrintScale = 100

            FOne.Grilla.SetSelection(1, 1, 1, 1)
        End If

        Me.Cursor = Cursors.Default
    End Sub
    Public Sub CargarReporteCalendarioDiarioPrensa(ByVal IDPlaza As Integer, ByVal Plaza As String)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle

        Me.Text = "Calendario Diario"

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendarioPrensa(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltroCalendario(Me.FechaDesde, Me.FechaHasta)
        F.ShowDialog()
        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If




        'lee los datos
        Spots = S.ReporteCalendarioDiarioPrensa(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.CargarFacotres()

        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        Me.SemanaNatural = F.SemanaNatural

        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla

        'carga el template
        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevopr.vts")
        'Else ' es ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoArepr.vts")
        'End If

        'AG 26/03/2013 Codigo Anterior +++++++++++++++++++++++++++++++++++++
        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoArepr.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoProxpr.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevopr.vts")
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++	
        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\caldiarionuevoArepr.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\caldiarionuevoProxpr.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\caldiarionuevopr.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\caldiarionuevoFwdpr.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\caldiarionuevoSclpr.vts") 'AG Unificacon 08/06/2015
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\caldiarionuevoHsppr.vts") 'AG Unificacon 08/06/2015
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendario(14)
        'Aguzzardi ------------------------
        MaxCol = MaxCol - 1
        '-------------------------------------

        'devuelve un array de objetos Registro Calendario con los datos finales del reporte
        Dim Datos As ArrayList = Me.AplicarCorteControlPrensa()

        Fila = 14

        Me.CargarEncebezadoCalendarioDiarioPrensa(Spots, IDPlaza, Plaza)

        Fila = 12

        'carga los datos
        Me.CargarDatosCalendarioPrensa(Datos, 1, MaxCol, Fila, "Cadena", "Producto-Material", _
        "Concepto-Seccion", "Tamanio", "AnchoxAlto", "TarifaBruta", "D1", "D2", "D3", "D4", "D5", "TarifaNeta")

        Fila += 2

        Me.CargarPromediosFinalesPrensa(Fila, 7, 11, 12)
        Me.CargarSpotsSemanaPrensa(Fila, MaxCol, 14)
        Me.CargarTotalesFinalesPrensa(Fila, MaxCol)
        Me.CargarTotalesTRPsPR(Fila, MaxCol, 14)
        Me.CargarTotalesGeneralesPrensa(Fila, MaxCol, F.CalcularIVA, F.CalcularIVANetoAgencia)

        FOne.Grilla.MaxRow = Fila + 8
        FOne.Grilla.MaxCol -= 1

        FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow


        FOne.Grilla.PrintRowHeading = False
        FOne.Grilla.PrintGridLines = False
        FOne.Grilla.PrintLandscape = True

        FOne.Grilla.PrintLeftMargin = 0.8
        FOne.Grilla.PrintRightMargin = 0.2
        FOne.Grilla.PrintBottomMargin = 0.2
        FOne.Grilla.PrintHeaderMargin = 0.5
        FOne.Grilla.PrintTopMargin = 0.5
        FOne.Grilla.PrintHeader = ""
        FOne.Grilla.PrintHCenter = False
        FOne.Grilla.PrintScaleFitHPages = 1
        FOne.Grilla.PrintScale = 100

        FOne.Grilla.SetSelection(1, 1, 1, 1)

        Me.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' Setea los valores faltantes en el DataTable
    ''' </summary>
    ''' <param name="dtValues">DataTable con los valores</param>
    ''' <remarks></remarks>
    Private Function SetValuesReporteCalendarioExterior(ByVal dtValues As DataTable)
        ''Warning: Jsperk - Se estan seteando valores para pruebas.
        Try
            For index As Integer = 0 To dtValues.Rows.Count - 1
                dtValues.Rows(index)("CADENA") = dtValues.Rows(index)("CADENA").ToString
                dtValues.Rows(index)("Producto-Material") = dtValues.Rows(index)("Producto-Material").ToString
                dtValues.Rows(index)("Provincia-Poblacion") = dtValues.Rows(index)("Provincia-Poblacion").ToString
            Next
        Catch ex As Exception

        End Try
    End Function

    Public Sub CargarReporteCalendarioDiarioExterior(ByVal IDPlaza As Integer, ByVal Plaza As String)
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle

        Me.Text = "Calendario Diario"

        'guarda la 1er fecha y la ultima de la alternativa
        Spots = S.FechasCalendarioExterior(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("La Alternativa No Tiene Spots", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Dim F As New frmFiltroCalendario(Me.FechaDesde, Me.FechaHasta)
        F.ShowDialog()
        If F.Cancelar Then
            Me.Cursor = Cursors.Default
            Me.Cancelar = True
            Exit Sub
        End If



        'lee los datos
        Spots = S.ReporteCalendarioDiarioExterior(Activo.IDCampaña, Activo.IDAlternativa, _
        F.FechaDesde, F.FechaHasta, IDPlaza)

        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.CargarFacotres()

        Me.SetValuesReporteCalendarioExterior(Spots)

        Me.FechaDesde = F.FechaDesde
        Me.FechaHasta = F.FechaHasta

        Me.SemanaNatural = F.SemanaNatural

        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla

        'carga el template
        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevovp.vts")
        'Else ' es ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoArevp.vts")
        'End If

        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoArevp.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoProxvp.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevovp.vts")
        'End If

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++	
        If Activo.IDCompaniaMMS = 36 Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\caldiarionuevoArevp.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 38 Then
            FOne.CargarTemplate(Application.StartupPath & "\PRX\caldiarionuevoProxvp.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 35 Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\caldiarionuevovp.vts") 'AG Unificacon 25/03/2013
        ElseIf Activo.IDCompaniaMMS = 41 Then
            FOne.CargarTemplate(Application.StartupPath & "\FWD\caldiarionuevoFwdvp.vts") 'AG Unificacon 19/01/2015
        ElseIf Activo.IDCompaniaMMS = 42 Then
            FOne.CargarTemplate(Application.StartupPath & "\SCL\caldiarionuevoSclvp.vts") 'AG Unificacon 08/06/2015
        ElseIf Activo.IDCompaniaMMS = 39 Then
            FOne.CargarTemplate(Application.StartupPath & "\HSP\caldiarionuevoHspvp.vts") 'AG Unificacon 08/06/2015
        End If

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendario(13)
        'AGuzzardi ---------------------
        MaxCol = MaxCol - 1
        '---------------------------------
        'devuelve un array de objetos Registro Calendario con los datos finales del reporte
        Dim Datos As ArrayList = Me.AplicarCorteControlExterior()

        Fila = 14

        Me.CargarEncebezadoCalendarioDiarioPrensa(Spots, IDPlaza, Plaza)

        Fila = 12

        'carga los datos
        Me.CargarDatosCalendarioExterior(Datos, 1, MaxCol, Fila, "Cadena", "Producto-Material", _
        "Formato", "Provincia-Población", "TarifaBruta", "D1", "D2", "D3", "D4", "D5", "TarifaNeta")

        Fila += 2

        Me.CargarPromediosFinalesExterior(Fila, 7, 10, 11)
        Me.CargarSpotsSemanaExterior(Fila, MaxCol, 13)
        Me.CargarTotalesFinalesPrensa(Fila, MaxCol)
        Me.CargarTotalesTRPsPR(Fila, MaxCol, 13)
        Me.CargarTotalesGeneralesPrensa(Fila, MaxCol, F.CalcularIVA, F.CalcularIVANetoAgencia)

        FOne.Grilla.MaxRow = Fila + 8
        FOne.Grilla.MaxCol -= 1

        FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow


        FOne.Grilla.PrintRowHeading = False
        FOne.Grilla.PrintGridLines = False
        FOne.Grilla.PrintLandscape = True

        FOne.Grilla.PrintLeftMargin = 0.8
        FOne.Grilla.PrintRightMargin = 0.2
        FOne.Grilla.PrintBottomMargin = 0.2
        FOne.Grilla.PrintHeaderMargin = 0.5
        FOne.Grilla.PrintTopMargin = 0.5
        FOne.Grilla.PrintHeader = ""
        FOne.Grilla.PrintHCenter = False
        FOne.Grilla.PrintScaleFitHPages = 1
        FOne.Grilla.PrintScale = 100

        FOne.Grilla.SetSelection(1, 1, 1, 1)

        Me.Cursor = Cursors.Default
    End Sub
    Public Sub CargarReporteCalendarioDiarioLog()
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle
        Me.Text = "Calendario Diario Original"

        'guarda la 1er fecha y la ultima de la alternativa
        'lee los datos
        Spots = S.ReporteCalendarioDiarioLog(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)

        'si no hay spots cancela el reporte y sale
        If Spots.Rows.Count = 0 Then
            Mensajes.Mensaje("El Ejercicio nunca estubo en estado Final.", TipoMensaje.Informacion)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default

            Exit Sub
        End If

        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")
        Me.FechaHasta = Spots.Select("", "f_spot desc")(0).Item("f_spot")

        Me.SemanaNatural = True
        Dim Fila, MaxCol As Integer

        FOne.Grilla = Me.Grilla

        'carga el template
        'AG Codigo anterior +++++++++++++++++++++++++++
        'FOne.CargarTemplate(Application.StartupPath & "\calendariolog.vts")
        '++++++++++++++++++++++++++++++++++++++++

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        FOne.CargarTemplate(Application.StartupPath & "\Comun\calendariolog.vts") 'AG Unificacon 25/03/2013
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'If Activo.Empresa.IndexOf("are") = -1 Then 'ES MPG

        'Else ' es ARENA
        '    FOne.CargarTemplate(Application.StartupPath & "\calendariolog.vts")
        'End If

        'If Activo.Empresa.IndexOf("are") > -1 Then 'ES ARENA
        'FOne.CargarTemplate(Application.StartupPath & "\caldiarionuevoArevp.vts")
        'ElseIf Activo.Empresa.IndexOf("prx") > -1 Then 'ES PROXIMIA 
        '    FOne.CargarTemplate(Application.StartupPath & "\calendariolog.vts")
        'Else 'ES MPG
        '    FOne.CargarTemplate(Application.StartupPath & "\calendariolog.vts")
        'End If

        'agrega las columnas del calendario, devuelve la ultima columna
        MaxCol = Me.CargarColumnasCalendario(16)

        'devuelve un array de objetos Registro Calendario con los datos finales del reporte
        Dim Datos As ArrayList = Me.AplicarCorteControl(True, False)

        Fila = 14
        Me.CargarEncebezadoCalendarioDiarioLog(Spots)

        Fila = 12

        'carga los datos
        Me.CargarDatosCalendarioLog(Datos, 1, MaxCol, Fila, "Cadena", _
        "Hora", "Programa", "TarifaBruta", "D1", "D2", "D3", "D4", "D5", "TarifaNeta", "Dur", _
        "CostoSpot", "Rating", "CPR")

        Fila += 2

        Me.CargarPromediosFinales(Fila, 6, 10, 14)
        Me.CargarSpotsSemana(Fila, MaxCol, 16)
        Me.CargarTotalesFinales(Fila, MaxCol)
        Me.CargarTotalesTRPS(Fila, MaxCol, 16)
        Me.CargarTotalesGenerales(Fila, MaxCol, False, False)
        Me.CargarEtiquetasTemasLog(Fila + 2, 3, Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio)

        FOne.Grilla.MaxRow = Fila + 8
        FOne.Grilla.MaxCol -= 1

        FOne.Grilla.PrintArea = "$A$1:$" & Me.GetLetras(FOne.Grilla.MaxCol) & "$" & FOne.Grilla.MaxRow


        FOne.Grilla.PrintRowHeading = False
        FOne.Grilla.PrintGridLines = False
        FOne.Grilla.PrintLandscape = True

        FOne.Grilla.PrintLeftMargin = 0.8
        FOne.Grilla.PrintRightMargin = 0.2
        FOne.Grilla.PrintBottomMargin = 0.2
        FOne.Grilla.PrintHeaderMargin = 0.5
        FOne.Grilla.PrintTopMargin = 0.5
        FOne.Grilla.PrintHeader = ""
        FOne.Grilla.PrintHCenter = False
        FOne.Grilla.PrintScaleFitHPages = 1
        FOne.Grilla.PrintScale = 100

        FOne.Grilla.SetSelection(1, 1, 1, 1)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CargarEncebezadoResumenPrograma(ByVal Spots As DataTable, ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ColSegundaColumna As Integer = 8

        'empresa / cliente
        FOne.CargarDato(Activo.Cliente, 1, 2)
        FOne.CargarDato(Activo.Cliente, 2, 2)

        'producto
        '*** se carga en CargarEtiquetasTemas

        'campaña
        FOne.CargarDato(Activo.Campaña, 4, 2)

        'periodo
        FOne.CargarDato(FechaDesde & " al " & FechaHasta, 5, 2)

        'fuente
        FOne.CargarDato("Procesamiento Ibope (Nautilus), Sigeme", 3, ColSegundaColumna, True)
        FOne.CambiarFuente(3, ColSegundaColumna, "Arial", 11, True, False)

        'plaza
        FOne.CargarDato(Plaza, 6, 2, True)

        'FOne.CargarDato("Alternativa:", 7, 1)
        'FOne.CambiarFuente(7, 1, True)
        FOne.CargarDato(mDescripcion, 7, 2)

        Dim S As New Spots_detalle
        Dim Dt As DataTable
        Dim Separador As String = " / "

        Dt = S.ObtenerCalendarioEncabezado(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Activo.IDMedio, FechaDesde, FechaHasta)

        For Each Dr As DataRow In Dt.Rows
            If Dr Is Dt.Rows(Dt.Rows.Count - 1) Then
                Separador = ""
            End If

            'target
            FOne.CargarDato(Dr("target") & Separador, 1, ColSegundaColumna, True)
            FOne.CambiarFuente(1, ColSegundaColumna, "Arial", 11, True, False)

            'periodo de medicion
            FOne.CargarDato(Dr("f_inicio_aud") & " al " & Dr("f_fin_aud") & IIf(Separador = " / ", " * ", ""), 4, ColSegundaColumna, True)

            'tipo rating
            Select Case Dr("tipo_rating").ToString.ToLower
                Case "p"
                    TipoRating = "Programa"
                Case "t"
                    TipoRating = "Tanda"
                Case "f"
                    TipoRating = "Franja"
            End Select

            FOne.CargarDato(Dr("tipo_soporte") & " - " & TipoRating & Separador, 5, ColSegundaColumna, True)
            FOne.CambiarFuente(5, ColSegundaColumna, "Arial", 11, True, False)
        Next
    End Sub

    Private Sub CargarEncebezadoCalendarioDiario(ByVal Spots As DataTable, ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ColSegundaColumna As Integer = 11

        'empresa / cliente
        FOne.CargarDato(Activo.Cliente, 1, 2)
        FOne.CargarDato(Activo.Cliente, 2, 2)

        'producto
        '*** se carga en CargarEtiquetasTemas

        'campaña
        FOne.CargarDato(Activo.Campaña, 4, 2)

        'periodo
        FOne.CargarDato(FechaDesde & " al " & FechaHasta, 5, 2)

        'plaza
        FOne.CargarDato(Plaza, 6, 2, True)
        'FOne.CargarDato("Alternativa:", 7, 1)
        'FOne.CambiarFuente(7, 1, True)
        FOne.CargarDato(mDescripcion, 7, 2)

        Dim S As New Spots_detalle
        Dim Dt As DataTable
        Dim Separador As String = " / "

        Dt = S.ObtenerCalendarioEncabezado(Activo.IDCampaña, Activo.IDAlternativa, IDPlaza, Activo.IDMedio, FechaDesde, FechaHasta)

        For Each Dr As DataRow In Dt.Rows
            If Dr Is Dt.Rows(Dt.Rows.Count - 1) Then
                Separador = ""
            End If

            'target
            FOne.CargarDato(Dr("target") & Separador, 1, ColSegundaColumna, True)

            'periodo de medicion
            FOne.CargarDato(Dr("f_inicio_aud") & " al " & Dr("f_fin_aud") & IIf(Separador = " / ", " * ", ""), 4, ColSegundaColumna, True)

            'tipo rating
            Select Case Dr("tipo_rating").ToString.ToLower
                Case "p"
                    TipoRating = "Programa"
                Case "t"
                    TipoRating = "Tanda"
                Case "f"
                    TipoRating = "Franja"
            End Select

            FOne.CargarDato(Dr("tipo_soporte") & " - " & TipoRating & Separador, 5, ColSegundaColumna, True)
        Next
    End Sub

    Private Sub CargarEncebezadoCalendarioDiarioLog(ByVal Spots As DataTable)
        Dim ColSegundaColumna As Integer = 10

        'empresa / cliente
        FOne.CargarDato(Activo.Cliente, 1, 2)
        FOne.CargarDato(Activo.Cliente, 2, 2)

        'campaña
        FOne.CargarDato(Activo.Campaña, 4, 2)

        'periodo
        FOne.CargarDato(FechaDesde & " al " & FechaHasta, 5, 2)

        Dim Plaza As String

        Dim S As New Spots_detalle
        Dim Dt As DataTable
        Dim Separador As String = " / "

        For Each Dr As DataRow In Spots.Rows
            Separador = ""

            Plaza = Dr("plaza")

            'target
            FOne.CargarDato(Dr("target") & Separador, 1, ColSegundaColumna, True)

            'periodo de medicion
            FOne.CargarDato(Dr("f_inicio_aud") & " al " & Dr("f_fin_aud") & IIf(Separador = " / ", " * ", ""), 4, ColSegundaColumna, True)

            'tipo rating
            Select Case Dr("tipo_rating").ToString.ToLower
                Case "p"
                    TipoRating = "Programa"
                Case "t"
                    TipoRating = "Tanda"
                Case "f"
                    TipoRating = "Franja"
            End Select

            FOne.CargarDato(Dr("tipo_soporte") & " - " & TipoRating & Separador, 5, ColSegundaColumna, True)
            Exit For
        Next

        'plaza
        FOne.CargarDato(Plaza, 6, 2, True)
        'FOne.CargarDato("Alternativa:", 7, 1)
        'FOne.CambiarFuente(7, 1, True)
        'FOne.CargarDato(mDescripcion, 7, 2)
    End Sub

    Private Sub CargarEncebezadoCalendarioDiarioInternet(ByVal Spots As DataTable, ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ColSegundaColumna As Integer = 11

        'cliente / marca
        FOne.CargarDato(Activo.Cliente, 1, 2)
        If Activo.Producto IsNot Nothing Then
            FOne.CargarDato(Activo.Producto, 2, 2)
        End If
        'producto
        'no se carga para prensa
        '*** se carga en CargarEtiquetasTemas

        'campaña
        FOne.CargarDato(Activo.Campaña, 4, 2)

        'periodo
        'FOne.CargarDato(FechaDesde & " al " & FechaHasta, 5, 2)

        'plaza
        'FOne.CargarDato(Plaza, 5, 2, True)
        'descripción alternativa
        'FOne.CargarDato(mDescripcion, 6, 2)

    End Sub
    Private Sub CargarEncebezadoCalendarioDiarioPrensa(ByVal Spots As DataTable, ByVal IDPlaza As Integer, ByVal Plaza As String)
        Dim ColSegundaColumna As Integer = 11

        'empresa / cliente
        FOne.CargarDato(Activo.Cliente, 1, 2)
        FOne.CargarDato(Activo.Cliente, 2, 2)

        'producto
        'no se carga para prensa
        '*** se carga en CargarEtiquetasTemas

        'campaña
        FOne.CargarDato(Activo.Campaña, 3, 2)

        'periodo
        FOne.CargarDato(FechaDesde & " al " & FechaHasta, 4, 2)

        'plaza
        FOne.CargarDato(Plaza, 5, 2, True)
        'descripción alternativa
        FOne.CargarDato(mDescripcion, 6, 2)

    End Sub
    Private Function CargarEtiquetasTemas(ByVal Fila As Integer, ByVal Col As Integer, ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer) As Integer
        Dim A As New Alternativas
        Dim Temas As DataTable
        Dim Texto As String
        Dim Productos As String
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        A.Id_campania = IDCampaña
        A.Id_alternativa = IDAlternativa

        Temas = A.ObtenerTemasGuardados

        For i As Integer = 0 To Temas.Rows.Count - 1
            Texto = "[" & Temas.Rows(i)("id_tema") & "] " & _
            Temas.Rows(i)("descripcion") & " " & _
            Temas.Rows(i)("duracion") & """ " & _
            Temas.Rows(i)("material")

            FOne.CargarDato(Texto, Fila + i, Col)

            Productos &= Temas.Rows(i)("descripcion") & ", "
        Next

        'productos del encabezado
        Productos = Productos.Substring(0, Productos.Length - 2)
        FOne.CargarDato(Productos, 3, 2)

        Return Temas.Rows.Count
    End Function

    Private Sub CargarEtiquetasTemasLog(ByVal Fila As Integer, ByVal Col As Integer, ByVal IDCampaña As Integer, ByVal IDSistema As Integer, ByVal IDEjercicio As Integer)
        Dim Texto As String
        Dim Productos As String
        Dim i As Integer = 0
        Dim ArrayTema As New ArrayList
        For Each drSpots As DataRow In Spots.Select("", "Id_Tema")
            If Not ArrayTema.Contains(drSpots("id_tema")) Then
                ArrayTema.Add(drSpots("id_tema"))
                Texto = "[" & drSpots("id_tema") & "] " & _
                drSpots("descripcion") & " " & _
                drSpots("duracion") & """ " & _
                drSpots("material")

                FOne.CargarDato(Texto, Fila + i, Col)

                Productos &= drSpots("descripcion") & ", "
                i += 1
            End If
        Next

        'productos del encabezado
        Productos = Productos.Substring(0, Productos.Length - 2)
        FOne.CargarDato(Productos, 3, 2)
    End Sub

    Public Sub CargarTotalesTemas(ByVal SoporteDias As SoporteDias, ByVal Fila As Integer, ByVal ColumnaInicio As Integer)
        Dim columna As Integer = ColumnaInicio
        Dim sumatoria As Integer = 0
        Dim contador As Integer = 0
        Dim columnaInicial As Integer = 0
        Dim columnaFinal As Integer = 0
        Dim mes As Integer = 0
        Dim total As Double = 0
        Dim dias As Integer = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)
        mes = Me.FechaDesde.Month
        columnaInicial = columna + contador

        While contador <= dias
            While mes = Me.FechaDesde.AddDays(contador).Month And contador <= dias
                Dim temas As List(Of DiaCalendario) = SoporteDias.Dias.FindAll(Function(x) x.Fecha = Me.FechaDesde.AddDays(contador))
                total += temas.Select(Function(x) x.Valor).Sum()
                columnaFinal = columna + contador
                contador += 1
            End While
            FOne.CargarDato("$ " & Format(total, "#,##0.00"), Fila, columnaInicial, True)
            FOne.Grilla.SetSelection(Fila, columnaInicial, Fila, columnaFinal)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))
            columnaInicial = columna + contador
            mes = Me.FechaDesde.AddDays(contador).Month
            total = 0
        End While

    End Sub

    Public Sub CargarDatosCalendario(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal ColumnaInicio As Integer, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer
        Dim SoporteDias As New SoporteDias

        'guarda la 1er fecha y la ultima de la alternativa
        'Me.FechaDesde = Spots.Select("", "f_spot asc, hora asc, Dur asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Cadena

        SoporteDias.Soporte = CadenaAnterior

        For Each R As RegistroCalendario In Datos
            If CadenaAnterior <> R.Cadena Then
                FOne.DuplicarFila(Fila, Col, MaxCol)

                Me.CargarTotalesCadena(CadenaAnterior, Fila, MaxCol)

                Me.CargarTotalesTemas(SoporteDias, Fila, ColumnaInicio)

                Fila += 1
                FOne.DuplicarFila(Fila, Col, MaxCol)
                Fila += 1

                CadenaAnterior = R.Cadena

                SoporteDias.Soporte = CadenaAnterior
                SoporteDias.Dias.Clear()

            End If

            FOne.DuplicarFila(Fila, Col, MaxCol)

            Me.CargarEnGrilla(R, Fila, MaxCol)

            For Each D As DiaCalendario In R.Dias
                Try
                    'guarda cuantas columnas hay desde la 1er fecha del calendario a la que se esta iterando
                    ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                    'carga el tema en la grilla
                    If Not Me.CalendarioConNumeros Then
                        FOne.CargarDato(D.Tema, Fila, ColumnaInicio + ColCal, True)
                    Else
                        FOne.CargarDato(1, Fila, ColumnaInicio + ColCal, True)
                    End If
                Catch e As Exception

                End Try
            Next

            Texto = ""

            Fila += 1

            SoporteDias.Dias.AddRange(R.Dias.Cast(Of DiaCalendario).ToList())
        Next

        Me.CargarTotalesCadena(CadenaAnterior, Fila, MaxCol)
        Me.CargarTotalesTemas(SoporteDias, Fila, ColumnaInicio)
    End Sub
    Public Sub CargarDatosCalendarioLog(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer

        'guarda la 1er fecha y la ultima de la alternativa
        Me.FechaDesde = Spots.Select("", "f_spot asc, hora asc, Dur asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Cadena

        For Each R As RegistroCalendario In Datos
            If CadenaAnterior <> R.Cadena Then
                FOne.DuplicarFila(Fila, Col, MaxCol)

                Me.CargarTotalesCadenaLog(CadenaAnterior, Fila, MaxCol)

                Fila += 1
                FOne.DuplicarFila(Fila, Col, MaxCol)
                Fila += 1

                CadenaAnterior = R.Cadena
            End If

            FOne.DuplicarFila(Fila, Col, MaxCol)

            Me.CargarEnGrillaLog(R, Fila, MaxCol)

            For Each D As DiaCalendario In R.Dias
                'guarda cuantas columnas hay desde la 1er fecha del calendario a la que se esta iterando
                ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                'carga el tema en la grilla
                FOne.CargarDato(D.Tema, Fila, 16 + ColCal, True)
            Next

            Texto = ""

            Fila += 1
        Next

        Me.CargarTotalesCadenaLog(CadenaAnterior, Fila, MaxCol)
    End Sub

    Public Sub CargarDatosCalendarioInternet(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer
        Dim spots As Integer
        Dim DiaAnterior As Integer
        Dim CuentaSpots As String
        Dim ColActual As Integer = -1
        Dim FechaSiguiente As DateTime
        Dim TotalTarifaCorteControl As Double
        Dim TotalServicioAgenciaDisplay As Double
        Dim TotalServicioAgenciaVideoOnline = 0
        Dim TotalServicioAgenciaSEM As Double
        Dim TotalServicioAgenciaGestiónInventarioDinámico As Double
        Dim TotalServicioAdservingTrackeoArtemis As Double

        HashServicioAgenciaImporte = New Hashtable
        HashServicioAgenciaTipo = New Hashtable

        'guarda la 1er fecha y la ultima de la alternativa
        'Me.FechaDesde = Spots.Select("", "f_spot asc, hora asc, Dur asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Proveedor
        TotalTarifaCorteControl = 0
        TotalServicioAgenciaDisplay = 0
        TotalServicioAgenciaVideoOnline = 0
        TotalServicioAgenciaSEM = 0
        TotalServicioAgenciaGestiónInventarioDinámico = 0
        TotalServicioAdservingTrackeoArtemis = 0

        For Each R As RegistroCalendario In Datos
            If R.Proveedor <> "" And CadenaAnterior <> R.Proveedor Then
                'If HashServicioAgenciaImporte.Contains(R.TipoSoporte) Then
                '    HashServicioAgenciaImporte.Item(R.TipoSoporte) += R.Impsag
                'Else
                '    HashServicioAgenciaImporte.Add(R.TipoSoporte, R.Impsag)
                'End If
                'If Not HashServicioAgenciaTipo.Contains(R.TipoSoporte) Then
                '    HashServicioAgenciaTipo.Add(R.TipoSoporte, R.Porsag)
                'End If
                FOne.DuplicarFila(Fila, Col, MaxCol + 14)
                Me.CargarTotalesCadenaInternet(CadenaAnterior, Fila, MaxCol)
                'Me.CargarTotalesCadenaPrensa(CadenaAnterior, Fila, MaxCol)
                'FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 12 + i)
                Fila += 1
                CadenaAnterior = R.Proveedor
                TotalTarifaCorteControl = 0
                TotalServicioAgenciaDisplay = 0
                TotalServicioAgenciaVideoOnline = 0
                TotalServicioAgenciaSEM = 0
                TotalServicioAgenciaGestiónInventarioDinámico = 0
                TotalServicioAdservingTrackeoArtemis = 0


            End If
            TotalTarifaCorteControl += R.Neto
            FOne.DuplicarFila(Fila, Col, MaxCol + 14)

            Me.CargarEnGrillaInternet(R, Fila, MaxCol)

            Dim H As New Hashtable
            Dim IndiceDia As Integer = 0
            Dim UltimoDia As Boolean = False

            For Each D As DiaCalendario In R.Dias

                ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                'cuenta las fechas para sumar la cantidad de spots por día
                If H.Contains(D.Fecha) Then
                    H.Item(D.Fecha) += 1
                Else
                    H.Add(D.Fecha, 1)
                End If

                If (R.Dias.Count - 1) > IndiceDia Then
                    FechaSiguiente = Convert.ToDateTime(R.Dias(IndiceDia + 1).Fecha)
                Else
                    UltimoDia = True
                End If
                If FechaSiguiente.Date <> D.Fecha OrElse UltimoDia Then
                    For Each T As Date In H.Keys
                        Dim cellFormat As VCF150.F1CellFormat
                        Grilla.SetSelection(9, 1, 9, 1)
                        cellFormat = Grilla.GetCellFormat()
                        Grilla.SetSelection(Fila, 8 + ColCal, Fila, 8 + ColCal)
                        Grilla.SetCellFormat(cellFormat)
                        FOne.CargarDato("", Fila, 8 + ColCal, True)
                    Next
                    H.Clear()
                    UltimoDia = False
                End If
                IndiceDia += 1
            Next
            Texto = ""

            Fila += 1


            'Dim cellFormat As VCF150.F1CellFormat
            'Grilla.InsertRange(FilaDesde, Col, FilaHasta, Col, VCF150.F1ShiftTypeConstants.F1ShiftHorizontal)

            'If Grilla.MaxCol < 256 Then
            '    Grilla.MaxCol += 1 'amplia las columnas de la grilla
            'End If

            ''pega el formato copiado en la nueva columna, fila por fila
            'For nroFila As Integer = FilaDesde To FilaHasta
            '    Grilla.SetSelection(nroFila, Col + 1, nroFila, Col + 1)
            '    cellFormat = Grilla.GetCellFormat()

            '    Grilla.SetSelection(nroFila, Col, nroFila, Col)
            '    Grilla.SetCellFormat(cellFormat)
            'Next



        Next

        Me.CargarTotalesCadenaInternet(CadenaAnterior, Fila, MaxCol)
        'FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 12 + i)
    End Sub
    Public Sub CargarDatosCalendarioPrensa(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer
        Dim spots As Integer
        Dim DiaAnterior As Integer
        Dim CuentaSpots As String
        Dim ColActual As Integer = -1
        Dim FechaSiguiente As DateTime
        Dim TotalTarifaCorteControl As Double

        'guarda la 1er fecha y la ultima de la alternativa
        'Me.FechaDesde = Spots.Select("", "f_spot asc, hora asc, Dur asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Cadena
        TotalTarifaCorteControl = 0

        For Each R As RegistroCalendario In Datos
            If CadenaAnterior <> R.Cadena Then

                FOne.DuplicarFila(Fila, Col, MaxCol)
                Me.CargarTotalesCadenaPrensa(CadenaAnterior, Fila, MaxCol)
                FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 12 + i)
                Fila += 1
                CadenaAnterior = R.Cadena
                TotalTarifaCorteControl = 0
            End If
            TotalTarifaCorteControl += R.TarifaNeta
            FOne.DuplicarFila(Fila, Col, MaxCol)

            Me.CargarEnGrillaPrensa(R, Fila, MaxCol)

            Dim H As New Hashtable
            Dim IndiceDia As Integer = 0
            Dim UltimoDia As Boolean = False

            For Each D As DiaCalendarioPrensa In R.Dias

                ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                'cuenta las fechas para sumar la cantidad de spots por día
                If H.Contains(D.Fecha) Then
                    H.Item(D.Fecha) += 1
                Else
                    H.Add(D.Fecha, 1)
                End If

                If (R.Dias.Count - 1) > IndiceDia Then
                    FechaSiguiente = Convert.ToDateTime(R.Dias(IndiceDia + 1).Fecha)
                Else
                    UltimoDia = True
                End If
                If FechaSiguiente.Date <> D.Fecha OrElse UltimoDia Then
                    For Each T As Date In H.Keys
                        FOne.CargarDato(H.Item(T), Fila, 14 + ColCal, True)
                    Next
                    H.Clear()
                    UltimoDia = False
                End If
                IndiceDia += 1

            Next

            Texto = ""

            Fila += 1
        Next

        Me.CargarTotalesCadenaPrensa(CadenaAnterior, Fila, MaxCol)
        FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 12 + i)
    End Sub
    Public Sub CargarDatosCalendarioExterior(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer
        Dim spots As Integer
        Dim DiaAnterior As Integer
        Dim CuentaSpots As String
        Dim ColActual As Integer = -1
        Dim FechaSiguiente As DateTime
        Dim TotalTarifaCorteControl As Double

        'guarda la 1er fecha y la ultima de la alternativa
        'Me.FechaDesde = Spots.Select("", "f_spot asc, hora asc, Dur asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Cadena
        TotalTarifaCorteControl = 0
        For Each R As RegistroCalendario In Datos

            If CadenaAnterior <> R.Cadena Then

                FOne.DuplicarFila(Fila, Col, MaxCol)
                Me.CargarTotalesCadenaPrensa(CadenaAnterior, Fila, MaxCol)
                FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 11 + i)
                Fila += 1
                CadenaAnterior = R.Cadena
                TotalTarifaCorteControl = 0
            End If
            TotalTarifaCorteControl += R.TarifaNeta
            FOne.DuplicarFila(Fila, Col, MaxCol)

            Me.CargarEnGrillaExterior(R, Fila, MaxCol)

            Dim H As New Hashtable
            Dim IndiceDia As Integer = 0
            Dim UltimoDia As Boolean = False

            For Each D As DiaCalendarioPrensa In R.Dias

                ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                'cuenta las fechas para sumar la cantidad de spots por día
                If H.Contains(D.Fecha) Then
                    H.Item(D.Fecha) += 1
                Else
                    H.Add(D.Fecha, 1)
                End If

                If (R.Dias.Count - 1) > IndiceDia Then
                    FechaSiguiente = Convert.ToDateTime(R.Dias(IndiceDia + 1).Fecha)
                Else
                    UltimoDia = True
                End If
                If FechaSiguiente.Date <> D.Fecha OrElse UltimoDia Then
                    For Each T As Date In H.Keys
                        FOne.CargarDato(H.Item(T), Fila, 13 + ColCal, True)
                    Next
                    H.Clear()
                    UltimoDia = False
                End If
                IndiceDia += 1

            Next

            Texto = ""

            Fila += 1
        Next

        Me.CargarTotalesCadenaPrensa(CadenaAnterior, Fila, MaxCol)
        FOne.CargarDato(Math.Round(TotalTarifaCorteControl, 2), Fila, 11 + i)
    End Sub

    Public Sub CargarDatosResumenPrograma(ByVal Datos As ArrayList, ByRef Col As Integer, ByVal MaxCol As Integer, ByRef Fila As Integer, ByVal MostrarTotalNeto As Boolean, ByVal AgruparLetrasTemas As Boolean, ByVal ParamArray Campos() As String)
        Dim i As Integer
        Dim CadenaAnterior As String
        Dim Texto As String
        Dim ColCal As Integer
        Dim FechaSiguiente As DateTime

        'guarda la 1er fecha y la ultima de la alternativa
        Me.FechaDesde = Spots.Select("", "f_spot asc")(0).Item("f_spot")

        CadenaAnterior = DirectCast(Datos(0), RegistroCalendario).Cadena

        For Each R As RegistroCalendario In Datos
            If CadenaAnterior <> R.Cadena Then
                FOne.DuplicarFila(Fila, Col, MaxCol)

                Me.CargarTotalesCadenaResumenPrograma(CadenaAnterior, Fila, MaxCol, MostrarTotalNeto)

                Fila += 1
                FOne.DuplicarFila(Fila, Col, MaxCol)
                Fila += 1

                CadenaAnterior = R.Cadena
            End If

            FOne.DuplicarFila(Fila, Col, MaxCol)

            Me.CargarEnGrillaResumenPrograma(R, Fila, MaxCol, MostrarTotalNeto)
            Dim H As New Hashtable
            Dim IndiceDia As Integer = 0
            Dim UltimoDia As Boolean = False
            For Each D As DiaCalendario In R.Dias
                'guarda cuantas columnas hay desde la 1er fecha del calendario a la que se esta iterando
                ColCal = DateDiff(DateInterval.Day, Me.FechaDesde, D.Fecha)

                If AgruparLetrasTemas Then
                    'cuenta las letras para agrupar los temas. Ej.: "3A"
                    If H.Contains(D.Tema) Then
                        H.Item(D.Tema) += 1
                    Else
                        H.Add(D.Tema, 1)
                    End If

                    If (R.Dias.Count - 1) > IndiceDia Then
                        FechaSiguiente = Convert.ToDateTime(R.Dias(IndiceDia + 1).Fecha)
                    Else
                        UltimoDia = True
                    End If
                    If FechaSiguiente.Date <> D.Fecha OrElse UltimoDia Then
                        For Each T As Char In H.Keys
                            FOne.CargarDato(H.Item(T) & T & " ", Fila, 6 + ColCal, True)
                        Next
                        H.Clear()
                        UltimoDia = False
                    End If
                    IndiceDia += 1
                Else
                    'carga todas las letras: "AAA"
                    FOne.CargarDato(D.Tema, Fila, 6 + ColCal, True)
                End If

            Next

            'ingresa los temas agrupados
            'If AgruparLetrasTemas Then
            '    For Each T As Char In H.Keys
            '        FOne.CargarDato(H.Item(T) & T & " ", Fila, 6 + ColCal, True)
            '    Next
            'End If

            Texto = ""
            Fila += 1
        Next

        Me.CargarTotalesCadenaResumenPrograma(CadenaAnterior, Fila, MaxCol, MostrarTotalNeto)
    End Sub

    Private Sub CargarTotalesCadenaResumenPrograma(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer, ByVal MostrarTotalNeto As Boolean)
        Dim Total As Decimal
        Dim Calculos As New ArrayList

        'totales antes del calendario
        If TipoRating = "Tanda" Then
            Total = Spots.Compute("avg(RatingTanda)", "Cadena='" & Cadena & "'")
        Else
            Total = Spots.Compute("avg(RatingPrograma)", "Cadena='" & Cadena & "'")
        End If

        FOne.CargarDato(Math.Round(Total, 2), Fila, 4)

        '** Total despues del calendario

        'total de spots
        Total = Spots.Compute("count(id_tema)", "Cadena='" & Cadena & "'")
        FOne.CargarDato(Total, Fila, MaxCol - 2)

        'total rating
        Total = Spots.Compute("sum(rating)", "Cadena='" & Cadena & "'")
        FOne.CargarDato(Math.Round(Total, 2), Fila, MaxCol - 1)

        'total neto
        If MostrarTotalNeto Then
            Total = Spots.Compute("sum(TarifaNeta)", "Cadena='" & Cadena & "'")
            FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, MaxCol)
        End If

        FOne.CargarDato("Total Cadena", Fila, MaxCol - 5)

        FOne.Grilla.SetSelection(Fila, 1, Fila, MaxCol)
        FOne.Grilla.FontBold = True

        FOne.CargarBorde(Fila, 1, MaxCol, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeMedio, -1)
    End Sub

    Private Sub CargarTotalesGenerales(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal CalcularIVA As Boolean, ByVal IVASobreNetoAgencia As Boolean)
        Dim Total As Decimal
        Dim Texto As String
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        'CPR a 1 segundo

        Dim neto As Single
        Dim durprom As Single
        Dim trp As Single

        neto = Me.TotalNetoFinal
        trp = SpotsData.Compute("sum(rating)", "")
        durprom = SpotsData.Compute("sum(dur)", "") / SpotsData.Compute("count(rating)", "")

        'AG 23/01/2013 +++++++++++++++++++++++++++++++++++++++++++++++++
        If neto > 0 Then
            'CalculoCPRDuracionPromedioCompleto()
            Total = Valores.CastNulo(CalculoCPRDuracionPromedioCompleto().Rows(0)("CPRPromFinalPauta"))
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'Total = Valores.CastNulo(Spots.Compute("sum(tarifaneta)", "") / Spots.Compute("sum(rating)", "") / Spots.Compute("avg(dur)", ""))
        'Total = Valores.CastNulo(neto / trp / durprom) AG CALCULO ANTERIOR DE CPR 

        FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila + 2, MaxCol)

        'total neto
        Total = Math.Round(CDec(FOne.LeerDato(Fila, MaxCol)), 2)

        FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila + 3, MaxCol)

        'servicio de agencia
        Dim C As New Clientes
        Dim T As Decimal
        Dim AuxI As Decimal

        C.Id_cliente = Activo.IDCliente
        C.BuscarPorId()

        'AGuzzardi SAG ---------------------------------------------------------
        C.BuscarPorIDSAG()
        '----------------------------------------------------------------------------

        Texto = "S.A. " & C.Servicio_agencia & "%"
        FOne.CargarDato(Texto, Fila + 4, MaxCol - 2)

        Texto = (Total * C.Servicio_agencia / 100).ToString("0.00")
        T = Texto
        FOne.CargarDato(Format(CDec(Texto), "#,##0.00"), Fila + 4, MaxCol)

        'subtotal
        Texto = (Total + CDec(T)).ToString("0.00")
        T = Texto
        FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 5, MaxCol)

        'IVA
        If CalcularIVA Then
            Dim IVA As Decimal

            'AGuzzardi Siempre es el 21 % -----------------------------------------------------
            IVA = 21 'C.BuscarImpuesto(Activo.IDCliente).Rows(0).Item("porcentaje")
            '-------------------------------------------------------------------------------------------

            'label IVA xx%
            Texto = "IVA " & IVA & "%"
            FOne.CargarDato(Texto, Fila + 6, MaxCol - 2)

            If IVASobreNetoAgencia Then
                '*** iva sobre el neto + servicio de agencia

                'lee el subtotal
                'Total = CDec(FOne.LeerDato(Fila + 5, MaxCol))
                'T = Total

                'importe del IVA
                Texto = (Total * IVA / 100).ToString("0.00")
                AuxI = Texto
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 6, MaxCol)
            Else
                '*** iva sobre el servicio de agencia

                'lee el servicio de agencia
                Total = CDec(FOne.LeerDato(Fila + 4, MaxCol))

                'importe del IVA
                Texto = (Total * IVA / 100).ToString("0.00")
                AuxI = Texto
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 6, MaxCol)
            End If

            'total a pagar
            'Texto = CDec(T + CDec(FOne.LeerDato(Fila + 6, MaxCol)))
            Texto = CDec(T + AuxI)
            FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 7, MaxCol)
        Else
            'borra el label "IVA"
            FOne.CargarDato("", Fila + 6, MaxCol - 2)

            'total a pagar
            Texto = CDec(FOne.LeerDato(Fila + 5, MaxCol)).ToString("0.00")
            FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 7, MaxCol)
        End If
    End Sub

#Region "Calculos Nuevo CPR y Duracion Promedio - AG 23/01/2013 Calendario y Resumen Economico"

    Private Function CalculoCPRDuracionPromedioCompleto() As DataTable

        Dim DtResultado As DataTable
        Dim DtTemasCalculos As DataTable = ArmarDtCPRPromedio(1)
        Dim DtTemasAplicados As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
        Dim Dr As DataRow
        Dim FilaNueva As DataRow
        Dim DurPromedioFinal, CprPromedioFinal As Single
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        For Each Dr In DtTemasAplicados.Rows
            FilaNueva = DtTemasCalculos.NewRow
            FilaNueva("id_tema") = Dr("id_tema")
            FilaNueva("Duracion") = Dr("Dur")
            FilaNueva("TotalGrps") = 0
            FilaNueva("SumaTotalInversion") = 0
            FilaNueva("CantTemas") = 0
            FilaNueva("CalculoPonderado1") = 0
            FilaNueva("CalculoPonderado2") = 0
            DtTemasCalculos.Rows.Add(FilaNueva)
        Next

        For Each Dr In DtTemasCalculos.Rows
            If Not Me.CalendarioConNumeros Then
                Dr("CantTemas") = SpotsData.Select(" ID_TEMA='" & Dr("ID_TEMA") & "'").Count
                Dr("TotalGrps") = SpotsData.Compute("Sum(rating)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / SpotsData.Compute("sum(rating)", "")
                Dr("CalculoPonderado2") = Dr("CalculoPonderado1") * Dr("Duracion")
            Else
                Dr("CantTemas") = SpotsData.Compute("SUM(cantidad)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("TotalGrps") = SpotsData.Compute("Sum(ratingprogramatotal)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / SpotsData.Compute("sum(ratingprogramatotal)", "")
                Dr("CalculoPonderado2") = Dr("CalculoPonderado1") * Dr("Duracion")
            End If
        Next

        DtResultado = ArmarDtCPRPromedio(2)

        'Realizo el calculo final del CPR y Duracion
        DurPromedioFinal = DtTemasCalculos.Compute("sum(CalculoPonderado2)", "")
        ' GW 13/07/2014 si es infinito la conversion a int falla
        If Not DurPromedioFinal.IsNaN(DurPromedioFinal) Then

            Dim TEjercicio As Integer
            Dim ObSistema As New Sistemas

            TEjercicio = ObSistema.ObtenerTipoEjercicio(Activo.IDCampaña, Activo.IDSistema)

            'AG 10/07/2014 =====================================================================================================
            'CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
            'AG 21/07/2014 ====================================================================================================
            If TEjercicio = Activo.TipoEjercicio.Estandar Then
                CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
            ElseIf TEjercicio = Activo.TipoEjercicio.CPunto Then
                If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then ' Cliente Claro
                    CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
                Else
                    CprPromedioFinal = CInt(Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal)
                End If
            End If
            '====================================================================================================================
            'If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then ' Cliente Claro
            '    CprPromedioFinal = Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
            'Else
            '    CprPromedioFinal = CInt(Me.TotalNetoFinal / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal)
            'End If
            '=========================================================================================================================
        End If

        FilaNueva = DtResultado.NewRow
        FilaNueva("DurPromFinalPauta") = DurPromedioFinal
        FilaNueva("CPRPromFinalPauta") = CprPromedioFinal
        DtResultado.Rows.Add(FilaNueva)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Return DtResultado

    End Function

    Private Function CalculoCPRPromedioXCadena(ByVal Cadena As String, ByVal TotalInsercionXsoporte As Decimal) As DataTable

        Dim DtResultado As DataTable
        Dim DtCadenaDatos As DataTable = ArmarDtCPRPromedio(3)
        Dim DtCadena As DataTable = Spots.DefaultView.ToTable(True, "Cadena")
        Dim DtTemas As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
        Dim Dr As DataRow
        Dim DrTemas As DataRow
        Dim FilaNueva As DataRow
        Dim DurPromedioSoporte, CprPromedioSoporte As Single
        Dim DrGrps() As DataRow

        For Each Dr In DtCadena.Rows
            For Each DrTemas In DtTemas.Rows
                FilaNueva = DtCadenaDatos.NewRow
                FilaNueva("Cadena") = Dr("Cadena")
                FilaNueva("TotalGrps") = Spots.Compute("Sum(rating)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                If FilaNueva("TotalGrps").ToString() <> "" Then
                    FilaNueva("id_tema") = DrTemas("ID_TEMA")
                    FilaNueva("Duracion") = DrTemas("Dur")
                    FilaNueva("CantTemas") = Spots.Compute("Count(ID_TEMA)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                    FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / Spots.Compute("Sum(rating)", "Cadena='" & Dr("Cadena") & "'")
                    FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * DrTemas("Dur")
                    DtCadenaDatos.Rows.Add(FilaNueva)
                End If
            Next
        Next


        DtResultado = ArmarDtCPRPromedio(4)
        Dim TotalnetoSoporte As Decimal
        'Dim DtInversionNeta As DataTable = Spots.DefaultView.ToTable(True, "CostoSpot", "Cadena", "Dur", "Rating", "Dia", "cprprog", "hora")

        'Realizo el calculo final del CPR y Duracion
        TotalnetoSoporte = Spots.Compute("Sum(CostoSpot)", "Cadena='" & Cadena & "'")

        DurPromedioSoporte = DtCadenaDatos.Compute("Sum(CalculoPonderado2)", "Cadena='" & Cadena & "'")
        CprPromedioSoporte = TotalInsercionXsoporte / DtCadenaDatos.Compute("Sum(TotalGrps)", "Cadena='" & Cadena & "'") / DurPromedioSoporte

        FilaNueva = DtResultado.NewRow
        FilaNueva("Cadena") = Cadena
        FilaNueva("DurPromCadena") = Math.Round(DurPromedioSoporte, 2)
        FilaNueva("CPRPromCadena") = Math.Round(CprPromedioSoporte, 2)

        DtResultado.Rows.Add(FilaNueva)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Return DtResultado

    End Function

    Private Function CalculoCPRPromedioXCadenaResumenEconomico(ByVal DtDatos As DataTable) As DataTable

        Dim DtResultadoCadena As DataTable
        Dim DtCadenaDatos As DataTable = ArmarDtCPRPromedio(3)
        Dim DtCadena As DataTable = Spots.DefaultView.ToTable(True, "Cadena")
        Dim DtTemas As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
        Dim Dr As DataRow
        Dim DrTemas As DataRow
        Dim FilaNueva As DataRow
        Dim DurPromedioSoporte, CprPromedioSoporte As Single
        Dim DrGrps() As DataRow
        Dim DrDatos As DataRow

        For Each Dr In DtCadena.Rows
            For Each DrTemas In DtTemas.Rows
                FilaNueva = DtCadenaDatos.NewRow
                FilaNueva("Cadena") = Dr("Cadena")
                If ControlReporteCPR = True Then
                    FilaNueva("TotalGrps") = Spots.Compute("Sum(ratingtanda)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                Else
                    FilaNueva("TotalGrps") = Spots.Compute("Sum(ratingprograma)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                End If
                If FilaNueva("TotalGrps").ToString() <> "" Then
                    FilaNueva("id_tema") = DrTemas("ID_TEMA")
                    FilaNueva("Duracion") = DrTemas("Dur")
                    FilaNueva("CantTemas") = Spots.Compute("Count(ID_TEMA)", "Cadena='" & Dr("Cadena") & "' AND ID_TEMA='" & DrTemas("ID_TEMA") & "'")
                    If ControlReporteCPR = True Then
                        FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / Spots.Compute("Sum(ratingtanda)", "Cadena='" & Dr("Cadena") & "'")
                    Else
                        FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / Spots.Compute("Sum(ratingprograma)", "Cadena='" & Dr("Cadena") & "'")
                    End If
                    FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * DrTemas("Dur")
                    DtCadenaDatos.Rows.Add(FilaNueva)
                End If
            Next
        Next
        '===============================

        DtResultadoCadena = ArmarDtCPRPromedio(5)

        For Each Dr In DtCadena.Rows
            FilaNueva = DtResultadoCadena.NewRow
            FilaNueva("Cadena") = Dr("Cadena")
            FilaNueva("id_tema") = ""
            FilaNueva("Duracion") = ""
            FilaNueva("TotalGrps") = DtCadenaDatos.Compute("Sum(TotalGrps)", "Cadena='" & Dr("Cadena").ToString() & "'")
            FilaNueva("SumaTotalInversion") = Spots.Compute("Sum(CostoSpot)", "Cadena='" & Dr("Cadena").ToString() & "'")
            FilaNueva("CantTemas") = DtCadenaDatos.Compute("Sum(CantTemas)", "Cadena='" & Dr("Cadena").ToString() & "'")
            FilaNueva("CalculoPonderado1") = DtCadenaDatos.Compute("Sum(CalculoPonderado1)", "Cadena='" & Dr("Cadena").ToString() & "'")
            FilaNueva("CalculoPonderado2") = 0
            FilaNueva("DurPromCadena") = DtCadenaDatos.Compute("Sum(CalculoPonderado2)", "Cadena='" & Dr("Cadena").ToString() & "'")
            If FilaNueva("TotalGrps") > 0 Then
                FilaNueva("CPRPromCadena") = FilaNueva("SumaTotalInversion") / FilaNueva("TotalGrps") / FilaNueva("DurPromCadena")
            Else
                FilaNueva("CPRPromCadena") = 0
            End If

            DtResultadoCadena.Rows.Add(FilaNueva)
        Next

        '===========
        Dim DrCadena() As DataRow

        For Each DrDatos In DtDatos.Rows
            DrCadena = DtResultadoCadena.Select("Cadena='" & DrDatos("Soporte").ToString() & "'")
            If DrCadena.Length > 0 Then
                DrDatos("CPR") = Math.Round(DrCadena(0)("CPRPromCadena"), 2)
                DrDatos("TRP") = DrCadena(0)("TotalGrps")
            End If
        Next



        Return DtDatos

    End Function

    Private Function CalculoCPRPromedioXTemaResumenEconomico(ByVal DtDatos As DataTable) As DataTable

        Dim DtTemaDatos As DataTable = ArmarDtCPRPromedio(6)
        Dim DtCadena As DataTable = Me.Spots.DefaultView.ToTable(True, "Cadena")
        Dim DtTema As DataTable = Me.Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
        Dim DrTemas As DataRow
        Dim DrIdDema() As DataRow
        Dim Tema As String
        Dim FilaNueva As DataRow
        Dim i As Integer
        Dim DrDatos As DataRow

        For Each DrTemas In DtTema.Rows
            DrIdDema = DtTema.Select("Id_tema='" & DrTemas("id_Tema").ToString().Split("-")(0).Trim & "'")
            If DrIdDema.Length > 0 Then
                For i = 0 To DrIdDema.Length - 1
                    FilaNueva = DtTemaDatos.NewRow
                    If ControlReporteCPR = True Then
                        FilaNueva("TotalGrps") = Spots.Compute("Sum(ratingtanda)", "ID_TEMA='" & DrIdDema(0)("id_tema").ToString & "'")
                    Else
                        FilaNueva("TotalGrps") = Spots.Compute("Sum(ratingprograma)", "ID_TEMA='" & DrIdDema(0)("id_tema").ToString & "'")
                    End If
                    If FilaNueva("TotalGrps").ToString <> "" Then
                        FilaNueva("id_tema") = DrIdDema(0)("Id_tema").ToString
                        FilaNueva("Duracion") = DtTema.Select("ID_TEMA='" & FilaNueva("id_tema") & "'")(0)("Dur")
                        FilaNueva("CantTemas") = Spots.Compute("Count(ID_TEMA)", "ID_TEMA='" & FilaNueva("id_tema") & "'")
                        If ControlReporteCPR = True Then
                            FilaNueva("CalculoPonderado1") = FilaNueva.Item("TotalGrps") / Spots.Compute("Sum(ratingtanda)", "")
                        Else
                            FilaNueva("CalculoPonderado1") = FilaNueva.Item("TotalGrps") / Spots.Compute("Sum(ratingprograma)", "")
                        End If
                        FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * FilaNueva("Duracion")
                        If FilaNueva("TotalGrps") > 0 Then
                            FilaNueva("CPRPromCadena") = Spots.Compute("Sum(CostoSpot)", "ID_TEMA='" & FilaNueva("id_tema") & "'") / FilaNueva("TotalGrps") / FilaNueva("Duracion")
                        Else
                            FilaNueva("CPRPromCadena") = 0
                        End If
                    End If
                    DtTemaDatos.Rows.Add(FilaNueva)
                Next
            End If
        Next


        Dim Rows() As DataRow

        For Each DrDatos In DtDatos.Rows
            Rows = DtTemaDatos.Select("Id_tema='" & DrDatos("Tema").ToString().Split("-")(0).Trim & "'")
            If Rows.Length > 0 Then
                DrDatos("CPR") = Math.Round(Rows(0)("CPRPromCadena"), 2)
                DrDatos("TRP") = Rows(0)("TotalGrps")
            End If
        Next


        Return DtDatos

    End Function

    Private Function CalculoCPRPromedioXDiaResumenEconomico(ByVal DtDatos As DataTable, ByVal DtDatosCPR As DataTable) As DataTable

        Dim DtDiaCPR As DataTable = ArmarDtCPRPromedio(8)
        Dim DtDias As DataTable = DtDatosCPR.DefaultView.ToTable(True, "Dia")
        Dim DtTemas As DataTable = DtDatosCPR.DefaultView.ToTable(True, "ID_TEMA", "Segundos")
        Dim DrDia As DataRow
        Dim FilaNueva As DataRow
        Dim DrTema As DataRow


        For Each DrDia In DtDias.Rows
            For Each DrTema In DtTemas.Rows
                FilaNueva = DtDiaCPR.NewRow
                FilaNueva("TotalGrps") = DtDatosCPR.Compute("Sum(TRP)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Dia='" & DrDia("Dia").ToString.Trim & "'")
                If FilaNueva("TotalGrps").ToString <> "" Then
                    FilaNueva("id_tema") = DrTema("Id_tema")
                    FilaNueva("Duracion") = DrTema("Segundos")
                    FilaNueva("SumaTotalInversion") = DtDatosCPR.Compute("Sum(neto)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Dia='" & DrDia("Dia").ToString.Trim & "'")
                    FilaNueva("CantTemas") = DtDatosCPR.Compute("Count(ID_TEMA)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Dia='" & DrDia("Dia").ToString.Trim & "'")
                    FilaNueva("Dia") = DrDia("Dia")
                    FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / DtDatosCPR.Compute("Sum(TRP)", "Dia='" & DrDia("Dia").ToString.Trim & "'")
                    FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * FilaNueva("Duracion")
                    DtDiaCPR.Rows.Add(FilaNueva)
                End If
            Next
        Next

        Dim DtClonadoDiaCPR As New DataTable
        DtClonadoDiaCPR = DtDiaCPR.Clone

        For Each DrDia In DtDias.Rows
            FilaNueva = DtClonadoDiaCPR.NewRow
            FilaNueva("Dia") = DrDia("Dia")
            FilaNueva("TotalGrps") = DtDiaCPR.Compute("Sum(TotalGrps)", "Dia='" & DrDia("Dia") & "'")
            FilaNueva("CantTemas") = DtDiaCPR.Compute("Sum(CantTemas)", "Dia='" & DrDia("Dia") & "'")
            FilaNueva("SumaTotalInversion") = DtDiaCPR.Compute("Sum(SumaTotalInversion)", "Dia='" & DrDia("Dia") & "'")
            FilaNueva("CalculoPonderado1") = DtDiaCPR.Compute("Sum(CalculoPonderado1)", "Dia='" & DrDia("Dia") & "'")
            FilaNueva("CalculoPonderado2") = DtDiaCPR.Compute("Sum(CalculoPonderado2)", "Dia='" & DrDia("Dia") & "'")
            FilaNueva("DurPromDia") = FilaNueva("CalculoPonderado2")
            If FilaNueva("TotalGrps") > 0 Then
                FilaNueva("CPRPromDia") = FilaNueva("SumaTotalInversion") / FilaNueva("TotalGrps") / FilaNueva("DurPromDia")
            Else
                FilaNueva("CPRPromDia") = 0
            End If
            DtClonadoDiaCPR.Rows.Add(FilaNueva)
        Next

        Dim DrResultado() As DataRow
        Dim DrDatos As DataRow

        For Each DrDatos In DtDatos.Rows
            DrResultado = DtClonadoDiaCPR.Select("Dia='" & DrDatos("Dia").ToString() & "'")
            If DrResultado.Length > 0 Then
                DrDatos("CPR") = Math.Round(DrResultado(0)("CPRPromDia"), 2)
                DrDatos("TRP") = DrResultado(0)("TotalGrps")
            End If
        Next

        Return DtDatos

    End Function

    Private Function CalculoCPRPromedioXSemanaResumenEconomico(ByVal DtDatos As DataTable, ByVal DtDatosCPR As DataTable) As DataTable

        Dim DtSemanaCPR As DataTable = ArmarDtCPRPromedio(7)
        Dim DtSemanas As DataTable = DtDatosCPR.DefaultView.ToTable(True, "Semana")
        Dim DtTemas As DataTable = DtDatosCPR.DefaultView.ToTable(True, "ID_TEMA", "Segundos")
        Dim DrSemana As DataRow
        Dim FilaNueva As DataRow
        Dim DrTema As DataRow

        For Each DrSemana In DtSemanas.Rows
            For Each DrTema In DtTemas.Rows
                FilaNueva = DtSemanaCPR.NewRow
                FilaNueva("TotalGrps") = DtDatosCPR.Compute("Sum(TRP)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Semana='" & DrSemana("Semana").ToString.Trim & "'")
                If FilaNueva("TotalGrps").ToString <> "" Then
                    FilaNueva("id_tema") = DrTema("Id_tema")
                    FilaNueva("Duracion") = DrTema("Segundos")
                    FilaNueva("SumaTotalInversion") = DtDatosCPR.Compute("Sum(neto)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Semana='" & DrSemana("Semana").ToString.Trim & "'")
                    FilaNueva("CantTemas") = DtDatosCPR.Compute("Count(ID_TEMA)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Semana='" & DrSemana("Semana").ToString.Trim & "'")
                    FilaNueva("Semana") = DrSemana("Semana")
                    FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / DtDatosCPR.Compute("Sum(TRP)", "Semana='" & DrSemana("Semana").ToString.Trim & "'")
                    FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * FilaNueva("Duracion")
                    DtSemanaCPR.Rows.Add(FilaNueva)
                End If
            Next
        Next

        Dim DtClonadoSemanaCPR As New DataTable
        DtClonadoSemanaCPR = DtSemanaCPR.Clone

        For Each DrSemana In DtSemanas.Rows
            FilaNueva = DtClonadoSemanaCPR.NewRow
            FilaNueva("Semana") = DrSemana("Semana")
            FilaNueva("TotalGrps") = DtSemanaCPR.Compute("Sum(TotalGrps)", "Semana='" & DrSemana("Semana") & "'")
            FilaNueva("CantTemas") = DtSemanaCPR.Compute("Sum(CantTemas)", "Semana='" & DrSemana("Semana") & "'")
            FilaNueva("SumaTotalInversion") = DtSemanaCPR.Compute("Sum(SumaTotalInversion)", "Semana='" & DrSemana("Semana") & "'")
            FilaNueva("CalculoPonderado1") = DtSemanaCPR.Compute("Sum(CalculoPonderado1)", "Semana='" & DrSemana("Semana") & "'")
            FilaNueva("CalculoPonderado2") = DtSemanaCPR.Compute("Sum(CalculoPonderado2)", "Semana='" & DrSemana("Semana") & "'")
            FilaNueva("DurPromSemana") = FilaNueva("CalculoPonderado2")
            If FilaNueva("TotalGrps") > 0 Then
                FilaNueva("CPRPromSemana") = FilaNueva("SumaTotalInversion") / FilaNueva("TotalGrps") / FilaNueva("DurPromSemana")
            Else
                FilaNueva("CPRPromSemana") = 0
            End If

            DtClonadoSemanaCPR.Rows.Add(FilaNueva)
        Next

        Dim DrResultado() As DataRow
        Dim DrDatos As DataRow

        For Each DrDatos In DtDatos.Rows
            DrResultado = DtClonadoSemanaCPR.Select("Semana='" & DrDatos("Semana").ToString() & "'")
            If DrResultado.Length > 0 Then
                DrDatos("CPR") = Math.Round(DrResultado(0)("CPRPromSemana"), 2)
                DrDatos("TRP") = DrResultado(0)("TotalGrps")
            End If
        Next

        Return DtDatos

    End Function

    Private Function CalculoCPRPromedioXFranjaResumenEconomico(ByVal DtDatos As DataTable, ByVal DtDatosCPR As DataTable) As DataTable

        Dim DtFranjaCPR As DataTable = ArmarDtCPRPromedio(10)
        Dim DtSopFranja As DataTable = DtDatosCPR.DefaultView.ToTable(True, "Soporte")
        Dim DtTemas As DataTable = DtDatosCPR.DefaultView.ToTable(True, "ID_TEMA", "Segundos")
        Dim DrSopFranja As DataRow
        Dim FilaNueva As DataRow
        Dim DrTema As DataRow

        For Each DrSopFranja In DtSopFranja.Rows
            For Each DrTema In DtTemas.Rows
                FilaNueva = DtFranjaCPR.NewRow
                FilaNueva("TotalGrps") = DtDatosCPR.Compute("Sum(TRP)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Soporte='" & DrSopFranja("Soporte").ToString.Trim & "'")
                If FilaNueva("TotalGrps").ToString <> "" Then
                    FilaNueva("id_tema") = DrTema("Id_tema")
                    FilaNueva("Duracion") = DrTema("Segundos")
                    FilaNueva("SumaTotalInversion") = DtDatosCPR.Compute("Sum(neto)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Soporte='" & DrSopFranja("Soporte").ToString.Trim & "'")
                    FilaNueva("CantTemas") = DtDatosCPR.Compute("Count(ID_TEMA)", "ID_TEMA = '" & DrTema("ID_TEMA") & "' AND Soporte='" & DrSopFranja("Soporte").ToString.Trim & "'")
                    FilaNueva("Soporte") = DrSopFranja("Soporte")
                    FilaNueva("CalculoPonderado1") = FilaNueva("TotalGrps") / DtDatosCPR.Compute("Sum(TRP)", "Soporte='" & DrSopFranja("Soporte").ToString.Trim & "'")
                    FilaNueva("CalculoPonderado2") = FilaNueva("CalculoPonderado1") * FilaNueva("Duracion")
                    DtFranjaCPR.Rows.Add(FilaNueva)
                End If
            Next
        Next

        Dim DtClonadoFranjaCPR As New DataTable
        DtClonadoFranjaCPR = DtFranjaCPR.Clone

        For Each DrSopFranja In DtSopFranja.Rows
            FilaNueva = DtClonadoFranjaCPR.NewRow
            FilaNueva("Soporte") = DrSopFranja("Soporte")
            FilaNueva("TotalGrps") = DtFranjaCPR.Compute("Sum(TotalGrps)", "Soporte='" & DrSopFranja("Soporte") & "'")
            FilaNueva("CantTemas") = DtFranjaCPR.Compute("Sum(CantTemas)", "Soporte='" & DrSopFranja("Soporte") & "'")
            FilaNueva("SumaTotalInversion") = DtFranjaCPR.Compute("Sum(SumaTotalInversion)", "Soporte='" & DrSopFranja("Soporte") & "'")
            FilaNueva("CalculoPonderado1") = DtFranjaCPR.Compute("Sum(CalculoPonderado1)", "Soporte='" & DrSopFranja("Soporte") & "'")
            FilaNueva("CalculoPonderado2") = DtFranjaCPR.Compute("Sum(CalculoPonderado2)", "Soporte='" & DrSopFranja("Soporte") & "'")
            FilaNueva("DurPromFraSoporte") = FilaNueva("CalculoPonderado2")
            If FilaNueva("TotalGrps") > 0 Then
                FilaNueva("CPRPromFraSoporte") = FilaNueva("SumaTotalInversion") / FilaNueva("TotalGrps") / FilaNueva("DurPromFraSoporte")
            Else
                FilaNueva("CPRPromFraSoporte") = 0
            End If

            DtClonadoFranjaCPR.Rows.Add(FilaNueva)
        Next

        Dim DrResultado() As DataRow
        Dim DrDatos As DataRow

        For Each DrDatos In DtDatos.Rows
            DrResultado = DtClonadoFranjaCPR.Select("Soporte='" & DrDatos("Soporte").ToString() & "'")
            If DrResultado.Length > 0 Then
                DrDatos("CPR") = Math.Round(DrResultado(0)("CPRPromFraSoporte"), 2)
                DrDatos("TRP") = DrResultado(0)("TotalGrps")
            End If
        Next

        Return DtDatos

    End Function

    Private Function ArmarDtCPRPromedio(ByVal TipoDt As Integer)

        Dim DtDatos As New DataTable
        Select Case TipoDt
            Case 1
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
            Case 2
                DtDatos.Columns.Add("DurPromFinalPauta", GetType(Single))
                DtDatos.Columns.Add("CPRPromFinalPauta", GetType(Single))
            Case 3
                DtDatos.Columns.Add("Cadena", GetType(String))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
            Case 4
                DtDatos.Columns.Add("Cadena", GetType(String))
                DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
            Case 5
                DtDatos.Columns.Add("Cadena", GetType(String))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
            Case 6
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromCadena", GetType(Single))
                DtDatos.Columns.Add("CPRPromCadena", GetType(Single))
            Case 7
                DtDatos.Columns.Add("Semana", GetType(Integer))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromSemana", GetType(Single))
                DtDatos.Columns.Add("CPRPromSemana", GetType(Single))
            Case 8
                DtDatos.Columns.Add("Dia", GetType(String))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromDia", GetType(Single))
                DtDatos.Columns.Add("CPRPromDia", GetType(Single))
            Case 9
                DtDatos.Columns.Add("Franja", GetType(Integer))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromFranja", GetType(Single))
                DtDatos.Columns.Add("CPRPromFranja", GetType(Single))
            Case 10
                DtDatos.Columns.Add("Soporte", GetType(String))
                DtDatos.Columns.Add("id_tema", GetType(String))
                DtDatos.Columns.Add("Duracion", GetType(String))
                DtDatos.Columns.Add("TotalGrps", GetType(Single))
                DtDatos.Columns.Add("SumaTotalInversion", GetType(Single))
                DtDatos.Columns.Add("CantTemas", GetType(Integer))
                DtDatos.Columns.Add("CalculoPonderado1", GetType(Single))
                DtDatos.Columns.Add("CalculoPonderado2", GetType(Single))
                DtDatos.Columns.Add("DurPromFraSoporte", GetType(Single))
                DtDatos.Columns.Add("CPRPromFraSoporte", GetType(Single))
        End Select
        Return DtDatos

    End Function

    Private Function CalculoCPRPromedioCompletoResumenEconomico() As Single

        Dim DtResultado As DataTable
        Dim DtTemasCalculos As DataTable = ArmarDtCPRPromedio(1)
        Dim DtTemasAplicados As DataTable = Spots.DefaultView.ToTable(True, "ID_TEMA", "dur")
        Dim DtInversion As DataTable = Spots.DefaultView.ToTable(True, "costospot")
        Dim Dr As DataRow
        Dim FilaNueva As DataRow
        Dim DurPromedioFinal, CprPromedioFinal As Single

        For Each Dr In DtTemasAplicados.Rows
            FilaNueva = DtTemasCalculos.NewRow
            FilaNueva("id_tema") = Dr("id_tema")
            FilaNueva("Duracion") = Dr("Dur")
            FilaNueva("TotalGrps") = 0
            FilaNueva("SumaTotalInversion") = 0
            FilaNueva("CantTemas") = 0
            FilaNueva("CalculoPonderado1") = 0
            FilaNueva("CalculoPonderado2") = 0
            DtTemasCalculos.Rows.Add(FilaNueva)
        Next

        For Each Dr In DtTemasCalculos.Rows
            Dr("CantTemas") = Spots.Select(" ID_TEMA='" & Dr("ID_TEMA") & "'").Count

            If ControlReporteCPR = True Then
                Dr("TotalGrps") = Spots.Compute("Sum(ratingtanda)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / Spots.Compute("sum(ratingtanda)", "")
            Else
                Dr("TotalGrps") = Spots.Compute("Sum(ratingprograma)", "ID_TEMA='" & Dr("ID_TEMA") & "'")
                Dr("CalculoPonderado1") = Dr("TotalGrps") / Spots.Compute("sum(ratingprograma)", "")
            End If
            Dr("CalculoPonderado2") = Dr("CalculoPonderado1") * Dr("Duracion")
        Next

        DtResultado = ArmarDtCPRPromedio(2)

        'Realizo el calculo final del CPR y Duracion
        DurPromedioFinal = DtTemasCalculos.Compute("sum(CalculoPonderado2)", "")

        CprPromedioFinal = Spots.Compute("sum(costospot)", "") / DtTemasCalculos.Compute("sum(TotalGrps)", "") / DurPromedioFinal
        FilaNueva = DtResultado.NewRow
        FilaNueva("DurPromFinalPauta") = DurPromedioFinal
        FilaNueva("CPRPromFinalPauta") = Math.Round(CprPromedioFinal, 2)
        DtResultado.Rows.Add(FilaNueva)

        Return DtResultado.Rows(0)("CPRPromFinalPauta")

    End Function

#End Region

    Private Sub CargarTotalesGeneralesPrensa(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal CalcularIVA As Boolean, ByVal IVASobreNetoAgencia As Boolean)
        Dim Total As Decimal
        Dim Texto As String

        'CPR a 1 segundo

        Dim neto As Single
        'Dim durprom As Single
        'Dim trp As Single

        neto = Me.TotalNetoFinal
        'trp = Spots.Compute("sum(rating)", "")
        'durprom = Spots.Compute("sum(dur)", "") / Spots.Compute("count(rating)", "")

        'Total = Valores.CastNulo(Spots.Compute("sum(tarifaneta)", "") / Spots.Compute("sum(rating)", "") / Spots.Compute("avg(dur)", ""))
        'Total = Valores.CastNulo(neto)
        'FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila + 2, MaxCol)

        'total neto
        Total = Math.Round(CDec(FOne.LeerDato(Fila, MaxCol)), 2)
        FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila + 2, MaxCol)

        'servicio de agencia
        Dim C As New Clientes
        Dim T As Decimal
        Dim AuxI As Decimal

        C.Id_cliente = Activo.IDCliente
        C.BuscarPorId()

        'AGuzzardi SAG ----------------------------------------------
        C.BuscarPorIDSAG()
        '-----------------------------------------------------------------

        Texto = "S.A. " & C.Servicio_agencia & "%"
        FOne.CargarDato(Texto, Fila + 3, MaxCol - 1)

        Texto = (Total * C.Servicio_agencia / 100).ToString("0.00")
        T = Texto
        FOne.CargarDato(Format(CDec(Texto), "#,##0.00"), Fila + 3, MaxCol)

        'subtotal
        Texto = (Total + CDec(T)).ToString("0.00")
        T = Texto
        FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 4, MaxCol)

        'IVA
        If CalcularIVA Then
            Dim IVA As Decimal
            'AGuzzardi IVA Siempre sea lo que traida el porcenteje es 21 % ----------------
            IVA = 21 'C.BuscarImpuesto(Activo.IDCliente).Rows(0).Item("porcentaje")
            '------------------------------------------------------------------------------------------------
            'label IVA xx%
            Texto = "IVA " & IVA & "%"
            FOne.CargarDato(Texto, Fila + 5, MaxCol - 2)

            If IVASobreNetoAgencia Then
                '*** iva sobre el neto + servicio de agencia

                'lee el subtotal
                'Total = CDec(FOne.LeerDato(Fila + 5, MaxCol))
                'T = Total

                'importe del IVA
                Texto = (Total * IVA / 100).ToString("0.00")
                AuxI = Texto
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 5, MaxCol)
            Else
                '*** iva sobre el servicio de agencia

                'lee el servicio de agencia
                Total = CDec(FOne.LeerDato(Fila + 3, MaxCol))

                'importe del IVA
                Texto = (Total * IVA / 100).ToString("0.00")
                AuxI = Texto
                FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 5, MaxCol)
            End If

            'total a pagar
            'Texto = CDec(T + CDec(FOne.LeerDato(Fila + 6, MaxCol)))
            Texto = CDec(T + AuxI)
            FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 6, MaxCol)
        Else
            'borra el label "IVA"
            FOne.CargarDato("", Fila + 5, MaxCol - 2)

            'total a pagar
            Texto = CDec(FOne.LeerDato(Fila + 4, MaxCol)).ToString("0.00")
            FOne.CargarDato("$ " & Format(CDec(Texto), "#,##0.00"), Fila + 6, MaxCol)
        End If
    End Sub
    Private Sub CargarTotalesTRPS(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal ColInicio As Integer, Optional ByVal MostrarNeto As Boolean = True)
        Dim TotalDia, TotalSemana, Total, TotalInversion As Decimal
        Dim Filas() As DataRow
        Dim Dr As DataRow
        Dim Dias, i As Integer
        Dim Texto As String
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        If TipoRating = "Tanda" Then
            Total = SpotsData.Compute("sum(ratingTanda)", "")
        Else
            Total = SpotsData.Compute("sum(ratingPrograma)", "")
        End If

        'borde de arriba y abajo
        FOne.CargarBorde(Fila + 6, ColInicio, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

        If MostrarNeto Then
            FOne.CargarBorde(Fila + 8, ColInicio, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)
        End If

        For i = 0 To Dias
            Filas = Spots.Select("f_spot='" & Me.FechaDesde.AddDays(i) & "'")

            For Each Dr In Filas
                TotalDia += Dr("rating")
                TotalSemana += Dr("rating")
                TotalInversion += Dr("TarifaNeta") * Dr("Dur")
            Next

            'trps por dia
            FOne.CargarDato(TotalDia, Fila + 4, ColInicio + i)

            TotalDia = 0

            'trps por semana, lo muestra si se termina la semana (con el domingo) o si se llega al final de la planificacion
            'If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
            If Me.SemanaNatural Then
                If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
                    If Total > 0 Then
                        Texto = Math.Round(TotalSemana, 2) & " - " & Math.Round(TotalSemana / Total * 100, 2) & "%"
                    Else
                        Texto = "Total Cero"
                    End If

                    'total Trps por semana
                    FOne.CargarDato(Texto, Fila + 6, ColInicio + i)

                    'total inversion por semana
                    If MostrarNeto Then
                        FOne.CargarDato("$ " & Format(TotalInversion, "#,##0.00"), Fila + 8, ColInicio + i)
                    End If

                    If i <> Dias Then
                        'agrega el borde a la izquieda del Total por semana y inversion por semana
                        FOne.CargarBorde(Fila + 4, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(Fila + 6, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        If MostrarNeto Then
                            FOne.CargarBorde(Fila + 8, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        End If
                    End If

                    TotalSemana = 0
                    TotalInversion = 0
                End If
            Else
                If (i + 1) Mod 7 = 0 Or i = Dias Then
                    If Total > 0 Then
                        Texto = Math.Round(TotalSemana, 2) & " - " & Math.Round(TotalSemana / Total * 100, 2) & "%"
                    Else
                        Texto = "Total Cero"
                    End If

                    'total Trps por semana
                    FOne.CargarDato(Texto, Fila + 6, ColInicio + i)

                    'total inversion por semana
                    If MostrarNeto Then
                        FOne.CargarDato("$ " & Format(TotalInversion, "#,##0.00"), Fila + 8, ColInicio + i)
                    End If

                    If i <> Dias Then
                        'agrega el borde a la izquieda del Total por semana y inversion por semana
                        FOne.CargarBorde(Fila + 4, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(Fila + 6, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        If MostrarNeto Then
                            FOne.CargarBorde(Fila + 8, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        End If
                    End If

                    TotalSemana = 0
                    TotalInversion = 0
                End If
            End If

        Next
    End Sub
    Private Sub CargarTotalesTRPsPR(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal ColInicio As Integer, Optional ByVal MostrarNeto As Boolean = True)
        Dim TotalDia, TotalSemana, Total, TotalInversion As Decimal
        Dim Filas() As DataRow
        Dim Dr As DataRow
        Dim Dias, i As Integer
        Dim Texto As String
        Dim cellFormat As VCF150.F1CellFormat

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        If MostrarNeto Then
            FOne.CargarBorde(Fila + 4, ColInicio, MaxCol - 3, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)
        End If

        For i = 0 To Dias
            Filas = Spots.Select("f_spot='" & Me.FechaDesde.AddDays(i) & "'")

            For Each Dr In Filas
                TotalInversion += Dr("TarifaNeta") '* Dr("Dur")
            Next

            'trps por semana, lo muestra si se termina la semana (con el domingo) o si se llega al final de la planificacion
            'If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
            If Me.SemanaNatural Then
                If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then

                    'total inversion por semana
                    If MostrarNeto Then

                        '''FORMATO
                        'copia el formato de la columna
                        FOne.Grilla.SetSelection(Fila + 2, ColInicio + i, Fila + 2, ColInicio + i)
                        cellFormat = FOne.Grilla.GetCellFormat()

                        'pega el formato copiado en la nueva columna
                        FOne.Grilla.SetSelection(Fila + 4, ColInicio + i, Fila + 4, ColInicio + i)
                        FOne.Grilla.SetCellFormat(cellFormat)
                        '''FORMATO

                        FOne.CargarDato("$ " & Format(TotalInversion, "#,##0.00"), Fila + 4, ColInicio + i)
                    End If

                    If i <> Dias Then
                        'agrega el borde a la izquieda del Total por semana y inversion por semana
                        If MostrarNeto Then
                            FOne.CargarBorde(Fila + 4, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        End If
                    End If

                    TotalInversion = 0
                End If
            Else
                If (i + 1) Mod 7 = 0 Or i = Dias Then

                    'total inversion por semana
                    If MostrarNeto Then

                        '''FORMATO
                        'copia el formato de la columna
                        FOne.Grilla.SetSelection(Fila + 2, ColInicio + i, Fila + 2, ColInicio + i)
                        cellFormat = FOne.Grilla.GetCellFormat()

                        'pega el formato copiado en la nueva columna
                        FOne.Grilla.SetSelection(Fila + 4, ColInicio + i, Fila + 4, ColInicio + i)
                        FOne.Grilla.SetCellFormat(cellFormat)
                        '''FORMATO

                        FOne.CargarDato("$ " & Format(TotalInversion, "#,##0.00"), Fila + 4, ColInicio + i)
                    End If

                    If i <> Dias Then
                        'agrega el borde a la izquieda del Total por semana y inversion por semana
                        If MostrarNeto Then
                            FOne.CargarBorde(Fila + 4, MaxCol - 4, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        End If
                    End If

                    TotalInversion = 0
                End If
            End If

        Next
    End Sub
    Private Sub CargarTotalesFinales(ByVal Fila As Integer, ByVal MaxCol As Integer, Optional ByVal EsResumenPrograma As Boolean = False)
        Dim Total As Decimal
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        'total Spots
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        If Not CalendarioConNumeros Then
            Total = SpotsData.Compute("sum(Factor)", "")
        Else
            Total = SpotsData.Compute("sum(cantidad)", "")
        End If

        'Total = Spots.Compute("count(id_tema)", "")

        ' Total Final de Spots
        If Not Me.CalendarioConNumeros Then
            FOne.CargarDato(Math.Round(Total), Fila, MaxCol - 2)
        Else
            Dim formulaSpots As String
            For Each formula As String In TotalesSpots
                formulaSpots += String.Concat(formula, "+")
            Next
            formulaSpots = formulaSpots.Substring(0, formulaSpots.Length - 1)
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 2, formulaSpots)
        End If

        ' Total Final de TRPs
        If Not Me.CalendarioConNumeros Then
            Total = SpotsData.Compute("sum(rating)", "")
            FOne.CargarDato(Math.Round(Total, 2), Fila, MaxCol - 1)
        Else
            Dim formulaTrps As String
            For Each formula As String In TotalesTrps
                formulaTrps += String.Concat(formula, "+")
            Next
            formulaTrps = formulaTrps.Substring(0, formulaTrps.Length - 1)
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 1, formulaTrps)
        End If

        ' Total Final de Netos
        If Not EsResumenPrograma Then
            If Not Me.CalendarioConNumeros Then
                FOne.CargarDato("$ " & Format(Me.TotalNetoFinal, "#,##0.00"), Fila, MaxCol)
            Else
                Dim formulaNetos As String
                For Each formula As String In TotalesNetos
                    formulaNetos += String.Concat(formula, "+")
                Next
                formulaNetos = formulaNetos.Substring(0, formulaNetos.Length - 1)
                FOne.Grilla.set_FormulaRC(Fila, MaxCol, formulaNetos)
            End If
        Else
            Total = SpotsData.Compute("sum(tarifaneta)", "")
            If Me.CalendarioConNumeros Then
                Total = Total / 2
            End If
            If Not Me.CalendarioConNumeros Then
                FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, MaxCol)
            Else
                Dim formulaNetos As String
                For Each formula As String In TotalesNetos
                    formulaNetos += String.Concat(formula, "+")
                Next
                formulaNetos = formulaNetos.Substring(0, formulaNetos.Length - 1)
                FOne.Grilla.set_FormulaRC(Fila, MaxCol, formulaNetos)
            End If
        End If
    End Sub
    Private Sub CargarTotalesFinalesPrensa(ByVal Fila As Integer, ByVal MaxCol As Integer, Optional ByVal EsResumenPrograma As Boolean = False)
        Dim Total As Decimal

        'total Spots
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Total = Spots.Compute("sum(Factor)", "")
        'Total = Spots.Compute("count(id_tema)", "")
        FOne.CargarDato(Math.Round(Total), Fila, MaxCol - 1)

        'total Neto
        If Not EsResumenPrograma Then
            FOne.CargarDato("$ " & Format(Me.TotalNetoFinal, "#,##0.00"), Fila, MaxCol)
        Else
            Total = Spots.Compute("sum(tarifaneta)", "")
            FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, MaxCol)
        End If
    End Sub
    Private Sub CargarSpotsSemana(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal ColInicio As Integer)
        Dim Total, TotalSemana, TotalSpots As Integer
        Dim Dias, i As Integer
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        TotalSpots = Spots.Compute("count(id_tema)", "")

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        'borde de arriba y abajo
        FOne.CargarBorde(Fila + 2, ColInicio, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

        For i = 0 To Dias
            'Total = Spots.Compute("count(id_tema)", "f_spot='" & Me.FechaDesde.AddDays(i) & "'")

            'LC 25/06/2014 Reporte calendario cantidad de avisos
            Try
                Total = Spots.Compute("sum(Factor)", "f_spot='" & Me.FechaDesde.AddDays(i) & "'")
            Catch ex As Exception
                Total = 0
            End Try

            'spots por dia
            FOne.CargarDato(Total, Fila, ColInicio + i)

            TotalSemana += Total

            'spots por semana
            'If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
            If Me.SemanaNatural Then
                If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If
            Else
                If (i + 1) Mod 7 = 0 Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If


            End If

        Next
    End Sub
    Private Sub CargarSpotsSemanaPrensa(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal ColInicio As Integer)
        Dim Total, TotalSemana, TotalSpots As Integer
        Dim Dias, i As Integer

        TotalSpots = Spots.Compute("count(id_tema)", "")

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        'borde de arriba y abajo
        FOne.CargarBorde(Fila + 2, ColInicio, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

        For i = 0 To Dias
            'LC 25/06/2014 Reporte calendario cantidad de avisos
            Try
                Total = Spots.Compute("sum(Factor)", "f_spot='" & Me.FechaDesde.AddDays(i) & "'")
            Catch ex As Exception
                Total = 0
            End Try

            'spots por dia
            FOne.CargarDato(Total, Fila, ColInicio + i)

            TotalSemana += Total

            'spots por semana
            'If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
            If Me.SemanaNatural Then
                If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If
            Else
                If (i + 1) Mod 7 = 0 Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If


            End If

        Next
    End Sub
    Private Sub CargarSpotsSemanaExterior(ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal ColInicio As Integer)
        Dim Total, TotalSemana, TotalSpots As Integer
        Dim Dias, i As Integer

        TotalSpots = Spots.Compute("count(id_tema)", "")

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        'borde de arriba y abajo
        FOne.CargarBorde(Fila + 2, ColInicio, MaxCol - 4, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.BordeFino)

        For i = 0 To Dias
            'LC 25/06/2014 Reporte calendario cantidad de avisos
            Try
                Total = Spots.Compute("sum(Factor)", "f_spot='" & Me.FechaDesde.AddDays(i) & "'")
            Catch ex As Exception
                Total = 0
            End Try

            'spots por dia
            FOne.CargarDato(Total, Fila, ColInicio + i)

            TotalSemana += Total

            'spots por semana
            'If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
            If Me.SemanaNatural Then
                If Me.FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If
            Else
                If (i + 1) Mod 7 = 0 Or i = Dias Then
                    Dim Valor As String
                    Valor = TotalSemana & " - " & Math.Round(TotalSemana / TotalSpots * 100, 2) & "%"

                    FOne.CargarDato(Valor, Fila + 2, ColInicio + i)

                    TotalSemana = 0

                    If i <> Dias Then
                        'agrega el borde a la derecha del Total
                        FOne.CargarBorde(Fila + 2, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)

                        FOne.CargarBorde(Fila, ColInicio + i, ColInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If


            End If

        Next
    End Sub
    Private Sub CargarPromediosFinales(ByVal Fila As Integer, ByVal ColLabelPromedio As Integer, ByVal ColPromedios As Integer, ByVal ColLabelTotales As Integer, Optional ByVal MostrarNeto As Boolean = True)
        Dim Total As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        If ColLabelPromedio > 0 Then
            'totales antes del calendario

            If Not CalendarioConNumeros Then
                Calculos.Add("avg(TarifaNeta)")
                Calculos.Add("avg(Dur)")
                Calculos.Add("avg(CostoSpot)")
            Else
                Calculos.Add("sum(tarifanetatotal)/sum(cantidad)")
                Calculos.Add("sum(duraciontotal)/sum(cantidad)")
                Calculos.Add("sum(costospottotal)/sum(cantidad)")
            End If

            FOne.CargarDato("Promedio", Fila, ColLabelPromedio)

            For i = 0 To Calculos.Count - 1
                'calculo
                Total = SpotsData.Compute(Calculos(i), "")
                FOne.CargarDato(Math.Round(Total, 2), Fila, ColPromedios + i)
            Next
        End If

        'Titulos de totales en el calendario
        FOne.CargarDato("Spots por Día", Fila, ColLabelTotales)
        FOne.CargarDato("Spots por Semana", Fila + 2, ColLabelTotales)
        FOne.CargarDato("Trps por Día", Fila + 4, ColLabelTotales)
        FOne.CargarDato("Trps por Semana", Fila + 6, ColLabelTotales)

        If MostrarNeto Then
            FOne.CargarDato("Inv. por Semana", Fila + 8, ColLabelTotales)
        End If
    End Sub
    Private Sub CargarPromediosFinalesPrensa(ByVal Fila As Integer, ByVal ColLabelPromedio As Integer, ByVal ColPromedios As Integer, ByVal ColLabelTotales As Integer, Optional ByVal MostrarNeto As Boolean = True)
        Dim Total As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer
        Dim cellFormat As VCF150.F1CellFormat

        'Titulos de totales en el calendario
        FOne.CargarDato("Spots por Día", Fila, ColLabelTotales)
        FOne.CargarDato("Spots por Semana", Fila + 2, ColLabelTotales)

        '''FORMATO
        'copia el formato de la columna
        FOne.Grilla.SetSelection(Fila + 2, ColLabelTotales, Fila + 2, ColLabelTotales)
        cellFormat = FOne.Grilla.GetCellFormat()

        'pega el formato copiado en la nueva columna
        FOne.Grilla.SetSelection(Fila + 4, ColLabelTotales, Fila + 4, ColLabelTotales)
        FOne.Grilla.SetCellFormat(cellFormat)
        '''FORMATO

        If MostrarNeto Then
            FOne.CargarDato("Inv. por Semana", Fila + 4, ColLabelTotales)
        End If
    End Sub
    Private Sub CargarPromediosFinalesExterior(ByVal Fila As Integer, ByVal ColLabelPromedio As Integer, ByVal ColPromedios As Integer, ByVal ColLabelTotales As Integer, Optional ByVal MostrarNeto As Boolean = True)
        Dim Total As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer
        Dim cellFormat As VCF150.F1CellFormat

        'Titulos de totales en el calendario
        FOne.CargarDato("Spots por Día", Fila, ColLabelTotales)
        FOne.CargarDato("Spots por Semana", Fila + 2, ColLabelTotales)

        '''FORMATO
        'copia el formato de la columna
        FOne.Grilla.SetSelection(Fila + 2, ColLabelTotales, Fila + 2, ColLabelTotales)
        cellFormat = FOne.Grilla.GetCellFormat()

        'pega el formato copiado en la nueva columna
        FOne.Grilla.SetSelection(Fila + 4, ColLabelTotales, Fila + 4, ColLabelTotales)
        FOne.Grilla.SetCellFormat(cellFormat)
        '''FORMATO


        If MostrarNeto Then
            FOne.CargarDato("Inv. por Semana", Fila + 4, ColLabelTotales)
        End If

    End Sub
    Private Sub CargarTotalesCadena(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer)
        Dim CantidadCadena As Integer
        Dim Total As Decimal
        Dim TotalTRP As Decimal
        Dim totalInversionNeta As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer
        Dim SpotsData As DataTable = IIf(Me.CalendarioConNumeros, SpotsTotales, Spots)

        'totales antes del calendario
        'Calculos.Add("sum(tarifaneta) / count(id_tema) / (sum(dur) / count(id_tema))")

        If Not Me.CalendarioConNumeros Then
            Calculos.Add("sum(tarifaneta) / count(id_tema)")
            Calculos.Add("sum(Dur) / count(id_tema)")
            Calculos.Add("sum(CostoSpot) / count(id_tema)")
        Else
            Calculos.Add("sum(tarifanetatotal) / sum(cantidad)")
            Calculos.Add("sum(duraciontotal) / sum(cantidad)")
            Calculos.Add("sum(costospottotal) / sum(cantidad)")
        End If

        If TipoRating = "Tanda" Then
            Calculos.Add("sum(RatingTanda) / count(id_tema)")
        Else
            Calculos.Add("sum(RatingPrograma) / count(id_tema)")
        End If

        'If TipoRating = "Tanda" Then
        '    Calculos.Add("avg(CPRTanda)")
        'Else
        '    Calculos.Add("avg(CPRProg)")
        'End If

        'total TRPs
        TotalTRP = SpotsData.Compute("sum(rating)", "Cadena='" & Cadena & "'")

        '*** total neto por cadena
        totalInversionNeta = 0

        For Each Dr As DataRow In SpotsData.Rows
            If Dr("cadena") = Cadena Then
                If Not Me.CalendarioConNumeros Then
                    totalInversionNeta += Dr("tarifaneta") * Dr("dur")
                Else
                    totalInversionNeta += Dr("tarifaneta") * Dr("dur") * Dr("cantidad")
                End If
            End If
        Next

        For i = 0 To Calculos.Count - 1
            'calculo
            Total = SpotsData.Compute(Calculos(i), "Cadena='" & Cadena & "'")

            If Calculos(i) = "avg(CostoSpot)" Or Calculos(i) = "avg(CPRTanda)" Or Calculos(i) = "avg(CPRProg)" Then
                FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, 11 + i)
            ElseIf Calculos(i) = "sum(Dur) / count(id_tema)" Then
                FOne.CargarDato(Format(Total, ".0"), Fila, 11 + i)
            Else
                FOne.CargarDato(Math.Round(Total, 2), Fila, 11 + i)
            End If
        Next

        Dim segundosxcadena As Decimal
        segundosxcadena = SpotsData.Compute(Calculos(1), "Cadena='" & Cadena & "'")
        If segundosxcadena = 0 Or TotalTRP = 0 Or totalInversionNeta = 0 Then
            FOne.CargarDato(0, Fila, 11 + i)
        Else
            'AG 24/01/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'CalculoCPRPromedioXCadena(Cadena, totalInversionNeta).Rows(0)("CPRPromCadena").ToString()
            FOne.CargarDato(CalculoCPRPromedioXCadena(Cadena, totalInversionNeta).Rows(0)("CPRPromCadena").ToString(), Fila, 11 + i)
            ' Codigo anterior ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'FOne.CargarDato(Math.Round(totalInversionNeta / TotalTRP / segundosxcadena, 2), Fila, 11 + i)
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        End If

        'Total despues del calendario

        'total Spots
        'Total = Spots.Compute("count(id_tema)", "Cadena='" & Cadena & "'")
        'LC 25/06/2014 Reporte calendario cantidad de avisos


        If Not Me.CalendarioConNumeros Then
            Total = SpotsData.Compute("sum(Factor)", "Cadena='" & Cadena & "'")
            CantidadCadena = SpotsData.Compute("count(Factor)", "Cadena='" & Cadena & "'")
        Else
            Total = SpotsData.Compute("sum(cantidad)", "Cadena='" & Cadena & "'")
            CantidadCadena = SpotsData.Compute("count(cantidad)", "Cadena='" & Cadena & "'")
        End If

        ' Total Spots
        If Not Me.CalendarioConNumeros Then
            FOne.CargarDato(Total, Fila, MaxCol - 2)
        Else
            TotalesSpots.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol - 2, Fila - CantidadCadena), GetCellName(MaxCol - 2, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 2, String.Format("SUM({0}:{1})", GetCellName(MaxCol - 2, Fila - CantidadCadena), GetCellName(MaxCol - 2, Fila - 1)))
        End If

        ' Total TRPs
        If Not Me.CalendarioConNumeros Then
            FOne.CargarDato(Math.Round(TotalTRP, 2), Fila, MaxCol - 1)
        Else
            TotalesTrps.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol - 1, Fila - CantidadCadena), GetCellName(MaxCol - 1, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 1, String.Format("SUM({0}:{1})", GetCellName(MaxCol - 1, Fila - CantidadCadena), GetCellName(MaxCol - 1, Fila - 1)))
        End If

        'Total = Spots.Compute("sum(tarifaneta)", "Cadena='" & Cadena & "'")

        ' Total Neto
        If Not Me.CalendarioConNumeros Then
            FOne.CargarDato("$ " & Format(totalInversionNeta, "#,##0.00"), Fila, MaxCol)
        Else
            TotalesNetos.Add(String.Format("SUM({0}:{1})", GetCellName(MaxCol, Fila - CantidadCadena), GetCellName(MaxCol, Fila - 1)))
            FOne.Grilla.set_FormulaRC(Fila, MaxCol, String.Format("SUM({0}:{1})", GetCellName(MaxCol, Fila - CantidadCadena), GetCellName(MaxCol, Fila - 1)))
        End If
        '***

        'FOne.CargarDato("Total Cadena", Fila, MaxCol - 5)

        FOne.Grilla.SetColWidth(50, 50, 4000, False)

        FOne.CargarDato("Total Cadena", Fila, MaxCol - 3)

        FOne.Grilla.SetColWidth(MaxCol - 3, MaxCol - 3, 4000, False)

        FOne.Grilla.SetSelection(Fila, 1, Fila, MaxCol)
        FOne.Grilla.FontBold = True

        FOne.CargarBorde(Fila, 1, MaxCol, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeMedio, -1)
    End Sub

    Private Sub CargarTotalesCadenaLog(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer)
        Dim Total As Decimal
        Dim TotalTRP As Decimal
        Dim totalInversionNeta As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer

        'totales antes del calendario
        'Calculos.Add("sum(tarifaneta) / count(id_tema) / (sum(dur) / count(id_tema))")
        Calculos.Add("sum(tarifaneta) / count(id_tema)")
        Calculos.Add("sum(Dur) / count(id_tema)")
        Calculos.Add("sum(CostoSpot) / count(id_tema)")

        If TipoRating = "Tanda" Then
            Calculos.Add("sum(RatingTanda) / count(id_tema)")
        Else
            Calculos.Add("sum(RatingPrograma) / count(id_tema)")
        End If

        'total TRPs
        TotalTRP = Spots.Compute("sum(rating)", "Cadena='" & Cadena & "'")

        '*** total neto por cadena
        totalInversionNeta = 0

        For Each Dr As DataRow In Spots.Rows
            If Dr("cadena") = Cadena Then
                totalInversionNeta += Dr("tarifaneta") * Dr("dur")
            End If
        Next

        For i = 0 To Calculos.Count - 1
            'calculo
            Total = Spots.Compute(Calculos(i), "Cadena='" & Cadena & "'")

            If Calculos(i) = "avg(CostoSpot)" Or Calculos(i) = "avg(CPRTanda)" Or Calculos(i) = "avg(CPRProg)" Then
                FOne.CargarDato("$ " & Format(Total, "#,##0.00"), Fila, 11 + i)
            ElseIf Calculos(i) = "sum(Dur) / count(id_tema)" Then
                FOne.CargarDato(Format(Total, ".0"), Fila, 10 + i)
            Else
                FOne.CargarDato(Math.Round(Total, 2), Fila, 10 + i)
            End If
        Next

        Dim segundosxcadena As Decimal
        segundosxcadena = Spots.Compute(Calculos(1), "Cadena='" & Cadena & "'")
        If segundosxcadena = 0 Or TotalTRP = 0 Or totalInversionNeta = 0 Then
            FOne.CargarDato(0, Fila, 10 + i)
        Else
            FOne.CargarDato(Math.Round(totalInversionNeta / TotalTRP / segundosxcadena, 2), Fila, 10 + i)
        End If

        'Total despues del calendario

        'total Spots
        Total = Spots.Compute("count(id_tema)", "Cadena='" & Cadena & "'")
        FOne.CargarDato(Total, Fila, MaxCol - 2)

        'total TRPs
        FOne.CargarDato(Math.Round(TotalTRP, 2), Fila, MaxCol - 1)

        'Total = Spots.Compute("sum(tarifaneta)", "Cadena='" & Cadena & "'")
        FOne.CargarDato("$ " & Format(totalInversionNeta, "#,##0.00"), Fila, MaxCol)
        '***

        FOne.CargarDato("Total Cadena", Fila, MaxCol - 5)

        FOne.Grilla.SetSelection(Fila, 1, Fila, MaxCol)
        FOne.Grilla.FontBold = True

        FOne.CargarBorde(Fila, 1, MaxCol, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeMedio, -1)
    End Sub

    Private Sub CargarTotalesCadenaInternet(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer)
        Dim Total As Decimal
        Dim TotalTRP As Decimal
        Dim totalInversionNeta As Decimal
        Dim totalTotal As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer
        Dim totalImpresiones As Integer
        Dim TotalView As Integer
        Dim TotalClicks As Integer
        Dim Total_Total As Decimal
        Dim TotalPrcentaje As Decimal
        Dim TotalImpSag As Decimal
        Dim SubTotalFila As Decimal

        'totales antes del calendario
        Calculos.Add("sum(inversion)")
        Calculos.Add("sum(impresiones)")
        'Calculos.Add("sum(neto) / count(id_tema)")

        '*** total neto por cadena
        totalInversionNeta = 0
        totalImpresiones = 0

        For Each Dr As DataRow In Spots.Rows
            If Dr("PROVEEDOR") = Cadena Then
                totalInversionNeta += Dr("inversion")
                totalImpresiones += Dr("impresiones")
                'totalTotal += Dr("total")
                TotalView += Dr("CLICKS")
                TotalClicks += Dr("VIEWS")
                TotalPrcentaje += Dr("SHAR")
                TotalImpSag += Dr("IMPSAG")
                Total_Total += Dr("inversion")
            End If
        Next
        Dim cpmCalculado As Decimal = 0

        If totalImpresiones <> 0 Then
            cpmCalculado = ((totalInversionNeta / totalImpresiones) * 1000)
        End If

        'AG 03/12/2013 =================================
        SubTotalFila = TotalImpSag + Total_Total
        '===============================================

        'total Spots
        'Total = Spots.Compute("count(id_spot)", "PROVEEDOR='" & Cadena & "'")
        'Total = Spots.Compute("count(id_tema)", "PROVEEDOR='" & Cadena & "'")
        'FOne.CargarDato(Total, Fila, MaxCol - 1)
        totalInversionNetaTodosMedios += totalInversionNeta
        'totalTotalTodosMedios += totalTotal
        FOne.CargarDato("$ " & Format(totalInversionNeta, "#,##0.00"), Fila, MaxCol + 6)

        'FOne.CargarDato("Subtotal Medio " & Cadena, Fila, MaxCol + 5)

        'AG 03/12/2013 ========================================
        FOne.CargarDato("Subtotal Medio " & Cadena, Fila, 1)
        FOne.Grilla.SetSelection(Fila, 1, Fila, 1)
        FOne.Grilla.FontBold = True
        '=======================================================

        FOne.Grilla.SetSelection(Fila, MaxCol + 5, Fila, MaxCol + 6)
        FOne.Grilla.FontBold = True
        FOne.CargarDato(Format(totalImpresiones, "#,##0."), Fila, MaxCol + 7)
        FOne.Grilla.SetSelection(Fila, MaxCol + 7, Fila, MaxCol + 7)
        FOne.Grilla.FontBold = True
        FOne.CargarDato("$ " & Format(cpmCalculado, "#,##0.00"), Fila, MaxCol + 5)
        'FOne.CargarDato("CPM", Fila, MaxCol + 8)
        FOne.Grilla.SetSelection(Fila, MaxCol + 4, Fila, MaxCol + 5)
        FOne.Grilla.FontBold = True

        'AG 03/12/2013 ====================================================
        FOne.CargarDato(Format(TotalView, "#,##0."), Fila, MaxCol + 8)
        FOne.Grilla.SetSelection(Fila, MaxCol + 8, Fila, MaxCol + 8)
        FOne.Grilla.FontBold = True

        FOne.CargarDato(Format(TotalClicks, "#,##0."), Fila, MaxCol + 9)
        FOne.Grilla.SetSelection(Fila, MaxCol + 9, Fila, MaxCol + 9)
        FOne.Grilla.FontBold = True
        FOne.CargarDato(Format(TotalPrcentaje, "#,##0.00") & " %", Fila, MaxCol + 10)

        FOne.Grilla.SetSelection(Fila, MaxCol + 10, Fila, MaxCol + 10)
        FOne.Grilla.FontBold = True

        FOne.CargarDato("$ " & Format(TotalImpSag, "#,##0.00"), Fila, MaxCol + 12)
        FOne.Grilla.SetSelection(Fila, MaxCol + 12, Fila, MaxCol + 12)
        FOne.Grilla.FontBold = True


        FOne.CargarDato("$ " & Format(SubTotalFila, "#,##0.00"), Fila, MaxCol + 13)
        FOne.Grilla.SetSelection(Fila, MaxCol + 13, Fila, MaxCol + 13)
        FOne.Grilla.FontBold = True
        '==================================================================

        FOne.CargarBorde(Fila, 1, MaxCol + 13, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeMedio, -1)

    End Sub
    Private Sub CargarTotalesCadenaPrensa(ByVal Cadena As String, ByRef Fila As Integer, ByVal MaxCol As Integer)
        Dim Total As Decimal
        Dim TotalTRP As Decimal
        Dim totalInversionNeta As Decimal
        Dim Calculos As New ArrayList
        Dim i As Integer

        'totales antes del calendario
        'Calculos.Add("sum(tarifaneta) / count(id_tema) / (sum(dur) / count(id_tema))")
        Calculos.Add("sum(tarifaneta) / count(id_tema)")
        'Calculos.Add("sum(Dur) / count(id_tema)")
        'Calculos.Add("sum(CostoSpot) / count(id_tema)")

        '*** total neto por cadena
        totalInversionNeta = 0

        For Each Dr As DataRow In Spots.Rows
            If Dr("cadena") = Cadena Then
                totalInversionNeta += Dr("tarifaneta")
            End If
        Next

        'For i = 0 To Calculos.Count - 1
        '    'calculo
        '    Total = Spots.Compute(Calculos(i), "Cadena='" & Cadena & "'")
        '    FOne.CargarDato(Math.Round(Total, 2), Fila, 11 + i)
        'Next

        'Total despues del calendario

        'total Spots
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Total = Spots.Compute("sum(Factor)", "Cadena='" & Cadena & "'")
        'Total = Spots.Compute("count(id_tema)", "Cadena='" & Cadena & "'")
        FOne.CargarDato(Total, Fila, MaxCol - 1)

        'Total = Spots.Compute("sum(tarifaneta)", "Cadena='" & Cadena & "'")
        FOne.CargarDato("$ " & Format(totalInversionNeta, "#,##0.00"), Fila, MaxCol)
        '***

        FOne.CargarDato("Total Medio", Fila, MaxCol - 4)

        FOne.Grilla.SetSelection(Fila, 1, Fila, MaxCol)
        FOne.Grilla.FontBold = True

        FOne.CargarBorde(Fila, 1, MaxCol, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeMedio, -1)
    End Sub

    Private Sub CargarEnGrilla(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Cadena, Fila, 1)
        FOne.CargarDato(Reg.Dia, Fila, 2)
        FOne.CargarDato(Reg.Hora, Fila, 3)
        FOne.CargarDato(Reg.Programa, Fila, 4)
        FOne.CargarDato(Reg.TarifaBruta, Fila, 5)
        FOne.CargarDato(Reg.D1, Fila, 6)
        FOne.CargarDato(Reg.D2, Fila, 7)
        FOne.CargarDato(Reg.D3, Fila, 8)
        FOne.CargarDato(Reg.D4, Fila, 9)
        FOne.CargarDato(Reg.D5, Fila, 10)
        FOne.CargarDato(Format(Reg.TarifaNeta, "#,##0.00"), Fila, 11)
        'Dur
        FOne.CargarDato(Reg.Dur, Fila, 12)
        FOne.CargarDato("$ " & Format(Reg.CostoSpot, "#,##0.00"), Fila, 13)
        FOne.CargarDato(Format(Reg.Rating, "#,##0.00"), Fila, 14)
        FOne.CargarDato("$ " & Format(Reg.CPR, "#0.00"), Fila, 15)
        FOne.CargarDato(Reg.Tema, Fila, 16)

        ' Totales
        If Not Me.CalendarioConNumeros Then
            FOne.CargarDato(Reg.TotalSpots * Reg.Factor, Fila, MaxCol - 2)
            FOne.CargarDato(Math.Round(Reg.TotalTrps, 1), Fila, MaxCol - 1)
            FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)
        Else
            FOne.Grilla.set_FormulaRC(Fila, MaxCol - 2, String.Format("SUM({0}:{1})", GetCellName(18, Fila), GetCellName(MaxCol - 4, Fila)))
        End If

        'LC 25/06/2014 Reporte calendario cantidad de avisos        
        'lo comento porque ahora se usan formulas para su calculo.
        'FOne.CargarDato(Reg.Factor, Fila, MaxCol + 1)

        Me.TotalNetoFinal += Reg.TotalNeto
    End Sub

    Private Function GetCellName(ByVal column As Integer, ByVal row As Integer) As String
        Dim cells As New List(Of String)(New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        If column > cells.Count Then
            Dim ciclos As Integer = Math.Truncate(column / cells.Count)
            Dim cellName As String = cells(ciclos - 1)
            Return String.Format("{0}{1}", String.Format("{0}{1}", cellName, cells(column - 1 - (cells.Count() * ciclos))), row)
        Else
            Return String.Format("{0}{1}", cells(column - 1), row)
        End If
    End Function

    Private Sub CargarEnGrillaLog(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Cadena, Fila, 1)
        FOne.CargarDato(Reg.Hora, Fila, 2)
        FOne.CargarDato(Reg.Programa, Fila, 3)
        FOne.CargarDato(Reg.TarifaBruta, Fila, 4)
        FOne.CargarDato(Reg.D1, Fila, 5)
        FOne.CargarDato(Reg.D2, Fila, 6)
        FOne.CargarDato(Reg.D3, Fila, 7)
        FOne.CargarDato(Reg.D4, Fila, 8)
        FOne.CargarDato(Reg.D5, Fila, 9)
        FOne.CargarDato(Format(Reg.TarifaNeta, "#,##0.00"), Fila, 10)
        'Dur
        FOne.CargarDato(Reg.Dur, Fila, 11)
        FOne.CargarDato("$ " & Format(Reg.CostoSpot, "#,##0.00"), Fila, 12)
        FOne.CargarDato(Format(Reg.Rating, "#,##0.00"), Fila, 13)
        FOne.CargarDato("$ " & Format(Reg.CPR, "#0.00"), Fila, 14)
        FOne.CargarDato(Reg.TotalSpots, Fila, MaxCol - 2)
        FOne.CargarDato(Math.Round(Reg.TotalTrps, 1), Fila, MaxCol - 1)
        FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)

        Me.TotalNetoFinal += Reg.TotalNeto
    End Sub
    Private Sub CargarEnGrillaInternet(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Proveedor, Fila, 1)
        FOne.CargarDato(Reg.Soporte, Fila, 2)
        FOne.CargarDato(Reg.TipoSoporte, Fila, 3)
        FOne.CargarDato(Reg.Ubicacion, Fila, 4)
        FOne.CargarDato(Reg.TipoFormato, Fila, 5)
        FOne.CargarDato(Reg.Formato, Fila, 6)
        FOne.CargarDato(Reg.TipoCompra, Fila, MaxCol - 1)
        FOne.CargarDato(Reg.CantidadDias, Fila, MaxCol)
        FOne.CargarDato(Reg.CantidadHoras, Fila, MaxCol + 1)
        FOne.CargarDato("$ " & Format(Reg.Bruto, "#,##0.00"), Fila, MaxCol + 2)
        FOne.CargarDato(Format(Reg.Descuento1 / 100, "#,##0.00%"), Fila, MaxCol + 3)
        FOne.CargarDato(Format(Reg.Descuento2 / 100, "#,##0.00%"), Fila, MaxCol + 4)
        FOne.CargarDato("$ " & Format(Reg.Neto, "#,##0.00"), Fila, MaxCol + 5)
        FOne.CargarDato("$ " & Format(Reg.Inversion, "#,##0.00"), Fila, MaxCol + 6)
        'Dim ImpSag As Decimal = Reg.Inversion * (Reg.Porsag / 100)
        'Dim Total As Decimal = Reg.Inversion + ImpSag
        FOne.CargarDato(Format(Reg.Impresiones, "#,0."), Fila, MaxCol + 7)
        FOne.CargarDato(Format(Reg.Clicks, "#,0."), Fila, MaxCol + 8)
        FOne.CargarDato(Format(Reg.Views, "#,0."), Fila, MaxCol + 9)
        FOne.CargarDato(Format(Reg.Shar / 100, "#,##0.00%"), Fila, MaxCol + 10)
        FOne.CargarDato(Format(Reg.Porsag / 100, "#,##0.00%"), Fila, MaxCol + 11)
        FOne.CargarDato("$ " & Format(Reg.Impsag, "#,##0.00"), Fila, MaxCol + 12)
        FOne.CargarDato("$ " & Format(Reg.Total, "#,##0.00"), Fila, MaxCol + 13)
        'FOne.CargarDato(Reg.TotalSpots, Fila, MaxCol - 1)
        'FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)

        Me.TotalNetoFinal += Reg.TotalNeto
    End Sub
    Private Sub CargarEnGrillaPrensa(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Cadena, Fila, 1)
        FOne.CargarDato(Reg.ProductoMaterial, Fila, 2)
        FOne.CargarDato(Reg.ConceptoSeccion, Fila, 3)
        FOne.CargarDato(Reg.Tamaño, Fila, 4)
        FOne.CargarDato(Reg.AnchoAlto, Fila, 5)
        FOne.CargarDato(Reg.TarifaBruta, Fila, 6)
        FOne.CargarDato(Reg.D1, Fila, 7)
        FOne.CargarDato(Reg.D2, Fila, 8)
        FOne.CargarDato(Reg.D3, Fila, 9)
        FOne.CargarDato(Reg.D4, Fila, 10)
        FOne.CargarDato(Reg.D5, Fila, 11)
        FOne.CargarDato(Format(Reg.TarifaNeta, "#,##0.00"), Fila, 12)
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        FOne.CargarDato(Reg.TotalSpots * Reg.Factor, Fila, MaxCol - 1)
        FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)

        Me.TotalNetoFinal += Reg.TotalNeto
    End Sub
    Private Sub CargarEnGrillaExterior(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Cadena, Fila, 1)
        FOne.CargarDato(Reg.ProductoMaterial, Fila, 2)
        FOne.CargarDato(Reg.Formato, Fila, 3)
        FOne.CargarDato(Reg.ProvinciaPoblacion, Fila, 4)
        FOne.CargarDato(Reg.TarifaBruta, Fila, 5)
        FOne.CargarDato(Reg.D1, Fila, 6)
        FOne.CargarDato(Reg.D2, Fila, 7)
        FOne.CargarDato(Reg.D3, Fila, 8)
        FOne.CargarDato(Reg.D4, Fila, 9)
        FOne.CargarDato(Reg.D5, Fila, 10)
        FOne.CargarDato(Format(Reg.TarifaNeta, "#,##0.00"), Fila, 11)
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        FOne.CargarDato(Reg.TotalSpots * Reg.Factor, Fila, MaxCol - 1)
        FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)

        Me.TotalNetoFinal += Reg.TotalNeto
    End Sub

    Private Sub CargarEnGrillaResumenPrograma(ByVal Reg As RegistroCalendario, ByVal Fila As Integer, ByVal MaxCol As Integer, ByVal MostrarTotalNeto As Boolean)
        'carga los datos que estan ANTES del calendario
        FOne.CargarDato(Reg.Cadena, Fila, 1)
        FOne.CargarDato(Reg.Hora, Fila, 2)
        FOne.CargarDato(Reg.Programa, Fila, 3)
        FOne.CargarDato(Reg.Rating, Fila, 4)
        FOne.CargarDato(Reg.TotalSpots, Fila, MaxCol - 2)
        FOne.CargarDato(Math.Round(Reg.TotalTrps, 1), Fila, MaxCol - 1)

        If MostrarTotalNeto Then
            FOne.CargarDato("$ " & Format(Reg.TotalNeto, "#,##0.00"), Fila, MaxCol)
        End If
    End Sub

    Private Function AplicarCorteControl(Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As ArrayList
        Dim Dr As DataRow
        Dim DrSpot As DataRow
        Dim DrAnterior As DataRow
        Dim RegCal As RegistroCalendario
        Dim Datos As New ArrayList
        Dim Dia As DiaCalendario
        Dim PrimerRegistro As Boolean = True

        If Not Me.CalendarioConNumeros Then

            Spots.Columns.Add("TotalTrps", GetType(Decimal))
            Spots.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = Spots.Rows(Spots.Rows.Count - 1)

            For Each Dr In Spots.Rows
                If PrimerRegistro OrElse Me.EsDiferente(Dr, DrAnterior, EsCalendarioDiario, MostrarCampoDia) Then
                    'otro registro
                    RegCal = New RegistroCalendario

                    RegCal.Cargar(Dr, MostrarCampoDia)

                    Dia = New DiaCalendario(Dr("f_spot"), Dr("id_tema"), Dr("costospot"))
                    RegCal.Dias.Add(Dia)

                    Datos.Add(RegCal)

                    PrimerRegistro = False
                Else
                    'el mismo registro
                    Dia = New DiaCalendario(Dr("f_spot"), Dr("id_tema"), Dr("costospot"))
                    RegCal.Dias.Add(Dia)
                    RegCal.Cargar(Dr, MostrarCampoDia)
                End If

                DrAnterior = Dr
            Next
        Else

            Spots.Columns.Add("TotalTrps", GetType(Decimal))
            Spots.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = Spots.Rows(Spots.Rows.Count - 1)

            For Each Dr In Spots.Rows
                If PrimerRegistro OrElse Me.EsDiferente(Dr, DrAnterior, EsCalendarioDiario, MostrarCampoDia) Then
                    'otro registro
                    RegCal = New RegistroCalendario

                    RegCal.Cargar(Dr, MostrarCampoDia)

                    Dia = New DiaCalendario(Dr("f_spot"), Dr("id_tema"), Dr("costospot"))
                    RegCal.Dias.Add(Dia)

                    PrimerRegistro = False
                Else
                    'el mismo registro
                    Dia = New DiaCalendario(Dr("f_spot"), Dr("id_tema"), Dr("costospot"))
                    RegCal.Dias.Add(Dia)
                    RegCal.Cargar(Dr, MostrarCampoDia)
                End If

                DrAnterior = Dr
            Next

            SpotsTotales.Columns.Add("TotalTrps", GetType(Decimal))
            SpotsTotales.Columns.Add("Rating", GetType(Decimal))

            DrAnterior = SpotsTotales.Rows(SpotsTotales.Rows.Count - 1)

            For Each Dr In SpotsTotales.Rows
                RegCal = New RegistroCalendario
                RegCal.Cargar(Dr, MostrarCampoDia)

                If Dr("Tipo_Rating") = "P" Or Dr("Tipo_Rating") = "F" Then
                    RegCal.Rating = Dr("ratingprogramatotal")
                Else
                    RegCal.Rating = Dr("ratingtandatotal")
                End If

                RegCal.TotalSpots = Dr("cantidad")
                RegCal.TotalNeto = RegCal.TarifaNeta * RegCal.Dur * RegCal.TotalSpots
                For Each DrSpot In Spots.Select("Cadena='" & Dr("Cadena") & "' and Programa='" & Dr("Programa") & "' and id_tema='" & Dr("id_tema") & "' and Hora='" & Dr("Hora") & "'")
                    Dia = New DiaCalendario(DrSpot("f_spot"), DrSpot("id_tema"), DrSpot("costospot"))
                    RegCal.Dias.Add(Dia)
                Next
                Datos.Add(RegCal)
            Next
        End If

        Return Datos
    End Function

    Private Function AplicarCorteControlInternet(Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As ArrayList
        Dim Dr As DataRow
        Dim DrAnterior As DataRow
        Dim RegCal As RegistroCalendario
        Dim Datos As New ArrayList
        Dim Dia As DiaCalendario
        Dim DiaInternet As DiaCalendario
        Dim PrimerRegistro As Boolean = True

        DrAnterior = Spots.Rows(Spots.Rows.Count - 1)
        For Each Dr In Spots.Rows
            If PrimerRegistro OrElse Me.EsDiferenteInternet(Dr, DrAnterior, EsCalendarioDiario, MostrarCampoDia) Then
                'otro registro
                RegCal = New RegistroCalendario

                RegCal.CargarInternet(Dr, MostrarCampoDia)

                Dim dias As Long = DateDiff(DateInterval.Day, Dr("f_inicio"), Dr("f_fin"))
                DiaInternet = New DiaCalendario(Dr("f_inicio"))
                RegCal.Dias.Add(DiaInternet)
                For value As Integer = 1 To dias
                    DiaInternet = New DiaCalendario(DateTime.ParseExact(Dr("f_inicio"), "dd\/MM\/yyyy", Nothing).AddDays(value))
                    RegCal.Dias.Add(DiaInternet)
                Next

                Datos.Add(RegCal)

                PrimerRegistro = False
            Else
                'el mismo registro
                RegCal = New RegistroCalendario
                RegCal.CargarInternet(Dr, MostrarCampoDia)

                Dim dias As Long = DateDiff(DateInterval.Day, Dr("f_inicio"), Dr("f_fin"))
                DiaInternet = New DiaCalendario(Dr("f_inicio"))
                RegCal.Dias.Add(DiaInternet)
                For value As Integer = 1 To dias
                    DiaInternet = New DiaCalendario(DateTime.ParseExact(Dr("f_inicio"), "dd\/MM\/yyyy", Nothing).AddDays(value))
                    RegCal.Dias.Add(DiaInternet)
                Next

                If RegCal.Proveedor = DrAnterior("Proveedor") Then
                    RegCal.Proveedor = ""
                End If
                Datos.Add(RegCal)
            End If

            DrAnterior = Dr
        Next

        Return Datos
    End Function
    Private Function AplicarCorteControlPrensa(Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As ArrayList
        Dim Dr As DataRow
        Dim DrAnterior As DataRow
        Dim RegCal As RegistroCalendario
        Dim Datos As New ArrayList
        Dim Dia As DiaCalendario
        Dim DiaPrensa As DiaCalendarioPrensa
        Dim PrimerRegistro As Boolean = True

        DrAnterior = Spots.Rows(Spots.Rows.Count - 1)

        For Each Dr In Spots.Rows
            If PrimerRegistro OrElse Me.EsDiferentePrensa(Dr, DrAnterior, EsCalendarioDiario, MostrarCampoDia) Then
                'otro registro
                RegCal = New RegistroCalendario

                RegCal.CargarPrensa(Dr, MostrarCampoDia)

                DiaPrensa = New DiaCalendarioPrensa(Dr("f_spot"))
                RegCal.Dias.Add(DiaPrensa)

                Datos.Add(RegCal)

                PrimerRegistro = False
            Else
                'el mismo registro
                DiaPrensa = New DiaCalendarioPrensa(Dr("f_spot"))
                RegCal.Dias.Add(DiaPrensa)

                RegCal.CargarPrensa(Dr, MostrarCampoDia)
            End If

            DrAnterior = Dr
        Next

        Return Datos
    End Function
    Private Function AplicarCorteControlExterior(Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As ArrayList
        Dim Dr As DataRow
        Dim DrAnterior As DataRow
        Dim RegCal As RegistroCalendario
        Dim Datos As New ArrayList
        Dim Dia As DiaCalendario
        Dim DiaPrensa As DiaCalendarioPrensa
        Dim PrimerRegistro As Boolean = True

        DrAnterior = Spots.Rows(Spots.Rows.Count - 1)

        For Each Dr In Spots.Rows
            If PrimerRegistro OrElse Me.EsDiferenteExterior(Dr, DrAnterior, EsCalendarioDiario, MostrarCampoDia) Then
                'otro registro
                RegCal = New RegistroCalendario

                RegCal.CargarExterior(Dr, MostrarCampoDia)

                DiaPrensa = New DiaCalendarioPrensa(Dr("f_spot"))
                RegCal.Dias.Add(DiaPrensa)

                Datos.Add(RegCal)

                PrimerRegistro = False
            Else
                'el mismo registro
                DiaPrensa = New DiaCalendarioPrensa(Dr("f_spot"))
                RegCal.Dias.Add(DiaPrensa)

                RegCal.CargarExterior(Dr, MostrarCampoDia)
            End If

            DrAnterior = Dr
        Next

        Return Datos
    End Function
    Private Function EsDiferente(ByVal Dr1 As DataRow, ByVal Dr2 As DataRow, Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As Boolean
        Dim Campos As New ArrayList

        'columnas por las que aplica el corte de control
        If EsCalendarioDiario Then
            Campos.Add("Cadena")
            If MostrarCampoDia Then
                Campos.Add("Dia")
            End If
            Campos.Add("Programa")
            Campos.Add("TarifaBruta")
            Campos.Add("D1")
            Campos.Add("D2")
            Campos.Add("D3")
            Campos.Add("D4")
            Campos.Add("D5")
            Campos.Add("TarifaNeta")
            Campos.Add("Dur")
            'JJP - Columnas agregadas - 18/06/2009
            Campos.Add("Hora")
            Campos.Add("Rating")
            ', "f_spot"}
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        Else
            Campos.Add("Cadena")
            If MostrarCampoDia Then
                Campos.Add("Dia")
            End If
            Campos.Add("Programa")
            Campos.Add("Rating")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        End If

        For Each S As String In Campos
            If Dr1(S) Is DBNull.Value Or Dr2(S) Is DBNull.Value Then
                If Not Dr1(S) Is Dr2(S) Then
                    'Return True
                End If
            Else
                If Dr1(S) <> Dr2(S) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function
    Private Function EsDiferenteInternet(ByVal Dr1 As DataRow, ByVal Dr2 As DataRow, Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As Boolean
        Dim Campos As New ArrayList
        'columnas por las que aplica el corte de control
        If EsCalendarioDiario Then
            Campos.Add("PROVEEDOR")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        Else
            Campos.Add("PROVEEDOR")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        End If

        For Each S As String In Campos
            If Dr1(S) Is DBNull.Value Or Dr2 Is DBNull.Value Then
                If Not Dr1(S) Is Dr2(S) Then
                    'Return True
                End If
            Else
                If Dr1(S) <> Dr2(S) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    Private Function EsDiferentePrensa(ByVal Dr1 As DataRow, ByVal Dr2 As DataRow, Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As Boolean
        Dim Campos As New ArrayList

        'columnas por las que aplica el corte de control
        If EsCalendarioDiario Then
            Campos.Add("Cadena")
            Campos.Add("Producto-Material")
            Campos.Add("Concepto-Seccion")
            Campos.Add("Tamanio")
            Campos.Add("AnchoxAlto")
            Campos.Add("TarifaBruta")
            Campos.Add("D1")
            Campos.Add("D2")
            Campos.Add("D3")
            Campos.Add("D4")
            Campos.Add("D5")
            Campos.Add("TarifaNeta")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        Else
            Campos.Add("Cadena")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        End If

        For Each S As String In Campos
            If Dr1(S) Is DBNull.Value Or Dr2 Is DBNull.Value Then
                If Not Dr1(S) Is Dr2(S) Then
                    'Return True
                End If
            Else
                If Dr1(S) <> Dr2(S) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function
    Private Function EsDiferenteExterior(ByVal Dr1 As DataRow, ByVal Dr2 As DataRow, Optional ByVal EsCalendarioDiario As Boolean = True, Optional ByVal MostrarCampoDia As Boolean = True) As Boolean
        Dim Campos As New ArrayList

        'columnas por las que aplica el corte de control
        If EsCalendarioDiario Then
            Campos.Add("Cadena")
            Campos.Add("Producto-Material")
            Campos.Add("Formato")
            Campos.Add("Provincia-Poblacion")
            Campos.Add("TarifaBruta")
            Campos.Add("D1")
            Campos.Add("D2")
            Campos.Add("D3")
            Campos.Add("D4")
            Campos.Add("D5")
            Campos.Add("TarifaNeta")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        Else
            Campos.Add("Cadena")
            'LC 25/06/2014 Reporte calendario cantidad de avisos 
            Campos.Add("Factor")
        End If

        For Each S As String In Campos
            If Dr1(S) Is DBNull.Value Or Dr2 Is DBNull.Value Then
                If Not Dr1(S) Is Dr2(S) Then
                    'Return True
                End If
            Else
                If Dr1(S) <> Dr2(S) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function
    Private Function CargarColumnasCalendario(ByVal colInicio As Integer) As Integer
        '* CREA LAS COLUMNAS DEL CALENDARIO, LES DA FORMATO Y AGREGA LOS DATOS
        '* DE LOS DIAS Y EL MES
        Dim i, Dias As Integer
        Dim MesAnterior As String
        Dim primerDiaDespuesDeDomingo As Boolean = False

        Dim j As Integer

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)
        If Dias > 255 Then
            Mensajes.Mensaje("El rango de fechas seleccionados es demasiado grande, por favor elija rangos menores", TipoMensaje.DeError)
            Me.Cancelar = True
            Me.Cursor = Cursors.Default
        Else

            'recorre todos los dias y va agregando la informacion
            For i = 0 To Dias
                Dim D As New DiaCalendario(Me.FechaDesde.AddDays(i))

                'cuando se llega a la ultima columna, no duplica mas (si no queda una columna de mas)
                If i < Dias Then
                    FOne.DuplicarColumna(colInicio + i, 9, 22)
                End If

                'agrega el mes, cuando cambia
                If MesAnterior <> D.MesLetras Then
                    FOne.CargarDato(D.MesLetras, 9, colInicio + i)
                    MesAnterior = D.MesLetras

                    If primerDiaDespuesDeDomingo Then
                        FOne.CargarBorde(9, colInicio + i, colInicio + i, 2, 1, 1, 1, -1)
                        primerDiaDespuesDeDomingo = False
                    Else
                        FOne.CargarBorde(9, colInicio + i, colInicio + i, TipoBorde.BordeFino, _
                        TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    End If
                End If

                If primerDiaDespuesDeDomingo Then
                    FOne.CargarBorde(10, colInicio + i, colInicio + i, 2, 1, 1, 1, -1)
                    FOne.CargarBorde(11, colInicio + i, colInicio + i, 2, 1, 1, 1, -1)
                    FOne.CargarBorde(12, colInicio + i, colInicio + i, 2, 1, 1, 1, -1)
                    primerDiaDespuesDeDomingo = False
                End If

                If Me.SemanaNatural Then
                    If D.Fecha.DayOfWeek = DayOfWeek.Sunday Then
                        FOne.CargarBorde(10, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(11, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(12, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        primerDiaDespuesDeDomingo = True
                    End If
                Else
                    If (i + 1) Mod 7 = 0 Then
                        FOne.CargarBorde(10, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(11, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        FOne.CargarBorde(12, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                        primerDiaDespuesDeDomingo = True
                    End If
                End If
                j += 1
                '------------------------------

                'agrega el dia en letras y numero
                FOne.CargarDato(D.DiaLetras, 10, colInicio + i)
                FOne.CargarDato(D.DiaNumero, 11, colInicio + i)

                FOne.Grilla.set_ColWidth(colInicio + i, 2000)
            Next

            'cambia el ancho de la ultima columna que es de separador
            FOne.Grilla.set_ColWidth(colInicio + i, FOne.Grilla.get_ColWidth(colInicio - 1))

            'cargar el borde superior
            FOne.CargarBorde(9, colInicio, colInicio + i - 1, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio)

            Return colInicio + i + 2 + 1 'devuelve la ultima columna usada (colInicio + las columnas creadas + 1 espacio + los 2 totales )
        End If

    End Function

    Private Function CargarColumnasCalendarioTVRD(ByVal colInicio As Integer) As Integer
        '* CREA LAS COLUMNAS DEL CALENDARIO, LES DA FORMATO Y AGREGA LOS DATOS
        '* DE LOS DIAS Y EL MES
        Dim i, Dias As Integer
        Dim MesAnterior As String
        Dim primerDiaDespuesDeDomingo As Boolean = False

        Dim j As Integer

        'saca la cantidad de dias que hay entre las fechas
        Dias = DateDiff(DateInterval.Day, Me.FechaDesde, Me.FechaHasta)

        'recorre todos los dias y va agregando la informacion
        For i = 0 To Dias
            Dim D As New DiaCalendario(Me.FechaDesde.AddDays(i))

            'cuando se llega a la ultima columna, no duplica mas (si no queda una columna de mas)
            If i < Dias Then
                FOne.DuplicarColumna(colInicio + i, 9, 22)
            End If

            'agrega el mes, cuando cambia
            If MesAnterior <> D.MesLetras Then
                FOne.CargarDato(D.MesLetras, 9, colInicio + i)
                MesAnterior = D.MesLetras

                If primerDiaDespuesDeDomingo Then
                    FOne.CargarBorde(9, colInicio + i, colInicio + i, 2, 1, 1, 1, -1)
                    primerDiaDespuesDeDomingo = False
                Else
                    FOne.CargarBorde(9, colInicio + i, colInicio + i, TipoBorde.BordeFino, _
                    TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                End If
            End If

            If primerDiaDespuesDeDomingo Then
                FOne.CargarBorde(10, colInicio + i, colInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                FOne.CargarBorde(11, colInicio + i, colInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                FOne.CargarBorde(12, colInicio + i, colInicio + i, TipoBorde.BordeMedio, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, -1)
                primerDiaDespuesDeDomingo = False
            End If

            If Me.SemanaNatural Then
                If D.Fecha.DayOfWeek = DayOfWeek.Sunday Then
                    FOne.CargarBorde(10, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(11, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(12, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    primerDiaDespuesDeDomingo = True
                End If
            Else
                If (i + 1) Mod 7 = 0 Then
                    FOne.CargarBorde(10, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(11, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, -1)
                    FOne.CargarBorde(12, colInicio + i, colInicio + i, TipoBorde.SinCambio, TipoBorde.BordeMedio, TipoBorde.SinCambio, TipoBorde.SinCambio, 1)
                    primerDiaDespuesDeDomingo = True
                End If
            End If
            j += 1
            '------------------------------

            'agrega el dia en letras y numero
            FOne.CargarDato(D.DiaLetras, 10, colInicio + i)
            FOne.CargarDato(D.DiaNumero, 11, colInicio + i)

            FOne.Grilla.set_ColWidth(colInicio + i, 2000)
        Next

        'cambia el ancho de la ultima columna que es de separador
        FOne.Grilla.set_ColWidth(colInicio + i, FOne.Grilla.get_ColWidth(colInicio - 1))

        'cargar el borde superior
        FOne.CargarBorde(9, colInicio, colInicio + i - 1, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.BordeFino, TipoBorde.SinCambio)

        Return colInicio + i + 3 'devuelve la ultima columna usada (colInicio + las columnas creadas + los 3 totales)
    End Function

#Region "Reporte CPR"

    Public Function MostrarFOneCPR(ByVal DtSpotEverest As DataTable, ByVal DtAvisosMMS As DataTable, ByVal DtDatosCompletos As DataTable, ByVal DtDatosdesglose As DataTable, ByVal DtDesgloseSeguimientoFinal As DataTable, ByVal DtFranjas As DataTable, ByVal dtCuadroResumen As DataTable, ByVal dtCuadroInversion As DataTable)

        Dim DrSpotEverest As DataRow
        Dim Fila, ColumnaEverest, ColumnaMMS As Integer
        Dim i, j As Integer
        Dim x, h As Integer
        Dim r, e As Integer
        Dim texto As String
        Dim Rating As Double
        Dim Neto As Double
        Dim Cadena() As String

        '++++++ Variables de Ubicacion Columnas en el Excel +++++++++++++++++++++++++++
        '++++++ Posiciones Datos Everest ++++++++++++++++++++
        Dim ColExCanal As Integer = 1 'Ok
        Dim ColExFechaPlanificado As Integer = 3 'Ok
        Dim ColExHoraPlanificado As Integer = 4 'Ok
        Dim ColExCostoSpot As Integer = 15 'Ok
        Dim ColExCPRPlanificado As Integer = 17
        '++++++ Posiciones Datos MMS +++++++++++++++++++
        Dim ColExCPRSoporte As Integer = 27
        Dim ColExInversionReal As Integer = 28
        '++++++ Posiciones Datos Calculados ++++++++++++++
        Dim ColExDiferenciaInversionNeta As Integer = 29
        Dim ColExDiferenciaRating As Integer = 30
        Dim ColExDiferenciaRatingPorcentaje As Integer = 31
        '++++++ Posiciones de Totales al Final del Reporte +++++
        '+++++++++++++++ Columnas ++++++++++++++++++
        Dim ColExInversinNetaPlanificada As Integer = 34
        Dim ColExGRPSPlanificados As Integer = 35
        Dim ColExDuracionPromedioPlanificado As Integer = 36
        Dim ColExCPRPromedioPlanificado As Integer = 37
        Dim ColExCOIxCanalPlanificado As Integer = 38
        '+++++++++++++++++ Filas ++++++++++++++++++++
        Dim FilCanal13 As Integer = 8
        Dim FilCanal9 As Integer = 9
        Dim FilAmerica As Integer = 10
        Dim FilTelefe As Integer = 11
        '++++++ Posiciones de Totales Emitidos +++++++++++++
        '++++++++++++++ Columnas ++++++++++
        Dim ColExInversionNetaRealEmitido As Integer = 39 '39
        Dim ColExGRPSReal As Integer = 40 '40
        Dim ColExDuracionPromedioEmitido As Integer = 41 '41
        Dim ColExPromedioEmitido As Integer = 42 '42
        Dim ColExSOIcCanalEmitido As Integer = 43 '43

        Dim ColDiferenciaInversionDesglose As Integer = 44
        Dim ColDiferenciaGrpsDesglose As Integer = 45

        '++++++ Posiciones Totales Seguimientos +++++++++++++
        '++++++++++++++ Columnas ++++++++++
        Dim ColExPlaCPRPromedio As Integer = 47
        Dim ColExEmiCPRPromedio As Integer = 48
        Dim ColExTotalOrdenCompra As Integer = 49
        Dim ColExTotalDiferenciaNetoCompra As Integer = 50
        '++++++++++++++ Filas ++++++++++++++
        Dim FilExTotalOrdenCompra As Integer = 8
        Dim FilExTotalDiferenciaNetoCompra As Integer = 8
        '+++++++++++++ Columnnas dede y Hasta Colorear +++++++++
        Dim ColumnaInicio As Integer = 1
        Dim ColumnaFin As Integer = 31 '29
        Dim t As Integer

        FOne.Grilla = Me.Grilla
        If Activo.CodCampaniaActualMms = "36" Then
            FOne.CargarTemplate(Application.StartupPath & "\ARE\Reporte_CPR_Are.vts")
        ElseIf Activo.CodCampaniaActualMms = "35" Then
            FOne.CargarTemplate(Application.StartupPath & "\MPG\Reporte_CPR_MPG.vts")
        ElseIf Activo.CodCampaniaActualMms = "41" Then '16/01/2015
            FOne.CargarTemplate(Application.StartupPath & "\FWD\Reporte_CPR_Fwd.vts")
        ElseIf Activo.CodCampaniaActualMms = "42" Then '08/06/2015
            FOne.CargarTemplate(Application.StartupPath & "\SCL\Reporte_CPR_Scl.vts")
        ElseIf Activo.CodCampaniaActualMms = "39" Then '08/06/2015
            FOne.CargarTemplate(Application.StartupPath & "\HSP\Reporte_CPR_Hsp.vts")
        End If

        Fila = 9
        ColumnaEverest = 1

        '++++ Agrego una fila en blanco en la primer fila del reporte ++++++++
        Dim z As Integer
        Dim ColumnaMax As Integer = 31
        For z = 1 To ColumnaMax
            FOne.CargarDato("", 8, z, True)
        Next
        '++++++++++++++++++++++++++++++++++++++++++++++++++

        For i = 0 To DtDatosCompletos.Rows.Count - 1
            For j = 1 To DtDatosCompletos.Columns.Count
                If j = 40 Then '38
                    If DtDatosCompletos.Rows(i)("Control").ToString <> "vacio" Then
                        Select Case DtDatosCompletos.Rows(i)("Control").ToString
                            Case "rojo"
                                Dim FormatoCelda As VCF150.F1CellFormat
                                FormatoCelda = FOne.Grilla.CreateNewCellFormat
                                With FormatoCelda
                                    .FontBold = True
                                End With
                                For t = 29 To ColumnaFin
                                    FOne.Grilla.SetActiveCell(Fila, t)
                                    FOne.Grilla.set_PaletteEntry(20, RGB(255, 0, 0))  ' rojo
                                    FOne.Grilla.SetPattern(1, RGB(255, 0, 0), RGB(255, 0, 0))
                                    FOne.Grilla.SetCellFormat(FormatoCelda)
                                Next
                            Case "naranja"
                                Dim FormatoCelda As VCF150.F1CellFormat
                                FormatoCelda = FOne.Grilla.CreateNewCellFormat
                                With FormatoCelda
                                    .FontBold = True
                                End With
                                For t = 29 To ColumnaFin
                                    FOne.Grilla.SetActiveCell(Fila, t)
                                    FOne.Grilla.set_PaletteEntry(21, RGB(255, 128, 0))
                                    FOne.Grilla.SetPattern(1, RGB(255, 128, 0), RGB(255, 128, 0))
                                    FOne.Grilla.SetCellFormat(FormatoCelda)
                                Next
                            Case "amarillo"
                                Dim FormatoCelda As VCF150.F1CellFormat
                                FormatoCelda = FOne.Grilla.CreateNewCellFormat
                                With FormatoCelda
                                    .FontBold = True
                                End With
                                For t = 29 To ColumnaFin
                                    FOne.Grilla.SetActiveCell(Fila, t)
                                    FOne.Grilla.set_PaletteEntry(22, RGB(255, 255, 0))
                                    FOne.Grilla.SetPattern(1, RGB(255, 255, 0), RGB(255, 255, 0))
                                    FOne.Grilla.SetCellFormat(FormatoCelda)
                                Next
                        End Select
                    End If
                End If
                If j = 40 Then
                    Exit For
                End If
                If j = 1 Then 'Columna Canal
                    Cadena = DtDatosCompletos.Rows(i)("cadena").ToString.Split("[")
                    texto = Cadena(0).ToString
                    FOne.CargarDato(texto, Fila, ColExCanal, True)
                    ColumnaEverest += 1
                End If
                If j >= 9 Then
                    Select Case j
                        Case 10 'Columna Fecha Spots 
                            texto = Date.Parse(DtDatosCompletos.Rows(i)("F_SPOT").ToShortDateString)
                            FOne.CargarDato(texto, Fila, ColExFechaPlanificado, True)
                        Case 11 'Columna Hora Spot
                            texto = DtDatosCompletos.Rows(i)(11).ToString
                            FOne.CargarDato(texto, Fila, ColExHoraPlanificado, True)
                        Case 24 'Columna CPR Planificado
                            If Not DBNull.Value.Equals(DtDatosCompletos.Rows(i)("Rating")) Then
                                If DtDatosCompletos.Rows(i)("Rating") = "0" Then
                                    texto = "0"
                                Else
                                    texto = Valores.Redondear(Valores.CastNulo(IIf(IsDBNull(DtDatosCompletos.Rows(i)("TarifaNeta")), 0, DtDatosCompletos.Rows(i)("TarifaNeta")) / DtDatosCompletos.Rows(i)("Rating")))
                                    If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then ' Cliente Claro
                                        texto = texto
                                    Else
                                        texto = CStr(CInt(texto))
                                    End If
                                End If
                            Else
                                texto = "0"
                            End If
                            FOne.CargarDato(texto, Fila, ColExCPRPlanificado, True)
                        Case 35 'Columna Diferencia Inversion Real 
                            texto = Math.Round(Double.Parse(DtDatosCompletos.Rows(i)(35)), 2)
                            FOne.CargarDato(texto, Fila, ColumnaEverest, False)
                        Case 36 'Columna Diferencia Inversion Neta 
                            texto = Math.Round(Double.Parse(DtDatosCompletos.Rows(i)(36)), 2)
                            FOne.CargarDato(texto, Fila, ColumnaEverest, True)
                        Case 37 'Columna Diferencia Rating 
                            texto = Math.Round(Double.Parse(DtDatosCompletos.Rows(i)(37)), 2)
                            FOne.CargarDato(texto, Fila, ColumnaEverest, True)
                        Case 38 'Columna Diferencia Rating Porcentaje
                            texto = Math.Round(Double.Parse(DtDatosCompletos.Rows(i)(38)), 2)
                            FOne.CargarDato(texto, Fila, ColumnaEverest, True)
                        Case Else
                            If j < 39 Then
                                texto = DtDatosCompletos.Rows(i)(j).ToString()
                                FOne.CargarDato(texto, Fila, ColumnaEverest, True)
                            End If
                    End Select
                    '+++++++++++++++++++++++++++++ Asigno los formatos a las celdas ++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Select Case ColumnaEverest
                        Case 3 ' Formato Fecha
                            Dim ValorFecha As String
                            FOne.Grilla.SetActiveCell(Fila, ColumnaEverest)
                            ValorFecha = FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString
                            FOne.Grilla.set_EntryRC(Fila, ColumnaEverest, Format(CDate(ValorFecha), "short date"))
                        Case 5, 6, 9, 10, 11, 12, 13, 14, 15, 16, 21, 25, 26, 27, 28, 29 ' Formato decimal 
                            Dim ValorDecimal As Decimal
                            FOne.Grilla.SetActiveCell(Fila, ColumnaEverest)
                            If IsNumeric(FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString()) Then
                                ValorDecimal = FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString()
                                FOne.Grilla.set_NumberRC(Fila, ColumnaEverest, Format(CDec(ValorDecimal), "#,##0.00"))
                            End If
                        Case 7, 27  ' Formato entero 
                            Dim ValorEntero As String ' Columnas de Duarcion Planificacion y Emision
                            FOne.Grilla.SetActiveCell(Fila, ColumnaEverest)
                            ValorEntero = FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString()
                            FOne.Grilla.set_NumberRC(Fila, ColumnaEverest, Format(CInt(ValorEntero)))
                        Case 17, 25 ' Columnas de CPR segun el Cliente acepta tipo dato ( Entero y Decimal )
                            If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then 'Clientes con decimales
                                Dim ValorDecimal As String
                                FOne.Grilla.SetActiveCell(Fila, ColumnaEverest)
                                ValorDecimal = FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString()
                                FOne.Grilla.set_NumberRC(Fila, ColumnaEverest, Format(CDec(ValorDecimal), "#,##0.00"))
                            Else  'Clientes con enteros
                                Dim ValorEntero As String
                                FOne.Grilla.SetActiveCell(Fila, ColumnaEverest)
                                ValorEntero = FOne.Grilla.get_TextRC(Fila, ColumnaEverest).ToString()
                                FOne.Grilla.set_NumberRC(Fila, ColumnaEverest, Format(CInt(ValorEntero)))
                            End If
                    End Select
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    ColumnaEverest += 1
                End If
            Next j
            ColumnaEverest = 1
            Fila += 1
        Next i

        '+++++++++++++ Recorro y Cargo los datos de los desgloses Totales +++++++++++++++++++++++
        Dim FilaDesglose As Integer = 8
        Dim FilaTotalCampania As Integer = 12

        For x = 0 To DtDatosdesglose.Rows.Count - 1
            For h = 1 To DtDatosdesglose.Columns.Count
                If h = 24 Then
                    Exit For
                End If
                Select Case CInt(DtDatosdesglose.Rows(x)("CodSoporte"))
                    Case 1870 ' Canal 9
                        FilaDesglose = 11
                    Case 13 'Canal 13
                        FilaDesglose = 8
                    Case 11 ' Telefe
                        FilaDesglose = 9
                    Case 48 ' America
                        FilaDesglose = 10
                End Select
                'LC 28/03/2014 Se agregaron dos TRY \ CATCH para evitar el error de conversion de string a decimal
                Try
                    Select Case h
                        '++++++++++++++++++++++++++++++++++++++ Datos Planificacion +++++++++++++++++++++++++++++++
                        Case 2
                            texto = DtDatosdesglose.Rows(x)("PlaInversionNeta").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExInversinNetaPlanificada, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExInversinNetaPlanificada)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExInversinNetaPlanificada).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExInversinNetaPlanificada, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 3
                            texto = DtDatosdesglose.Rows(x)("PlaGRPS").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExGRPSPlanificados, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExGRPSPlanificados)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExGRPSPlanificados).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExGRPSPlanificados, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 4
                            texto = DtDatosdesglose.Rows(x)("PlaDuracionPromedio").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExDuracionPromedioPlanificado, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExDuracionPromedioPlanificado)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExDuracionPromedioPlanificado).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExDuracionPromedioPlanificado, Format(CDec(ValorDecimal), "#,##0.00"))

                            '+++++++++++ Con valores entero ++++++++++++++++++
                            'ValorEntero = FOne.Grilla.get_TextRC(FilaDesglose, ColExDuracionPromedioPlanificado).ToString()
                            'FOne.Grilla.set_NumberRC(FilaDesglose, ColExDuracionPromedioPlanificado, Format(CInt(ValorEntero)))
                            '+++++++++++++++++++++++++++++++++++++++++++
                        Case 5
                            texto = DtDatosdesglose.Rows(x)("PlaCPRPromedio").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExCPRPromedioPlanificado, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExCPRPromedioPlanificado)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExCPRPromedioPlanificado).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExCPRPromedioPlanificado, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 6
                            texto = DtDatosdesglose.Rows(x)("PlaSOIxCanal").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExCOIxCanalPlanificado, True)
                            '++++++++++++++++++++++++++++++++++++ Datos Emitios ++++++++++++++++++++++++++++++++++++++
                        Case 7
                            texto = DtDatosdesglose.Rows(x)("EmiInversionNeta").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExInversionNetaRealEmitido, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExInversionNetaRealEmitido)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExInversionNetaRealEmitido).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExInversionNetaRealEmitido, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 8
                            texto = DtDatosdesglose.Rows(x)("EmiGRPS").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExGRPSReal, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExGRPSReal)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExGRPSReal).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExGRPSReal, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 9
                            texto = DtDatosdesglose.Rows(x)("EmiDuracionPromedio").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExDuracionPromedioEmitido, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExDuracionPromedioEmitido)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExDuracionPromedioEmitido).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExDuracionPromedioEmitido, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 10
                            texto = DtDatosdesglose.Rows(x)("EmiCPRPromedio").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExPromedioEmitido, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColExPromedioEmitido)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColExPromedioEmitido).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColExPromedioEmitido, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 11
                            texto = DtDatosdesglose.Rows(x)("EmiSOIxCanal").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColExSOIcCanalEmitido, True)
                            '+++++++++++++++++++ Fila de Totales de Campañas ++++++++++++++++++++++++++
                        Case 12
                            texto = DtDatosdesglose.Rows(x)("PlaTotalInversionCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExInversinNetaPlanificada, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExInversinNetaPlanificada)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExInversinNetaPlanificada).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExInversinNetaPlanificada, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExInversinNetaPlanificada)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 13
                            texto = DtDatosdesglose.Rows(x)("PlaTotalGrpsCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExGRPSPlanificados, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExGRPSPlanificados)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExGRPSPlanificados).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExGRPSPlanificados, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExGRPSPlanificados)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 14
                            texto = DtDatosdesglose.Rows(x)("PlaTotalDuracionProCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExDuracionPromedioPlanificado, True)
                            Dim ValorEntero As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExDuracionPromedioPlanificado)
                            ValorEntero = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExDuracionPromedioPlanificado).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExDuracionPromedioPlanificado, Format(CInt(ValorEntero)))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExDuracionPromedioPlanificado)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 15
                            If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then 'Clientes con decimales
                                texto = DtDatosdesglose.Rows(x)("PlaTotalCPRCamp").ToString
                                FOne.CargarDato(texto, FilaTotalCampania, ColExCPRPromedioPlanificado, True)
                                Dim ValorDecimal As String
                                FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExCPRPromedioPlanificado)
                                ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExCPRPromedioPlanificado).ToString()
                                FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExCPRPromedioPlanificado, Format(CDec(ValorDecimal), "#,##0.00"))
                            Else  'Clientes con enteros
                                texto = DtDatosdesglose.Rows(x)("PlaTotalCPRCamp").ToString
                                FOne.CargarDato(texto, FilaTotalCampania, ColExCPRPromedioPlanificado, True)
                                Dim ValorEntero As String
                                FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExCPRPromedioPlanificado)
                                ValorEntero = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExCPRPromedioPlanificado).ToString()
                                FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExCPRPromedioPlanificado, Format(CDec(ValorEntero), "#,##0.00"))
                            End If
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExCPRPromedioPlanificado)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 16
                            texto = DtDatosdesglose.Rows(x)("PlaTotalSOIxCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExCOIxCanalPlanificado, True)
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExCOIxCanalPlanificado)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 17
                            texto = DtDatosdesglose.Rows(x)("EmiTotalInversionCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExInversionNetaRealEmitido, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExInversionNetaRealEmitido)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExInversionNetaRealEmitido).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExInversionNetaRealEmitido, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExInversionNetaRealEmitido)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 18
                            texto = DtDatosdesglose.Rows(x)("EmiTotalGrpsCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExGRPSReal, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExGRPSReal)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExGRPSReal).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExGRPSReal, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExGRPSReal)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 19
                            texto = DtDatosdesglose.Rows(x)("EmiTotalDuracionProCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExDuracionPromedioEmitido, True)
                            Dim ValorEntero As String
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExDuracionPromedioEmitido)
                            ValorEntero = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExDuracionPromedioEmitido).ToString()
                            FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExDuracionPromedioEmitido, Format(CInt(ValorEntero)))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExDuracionPromedioEmitido)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 20
                            If Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Or Activo.IDCliente = 227 Then 'Clientes con decimales
                                texto = DtDatosdesglose.Rows(x)("EmiTotalCPRCamp").ToString
                                FOne.CargarDato(texto, FilaTotalCampania, ColExPromedioEmitido, True)
                                Dim ValorDecimal As String
                                FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExPromedioEmitido)
                                ValorDecimal = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExPromedioEmitido).ToString()
                                FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExPromedioEmitido, Format(CDec(ValorDecimal), "#,##0.00"))
                            Else  'Clientes con enteros
                                texto = DtDatosdesglose.Rows(x)("EmiTotalCPRCamp").ToString
                                FOne.CargarDato(texto, FilaTotalCampania, ColExPromedioEmitido, True)
                                Dim ValorEntero As String
                                FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExPromedioEmitido)
                                ValorEntero = FOne.Grilla.get_TextRC(FilaTotalCampania, ColExPromedioEmitido).ToString()
                                FOne.Grilla.set_NumberRC(FilaTotalCampania, ColExPromedioEmitido, Format(CDec(ValorEntero), "#,##0.00"))
                            End If
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExPromedioEmitido)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 21
                            texto = DtDatosdesglose.Rows(x)("EmiTotalSOIxCamp").ToString
                            FOne.CargarDato(texto, FilaTotalCampania, ColExSOIcCanalEmitido, True)
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaTotalCampania, ColExSOIcCanalEmitido)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 22
                            texto = DtDatosdesglose.Rows(x)("DiferenciaInversion").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColDiferenciaInversionDesglose, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColDiferenciaInversionDesglose)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColDiferenciaInversionDesglose).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColDiferenciaInversionDesglose, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColDiferenciaInversionDesglose)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                        Case 23
                            texto = DtDatosdesglose.Rows(x)("DiferenciaGrps").ToString
                            FOne.CargarDato(texto, FilaDesglose, ColDiferenciaGrpsDesglose, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColDiferenciaGrpsDesglose)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesglose, ColDiferenciaGrpsDesglose).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesglose, ColDiferenciaGrpsDesglose, Format(CDec(ValorDecimal), "#,##0.00"))
                            Dim FormatoCelda As VCF150.F1CellFormat
                            FormatoCelda = FOne.Grilla.CreateNewCellFormat
                            FormatoCelda.FontBold = True
                            FOne.Grilla.SetActiveCell(FilaDesglose, ColDiferenciaGrpsDesglose)
                            FOne.Grilla.SetCellFormat(FormatoCelda)
                    End Select
                Catch ex As Exception

                End Try
            Next h
        Next x

        '++++++++++++++++++Totales de Diferencias entre Real y Planificado ++++++++++++++++++++++++++++++++++++++++
        Dim totalDiferenciaInvNeta As Decimal
        Dim totalDiferenciaGRPS As Decimal

        For Each dr As DataRow In DtDatosdesglose.Rows
            totalDiferenciaInvNeta += Convert.ToDecimal(dr("DiferenciaInversion"))
            totalDiferenciaGRPS += Convert.ToDecimal(dr("DiferenciaGrps"))
        Next

        FOne.CargarDato(totalDiferenciaGRPS.ToString(), FilaTotalCampania, ColDiferenciaGrpsDesglose, True)
        FOne.Grilla.SetActiveCell(FilaTotalCampania, ColDiferenciaGrpsDesglose)
        Dim ValorDecimal2 As String = FOne.Grilla.get_TextRC(FilaTotalCampania, ColDiferenciaGrpsDesglose).ToString()
        FOne.Grilla.set_NumberRC(FilaTotalCampania, ColDiferenciaGrpsDesglose, Format(CDec(ValorDecimal2), "#,##0.00"))
        Dim FormatoCelda2 As VCF150.F1CellFormat
        FormatoCelda2 = FOne.Grilla.CreateNewCellFormat
        FormatoCelda2.FontBold = True
        FOne.Grilla.SetActiveCell(FilaTotalCampania, ColDiferenciaGrpsDesglose)
        FOne.Grilla.SetCellFormat(FormatoCelda2)

        FOne.CargarDato(totalDiferenciaInvNeta.ToString(), FilaTotalCampania, ColDiferenciaInversionDesglose, True)
        FOne.Grilla.SetActiveCell(FilaTotalCampania, ColDiferenciaInversionDesglose)
        ValorDecimal2 = FOne.Grilla.get_TextRC(FilaTotalCampania, ColDiferenciaInversionDesglose).ToString()
        FOne.Grilla.set_NumberRC(FilaTotalCampania, ColDiferenciaInversionDesglose, Format(CDec(ValorDecimal2), "#,##0.00"))
        FormatoCelda2 = FOne.Grilla.CreateNewCellFormat
        FormatoCelda2.FontBold = True
        FOne.Grilla.SetActiveCell(FilaTotalCampania, ColDiferenciaInversionDesglose)
        FOne.Grilla.SetCellFormat(FormatoCelda2)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        '+++++++++++++ Recorro y Cargo los datos de los desgloses Totales Seguimientos +++++++++++++++++++++++
        Dim FilaDesgloseSeguimiento As Integer = 8

        For r = 0 To DtDesgloseSeguimientoFinal.Rows.Count - 1
            For e = 1 To DtDesgloseSeguimientoFinal.Columns.Count
                'LC 28/03/2014 Se agregaron dos TRY \ CATCH para evitar el error de conversion de string a decimal
                Try
                    Select Case e
                        Case 1
                            texto = DtDesgloseSeguimientoFinal.Rows(r)("PlaTotalPautaCPRPromedio").ToString
                            FOne.CargarDato(texto, FilaDesgloseSeguimiento, ColExPlaCPRPromedio, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesgloseSeguimiento, ColExPlaCPRPromedio)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesgloseSeguimiento, ColExPlaCPRPromedio).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesgloseSeguimiento, ColExPlaCPRPromedio, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 2
                            texto = DtDesgloseSeguimientoFinal.Rows(r)("EmiTotalPautaCPRPromedio").ToString
                            FOne.CargarDato(texto, FilaDesgloseSeguimiento, ColExEmiCPRPromedio, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesgloseSeguimiento, ColExEmiCPRPromedio)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesgloseSeguimiento, ColExEmiCPRPromedio).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesgloseSeguimiento, ColExEmiCPRPromedio, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 3
                            texto = DtDesgloseSeguimientoFinal.Rows(r)("TotalOrdenCompra").ToString
                            FOne.CargarDato(texto, FilaDesgloseSeguimiento, ColExTotalOrdenCompra, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesgloseSeguimiento, ColExTotalOrdenCompra)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesgloseSeguimiento, ColExTotalOrdenCompra).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesgloseSeguimiento, ColExTotalOrdenCompra, Format(CDec(ValorDecimal), "#,##0.00"))
                        Case 4
                            texto = DtDesgloseSeguimientoFinal.Rows(r)("DifTotalNetoRealCompra").ToString
                            FOne.CargarDato(texto, FilaDesgloseSeguimiento, ColExTotalDiferenciaNetoCompra, True)
                            Dim ValorDecimal As String
                            FOne.Grilla.SetActiveCell(FilaDesgloseSeguimiento, ColExTotalDiferenciaNetoCompra)
                            ValorDecimal = FOne.Grilla.get_TextRC(FilaDesgloseSeguimiento, ColExTotalDiferenciaNetoCompra).ToString()
                            FOne.Grilla.set_NumberRC(FilaDesgloseSeguimiento, ColExTotalDiferenciaNetoCompra, Format(CDec(ValorDecimal), "#,##0.00"))
                    End Select
                Catch ex As Exception

                End Try
            Next e
            FilaDesgloseSeguimiento += 1
        Next r

        '+++++++++++++++++ Configuro los datos de las celdas de referencias +++++++++++++++++++++++++++
        Dim FilaReferencia As Integer = 15
        Dim ColuReferencia As Integer = 33
        Dim ColuInformacion As Integer = 34
        Dim f As Integer
        Dim TextoCeldaNaranja As String = " Valor del Porcentaje de Rating Mayor al 20 Porciento. "
        Dim TextoCeldaAmarillo As String = " Valor del Porcentaje de Rating Entre el 10 y 20 Porciento. "
        Dim TextoCeldaRoja As String = " No se encuentran avisos asociados en MMS. "

        For f = 0 To 3
            Dim FormatoCelda As VCF150.F1CellFormat
            Dim FormatoCInfo As VCF150.F1CellFormat
            FormatoCelda = FOne.Grilla.CreateNewCellFormat
            FormatoCInfo = FOne.Grilla.CreateNewCellFormat
            FOne.Grilla.SetActiveCell(FilaReferencia, ColuReferencia)
            Select Case f
                Case 0
                    FOne.Grilla.set_PaletteEntry(22, RGB(255, 255, 0)) 'Amarillo
                    FOne.Grilla.SetPattern(1, RGB(255, 255, 0), RGB(255, 255, 0))
                    FOne.Grilla.SetCellFormat(FormatoCelda)
                    FOne.Grilla.SetActiveCell(FilaReferencia, ColuInformacion)
                    FOne.Grilla.set_TextRC(FilaReferencia, ColuInformacion, TextoCeldaAmarillo)
                    FormatoCInfo.FontBold = True
                    FOne.Grilla.SetCellFormat(FormatoCInfo)
                Case 1
                    FOne.Grilla.set_PaletteEntry(21, RGB(255, 128, 0)) 'Naranja
                    FOne.Grilla.SetPattern(1, RGB(255, 128, 0), RGB(255, 128, 0))
                    FOne.Grilla.SetCellFormat(FormatoCelda)
                    FOne.Grilla.SetActiveCell(FilaReferencia, ColuInformacion)
                    FOne.Grilla.set_TextRC(FilaReferencia, ColuInformacion, TextoCeldaNaranja)
                    FormatoCInfo.FontBold = True
                    FOne.Grilla.SetCellFormat(FormatoCInfo)
                Case 2
                    FOne.Grilla.SetPattern(1, 1583103, 1583103) 'Rojo
                    FOne.Grilla.SetCellFormat(FormatoCelda)
                    FOne.Grilla.SetActiveCell(FilaReferencia, ColuInformacion)
                    FOne.Grilla.set_TextRC(FilaReferencia, ColuInformacion, TextoCeldaRoja)
                    FormatoCInfo.FontBold = True
                    FOne.Grilla.SetCellFormat(FormatoCInfo)
            End Select
            FilaReferencia += 1
        Next
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        ' Cuadro de resumen de Indicadores de GPR (AN 06-11-2015)
        Dim filaOrigen As Integer = 20
        Dim filaOrigenInversion As Integer = filaOrigen + 18
        Dim columnaOrigen As Integer = 33

        For cuadroId As Integer = 1 To 2

            If cuadroId = 2 Then
                filaOrigen = 28
            End If

            FOne.CargarDato(IIf(cuadroId = 1, "Planificado", "Ordenado / Emitido"), filaOrigen, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen, columnaOrigen, filaOrigen, columnaOrigen + 1 + (DtFranjas.Rows.Count * 2))
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("Canal", filaOrigen + 1, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 1, columnaOrigen, filaOrigen + 1, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("", filaOrigen + 2, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 2, columnaOrigen, filaOrigen + 2, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            For iContador As Integer = 0 To DtFranjas.Rows.Count - 1
                FOne.CargarDato(DtFranjas.Rows(iContador)("DESCRIPCION"), filaOrigen + 1, columnaOrigen + ((iContador * 2) + 1))
                FOne.Grilla.SetSelection(filaOrigen + 1, columnaOrigen + ((iContador * 2) + 1), filaOrigen + 1, columnaOrigen + ((iContador * 2) + 2))
                FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
                FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

                FOne.CargarDato("GRP", filaOrigen + 2, columnaOrigen + ((iContador * 2) + 1))
                FOne.Grilla.SetSelection(filaOrigen + 2, columnaOrigen + ((iContador * 2) + 1), filaOrigen + 2, columnaOrigen + ((iContador * 2) + 1))
                FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
                FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

                FOne.CargarDato("SOV%", filaOrigen + 2, columnaOrigen + ((iContador * 2) + 2))
                FOne.Grilla.SetSelection(filaOrigen + 2, columnaOrigen + ((iContador * 2) + 2), filaOrigen + 2, columnaOrigen + ((iContador * 2) + 2))
                FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
                FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))
            Next

            FOne.CargarDato("Total GRP", filaOrigen + 1, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1)
            FOne.Grilla.SetSelection(filaOrigen + 1, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1, filaOrigen + 1, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("", filaOrigen + 2, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1)
            FOne.Grilla.SetSelection(filaOrigen + 2, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1, filaOrigen + 2, columnaOrigen + (DtFranjas.Rows.Count * 2) + 1)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("Canal 13", filaOrigen + 3, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 3, columnaOrigen, filaOrigen + 3, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("Telefe", filaOrigen + 4, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 4, columnaOrigen, filaOrigen + 4, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("America", filaOrigen + 5, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 5, columnaOrigen, filaOrigen + 5, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("Canal 9", filaOrigen + 6, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 6, columnaOrigen, filaOrigen + 6, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            FOne.CargarDato("Total Campaña", filaOrigen + 7, columnaOrigen)
            FOne.Grilla.SetSelection(filaOrigen + 7, columnaOrigen, filaOrigen + 7, columnaOrigen)
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

            Dim row, column As Integer
            row = IIf(cuadroId = 2, 5, 0)
            column = 0
            For filaDato As Integer = filaOrigen + 3 To filaOrigen + 7
                column = 0
                For columnaDato As Integer = columnaOrigen + 1 To columnaOrigen + (DtFranjas.Rows.Count * 2) + 1
                    FOne.CargarDato(Format(dtCuadroResumen(row)(column), "#,##0.00"), filaDato, columnaDato)
                    FOne.Grilla.SetSelection(filaDato, columnaDato, filaDato, columnaDato)
                    FOne.Grilla.SetCellFormat(GetFormatoCeldaDatoGPR())
                    column = column + 1
                Next
                row = row + 1
            Next

        Next

        ' Cuadro de Inversion (AN 29-02-2016)
        FOne.CargarDato("PLANIFICADO Everest", filaOrigenInversion, columnaOrigen + 1)
        FOne.Grilla.SetSelection(filaOrigenInversion, columnaOrigen + 1, filaOrigenInversion, columnaOrigen + 2)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("POST", filaOrigenInversion, columnaOrigen + 3)
        FOne.Grilla.SetSelection(filaOrigenInversion, columnaOrigen + 3, filaOrigenInversion, columnaOrigen + 4 + (DtFranjas.Rows.Count * 2))
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(True))
        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))

        FOne.CargarDato("", filaOrigenInversion, columnaOrigen + 5 + (DtFranjas.Rows.Count * 2))
        FOne.Grilla.SetSelection(filaOrigenInversion, columnaOrigen + 5 + (DtFranjas.Rows.Count * 2), filaOrigenInversion, columnaOrigen + 5 + (DtFranjas.Rows.Count * 2))
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))

        FOne.CargarDato("CANAL", filaOrigenInversion + 1, columnaOrigen)
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen, filaOrigenInversion + 1, columnaOrigen)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        For iContador As Integer = 0 To DtFranjas.Rows.Count - 1
            FOne.CargarDato(DtFranjas.Rows(iContador)("DESCRIPCION"), filaOrigenInversion + 1, columnaOrigen + (iContador + 5))
            FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + (iContador + 5), filaOrigenInversion + 1, columnaOrigen + (iContador + 5))
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))
        Next

        For iContador As Integer = 0 To DtFranjas.Rows.Count - 1
            FOne.CargarDato("PBR " + DtFranjas.Rows(iContador)("DESCRIPCION"), filaOrigenInversion + 1, columnaOrigen + (iContador + 5 + DtFranjas.Rows.Count))
            FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + (iContador + 5 + DtFranjas.Rows.Count), filaOrigenInversion + 1, columnaOrigen + (iContador + 5 + DtFranjas.Rows.Count))
            FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
            FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))
        Next

        FOne.CargarDato("DIFERENCIA $$$", filaOrigenInversion + 1, columnaOrigen + (5 + (DtFranjas.Rows.Count * 2)))
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + (5 + (DtFranjas.Rows.Count * 2)), filaOrigenInversion + 1, columnaOrigen + (5 + (DtFranjas.Rows.Count * 2)))
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))

        FOne.Grilla.SetColWidth(columnaOrigen + (5 + (DtFranjas.Rows.Count * 2)), columnaOrigen + (5 + (DtFranjas.Rows.Count * 2)) + 1, 4000, False)

        FOne.CargarDato("Canal 13", filaOrigenInversion + 2, columnaOrigen)
        FOne.Grilla.SetSelection(filaOrigenInversion + 2, columnaOrigen, filaOrigenInversion + 2, columnaOrigen)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("Telefe", filaOrigenInversion + 3, columnaOrigen)
        FOne.Grilla.SetSelection(filaOrigenInversion + 3, columnaOrigen, filaOrigenInversion + 3, columnaOrigen)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("America", filaOrigenInversion + 4, columnaOrigen)
        FOne.Grilla.SetSelection(filaOrigenInversion + 4, columnaOrigen, filaOrigenInversion + 4, columnaOrigen)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("Canal 9", filaOrigenInversion + 5, columnaOrigen)
        FOne.Grilla.SetSelection(filaOrigenInversion + 5, columnaOrigen, filaOrigenInversion + 5, columnaOrigen)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("$$$", filaOrigenInversion + 1, columnaOrigen + 1)
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + 1, filaOrigenInversion + 1, columnaOrigen + 1)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("%", filaOrigenInversion + 1, columnaOrigen + 2)
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + 2, filaOrigenInversion + 1, columnaOrigen + 2)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))

        FOne.CargarDato("$$$", filaOrigenInversion + 1, columnaOrigen + 3)
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + 3, filaOrigenInversion + 1, columnaOrigen + 3)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))

        FOne.CargarDato("%", filaOrigenInversion + 1, columnaOrigen + 4)
        FOne.Grilla.SetSelection(filaOrigenInversion + 1, columnaOrigen + 4, filaOrigenInversion + 1, columnaOrigen + 4)
        FOne.Grilla.SetCellFormat(GetFormatoCeldaGPR(False))
        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))

        Dim rowInversion As Integer = 0
        Dim columnInversion As Integer = 0
        For filaDato As Integer = filaOrigenInversion + 2 To filaOrigenInversion + 6
            columnInversion = 0
            For columnaDato As Integer = columnaOrigen + 1 To columnaOrigen + (5 + (DtFranjas.Rows.Count * 2))
                If Not ((columnaDato = columnaOrigen + 2 Or columnaDato = columnaOrigen + 4) And filaDato = filaOrigenInversion + 6) Then
                    FOne.CargarDato(Format(dtCuadroInversion(rowInversion)(columnInversion), "#,##0.00"), filaDato, columnaDato)
                    FOne.Grilla.SetSelection(filaDato, columnaDato, filaDato, columnaDato)
                    FOne.Grilla.SetCellFormat(GetFormatoCeldaDatoGPR())

                    If columnaDato = columnaOrigen + 2 Then
                        FOne.Grilla.SetPattern(1, RGB(223, 223, 223), RGB(223, 223, 223))
                    End If

                    If columnaDato = columnaOrigen + 3 Then
                        FOne.Grilla.SetPattern(1, RGB(255, 128, 0), RGB(255, 128, 0))
                    End If

                    If columnaDato = columnaOrigen + 4 Then
                        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))
                    End If

                    If filaDato = filaOrigenInversion + 6 And columnaDato > columnaOrigen + 2 And columnaDato <> columnaOrigen + 5 + (DtFranjas.Rows.Count * 2) Then
                        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))
                    End If

                    If filaDato = filaOrigenInversion + 6 And columnaDato > columnaOrigen + 4 + DtFranjas.Rows.Count And columnaDato <> columnaOrigen + 5 + (DtFranjas.Rows.Count * 2) Then
                        FOne.CargarDato(String.Empty, filaDato, columnaDato)
                    End If

                    If filaDato <> filaOrigenInversion + 6 And columnaDato = columnaOrigen + 5 + (DtFranjas.Rows.Count * 2) Then
                        FOne.Grilla.SetPattern(1, RGB(187, 182, 252), RGB(187, 182, 252))
                    End If

                    If filaDato = filaOrigenInversion + 6 And columnaDato = columnaOrigen + 5 + (DtFranjas.Rows.Count * 2) Then
                        Dim FormatoCelda As VCF150.F1CellFormat
                        FormatoCelda = FOne.Grilla.CreateNewCellFormat
                        With FormatoCelda
                            .FontBold = True
                        End With
                        FOne.Grilla.SetCellFormat(FormatoCelda)
                    End If

                End If
                columnInversion = columnInversion + 1
            Next
            rowInversion = rowInversion + 1
        Next

        ' Pongo el foco en la primer celda de la grilla.
        FOne.Grilla.SetActiveCell(1, 1)
        FOne.Grilla.ShowActiveCell()

    End Function

#End Region

#Region " Funciones de Cuadro Resumen GPR (AN 09-11-2015) "
    Private Function GetFormatoCeldaTotalesTemas(ByVal merge As Boolean) As VCF150.F1CellFormat
        Dim formatoCeldaGPR As VCF150.F1CellFormat
        formatoCeldaGPR = FOne.Grilla.CreateNewCellFormat()
        If merge Then
            formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenterAcrossCells
        Else
            formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenter
        End If
        formatoCeldaGPR.FontBold = True
        formatoCeldaGPR.FontSize = 10
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1LeftBorder) = VCF150.F1BorderStyleConstants.F1BorderMedium
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1RightBorder) = VCF150.F1BorderStyleConstants.F1BorderMedium
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1TopBorder) = VCF150.F1BorderStyleConstants.F1BorderMedium
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1BottomBorder) = VCF150.F1BorderStyleConstants.F1BorderMedium
        Return formatoCeldaGPR
    End Function
    Private Function GetFormatoCeldaGPR(ByVal merge As Boolean) As VCF150.F1CellFormat
        Dim formatoCeldaGPR As VCF150.F1CellFormat
        formatoCeldaGPR = FOne.Grilla.CreateNewCellFormat()
        If merge Then
            formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenterAcrossCells
        Else
            formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignCenter
        End If
        formatoCeldaGPR.FontBold = True
        formatoCeldaGPR.FontSize = 10
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1LeftBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1RightBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1TopBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1BottomBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        Return formatoCeldaGPR
    End Function

    Private Function GetFormatoCeldaDatoGPR() As VCF150.F1CellFormat
        Dim formatoCeldaGPR As VCF150.F1CellFormat
        formatoCeldaGPR = FOne.Grilla.CreateNewCellFormat()
        formatoCeldaGPR.AlignHorizontal = VCF150.F1HAlignConstants.F1HAlignRight
        formatoCeldaGPR.FontSize = 10
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1LeftBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1RightBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1TopBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        formatoCeldaGPR.BorderStyle(VCF150.F1BorderConstants.F1BottomBorder) = VCF150.F1BorderStyleConstants.F1BorderThin
        Return formatoCeldaGPR
    End Function
#End Region


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case e.Button.Tag.ToString.ToLower
            Case "imprimir"
                Try
                    FOne.Grilla.FilePrint(True)
                Catch ex As Exception
                End Try

            Case "exportar"
                Try
                    Dim archivo As String

                    archivo = ""
                    FOne.Grilla.SaveFileDlg("Exportar Reporte", archivo, 4)
                    If archivo <> "" Then
                        FOne.Grilla.Write(archivo, 4)

                        ''AS 2015/03
                        'Dim ruta As String = Framework.ExportacionUtil.ParametrosExportacionLegajos.RutaExportacionControlMonitor
                        'Dim nombreArchivo As String = String.Format("{0}_{1}.xls", Activo.IDCompaniaMMS, _nroPresupuesto)
                        'Dim rutaCompleta As String = String.Format(" {0}{1}", ruta, nombreArchivo)

                        'Try

                        '    File.Copy(archivo, rutaCompleta)
                        'Catch ex As Exception

                        '    'Reportes.Util.LogExportacionLegajo(param);

                        'End Try
                    End If
                Catch ex As Exception
                End Try
        End Select
    End Sub

    Private Function GetLetras(ByVal Col As Integer) As String
        Dim ret As Integer

        ret = Int(Col / 26)

        Return IIf(ret = 0, "", Chr(ret + 64)) & Chr(Col - (ret * 26) + 65)
    End Function


#Region " METODOS DE REPORTE TARIFAS TV" 'GWINKLER


    Public Sub ReporteTVAbierta(ByVal f_vigencia As Date, ByVal soporte As Integer, ByVal descripcion As String)

        FOne.Grilla = Me.Grilla

        Dim a, b As Integer

        Select Case Activo.IDMedio
            Case 1
                Me.Text = "Reporte Programación TV Abierta - Cliente Genérico"
                'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                FOne.CargarTemplate(Application.StartupPath & "\Comun\ReporteTarifasTV.vts") 'AG Unificacon 25/03/2013
                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                'FOne.CargarTemplate(Application.StartupPath & "\ReporteTarifasTV.vts")
            Case 6
                Me.Text = "Reporte Programación Radio Abierta - Cliente Genérico"
                'AG 26/03/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                FOne.CargarTemplate(Application.StartupPath & "\Comun\ReporteTarifasRadio.vts") 'AG Unificacon 25/03/2013
                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                'FOne.CargarTemplate(Application.StartupPath & "\ReporteTarifasRadio.vts")
        End Select

        For a = 2 To 8
            For b = 7 To 48 + 7
                FOne.CargarDato(" ", b, a, True)
            Next
        Next

        Dim t As New Tarifas_tv

        t.Id_medio = Activo.IDMedio
        t.Id_soporte = soporte
        t.Id_cliente = 0
        t.F_inicio_vig = f_vigencia.Date
        t.F_fin_vig = f_vigencia.Date.AddDays(6)


        Dim texto As String
        Dim dt As New DataTable
        Dim f, c, f2 As Integer

        Dim i As Integer
        Dim inicial, final As Integer

        inicial = 0
        final = 0
        dt = t.TraerReporteTarifas()
        Dim O As New System.UInt32

        FOne.Grilla.ShowRowHeading = False
        If Not dt Is Nothing Then
            Dim dr As DataRow
            For Each dr In dt.Rows
                inicial = 0
                final = 0

                texto = dr("PROGRAMA") + " (" + dr("hora inicio") + "-" + dr("hora fin") + ") " + Format(dr("Tarifa Bruta"), "0.00")
                f = dr("hora_inicio")
                f2 = dr("hora_fin")
                For i = 1 To 7
                    If Not dr(i) Is DBNull.Value Then
                        If dr(i).ToString = "X" Then

                            If inicial = 0 Then
                                inicial = i
                            Else
                                final = i
                            End If

                            If (inicial > 0 And final = 0) Then
                                ' es solo 1 programa ese dia
                                ' le hago un warp text
                                FOne.CargarDato(texto, f + 6, i + 1, True)
                                FOne.Grilla.SetSelection(f + 6, inicial + 1, f2 + 6, inicial + 1)
                                FOne.Grilla.SetAlignment(7, True, 2, 0)
                                FOne.Grilla.SetBorder(2, 0, 0, 0, 0, 1, O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"))
                            End If
                            If inicial > 0 And final > 0 Then
                                If FOne.LeerDato(f + 6, final + 1) = " " Then
                                    FOne.Grilla.ClearRange(f + 6, final + 1, f + 6, final + 1, VCF150.F1ClearTypeConstants.F1ClearValues)
                                End If
                                FOne.Grilla.SetSelection(f + 6, inicial + 1, f2 + 6, final + 1)
                                FOne.Grilla.SetAlignment(7, False, 2, 0)
                                FOne.Grilla.SetBorder(2, 0, 0, 0, 0, 1, O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"))
                            End If
                        Else
                            inicial = 0
                            final = 0
                        End If
                    Else

                        inicial = 0
                        final = 0
                        '  consecutivo = False

                    End If
                Next



            Next
        Else
            Mensajes.Mensaje("No hay programación vigente para ese periodo / soporte")
        End If
        FOne.CargarDato(descripcion, 4, 2)

        Dim fecha As String

        fecha = CStr(f_vigencia.Date) + " al " + CStr(f_vigencia.Date.AddDays(6).Date)
        FOne.CargarDato(fecha, 4, 7)
        FOne.Grilla.SetSelection(1, 1, 1, 1)
        FOne.Grilla.SetRowHeightAuto(3, 1, 48 + 7, 8, False)
    End Sub

#End Region

#Region " METODOS DE REPORTE TARIFAS PROMEDIO" 'CFANEGO


    Public Sub ReporteTarifaPromedio(ByVal f_vigencia_desde As Date, ByVal f_vigencia_hasta As Date)

        FOne.Grilla = Me.Grilla

        Dim a, b As Integer

        Me.Text = "Reporte Tarifa Promedio"
        FOne.CargarTemplate(Application.StartupPath & "\Comun\ReporteTarifasPromedio.vts") 'AG Unificacon 25/03/2013

        Dim t As New Tarifas_tv

        t.F_inicio_vig = f_vigencia_desde.Date
        t.F_fin_vig = f_vigencia_hasta.Date


        Dim texto As String
        Dim dt As New DataTable
        Dim O As New System.UInt32
        Dim f, c As Integer
        f = 0
        dt = t.TraerReporteTarifasPromedio()

        FOne.Grilla.ShowRowHeading = False
        If Not dt Is Nothing Then
            Dim dr As DataRow
            For Each dr In dt.Rows
                For c = 0 To dt.Columns.Count - 1

                    If c = 2 Then ' Si es importe lo alineo a la derecha y lo inserto como numero
                        Dim numero As Integer
                        numero = CInt(Math.Floor(dr(c)))
                        'Dim FormatoCelda As VCF150.F1CellFormat
                        'With FormatoCelda
                        '    .NumberFormat(numero) = "0"
                        'End With
                        'FOne.Grilla.SetCellFormat(FormatoCelda)
                        FOne.CargarNumero(numero, f + 8, c + 1)
                        FOne.Grilla.SetSelection(f + 8, c + 1, f + 8, c + 1)
                        FOne.Grilla.SetAlignment(4, True, 2, 0)
                        FOne.Grilla.SetBorder(2, 0, 0, 0, 0, 1, O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"))
                    ElseIf c = 3 Then ' Si es dia inserto como numero
                        FOne.CargarNumero(CDbl(dr(c)), f + 8, c + 1)
                        FOne.Grilla.SetSelection(f + 8, c + 1, f + 8, c + 1)
                        FOne.Grilla.SetAlignment(7, True, 2, 0)
                        FOne.Grilla.SetBorder(2, 0, 0, 0, 0, 1, O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"))
                    Else
                        FOne.CargarDato(dr(c), f + 8, c + 1, False)
                        FOne.Grilla.SetSelection(f + 8, c + 1, f + 8, c + 1)
                        FOne.Grilla.SetAlignment(7, True, 2, 0)
                        FOne.Grilla.SetBorder(2, 0, 0, 0, 0, 1, O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"), O.Parse("2"))
                    End If
                Next
                f = f + 1
            Next
        Else
            Mensajes.Mensaje("No hay programación vigente para ese periodo")
        End If

        Dim fecha As String

        fecha = CStr(f_vigencia_desde.Date) + " al " + CStr(f_vigencia_hasta.Date)
        FOne.CargarDato(fecha, 4, 2)
        FOne.Grilla.SetSelection(4, 2, 4, 2)
        FOne.Grilla.SetAlignment(7, True, 2, 0)
        FOne.Grilla.SetRowHeightAuto(3, 1, 48 + 7, 8, False)
    End Sub

#End Region

#Region "REPORTE CONVENIOS"

    Public Function ReporteConvenios(ByVal Capacidad As CapacidadesUsuario, ByVal DtConvenios As DataTable, ByVal Tipo As TipoListado, ByVal Vigencia As Integer, Optional ByVal AccesoEspecial As Boolean = False) As Boolean
        Dim auxSoporte As String = ""
        Dim m As New Soportes
        Dim dtMedio As DataTable = m.ObtenerMedios


        Dim auxcliente As String = ""
        Dim vigente As Boolean
        Dim Fila As Long = 10
        Dim Col As Long = 1
        Dim i As Long
        Me.Text = "Reporte de Convenios"
        Dim C As New Convenios

        Dim aux As Integer

        FOne.Grilla = Me.Grilla
        vigente = Algoritmos.EsPar(Tipo)

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        FOne.CargarTemplate(Application.StartupPath & "\Comun\reporte_convenio.vts") 'AG Unificacon 26/03/2013
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'AG Codigo anterior +++++++++++++++++++++++++++++++++++++++
        'FOne.CargarTemplate(Application.StartupPath & "\reporte_convenio.vts")
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++
        FOne.CargarDato(Now.Date, 1, 3)
        FOne.Grilla.PrintLandscape = True
        FOne.Grilla.PrintLeftMargin = 0.09
        FOne.Grilla.PrintRightMargin = 0.63
        FOne.Grilla.PrintTopMargin = 0.09
        FOne.Grilla.PrintBottomMargin = 0.01
        FOne.Grilla.PrintFooter = "&R Pagina &P de &N"
        FOne.Grilla.PrintVCenter = False


        Try
            For Each r As DataRow In DtConvenios.Rows
                With FOne
                    Select Case Tipo
                        '' modified by daniel caime 01/06/2010
                        Case TipoListado.ClienteVig, TipoListado.ClienteNoVig
                            'CLIENTE
                            .CargarDato("Cliente", 4, 1)
                            .CambiarFuente(4, 1, True)
                            .InsertarDato(r("cliente"), 4, 3)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", Fila + 1, Col)
                            .CambiarFuente(Fila + 1, Col, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), Fila + 1, Col + 2)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", Fila + 2, Col)
                            .CambiarFuente(Fila + 2, Col, True)
                            .InsertarDato(r("Tipo_Soporte"), Fila + 2, Col + 2)

                            'SOPORTE
                            .CargarDato("Soporte", Fila + 3, Col)
                            .CambiarFuente(Fila + 3, Col, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), Fila + 3, Col + 2)
                            '.InsertarDato(r("cod_Soporte"), Fila + 3, Col + 2)

                        Case TipoListado.MedioVig, TipoListado.MedioNoVig

                            'CLIENTE
                            .CargarDato("Cliente", Fila, Col)
                            .CambiarFuente(Fila, Col, True)
                            .InsertarDato(r("cliente"), Fila, Col + 2)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", Fila + 2, Col)
                            .CambiarFuente(Fila + 2, Col, True)
                            .InsertarDato(r("Tipo_Soporte"), Fila + 2, Col + 2)

                            'SOPORTE
                            .CargarDato("Soporte", Fila + 3, Col)
                            .CambiarFuente(Fila + 3, Col, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), Fila + 3, Col + 2)
                            '.InsertarDato(r("Soporte"), Fila + 3, Col + 2)

                        Case TipoListado.ClienteMedioNoVig, TipoListado.ClienteMedioVig
                            'CLIENTE
                            .CargarDato("Cliente", 4, 1)
                            .CambiarFuente(4, 1, True)
                            .InsertarDato(r("cliente"), 4, 3)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", Fila + 2, Col)
                            .CambiarFuente(Fila + 2, Col, True)
                            .InsertarDato(r("Tipo_Soporte"), Fila + 2, Col + 2)

                            'SOPORTE
                            .CargarDato("Soporte", Fila + 3, Col)
                            .CambiarFuente(Fila + 3, Col, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), Fila + 3, Col + 2)
                            '.InsertarDato(r("cod_Soporte"), Fila + 3, Col + 2)

                        Case TipoListado.ClienteMedioTipoSoporteVig, TipoListado.ClienteMedioTipoSoporteNoVig
                            'CLIENTE
                            .CargarDato("Cliente", 4, 1)
                            .CambiarFuente(4, 1, True)
                            .InsertarDato(r("cliente"), 4, 3)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", 6, 1)
                            .CambiarFuente(6, 1, True)
                            .InsertarDato(r("Tipo_Soporte"), 6, 3)

                            'SOPORTE
                            .CargarDato("Soporte", 7, 1)
                            .CambiarFuente(7, 1, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), 7, 3)
                            '.InsertarDato(r("cod_Soporte"), 7, 3)

                        Case TipoListado.MedioTipoVig, TipoListado.MedioTipoNoVig
                            'CLIENTE
                            .CargarDato("Cliente", Fila, Col)
                            .CambiarFuente(Fila, Col, True)
                            .InsertarDato(r("cliente"), Fila, Col + 2)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", 6, 1)
                            .CambiarFuente(6, 1, True)
                            .InsertarDato(r("Tipo_Soporte"), 6, 3)

                            'SOPORTE
                            .CargarDato("Soporte", 7, 1)
                            .CambiarFuente(7, 1, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), 7, 3)
                            '.InsertarDato(r("cod_Soporte"), 7, 3)

                        Case TipoListado.ClienteMedioTipoNoVig, TipoListado.ClienteMedioTipoVig
                            'CLIENTE
                            .CargarDato("Cliente", 4, 1)
                            .CambiarFuente(4, 1, True)
                            .InsertarDato(r("cliente"), 4, 3)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", 6, 1)
                            .CambiarFuente(6, 1, True)
                            .InsertarDato(r("Tipo_Soporte"), 6, 3)

                            'SOPORTE
                            .CargarDato("Soporte", Fila + 3, Col)
                            .CambiarFuente(Fila + 3, Col, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), Fila + 3, Col + 2)
                            '.InsertarDato(r("cod_Soporte"), Fila + 3, Col + 2)

                        Case TipoListado.MedioTipoSoporteVig, TipoListado.MedioTipoSoporteNoVig
                            'CLIENTE
                            .CargarDato("Cliente", Fila, Col)
                            .CambiarFuente(Fila, Col, True)
                            .InsertarDato(r("cliente"), Fila, Col + 2)

                            'TIPO DE MEDIO
                            .CargarDato("Tipo Medio", 5, 1)
                            .CambiarFuente(5, 1, True)
                            .InsertarDato(Grilladmin.ObtenerDato(dtMedio, "id_medio=" & r("id_medio"), "Descripcion"), 5, 3)

                            'TIPO DE SOPORTE
                            .CargarDato("Tipo Soporte", 6, 1)
                            .CambiarFuente(6, 1, True)
                            .InsertarDato(r("Tipo_Soporte"), 6, 3)

                            'SOPORTE
                            .CargarDato("Soporte", Fila + 3, Col)
                            .CambiarFuente(Fila + 3, Col, True)
                            'JJP Descripcion de soporte en listado de convenios
                            .InsertarDato(r("DES_SOPORTE"), Fila + 3, Col + 2)
                            '.InsertarDato(r("cod_Soporte"), Fila + 3, Col + 2)

                    End Select

                    'If vigente Then
                    '    'VIGENCIA
                    '    .CargarDato("No Vigente Al:", 6, 11)
                    'Else
                    '    .CargarDato("Vigente Al:", 6, 11)

                    'End If
                    Select Case Vigencia
                        Case 0
                            .CargarDato("No Vigente Al:", 6, 11)
                        Case 1
                            .CargarDato("Vigente Al:", 6, 11)
                    End Select

                    If Vigencia <> 2 Then
                        .CambiarFuente(6, 11, True)
                        .InsertarDato(Now.Date, 6, 12)
                    End If

                    '   NUMERO DE CONVENIO
                    '.CargarDato("Nº", Fila, Col + 2)
                    .CambiarFuente(Fila + 1, Col + 4, True)
                    .InsertarDato("Nº " & r("convenio"), Fila + 1, Col + 4)

                    'DETALLE
                    .CargarDato("Detalle", Fila + 4, Col)
                    .CambiarFuente(Fila + 4, Col, True)
                    .InsertarDato(r("Detalle"), Fila + 4, Col + 2)

                    'PARTICIPACION
                    .CargarDato("Particip.", Fila + 5, Col)
                    .CambiarFuente(Fila + 5, Col, True)
                    .InsertarDato(r("participacion"), Fila + 5, Col + 2)

                    'Observaciones COMPRA
                    .CargarDato("Observ.", Fila + 6, Col)
                    .CambiarFuente(Fila + 6, Col, True)
                    .InsertarDato(r("obs compra"), Fila + 6, Col + 2)

                    'Observaciones venta
                    .CambiarFuente(Fila + 7, Col, True)
                    .InsertarDato(r("obs venta"), Fila + 7, Col + 2)

                    'FECHA INICIO
                    .CargarDato("Fec. Inicio", Fila + 1, Col + 5)
                    .CambiarFuente(Fila + 1, Col + 5, True)
                    .InsertarDato(r("Fecha Inicio"), Fila + 2, Col + 5)

                    'FECHA FIN
                    .CargarDato("Fec. Fin", Fila + 1, Col + 6)
                    .CambiarFuente(Fila + 1, Col + 6, True)
                    .InsertarDato(r("Fecha Fin"), Fila + 2, Col + 6)

                    'PROGRAMA
                    .CargarDato("Programa", Fila + 1, Col + 7)
                    .CambiarFuente(Fila + 1, Col + 7, True)
                    .InsertarDato(r("programa"), Fila + 2, Col + 7)

                    'HORA
                    .CargarDato("Hora", Fila + 1, Col + 8)
                    .CambiarFuente(Fila + 1, Col + 8, True)
                    .InsertarDato(r("Hora"), Fila + 2, Col + 8)

                    'SEMANA
                    .CargarDato("Semana", Fila + 3, Col + 7)
                    .CambiarFuente(Fila + 3, Col + 7, True)
                    .InsertarDato(r("semana"), Fila + 3, Col + 8)
                    .CargarDato("Importe", Fila + 1, Col + 10)
                    .CambiarFuente(Fila + 1, Col + 10, True)
                    'VeNTA COMPRA EXT

                    '--CONTROL DE LAS CAPASIDADES DE USUARIO
                    Select Case Capacidad
                        Case CapacidadesUsuario.Planificador
                            .CargarDato("Venta", Fila + 2, Col + 9)
                            .CambiarFuente(Fila + 2, Col + 9, True)
                            .CargarDato("Producto", Fila + 3, Col + 9)
                            .CambiarFuente(Fila + 3, Col + 9, True)
                            .InsertarDato(r("Producto"), Fila + 3, Col + 10)
                            'importe Vta compra
                            .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                            'DESCUNTOS
                            .CargarDato("Descuentos", Fila + 1, Col + 11)
                            .CambiarFuente(Fila + 1, Col + 11, True)
                            .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                        Case CapacidadesUsuario.Compras
                            If AccesoEspecial Then
                                If C.VerExtras(Activo.IDUsuario) Then
                                    'Observaciones venta
                                    .CambiarFuente(Fila + 8, Col, True)
                                    .InsertarDato(r("obs finanza"), Fila + 8, Col + 2)

                                    .CargarDato("Venta", Fila + 2, Col + 9)
                                    .CambiarFuente(Fila + 2, Col + 9, True)
                                    .CargarDato("Compra", Fila + 3, Col + 9)
                                    .CambiarFuente(Fila + 3, Col + 9, True)
                                    .CargarDato("Extra", Fila + 4, Col + 9)
                                    .CambiarFuente(Fila + 4, Col + 9, True)
                                    .CargarDato("Producto", Fila + 5, Col + 9)
                                    .CambiarFuente(Fila + 5, Col + 9, True)
                                    .InsertarDato(r("Producto"), Fila + 5, Col + 10)
                                    'importe Vta compra
                                    .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                                    .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                                    'DESCUNTOS
                                    .CargarDato("Descuentos", Fila + 1, Col + 11)
                                    .CambiarFuente(Fila + 1, Col + 11, True)
                                    .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                                    .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                                    .InsertarDato(r("Desc Extra"), Fila + 4, Col + 11)
                                Else
                                    .CargarDato("Venta", Fila + 2, Col + 9)
                                    .CambiarFuente(Fila + 2, Col + 9, True)
                                    .CargarDato("Compra", Fila + 3, Col + 9)
                                    .CambiarFuente(Fila + 3, Col + 9, True)
                                    .CargarDato("Producto", Fila + 4, Col + 9)
                                    .CambiarFuente(Fila + 4, Col + 9, True)
                                    .InsertarDato(r("Producto"), Fila + 4, Col + 10)
                                    'importe Vta compra
                                    .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                                    .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                                    'DESCUNTOS
                                    .CargarDato("Descuentos", Fila + 1, Col + 11)
                                    .CambiarFuente(Fila + 1, Col + 11, True)
                                    .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                                    .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                                End If
                            Else
                                .CargarDato("Venta", Fila + 2, Col + 9)
                                .CambiarFuente(Fila + 2, Col + 9, True)
                                .CargarDato("Compra", Fila + 3, Col + 9)
                                .CambiarFuente(Fila + 3, Col + 9, True)
                                .CargarDato("Producto", Fila + 4, Col + 9)
                                .CambiarFuente(Fila + 4, Col + 9, True)
                                .InsertarDato(r("Producto"), Fila + 4, Col + 10)
                                'importe Vta compra
                                .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                                .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                                'DESCUNTOS
                                .CargarDato("Descuentos", Fila + 1, Col + 11)
                                .CambiarFuente(Fila + 1, Col + 11, True)
                                .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                                .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                            End If

                        Case CapacidadesUsuario.Finansas, CapacidadesUsuario.Direccion
                            If C.VerExtras(Activo.IDUsuario) Then
                                'Observaciones venta
                                .CambiarFuente(Fila + 8, Col, True)
                                .InsertarDato(r("obs finanza"), Fila + 8, Col + 2)

                                .CargarDato("Venta", Fila + 2, Col + 9)
                                .CambiarFuente(Fila + 2, Col + 9, True)
                                .CargarDato("Compra", Fila + 3, Col + 9)
                                .CambiarFuente(Fila + 3, Col + 9, True)
                                .CargarDato("Extra", Fila + 4, Col + 9)
                                .CambiarFuente(Fila + 4, Col + 9, True)
                                .CargarDato("Producto", Fila + 5, Col + 9)
                                .CambiarFuente(Fila + 5, Col + 9, True)
                                .InsertarDato(r("Producto"), Fila + 5, Col + 10)
                                'importe Vta compra
                                .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                                .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                                'DESCUNTOS
                                .CargarDato("Descuentos", Fila + 1, Col + 11)
                                .CambiarFuente(Fila + 1, Col + 11, True)
                                .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                                .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                                .InsertarDato(r("Desc Extra"), Fila + 4, Col + 11)
                            Else
                                'Observaciones venta
                                .CambiarFuente(Fila + 8, Col, True)
                                .InsertarDato(r("obs finanza"), Fila + 8, Col + 2)

                                .CargarDato("Venta", Fila + 2, Col + 9)
                                .CambiarFuente(Fila + 2, Col + 9, True)
                                .CargarDato("Compra", Fila + 3, Col + 9)
                                .CambiarFuente(Fila + 3, Col + 9, True)
                                .CargarDato("Extra", Fila + 4, Col + 9)
                                .CambiarFuente(Fila + 4, Col + 9, True)
                                .CargarDato("Producto", Fila + 5, Col + 9)
                                .CambiarFuente(Fila + 5, Col + 9, True)
                                .InsertarDato(r("Producto"), Fila + 5, Col + 10)
                                'importe Vta compra
                                .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                                .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                                'DESCUNTOS
                                .CargarDato("Descuentos", Fila + 1, Col + 11)
                                .CambiarFuente(Fila + 1, Col + 11, True)
                                .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                                .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                                'Mensajes.Mensaje("El usuario No tiene Permisos para Ver Convenios", TipoMensaje.Informacion)
                                'Exit Sub
                                'Me.Close()
                            End If

                        Case CapacidadesUsuario.Sistemas
                            'Observaciones venta
                            .CambiarFuente(Fila + 8, Col, True)
                            .InsertarDato(r("obs finanza"), Fila + 8, Col + 2)

                            .CargarDato("Venta", Fila + 2, Col + 9)
                            .CambiarFuente(Fila + 2, Col + 9, True)
                            .CargarDato("Compra", Fila + 3, Col + 9)
                            .CambiarFuente(Fila + 3, Col + 9, True)
                            .CargarDato("Extra", Fila + 4, Col + 9)
                            .CambiarFuente(Fila + 4, Col + 9, True)
                            .CargarDato("Producto", Fila + 5, Col + 9)
                            .CambiarFuente(Fila + 5, Col + 9, True)
                            .InsertarDato(r("Producto"), Fila + 5, Col + 10)
                            'importe Vta compra
                            .InsertarDato(r("Importe Venta"), Fila + 2, Col + 10)
                            .InsertarDato(r("Importe Compra"), Fila + 3, Col + 10)
                            'DESCUNTOS
                            .CargarDato("Descuentos", Fila + 1, Col + 11)
                            .CambiarFuente(Fila + 1, Col + 11, True)
                            .InsertarDato(r("Desc Venta"), Fila + 2, Col + 11)
                            .InsertarDato(r("Desc Compra"), Fila + 3, Col + 11)
                            .InsertarDato(r("Desc Extra"), Fila + 4, Col + 11)
                        Case Else
                            Return False
                    End Select
                    'FIN DEL CONTROLLLLLLLLLL

                    auxSoporte = LCase(r("cod_soporte"))
                    auxcliente = LCase(r("cliente"))
                    i += 1
                    If DtConvenios.Rows.Count > i Then
                        If LCase(DtConvenios.Rows(i)("cod_soporte")) <> auxSoporte Then
                            .CargarBorde(Fila + 9, Col, Col + 12, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.BordeMedio, TipoBorde.SinBorde, -1)
                        Else
                            .CargarBorde(Fila + 9, Col, Col + 12, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.BordeFino, TipoBorde.SinBorde, -1)
                        End If

                        If LCase(DtConvenios.Rows(i)("cliente")) <> auxcliente Then
                            .CargarBorde(Fila + 9, Col, Col + 12, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.Doble, TipoBorde.SinBorde, -1)
                        Else
                            .CargarBorde(Fila + 9, Col, Col + 12, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.BordeFino, TipoBorde.SinBorde, -1)
                        End If

                    Else
                        .CargarBorde(Fila + 9, Col, Col + 12, TipoBorde.SinBorde, TipoBorde.SinBorde, TipoBorde.Doble, TipoBorde.SinBorde, -1)

                    End If
                    Fila += 9
                End With
            Next
            Return True
        Catch er As Exception
        End Try

    End Function


#End Region

#Region "REPORTE MOTOR P"
    Private Function ControlarFrecuencia(ByVal FrecUsuario As Integer, ByVal FrecMotor As Integer) As Integer
        If FrecUsuario >= FrecMotor Then
            Return FrecMotor
        Else
            Return FrecUsuario
        End If
    End Function
    Public Sub CargarReporteMotorP(ByVal TiposReporte As ReporteMotorP, ByVal dtReporte As ArrayList, ByVal pauta As Long, ByVal Targets As String, ByVal TasaRepeticion As Double, ByVal NoContactados As Double, ByVal Grps As Double, ByVal CoberturaNeta As Double, ByVal Avisos As Long, ByVal MaxFrecuencia As Long, ByVal dtextra As DataTable, ByVal Alternativa As String, Optional ByVal DtTotal As ArrayList = Nothing)
        FOne.Grilla = Me.Grilla

        Dim Temas As New Temas, j As Integer
        Temas.Id_campania = Activo.IDCampaña
        Temas.ObtenerTemasPorCampaña()
        Me.sAlternativa = Alternativa
        MaxFrecuencia = ControlarFrecuencia(MaxFrecuencia, dtReporte(0).rows.count - 1)
        Dim P As New Pautas_mp, i As Integer
        Try
            Universo = P.ObtenerUniverso(pauta).Rows(0)("UNIVERSO")
            Me.Target = Targets
            For Each dt As DataTable In dtReporte
                Select Case dt.TableName
                    Case "frecuencia"
                        Me.ReporteFrecuencias(dtReporte(i), TasaRepeticion, Grps, CoberturaNeta, MaxFrecuencia, Avisos)
                    Case "pbr"
                        Me.ReportePorAvisos(dtReporte(i), dtextra)
                    Case "tema"
                        Me.ReporteMotorGeneral(dtReporte(i), Temas.ObtenerTemasPorCampaña(), "Desglose por Temas", "Tema", MaxFrecuencia, 3, DtTotal(j))
                        j += 1
                    Case "canal"
                        Me.ReporteMotorGeneral(dtReporte(i), dtextra, "Desglose por Soporte", "Soporte", MaxFrecuencia, 4, DtTotal(j))
                        j += 1
                    Case "calendario"
                        Me.ReporteMotorGeneral(dtReporte(i), Nothing, "Desglose por Soporte Calendario", "SemanaC", MaxFrecuencia, 5, DtTotal(j))
                        j += 1
                    Case "pauta"
                        Me.ReporteMotorGeneral(dtReporte(i), Nothing, "Desglose por Soporte Pauta", "SemanaP", MaxFrecuencia, 5, DtTotal(j))
                        j += 1
                End Select
                i += 1
            Next

            FormatosListadoMotor()

            Me.Show()

        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & "Tabla Nº: " & i)
            Exit Sub
        End Try
    End Sub
    Private Sub FormatosListadoMotor()
        For i As Int16 = 1 To 5
            With FOne
                .Grilla.Sheet = i
                .Grilla.ShowColHeading = False
                .Grilla.ShowRowHeading = False
                .Grilla.ShowEditBar = False
                .Grilla.ShowGridLines = False
                .Grilla.SetSelection(1, 1, 1, 1)

                ' .Grilla.PrintLandscape = False
            End With
        Next
        FOne.Grilla.Sheet = 1
    End Sub
    Private Sub ReporteFrecuencias(ByVal dtReporte As DataTable, ByVal TasaRepeticion As Double, ByVal Grps As Double, ByVal CoberturaNeta As Double, ByVal MaxFrecuencia As Long, ByVal Avisos As Long)
        Dim Cols() As String = {"QTYCONTACTOS", "PORCENTAJE"}
        Dim Fila As Integer, Columnas As Integer = dtReporte.Rows.Count - 1
        Dim Arr As New ArrayList
        Try
            With Me.FOne
                '.CargarTemplate(Application.StartupPath & "\reporte_motorp.vts")
                .CargarTemplate(Application.StartupPath & "\Comun\reporte_motorp.vts")
                .Grilla.Sheet = 1
                'IMpresion
                .Grilla.PrintLandscape = False
                FOne.CargarDato("Target: " & Target, 5, 2)
                FOne.CargarDato("Universo: " & Format(Universo, "##,##0.00"), 6, 2)
                FOne.CargarDato("Alternativa: " & sAlternativa, 7, 2)

                'Carga de Cuadrito de TOTALES GENERALES
                .CargarDato("GRP's", 8, 2)
                .CargarNumero(Grps, 8, 3)
                .CargarDato("Cob. Neta", 9, 2)
                .CargarNumero(CoberturaNeta, 9, 3)
                .CargarDato("Cob. Neta 3+", 10, 2)
                .CargarFormula("D19", 10, 3)
                .CargarDato("OTS", 11, 2)
                .CargarNumero(TasaRepeticion, 11, 3)
                .CargarDato("Avisos", 12, 2)
                .CargarNumero(Avisos, 12, 3)

                'Tabla de Frecuencias
                .CargarDato("Contactos", 15, 2)
                .CambiarFuente(15, 2, True)
                .CargarDato("Discretos%", 15, 3)
                .CambiarFuente(15, 3, True)
                .CargarDato("Acum%", 15, 4)
                .CambiarFuente(15, 4, True)
                Fila = 16
                Dim k As Integer, j As Integer
                Tasa = TasaRepeticion

                For i As Integer = 2 To 3
                    For Each r As DataRow In dtReporte.Rows
                        If j <= MaxFrecuencia Then

                            If k = 0 Then
                                .CargarDato(r(Cols(k)) & "+", Fila + j, i)
                            End If
                            If k = 1 Then
                                .CargarNumero(r(Cols(k)), Fila + j, i)
                                TotalDiscreto.Add(r(Cols(k)))
                            End If
                            j += 1
                        Else
                            j = 0
                            Exit For
                        End If
                    Next
                    j = 0
                    k += 1
                Next
                j = 0

                Dim Suma As Double
                For i As Integer = Columnas To 0 Step -1
                    Suma += dtReporte.Rows(i)("PORCENTAJE")
                    Arr.Add(Suma)
                Next
                ' Dim Borde As Integer
                For i As Integer = MaxFrecuencia To 1 Step -1
                    .CargarNumero(Arr(Columnas - i), Fila + i, 4)
                    TotalAcumulado.Add(Arr(Columnas - i))
                    ' Borde = i
                Next
                .SetBorde(Fila, 2, Fila + MaxFrecuencia, 4, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio)


                .CargarNumero(100 - CoberturaNeta, 16, 4)
            End With
        Catch ex As Exception
            Throw New Exception("Error - Reporte Frecuencias" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub ReportePorAvisos(ByVal dtReporte As DataTable, ByVal DtSoportes As DataTable)
        Dim Cols() As String = {"CANAL", "FECHA", "HORA", "TEMA", "SEMANAC", "SEMANAP", "PBR"}
        Dim Fila As Integer
        Try
            With Me.FOne
                .Grilla.Sheet = 2
                .Grilla.PrintLandscape = False
                FOne.CargarDato("Target: " & Target, 5, 1)
                FOne.CargarDato("Universo: " & Format(Universo, "##,##0.00"), 6, 1)
                FOne.CargarDato("Alternativa: " & sAlternativa, 7, 1)
                Fila = 9
                Dim k As Integer, j As Integer
                Dim sop As DataRow
                For i As Integer = 2 To 8
                    For Each r As DataRow In dtReporte.Rows
                        Select Case Cols(k)
                            Case "CANAL"
                                sop = DtSoportes.Select("Id_ibope=" & r("canal"))(0)
                                .CargarDato(sop("soporte"), Fila + j, i)
                            Case "FECHA", "TEMA", "SEMANAC"
                                .CargarDato(r(Cols(k)), Fila + j, i)
                            Case "SEMANAP", "PBR"
                                .CargarNumero(r(Cols(k)), Fila + j, i)
                            Case "HORA"
                                .CargarDato(Algoritmos.ObtenerHora(r(Cols(k))), Fila + j, i)
                        End Select

                        j += 1
                    Next
                    j = 0
                    k += 1
                Next
                j = 0

                Dim Suma As Double

                For i As Integer = 0 To dtReporte.Rows.Count - 1
                    Suma += dtReporte.Rows(i)("pbr")
                    .CargarNumero(Suma, Fila + i, 9)
                    .CargarNumero(i + 1, Fila + i, 1)
                Next
                .SetBorde(Fila, 1, Fila + dtReporte.Rows.Count - 1, 9, TipoBorde.BordeFino, TipoBorde.SinCambio, TipoBorde.SinCambio, TipoBorde.SinCambio)
                FOne.Grilla.PrintScaleFitHPages = 0
                FOne.Grilla.PrintScaleFitVPages = 0
            End With
        Catch ex As Exception
            Throw New Exception("Error - Reporte PBR por Avisos" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub ReporteMotorGeneral(ByVal dtReporte As DataTable, ByVal DtExtra As DataTable, ByVal TituloReporte As String, ByVal Titulo As String, ByVal MaxFrecuencia As Integer, ByVal Hoja As Integer, ByVal dtTotales As DataTable)
        Dim CantFilas As Integer = dtReporte.Rows.Count
        Dim FilaInicial As Integer = 8
        Dim FilaTotal1 As Integer = FilaInicial + CantFilas
        Dim FilaAcumulado As Integer = FilaTotal1 + 5
        Dim FilaTotal2 As Integer = FilaAcumulado + CantFilas + 1

        FOne.Grilla.Sheet = Hoja

        FOne.CargarDato("Target: " & Target, FilaInicial - 4, 1)
        FOne.CargarDato("Universo: " & Format(Universo, "##,##0.00"), FilaInicial - 3, 1)
        FOne.CargarDato("Alternativa: " & sAlternativa, FilaInicial - 2, 1)
        Try
            Me.CargarHeader(FilaInicial - 1, 1, Titulo, MaxFrecuencia)
            Me.CargarTextos(FilaInicial, 1, dtReporte, DtExtra, Titulo)
            Me.CargarValores(FilaInicial, 2, dtReporte, MaxFrecuencia, dtTotales)
            Me.CargarTotales(FilaInicial, FilaTotal1, 1, CantFilas, MaxFrecuencia)

            Me.CargarHeader(FilaAcumulado, 1, Titulo, MaxFrecuencia, True)
            Me.CargarTextos(FilaAcumulado + 1, 1, dtReporte, DtExtra, Titulo)
            Me.CargarAcumulados(FilaAcumulado + 1, 2, dtReporte, MaxFrecuencia, dtTotales)
            Me.CargarTotales(FilaAcumulado + 1, FilaTotal2, 1, CantFilas, MaxFrecuencia, True)

            FOne.Grilla.PrintLandscape = True
            FOne.Grilla.PrintScaleFitToPage = True
            FOne.Grilla.PrintScaleFitHPages = 1
        Catch ex As Exception
            Throw New Exception("Error - Reporte Motor General" & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub CargarHeader(ByVal Fila As Integer, ByVal Columna As Integer, ByVal Titulo As String, ByVal FrecMaxima As Integer, Optional ByVal Acumulado As Boolean = False)
        If Titulo.ToLower.IndexOf("semana") > -1 Then
            Titulo = "Semana"
        End If

        FOne.CargarDato(Titulo, Fila, Columna)
        FOne.CambiarFuente(Fila, Columna, True)
        FOne.Grilla.SetAlignment(3, False, 1, 0)

        For i As Integer = 1 To FrecMaxima
            If Acumulado Then
                FOne.CargarDato(i & "+", Fila, i + 1)
            Else
                FOne.CargarNumero(i, Fila, i + 1)
            End If
            FOne.CambiarFuente(Fila, i + 1, True)
            FOne.Grilla.SetAlignment(3, False, 1, 0)
        Next

        FOne.CargarDato("PBR", Fila, FrecMaxima + 2)
        FOne.CargarDato("OTS", Fila, FrecMaxima + 3)
        FOne.CambiarFuente(Fila, FrecMaxima + 2, True)
        FOne.Grilla.SetAlignment(3, False, 1, 0)
        FOne.CambiarFuente(Fila, FrecMaxima + 3, True)
        FOne.Grilla.SetAlignment(3, False, 1, 0)
        FOne.CargarDato("Avisos", Fila, FrecMaxima + 4)
        FOne.CambiarFuente(Fila, FrecMaxima + 4, True)
        FOne.Grilla.SetAlignment(4, False, 1, 0)
        FOne.CargarBorde(Fila, Columna, FrecMaxima + 4, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
    End Sub
    Private Sub CargarTextos(ByVal Fila As Integer, ByVal Columna As Integer, ByVal DtReporte As DataTable, ByVal DtExtra As DataTable, ByVal SelCol As String)
        Dim Texto As String, j As Integer
        For Each r As DataRow In DtReporte.Rows
            Select Case SelCol.ToLower
                Case "tema"
                    Texto = Grilladmin.ObtenerDato(DtExtra, "Id_Tema='" & r("Tema") & "'", SelCol)
                Case "soporte"
                    Texto = Grilladmin.ObtenerDato(DtExtra, "Id_ibope=" & r("canal"), SelCol)
                Case "semanac"
                    Texto = r("Semanac")
                Case "semanap"
                    Texto = r("SemanaP")
            End Select
            FOne.CargarDato(Texto, Fila + j, Columna)
            j += 1
        Next
    End Sub
    Private Sub CargarValores(ByVal Fila As Integer, ByVal Columna As Integer, ByVal DtReporte As DataTable, ByVal FrecMaxima As Integer, ByVal dtTotal As DataTable)
        'CARGA LOS DATOS
        Dim j As Integer, ColCN As String, Formula As String
        'Dim Arr As New ArrayList
        For Each r As DataRow In DtReporte.Rows
            For i As Integer = 1 To FrecMaxima
                FOne.CargarNumero(r(i + 1), Fila + j, i + 1)
            Next
            j += 1
        Next
        j = 0
        ColCN = Me.GetLetras(Columna)
        For Each r As DataRow In DtReporte.Rows
            FOne.CargarNumero(r("PBR"), Fila + j, FrecMaxima + 2)
            FOne.CargarNumero(r("PBR") / r("CN"), Fila + j, FrecMaxima + 3)

            j += 1
        Next
        j = 0
        For Each r As DataRow In dtTotal.Rows
            FOne.CargarNumero(r("CANT"), Fila + j, FrecMaxima + 4)
            j += 1
        Next
    End Sub

    Private Sub CargarTotales(ByVal FilaInicio As Integer, ByVal FilaFin As Integer, ByVal Columna As Integer, ByVal CantFilas As Integer, ByVal FrecMaxima As Integer, Optional ByVal Acumulado As Boolean = False)
        'TOTALES
        Dim Total As Double
        Dim Formula As String
        With FOne
            .CargarDato("Total", FilaFin, Columna)
            .CambiarFuente(FilaFin, Columna, True)
            .Grilla.SetAlignment(3, False, 1, 0)
            'Totales.Clear()
            For i As Integer = 1 To FrecMaxima
                If Acumulado Then
                    .CargarNumero(TotalAcumulado((TotalAcumulado.Count) - i), FilaFin, i + 1)
                Else
                    .CargarNumero(TotalDiscreto(i), FilaFin, i + 1)
                End If
                .CambiarFuente(FilaFin, i + 1, True)
                Total = 0
            Next
            Formula = "SUM(" & Me.GetLetras(FrecMaxima + 1) & FilaInicio & ":" & Me.GetLetras(FrecMaxima + 1) & FilaFin - 1 & ")"
            .CargarFormula(Formula, FilaFin, FrecMaxima + 2)
            .CambiarFuente(FilaFin, FrecMaxima + 2, True)

            Formula = "SUM(" & Me.GetLetras(FrecMaxima + 3) & FilaInicio & ":" & Me.GetLetras(FrecMaxima + 3) & FilaFin - 1 & ")"
            .CargarFormula(Formula, FilaFin, FrecMaxima + 4)
            .CambiarFuente(FilaFin, FrecMaxima + 4, True)

            .CargarNumero(Tasa, FilaFin, FrecMaxima + 3)
            .CambiarFuente(FilaFin, FrecMaxima + 3, True)

            .CargarBorde(FilaFin, 1, FrecMaxima + 4, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
        End With
    End Sub
    Private Sub CargarAcumulados(ByVal Fila As Integer, ByVal Columna As Integer, ByVal DtReporte As DataTable, ByVal FrecMaxima As Integer, ByVal dtTotal As DataTable)
        'CARGA LOS DATOS
        Dim suma As Double, j As Integer, colcn As String
        Dim Acum As New ArrayList, Cols As Integer = DtReporte.Columns.Count - 4
        FOne.CargarDato("Acumulados", Fila - 2, 1)
        FOne.CambiarFuente(Fila - 2, 1, True)
        For Each r As DataRow In DtReporte.Rows
            For i As Integer = Cols To 1 Step -1
                suma += r(i)
                Acum.Add(suma)
            Next
            For i As Integer = 1 To FrecMaxima
                FOne.CargarNumero(DirectCast(Acum((Cols - 1) - i), Double), Fila + j, i + 1)
            Next

            Acum.Clear()
            suma = 0
            j += 1
        Next
        j = 0
        colcn = Me.GetLetras(Columna)
        For Each r As DataRow In DtReporte.Rows
            FOne.CargarNumero(r("PBR"), Fila + j, FrecMaxima + 2)
            FOne.CargarNumero(r("PBR") / r("CN"), Fila + j, FrecMaxima + 3)
            j += 1
        Next

        j = 0
        For Each r As DataRow In dtTotal.Rows
            FOne.CargarNumero(r("CANT"), Fila + j, FrecMaxima + 4)
            j += 1
        Next
    End Sub
#End Region

#Region "REPORTE AVISOS MACHEADOS"
    Public Sub ReporteAvisosMacheados(ByVal pCod_Presupuesto As Double, ByVal pOrden As Integer, ByVal tipoSoporte As Integer)
        Dim ControlMacheo As New Control_Macheo
        Dim MaterialesOrdenes As New Materiales
        Dim Ordenes As DataSet
        Dim Spots As DataSet
        Dim MatOrd As DataTable
        Dim Cod_Spot As Double
        Dim Cod_Cliente, Hora, Segundos As Integer
        Dim Cod_Cadena, Cliente, Producto, HoraReal, Material As String
        Dim Fecha As DateTime
        Dim FiltroMaterial, HoraFormato, Posicion As StringBuilder
        Dim Fila As Long = 7
        Dim Ordenamiento As String
        Dim resultado As New Dictionary(Of String, List(Of AvisoConfirmado))
        Dim lOrdenes As New List(Of AvisoConfirmado)
        Dim dsCliente As New DataSet
        Dim dtSoportes As New DataTable
        Dim index, Cantidad As Integer
        Dim SoportesAdmedia As New StringBuilder
        Dim draux As DataRow()
        Dim indice As Integer = 0

        FOne.Grilla = Me.Grilla

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        FOne.CargarTemplate(Application.StartupPath & "\Comun\reporte monitor.vts") 'AG Unificacon 25/03/2013
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Dim datos(0, 8) As String


        'worksheet.Cells(1, 10).Value = "Hello world!"



        'AG Codigo anterior +++++++++++++++++++++++++++++++++
        'FOne.CargarTemplate(Application.StartupPath & "\reporte monitor.vts")
        '++++++++++++++++++++++++++++++++++++++++++++++

        FOne.Grilla.PrintLandscape = True

        FOne.Grilla.PrintLeftMargin = 0.09
        FOne.Grilla.PrintRightMargin = 0.63
        FOne.Grilla.PrintTopMargin = 0.09
        FOne.Grilla.PrintBottomMargin = 0.01
        FOne.Grilla.PrintFooter = "  &R Pag &P de &N"
        FOne.Grilla.PrintVCenter = False

        If pOrden = 0 Then
            Ordenamiento = "Des_Soporte,Fec_Spot ASC"
        Else
            Ordenamiento = "Fec_Spot,Des_Soporte ASC"
        End If

        resultado = ControlMacheo.ObtenerOrdenesConfirmados(Activo.IDCompaniaMMS, pCod_Presupuesto, Ordenamiento)

        If resultado Is Nothing Or Not String.IsNullOrEmpty(resultado.Keys(0)) Then
            MessageBox.Show(resultado.Keys(0))
            Exit Sub
        End If

        lOrdenes = resultado.Values(0)

        If Not lOrdenes Is Nothing AndAlso lOrdenes.Count > 0 Then
            Cliente = lOrdenes(0).DescripcionCliente
            Producto = lOrdenes(0).DescripcionProducto

            ControlMacheo.Cod_Cli = lOrdenes(0).CodigoCliente
            dsCliente = ControlMacheo.BuscarAr_Clientes_Sig_Nau()
            If Not dsCliente Is Nothing AndAlso dsCliente.Tables.Count > 0 Then
                If Not dsCliente.Tables(0) Is Nothing AndAlso dsCliente.Tables(0).Rows.Count > 0 Then
                    Cod_Cliente = dsCliente.Tables(0).Rows(0)("Cod_Cli_Nau")
                Else
                    MessageBox.Show("No se encontró el cliente relacionado")
                End If
            End If

            With FOne
                .CargarDato("Cliente", 2, 5)
                .CambiarFuente(2, 5, True)
                .InsertarDato(Cliente, 2, 5)

                .CargarDato("Producto", 3, 5)
                .CambiarFuente(3, 5, True)
                .InsertarDato(Producto, 3, 5)
            End With


            For Each aviso As AvisoConfirmado In lOrdenes
                Cod_Spot = aviso.CodigoSpot.Value
                Cod_Cadena = aviso.CadenaSpot
                Hora = aviso.HoraReal
                Segundos = aviso.SegundoReal
                Fecha = aviso.FechaReal

                dtSoportes = ControlMacheo.BuscarAr_Soportes_Admedia(aviso.CodigoSoporte).Tables(0)

                SoportesAdmedia.Remove(0, SoportesAdmedia.Length)
                If Not dtSoportes Is Nothing AndAlso dtSoportes.Rows.Count > 0 Then
                    Cantidad = dtSoportes.Rows.Count ' - 1
                    For index = 0 To Cantidad - 1
                        SoportesAdmedia.Append(dtSoportes.Rows(index)("cod_vehiculo_admedia"))
                        If index < Cantidad - 1 Then
                            SoportesAdmedia.Append(",")
                        End If
                    Next

                    draux = Activo.DTSoportesCache.Select("id_soporte = " & dtSoportes.Rows(0)("id_soporte") & " and id_medio = " & dtSoportes.Rows(0)("id_medio"))
                    If Not draux Is Nothing AndAlso draux.Length > 0 Then
                        tipoSoporte = draux(0)("cod_tipo_soporte")
                    End If

                    Spots = ControlMacheo.TraerSpotConfirmadoAdmedia(Cod_Spot, Cod_Cliente, SoportesAdmedia.ToString, Hora, Segundos, Fecha, tipoSoporte)
                End If

                'Spots = ControlMacheo.TraerSpotConfirmadoAdmedia(Cod_Spot, Cod_Cliente, Cod_Cadena, Hora, Segundos, Fecha, tipoSoporte)
                'Spots = ControlMacheo.BuscarSpotsConfirmados(Cod_Spot, Cod_Cliente, Cod_Cadena, Hora, Segundos, Fecha)
                Fila += 1
                indice += 1
                datos = CType(ResizeArray(datos, New Integer() {indice, 8}), String(,))

                If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then
                    For Each drSpots As DataRow In Spots.Tables(0).Rows
                        With FOne
                            .CargarDato("Fecha", Fila, 1)
                            .CambiarFuente(Fila, 1, True)
                            .InsertarDato(drSpots("Fec_Spt"), Fila, 1)
                            datos(indice - 1, 0) = drSpots("Fec_Spt")

                            HoraReal = drSpots("hm_spt")
                            HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                            HoraReal = HoraReal.Insert(0, "0")
                            HoraReal = HoraReal.Substring(HoraReal.Length - 5)
                            HoraFormato = New StringBuilder
                            HoraFormato.Append(HoraReal)
                            HoraFormato.Append(":")
                            If drSpots("ss_spt").ToString.Length = 1 Then
                                HoraFormato.Append("0")
                            End If
                            HoraFormato.Append(drSpots("ss_spt"))

                            .CargarDato("Hora", Fila, 2)
                            .CambiarFuente(Fila, 2, True)
                            .InsertarDato(HoraFormato.ToString, Fila, 2)
                            datos(indice - 1, 1) = HoraFormato.ToString


                            .CargarDato("Programa", Fila, 3)
                            .CambiarFuente(Fila, 3, True)
                            .InsertarDato(drSpots("zpnomb"), Fila, 3)
                            datos(indice - 1, 2) = drSpots("zpnomb")


                            .CargarDato("Medida", Fila, 4)
                            .CambiarFuente(Fila, 4, True)
                            .InsertarDato(drSpots("dur_spt"), Fila, 4)
                            datos(indice - 1, 3) = drSpots("dur_spt")

                            Posicion = New StringBuilder
                            'Posicion.Append(drSpots("Pos_Spt"))
                            'Posicion.Append("/")
                            'Posicion.Append(drSpots("Nsb_Spt"))

                            Posicion.Append(drSpots("POS_COMERCIAL")) 'CF 10/02/2014
                            Posicion.Append("/")
                            Posicion.Append(drSpots("AVISO_COMERCIAL"))

                            .CargarDato("Posicion", Fila, 5)
                            .CambiarFuente(Fila, 5, True)
                            .InsertarDato(Posicion.ToString, Fila, 5)
                            datos(indice - 1, 4) = Posicion.ToString

                            .CargarDato("Tema", Fila, 6)
                            .CambiarFuente(Fila, 6, True)
                            .InsertarDato(drSpots("desc_tema"), Fila, 6)
                            datos(indice - 1, 5) = drSpots("desc_tema")

                            .CargarDato("Vehiculo", Fila, 7)
                            .CambiarFuente(Fila, 7, True)
                            .InsertarDato(aviso.DescripcionSoporte, Fila, 7)
                            datos(indice - 1, 6) = aviso.DescripcionSoporte

                            .CargarDato("Material", Fila, 8)
                            .CambiarFuente(Fila, 8, True)
                            .InsertarDato(drSpots("Des_Tps"), Fila, 8)
                            datos(indice - 1, 7) = drSpots("Des_Tps")

                        End With
                    Next
                Else
                    With FOne
                        .CargarDato("Fecha", Fila, 1)
                        .CambiarFuente(Fila, 1, True)
                        .InsertarDato(aviso.FechaReal, Fila, 1)
                        datos(indice - 1, 0) = aviso.FechaReal

                        HoraReal = aviso.HoraReal
                        HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                        HoraReal = HoraReal.Insert(0, "0")
                        HoraReal = HoraReal.Substring(HoraReal.Length - 5)
                        HoraFormato = New StringBuilder
                        HoraFormato.Append(HoraReal)
                        HoraFormato.Append(":")
                        If aviso.SegundoReal.ToString.Length = 1 Then
                            HoraFormato.Append("0")
                        End If
                        HoraFormato.Append(aviso.SegundoReal)

                        .CargarDato("Hora", Fila, 2)
                        .CambiarFuente(Fila, 2, True)
                        .InsertarDato(HoraFormato.ToString, Fila, 2)
                        datos(indice - 1, 1) = HoraFormato.ToString

                        .CargarDato("Programa", Fila, 3)
                        .CambiarFuente(Fila, 3, True)
                        .InsertarDato(aviso.ProgramaReal, Fila, 3)
                        datos(indice - 1, 2) = aviso.ProgramaReal

                        .CargarDato("Medida", Fila, 4)
                        .CambiarFuente(Fila, 4, True)
                        .InsertarDato(aviso.DuracionReal, Fila, 4)
                        datos(indice - 1, 3) = aviso.DuracionReal

                        .CargarDato("Posicion", Fila, 5)
                        .CambiarFuente(Fila, 5, True)
                        .InsertarDato("", Fila, 5)
                        datos(indice - 1, 4) = ""

                        Material = aviso.DescripcionMaterial

                        .CargarDato("Tema", Fila, 6)
                        .CambiarFuente(Fila, 6, True)
                        .InsertarDato(Material, Fila, 6)
                        datos(indice - 1, 5) = Material

                        .CargarDato("Vehiculo", Fila, 7)
                        .CambiarFuente(Fila, 7, True)
                        .InsertarDato(aviso.DescripcionSoporte, Fila, 7)
                        datos(indice - 1, 6) = aviso.DescripcionSoporte

                        .CargarDato("Material", Fila, 8)
                        .CambiarFuente(Fila, 8, True)
                        .InsertarDato("", Fila, 8)
                        datos(indice - 1, 7) = ""


                    End With
                End If
                FOne.CargarBorde(Fila, 1, 8, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
            Next

            'ControlMacheo.Cod_Presupuesto = pCod_Presupuesto
            'Ordenes = ControlMacheo.BuscarOrdenesConfirmadas
            'If Not Ordenes Is Nothing AndAlso Not Ordenes.Tables(0) Is Nothing AndAlso Ordenes.Tables(0).Rows.Count > 0 Then
            '    Cliente = Ordenes.Tables(0).Rows(0)("Des_Cliente")
            '    Producto = Ordenes.Tables(0).Rows(0)("Des_Producto")
            '    MaterialesOrdenes.Id_cliente = Ordenes.Tables(0).Rows(0)("Cliente_Sigeme")
            '    MaterialesOrdenes.Id_producto = Ordenes.Tables(0).Rows(0)("Producto_Sigeme")
            '    MatOrd = MaterialesOrdenes.TraerMateriales

            '    With FOne
            '        .CargarDato("Cliente", 2, 5)
            '        .CambiarFuente(2, 5, True)
            '        .InsertarDato(Cliente, 2, 5)

            '        .CargarDato("Producto", 3, 5)
            '        .CambiarFuente(3, 5, True)
            '        .InsertarDato(Producto, 3, 5)
            '    End With

            '    For Each drOrdenes As DataRow In Ordenes.Tables(0).Select("", Ordenamiento)
            '        Cod_Spot = drOrdenes("Cod_Spot")
            '        Cod_Cliente = drOrdenes("Cod_Cli_Nau")
            '        Cod_Cadena = drOrdenes("Id_Cadena")
            '        Hora = drOrdenes("Hr_Spot")
            '        Segundos = drOrdenes("SS_Spot")
            '        Fecha = drOrdenes("Fec_Spot")
            '        Spots = ControlMacheo.BuscarSpotsConfirmados(Cod_Spot, Cod_Cliente, Cod_Cadena, Hora, Segundos, Fecha)
            '        Fila += 1
            '        If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then
            '            For Each drSpots As DataRow In Spots.Tables(0).Rows
            '                With FOne
            '                    .CargarDato("Fecha", Fila, 1)
            '                    .CambiarFuente(Fila, 1, True)
            '                    .InsertarDato(drSpots("Fec_Spt"), Fila, 1)

            '                    HoraReal = drSpots("hm_spt")
            '                    HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
            '                    HoraReal = HoraReal.Insert(0, "0")
            '                    HoraReal = HoraReal.Substring(HoraReal.Length - 5)
            '                    HoraFormato = New StringBuilder
            '                    HoraFormato.Append(HoraReal)
            '                    HoraFormato.Append(":")
            '                    If drSpots("ss_spt").ToString.Length = 1 Then
            '                        HoraFormato.Append("0")
            '                    End If
            '                    HoraFormato.Append(drSpots("ss_spt"))

            '                    .CargarDato("Hora", Fila, 2)
            '                    .CambiarFuente(Fila, 2, True)
            '                    .InsertarDato(HoraFormato.ToString, Fila, 2)

            '                    .CargarDato("Programa", Fila, 3)
            '                    .CambiarFuente(Fila, 3, True)
            '                    .InsertarDato(drSpots("zpnomb"), Fila, 3)

            '                    .CargarDato("Medida", Fila, 4)
            '                    .CambiarFuente(Fila, 4, True)
            '                    .InsertarDato(drSpots("dur_spt"), Fila, 4)

            '                    Posicion = New StringBuilder
            '                    Posicion.Append(drSpots("Pos_Spt"))
            '                    Posicion.Append("/")
            '                    Posicion.Append(drSpots("Nsb_Spt"))

            '                    .CargarDato("Posicion", Fila, 5)
            '                    .CambiarFuente(Fila, 5, True)
            '                    .InsertarDato(Posicion.ToString, Fila, 5)

            '                    .CargarDato("Tema", Fila, 6)
            '                    .CambiarFuente(Fila, 6, True)
            '                    .InsertarDato(drSpots("desc_tema"), Fila, 6)

            '                    .CargarDato("Vehiculo", Fila, 7)
            '                    .CambiarFuente(Fila, 7, True)
            '                    .InsertarDato(drOrdenes("Des_Soporte"), Fila, 7)

            '                    .CargarDato("Material", Fila, 8)
            '                    .CambiarFuente(Fila, 8, True)
            '                    .InsertarDato(drSpots("Des_Tps"), Fila, 8)

            '                End With
            '            Next
            '        Else
            '            With FOne
            '                .CargarDato("Fecha", Fila, 1)
            '                .CambiarFuente(Fila, 1, True)
            '                .InsertarDato(drOrdenes("Fec_Spot"), Fila, 1)

            '                HoraReal = drOrdenes("hr_spot")
            '                HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
            '                HoraReal = HoraReal.Insert(0, "0")
            '                HoraReal = HoraReal.Substring(HoraReal.Length - 5)
            '                HoraFormato = New StringBuilder
            '                HoraFormato.Append(HoraReal)
            '                HoraFormato.Append(":")
            '                If drOrdenes("ss_spot").ToString.Length = 1 Then
            '                    HoraFormato.Append("0")
            '                End If
            '                HoraFormato.Append(drOrdenes("ss_spot"))

            '                .CargarDato("Hora", Fila, 2)
            '                .CambiarFuente(Fila, 2, True)
            '                .InsertarDato(HoraFormato.ToString, Fila, 2)

            '                .CargarDato("Programa", Fila, 3)
            '                .CambiarFuente(Fila, 3, True)
            '                .InsertarDato(drOrdenes("Programa"), Fila, 3)

            '                .CargarDato("Medida", Fila, 4)
            '                .CambiarFuente(Fila, 4, True)
            '                .InsertarDato(drOrdenes("Tamano_TV"), Fila, 4)

            '                .CargarDato("Posicion", Fila, 5)
            '                .CambiarFuente(Fila, 5, True)
            '                .InsertarDato("", Fila, 5)

            '                Material = String.Empty
            '                If Not drOrdenes.Table.Columns("Material_Sigeme") Is Nothing AndAlso Not drOrdenes("Material_Sigeme") Is DBNull.Value AndAlso Not MatOrd Is Nothing AndAlso MatOrd.Rows.Count > 0 Then
            '                    FiltroMaterial = New StringBuilder
            '                    FiltroMaterial.Append("Id_Material = '")
            '                    FiltroMaterial.Append(drOrdenes("Material_Sigeme"))
            '                    FiltroMaterial.Append("'")
            '                    For Each drMaterial As DataRow In MatOrd.Select(FiltroMaterial.ToString)
            '                        Material = drMaterial("Descripcion")
            '                    Next
            '                End If

            '                .CargarDato("Tema", Fila, 6)
            '                .CambiarFuente(Fila, 6, True)
            '                .InsertarDato(Material, Fila, 6)

            '                .CargarDato("Vehiculo", Fila, 7)
            '                .CambiarFuente(Fila, 7, True)
            '                .InsertarDato(drOrdenes("Des_Soporte"), Fila, 7)

            '                .CargarDato("Material", Fila, 8)
            '                .CambiarFuente(Fila, 8, True)
            '                .InsertarDato("", Fila, 8)
            '            End With
            '        End If
            '        FOne.CargarBorde(Fila, 1, 8, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
            '    Next
            With FOne
                .Grilla.Sheet = 1
                .Grilla.ShowColHeading = False
                .Grilla.ShowRowHeading = False
                .Grilla.ShowEditBar = False
                .Grilla.ShowGridLines = False
                .Grilla.SetSelection(1, 1, 1, 1)
            End With
        End If



        '  gw 18/03/2015 para abrir excel  y generar pdf
        'https://msdn.microsoft.com/en-us/library/bb407651(v=office.12).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-5
        'http://www.gemboxsoftware.com/support/articles/read-write-excel-spreadsheet-net

        If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then

            Dim args As ArgumentType = New ArgumentType()
            args._Presupuesto = pCod_Presupuesto
            args._Cliente = Cliente
            args._Producto = Producto
            args._Fila = indice - 1
            ExcelFunciones.TemplateXLS = Application.StartupPath & "\Comun\template.xlsx"

            Dim nombreArchivo As String = String.Format("{0}_{1}.pdf", Activo.IDCompaniaMMS, args._Presupuesto)
            ExcelFunciones.CarpetaDestino = Framework.ExportacionUtil.ParametrosExportacionLegajos.RutaExportacionControlMonitor + nombreArchivo

            ExcelFunciones.TempFolder = Framework.ExportacionUtil.ParametrosExportacionLegajos.RutaCarpetaTemporal + "\" + nombreArchivo

            'Dim datos(,) As String = {{"1", "2", "3"}, {"4", "5", "6"}, {"7", "8", "9"}}

            ExcelFunciones.ColumnaInicio = "A"
            ExcelFunciones.ColumnaFin = "H"
            ExcelFunciones.RegistroInicio = 8
            ExcelFunciones.Datos = datos
            ExcelFunciones.GeneraExcelReporteAvisosMacheados(args)
        End If
        ' fin gw exportacion a pdf
    End Sub

    Private Function ResizeArray(ByVal arr As Array, ByVal newSizes() As Integer) As Array
        Try
            If newSizes.Length <> arr.Rank Then
                Throw New ArgumentException("arr must have the same number of dimensions " + "as there are elements in newSizes", "newSizes")
            End If
        Catch
        End Try

        Dim temp As Array = Array.CreateInstance(arr.GetType().GetElementType(), newSizes)
        Dim length As Integer = If(arr.Length <= temp.Length, arr.Length, temp.Length)
        Array.ConstrainedCopy(arr, 0, temp, 0, length)
        Return temp
    End Function

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

    Public Sub ReporteControlAvisos(ByVal pCod_Presupuesto As Double, ByVal pOrden As Integer, ByVal tipoSoporte As Integer)

        Dim ControlMacheo As New Control_Macheo
        Dim MaterialesOrdenes As New Materiales
        Dim Ordenes As DataSet
        Dim Spots As DataSet
        Dim MatOrd As DataTable
        Dim Cod_Spot As Double
        Dim Cod_Cliente, Hora, Segundos As Integer
        Dim Cod_Cadena, Cliente, Producto, HoraReal, Material As String
        Dim Fecha As DateTime
        Dim FiltroMaterial, HoraFormato, Posicion As StringBuilder
        Dim Fila As Long = 7
        Dim Ordenamiento As String
        Dim resultado As New Dictionary(Of String, List(Of AvisoConfirmado))
        Dim lOrdenes As New List(Of AvisoConfirmado)
        Dim dsCliente As New DataSet
        Dim dtSoportes As New DataTable
        Dim index, Cantidad As Integer
        Dim SoportesAdmedia As New StringBuilder
        Dim ProgramaMMS, Orden, FechaMMS, HoraMMS As String
        Dim Presupuesto As String
        Dim draux As DataRow()

        FOne.Grilla = Me.Grilla

        'AG 26/03/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        FOne.CargarTemplate(Application.StartupPath & "\Comun\reportecontrol.vts") 'AG Unificacon 25/03/2013 
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG Codigo Anterior ++++++++++++++++++++++++++++++++++++++
        'FOne.CargarTemplate(Application.StartupPath & "\reportecontrol.vts")
        '++++++++++++++++++++++++++++++++++++++++++++++++++++

        FOne.Grilla.PrintLandscape = True
        FOne.Grilla.PrintLeftMargin = 0.09
        FOne.Grilla.PrintRightMargin = 0.63
        FOne.Grilla.PrintTopMargin = 0.09
        FOne.Grilla.PrintBottomMargin = 0.01
        FOne.Grilla.PrintFooter = "  &R Pag &P de &N"
        FOne.Grilla.PrintVCenter = False

        If pOrden = 0 Then
            Ordenamiento = "Des_Soporte,Fec_Spot ASC"
        Else
            Ordenamiento = "Fec_Spot,Des_Soporte ASC"
        End If

        resultado = ControlMacheo.ObtenerOrdenesConfirmados(Activo.IDCompaniaMMS, pCod_Presupuesto, Ordenamiento)

        If resultado Is Nothing Or Not String.IsNullOrEmpty(resultado.Keys(0)) Then
            MessageBox.Show(resultado.Keys(0))
            Exit Sub
        End If

        lOrdenes = resultado.Values(0)

        If Not lOrdenes Is Nothing AndAlso lOrdenes.Count > 0 Then
            Cliente = lOrdenes(0).DescripcionCliente
            Producto = lOrdenes(0).DescripcionProducto
            Presupuesto = lOrdenes(0).CodigoPresupuesto.ToString

            ControlMacheo.Cod_Cli = lOrdenes(0).CodigoCliente
            dsCliente = ControlMacheo.BuscarAr_Clientes_Sig_Nau()
            If Not dsCliente Is Nothing AndAlso dsCliente.Tables.Count > 0 Then
                If Not dsCliente.Tables(0) Is Nothing AndAlso dsCliente.Tables(0).Rows.Count > 0 Then
                    Cod_Cliente = dsCliente.Tables(0).Rows(0)("Cod_Cli_Nau")
                Else
                    MessageBox.Show("No se encontró el cliente relacionado")
                End If
            End If

            With FOne
                .CargarDato("Cliente:", 2, 1)
                .CambiarFuente(2, 1, True)
                .InsertarDato("Cliente:  " & Cliente, 2, 1)

                .CargarDato("Producto:", 3, 1)
                .CambiarFuente(3, 1, True)
                .InsertarDato("Producto:  " & Producto, 3, 1)

                .CargarDato("Presupuesto:", 4, 1)
                .CambiarFuente(4, 1, True)
                .InsertarDato("Presupuesto:  " & Presupuesto, 4, 1)
            End With

            For Each aviso As AvisoConfirmado In lOrdenes
                Cod_Spot = aviso.CodigoSpot.Value
                Cod_Cadena = aviso.CadenaSpot
                Hora = aviso.HoraReal
                Segundos = aviso.SegundoReal
                Fecha = aviso.FechaReal

                dtSoportes = ControlMacheo.BuscarAr_Soportes_Admedia(aviso.CodigoSoporte).Tables(0)

                SoportesAdmedia.Remove(0, SoportesAdmedia.Length)
                If Not dtSoportes Is Nothing AndAlso dtSoportes.Rows.Count > 0 Then
                    Cantidad = dtSoportes.Rows.Count ' - 1
                    For index = 0 To Cantidad - 1
                        SoportesAdmedia.Append(dtSoportes.Rows(index)("cod_vehiculo_admedia"))
                        If index < Cantidad - 1 Then
                            SoportesAdmedia.Append(",")
                        End If
                    Next

                    draux = Activo.DTSoportesCache.Select("id_soporte = " & dtSoportes.Rows(0)("id_soporte") & " and id_medio = " & dtSoportes.Rows(0)("id_medio"))
                    If Not draux Is Nothing AndAlso draux.Length > 0 Then
                        tipoSoporte = draux(0)("cod_tipo_soporte")
                    End If

                    Spots = ControlMacheo.TraerSpotConfirmadoAdmedia(Cod_Spot, Cod_Cliente, SoportesAdmedia.ToString, Hora, Segundos, Fecha, tipoSoporte)
                    'AG 13/03/2013 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Spots = anexarcolumnas(Spots)
                    Spots = AgregarDatos(Spots, aviso.CodigoOrden.ToString(), aviso.Programa.ToString(), aviso.FechaReal.Value, aviso.Hora)
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                End If

                'Spots = ControlMacheo.TraerSpotConfirmadoAdmedia(Cod_Spot, Cod_Cliente, Cod_Cadena, Hora, Segundos, Fecha, tipoSoporte)
                'Spots = ControlMacheo.BuscarSpotsConfirmados(Cod_Spot, Cod_Cliente, Cod_Cadena, Hora, Segundos, Fecha)
                Fila += 1
                If Not Spots Is Nothing AndAlso Not Spots.Tables(0) Is Nothing AndAlso Spots.Tables(0).Rows.Count > 0 Then
                    For Each drSpots As DataRow In Spots.Tables(0).Rows
                        With FOne
                            .CargarDato("Fecha", Fila, 1)
                            .CambiarFuente(Fila, 1, True)
                            .InsertarDato(drSpots("Fec_Spt"), Fila, 1)

                            HoraReal = drSpots("hm_spt")
                            HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                            HoraReal = HoraReal.Insert(0, "0")
                            HoraReal = HoraReal.Substring(HoraReal.Length - 5)
                            HoraFormato = New StringBuilder
                            HoraFormato.Append(HoraReal)
                            HoraFormato.Append(":")
                            If drSpots("ss_spt").ToString.Length = 1 Then
                                HoraFormato.Append("0")
                            End If
                            HoraFormato.Append(drSpots("ss_spt"))

                            .CargarDato("Hora", Fila, 2)
                            .CambiarFuente(Fila, 2, True)
                            .InsertarDato(HoraFormato.ToString, Fila, 2)

                            .CargarDato("Programa", Fila, 3)
                            .CambiarFuente(Fila, 3, True)
                            .InsertarDato(drSpots("zpnomb"), Fila, 3)

                            .CargarDato("Medida", Fila, 4)
                            .CambiarFuente(Fila, 4, True)
                            .InsertarDato(drSpots("dur_spt"), Fila, 4)

                            'Posicion = New StringBuilder
                            'Posicion.Append(drSpots("Pos_Spt"))
                            'Posicion.Append("/")
                            'Posicion.Append(drSpots("Nsb_Spt"))

                            Posicion = New StringBuilder
                            Posicion.Append(drSpots("POS_COMERCIAL"))
                            Posicion.Append("/")
                            Posicion.Append(drSpots("AVISO_COMERCIAL"))

                            .CargarDato("Posicion", Fila, 5)
                            .CambiarFuente(Fila, 5, True)
                            .InsertarDato(Posicion.ToString, Fila, 5)

                            .CargarDato("Tema", Fila, 6)
                            .CambiarFuente(Fila, 6, True)
                            .InsertarDato(drSpots("desc_tema"), Fila, 6)

                            .CargarDato("Vehiculo", Fila, 7)
                            .CambiarFuente(Fila, 7, True)
                            .InsertarDato(aviso.DescripcionSoporte, Fila, 7)

                            .CargarDato("Material", Fila, 8)
                            .CambiarFuente(Fila, 8, True)
                            .InsertarDato(drSpots("Des_Tps"), Fila, 8)

                            'AG 13/03/2013 ++++++++++++++++++++++++++++++
                            .CargarDato("Orden", Fila, 9)
                            .CambiarFuente(Fila, 9, True)
                            .InsertarDato(drSpots("Orden"), Fila, 9)

                            .CargarDato("FechaMMS", Fila, 10)
                            .CambiarFuente(Fila, 10, True)
                            .InsertarDato(drSpots("FechaMMS"), Fila, 10)

                            HoraReal = drSpots("HoraMMS")
                            HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                            HoraReal = HoraReal.Insert(0, "0")
                            HoraReal = HoraReal.Substring(HoraReal.Length - 5)

                            .CargarDato("HoraMMS", Fila, 11)
                            .CambiarFuente(Fila, 11, True)
                            .InsertarDato(HoraReal.ToString(), Fila, 11)

                            .CargarDato("ProgramaMMs", Fila, 12)
                            .CambiarFuente(Fila, 12, True)
                            .InsertarDato(drSpots("ProgramaMMS"), Fila, 12)

                            '++++++++++++++++++++++++++++++++++++++++++

                        End With
                    Next
                Else
                    With FOne
                        .CargarDato("Fecha", Fila, 1)
                        .CambiarFuente(Fila, 1, True)
                        .InsertarDato(aviso.FechaReal, Fila, 1)

                        HoraReal = aviso.HoraReal
                        HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                        HoraReal = HoraReal.Insert(0, "0")
                        HoraReal = HoraReal.Substring(HoraReal.Length - 5)
                        HoraFormato = New StringBuilder
                        HoraFormato.Append(HoraReal)
                        HoraFormato.Append(":")
                        If aviso.SegundoReal.ToString.Length = 1 Then
                            HoraFormato.Append("0")
                        End If
                        HoraFormato.Append(aviso.SegundoReal)

                        .CargarDato("Hora", Fila, 2)
                        .CambiarFuente(Fila, 2, True)
                        .InsertarDato(HoraFormato.ToString, Fila, 2)

                        .CargarDato("Programa", Fila, 3)
                        .CambiarFuente(Fila, 3, True)
                        .InsertarDato(aviso.ProgramaReal, Fila, 3)

                        .CargarDato("Medida", Fila, 4)
                        .CambiarFuente(Fila, 4, True)
                        .InsertarDato(aviso.DuracionReal, Fila, 4)

                        .CargarDato("Posicion", Fila, 5)
                        .CambiarFuente(Fila, 5, True)
                        .InsertarDato("", Fila, 5)

                        Material = aviso.DescripcionMaterial

                        .CargarDato("Tema", Fila, 6)
                        .CambiarFuente(Fila, 6, True)
                        .InsertarDato(Material, Fila, 6)

                        .CargarDato("Vehiculo", Fila, 7)
                        .CambiarFuente(Fila, 7, True)
                        .InsertarDato(aviso.DescripcionSoporte, Fila, 7)

                        .CargarDato("Material", Fila, 8)
                        .CambiarFuente(Fila, 8, True)
                        .InsertarDato("", Fila, 8)

                        'AG 13/03/2013 ++++++++++++++++++++++++++++++
                        .CargarDato("Orden", Fila, 9)
                        .CambiarFuente(Fila, 9, True)
                        .InsertarDato(aviso.CodigoOrden, Fila, 9)

                        .CargarDato("FechaMMS", Fila, 10)
                        .CambiarFuente(Fila, 10, True)
                        .InsertarDato(aviso.FechaReal, Fila, 10)

                        HoraReal = aviso.HoraReal
                        HoraReal = HoraReal.Insert(HoraReal.Length - 2, ":")
                        HoraReal = HoraReal.Insert(0, "0")
                        HoraReal = HoraReal.Substring(HoraReal.Length - 5)

                        .CargarDato("HoraMMS", Fila, 11)
                        .CambiarFuente(Fila, 11, True)
                        .InsertarDato(HoraFormato.ToString(), Fila, 11)

                        .CargarDato("ProgramaMMs", Fila, 12)
                        .CambiarFuente(Fila, 12, True)
                        .InsertarDato(aviso.Programa, Fila, 12)
                        '++++++++++++++++++++++++++++++++++++++++++

                    End With
                End If
                FOne.CargarBorde(Fila, 1, 12, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
            Next


            With FOne
                .Grilla.Sheet = 1
                .Grilla.ShowColHeading = False
                .Grilla.ShowRowHeading = False
                .Grilla.ShowEditBar = False
                .Grilla.ShowGridLines = False
                .Grilla.SetSelection(1, 1, 1, 1)
            End With
        End If
    End Sub

    Private Function anexarcolumnas(ByVal dtspots As DataSet) As DataSet

        With dtspots.Tables(0)
            .Columns.Add("Orden", GetType(String))
            .Columns.Add("ProgramaMMS", GetType(String))
            .Columns.Add("FechaMMS", GetType(String))
            .Columns.Add("HoraMMS", GetType(String))
        End With

        Return dtspots

    End Function

    Private Function AgregarDatos(ByVal DsDatoMMS As DataSet, ByVal CodOrden As String, ByVal ProgramaMMS As String, ByVal FechaMMS As String, ByVal HoraMMS As String) As DataSet

        For Each DatoMMS As DataRow In DsDatoMMS.Tables(0).Rows
            DatoMMS("Orden") = CodOrden
            DatoMMS("ProgramaMMS") = ProgramaMMS
            DatoMMS("FechaMMS") = FechaMMS
            DatoMMS("HoraMMS") = HoraMMS
        Next

        Return DsDatoMMS
    End Function

    Public Sub ReporteAvisosMonitor(ByVal pCod_Presupuesto As Double, ByVal pOrden As Integer, ByVal Ordenes As DataSet, ByVal Cliente As String, ByVal Producto As String)
        Dim ControlMacheo As New Control_Macheo
        Dim MaterialesOrdenes As New Materiales
        Dim Spots As DataSet
        Dim MatOrd As DataTable
        Dim Cod_Spot As Double
        Dim Cod_Cliente, Hora, Segundos As Integer
        Dim Cod_Cadena, HoraReal, Material, PosicionBloque As String
        Dim Fecha As DateTime
        Dim FiltroMaterial, HoraFormato, Posicion As StringBuilder
        Dim Fila As Long = 7
        Dim Ordenamiento As String

        FOne.Grilla = Me.Grilla
        FOne.CargarTemplate(Application.StartupPath & "\reporte monitor externo.vts")
        FOne.Grilla.PrintLandscape = True
        FOne.Grilla.PrintLeftMargin = 0.09
        FOne.Grilla.PrintRightMargin = 0.63
        FOne.Grilla.PrintTopMargin = 0.09
        FOne.Grilla.PrintBottomMargin = 0.01
        FOne.Grilla.PrintFooter = "  &R Pag &P de &N"
        FOne.Grilla.PrintVCenter = False

        If pOrden = 0 Then
            Ordenamiento = "Soporte,FechaReal ASC"
        Else
            Ordenamiento = "FechaReal,Soporte ASC"
        End If

        ControlMacheo.Cod_Presupuesto = pCod_Presupuesto

        If Not Ordenes Is Nothing AndAlso Not Ordenes.Tables(0) Is Nothing AndAlso Ordenes.Tables(0).Rows.Count > 0 Then

            With FOne
                .CargarDato("Cliente", 2, 5)
                .CambiarFuente(2, 5, True)
                .InsertarDato(Cliente, 2, 5)

                .CargarDato("Producto", 3, 5)
                .CambiarFuente(3, 5, True)
                .InsertarDato(Producto, 3, 5)
            End With

            For Each drOrdenes As DataRow In Ordenes.Tables(0).Select("", Ordenamiento)
                'Cod_Spot = drOrdenes("Cod_Spot")
                'Cod_Cliente = drOrdenes("Cod_Cli_Nau")
                'Cod_Cadena = drOrdenes("Id_Cadena")
                'Hora = drOrdenes("Hr_Spot")
                'Segundos = drOrdenes("SS_Spot")
                'Fecha = drOrdenes("Fec_Spot")
                Fila += 1
                With FOne
                    .CargarDato("Fecha", Fila, 1)
                    .CambiarFuente(Fila, 1, True)
                    .InsertarDato(drOrdenes("FechaReal"), Fila, 1)

                    HoraReal = drOrdenes("HoraReal")

                    .CargarDato("Hora", Fila, 2)
                    .CambiarFuente(Fila, 2, True)
                    .InsertarDato(HoraReal.ToString, Fila, 2)

                    .CargarDato("Soporte", Fila, 3)
                    .CambiarFuente(Fila, 3, True)
                    .InsertarDato(drOrdenes("Soporte"), Fila, 3)

                    .CargarDato("Programa", Fila, 4)
                    .CambiarFuente(Fila, 4, True)
                    .InsertarDato(drOrdenes("ProgramaReal"), Fila, 4)

                    .CargarDato("Medida", Fila, 5)
                    .CambiarFuente(Fila, 5, True)
                    .InsertarDato(drOrdenes("DuracionReal"), Fila, 5)

                    PosicionBloque = drOrdenes("PosicionComercial") & "/" & drOrdenes("AvisoComercial")

                    .CargarDato("PosicionComercial", Fila, 6)
                    .CambiarFuente(Fila, 6, True)
                    .InsertarDato(PosicionBloque.ToString(), Fila, 6)

                    .CargarDato("Tema", Fila, 7)
                    .CambiarFuente(Fila, 7, True)
                    .InsertarDato(drOrdenes("Tema"), Fila, 7)

                End With

                FOne.CargarBorde(Fila, 1, 7, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino, TipoBorde.BordeFino)
            Next
            With FOne
                .Grilla.Sheet = 1
                .Grilla.ShowColHeading = False
                .Grilla.ShowRowHeading = False
                .Grilla.ShowEditBar = False
                .Grilla.ShowGridLines = False
                .Grilla.SetSelection(1, 1, 1, 1)
            End With
        End If
    End Sub
#End Region

    Private Sub Grilla_ClickEvent(ByVal sender As System.Object, ByVal e As AxVCF150.DF1Events_ClickEvent) Handles Grilla.ClickEvent

    End Sub

    Private Sub frmFormulaOne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class DiaCalendario
    Dim mFecha As Date
    Dim mTema As Char
    Dim mValor As Double

    Public Sub New(ByVal Fecha As Date)
        Me.Fecha = Fecha
    End Sub

    Public Sub New(ByVal Fecha As Date, ByVal Tema As Char, ByVal Valor As Double)
        Me.Fecha = Fecha
        Me.Tema = Tema
        Me.Valor = Valor
    End Sub

    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property

    Public Property Tema() As Char
        Get
            Return mTema
        End Get
        Set(ByVal Value As Char)
            mTema = Value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return mValor
        End Get
        Set(ByVal value As Double)
            mValor = value
        End Set
    End Property

    Public ReadOnly Property DiaLetras() As String
        Get
            Select Case Fecha.DayOfWeek
                Case DayOfWeek.Monday
                    Return "Lun"
                Case DayOfWeek.Tuesday
                    Return "Mar"
                Case DayOfWeek.Wednesday
                    Return "Mié"
                Case DayOfWeek.Thursday
                    Return "Jue"
                Case DayOfWeek.Friday
                    Return "Vie"
                Case DayOfWeek.Saturday
                    Return "Sáb"
                Case DayOfWeek.Sunday
                    Return "Dom"
            End Select
        End Get
    End Property

    Public ReadOnly Property DiaNumero() As String
        Get
            Return Fecha.Day
        End Get
    End Property

    Public ReadOnly Property MesLetras() As String
        Get
            Select Case Fecha.Month
                Case 1
                    Return "Enero"
                Case 2
                    Return "Febrero"
                Case 3
                    Return "Marzo"
                Case 4
                    Return "Abril"
                Case 5
                    Return "Mayo"
                Case 6
                    Return "Junio"
                Case 7
                    Return "Julio"
                Case 8
                    Return "Agosto"
                Case 9
                    Return "Septiembre"
                Case 10
                    Return "Octubre"
                Case 11
                    Return "Noviembre"
                Case 12
                    Return "Diciembre"
            End Select
        End Get
    End Property
End Class
Public Class DiaCalendarioPrensa
    Dim mFecha As Date

    Public Sub New(ByVal Fecha As Date)
        Me.Fecha = Fecha
    End Sub
    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property
    Public ReadOnly Property DiaLetras() As String
        Get
            Select Case Fecha.DayOfWeek
                Case DayOfWeek.Monday
                    Return "Lun"
                Case DayOfWeek.Tuesday
                    Return "Mar"
                Case DayOfWeek.Wednesday
                    Return "Mié"
                Case DayOfWeek.Thursday
                    Return "Jue"
                Case DayOfWeek.Friday
                    Return "Vie"
                Case DayOfWeek.Saturday
                    Return "Sáb"
                Case DayOfWeek.Sunday
                    Return "Dom"
            End Select
        End Get
    End Property

    Public ReadOnly Property DiaNumero() As String
        Get
            Return Fecha.Day
        End Get
    End Property

    Public ReadOnly Property MesLetras() As String
        Get
            Select Case Fecha.Month
                Case 1
                    Return "Enero"
                Case 2
                    Return "Febrero"
                Case 3
                    Return "Marzo"
                Case 4
                    Return "Abril"
                Case 5
                    Return "Mayo"
                Case 6
                    Return "Junio"
                Case 7
                    Return "Julio"
                Case 8
                    Return "Agosto"
                Case 9
                    Return "Septiembre"
                Case 10
                    Return "Octubre"
                Case 11
                    Return "Noviembre"
                Case 12
                    Return "Diciembre"
            End Select
        End Get
    End Property
End Class
'Public Class DiaCalendarioInternet
'Dim mFechaDesde As Date
'    Dim mFechaHasta As Date

'    Public Sub New(ByVal FechaDesde As Date, ByVal FechaHasta As Date)
'        Me.FechaDesde = FechaDesde
'        Me.FechaHasta = FechaHasta
'    End Sub
'    Public Property FechaDesde() As Date
'        Get
'            Return mFechaDesde
'        End Get
'        Set(ByVal Value As Date)
'            mFechaDesde = Value
'        End Set
'    End Property
'    Public Property FechaHasta() As Date
'        Get
'            Return mFechaHasta
'        End Get
'        Set(ByVal Value As Date)
'            mFechaHasta = Value
'        End Set
'    End Property
'    Public ReadOnly Property DiaLetras() As String
'        Get
'            Select Case Fecha.DayOfWeek
'                Case DayOfWeek.Monday
'                    Return "Lun"
'                Case DayOfWeek.Tuesday
'                    Return "Mar"
'                Case DayOfWeek.Wednesday
'                    Return "Mié"
'                Case DayOfWeek.Thursday
'                    Return "Jue"
'                Case DayOfWeek.Friday
'                    Return "Vie"
'                Case DayOfWeek.Saturday
'                    Return "Sáb"
'                Case DayOfWeek.Sunday
'                    Return "Dom"
'            End Select
'        End Get
'    End Property

'    Public ReadOnly Property DiaNumero() As String
'        Get
'            Return Fecha.Day
'        End Get
'    End Property

'    Public ReadOnly Property MesLetras() As String
'        Get
'            Select Case Fecha.Month
'                Case 1
'                    Return "Enero"
'                Case 2
'                    Return "Febrero"
'                Case 3
'                    Return "Marzo"
'                Case 4
'                    Return "Abril"
'                Case 5
'                    Return "Mayo"
'                Case 6
'                    Return "Junio"
'                Case 7
'                    Return "Julio"
'                Case 8
'                    Return "Agosto"
'                Case 9
'                    Return "Septiembre"
'                Case 10
'                    Return "Octubre"
'                Case 11
'                    Return "Noviembre"
'                Case 12
'                    Return "Diciembre"
'            End Select
'        End Get
'    End Property
'End Class
Public Class RegistroCalendario
    Public Cadena As String
    Public Dia As String
    Public Hora As String
    Public Programa As String
    '----- PRENSA -----
    Public Material As String
    Public ProductoMaterial As String
    Public ConceptoSeccion As String
    Public Anuncio As String
    Public Tamaño As String
    Public AnchoAlto As String
    '----- PRENSA -----
    '----- EXTERIOR -----
    Public Formato As String
    Public ProvinciaPoblacion As String
    '----- EXTERIOR -----
    Public TarifaBruta As Decimal
    Public D1 As Decimal
    Public D2 As Decimal
    Public D3 As Decimal
    Public D4 As Decimal
    Public D5 As Decimal
    Public TarifaNeta As Decimal
    Public Dur As Integer
    Public CostoSpot As Decimal
    Public Rating As Single
    Public CPR As Decimal
    Public Tema As String
    Public TotalSpots As Integer = 0
    Public TotalTrps As Single = 0
    Public TotalNeto As Decimal = 0
    '----- INTERNET -----
    Public Proveedor As String
    Public Soporte As String
    Public TipoSoporte As String
    Public Ubicacion As String
    Public TipoFormato As String
    Public TipoCompra As String
    Public CantidadDias As Integer
    Public CantidadHoras As Integer
    Public Bruto As Decimal
    Public Descuento1 As Decimal
    Public Descuento2 As Decimal
    Public Neto As Decimal
    Public Inversion As Decimal
    Public Impresiones As Integer
    Public Clicks As Integer
    Public Views As Integer
    Public Shar As Decimal
    Public Porsag As Decimal
    Public Impsag As Decimal
    Public Total As Decimal
    'LC 25/06/2014 Reporte calendario cantidad de avisos
    Public Factor As Integer = 0

    Dim mDias As ArrayList

    Public Property Dias() As ArrayList
        Get
            If mDias Is Nothing Then
                mDias = New ArrayList
            End If

            Return mDias
        End Get
        Set(ByVal Value As ArrayList)
            mDias = Value
        End Set
    End Property

    Public Sub Cargar(ByVal Dr As DataRow, Optional ByVal MostrarCampoDia As Boolean = True)
        Me.Cadena = IIf(IsDBNull(Dr("cadena")) = True, "", Dr("cadena"))
        If MostrarCampoDia Then
            Me.Dia = Dr("dia")
        End If
        Me.Hora = Dr("hora")
        Me.Programa = Dr("programa")
        Me.TarifaBruta = Dr("tarifaBruta")
        Me.D1 = Dr("D1")
        Me.D2 = Dr("D2")
        Me.D3 = Dr("D3")
        Me.D4 = Dr("D4")
        Me.D5 = Dr("D5")
        Me.TarifaNeta = Valores.CastDBNull(Dr("TarifaNeta"))
        Me.Dur = Dr("dur")
        Me.CostoSpot = Valores.CastDBNull(Dr("CostoSpot"))
        Me.Tema = Dr("id_tema")

        If Dr("Tipo_Rating") = "P" Or Dr("Tipo_Rating") = "F" Then
            Me.Rating = Dr("ratingPrograma")
            Me.CPR = Valores.CastDBNull(Dr("CPRProg"))
            Me.TotalTrps += Dr("ratingPrograma")
        Else
            Me.Rating = Valores.CastDBNull(Dr("ratingTanda"))
            Me.CPR = Valores.CastDBNull(Dr("CPRTanda"))
            Me.TotalTrps += Dr("ratingTanda")
        End If

        Dr("rating") = Me.Rating
        Dr("TotalTrps") = Me.TotalTrps

        Me.TotalSpots += 1
        Me.TotalNeto += Valores.CastDBNull(Dr("TarifaNeta")) * Me.Dur
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.Factor = Dr("Factor")
    End Sub
    Public Sub CargarPrensa(ByVal Dr As DataRow, Optional ByVal MostrarCampoDia As Boolean = True)
        Me.Cadena = IIf(IsDBNull(Dr("cadena")) = True, "", Dr("cadena"))
        Me.ProductoMaterial = Dr("producto-material")
        Me.ConceptoSeccion = Dr("concepto-seccion")
        Me.Tamaño = Dr("tamanio")
        Me.AnchoAlto = IIf(IsDBNull(Dr("anchoxalto")) = True, "", Dr("anchoxalto"))
        Me.TarifaBruta = Dr("tarifaBruta")
        Me.D1 = Dr("D1")
        Me.D2 = Dr("D2")
        Me.D3 = Dr("D3")
        Me.D4 = Dr("D4")
        Me.D5 = Dr("D5")
        Me.TarifaNeta = Valores.CastDBNull(Dr("TarifaNeta"))

        Me.TotalSpots += 1
        Me.TotalNeto += Valores.CastDBNull(Dr("TarifaNeta"))
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.Factor = Dr("Factor")
    End Sub

    Public Sub CargarInternet(ByVal Dr As DataRow, Optional ByVal MostrarCampoDia As Boolean = True)
        Me.Proveedor = Dr("PROVEEDOR")
        Me.Soporte = IIf(IsDBNull(Dr("SOPORTE")) = True, "", Dr("SOPORTE").ToString().Remove(Dr("SOPORTE").ToString().LastIndexOf("|")))
        Me.TipoSoporte = IIf(IsDBNull(Dr("TIPO_SOPORTE")) = True, "", Dr("TIPO_SOPORTE"))
        Me.Ubicacion = IIf(IsDBNull(Dr("UBICACION")) = True, "", Dr("UBICACION"))
        Me.TipoFormato = IIf(IsDBNull(Dr("TIPO_FORMATO")) = True, "", Dr("TIPO_FORMATO"))
        Me.Formato = IIf(IsDBNull(Dr("FORMATO")) = True, "", Dr("FORMATO"))
        Me.TipoCompra = IIf(IsDBNull(Dr("TIPO_COMPRA")) = True, "", Dr("TIPO_COMPRA"))
        Me.CantidadDias = Dr("CANTIDAD_DIAS")
        Me.CantidadHoras = Dr("CANTIDAD_HORAS")
        Me.Bruto = Dr("BRUTO")
        Me.Descuento1 = Dr("DCTO1")
        Me.Descuento2 = Dr("DCTO2")
        Me.Neto = Dr("NETO")
        Me.Inversion = Dr("INVERSION")
        Me.Impresiones = Dr("IMPRESIONES")
        Me.Clicks = Dr("CLICKS")
        Me.Views = Dr("VIEWS")
        Me.Shar = Dr("SHAR")
        Me.Porsag = Dr("PORSAG")
        Dim ImpSag As Decimal = Me.Inversion * (Dr("PORSAG") / 100)
        Dim Total As Decimal = Me.Inversion + ImpSag
        Me.Impsag = ImpSag
        Me.Total = Total

        'Me.TotalSpots += 1
        Me.TotalNeto += Total
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.Factor = Dr("Factor")
    End Sub

    Public Sub CargarExterior(ByVal Dr As DataRow, Optional ByVal MostrarCampoDia As Boolean = True)
        Me.Cadena = Dr("cadena")
        Me.ProductoMaterial = Dr("producto-material")
        Me.Formato = Dr("formato")
        Me.ProvinciaPoblacion = Dr("provincia-poblacion")
        Me.TarifaBruta = Dr("tarifaBruta")
        Me.D1 = Dr("D1")
        Me.D2 = Dr("D2")
        Me.D3 = Dr("D3")
        Me.D4 = Dr("D4")
        Me.D5 = Dr("D5")
        Me.TarifaNeta = Valores.CastDBNull(Dr("TarifaNeta"))

        Me.TotalSpots += 1
        Me.TotalNeto += Valores.CastDBNull(Dr("TarifaNeta"))
        'LC 25/06/2014 Reporte calendario cantidad de avisos
        Me.Factor = Dr("Factor")
    End Sub
End Class
Public Class ComparaDiasCalendario
    Implements IComparer

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim Dia1 As DiaCalendario = DirectCast(x, DiaCalendario)
        Dim Dia2 As DiaCalendario = DirectCast(y, DiaCalendario)

        If Dia1.Tema < Dia2.Tema Then
            Return -1
        End If

        If Dia1.Tema > Dia2.Tema Then
            Return 1
        End If

        If Dia1.Tema = Dia2.Tema Then
            Return 0
        End If
    End Function
End Class

Public Class DatosDesgloseFranjas
    Dim mFranja As String
    Dim mSpots As Integer
    Dim mTRPs As Single
    Dim mCPR As Decimal

    Public Property Franja() As String
        Get
            Return mFranja
        End Get
        Set(ByVal Value As String)
            mFranja = Value
        End Set
    End Property

    Public Property Spots() As Integer
        Get
            Return mSpots
        End Get
        Set(ByVal Value As Integer)
            mSpots = Value
        End Set
    End Property

    Public Property TRPs() As Single
        Get
            Return mTRPs
        End Get
        Set(ByVal Value As Single)
            mTRPs = Value
        End Set
    End Property

    Public Property CPR() As Decimal
        Get
            Return mCPR
        End Get
        Set(ByVal Value As Decimal)
            mCPR = Value
        End Set
    End Property

End Class

Public Class SoporteDias

    Private _soporte As String
    Public Property Soporte() As String
        Get
            Return _soporte
        End Get
        Set(ByVal value As String)
            _soporte = value
        End Set
    End Property

    Private _dias As List(Of DiaCalendario)
    Public Property Dias() As List(Of DiaCalendario)
        Get
            Return _dias
        End Get
        Set(ByVal value As List(Of DiaCalendario))
            _dias = value
        End Set
    End Property

    Sub New()
        Me._soporte = String.Empty
        Me._dias = New List(Of DiaCalendario)
    End Sub

End Class
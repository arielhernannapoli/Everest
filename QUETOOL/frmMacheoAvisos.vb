Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Excel
Imports HM.MMS.AR.Server.BusinessEntity.Control
Imports System.Collections.Generic
Imports System.Collections
Imports HM.Comun.SolutionEntityFramework.BaseClasse
Imports HM.Comun.SolutionEntityFramework.Common
Imports HM.Comun.SolutionEntityFramework
Imports System.Runtime.Serialization
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Reflection
Imports System.ComponentModel
Imports Framework.ExportacionUtil

Public Class frmMacheoAvisos
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        'AS 2015/03 =======================================================================
        Me.bWorker = New BackgroundWorker
        AddHandler Me.bWorker.DoWork, AddressOf ExportarCaratulaBackground

    End Sub

    'AS 2015-03
    Private Sub ExportarCaratulaBackground(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim param As Framework.ExportacionUtil.ParametrosExportacionLegajos = DirectCast(e.Argument, Framework.ExportacionUtil.ParametrosExportacionLegajos)

        Dim ruta As String = Framework.ExportacionUtil.ParametrosExportacionLegajos.RutaExportacionCaratula
        Dim nombreArchivo As String = String.Format("{0}_{1}.pdf", param.NumCompania, param.NumPresupuesto)
        Dim rutaCompleta As String = String.Format(" {0}\{1}", ruta, nombreArchivo)

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = CType(param.Param1, CrystalDecisions.CrystalReports.Engine.ReportDocument)

        Try
            reportDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, rutaCompleta)
        Catch
            'Reportes.Util.LogExportacionLegajo(param)
        End Try
        e.Result = 0
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
    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents btnPresupuesto As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtPresupuesto As QUETOOL.txtTexto
    Friend WithEvents lblPresupuesto As System.Windows.Forms.Label
    Friend WithEvents pnlGeneral As System.Windows.Forms.Panel
    Friend WithEvents pnlOrdenes As System.Windows.Forms.Panel
    Friend WithEvents ugOrdenAviso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents _pnlOrdenes_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlOrdenes_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlOrdenes_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlOrdenes_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsManagerOrdenes As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents UltraToolbarsManagerGeneral As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents pnlFiltro_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _pnlFiltro_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlFiltro_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlFiltro_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlFiltro_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents SplitterOrdenesResumen As System.Windows.Forms.Splitter
    Friend WithEvents pnlResumen As System.Windows.Forms.Panel
    Friend WithEvents pnlResumenNoOrdenado As System.Windows.Forms.Panel
    Friend WithEvents pnlCaidos As System.Windows.Forms.Panel
    Friend WithEvents SplitterCaidosReprogramados As System.Windows.Forms.Splitter
    Friend WithEvents pnlReprogramados As System.Windows.Forms.Panel
    Friend WithEvents ugCaidos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugReprogramados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraToolbarsManagerCaidos As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _pnlCaidos_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCaidos_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCaidos_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCaidos_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsManagerReprogramados As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _pnlReprogramados_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlReprogramados_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlReprogramados_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlReprogramados_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents SplitterNoOrdenadoCertificado As System.Windows.Forms.Splitter
    Friend WithEvents pnlResumenCertificado As System.Windows.Forms.Panel
    Friend WithEvents pnlCertificados As System.Windows.Forms.Panel
    Friend WithEvents UltraToolbarsManagerCertificados As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _pnlCertificados_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCertificados_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCertificados_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _pnlCertificados_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ugCertificados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblCantidadCaidos As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMacheoAvisos))
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbarGeneral")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim PopupMenuTool1 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Reporte")
        Dim PopupMenuTool2 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Exportar")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Blanquear")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteControl")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteFinanzas")
        Dim PopupMenuTool3 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Reporte")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteControl")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ReporteFinanzas")
        Dim PopupMenuTool4 As Infragistics.Win.UltraWinToolbars.PopupMenuTool = New Infragistics.Win.UltraWinToolbars.PopupMenuTool("Exportar")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExportarControl")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExportarFinanzas")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExportarControl")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ExportarFinanzas")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar2 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbarCertificados")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar3 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbarReprogramados")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar4 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbarCaidos")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AjustarAvisos")
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("AjustarAvisos")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolbar5 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbarOrdenes")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Caidos")
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reprogramados")
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Certificados")
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Aviso")
        Dim ButtonTool25 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Reprogramados")
        Dim ButtonTool26 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Caidos")
        Dim ButtonTool27 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Aviso")
        Dim ButtonTool28 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Certificados")
        Me.pnlFiltro = New System.Windows.Forms.Panel
        Me.pnlFiltro_Fill_Panel = New System.Windows.Forms.Panel
        Me.txtPresupuesto = New QUETOOL.txtTexto
        Me.btnPresupuesto = New Infragistics.Win.Misc.UltraButton
        Me.lblPresupuesto = New System.Windows.Forms.Label
        Me._pnlFiltro_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManagerGeneral = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlFiltro_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlFiltro_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.pnlGeneral = New System.Windows.Forms.Panel
        Me.pnlResumen = New System.Windows.Forms.Panel
        Me.pnlResumenCertificado = New System.Windows.Forms.Panel
        Me.pnlCertificados = New System.Windows.Forms.Panel
        Me.ugCertificados = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlCertificados_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManagerCertificados = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlCertificados_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlCertificados_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.SplitterNoOrdenadoCertificado = New System.Windows.Forms.Splitter
        Me.pnlResumenNoOrdenado = New System.Windows.Forms.Panel
        Me.pnlReprogramados = New System.Windows.Forms.Panel
        Me.ugReprogramados = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlReprogramados_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManagerReprogramados = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlReprogramados_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlReprogramados_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.SplitterCaidosReprogramados = New System.Windows.Forms.Splitter
        Me.pnlCaidos = New System.Windows.Forms.Panel
        Me.lblCantidadCaidos = New System.Windows.Forms.Label
        Me.ugCaidos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlCaidos_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManagerCaidos = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlCaidos_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlCaidos_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.SplitterOrdenesResumen = New System.Windows.Forms.Splitter
        Me.pnlOrdenes = New System.Windows.Forms.Panel
        Me.ugOrdenAviso = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me._pnlOrdenes_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManagerOrdenes = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._pnlOrdenes_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlOrdenes_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.pnlFiltro.SuspendLayout()
        Me.pnlFiltro_Fill_Panel.SuspendLayout()
        CType(Me.UltraToolbarsManagerGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        Me.pnlResumen.SuspendLayout()
        Me.pnlResumenCertificado.SuspendLayout()
        Me.pnlCertificados.SuspendLayout()
        CType(Me.ugCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManagerCertificados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResumenNoOrdenado.SuspendLayout()
        Me.pnlReprogramados.SuspendLayout()
        CType(Me.ugReprogramados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManagerReprogramados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCaidos.SuspendLayout()
        CType(Me.ugCaidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManagerCaidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrdenes.SuspendLayout()
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManagerOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.pnlFiltro_Fill_Panel)
        Me.pnlFiltro.Controls.Add(Me._pnlFiltro_Toolbars_Dock_Area_Left)
        Me.pnlFiltro.Controls.Add(Me._pnlFiltro_Toolbars_Dock_Area_Right)
        Me.pnlFiltro.Controls.Add(Me._pnlFiltro_Toolbars_Dock_Area_Top)
        Me.pnlFiltro.Controls.Add(Me._pnlFiltro_Toolbars_Dock_Area_Bottom)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(974, 56)
        Me.pnlFiltro.TabIndex = 1
        '
        'pnlFiltro_Fill_Panel
        '
        Me.pnlFiltro_Fill_Panel.Controls.Add(Me.txtPresupuesto)
        Me.pnlFiltro_Fill_Panel.Controls.Add(Me.btnPresupuesto)
        Me.pnlFiltro_Fill_Panel.Controls.Add(Me.lblPresupuesto)
        Me.pnlFiltro_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlFiltro_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFiltro_Fill_Panel.Location = New System.Drawing.Point(0, 22)
        Me.pnlFiltro_Fill_Panel.Name = "pnlFiltro_Fill_Panel"
        Me.pnlFiltro_Fill_Panel.Size = New System.Drawing.Size(974, 34)
        Me.pnlFiltro_Fill_Panel.TabIndex = 0
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.AcceptsReturn = True
        Me.txtPresupuesto.AcceptsTab = True
        Me.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresupuesto.ConDecimal = False
        Me.txtPresupuesto.Location = New System.Drawing.Point(80, 8)
        Me.txtPresupuesto.Maximo = 0
        Me.txtPresupuesto.MaxLength = 9
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(88, 20)
        Me.txtPresupuesto.SoloLetra = False
        Me.txtPresupuesto.SoloNumero = True
        Me.txtPresupuesto.TabIndex = 1
        Me.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPresupuesto
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnPresupuesto.Appearance = Appearance1
        Me.btnPresupuesto.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Flat
        Me.btnPresupuesto.Location = New System.Drawing.Point(172, 8)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(24, 21)
        Me.btnPresupuesto.TabIndex = 18
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Location = New System.Drawing.Point(4, 10)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(72, 13)
        Me.lblPresupuesto.TabIndex = 10
        Me.lblPresupuesto.Text = "Presupuesto :"
        '
        '_pnlFiltro_Toolbars_Dock_Area_Left
        '
        Me._pnlFiltro_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlFiltro_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlFiltro_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlFiltro_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlFiltro_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlFiltro_Toolbars_Dock_Area_Left.Name = "_pnlFiltro_Toolbars_Dock_Area_Left"
        Me._pnlFiltro_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 34)
        Me._pnlFiltro_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManagerGeneral
        '
        'UltraToolbarsManagerGeneral
        '
        Me.UltraToolbarsManagerGeneral.DesignerFlags = 1
        Me.UltraToolbarsManagerGeneral.DockWithinContainer = Me.pnlFiltro
        Me.UltraToolbarsManagerGeneral.LockToolbars = True
        Me.UltraToolbarsManagerGeneral.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "UltraToolbarGeneral"
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, PopupMenuTool1, PopupMenuTool2, ButtonTool2})
        Me.UltraToolbarsManagerGeneral.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool3.SharedProps.Caption = "Blanquear"
        ButtonTool4.SharedProps.Caption = "Salir"
        ButtonTool5.SharedProps.Caption = "Reporte Control"
        ButtonTool6.SharedProps.Caption = "Reporte Finanzas"
        PopupMenuTool3.SharedProps.Caption = "Reportes"
        PopupMenuTool3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool7, ButtonTool8})
        PopupMenuTool4.SharedProps.Caption = "Exportar"
        PopupMenuTool4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool9, ButtonTool10})
        ButtonTool11.SharedProps.Caption = "Reporte Control"
        ButtonTool12.SharedProps.Caption = "Reporte Finanzas"
        Me.UltraToolbarsManagerGeneral.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, PopupMenuTool3, PopupMenuTool4, ButtonTool11, ButtonTool12})
        '
        '_pnlFiltro_Toolbars_Dock_Area_Right
        '
        Me._pnlFiltro_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlFiltro_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlFiltro_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlFiltro_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlFiltro_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(974, 22)
        Me._pnlFiltro_Toolbars_Dock_Area_Right.Name = "_pnlFiltro_Toolbars_Dock_Area_Right"
        Me._pnlFiltro_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 34)
        Me._pnlFiltro_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManagerGeneral
        '
        '_pnlFiltro_Toolbars_Dock_Area_Top
        '
        Me._pnlFiltro_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlFiltro_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlFiltro_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlFiltro_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlFiltro_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlFiltro_Toolbars_Dock_Area_Top.Name = "_pnlFiltro_Toolbars_Dock_Area_Top"
        Me._pnlFiltro_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(974, 22)
        Me._pnlFiltro_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManagerGeneral
        '
        '_pnlFiltro_Toolbars_Dock_Area_Bottom
        '
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 56)
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.Name = "_pnlFiltro_Toolbars_Dock_Area_Bottom"
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(974, 0)
        Me._pnlFiltro_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManagerGeneral
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.pnlResumen)
        Me.pnlGeneral.Controls.Add(Me.SplitterOrdenesResumen)
        Me.pnlGeneral.Controls.Add(Me.pnlOrdenes)
        Me.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGeneral.Location = New System.Drawing.Point(0, 56)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(974, 643)
        Me.pnlGeneral.TabIndex = 2
        '
        'pnlResumen
        '
        Me.pnlResumen.Controls.Add(Me.pnlResumenCertificado)
        Me.pnlResumen.Controls.Add(Me.SplitterNoOrdenadoCertificado)
        Me.pnlResumen.Controls.Add(Me.pnlResumenNoOrdenado)
        Me.pnlResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResumen.Location = New System.Drawing.Point(0, 327)
        Me.pnlResumen.Name = "pnlResumen"
        Me.pnlResumen.Size = New System.Drawing.Size(974, 316)
        Me.pnlResumen.TabIndex = 2
        '
        'pnlResumenCertificado
        '
        Me.pnlResumenCertificado.Controls.Add(Me.pnlCertificados)
        Me.pnlResumenCertificado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlResumenCertificado.Location = New System.Drawing.Point(0, 187)
        Me.pnlResumenCertificado.Name = "pnlResumenCertificado"
        Me.pnlResumenCertificado.Size = New System.Drawing.Size(974, 129)
        Me.pnlResumenCertificado.TabIndex = 4
        '
        'pnlCertificados
        '
        Me.pnlCertificados.Controls.Add(Me.ugCertificados)
        Me.pnlCertificados.Controls.Add(Me._pnlCertificados_Toolbars_Dock_Area_Left)
        Me.pnlCertificados.Controls.Add(Me._pnlCertificados_Toolbars_Dock_Area_Right)
        Me.pnlCertificados.Controls.Add(Me._pnlCertificados_Toolbars_Dock_Area_Top)
        Me.pnlCertificados.Controls.Add(Me._pnlCertificados_Toolbars_Dock_Area_Bottom)
        Me.pnlCertificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCertificados.Location = New System.Drawing.Point(0, 0)
        Me.pnlCertificados.Name = "pnlCertificados"
        Me.pnlCertificados.Size = New System.Drawing.Size(974, 129)
        Me.pnlCertificados.TabIndex = 0
        '
        'ugCertificados
        '
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugCertificados.DisplayLayout.Appearance = Appearance2
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand1.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugCertificados.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugCertificados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugCertificados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.ugCertificados.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugCertificados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.ugCertificados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugCertificados.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.ugCertificados.DisplayLayout.MaxColScrollRegions = 1
        Me.ugCertificados.DisplayLayout.MaxRowScrollRegions = 1
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugCertificados.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugCertificados.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ugCertificados.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugCertificados.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugCertificados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugCertificados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.ugCertificados.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugCertificados.DisplayLayout.Override.CellAppearance = Appearance9
        Me.ugCertificados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugCertificados.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.ugCertificados.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugCertificados.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ugCertificados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugCertificados.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.ugCertificados.DisplayLayout.Override.RowAppearance = Appearance12
        Me.ugCertificados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugCertificados.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.ugCertificados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugCertificados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugCertificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugCertificados.FlatMode = True
        Me.ugCertificados.Location = New System.Drawing.Point(0, 22)
        Me.ugCertificados.Name = "ugCertificados"
        Me.ugCertificados.Size = New System.Drawing.Size(974, 107)
        Me.ugCertificados.TabIndex = 4
        Me.ugCertificados.Text = "Avisos Certificados"
        '
        '_pnlCertificados_Toolbars_Dock_Area_Left
        '
        Me._pnlCertificados_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCertificados_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCertificados_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlCertificados_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCertificados_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlCertificados_Toolbars_Dock_Area_Left.Name = "_pnlCertificados_Toolbars_Dock_Area_Left"
        Me._pnlCertificados_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 107)
        Me._pnlCertificados_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManagerCertificados
        '
        'UltraToolbarsManagerCertificados
        '
        Me.UltraToolbarsManagerCertificados.DesignerFlags = 1
        Me.UltraToolbarsManagerCertificados.DockWithinContainer = Me.pnlCertificados
        Me.UltraToolbarsManagerCertificados.LockToolbars = True
        Me.UltraToolbarsManagerCertificados.ShowFullMenusDelay = 500
        UltraToolbar2.DockedColumn = 0
        UltraToolbar2.DockedRow = 0
        UltraToolbar2.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar2.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar2.Text = "UltraToolbarCertificados"
        UltraToolbar2.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13})
        Me.UltraToolbarsManagerCertificados.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar2})
        ButtonTool14.SharedProps.Caption = "Eliminar"
        Me.UltraToolbarsManagerCertificados.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool14})
        '
        '_pnlCertificados_Toolbars_Dock_Area_Right
        '
        Me._pnlCertificados_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCertificados_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCertificados_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlCertificados_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCertificados_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(974, 22)
        Me._pnlCertificados_Toolbars_Dock_Area_Right.Name = "_pnlCertificados_Toolbars_Dock_Area_Right"
        Me._pnlCertificados_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 107)
        Me._pnlCertificados_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManagerCertificados
        '
        '_pnlCertificados_Toolbars_Dock_Area_Top
        '
        Me._pnlCertificados_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCertificados_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCertificados_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlCertificados_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCertificados_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlCertificados_Toolbars_Dock_Area_Top.Name = "_pnlCertificados_Toolbars_Dock_Area_Top"
        Me._pnlCertificados_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(974, 22)
        Me._pnlCertificados_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManagerCertificados
        '
        '_pnlCertificados_Toolbars_Dock_Area_Bottom
        '
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 129)
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.Name = "_pnlCertificados_Toolbars_Dock_Area_Bottom"
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(974, 0)
        Me._pnlCertificados_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManagerCertificados
        '
        'SplitterNoOrdenadoCertificado
        '
        Me.SplitterNoOrdenadoCertificado.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterNoOrdenadoCertificado.Location = New System.Drawing.Point(0, 184)
        Me.SplitterNoOrdenadoCertificado.Name = "SplitterNoOrdenadoCertificado"
        Me.SplitterNoOrdenadoCertificado.Size = New System.Drawing.Size(974, 3)
        Me.SplitterNoOrdenadoCertificado.TabIndex = 3
        Me.SplitterNoOrdenadoCertificado.TabStop = False
        '
        'pnlResumenNoOrdenado
        '
        Me.pnlResumenNoOrdenado.Controls.Add(Me.pnlReprogramados)
        Me.pnlResumenNoOrdenado.Controls.Add(Me.SplitterCaidosReprogramados)
        Me.pnlResumenNoOrdenado.Controls.Add(Me.pnlCaidos)
        Me.pnlResumenNoOrdenado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlResumenNoOrdenado.Location = New System.Drawing.Point(0, 0)
        Me.pnlResumenNoOrdenado.Name = "pnlResumenNoOrdenado"
        Me.pnlResumenNoOrdenado.Size = New System.Drawing.Size(974, 184)
        Me.pnlResumenNoOrdenado.TabIndex = 0
        '
        'pnlReprogramados
        '
        Me.pnlReprogramados.Controls.Add(Me.ugReprogramados)
        Me.pnlReprogramados.Controls.Add(Me._pnlReprogramados_Toolbars_Dock_Area_Left)
        Me.pnlReprogramados.Controls.Add(Me._pnlReprogramados_Toolbars_Dock_Area_Right)
        Me.pnlReprogramados.Controls.Add(Me._pnlReprogramados_Toolbars_Dock_Area_Top)
        Me.pnlReprogramados.Controls.Add(Me._pnlReprogramados_Toolbars_Dock_Area_Bottom)
        Me.pnlReprogramados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReprogramados.Location = New System.Drawing.Point(367, 0)
        Me.pnlReprogramados.Name = "pnlReprogramados"
        Me.pnlReprogramados.Size = New System.Drawing.Size(607, 184)
        Me.pnlReprogramados.TabIndex = 2
        '
        'ugReprogramados
        '
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugReprogramados.DisplayLayout.Appearance = Appearance14
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand2.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand2.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand2.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand2.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugReprogramados.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugReprogramados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugReprogramados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.ugReprogramados.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugReprogramados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.ugReprogramados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugReprogramados.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.ugReprogramados.DisplayLayout.MaxColScrollRegions = 1
        Me.ugReprogramados.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugReprogramados.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugReprogramados.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.ugReprogramados.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugReprogramados.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugReprogramados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugReprogramados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.ugReprogramados.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugReprogramados.DisplayLayout.Override.CellAppearance = Appearance21
        Me.ugReprogramados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugReprogramados.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.ugReprogramados.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugReprogramados.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.ugReprogramados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugReprogramados.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.ugReprogramados.DisplayLayout.Override.RowAppearance = Appearance24
        Me.ugReprogramados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugReprogramados.DisplayLayout.Override.TemplateAddRowAppearance = Appearance25
        Me.ugReprogramados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugReprogramados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugReprogramados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugReprogramados.FlatMode = True
        Me.ugReprogramados.Location = New System.Drawing.Point(0, 22)
        Me.ugReprogramados.Name = "ugReprogramados"
        Me.ugReprogramados.Size = New System.Drawing.Size(607, 162)
        Me.ugReprogramados.TabIndex = 1
        Me.ugReprogramados.Text = "Avisos Reprogramados"
        '
        '_pnlReprogramados_Toolbars_Dock_Area_Left
        '
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.Name = "_pnlReprogramados_Toolbars_Dock_Area_Left"
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 162)
        Me._pnlReprogramados_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManagerReprogramados
        '
        'UltraToolbarsManagerReprogramados
        '
        Me.UltraToolbarsManagerReprogramados.DesignerFlags = 1
        Me.UltraToolbarsManagerReprogramados.DockWithinContainer = Me.pnlReprogramados
        Me.UltraToolbarsManagerReprogramados.LockToolbars = True
        Me.UltraToolbarsManagerReprogramados.ShowFullMenusDelay = 500
        UltraToolbar3.DockedColumn = 0
        UltraToolbar3.DockedRow = 0
        UltraToolbar3.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar3.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar3.Text = "UltraToolbarReprogramados"
        UltraToolbar3.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool15})
        Me.UltraToolbarsManagerReprogramados.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar3})
        ButtonTool16.SharedProps.Caption = "Eliminar"
        Me.UltraToolbarsManagerReprogramados.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool16})
        '
        '_pnlReprogramados_Toolbars_Dock_Area_Right
        '
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(607, 22)
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.Name = "_pnlReprogramados_Toolbars_Dock_Area_Right"
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 162)
        Me._pnlReprogramados_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManagerReprogramados
        '
        '_pnlReprogramados_Toolbars_Dock_Area_Top
        '
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.Name = "_pnlReprogramados_Toolbars_Dock_Area_Top"
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(607, 22)
        Me._pnlReprogramados_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManagerReprogramados
        '
        '_pnlReprogramados_Toolbars_Dock_Area_Bottom
        '
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 184)
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.Name = "_pnlReprogramados_Toolbars_Dock_Area_Bottom"
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(607, 0)
        Me._pnlReprogramados_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManagerReprogramados
        '
        'SplitterCaidosReprogramados
        '
        Me.SplitterCaidosReprogramados.Location = New System.Drawing.Point(364, 0)
        Me.SplitterCaidosReprogramados.Name = "SplitterCaidosReprogramados"
        Me.SplitterCaidosReprogramados.Size = New System.Drawing.Size(3, 184)
        Me.SplitterCaidosReprogramados.TabIndex = 1
        Me.SplitterCaidosReprogramados.TabStop = False
        '
        'pnlCaidos
        '
        Me.pnlCaidos.Controls.Add(Me.lblCantidadCaidos)
        Me.pnlCaidos.Controls.Add(Me.ugCaidos)
        Me.pnlCaidos.Controls.Add(Me._pnlCaidos_Toolbars_Dock_Area_Left)
        Me.pnlCaidos.Controls.Add(Me._pnlCaidos_Toolbars_Dock_Area_Right)
        Me.pnlCaidos.Controls.Add(Me._pnlCaidos_Toolbars_Dock_Area_Top)
        Me.pnlCaidos.Controls.Add(Me._pnlCaidos_Toolbars_Dock_Area_Bottom)
        Me.pnlCaidos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCaidos.Location = New System.Drawing.Point(0, 0)
        Me.pnlCaidos.Name = "pnlCaidos"
        Me.pnlCaidos.Size = New System.Drawing.Size(364, 184)
        Me.pnlCaidos.TabIndex = 0
        '
        'lblCantidadCaidos
        '
        Me.lblCantidadCaidos.AutoSize = True
        Me.lblCantidadCaidos.Location = New System.Drawing.Point(290, 4)
        Me.lblCantidadCaidos.Name = "lblCantidadCaidos"
        Me.lblCantidadCaidos.Size = New System.Drawing.Size(39, 13)
        Me.lblCantidadCaidos.TabIndex = 6
        Me.lblCantidadCaidos.Text = "Label1"
        '
        'ugCaidos
        '
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugCaidos.DisplayLayout.Appearance = Appearance26
        UltraGridBand3.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand3.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand3.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand3.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand3.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand3.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand3.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand3.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand3.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand3.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand3.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand3.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand3.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand3.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand3.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand3.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugCaidos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ugCaidos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugCaidos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.ugCaidos.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugCaidos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.ugCaidos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugCaidos.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.ugCaidos.DisplayLayout.MaxColScrollRegions = 1
        Me.ugCaidos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Appearance30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugCaidos.DisplayLayout.Override.ActiveCellAppearance = Appearance30
        Appearance31.BackColor = System.Drawing.SystemColors.Highlight
        Appearance31.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugCaidos.DisplayLayout.Override.ActiveRowAppearance = Appearance31
        Me.ugCaidos.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugCaidos.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugCaidos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugCaidos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Me.ugCaidos.DisplayLayout.Override.CardAreaAppearance = Appearance32
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Appearance33.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugCaidos.DisplayLayout.Override.CellAppearance = Appearance33
        Me.ugCaidos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugCaidos.DisplayLayout.Override.CellPadding = 0
        Appearance34.BackColor = System.Drawing.SystemColors.Control
        Appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance34.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.BorderColor = System.Drawing.SystemColors.Window
        Me.ugCaidos.DisplayLayout.Override.GroupByRowAppearance = Appearance34
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugCaidos.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.ugCaidos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugCaidos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Me.ugCaidos.DisplayLayout.Override.RowAppearance = Appearance36
        Me.ugCaidos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugCaidos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance37
        Me.ugCaidos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugCaidos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugCaidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugCaidos.FlatMode = True
        Me.ugCaidos.Location = New System.Drawing.Point(0, 22)
        Me.ugCaidos.Name = "ugCaidos"
        Me.ugCaidos.Size = New System.Drawing.Size(364, 162)
        Me.ugCaidos.TabIndex = 1
        Me.ugCaidos.Text = "Avisos Caidos"
        '
        '_pnlCaidos_Toolbars_Dock_Area_Left
        '
        Me._pnlCaidos_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCaidos_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCaidos_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlCaidos_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCaidos_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlCaidos_Toolbars_Dock_Area_Left.Name = "_pnlCaidos_Toolbars_Dock_Area_Left"
        Me._pnlCaidos_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 162)
        Me._pnlCaidos_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManagerCaidos
        '
        'UltraToolbarsManagerCaidos
        '
        Me.UltraToolbarsManagerCaidos.DesignerFlags = 1
        Me.UltraToolbarsManagerCaidos.DockWithinContainer = Me.pnlCaidos
        Me.UltraToolbarsManagerCaidos.LockToolbars = True
        Me.UltraToolbarsManagerCaidos.ShowFullMenusDelay = 500
        UltraToolbar4.DockedColumn = 0
        UltraToolbar4.DockedRow = 0
        UltraToolbar4.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar4.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar4.Text = "UltraToolbarCaidos"
        UltraToolbar4.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool18})
        Me.UltraToolbarsManagerCaidos.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar4})
        ButtonTool19.SharedProps.Caption = "Eliminar"
        ButtonTool20.SharedProps.Caption = "Envio Ajustes a MMS"
        Me.UltraToolbarsManagerCaidos.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool19, ButtonTool20})
        '
        '_pnlCaidos_Toolbars_Dock_Area_Right
        '
        Me._pnlCaidos_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCaidos_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCaidos_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlCaidos_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCaidos_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(364, 22)
        Me._pnlCaidos_Toolbars_Dock_Area_Right.Name = "_pnlCaidos_Toolbars_Dock_Area_Right"
        Me._pnlCaidos_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 162)
        Me._pnlCaidos_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManagerCaidos
        '
        '_pnlCaidos_Toolbars_Dock_Area_Top
        '
        Me._pnlCaidos_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCaidos_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCaidos_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlCaidos_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCaidos_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlCaidos_Toolbars_Dock_Area_Top.Name = "_pnlCaidos_Toolbars_Dock_Area_Top"
        Me._pnlCaidos_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(364, 22)
        Me._pnlCaidos_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManagerCaidos
        '
        '_pnlCaidos_Toolbars_Dock_Area_Bottom
        '
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 184)
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.Name = "_pnlCaidos_Toolbars_Dock_Area_Bottom"
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(364, 0)
        Me._pnlCaidos_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManagerCaidos
        '
        'SplitterOrdenesResumen
        '
        Me.SplitterOrdenesResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterOrdenesResumen.Location = New System.Drawing.Point(0, 324)
        Me.SplitterOrdenesResumen.Name = "SplitterOrdenesResumen"
        Me.SplitterOrdenesResumen.Size = New System.Drawing.Size(974, 3)
        Me.SplitterOrdenesResumen.TabIndex = 1
        Me.SplitterOrdenesResumen.TabStop = False
        '
        'pnlOrdenes
        '
        Me.pnlOrdenes.Controls.Add(Me.ugOrdenAviso)
        Me.pnlOrdenes.Controls.Add(Me._pnlOrdenes_Toolbars_Dock_Area_Left)
        Me.pnlOrdenes.Controls.Add(Me._pnlOrdenes_Toolbars_Dock_Area_Right)
        Me.pnlOrdenes.Controls.Add(Me._pnlOrdenes_Toolbars_Dock_Area_Top)
        Me.pnlOrdenes.Controls.Add(Me._pnlOrdenes_Toolbars_Dock_Area_Bottom)
        Me.pnlOrdenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOrdenes.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrdenes.Name = "pnlOrdenes"
        Me.pnlOrdenes.Size = New System.Drawing.Size(974, 324)
        Me.pnlOrdenes.TabIndex = 0
        '
        'ugOrdenAviso
        '
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugOrdenAviso.DisplayLayout.Appearance = Appearance38
        UltraGridBand4.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand4.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand4.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        UltraGridBand4.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand4.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand4.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand4.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand4.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand4.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand4.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand4.Override.AllowRowLayoutCellSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand4.Override.AllowRowLayoutColMoving = Infragistics.Win.Layout.GridBagLayoutAllowMoving.None
        UltraGridBand4.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand4.Override.AllowRowLayoutLabelSpanSizing = Infragistics.Win.Layout.GridBagLayoutAllowSpanSizing.None
        UltraGridBand4.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand4.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugOrdenAviso.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ugOrdenAviso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugOrdenAviso.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.Appearance = Appearance39
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance40
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance41.BackColor2 = System.Drawing.SystemColors.Control
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugOrdenAviso.DisplayLayout.GroupByBox.PromptAppearance = Appearance41
        Me.ugOrdenAviso.DisplayLayout.MaxColScrollRegions = 1
        Me.ugOrdenAviso.DisplayLayout.MaxRowScrollRegions = 1
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Appearance42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveCellAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.SystemColors.Highlight
        Appearance43.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugOrdenAviso.DisplayLayout.Override.ActiveRowAppearance = Appearance43
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugOrdenAviso.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Appearance45.BorderColor = System.Drawing.Color.Silver
        Appearance45.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugOrdenAviso.DisplayLayout.Override.CellAppearance = Appearance45
        Me.ugOrdenAviso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugOrdenAviso.DisplayLayout.Override.CellPadding = 0
        Appearance46.BackColor = System.Drawing.SystemColors.Control
        Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance46.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.BorderColor = System.Drawing.SystemColors.Window
        Me.ugOrdenAviso.DisplayLayout.Override.GroupByRowAppearance = Appearance46
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderAppearance = Appearance47
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugOrdenAviso.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.ugOrdenAviso.DisplayLayout.Override.RowAppearance = Appearance48
        Me.ugOrdenAviso.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugOrdenAviso.DisplayLayout.Override.TemplateAddRowAppearance = Appearance49
        Me.ugOrdenAviso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugOrdenAviso.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugOrdenAviso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugOrdenAviso.FlatMode = True
        Me.ugOrdenAviso.Location = New System.Drawing.Point(0, 22)
        Me.ugOrdenAviso.Name = "ugOrdenAviso"
        Me.ugOrdenAviso.Size = New System.Drawing.Size(974, 302)
        Me.ugOrdenAviso.TabIndex = 0
        Me.ugOrdenAviso.Text = "UltraGrid1"
        '
        '_pnlOrdenes_Toolbars_Dock_Area_Left
        '
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 22)
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.Name = "_pnlOrdenes_Toolbars_Dock_Area_Left"
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 302)
        Me._pnlOrdenes_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManagerOrdenes
        '
        'UltraToolbarsManagerOrdenes
        '
        Me.UltraToolbarsManagerOrdenes.DesignerFlags = 1
        Me.UltraToolbarsManagerOrdenes.DockWithinContainer = Me.pnlOrdenes
        Me.UltraToolbarsManagerOrdenes.FlatMode = True
        Me.UltraToolbarsManagerOrdenes.LockToolbars = True
        Me.UltraToolbarsManagerOrdenes.ShowFullMenusDelay = 500
        UltraToolbar5.DockedColumn = 0
        UltraToolbar5.DockedRow = 0
        UltraToolbar5.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar5.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar5.ShowInToolbarList = False
        UltraToolbar5.Text = "UltraToolbarOrdenes"
        UltraToolbar5.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24})
        Me.UltraToolbarsManagerOrdenes.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar5})
        ButtonTool25.SharedProps.Caption = "Agregar Reprogramados"
        ButtonTool26.SharedProps.Caption = "Agregar Caidos"
        ButtonTool27.SharedProps.Caption = "Agregar Aviso"
        ButtonTool28.SharedProps.Caption = "Agregar Certificados"
        Me.UltraToolbarsManagerOrdenes.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool25, ButtonTool26, ButtonTool27, ButtonTool28})
        '
        '_pnlOrdenes_Toolbars_Dock_Area_Right
        '
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(974, 22)
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.Name = "_pnlOrdenes_Toolbars_Dock_Area_Right"
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 302)
        Me._pnlOrdenes_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManagerOrdenes
        '
        '_pnlOrdenes_Toolbars_Dock_Area_Top
        '
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.Name = "_pnlOrdenes_Toolbars_Dock_Area_Top"
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(974, 22)
        Me._pnlOrdenes_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManagerOrdenes
        '
        '_pnlOrdenes_Toolbars_Dock_Area_Bottom
        '
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 324)
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.Name = "_pnlOrdenes_Toolbars_Dock_Area_Bottom"
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(974, 0)
        Me._pnlOrdenes_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManagerOrdenes
        '
        'frmMacheoAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(974, 699)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.pnlFiltro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMacheoAvisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Macheo de Avisos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlFiltro.ResumeLayout(False)
        Me.pnlFiltro_Fill_Panel.ResumeLayout(False)
        Me.pnlFiltro_Fill_Panel.PerformLayout()
        CType(Me.UltraToolbarsManagerGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlResumen.ResumeLayout(False)
        Me.pnlResumenCertificado.ResumeLayout(False)
        Me.pnlCertificados.ResumeLayout(False)
        CType(Me.ugCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManagerCertificados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResumenNoOrdenado.ResumeLayout(False)
        Me.pnlReprogramados.ResumeLayout(False)
        CType(Me.ugReprogramados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManagerReprogramados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCaidos.ResumeLayout(False)
        Me.pnlCaidos.PerformLayout()
        CType(Me.ugCaidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManagerCaidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrdenes.ResumeLayout(False)
        CType(Me.ugOrdenAviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManagerOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private DatosPresupuesto As DataTable
    Private Ordenes As DataTable
    Private Caidos As DataTable
    Private Reprogramados, OrdenReprogramado As DataTable
    Private Certificados As DataTable
    Private NetoCaidos As SortedList
    Private OrdenesPoint As New Point
    Private ColFinObservacion As Integer
    Private OrdenesCopia As DataTable
    Private DtOAjuste As DataTable

    'AS 2015/03 =======================================================================
    Private bWorker As BackgroundWorker

    Private Enum TipoSeleccion As Integer
        SS = 0
        AC = 1
        RO = 2
        RD = 3
        ACE = 4
    End Enum
#End Region

#Region "Eventos"
    Private Sub frmMacheoAvisos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LimpiarPantalla()
        Call SetearGrilla()
    End Sub

    Private Sub txtPresupuesto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPresupuesto.TextChanged
        Call LimpiarDatosPresupuesto()
        If Not Ordenes Is Nothing AndAlso Ordenes.Rows.Count > 0 Then
            Call LimpiarOrdenes()
        End If
        If Not Caidos Is Nothing AndAlso Caidos.Rows.Count > 0 Then
            Call LimpiarCaidos()
        End If
        If Not Reprogramados Is Nothing AndAlso Reprogramados.Rows.Count > 0 Then
            Call LimpiarReprogramados()
        End If
        If Not Certificados Is Nothing AndAlso Certificados.Rows.Count > 0 Then
            Call LimpiarCertificados()
        End If
    End Sub

    Private Sub btnPresupuesto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPresupuesto.Click
        Dim Presupuesto As String = txtPresupuesto.Text.Trim
        Call LimpiarDatos()
        If Presupuesto = String.Empty OrElse Convert.ToDouble(Presupuesto) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
        Else
            Call CargarOrdenesMacheo(Convert.ToDouble(Presupuesto))
            If ugOrdenAviso.Rows.Count <= 0 AndAlso ugCaidos.Rows.Count <= 0 AndAlso ugReprogramados.Rows.Count <= 0 Then
                Mensaje("No existen registros para el presupuesto ingresado.")
                txtPresupuesto.SelectAll()
                txtPresupuesto.Focus()
            End If
        End If
    End Sub

    Private Sub ugOrdenAviso_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugOrdenAviso.CellChange
        If e.Cell.Row.Cells("Orden").Value <= 0 Then
            Dim Valor As Integer = CType(e.Cell.EditorControlResolved, Infragistics.Win.UltraWinEditors.UltraOptionSet).Value
            If Valor <> TipoSeleccion.RD AndAlso Valor <> TipoSeleccion.ACE Then
                ugOrdenAviso.Rows(e.Cell.Row.ListIndex).Cells("Sel").Value = 0
            End If
        End If
    End Sub

    Private Sub ugOrdenAviso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugOrdenAviso.DoubleClick
        Dim aUIElement As Infragistics.Win.UIElement
        Dim ColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader
        Dim GridRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        aUIElement = ugOrdenAviso.DisplayLayout.UIElement.ElementFromPoint(New Point(OrdenesPoint.X, OrdenesPoint.Y))
        ColumnHeader = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If ColumnHeader Is Nothing Then
            GridRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            If Not GridRow Is Nothing Then
                If GridRow.Cells("Orden").Value <= 0 Then
                    Call AgregarAviso(False, GridRow)
                End If
            End If
        End If
    End Sub

    Private Sub ugOrdenAviso_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ugOrdenAviso.MouseDown
        OrdenesPoint.X = e.X
        OrdenesPoint.Y = e.Y
    End Sub

    Private Sub ugCaidos_AfterPerformAction(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterUltraGridPerformActionEventArgs) Handles ugCaidos.AfterPerformAction
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub

    Private Sub ugCaidos_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ugCaidos.AfterRowInsert
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub

    Private Sub ugCaidos_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugCaidos.ClickCellButton
        Call AgregarObservaciones(e.Cell.Row, "C")
    End Sub

    Private Sub ugReprogramados_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugReprogramados.ClickCellButton
        Call AgregarObservaciones(e.Cell.Row, "R")
    End Sub

    Private Sub ugCertificados_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugCertificados.ClickCellButton
        Call AgregarObservaciones(e.Cell.Row, "F")
    End Sub

    Private Sub UltraToolbarsManagerGeneral_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManagerGeneral.ToolClick
        Select Case e.Tool.Key
            Case "Blanquear"
                Call LimpiarPantalla()
            Case "ReporteControl"
                Call Imprimir(False)
            Case "ReporteFinanzas"
                Call Imprimir(True)
            Case "ExportarControl"
                Call Imprimir(False, True)
            Case "ExportarFinanzas"
                Call Imprimir(True, True)
            Case "Salir"
                Me.Close()
        End Select
    End Sub

    Private Sub UltraToolbarsManagerOrdenes_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManagerOrdenes.ToolClick
        Select Case e.Tool.Key
            Case "Reprogramados"
                Call AgregarReprogramados()
            Case "Caidos"
                Call AgregarCaidos()
            Case "Certificados"
                Call AgregarCertificados()
            Case "Aviso"
                Call AgregarAviso()
        End Select
    End Sub

    Private Sub UltraToolbarsManagerCaidos_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManagerCaidos.ToolClick
        Select Case e.Tool.Key
            Case "Eliminar"
                Call EliminarCaidos()
            Case "AjustarAvisos"
                Call AgregarOrdenAjuste()
        End Select

    End Sub

    Private Sub UltraToolbarsManagerReprogramados_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManagerReprogramados.ToolClick
        Select Case e.Tool.Key
            Case "Eliminar"
                Call EliminarReprogramados()
        End Select
    End Sub

    Private Sub UltraToolbarsManagerCertificados_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManagerCertificados.ToolClick
        Select Case e.Tool.Key
            Case "Eliminar"
                Call EliminarCertificados()
        End Select
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub LimpiarPantalla()
        txtPresupuesto.Text = String.Empty
        Call LimpiarDatos()
    End Sub

    Private Sub LimpiarDatos()
        Call LimpiarDatosPresupuesto()
        Call LimpiarOrdenes()
        Call LimpiarCaidos()
        Call LimpiarReprogramados()
        Call LimpiarCertificados()
    End Sub

    Private Sub LimpiarDatosPresupuesto()
        DatosPresupuesto = Nothing
    End Sub

    Private Sub LimpiarOrdenes()
        If Ordenes Is Nothing Then
            Call SetearOrdenes()
        End If
        Ordenes.Rows.Clear()
        ugOrdenAviso.DataSource = Ordenes
        ugOrdenAviso.DataBind()
    End Sub

    Private Sub LimpiarCaidos()
        If Caidos Is Nothing Then
            Call SetearCaidos()
        End If
        Caidos.Rows.Clear()
        ugCaidos.DataSource = Caidos
        ugCaidos.DataBind()
    End Sub

    Private Sub LimpiarReprogramados()
        If Reprogramados Is Nothing Then
            Call SetearReprogramados()
        End If
        Reprogramados.Rows.Clear()
        ugReprogramados.DataSource = Reprogramados
        ugReprogramados.DataBind()
    End Sub

    Private Sub LimpiarCertificados()
        If Certificados Is Nothing Then
            Call SetearCertificados()
        End If
        Certificados.Rows.Clear()
        ugCertificados.DataSource = Certificados
        ugCertificados.DataBind()
    End Sub

    Private Sub SetearOrdenes()
        Ordenes = New DataTable

        Ordenes.Columns.Add("Sel", GetType(Object))
        Ordenes.Columns.Add("Orden", GetType(Double))
        Ordenes.Columns.Add("Cod_Soporte", GetType(Integer))
        Ordenes.Columns.Add("Soporte", GetType(String))
        Ordenes.Columns.Add("Fecha", GetType(DateTime))
        Ordenes.Columns.Add("Hora", GetType(String))
        Ordenes.Columns.Add("Duracion", GetType(String))
        Ordenes.Columns.Add("Programa", GetType(String))
        Ordenes.Columns.Add("Neto", GetType(Double))
        Ordenes.Columns.Add("Material", GetType(String))

    End Sub

    Private Sub SetearCaidos()
        Caidos = New DataTable

        Caidos.Columns.Add("Orden", GetType(Double))
        Caidos.Columns.Add("Cod_Soporte", GetType(Integer))
        Caidos.Columns.Add("Soporte", GetType(String))
        Caidos.Columns.Add("Fecha", GetType(DateTime))
        Caidos.Columns.Add("Hora", GetType(String))
        Caidos.Columns.Add("Duracion", GetType(String))
        Caidos.Columns.Add("Programa", GetType(String))
        Caidos.Columns.Add("Neto", GetType(Double))
        Caidos.Columns.Add("Observaciones", GetType(String))
        Caidos.Columns.Add("btnObservaciones")

        'AG 26/02/2013 +++++++++++++++++++++++++
        Caidos.Columns.Add("Material", GetType(String))
        '++++++++++++++++++++++++++++++++++++

    End Sub

    Private Sub SetearAjustes()

        'AG 05/03/2013 +++++
        DtOAjuste = New DataTable

        DtOAjuste.Columns.Add("Orden", GetType(Double))
        DtOAjuste.Columns.Add("Cod_Soporte", GetType(Integer))
        DtOAjuste.Columns.Add("Soporte", GetType(String))
        DtOAjuste.Columns.Add("Fecha", GetType(DateTime))
        DtOAjuste.Columns.Add("Hora", GetType(String))
        DtOAjuste.Columns.Add("Duracion", GetType(String))
        DtOAjuste.Columns.Add("Programa", GetType(String))
        DtOAjuste.Columns.Add("Neto", GetType(Double))
        DtOAjuste.Columns.Add("Observaciones", GetType(String))
        DtOAjuste.Columns.Add("Material", GetType(String))

    End Sub

    Private Sub SetearReprogramados()
        Reprogramados = New DataTable

        Reprogramados.Columns.Add("Index", GetType(Integer))
        Reprogramados.Columns.Add("Orden", GetType(Double))
        Reprogramados.Columns.Add("Cod_Soporte", GetType(Integer))
        Reprogramados.Columns.Add("Soporte", GetType(String))
        Reprogramados.Columns.Add("Fecha", GetType(DateTime))
        Reprogramados.Columns.Add("Hora", GetType(String))
        Reprogramados.Columns.Add("Duracion", GetType(String))
        Reprogramados.Columns.Add("Programa", GetType(String))
        Reprogramados.Columns.Add("Neto", GetType(Double))
        Reprogramados.Columns.Add("OrdenDestino", GetType(Double))
        Reprogramados.Columns.Add("Cod_SoporteDestino", GetType(Integer))
        Reprogramados.Columns.Add("SoporteDestino", GetType(String))
        Reprogramados.Columns.Add("FechaDestino", GetType(DateTime))
        Reprogramados.Columns.Add("HoraDestino", GetType(String))
        Reprogramados.Columns.Add("DuracionDestino", GetType(String))
        Reprogramados.Columns.Add("ProgramaDestino", GetType(String))
        Reprogramados.Columns.Add("NetoDestino", GetType(Double))
        Reprogramados.Columns.Add("Observaciones", GetType(String))
        Reprogramados.Columns.Add("btnObservaciones")

    End Sub

    Private Sub SetearCertificados()
        Certificados = New DataTable

        Certificados.Columns.Add("Orden", GetType(Double))
        Certificados.Columns.Add("Cod_Soporte", GetType(Integer))
        Certificados.Columns.Add("Soporte", GetType(String))
        Certificados.Columns.Add("Fecha", GetType(DateTime))
        Certificados.Columns.Add("Hora", GetType(String))
        Certificados.Columns.Add("Duracion", GetType(String))
        Certificados.Columns.Add("Programa", GetType(String))
        Certificados.Columns.Add("Neto", GetType(Double))
        Certificados.Columns.Add("Observaciones", GetType(String))
        Certificados.Columns.Add("btnObservaciones")

    End Sub

    Private Sub SetearGrilla()
        Call SetearGrillaOrdenes()
        Call SetearGrillaCaidos()
        Call SetearGrillaReprogramados()
        Call SetearGrillaCertificados()
    End Sub

    Private Sub SetearGrillaOrdenes()
        Dim Explicacion As New StringBuilder
        Dim Seleccion As New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Seleccion.Items.Add(0, " ")
        Seleccion.Items.Add(1, " ")
        Seleccion.Items.Add(2, " ")
        Seleccion.Items.Add(3, " ")
        Seleccion.Items.Add(4, " ")

        Explicacion.Append("SS - Sin Selección")
        Explicacion.Append(vbCrLf)
        Explicacion.Append("AC - Aviso Caido")
        Explicacion.Append(vbCrLf)
        Explicacion.Append("RO - Reprogramación Origen")
        Explicacion.Append(vbCrLf)
        Explicacion.Append("RD - Reprogramación Destino")
        Explicacion.Append(vbCrLf)
        Explicacion.Append("ACE - Aviso Certificado")

        With ugOrdenAviso.DisplayLayout.Bands(0)
            .Columns("Cod_Soporte").Hidden = True
            .Columns("Sel").Header.Caption = "SS  AC  RO  RD  ACE"
            .Columns("Duracion").Header.Caption = "Duración"
            .Columns("Sel").Width = 130
            .Columns("Soporte").Width = 200
            .Columns("Hora").Width = 50
            .Columns("Duracion").Width = 60
            .Columns("Programa").Width = 320
            .Columns("Neto").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("Neto").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("Orden").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("Sel").EditorControl = Seleccion
            .Columns("Orden").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Soporte").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Fecha").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Hora").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Duracion").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Programa").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Neto").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Sel").Header.ToolTipText = Explicacion.ToString
            .Columns("Sel").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Orden").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Soporte").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Fecha").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Hora").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Duracion").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Programa").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled
            .Columns("Neto").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending '.Disabled

            .Columns("Orden").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

            'JJP Columna Material
            .Columns("Material").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("Material").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        End With

        ugOrdenAviso.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Soporte").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Fecha").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Hora").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Duracion").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Programa").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        ugOrdenAviso.DisplayLayout.Bands(0).Columns("Neto").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

        ugOrdenAviso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
    End Sub

    Private Sub SetearGrillaCaidos()
        With ugCaidos.DisplayLayout.Bands(0)
            .Columns("Cod_Soporte").Hidden = True
            .Columns("Duracion").Header.Caption = "Duración"
            .Columns("Soporte").Width = 200
            .Columns("Hora").Width = 50
            .Columns("Duracion").Width = 60
            .Columns("Programa").Width = 300
            .Columns("Observaciones").Width = 300
            .Columns("Neto").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("Neto").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("Orden").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("Orden").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Observaciones").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Orden").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Soporte").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Fecha").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Hora").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Duracion").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Programa").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Ascending
            .Columns("Observaciones").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Neto").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Fecha").CellActivation = Activation.NoEdit

            .Columns("btnObservaciones").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("btnObservaciones").Style = ColumnStyle.Button
            .Columns("btnObservaciones").Header.Caption = String.Empty
            .Columns("btnObservaciones").Width = 10
        End With
        ugCaidos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True
        ugCaidos.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        ugCaidos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    End Sub

    Private Sub SetearGrillaReprogramados()
        With ugReprogramados.DisplayLayout.Bands(0)
            .Columns("Cod_Soporte").Hidden = True
            .Columns("Duracion").Header.Caption = "Duración"
            .Columns("Index").Hidden = True
            .Columns("Soporte").Width = 200
            .Columns("Hora").Width = 50
            .Columns("Duracion").Width = 60
            .Columns("Programa").Width = 300
            .Columns("Observaciones").Width = 300
            .Columns("Neto").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("Neto").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("Orden").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("Orden").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Observaciones").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Orden").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Soporte").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Fecha").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Hora").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Duracion").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Programa").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Observaciones").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Neto").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Fecha").CellActivation = Activation.NoEdit

            .Columns("Cod_SoporteDestino").Hidden = True
            .Columns("OrdenDestino").Header.Caption = "Orden Destino"
            .Columns("SoporteDestino").Header.Caption = "Soporte Destino"
            .Columns("FechaDestino").Header.Caption = "Fecha Destino"
            .Columns("HoraDestino").Header.Caption = "Hora Destino"
            .Columns("DuracionDestino").Header.Caption = "Duración Destino"
            .Columns("ProgramaDestino").Header.Caption = "Programa Destino"
            .Columns("NetoDestino").Header.Caption = "Neto Destino"
            .Columns("SoporteDestino").Width = 200
            .Columns("HoraDestino").Width = 80
            .Columns("DuracionDestino").Width = 100
            .Columns("ProgramaDestino").Width = 300
            .Columns("NetoDestino").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("NetoDestino").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("OrdenDestino").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FechaDestino").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HoraDestino").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DuracionDestino").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("NetoDestino").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("OrdenDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SoporteDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FechaDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HoraDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DuracionDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ProgramaDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("NetoDestino").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("OrdenDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("SoporteDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("FechaDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("HoraDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("DuracionDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("ProgramaDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("NetoDestino").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("FechaDestino").CellActivation = Activation.NoEdit

            .Columns("btnObservaciones").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("btnObservaciones").Style = ColumnStyle.Button
            .Columns("btnObservaciones").Header.Caption = String.Empty
            .Columns("btnObservaciones").Width = 10
        End With

        ugReprogramados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True
        ugReprogramados.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        ugReprogramados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    End Sub

    Private Sub SetearGrillaCertificados()
        With ugCertificados.DisplayLayout.Bands(0)
            .Columns("Cod_Soporte").Hidden = True
            .Columns("Duracion").Header.Caption = "Duración"
            .Columns("Soporte").Width = 200
            .Columns("Hora").Width = 50
            .Columns("Duracion").Width = 60
            .Columns("Programa").Width = 300
            .Columns("Observaciones").Width = 300
            .Columns("Neto").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("Neto").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("Orden").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("Orden").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Observaciones").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Orden").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Soporte").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Fecha").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Hora").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Duracion").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Programa").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Observaciones").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Neto").SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
            .Columns("Fecha").CellActivation = Activation.NoEdit

            .Columns("btnObservaciones").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("btnObservaciones").Style = ColumnStyle.Button
            .Columns("btnObservaciones").Header.Caption = String.Empty
            .Columns("btnObservaciones").Width = 10
        End With
        ugCertificados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.True
        ugCertificados.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        ugCertificados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
    End Sub

    Private Sub CargarOrdenesMacheo(ByVal pPresupuesto As Double)
        Dim Control As New Control_Macheo
        Dim OrdenesMacheo As DataTable
        Dim OrdenesMatcheo As New Dictionary(Of String, List(Of OrdenMatcheo))
        Dim lOrdenesMatcheo As New List(Of OrdenMatcheo)
        Dim Orden As DataRow
        Dim AvisosNoConfirmados As DataSet
        Dim AvisoCaido, AvisoReprogramado, AvisoCertificado As DataRow
        OrdenReprogramado = Reprogramados.Clone
        Dim mOrden As New OrdenMatcheo
        DatosPresupuesto = Control.BuscarPresupuesto_Id(pPresupuesto)

        Control.Cod_Presupuesto = pPresupuesto
        OrdenesMatcheo = Control.BuscarOrdenesMacheo()

        If OrdenesMatcheo.Item(OrdenesMatcheo.Keys(0)).Count > 0 AndAlso String.IsNullOrEmpty(OrdenesMatcheo.Keys(0)) Then
            lOrdenesMatcheo = OrdenesMatcheo.Item(OrdenesMatcheo.Keys(0))
            For index As Integer = 0 To lOrdenesMatcheo.Count - 1
                mOrden = lOrdenesMatcheo.Item(index)
                Orden = Ordenes.NewRow

                Orden("Sel") = 0
                Orden("Orden") = mOrden.CodigoOrden
                Orden("Cod_Soporte") = mOrden.CodigoSoporte
                Orden("Soporte") = mOrden.DescripcionSoporte
                Orden("Fecha") = mOrden.fechaEjecucion
                Orden("Hora") = ObtenerHora(mOrden.Hora, mOrden.Minuto)
                Orden("Duracion") = mOrden.Duracion
                Orden("Programa") = mOrden.Programa
                Orden("Neto") = mOrden.Neto
                Orden("Material") = mOrden.DescripcionMaterial

                Ordenes.Rows.Add(Orden)
            Next

            ugOrdenAviso.DataSource = Ordenes
            ugOrdenAviso.DataBind()
        Else
            Mensaje(OrdenesMatcheo.Keys(0))
        End If

        AvisosNoConfirmados = ObtenerAvisosNoConfirmados(pPresupuesto)
        If Not AvisosNoConfirmados Is Nothing AndAlso Not AvisosNoConfirmados.Tables(0) Is Nothing AndAlso AvisosNoConfirmados.Tables(0).Rows.Count > 0 Then
            For Each AvisosCaidos As DataRow In AvisosNoConfirmados.Tables(0).Select("Cod_Estado = 'C'")
                AvisoCaido = Caidos.NewRow

                AvisoCaido("Orden") = AvisosCaidos("Orden_Origen")
                AvisoCaido("Cod_Soporte") = AvisosCaidos("Cod_Soporte_Origen")
                AvisoCaido("Soporte") = AvisosCaidos("Soporte_Origen")
                AvisoCaido("Fecha") = AvisosCaidos("Fecha_Origen")
                AvisoCaido("Hora") = ObtenerHora(AvisosCaidos("Hora_Origen"), AvisosCaidos("Minuto_Origen"))
                AvisoCaido("Duracion") = AvisosCaidos("Duracion_Origen")
                AvisoCaido("Programa") = AvisosCaidos("Programa_Origen")
                AvisoCaido("Neto") = AvisosCaidos("Neto_Origen")
                If Not AvisosCaidos("Observaciones") Is DBNull.Value Then
                    AvisoCaido("Observaciones") = AvisosCaidos("Observaciones")
                Else
                    AvisoCaido("Observaciones") = String.Empty
                End If
                AvisoCaido("material") = AvisosCaidos("material")
                Caidos.Rows.Add(AvisoCaido)
            Next
            For Each AvisosReprogramados As DataRow In AvisosNoConfirmados.Tables(0).Select("Cod_Estado = 'R'")
                AvisoReprogramado = OrdenReprogramado.NewRow

                AvisoReprogramado("Index") = ObtenerIndiceReprogramado(AvisosReprogramados("Orden_Origen"), AvisosReprogramados("Orden_Destino"))
                AvisoReprogramado("Orden") = AvisosReprogramados("Orden_Origen")
                AvisoReprogramado("Cod_Soporte") = AvisosReprogramados("Cod_Soporte_Origen")
                AvisoReprogramado("Soporte") = AvisosReprogramados("Soporte_Origen")
                AvisoReprogramado("Fecha") = AvisosReprogramados("Fecha_Origen")
                AvisoReprogramado("Hora") = ObtenerHora(AvisosReprogramados("Hora_Origen"), AvisosReprogramados("Minuto_Origen"))
                AvisoReprogramado("Duracion") = AvisosReprogramados("Duracion_Origen")
                AvisoReprogramado("Programa") = AvisosReprogramados("Programa_Origen")
                AvisoReprogramado("Neto") = AvisosReprogramados("Neto_Origen")
                If Not AvisosReprogramados("Observaciones") Is DBNull.Value Then
                    AvisoReprogramado("Observaciones") = AvisosReprogramados("Observaciones")
                Else
                    AvisoReprogramado("Observaciones") = String.Empty
                End If

                AvisoReprogramado("OrdenDestino") = AvisosReprogramados("Orden_Destino")
                AvisoReprogramado("Cod_SoporteDestino") = AvisosReprogramados("Cod_Soporte_Destino")
                AvisoReprogramado("SoporteDestino") = AvisosReprogramados("Soporte_Destino")
                AvisoReprogramado("FechaDestino") = AvisosReprogramados("Fecha_Destino")
                AvisoReprogramado("HoraDestino") = ObtenerHora(AvisosReprogramados("Hora_Destino"), AvisosReprogramados("Minuto_Destino"))
                AvisoReprogramado("DuracionDestino") = AvisosReprogramados("Duracion_Destino")
                AvisoReprogramado("ProgramaDestino") = AvisosReprogramados("Programa_Destino")
                AvisoReprogramado("NetoDestino") = AvisosReprogramados("Neto_Destino")

                OrdenReprogramado.Rows.Add(AvisoReprogramado)
            Next
            For Each OrdenRep As DataRow In OrdenReprogramado.Select("", "Index")
                Reprogramados.ImportRow(OrdenRep)
            Next
            Call SetearRowsReprogramados()
            For Each Rep As UltraGridRow In ugReprogramados.Rows
                If Rep.Cells("OrdenDestino").Value <= 0 Then
                    Rep.Cells("OrdenDestino").Hidden = True
                End If
            Next
            For Each AvisosCertificados As DataRow In AvisosNoConfirmados.Tables(0).Select("Cod_Estado = 'F'")
                AvisoCertificado = Certificados.NewRow

                AvisoCertificado("Orden") = AvisosCertificados("Orden_Origen")
                AvisoCertificado("Cod_Soporte") = AvisosCertificados("Cod_Soporte_Origen")
                AvisoCertificado("Soporte") = AvisosCertificados("Soporte_Origen")
                AvisoCertificado("Fecha") = AvisosCertificados("Fecha_Origen")
                AvisoCertificado("Hora") = ObtenerHora(AvisosCertificados("Hora_Origen"), AvisosCertificados("Minuto_Origen"))
                AvisoCertificado("Duracion") = AvisosCertificados("Duracion_Origen")
                AvisoCertificado("Programa") = AvisosCertificados("Programa_Origen")
                AvisoCertificado("Neto") = AvisosCertificados("Neto_Origen")
                If Not AvisosCertificados("Observaciones") Is DBNull.Value Then
                    AvisoCertificado("Observaciones") = AvisosCertificados("Observaciones")
                Else
                    AvisoCertificado("Observaciones") = String.Empty
                End If

                Certificados.Rows.Add(AvisoCertificado)
            Next
            For Each Certificado As UltraGridRow In ugCertificados.Rows
                If Certificado.Cells("Orden").Value <= 0 Then
                    Certificado.Cells("Orden").Hidden = True
                End If
            Next
        End If
        If Caidos.Rows.Count > 0 Then
            lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
            ugCaidos.ActiveRow = ugCaidos.Rows(0)
            ugCaidos.Rows(0).Selected = True
        End If
        If Reprogramados.Rows.Count > 0 Then
            ugReprogramados.ActiveRow = ugReprogramados.Rows(0)
            ugReprogramados.Rows(0).Selected = True
        End If
        If Certificados.Rows.Count > 0 Then
            ugCertificados.ActiveRow = ugCertificados.Rows(0)
            ugCertificados.Rows(0).Selected = True
        End If
    End Sub

    Private Sub AgregarCaidos()
        Dim AvisoCaido As DataRow
        Dim CantidadCaidos As Integer
        Dim Presupuesto, CodOrigen As Double
        Dim Presu As String = txtPresupuesto.Text.Trim
        Dim Control As New Control_Macheo
        Dim Filtro As StringBuilder
        Dim lAvisosNoConfirmados As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado

        If Presu = String.Empty OrElse Convert.ToDouble(Presu) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
            Exit Sub
        End If

        txtPresupuesto.Focus()
        Presupuesto = txtPresupuesto.Text.Trim
        For IndexOrden As Integer = ugOrdenAviso.Rows.Count - 1 To 0 Step -1
            If ugOrdenAviso.Rows(IndexOrden).Cells(0).Value = TipoSeleccion.AC Then
                avisoNC = New AvisoNoConfirmado

                CodOrigen = ugOrdenAviso.Rows(IndexOrden).Cells("Orden").Value

                avisoNC = New AvisoNoConfirmado
                avisoNC.CodigoPresupuesto = Presupuesto
                avisoNC.OrdenOrigen = New OrdenMatcheo
                avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                avisoNC.OrdenDestino = New OrdenMatcheo
                avisoNC.OrdenDestino.CodigoOrden = Nothing
                avisoNC.CodigoEstado = "C"
                lAvisosNoConfirmados.Add(avisoNC)

                'Control.AgregarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing, "C")

                CantidadCaidos += 1
                AvisoCaido = Caidos.NewRow

                AvisoCaido("Orden") = ugOrdenAviso.Rows(IndexOrden).Cells("Orden").Value
                AvisoCaido("Cod_Soporte") = ugOrdenAviso.Rows(IndexOrden).Cells("Cod_Soporte").Value
                AvisoCaido("Soporte") = ugOrdenAviso.Rows(IndexOrden).Cells("Soporte").Value
                AvisoCaido("Fecha") = ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value
                AvisoCaido("Hora") = ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value
                AvisoCaido("Duracion") = ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value
                AvisoCaido("Programa") = ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value
                AvisoCaido("Neto") = ugOrdenAviso.Rows(IndexOrden).Cells("Neto").Value
                'AG 26/02/2013 ++++++++++++++++
                AvisoCaido("Material") = ugOrdenAviso.Rows(IndexOrden).Cells("Material").Value
                '+++++++++++++++++++++++++++

                Filtro = New StringBuilder
                Filtro.Append("Soporte = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Soporte").Value)
                Filtro.Append("' and Fecha = '")
                Filtro.Append(Convert.ToDateTime(ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value).Date.ToString("dd/MM/yyyy"))
                Filtro.Append("' and Hora = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value)
                Filtro.Append("' and Duracion = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value)
                Filtro.Append("' and Programa = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value)
                Filtro.Append("'")
                AvisoCaido("Observaciones") = String.Empty
                For Each RowCaido As DataRow In Caidos.Select(Filtro.ToString)
                    AvisoCaido("Observaciones") = RowCaido("Observaciones")
                    Exit For
                Next

                Caidos.Rows.Add(AvisoCaido)
                ugOrdenAviso.Rows(IndexOrden).Delete(False)
            End If
        Next

        If lAvisosNoConfirmados.Count > 0 Then
            Dim resultado As String
            resultado = Control.InsertarAvisosNoConfirmados(lAvisosNoConfirmados)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
                Exit Sub
            End If
        End If

        If Caidos.Rows.Count > 0 Then
            lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
            ugCaidos.ActiveRow = ugCaidos.Rows(0)
            ugCaidos.Rows(0).Selected = True
        End If

        If CantidadCaidos = 0 Then
            MessageBox.Show("Debe seleccionar al menos un aviso caido (AC).")
        End If
    End Sub

    Private Function AgregarOrdenAjuste()
        'LC 02/07/2014 Restriccion de envio de ajustes de pautas planificadas
        For Each presupuesto As DataRow In DatosPresupuesto.Rows
            If presupuesto("Tipo") = "Planificado" Then
                Mensaje("Presupuesto de tipo Planificado, los ajustes a este presupuesto deben hacerse desde MMS.")
            Else
                If ugCaidos.Selected.Rows.Count <= 0 Then
                    Mensaje("No existen Ordenes, para realizar ajustes.")
                    Exit Function
                End If
            End If
        Next

        Dim Envio As New Envio_Compras
        Dim EstaBloqueado As Boolean = False

        EstaBloqueado = Envio.ObtenerEstadoBloqueadoPresupuesto(Activo.IDCompaniaMMS, Me.txtPresupuesto.Text)
        If EstaBloqueado Then
            Mensaje("El presupuesto no puede ajustarse debido a que esta bloqueado.")
            Exit Function
        End If

        If Caidos.Rows.Count > 0 Then
            Dim OfrmAvisosAjuste As New frmAvisosAjuste
            OfrmAvisosAjuste.mDtAjustarAvisos = Caidos
            OfrmAvisosAjuste.mNroPresupuesto = Me.txtPresupuesto.Text
            OfrmAvisosAjuste.ShowDialog()
        End If

    End Function

    Private Sub AgregarReprogramados()
        Dim AvisoReprogramado As DataRow
        Dim RepOrigen As New SortedList
        Dim RepDestino As New SortedList
        Dim OrdenOrigen, OrdenDestino As UltraGridRow
        Dim Filtro As StringBuilder
        Dim Index As Integer
        Dim Presupuesto, CodOrigen, CodDestino, Neto As Double
        Dim Control As New Control_Macheo
        Dim Presu As String = txtPresupuesto.Text.Trim
        Dim Cod_Medio, Cod_Soporte, Duracion As Integer
        Dim Fecha As DateTime
        Dim Hora, Programa As String
        Dim lAvisoManual As New List(Of AvisoConfirmado)
        Dim lAvisoNoConfirmado As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado
        Dim avisoM As AvisoConfirmado

        If Presu = String.Empty OrElse Convert.ToDouble(Presu) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
            Exit Sub
        End If

        txtPresupuesto.Focus()
        Presupuesto = txtPresupuesto.Text.Trim

        For Each Orden As UltraGridRow In ugOrdenAviso.Rows
            If Orden.Cells(0).Value = TipoSeleccion.RO Then
                RepOrigen.Add(Orden.Cells(1).Value, Orden)
            End If
            If Orden.Cells(0).Value = TipoSeleccion.RD Then
                RepDestino.Add(Orden.Cells(1).Value, Orden)
            End If
        Next
        If RepOrigen.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos un aviso de origen (RO).")
            Exit Sub
        End If
        If RepDestino.Count = 0 Then
            MessageBox.Show("Debe selecionar al menos un aviso de destino (RD).")
            Exit Sub
        End If
        If Reprogramados Is Nothing OrElse Reprogramados.Rows.Count = 0 Then
            Index = 0
        Else
            Index = Convert.ToInt32(Reprogramados.Rows(Reprogramados.Rows.Count - 1).Item("Index")) + 1
        End If
        For IndexOrigen As Integer = 0 To RepOrigen.Count - 1
            For IndexDestino As Integer = 0 To RepDestino.Count - 1

                AvisoReprogramado = Reprogramados.NewRow
                OrdenOrigen = RepOrigen(RepOrigen.GetKey(IndexOrigen))
                OrdenDestino = RepDestino(RepDestino.GetKey(IndexDestino))

                CodOrigen = OrdenOrigen.Cells("Orden").Value
                CodDestino = OrdenDestino.Cells("Orden").Value

                avisoNC = New AvisoNoConfirmado
                avisoNC.CodigoPresupuesto = Presupuesto
                avisoNC.OrdenOrigen = New OrdenMatcheo
                avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                avisoNC.OrdenDestino = New OrdenMatcheo
                avisoNC.OrdenDestino.CodigoOrden = CodDestino
                avisoNC.CodigoEstado = "R"
                lAvisoNoConfirmado.Add(avisoNC)

                'Control.AgregarAvisosNoConfirmados(Presupuesto, CodOrigen, CodDestino, "R")

                If CodDestino <= 0 Then
                    avisoM = New AvisoConfirmado

                    If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
                        avisoM.CodigoMedio = DatosPresupuesto.Rows(0)("Medio")
                    End If
                    avisoM.CodigoSoporte = OrdenDestino.Cells("Cod_Soporte").Value
                    avisoM.fechaEjecucion = OrdenDestino.Cells("Fecha").Value
                    avisoM.Hora = OrdenDestino.Cells("Hora").Value
                    avisoM.Programa = OrdenDestino.Cells("Programa").Value
                    avisoM.Duracion = OrdenDestino.Cells("Duracion").Value
                    avisoM.Neto = Decimal.Parse(OrdenDestino.Cells("Neto").Value.ToString)

                    'If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
                    '    Cod_Medio = DatosPresupuesto.Rows(0)("Medio")
                    'End If
                    'Cod_Soporte = OrdenDestino.Cells("Cod_Soporte").Value
                    'Fecha = OrdenDestino.Cells("Fecha").Value
                    'Hora = OrdenDestino.Cells("Hora").Value
                    'Programa = OrdenDestino.Cells("Programa").Value
                    'Duracion = OrdenDestino.Cells("Duracion").Value
                    'Neto = OrdenDestino.Cells("Neto").Value

                    lAvisoManual.Add(avisoM)
                    'Control.AgregarAvisosManuales(Presupuesto, CodDestino, Cod_Medio, Cod_Soporte, Fecha, Hora, Programa, Duracion, Neto)
                End If

                AvisoReprogramado("Index") = Index
                AvisoReprogramado("Orden") = OrdenOrigen.Cells("Orden").Value
                AvisoReprogramado("Cod_Soporte") = OrdenOrigen.Cells("Cod_Soporte").Value
                AvisoReprogramado("Soporte") = OrdenOrigen.Cells("Soporte").Value
                AvisoReprogramado("Fecha") = OrdenOrigen.Cells("Fecha").Value
                AvisoReprogramado("Hora") = OrdenOrigen.Cells("Hora").Value
                AvisoReprogramado("Duracion") = OrdenOrigen.Cells("Duracion").Value
                AvisoReprogramado("Programa") = OrdenOrigen.Cells("Programa").Value
                AvisoReprogramado("Neto") = OrdenOrigen.Cells("Neto").Value
                AvisoReprogramado("Observaciones") = String.Empty

                AvisoReprogramado("OrdenDestino") = OrdenDestino.Cells("Orden").Value
                AvisoReprogramado("Cod_SoporteDestino") = OrdenDestino.Cells("Cod_Soporte").Value
                AvisoReprogramado("SoporteDestino") = OrdenDestino.Cells("Soporte").Value
                AvisoReprogramado("FechaDestino") = OrdenDestino.Cells("Fecha").Value
                AvisoReprogramado("HoraDestino") = OrdenDestino.Cells("Hora").Value
                AvisoReprogramado("DuracionDestino") = OrdenDestino.Cells("Duracion").Value
                AvisoReprogramado("ProgramaDestino") = OrdenDestino.Cells("Programa").Value
                AvisoReprogramado("NetoDestino") = OrdenDestino.Cells("Neto").Value

                Reprogramados.Rows.Add(AvisoReprogramado)
                If OrdenDestino.Cells("Orden").Value <= 0 Then
                    ugReprogramados.Rows(ugReprogramados.Rows.Count - 1).Cells("OrdenDestino").Hidden = True
                End If
            Next
        Next

        If lAvisoNoConfirmado.Count > 0 Then
            Dim resultado As String
            resultado = Control.InsertarAvisosNoConfirmados(lAvisoNoConfirmado)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        If lAvisoManual.Count > 0 Then
            Dim resultado As String
            resultado = Control.InsertarAvisosManuales(lAvisoManual)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        Call EliminarOrden(RepOrigen)
        Call EliminarOrden(RepDestino)
        Call SetearRowsReprogramados()

        If Reprogramados.Rows.Count > 0 Then
            ugReprogramados.ActiveRow = ugReprogramados.Rows(0)
            ugReprogramados.Rows(0).Selected = True
        End If
    End Sub

    Private Sub AgregarCertificados()
        Dim AvisoCertificado As DataRow
        Dim CantidadCertificados As Integer
        Dim Presupuesto, CodOrigen As Double
        Dim Presu As String = txtPresupuesto.Text.Trim
        Dim Control As New Control_Macheo
        Dim Filtro As StringBuilder
        Dim Cod_Medio, Cod_Soporte, Duracion As Integer
        Dim Fecha As DateTime
        Dim Hora, Programa As String
        Dim Neto As Double
        Dim lAvisoManual As New List(Of AvisoConfirmado)
        Dim lAvisoNoConfirmado As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado
        Dim avisoM As AvisoConfirmado

        If Presu = String.Empty OrElse Convert.ToDouble(Presu) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
            Exit Sub
        End If

        txtPresupuesto.Focus()
        Presupuesto = txtPresupuesto.Text.Trim
        For IndexOrden As Integer = ugOrdenAviso.Rows.Count - 1 To 0 Step -1
            If ugOrdenAviso.Rows(IndexOrden).Cells(0).Value = TipoSeleccion.ACE Then

                CodOrigen = ugOrdenAviso.Rows(IndexOrden).Cells("Orden").Value
                avisoNC = New AvisoNoConfirmado
                avisoNC.CodigoPresupuesto = Presupuesto
                avisoNC.OrdenOrigen = New OrdenMatcheo
                avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                avisoNC.OrdenDestino = New OrdenMatcheo
                avisoNC.OrdenDestino.CodigoOrden = Nothing
                avisoNC.CodigoEstado = "F"
                lAvisoNoConfirmado.Add(avisoNC)

                'Control.AgregarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing, "F")

                If CodOrigen <= 0 Then
                    'If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
                    '    Cod_Medio = DatosPresupuesto.Rows(0)("Medio")
                    'End If
                    'Cod_Soporte = ugOrdenAviso.Rows(IndexOrden).Cells("Cod_Soporte").Value
                    'Fecha = ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value
                    'Hora = ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value
                    'Programa = ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value
                    'Duracion = ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value
                    'Neto = ugOrdenAviso.Rows(IndexOrden).Cells("Neto").Value

                    avisoM = New AvisoConfirmado

                    If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
                        avisoM.CodigoMedio = DatosPresupuesto.Rows(0)("Medio")
                    End If
                    avisoM.CodigoSoporte = ugOrdenAviso.Rows(IndexOrden).Cells("Cod_Soporte").Value
                    avisoM.fechaEjecucion = ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value
                    avisoM.Hora = ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value
                    avisoM.Programa = ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value
                    avisoM.Duracion = ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value
                    avisoM.Neto = Decimal.Parse(ugOrdenAviso.Rows(IndexOrden).Cells("Neto").Value.ToString())

                    lAvisoManual.Add(avisoM)

                    'Control.AgregarAvisosManuales(Presupuesto, CodOrigen, Cod_Medio, Cod_Soporte, Fecha, Hora, Programa, Duracion, Neto)
                End If

                CantidadCertificados += 1
                AvisoCertificado = Certificados.NewRow

                AvisoCertificado("Orden") = ugOrdenAviso.Rows(IndexOrden).Cells("Orden").Value
                AvisoCertificado("Cod_Soporte") = ugOrdenAviso.Rows(IndexOrden).Cells("Cod_Soporte").Value
                AvisoCertificado("Soporte") = ugOrdenAviso.Rows(IndexOrden).Cells("Soporte").Value
                AvisoCertificado("Fecha") = ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value
                AvisoCertificado("Hora") = ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value
                AvisoCertificado("Duracion") = ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value
                AvisoCertificado("Programa") = ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value
                AvisoCertificado("Neto") = ugOrdenAviso.Rows(IndexOrden).Cells("Neto").Value

                Filtro = New StringBuilder
                Filtro.Append("Soporte = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Soporte").Value)
                Filtro.Append("' and Fecha = '")
                Filtro.Append(Convert.ToDateTime(ugOrdenAviso.Rows(IndexOrden).Cells("Fecha").Value).Date.ToString("dd/MM/yyyy"))
                Filtro.Append("' and Hora = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Hora").Value)
                Filtro.Append("' and Duracion = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Duracion").Value)
                Filtro.Append("' and Programa = '")
                Filtro.Append(ugOrdenAviso.Rows(IndexOrden).Cells("Programa").Value)
                Filtro.Append("'")
                AvisoCertificado("Observaciones") = String.Empty
                For Each RowCertificado As DataRow In Certificados.Select(Filtro.ToString)
                    AvisoCertificado("Observaciones") = RowCertificado("Observaciones")
                    Exit For
                Next

                Certificados.Rows.Add(AvisoCertificado)
                If ugOrdenAviso.Rows(IndexOrden).Cells("Orden").Value <= 0 Then
                    ugCertificados.Rows(ugCertificados.Rows.Count - 1).Cells("Orden").Hidden = True
                End If

                ugOrdenAviso.Rows(IndexOrden).Delete(False)
            End If
        Next

        If lAvisoNoConfirmado.Count > 0 Then
            Dim resultado As String
            resultado = Control.InsertarAvisosNoConfirmados(lAvisoNoConfirmado)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        If lAvisoManual.Count > 0 Then
            Dim resultado As String
            resultado = Control.InsertarAvisosManuales(lAvisoManual)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        If Certificados.Rows.Count > 0 Then
            ugCertificados.ActiveRow = ugCertificados.Rows(0)
            ugCertificados.Rows(0).Selected = True
        End If
        If CantidadCertificados = 0 Then
            MessageBox.Show("Debe seleccionar al menos un aviso certificado (ACE).")
        End If
    End Sub

    Private Sub AgregarAviso(Optional ByVal pIsNew As Boolean = True, Optional ByVal pRow As UltraGridRow = Nothing)
        Dim Control As New Control_Macheo
        Dim AvisoNuevo As frmAgregarOrden
        Dim Presu As String = txtPresupuesto.Text.Trim
        Dim NewOrden As DataRow

        If Presu = String.Empty OrElse Convert.ToDouble(Presu) <= 0 Then
            Mensaje("Debe ingresar un Número de Presupuesto.")
            txtPresupuesto.Focus()
            Exit Sub
        End If

        If Ordenes Is Nothing OrElse Ordenes.Rows.Count <= 0 Then
            Mensaje("No existen registros para el presupuesto ingresado.", TipoMensaje.Informacion)
            Exit Sub
        End If

        If DatosPresupuesto Is Nothing Then
            DatosPresupuesto = Control.BuscarPresupuesto_Id(txtPresupuesto.Text.Trim)
        End If

        If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
            AvisoNuevo = New frmAgregarOrden
            AvisoNuevo.Id_Medio = DatosPresupuesto.Rows(0)("Medio")
            AvisoNuevo.Orden = ObtenerNroOrdenNuevo()
            If Not pIsNew Then
                AvisoNuevo.PopularDatos(pRow.Cells("Cod_Soporte").Value, pRow.Cells("Programa").Value, pRow.Cells("Hora").Value, pRow.Cells("Duracion").Value, pRow.Cells("Fecha").Value, pRow.Cells("Neto").Value)
            End If
            AvisoNuevo.ShowDialog()
            If AvisoNuevo.Aceptar Then
                If pIsNew Then
                    NewOrden = Ordenes.NewRow

                    NewOrden("Sel") = 0
                    NewOrden("Orden") = AvisoNuevo.Orden
                    NewOrden("Cod_Soporte") = AvisoNuevo.Cod_Soporte
                    NewOrden("Soporte") = AvisoNuevo.Soporte
                    NewOrden("Fecha") = AvisoNuevo.Fecha
                    NewOrden("Hora") = AvisoNuevo.Hora
                    NewOrden("Duracion") = AvisoNuevo.Duracion
                    NewOrden("Programa") = AvisoNuevo.Programa
                    NewOrden("Neto") = AvisoNuevo.Neto

                    Ordenes.Rows.Add(NewOrden)
                    ugOrdenAviso.Rows(ugOrdenAviso.Rows.Count - 1).Cells("Orden").Hidden = True
                Else
                    pRow.Cells("Sel").Value = 0
                    pRow.Cells("Orden").Value = AvisoNuevo.Orden
                    pRow.Cells("Cod_Soporte").Value = AvisoNuevo.Cod_Soporte
                    pRow.Cells("Soporte").Value = AvisoNuevo.Soporte
                    pRow.Cells("Fecha").Value = AvisoNuevo.Fecha
                    pRow.Cells("Hora").Value = AvisoNuevo.Hora
                    pRow.Cells("Duracion").Value = AvisoNuevo.Duracion
                    pRow.Cells("Programa").Value = AvisoNuevo.Programa
                    pRow.Cells("Neto").Value = AvisoNuevo.Neto
                End If

            End If
        End If
    End Sub

    Private Sub AgregarObservaciones(ByVal pRow As UltraGridRow, ByVal pEstado As String)
        Dim Control As New Control_Macheo
        Dim Filtro As New StringBuilder
        Dim Presupuesto, CodOrigen, CodDestino As Double
        Dim Indice As Integer
        Dim Observacion As New frmAgregarObservacion
        Dim Observaciones As String = pRow.Cells("Observaciones").Value
        Dim lAvisoNoConfirmado As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado

        Observacion.Observaciones = Observaciones
        Observacion.ShowDialog()
        If Observaciones <> Observacion.Observaciones Then
            Observaciones = Observacion.Observaciones
            Control = New Control_Macheo
            Presupuesto = txtPresupuesto.Text.Trim

            If pEstado <> "R" Then
                Filtro.Append("Soporte = '")
                Filtro.Append(pRow.Cells("Soporte").Value)
                Filtro.Append("' and Fecha = '")
                Filtro.Append(Convert.ToDateTime(pRow.Cells("Fecha").Value).Date.ToString("dd/MM/yyyy"))
                Filtro.Append("' and Hora = '")
                Filtro.Append(pRow.Cells("Hora").Value)
                Filtro.Append("' and Duracion = '")
                Filtro.Append(pRow.Cells("Duracion").Value)
                Filtro.Append("' and Programa = '")
                Filtro.Append(pRow.Cells("Programa").Value)
                Filtro.Append("'")
                '****************************************************************************
                'AGREGADO JJP 25/01/2008 - Agregaba la misma observación en mas de una orden.
                'Ver si se puede subir a Producción
                Filtro.Append(" and Orden ='")
                Filtro.Append(pRow.Cells("Orden").Value)
                Filtro.Append("'")
                '****************************************************************************
                If pEstado = "C" Then
                    For Each RowCaido As DataRow In Caidos.Select(Filtro.ToString)
                        RowCaido("Observaciones") = Observaciones
                        CodOrigen = RowCaido("Orden")

                        avisoNC = New AvisoNoConfirmado
                        avisoNC.CodigoPresupuesto = Presupuesto
                        avisoNC.OrdenOrigen = New OrdenMatcheo
                        avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                        avisoNC.OrdenDestino = New OrdenMatcheo
                        avisoNC.OrdenDestino.CodigoOrden = Nothing
                        avisoNC.Observaciones = Observaciones
                        lAvisoNoConfirmado.Add(avisoNC)

                        'Control.ActualizarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing, Observaciones)
                    Next
                Else

                    For Each RowCertificado As DataRow In Certificados.Select(Filtro.ToString)
                        RowCertificado("Observaciones") = Observaciones
                        CodOrigen = RowCertificado("Orden")

                        avisoNC = New AvisoNoConfirmado
                        avisoNC.CodigoPresupuesto = Presupuesto
                        avisoNC.OrdenOrigen = New OrdenMatcheo
                        avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                        avisoNC.OrdenDestino = New OrdenMatcheo
                        avisoNC.OrdenDestino.CodigoOrden = Nothing
                        avisoNC.Observaciones = Observaciones
                        lAvisoNoConfirmado.Add(avisoNC)

                        Control.ActualizarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing, Observaciones)
                    Next
                End If
            Else
                Indice = pRow.Cells("Index").Value
                For Each Repro As DataRow In Reprogramados.Select("Index = " & Indice)
                    Repro("Observaciones") = Observaciones
                    CodOrigen = Repro("Orden")
                    CodDestino = Repro("OrdenDestino")

                    avisoNC = New AvisoNoConfirmado
                    avisoNC.CodigoPresupuesto = Presupuesto
                    avisoNC.OrdenOrigen = New OrdenMatcheo
                    avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                    avisoNC.OrdenDestino = New OrdenMatcheo
                    avisoNC.OrdenDestino.CodigoOrden = CodDestino
                    avisoNC.Observaciones = Observaciones
                    lAvisoNoConfirmado.Add(avisoNC)

                    'Control.ActualizarAvisosNoConfirmados(Presupuesto, CodOrigen, CodDestino, Observaciones)
                Next
            End If
        End If

        If lAvisoNoConfirmado.Count > 0 Then
            Dim resultado As String
            resultado = Control.ActualizarAvisosNoConfirmados(lAvisoNoConfirmado)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
                Exit Sub
            End If
        End If

    End Sub

    Private Sub EliminarOrden(ByVal pOrdenesSeleccionadas As SortedList)
        Dim Filtro As New StringBuilder
        Filtro.Append("Orden IN (")
        For IndexOrigen As Integer = 0 To pOrdenesSeleccionadas.Count - 1
            Filtro.Append(pOrdenesSeleccionadas.GetKey(IndexOrigen))
            If IndexOrigen < pOrdenesSeleccionadas.Count - 1 Then
                Filtro.Append(",")
            End If
        Next
        Filtro.Append(")")
        For Each Orden As DataRow In Ordenes.Select(Filtro.ToString, "Orden desc")
            Orden.Delete()
        Next
    End Sub

    Private Sub EliminarCaidos()
        Dim Orden As DataRow
        Dim CantidadSeleccionados As Integer
        Dim Seleccionados As New SortedList
        Dim Presupuesto, CodOrigen As Double
        Dim Control As New Control_Macheo
        Dim lAvisoNoConfirmado As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado

        If ugCaidos.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a eliminar.")
            Exit Sub
        End If

        For Each AvisoCaido As UltraGridRow In ugCaidos.Selected.Rows
            Orden = Ordenes.NewRow

            Orden("Sel") = 0
            Orden("Orden") = AvisoCaido.Cells("Orden").Value
            Orden("Cod_Soporte") = AvisoCaido.Cells("Cod_Soporte").Value
            Orden("Soporte") = AvisoCaido.Cells("Soporte").Value
            Orden("Fecha") = AvisoCaido.Cells("Fecha").Value
            Orden("Hora") = AvisoCaido.Cells("Hora").Value
            Orden("Duracion") = AvisoCaido.Cells("Duracion").Value
            Orden("Programa") = AvisoCaido.Cells("Programa").Value
            Orden("Neto") = AvisoCaido.Cells("Neto").Value

            'AG 26/02/2013 ++++++++++++++++++++++
            Orden("Material") = AvisoCaido.Cells("Material").Value
            '+++++++++++++++++++++++++++++++++

            Ordenes.Rows.Add(Orden)
            If Not Seleccionados.ContainsKey(AvisoCaido.Index) Then
                Seleccionados.Add(AvisoCaido.Index, AvisoCaido.Index)
            End If
        Next

        Presupuesto = txtPresupuesto.Text.Trim
        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            CodOrigen = ugCaidos.Rows(Seleccionados.GetKey(Index)).Cells("Orden").Value

            avisoNC = New AvisoNoConfirmado
            avisoNC.CodigoPresupuesto = Presupuesto
            avisoNC.OrdenOrigen = New OrdenMatcheo
            avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
            avisoNC.OrdenDestino = New OrdenMatcheo
            avisoNC.OrdenDestino.CodigoOrden = Nothing
            lAvisoNoConfirmado.Add(avisoNC)

            'Control.EliminarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing)

            ugCaidos.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next

        If lAvisoNoConfirmado.Count > 0 Then
            Dim resultado As String
            resultado = Control.EliminarAvisosNoConfirmados(lAvisoNoConfirmado)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
                Exit Sub
            End If
            lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
        End If

    End Sub

    Private Sub EliminarReprogramados()
        Dim Orden As DataRow
        Dim Cod_Orden As Double
        Dim EliminarReprogramados As DataTable = Ordenes.Clone
        Dim Eliminados As DataRow
        Dim Indice As Integer
        Dim IndicesEliminar As New SortedList
        Dim Presupuesto, CodOrigen, CodDestino As Double
        Dim Control As New Control_Macheo
        Dim lAvisoManual As New List(Of AvisoConfirmado)
        Dim lAvisoNoConfirmado As New List(Of AvisoNoConfirmado)
        Dim avisoNC As AvisoNoConfirmado
        Dim avisoM As AvisoConfirmado

        If ugReprogramados.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a eliminar.")
            Exit Sub
        End If

        'Averigua los indices seleccionados
        For Each AvisoReprogramado As UltraGridRow In ugReprogramados.Selected.Rows
            Indice = AvisoReprogramado.Cells("Index").Value
            If Not IndicesEliminar.ContainsKey(Indice) Then
                IndicesEliminar.Add(Indice, Indice)
            End If
        Next

        'Selecciona todas las rows con el mismo indice
        For IndiceSeleccionados As Integer = 0 To IndicesEliminar.Count - 1
            For Each AvisoReprogramado As UltraGridRow In ugReprogramados.Rows
                If IndicesEliminar.GetKey(IndiceSeleccionados) = AvisoReprogramado.Cells("Index").Value Then
                    AvisoReprogramado.Selected = True
                End If
            Next
        Next

        'Recorre todas las rows seleccionadas y carga las ordenes
        For Each AvisoReprogramado As UltraGridRow In ugReprogramados.Selected.Rows
            'Carga orden origen
            Cod_Orden = AvisoReprogramado.Cells("Orden").Value
            If EliminarReprogramados.Select("Orden = " & Cod_Orden).Length = 0 Then
                Eliminados = EliminarReprogramados.NewRow

                Eliminados("Sel") = 0
                Eliminados("Orden") = AvisoReprogramado.Cells("Orden").Value
                Eliminados("Cod_Soporte") = AvisoReprogramado.Cells("Cod_Soporte").Value
                Eliminados("Soporte") = AvisoReprogramado.Cells("Soporte").Value
                Eliminados("Fecha") = AvisoReprogramado.Cells("Fecha").Value
                Eliminados("Hora") = AvisoReprogramado.Cells("Hora").Value
                Eliminados("Duracion") = AvisoReprogramado.Cells("Duracion").Value
                Eliminados("Programa") = AvisoReprogramado.Cells("Programa").Value
                Eliminados("Neto") = AvisoReprogramado.Cells("Neto").Value

                EliminarReprogramados.Rows.Add(Eliminados)
            End If
            'Carga orden destino
            Cod_Orden = AvisoReprogramado.Cells("OrdenDestino").Value
            If EliminarReprogramados.Select("Orden = " & Cod_Orden).Length = 0 Then
                Eliminados = EliminarReprogramados.NewRow

                Eliminados("Sel") = 0
                Eliminados("Orden") = AvisoReprogramado.Cells("OrdenDestino").Value
                Eliminados("Cod_Soporte") = AvisoReprogramado.Cells("Cod_SoporteDestino").Value
                Eliminados("Soporte") = AvisoReprogramado.Cells("SoporteDestino").Value
                Eliminados("Fecha") = AvisoReprogramado.Cells("FechaDestino").Value
                Eliminados("Hora") = AvisoReprogramado.Cells("HoraDestino").Value
                Eliminados("Duracion") = AvisoReprogramado.Cells("DuracionDestino").Value
                Eliminados("Programa") = AvisoReprogramado.Cells("ProgramaDestino").Value
                Eliminados("Neto") = AvisoReprogramado.Cells("NetoDestino").Value

                EliminarReprogramados.Rows.Add(Eliminados)
            End If
        Next

        'Carga las ordenes
        For Each RowOrden As DataRow In EliminarReprogramados.Rows
            Orden = Ordenes.NewRow

            Orden("Sel") = 0
            Orden("Orden") = RowOrden.Item("Orden")
            Orden("Cod_Soporte") = RowOrden.Item("Cod_Soporte")
            Orden("Soporte") = RowOrden.Item("Soporte")
            Orden("Fecha") = RowOrden.Item("Fecha")
            Orden("Hora") = RowOrden.Item("Hora")
            Orden("Duracion") = RowOrden.Item("Duracion")
            Orden("Programa") = RowOrden.Item("Programa")
            Orden("Neto") = RowOrden.Item("Neto")

            Ordenes.Rows.Add(Orden)
            If RowOrden.Item("Orden") <= 0 Then
                ugOrdenAviso.Rows(ugOrdenAviso.Rows.Count - 1).Cells("Orden").Hidden = True
            End If
        Next

        Presupuesto = txtPresupuesto.Text.Trim
        'Elimina las ordenes reprogramadas seleccionadas
        For IndiceSeleccionados As Integer = 0 To IndicesEliminar.Count - 1
            For IndiceReprogramado As Integer = ugReprogramados.Rows.Count - 1 To 0 Step -1
                If IndicesEliminar.GetKey(IndiceSeleccionados) = ugReprogramados.Rows(IndiceReprogramado).Cells("Index").Value Then
                    CodOrigen = ugReprogramados.Rows(IndiceReprogramado).Cells("Orden").Value
                    CodDestino = ugReprogramados.Rows(IndiceReprogramado).Cells("OrdenDestino").Value

                    avisoNC = New AvisoNoConfirmado
                    avisoNC.CodigoPresupuesto = Presupuesto
                    avisoNC.OrdenOrigen = New OrdenMatcheo
                    avisoNC.OrdenOrigen.CodigoOrden = CodOrigen
                    avisoNC.OrdenDestino = New OrdenMatcheo
                    avisoNC.OrdenDestino.CodigoOrden = CodDestino
                    lAvisoNoConfirmado.Add(avisoNC)

                    'Control.EliminarAvisosNoConfirmados(Presupuesto, CodOrigen, CodDestino)

                    If CodDestino <= 0 Then

                        avisoM = New AvisoConfirmado

                        avisoM.CodigoPresupuesto = Presupuesto
                        avisoM.CodigoOrden = CodDestino

                        lAvisoManual.Add(avisoM)

                        'Control.EliminarAvisosManuales(Presupuesto, CodDestino)
                    End If
                    ugReprogramados.Rows(IndiceReprogramado).Delete(False)
                End If
            Next
        Next

        If lAvisoNoConfirmado.Count > 0 Then
            Dim resultado As String
            resultado = Control.EliminarAvisosNoConfirmados(lAvisoNoConfirmado)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        If lAvisoManual.Count > 0 Then
            Dim resultado As String
            resultado = Control.EliminarAvisosManuales(lAvisoManual)
            If Not String.IsNullOrEmpty(resultado) Then
                Mensaje("Error: " & resultado & ". Debe realizar el proceso nuevamente")
            End If
            Exit Sub
        End If

        Call SetearRowsReprogramados()
    End Sub

    Private Sub EliminarCertificados()
        Dim Orden As DataRow
        Dim CantidadSeleccionados As Integer
        Dim Seleccionados As New SortedList
        Dim Presupuesto, CodOrigen As Double
        Dim Control As New Control_Macheo

        If ugCertificados.Selected.Rows.Count <= 0 Then
            Mensaje("Debe seleccionar al menos un registro a eliminar.")
            Exit Sub
        End If

        For Each AvisoCertificado As UltraGridRow In ugCertificados.Selected.Rows
            Orden = Ordenes.NewRow

            Orden("Sel") = 0
            Orden("Orden") = AvisoCertificado.Cells("Orden").Value
            Orden("Cod_Soporte") = AvisoCertificado.Cells("Cod_Soporte").Value
            Orden("Soporte") = AvisoCertificado.Cells("Soporte").Value
            Orden("Fecha") = AvisoCertificado.Cells("Fecha").Value
            Orden("Hora") = AvisoCertificado.Cells("Hora").Value
            Orden("Duracion") = AvisoCertificado.Cells("Duracion").Value
            Orden("Programa") = AvisoCertificado.Cells("Programa").Value
            Orden("Neto") = AvisoCertificado.Cells("Neto").Value

            Ordenes.Rows.Add(Orden)
            If AvisoCertificado.Cells("Orden").Value <= 0 Then
                ugOrdenAviso.Rows(ugOrdenAviso.Rows.Count - 1).Cells("Orden").Hidden = True
            End If
            If Not Seleccionados.ContainsKey(AvisoCertificado.Index) Then
                Seleccionados.Add(AvisoCertificado.Index, AvisoCertificado.Index)
            End If
        Next

        Presupuesto = txtPresupuesto.Text.Trim
        CantidadSeleccionados = Seleccionados.Count - 1
        For Index As Integer = CantidadSeleccionados To 0 Step -1
            CodOrigen = ugCertificados.Rows(Seleccionados.GetKey(Index)).Cells("Orden").Value
            Control.EliminarAvisosNoConfirmados(Presupuesto, CodOrigen, Nothing)

            If CodOrigen <= 0 Then
                Control.EliminarAvisosManuales(Presupuesto, CodOrigen)
            End If
            ugCertificados.Rows(Seleccionados.GetKey(Index)).Delete(False)
        Next
    End Sub

    Private Sub SetearRowsReprogramados()
        Dim Indice As Integer
        Dim Inicio As Boolean = True
        Dim ColorAlternativa As Color = Color.White

        If Not Reprogramados Is Nothing AndAlso Reprogramados.Rows.Count > 0 Then
            For Each Row As UltraGridRow In ugReprogramados.Rows
                If Inicio Then
                    Indice = Row.Cells("Index").Value
                    Inicio = False
                End If
                If Indice <> Row.Cells("Index").Value Then
                    If ColorAlternativa.Name = Color.LightBlue.Name Then
                        ColorAlternativa = Color.White
                    Else
                        ColorAlternativa = Color.LightBlue
                    End If
                End If
                Row.Appearance.BackColor = ColorAlternativa
                Indice = Row.Cells("Index").Value
            Next
        End If
    End Sub

    Private Sub Imprimir(ByVal pNeto As Boolean, Optional ByVal pExportar As Boolean = False)
        Dim CantidadImpresion As Integer
        Dim AvisosImprimir As New SortedList

        If txtPresupuesto.Text.Trim = String.Empty Then
            Mensajes.Mensaje("Debe ingresar un Número de Presupuesto.", TipoMensaje.Informacion)
            Exit Sub
        End If

        CantidadImpresion = Caidos.Rows.Count
        'CantidadImpresion += Reprogramados.Rows.Count
        'CantidadImpresion += Certificados.Rows.Count
        'If CantidadImpresion = 0 Then
        '    Mensajes.Mensaje("No existen Avisos Caidos/Ordenados para el presupuesto seleccionado", TipoMensaje.Informacion)
        'Mensajes.Mensaje("No existen Avisos Caidos/Reprogramados/Certificados para el presupuesto seleccionado", TipoMensaje.Informacion)
        'Exit Sub
        'End If

        Call AgregarCaidosImpresion(AvisosImprimir)
        'Call AgregarReprogramadosImpresion(AvisosImprimir)
        'Call AgregarCertificadosImpresion(AvisosImprimir)
        Call Imprimir(AvisosImprimir, pNeto, pExportar)
    End Sub

    Private Sub Imprimir(ByVal pAvisosImprimir As SortedList, ByVal pNeto As Boolean, ByVal pExportar As Boolean)
        Dim ugImpresion As New UltraGrid
        Dim Impresiones As New DataSet
        Dim Impresion As New AvisosNoConfirmados.AvisosDataTable
        Dim Datos As New AvisosNoConfirmados.DatosDataTable

        Call ObtenerImpresion(pAvisosImprimir, Impresion)
        Call ObtenerDatosImpresion(Datos, pNeto)


        Impresiones.Tables.Add(Impresion)
        Impresiones.Tables.Add(Datos)

        ugImpresion.DataSource = Impresiones
        ugImpresion.DataBind()

        If Not pExportar Then
            Dim AvisosNoConfirmados As New frmAvisosNoConfirmados
            AvisosNoConfirmados.DataSource = Impresiones
            AvisosNoConfirmados.ImprimirNeto = pNeto
            AvisosNoConfirmados.ShowDialog()

            'AS 2015-03-04
            Dim parameters As New Framework.ExportacionUtil.ParametrosExportacionLegajos
            parameters.NumCompania = Activo.IDCompaniaMMS
            parameters.NumPresupuesto = txtPresupuesto.Text.Trim
            parameters.Param1 = AvisosNoConfirmados.ReportViewer.ReportSource
            bWorker.RunWorkerAsync(parameters)
        Else
            Call ExportarReporte(Impresiones, pNeto)
        End If


    End Sub

    Private Sub ExportarReporte(ByVal pImpresiones As DataSet, ByVal pNeto As Boolean)
        Dim Libro As New Workbook
        Dim Hoja As Worksheet
        Dim FileName As String

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            FileName = SaveFileDialog.FileName
            Hoja = Libro.Worksheets.Add("Reporte")
            Hoja.DefaultColumnWidth = 6 * 256

            If pNeto Then
                ColFinObservacion = 9
            Else
                ColFinObservacion = 11
            End If

            Call ExportarReporteCabecera(Hoja, pImpresiones, pNeto)
            Call ExportarReporteDatos(Hoja, pImpresiones, pNeto)

            Try
                Infragistics.Excel.BIFF8Writer.WriteWorkbookToFile(Libro, FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If
    End Sub

    Private Sub ExportarReporteCabecera(ByRef pHoja As Worksheet, ByVal pImpresiones As DataSet, ByVal pNeto As Boolean)
        Dim NombreEmpresa As String

        If Activo.IDCompaniaMMS = 36 Then
            NombreEmpresa = "ARENA"
        ElseIf Activo.IDCompaniaMMS = 38 Then
            NombreEmpresa = "PROXIMIA"
        ElseIf Activo.IDCompaniaMMS = 35 Then
            NombreEmpresa = "MPG"
        End If

        pHoja.MergedCellsRegions.Add(0, 4, 0, 7)
        Call AplicarFormatoCelda(pHoja, 0, 4, NombreEmpresa, HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Courier New", 12)
        pHoja.MergedCellsRegions.Add(1, 5, 1, 6)
        Call AplicarFormatoCelda(pHoja, 1, 5, Today.ToString("dd/MM/yyyy"), HorizontalCellAlignment.Center, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
        pHoja.MergedCellsRegions.Add(2, 5, 2, 6)
        Call AplicarFormatoCelda(pHoja, 2, 5, "FINAL", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 8)
        Call AplicarFormatoCelda(pHoja, 3, 0, "INFORME DE LA PAUTA", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)
        Call AplicarFormatoCelda(pHoja, 4, 0, "CLIENTE :", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)
        Call AplicarFormatoCelda(pHoja, 5, 0, "PRODUCTO :", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)
        Call AplicarFormatoCelda(pHoja, 6, 0, "CAMPAÑA :", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)
        Call AplicarFormatoCelda(pHoja, 7, 0, "PERIODO :", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)
        Call AplicarFormatoCelda(pHoja, 8, 0, "PAUTA :", HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Single, "Arial", 6)

        If Not pImpresiones Is Nothing AndAlso pImpresiones.Tables.Count > 1 AndAlso pImpresiones.Tables(1).Rows.Count > 0 Then
            Call AplicarFormatoCelda(pHoja, 4, 2, pImpresiones.Tables(1).Rows(0)("Cliente"), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            Call AplicarFormatoCelda(pHoja, 5, 2, pImpresiones.Tables(1).Rows(0)("Producto"), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            Call AplicarFormatoCelda(pHoja, 6, 2, pImpresiones.Tables(1).Rows(0)("Campania"), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            Call AplicarFormatoCelda(pHoja, 7, 2, pImpresiones.Tables(1).Rows(0)("Periodo"), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            Call AplicarFormatoCelda(pHoja, 8, 2, pImpresiones.Tables(1).Rows(0)("Pauta"), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            pHoja.Rows(8).Cells(2).Value = Convert.ToDouble(pHoja.Rows(8).Cells(2).Value)
        End If

        pHoja.MergedCellsRegions.Add(10, 0, 10, 2)
        Call AplicarFormatoCelda(pHoja, 10, 0, "EMISORA", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 8)
        Call AplicarBordeCelda(pHoja, 10, 0, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
        pHoja.MergedCellsRegions.Add(10, 3, 10, ColFinObservacion)
        Call AplicarFormatoCelda(pHoja, 10, 3, "OBSERVACIONES", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 8)
        Call AplicarBordeCelda(pHoja, 10, 3, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
        If pNeto Then
            pHoja.MergedCellsRegions.Add(10, 10, 10, 11)
            Call AplicarFormatoCelda(pHoja, 10, 10, "NETO", HorizontalCellAlignment.Center, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 8)
            Call AplicarBordeCelda(pHoja, 10, 10, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
        End If
    End Sub

    Private Sub ExportarReporteDatos(ByRef pHoja As Worksheet, ByVal pImpresiones As DataSet, ByVal pNeto As Boolean)
        Dim Soportes As New ArrayList
        Dim RowIndex As Integer
        Dim TotalCaidosGeneral, TotalReprogramadosGeneral As Double
        Dim CellsRegion As Infragistics.Excel.WorksheetMergedCellsRegion

        If Not pImpresiones Is Nothing AndAlso pImpresiones.Tables.Count > 0 AndAlso pImpresiones.Tables(0).Rows.Count > 0 Then
            For Each pImpresion As DataRow In pImpresiones.Tables(0).Rows
                If Not Soportes.Contains(pImpresion("Emisora")) Then
                    Soportes.Add(pImpresion("Emisora"))
                End If
            Next
            RowIndex = 11
            For IndexSoporte As Integer = 0 To Soportes.Count - 1
                Call ExportarReporteDatos(pHoja, pImpresiones, pNeto, Soportes(IndexSoporte), RowIndex, TotalCaidosGeneral, TotalReprogramadosGeneral)
            Next
            If pNeto Then
                CellsRegion = pHoja.MergedCellsRegions.Add(RowIndex, 0, RowIndex + 2, 2)
                Call AplicarBordeCelda(pHoja, RowIndex, 0, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
                Call ExportarReporteDatos(pHoja, RowIndex, TotalCaidosGeneral, TotalReprogramadosGeneral)
            End If
        End If
    End Sub

    Private Sub ExportarReporteDatos(ByRef pHoja As Worksheet, ByVal pImpresiones As DataSet, ByVal pNeto As Boolean, _
            ByVal pSoporte As String, ByRef pRowIndex As Integer, ByRef pTotalCaidosGeneral As Double, ByRef pTotalReprogramadosGeneral As Double)
        Dim Filtro As New StringBuilder
        Dim Observacion As String()
        Dim ObservacionRepro As StringBuilder
        Dim TotalCaidos, TotalReprogramados As Double
        Dim RowStart As Integer = pRowIndex
        Dim CellsRegion As Infragistics.Excel.WorksheetMergedCellsRegion
        Dim CantRow, CantidadTotalRow As Integer
        Dim EsUltimo As Boolean

        Filtro.Append("Emisora = '")
        Filtro.Append(pSoporte)
        Filtro.Append("'")

        Call AplicarFormatoCelda(pHoja, pRowIndex, 0, pSoporte, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 8)
        CantRow = 0
        CantidadTotalRow = pImpresiones.Tables(0).Select(Filtro.ToString).Length

        For Each pImpresion As DataRow In pImpresiones.Tables(0).Select(Filtro.ToString)
            CantRow += 1
            Observacion = pImpresion("Observaciones").ToString.Split(vbCrLf)
            CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 3, pRowIndex, ColFinObservacion)
            If CantRow = CantidadTotalRow AndAlso Observacion.Length = 1 Then
                EsUltimo = True
            Else
                EsUltimo = False
            End If
            Call AplicarBordeCelda(CellsRegion, CantRow, CantidadTotalRow, EsUltimo)
            Call AplicarFormatoCelda(pHoja, pRowIndex, 3, Observacion(0), HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
            If pNeto Then
                CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 10, pRowIndex, 11)
                Call AplicarBordeCelda(CellsRegion, CantRow, CantidadTotalRow, EsUltimo)
                Call AplicarFormatoCelda(pHoja, pRowIndex, 10, pImpresion("Tarifa"), HorizontalCellAlignment.Right, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
                Call AplicarFormatoCeldaNumerica(pHoja, pRowIndex, 10)
                If pImpresion("Estado") = "C" Then
                    TotalCaidos += pImpresion("Tarifa")
                    pTotalCaidosGeneral += pImpresion("Tarifa")
                ElseIf pImpresion("Estado") = "R" Then
                    TotalReprogramados += pImpresion("Tarifa")
                    pTotalReprogramadosGeneral += pImpresion("Tarifa")
                End If
            End If
            pRowIndex += 1
            If Observacion.Length > 1 Then
                ObservacionRepro = New StringBuilder
                ObservacionRepro.Append("                 ")
                ObservacionRepro.Append(Observacion(1).Trim)
                CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 3, pRowIndex, ColFinObservacion)
                If CantRow = CantidadTotalRow Then
                    EsUltimo = True
                Else
                    EsUltimo = False
                End If
                Call AplicarBordeCelda(CellsRegion, CantRow, CantidadTotalRow, EsUltimo)
                Call AplicarFormatoCelda(pHoja, pRowIndex, 3, ObservacionRepro.ToString, HorizontalCellAlignment.Left, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)

                If pNeto Then
                    CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 10, pRowIndex, 11)
                    Call AplicarBordeCelda(CellsRegion, CantRow, CantidadTotalRow, EsUltimo)
                    Call AplicarFormatoCelda(pHoja, pRowIndex, 10, "", HorizontalCellAlignment.Right, ExcelDefaultableBoolean.Default, FontUnderlineStyle.Default, "Arial", 6)
                End If

                pRowIndex += 1
            End If
        Next
        If pNeto Then
            Call ExportarReporteDatos(pHoja, pRowIndex, TotalCaidos, TotalReprogramados)
        End If

        CellsRegion = pHoja.MergedCellsRegions.Add(RowStart, 0, pRowIndex - 1, 2)
        CellsRegion.CellFormat.VerticalAlignment = VerticalCellAlignment.Top
        CellsRegion.CellFormat.Alignment = HorizontalCellAlignment.Left
        Call AplicarBordeCelda(pHoja, RowStart, 0, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin, CellBorderLineStyle.Thin)
    End Sub

    Private Sub ExportarReporteDatos(ByRef pHoja As Worksheet, ByRef pRowIndex As Integer, ByVal pTotalCaidos As Double, ByVal pTotalReprogramados As Double)
        Dim CellsRegion As Infragistics.Excel.WorksheetMergedCellsRegion

        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 3, pRowIndex, ColFinObservacion)
        Call AplicarBordeCelda(CellsRegion, 1, 3, False)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 3, "Total Caidos :", HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 10, pRowIndex, 11)
        Call AplicarBordeCelda(CellsRegion, 1, 3, False)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 10, pTotalCaidos, HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        Call AplicarFormatoCeldaNumerica(pHoja, pRowIndex, 10)
        pRowIndex += 1

        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 3, pRowIndex, ColFinObservacion)
        Call AplicarBordeCelda(CellsRegion, 2, 3, False)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 3, "Total Reprogramados :", HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 10, pRowIndex, 11)
        Call AplicarBordeCelda(CellsRegion, 2, 3, False)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 10, pTotalReprogramados, HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        Call AplicarFormatoCeldaNumerica(pHoja, pRowIndex, 10)
        pRowIndex += 1

        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 3, pRowIndex, ColFinObservacion)
        Call AplicarBordeCelda(CellsRegion, 3, 3, True)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 3, "Total :", HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        CellsRegion = pHoja.MergedCellsRegions.Add(pRowIndex, 10, pRowIndex, 11)
        Call AplicarBordeCelda(CellsRegion, 3, 3, True)
        Call AplicarFormatoCelda(pHoja, pRowIndex, 10, pTotalCaidos + pTotalReprogramados, HorizontalCellAlignment.Right, ExcelDefaultableBoolean.True, FontUnderlineStyle.Default, "Arial", 6)
        Call AplicarFormatoCeldaNumerica(pHoja, pRowIndex, 10)
        pRowIndex += 1
    End Sub

    Private Sub AplicarFormatoCelda(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer, ByVal pTexto As String, _
            ByVal pAlign As HorizontalCellAlignment, ByVal pBold As ExcelDefaultableBoolean, ByVal pUnderlineStyle As FontUnderlineStyle, _
            ByVal pFontName As String, ByVal pHeight As Integer)

        pHoja.Rows(pRow).Cells(pCell).Value = pTexto
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Alignment = pAlign
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Bold = pBold
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Name = pFontName
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.Height = pHeight * 20
        pHoja.Rows(pRow).Cells(pCell).CellFormat.WrapText = ExcelDefaultableBoolean.False
        pHoja.Rows(pRow).Cells(pCell).CellFormat.Font.UnderlineStyle = pUnderlineStyle
    End Sub

    Private Sub AplicarBordeCelda(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer, _
            ByVal pBottomStyle As CellBorderLineStyle, ByVal pTopStyle As CellBorderLineStyle, ByVal pLeftStyle As CellBorderLineStyle, ByVal pRightStyle As CellBorderLineStyle)
        pHoja.Rows(pRow).Cells(pCell).CellFormat.BottomBorderStyle = pBottomStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.TopBorderStyle = pTopStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.LeftBorderStyle = pLeftStyle
        pHoja.Rows(pRow).Cells(pCell).CellFormat.RightBorderStyle = pRightStyle
    End Sub

    Private Sub AplicarBordeCelda(ByVal pCellsRegion As WorksheetMergedCellsRegion, ByVal pCantRow As Integer, ByVal pCantidadTotalRow As Integer, ByVal pEsUltimo As Boolean)
        If pCantRow = 1 Then
            pCellsRegion.CellFormat.TopBorderStyle = CellBorderLineStyle.Thin
            pCellsRegion.CellFormat.LeftBorderStyle = CellBorderLineStyle.Thin
            pCellsRegion.CellFormat.RightBorderStyle = CellBorderLineStyle.Thin
            If pEsUltimo Then
                pCellsRegion.CellFormat.BottomBorderStyle = CellBorderLineStyle.Thin
            Else
                pCellsRegion.CellFormat.BottomBorderStyle = CellBorderLineStyle.None
            End If
        ElseIf pCantRow = pCantidadTotalRow AndAlso pEsUltimo Then
            pCellsRegion.CellFormat.TopBorderStyle = CellBorderLineStyle.None
            pCellsRegion.CellFormat.BottomBorderStyle = CellBorderLineStyle.Thin
            pCellsRegion.CellFormat.LeftBorderStyle = CellBorderLineStyle.Thin
            pCellsRegion.CellFormat.RightBorderStyle = CellBorderLineStyle.Thin
        Else
            pCellsRegion.CellFormat.TopBorderStyle = CellBorderLineStyle.None
            pCellsRegion.CellFormat.BottomBorderStyle = CellBorderLineStyle.None
            pCellsRegion.CellFormat.LeftBorderStyle = CellBorderLineStyle.Thin
            pCellsRegion.CellFormat.RightBorderStyle = CellBorderLineStyle.Thin
        End If
    End Sub

    Private Sub AplicarFormatoCeldaNumerica(ByRef pHoja As Worksheet, ByVal pRow As Integer, ByVal pCell As Integer)
        pHoja.Rows(pRow).Cells(pCell).Value = Convert.ToDouble(pHoja.Rows(pRow).Cells(pCell).Value)
        pHoja.Rows(pRow).Cells(pCell).CellFormat.FormatString = "#,##0.00"
    End Sub

    Private Sub AgregarCaidosImpresion(ByRef pAvisosImprimir As SortedList)
        Dim Soporte, Fecha, Hora, Duracion, Programa, Material, Observacion As String
        Dim Neto As Double
        Dim Key As StringBuilder
        NetoCaidos = New SortedList


        For Each AvisosCaidos As DataRow In Caidos.Rows
            Soporte = AvisosCaidos("Soporte")
            Fecha = Convert.ToDateTime(AvisosCaidos("Fecha")).Date.ToString("dd/MM/yyyy")
            Hora = AvisosCaidos("Hora")
            Duracion = AvisosCaidos("Duracion")
            Programa = AvisosCaidos("Programa")
            Neto = AvisosCaidos("Neto")
            'AG 26/02/2013 ++++++++++++++++++++++++++++++++++++++++++++
            Material = AvisosCaidos("Material")
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Observacion = AvisosCaidos("Observaciones")

            Key = New StringBuilder
            Key.Append(Soporte)
            Key.Append("|")
            Key.Append(Fecha)
            Key.Append("|")
            Key.Append(Hora)
            Key.Append("|")
            Key.Append(Duracion)
            Key.Append("|")
            Key.Append(Programa)
            Key.Append("|")
            Key.Append(Material)
            Key.Append("|C|")
            Key.Append(Observacion)

            If Not pAvisosImprimir.ContainsKey(Key.ToString) Then
                pAvisosImprimir.Add(Key.ToString, 1)
                NetoCaidos.Add(Key.ToString, Neto)
            Else
                pAvisosImprimir(Key.ToString) += 1
                NetoCaidos(Key.ToString) += Neto
            End If
        Next
    End Sub

    Private Sub AgregarReprogramadosImpresion(ByRef pAvisosImprimir As SortedList)
        Dim Indice, IndiceAnterior As Integer
        Dim Soporte, Fecha, Hora, Duracion, Programa, Observacion As String
        Dim Key As StringBuilder

        IndiceAnterior = -1
        For Each AvisosReprogramados As DataRow In Reprogramados.Rows
            Indice = AvisosReprogramados("Index")
            If Indice <> IndiceAnterior OrElse IndiceAnterior = -1 Then
                IndiceAnterior = Indice
                Soporte = AvisosReprogramados("Soporte")
                Fecha = Convert.ToDateTime(AvisosReprogramados("Fecha")).Date.ToString("dd/MM/yyyy")
                Hora = AvisosReprogramados("Hora")
                Duracion = AvisosReprogramados("Duracion")
                Programa = AvisosReprogramados("Programa")
                Observacion = AvisosReprogramados("Observaciones")

                Key = New StringBuilder
                Key.Append(Soporte)
                Key.Append("|")
                Key.Append(Fecha)
                Key.Append("|")
                Key.Append(Hora)
                Key.Append("|")
                Key.Append(Duracion)
                Key.Append("|")
                Key.Append(Programa)
                Key.Append("|R|")
                Key.Append(Observacion)
                Key.Append("|")
                Key.Append(Indice)

                pAvisosImprimir.Add(Key.ToString, 1)
            End If
        Next
    End Sub

    Private Sub AgregarCertificadosImpresion(ByRef pAvisosImprimir As SortedList)
        Dim Soporte, Fecha, Hora, Duracion, Programa, Observacion As String
        Dim Neto As Double
        Dim Key As StringBuilder

        For Each AvisosCertificados As DataRow In Certificados.Rows
            Soporte = AvisosCertificados("Soporte")
            Fecha = Convert.ToDateTime(AvisosCertificados("Fecha")).Date.ToString("dd/MM/yyyy")
            Hora = AvisosCertificados("Hora")
            Duracion = AvisosCertificados("Duracion")
            Programa = AvisosCertificados("Programa")
            Neto = 0
            Observacion = AvisosCertificados("Observaciones")

            Key = New StringBuilder
            Key.Append(Soporte)
            Key.Append("|")
            Key.Append(Fecha)
            Key.Append("|")
            Key.Append(Hora)
            Key.Append("|")
            Key.Append(Duracion)
            Key.Append("|")
            Key.Append(Programa)
            Key.Append("|F|")
            Key.Append(Observacion)

            If Not pAvisosImprimir.ContainsKey(Key.ToString) Then
                pAvisosImprimir.Add(Key.ToString, 1)
            Else
                pAvisosImprimir(Key.ToString) += 1
            End If
        Next
    End Sub

    Private Sub ObtenerImpresion(ByVal pAvisosImprimir As SortedList, ByRef pImpresion As AvisosNoConfirmados.AvisosDataTable)
        Dim DatosImpresion As AvisosNoConfirmados.AvisosRow
        Dim Soporte, Hora, Duracion, Programa, Estado, Key, Material, Observacion As String
        Dim Fecha As DateTime
        Dim Neto As Double
        Dim CantidadSpots, Indice As Integer
        Dim KeyPart As String()
        Dim ControlMacheo As New Control_Macheo
        Dim lAvisos As New List(Of AvisoNoConfirmado)
        Dim lAvisosABorrar As New List(Of AvisoNoConfirmado)
        lAvisos = ControlMacheo.BuscarAvisosReporteFacturacion(Activo.IDCompaniaMMS, Integer.Parse(txtPresupuesto.Text.Trim))
        Dim Soportes As New ArrayList



        For Index As Integer = 0 To pAvisosImprimir.Count - 1
            Key = pAvisosImprimir.GetKey(Index)
            CantidadSpots = pAvisosImprimir(Key)

            KeyPart = Key.Split("|")
            If KeyPart.Length > 7 Then '6
                'AG 26/02/2013 ++++++++++++
                If (Soporte IsNot Nothing And Soporte <> KeyPart.GetValue(0)) Then
                    Dim avisoABorrar As AvisoNoConfirmado

                    For Each aviso As AvisoNoConfirmado In lAvisos
                        If (Soporte = aviso.OrdenOrigen.DescripcionSoporte) Then
                            DatosImpresion.CantOrdenados = aviso.OrdenOrigen.Duracion
                            DatosImpresion.ImporteOrdenados = Double.Parse(aviso.OrdenOrigen.Neto.ToString)
                            avisoABorrar = aviso
                            If Key = String.Empty Then
                                Soporte = KeyPart.GetValue(0)
                            End If
                            Exit For
                        End If
                    Next

                    If (avisoABorrar IsNot Nothing) Then
                        lAvisos.Remove(avisoABorrar)
                        'lAvisosABorrar.Add(avisoABorrar)
                    End If

                End If

                Soporte = KeyPart.GetValue(0)
                Fecha = KeyPart.GetValue(1)
                Hora = KeyPart.GetValue(2)
                Duracion = KeyPart.GetValue(3)
                Programa = KeyPart.GetValue(4)
                Material = KeyPart.GetValue(5)
                Estado = KeyPart.GetValue(6)
                Observacion = KeyPart.GetValue(7)
                If KeyPart.Length > 8 Then
                    Indice = KeyPart.GetValue(8)
                End If

                DatosImpresion = pImpresion.NewAvisosRow

                DatosImpresion.CantOrdenados = 0
                DatosImpresion.ImporteOrdenados = 0
                

                DatosImpresion.Emisora = Soporte
                DatosImpresion.Programa = Programa
                DatosImpresion.Fecha = Fecha

                DatosImpresion.Segundos = Duracion
                DatosImpresion.Cant = CantidadSpots * -1

                If Estado = "C" Then
                    DatosImpresion.Importe = NetoCaidos(Key) * -1
                Else
                    DatosImpresion.Importe = 0
                End If
                pImpresion.Rows.Add(DatosImpresion)
            End If
        Next
        'For Each aviso As AvisoNoConfirmado In lAvisosABorrar
        '    If (Soporte = aviso.OrdenOrigen.DescripcionSoporte) Then
        '        lAvisos.Remove(aviso)
        '    End If
        'Next

        For Each aviso As AvisoNoConfirmado In lAvisos
            DatosImpresion = pImpresion.NewAvisosRow
            DatosImpresion.CantOrdenados = aviso.OrdenOrigen.Duracion
            DatosImpresion.ImporteOrdenados = Double.Parse(aviso.OrdenOrigen.Neto.ToString)
            DatosImpresion.Emisora = aviso.OrdenOrigen.DescripcionSoporte
            DatosImpresion.Fecha = String.Empty
            Soporte = aviso.OrdenOrigen.DescripcionSoporte
            DatosImpresion.Programa = String.Empty
            DatosImpresion.Importe = 0
            DatosImpresion.Segundos = 0
            DatosImpresion.Cant = 0
            pImpresion.Rows.Add(DatosImpresion)
        Next

    End Sub

    Private Sub ObtenerDatosImpresion(ByRef pDatos As AvisosNoConfirmados.DatosDataTable, ByVal Neto As Boolean)
        Dim Dato As AvisosNoConfirmados.DatosRow
        Dim Control As New Control_Macheo

        If DatosPresupuesto Is Nothing Then
            DatosPresupuesto = Control.BuscarPresupuesto_Id(txtPresupuesto.Text.Trim)
        End If

        If Not DatosPresupuesto Is Nothing AndAlso DatosPresupuesto.Rows.Count > 0 Then
            Dato = pDatos.NewDatosRow
            Dato.Cliente = DatosPresupuesto.Rows(0)("Cliente")
            Dato.Producto = DatosPresupuesto.Rows(0)("Producto")
            Dato.Campania = DatosPresupuesto.Rows(0)("Campania")
            Dato.Periodo = DatosPresupuesto.Rows(0)("Periodo")
            Dato.Pauta = DatosPresupuesto.Rows(0)("Pauta")
            If Activo.IDCompaniaMMS = 36 Then
                Dato.Empresa = "ARENA"
                If Neto = True Then
                    Dato.Logo = ObtenerImagen(Application.StartupPath & "\ARE\ControlFinanzasArena.bmp")
                End If
            ElseIf Activo.IDCompaniaMMS = 38 Then
                Dato.Empresa = "PROXIMIA"
                If Neto = True Then
                    Dato.Logo = ObtenerImagen(Application.StartupPath & "\PRX\ControlFinanzasProximia.bmp")
                End If
            ElseIf Activo.IDCompaniaMMS = 35 Then
                Dato.Empresa = "HAVAS MEDIA"
                If Neto = True Then
                    Dato.Logo = ObtenerImagen(Application.StartupPath & "\MPG\ControlFinanzasHavasMedia.bmp")
                End If
            ElseIf Activo.IDCompaniaMMS = 41 Then
                Dato.Empresa = "FORWARD"
                If Neto = True Then
                    Dato.Logo = ObtenerImagen(Application.StartupPath & "\FWD\ControlFinanzasFwd.bmp")
                End If
            ElseIf Activo.IDCompaniaMMS = 42 Then
                Dato.Empresa = "SOCIA"
                If Neto = True Then
                    Dato.Logo = ObtenerImagen(Application.StartupPath & "\SCL\ControlFinanzasScl.bmp")
                End If
            End If

            'If Activo.Empresa.IndexOf("are") = -1 Then
            '    Dato.Empresa = "MEDIA PLANNING"
            'Else
            '    Dato.Empresa = "ARENA"
            'End If
            pDatos.Rows.Add(Dato)
        End If
    End Sub

    Private Function ObtenerImagen(ByVal Ruta As String) As Byte()

        Dim fs As New FileStream(Ruta, FileMode.Open)
        Dim br As New BinaryReader(fs)

        Dim Imagen(0 To fs.Length - 1) As Byte

        br.Read(Imagen, 0, CInt(fs.Length))

        br.Close()
        fs.Close()

        Return Imagen

    End Function

    Private Sub ObtenerAvisosAImprimir(ByRef pAvisosImprimir As SortedList, ByVal pIndice As Integer, ByVal pOrigen As Boolean)
        Dim Orden, Soporte, Hora, Duracion, Programa As String
        Dim Fecha As DateTime
        Dim Keys As StringBuilder
        Dim CampoOrden, CampoSoporte, CampoHora, CampoDuracion, CampoPrograma, CampoFecha As String

        CampoOrden = "Orden"
        CampoSoporte = "Soporte"
        CampoFecha = "Fecha"
        CampoHora = "Hora"
        CampoDuracion = "Duracion"
        CampoPrograma = "Programa"
        If Not pOrigen Then
            CampoOrden &= "Destino"
            CampoSoporte &= "Destino"
            CampoFecha &= "Destino"
            CampoHora &= "Destino"
            CampoDuracion &= "Destino"
            CampoPrograma &= "Destino"
        End If
        For Each AvisosReprogramados As DataRow In Reprogramados.Select("Index = " & pIndice)
            Orden = AvisosReprogramados(CampoOrden)
            Soporte = AvisosReprogramados(CampoSoporte)
            Fecha = Convert.ToDateTime(AvisosReprogramados(CampoFecha)).Date.ToString("dd/MM/yyyy")
            Hora = AvisosReprogramados(CampoHora)
            Duracion = AvisosReprogramados(CampoDuracion)
            Programa = AvisosReprogramados(CampoPrograma)

            Keys = New StringBuilder
            Keys.Append(Orden)
            Keys.Append("|")
            Keys.Append(Soporte)
            Keys.Append("|")
            Keys.Append(Fecha)
            Keys.Append("|")
            Keys.Append(Hora)
            Keys.Append("|")
            Keys.Append(Duracion)
            Keys.Append("|")
            Keys.Append(Programa)

            If Not pAvisosImprimir.ContainsKey(Keys.ToString) Then
                pAvisosImprimir.Add(Keys.ToString, 1)
            End If
        Next
    End Sub

    Private Function ObtenerHora(ByVal pHora As Integer, ByVal pMinuto As Integer) As String
        Dim Hora As New StringBuilder
        Dim HoraParcial As String

        HoraParcial = pHora
        HoraParcial = HoraParcial.Insert(0, "0")
        HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
        Hora.Append(HoraParcial)
        Hora.Append(":")
        HoraParcial = pMinuto
        HoraParcial = HoraParcial.Insert(0, "0")
        HoraParcial = HoraParcial.Substring(HoraParcial.Length - 2)
        Hora.Append(HoraParcial)

        Return Hora.ToString
    End Function

    Private Function ObtenerIndiceReprogramado(ByVal pOrden_Origen As Double, ByVal pOrden_Destino As Double) As Integer
        Dim Indice As Integer
        Dim Orden_Origen, Orden_Destino As Double
        Dim IndiceEncontrado As Boolean = False

        If Not OrdenReprogramado Is Nothing AndAlso OrdenReprogramado.Rows.Count > 0 Then
            Indice = ObtenerMaximoIndice()
            For Each IndiceOrigen As DataRow In OrdenReprogramado.Select("Orden = " & pOrden_Origen)
                Indice = IndiceOrigen("Index")
                IndiceEncontrado = True
            Next
            If Not IndiceEncontrado Then
                For Each IndiceDestino As DataRow In OrdenReprogramado.Select("OrdenDestino = " & pOrden_Destino)
                    Indice = IndiceDestino("Index")
                    IndiceEncontrado = True
                Next
            End If
            If Not IndiceEncontrado Then
                Indice += 1
            End If
        End If

        Return Indice
    End Function

    Private Function ObtenerMaximoIndice() As Integer
        Dim MaximoIndice As Integer
        If Not OrdenReprogramado Is Nothing AndAlso OrdenReprogramado.Rows.Count > 0 Then
            For Each IndiceOrigen As DataRow In OrdenReprogramado.Rows
                If IndiceOrigen("Index") > MaximoIndice Then
                    MaximoIndice = IndiceOrigen("Index")
                End If
            Next
        End If

        Return MaximoIndice
    End Function

    Private Function ObtenerObservacionImpresion(ByVal pSoporte As String, ByVal pFecha As DateTime, ByVal pHora As String, ByVal pDuracion As String, ByVal pPrograma As String, ByVal pMaterial As String, ByVal pObservacion As String, ByVal pEstado As String, ByVal pIndice As Integer, ByVal pCantidadSpots As Integer) As String
        If pEstado = "C" Then
            Return ObtenerObservacionImpresionCaido(pFecha, pDuracion, pPrograma, pMaterial, pObservacion, pCantidadSpots)
        ElseIf pEstado = "R" Then
            Return ObtenerObservacionImpresionRepro(pIndice, pObservacion)
        Else
            Return ObtenerObservacionImpresionCertificado(pFecha, pDuracion, pPrograma, pObservacion, pCantidadSpots)
        End If
    End Function

    Private Function ObtenerObservacionImpresionCaido(ByVal pFecha As DateTime, ByVal pDuracion As String, ByVal pPrograma As String, ByVal pMaterial As String, ByVal pObservacion As String, ByVal pCantidadSpots As Integer) As String
        Dim Observacion As New StringBuilder

        Observacion.Append(pFecha.ToString("dd/MM"))
        Observacion.Append(" - ")
        If pCantidadSpots > 1 Then
            Observacion.Append(pCantidadSpots)
            Observacion.Append(" spots de ")
        Else
            Observacion.Append("1 spot de ")
        End If
        Observacion.Append(pDuracion)
        Observacion.Append("'' ")
        Observacion.Append(pPrograma)
        'AG 26/02/2013 +++++++++++++++++++
        Observacion.Append(" - ")
        Observacion.Append(pMaterial)
        '++++++++++++++++++++++++++++++
        If pCantidadSpots > 1 Then
            Observacion.Append(", no fueron emitidos. ")
        Else
            Observacion.Append(", no fue emitido. ")
        End If
        Observacion.Append(pObservacion)

        Return Observacion.ToString
    End Function

    Private Function ObtenerObservacionImpresionRepro(ByVal pIndice As Integer, ByVal pObservacion As String) As String
        Dim Observacion As New StringBuilder
        Dim AvisosImprimirOrigen As New SortedList
        Dim AvisosImprimirDestino As New SortedList

        Call ObtenerAvisosAImprimir(AvisosImprimirOrigen, pIndice, True)
        Call ObtenerAvisosAImprimir(AvisosImprimirDestino, pIndice, False)

        Observacion.Append("REPRO - ")
        Observacion.Append(ObtenerObservacionImpresion(AvisosImprimirOrigen))
        If AvisosImprimirOrigen.Count > 1 Then
            Observacion.Append(", fueron emitidos como ")
        Else
            Observacion.Append(", fue emitido como ")
        End If
        Observacion.Append(vbCrLf)
        Observacion.Append(vbTab)
        Observacion.Append("     ")
        Observacion.Append(ObtenerObservacionImpresion(AvisosImprimirDestino))
        Observacion.Append(". ")
        Observacion.Append(pObservacion)

        Return Observacion.ToString
    End Function

    Private Function ObtenerObservacionImpresionCertificado(ByVal pFecha As DateTime, ByVal pDuracion As String, ByVal pPrograma As String, ByVal pObservacion As String, ByVal pCantidadSpots As Integer) As String
        Dim Observacion As New StringBuilder

        Observacion.Append(pFecha.ToString("dd/MM"))
        Observacion.Append(" - ")
        If pCantidadSpots > 1 Then
            Observacion.Append(pCantidadSpots)
            Observacion.Append(" spots de ")
        Else
            Observacion.Append("1 spot de ")
        End If
        Observacion.Append(pDuracion)
        Observacion.Append("'' ")
        Observacion.Append(pPrograma)
        Observacion.Append(". ")
        Observacion.Append(pObservacion)

        Return Observacion.ToString
    End Function

    Private Function ObtenerObservacionImpresion(ByVal pAvisosImprimir As SortedList) As String
        Dim Orden, OrdenAnterior, Soporte, Hora, Duracion, Programa As String
        Dim Fecha As DateTime
        Dim AvisosImprimirPart As New SortedList
        Dim KeyPart As String()
        Dim Keys As StringBuilder
        Dim Observacion As New StringBuilder

        For Index As Integer = 0 To pAvisosImprimir.Count - 1
            KeyPart = pAvisosImprimir.GetKey(Index).ToString.Split("|")
            Orden = KeyPart.GetValue(0)
            Soporte = KeyPart.GetValue(1)
            Fecha = KeyPart.GetValue(2)
            Hora = KeyPart.GetValue(3)
            Duracion = KeyPart.GetValue(4)
            Programa = KeyPart.GetValue(5)

            Keys = New StringBuilder
            Keys.Append(Soporte)
            Keys.Append("|")
            Keys.Append(Fecha)
            Keys.Append("|")
            Keys.Append(Hora)
            Keys.Append("|")
            Keys.Append(Duracion)
            Keys.Append("|")
            Keys.Append(Programa)

            If Not AvisosImprimirPart.ContainsKey(Keys.ToString) Then
                AvisosImprimirPart.Add(Keys.ToString, 1)
                OrdenAnterior = Orden
            ElseIf Orden <> OrdenAnterior Then
                AvisosImprimirPart(Keys.ToString) += 1
            End If
        Next
        For IndexPart As Integer = 0 To AvisosImprimirPart.Count - 1
            KeyPart = AvisosImprimirPart.GetKey(IndexPart).ToString.Split("|")
            Soporte = KeyPart.GetValue(0)
            Fecha = KeyPart.GetValue(1)
            Hora = KeyPart.GetValue(2)
            Duracion = KeyPart.GetValue(3)
            Programa = KeyPart.GetValue(4)

            Observacion.Append(Fecha.ToString("dd/MM"))
            Observacion.Append(" - ")
            If AvisosImprimirPart(AvisosImprimirPart.GetKey(IndexPart)) > 1 Then
                Observacion.Append(AvisosImprimirPart(AvisosImprimirPart.GetKey(IndexPart)))
                Observacion.Append(" spots de ")
            Else
                Observacion.Append("1 spot de ")
            End If
            Observacion.Append(Duracion)
            Observacion.Append("'' ")
            Observacion.Append(Programa)
            If IndexPart < AvisosImprimirPart.Count - 1 Then
                Observacion.Append("; ")
            End If
        Next

        Return Observacion.ToString
    End Function

    Private Function ObtenerNetoReprogramados(ByVal pIndice As Integer) As Double
        Dim Orden, Neto, NetoOrigen, NetoDestino As Double
        Dim AvisosImprimirTarifaOrigen As New SortedList
        Dim AvisosImprimirTarifaDestino As New SortedList

        For Each AvisosReprogramados As DataRow In Reprogramados.Select("Index = " & pIndice)
            Orden = AvisosReprogramados("Orden")
            Neto = AvisosReprogramados("Neto")
            If Not AvisosImprimirTarifaOrigen.ContainsKey(Orden) Then
                AvisosImprimirTarifaOrigen.Add(Orden, Neto)
                NetoOrigen += Neto
            End If
            Orden = AvisosReprogramados("OrdenDestino")
            Neto = AvisosReprogramados("NetoDestino")
            If Not AvisosImprimirTarifaDestino.ContainsKey(Orden) Then
                AvisosImprimirTarifaDestino.Add(Orden, Neto)
                NetoDestino += Neto
            End If
        Next
        Neto = NetoOrigen - NetoDestino
        Return Neto
    End Function

    Private Function ObtenerNroOrdenNuevo() As Double
        Dim NroOrden As Double

        For Each Orden As DataRow In Ordenes.Select("Orden < 0")
            If Convert.ToDouble(Orden("Orden")) < NroOrden Then
                NroOrden = Convert.ToDouble(Orden("Orden"))
            End If
        Next

        For Each Caido As DataRow In Caidos.Select("Orden < 0")
            If Convert.ToDouble(Caido("Orden")) < NroOrden Then
                NroOrden = Convert.ToDouble(Caido("Orden"))
            End If
        Next

        For Each Reprogramado As DataRow In Reprogramados.Select("Orden < 0 or OrdenDestino < 0")
            If Convert.ToDouble(Reprogramado("Orden")) < NroOrden Then
                NroOrden = Convert.ToDouble(Reprogramado("Orden"))
            End If
            If Convert.ToDouble(Reprogramado("OrdenDestino")) < NroOrden Then
                NroOrden = Convert.ToDouble(Reprogramado("OrdenDestino"))
            End If
        Next

        NroOrden -= 1
        Return NroOrden
    End Function

    Private Function ObtenerAvisosNoConfirmados(ByVal codPresupuesto As Double) As DataSet
        Dim ControlMatcheo As New Control_Macheo
        Dim dsAvisos As New DataSet
        Dim dtAvisos As New DataTable
        Dim lAvisos As New List(Of AvisoNoConfirmado)
        Dim dr As DataRow

        ArmarEstructuraAvisosNoConfirmados(dtAvisos)

        'AG 26/02/2013 ++++++++++++++++++++++++++++++++++++
        'Aqui se tiene que modificar el servicio y la consulta de mms para que se agrege en el resultado de busqueda el MATERIAL
        lAvisos = ControlMatcheo.BuscarAvisosNoConfirmados(Activo.IDCompaniaMMS, Integer.Parse(codPresupuesto.ToString))

        For Each aviso As AvisoNoConfirmado In lAvisos
            dr = dtAvisos.NewRow

            dr("orden_origen") = Double.Parse(aviso.OrdenOrigen.CodigoOrden.Value.ToString)
            dr("cod_soporte_origen") = aviso.OrdenOrigen.CodigoSoporte
            dr("soporte_origen") = aviso.OrdenOrigen.DescripcionSoporte
            dr("programa_origen") = aviso.OrdenOrigen.Programa
            dr("fecha_origen") = aviso.OrdenOrigen.fechaEjecucion
            dr("duracion_origen") = aviso.OrdenOrigen.Duracion
            dr("hora_origen") = aviso.OrdenOrigen.Hora
            dr("minuto_origen") = aviso.OrdenOrigen.Minuto
            dr("neto_origen") = Double.Parse(aviso.OrdenOrigen.Neto.ToString)
            'AG 27/02/2013 ++++++++++++++++++++++++++++++++++++++++++
            If Not aviso.OrdenOrigen.DescripcionMaterial Is Nothing Then
                dr("material") = aviso.OrdenOrigen.DescripcionMaterial.ToString
            End If
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++

            If Not aviso.OrdenDestino.CodigoOrden Is Nothing Then
                dr("orden_destino") = Double.Parse(aviso.OrdenDestino.CodigoOrden.ToString)
            Else
                dr("orden_destino") = 0
            End If
            If Not aviso.OrdenDestino.CodigoSoporte Is Nothing Then
                dr("cod_soporte_destino") = aviso.OrdenDestino.CodigoSoporte
            End If
            If Not aviso.OrdenDestino.DescripcionSoporte Is Nothing Then
                dr("soporte_destino") = aviso.OrdenDestino.DescripcionSoporte
            End If
            If Not aviso.OrdenDestino.Programa Is Nothing Then
                dr("programa_destino") = aviso.OrdenDestino.Programa
            End If
            If Not aviso.OrdenDestino.fechaEjecucion Is Nothing Then
                dr("fecha_destino") = aviso.OrdenDestino.fechaEjecucion
            End If
            If Not aviso.OrdenDestino.Duracion Is Nothing Then
                dr("duracion_destino") = aviso.OrdenDestino.Duracion
            End If
            If Not aviso.OrdenDestino.Hora Is Nothing Then
                dr("hora_destino") = aviso.OrdenDestino.Hora
            End If
            If Not aviso.OrdenDestino.Minuto Is Nothing Then
                dr("minuto_destino") = aviso.OrdenDestino.Minuto
            End If
            If Not aviso.OrdenDestino.Neto Is Nothing Then
                dr("neto_destino") = Double.Parse(aviso.OrdenDestino.Neto.ToString)
            End If
            dr("cod_estado") = aviso.CodigoEstado
            If Not aviso.Observaciones Is Nothing Then
                dr("observaciones") = aviso.Observaciones
            End If

            dtAvisos.Rows.Add(dr)
        Next

        dsAvisos.Tables.Add(dtAvisos)

        Return dsAvisos
    End Function

    Private Sub ArmarEstructuraAvisosNoConfirmados(ByRef dtPresupuestos As DataTable)

        dtPresupuestos.Columns.Add("orden_origen", GetType(Double))
        dtPresupuestos.Columns.Add("cod_soporte_origen", GetType(Integer))
        dtPresupuestos.Columns.Add("soporte_origen", GetType(String))
        dtPresupuestos.Columns.Add("programa_origen", GetType(String))
        dtPresupuestos.Columns.Add("fecha_origen", GetType(DateTime))
        dtPresupuestos.Columns.Add("duracion_origen", GetType(Integer))
        dtPresupuestos.Columns.Add("hora_origen", GetType(Integer))
        dtPresupuestos.Columns.Add("minuto_origen", GetType(Integer))
        dtPresupuestos.Columns.Add("neto_origen", GetType(Double))
        dtPresupuestos.Columns.Add("orden_destino", GetType(Double))
        dtPresupuestos.Columns.Add("cod_soporte_destino", GetType(Integer))
        dtPresupuestos.Columns.Add("soporte_destino", GetType(String))
        dtPresupuestos.Columns.Add("programa_destino", GetType(String))
        dtPresupuestos.Columns.Add("fecha_destino", GetType(DateTime))
        dtPresupuestos.Columns.Add("duracion_destino", GetType(Integer))
        dtPresupuestos.Columns.Add("hora_destino", GetType(Integer))
        dtPresupuestos.Columns.Add("minuto_destino", GetType(Integer))
        dtPresupuestos.Columns.Add("neto_destino", GetType(Double))
        dtPresupuestos.Columns.Add("cod_estado", GetType(String))
        dtPresupuestos.Columns.Add("observaciones", GetType(String))
        'AG 27/02/2013 +++++++++++++++++++++++++++++++++
        dtPresupuestos.Columns.Add("material", GetType(String))
        '++++++++++++++++++++++++++++++++++++++++++++
        dtPresupuestos.AcceptChanges()

    End Sub

    Private Function ObtenerOrdenesMatcheo(ByVal codPresupuesto As Double) As DataSet
        Dim ControlMatcheo As New Control_Macheo
        Dim dsOrdenes As New DataSet
        Dim dtOrdenes As New DataTable
        Dim lAvisosSE As New SolutionEntityList(Of OrdenMatcheo)
        Dim lAvisos As New List(Of OrdenMatcheo)
        Dim dr As DataRow
        Dim aviso As New OrdenMatcheo

        ArmarEstructuraOrdenesMatcheo(dtOrdenes)

        'lAvisos = ControlMatcheo.BuscarAvisosNoConfirmados(Activo.IDCompaniaMMS, Integer.Parse(codPresupuesto.ToString))

        For index As Integer = 0 To lAvisosSE.Count - 1
            aviso = lAvisosSE.Item(index)

            dr = dtOrdenes.NewRow

            dr("ORDEN") = aviso.CodigoOrden
            dr("COD_CLIENTE") = aviso.CodigoCliente
            dr("DES_CLIENTE") = aviso.DescripcionCliente
            dr("COD_SOPORTE") = aviso.CodigoSoporte
            dr("SOPORTE") = aviso.DescripcionSoporte
            dr("PROGRAMA") = aviso.Programa
            dr("FECHA") = aviso.fechaEjecucion.Value
            dr("DURACION") = aviso.Duracion
            dr("HORA") = aviso.Hora
            dr("MIN") = aviso.Minuto
            dr("NETO") = Double.Parse(aviso.Neto.Value.ToString())

            dtOrdenes.Rows.Add(dr)
        Next

        dsOrdenes.Tables.Add(dtOrdenes)

        Return dsOrdenes
    End Function

    Private Sub ArmarEstructuraOrdenesMatcheo(ByRef dtOrdenes As DataTable)

        dtOrdenes.Columns.Add("ORDEN", GetType(Double))
        dtOrdenes.Columns.Add("COD_CLIENTE", GetType(Integer))
        dtOrdenes.Columns.Add("DES_CLIENTE", GetType(String))
        dtOrdenes.Columns.Add("COD_SOPORTE", GetType(Integer))
        dtOrdenes.Columns.Add("SOPORTE", GetType(String))
        dtOrdenes.Columns.Add("PROGRAMA", GetType(String))
        dtOrdenes.Columns.Add("FECHA", GetType(DateTime))
        dtOrdenes.Columns.Add("DURACION", GetType(Integer))
        dtOrdenes.Columns.Add("HORA", GetType(Integer))
        dtOrdenes.Columns.Add("MIN", GetType(Integer))
        dtOrdenes.Columns.Add("NETO", GetType(Double))

        dtOrdenes.AcceptChanges()

    End Sub
#End Region

    Private Sub ugCaidos_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ugCaidos.DoubleClickRow
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub

    Private Sub ugCaidos_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugCaidos.EnabledChanged

    End Sub

    Private Sub ugCaidos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugCaidos.TextChanged
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub

    Private Sub ugCaidos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugCaidos.Validated
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub

    Private Sub ugCaidos_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugCaidos.VisibleChanged
        lblCantidadCaidos.Text = "Cant:" & ugCaidos.Rows.Count
    End Sub
End Class

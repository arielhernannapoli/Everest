Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win
Imports System.Globalization
Imports MSL
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text.RegularExpressions
Imports HM.MMS.AR.Utils
Imports HM.Comun.Varios
Imports HM.Contratos.Entidad.Seguridad
Imports HM.MMS.AR.Client.Reportes
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.ComponentModel.BackgroundWorker
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction



Public Class frmMantenimientoConvenio
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents pnlFiltro As System.Windows.Forms.Panel
    Friend WithEvents grbIngresoParametros As System.Windows.Forms.GroupBox
    Friend WithEvents TxtImporteCompra As QUETOOL.txtTexto
    Friend WithEvents TxtImporteVenta As QUETOOL.txtTexto
    Friend WithEvents lblImporteVenta As System.Windows.Forms.Label
    Friend WithEvents lblImporteCompra As System.Windows.Forms.Label
    Friend WithEvents grbDiaSemana As System.Windows.Forms.GroupBox
    Friend WithEvents ChkSabadoDomingo As QUETOOL.chkCheck
    Friend WithEvents ChkDomingo As QUETOOL.chkCheck
    Friend WithEvents ChkSabado As QUETOOL.chkCheck
    Friend WithEvents ChkViernes As QUETOOL.chkCheck
    Friend WithEvents ChkJueves As QUETOOL.chkCheck
    Friend WithEvents ChkMiercoles As QUETOOL.chkCheck
    Friend WithEvents ChkLunesViernes As QUETOOL.chkCheck
    Friend WithEvents ChkMartes As QUETOOL.chkCheck
    Friend WithEvents ChkLunes As QUETOOL.chkCheck
    Friend WithEvents TxtHFin As QUETOOL.txtTexto
    Friend WithEvents lblHoraFin As System.Windows.Forms.Label
    Friend WithEvents TxtHInicio As QUETOOL.txtTexto
    Friend WithEvents lblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents lblDesProducto As System.Windows.Forms.Label
    Friend WithEvents lblDesSoporte As System.Windows.Forms.Label
    Friend WithEvents TxtProducto As QUETOOL.txtTexto
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtCodProducto As QUETOOL.txtTexto
    Friend WithEvents TxtCodSoporte As QUETOOL.txtTexto
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents txtCodCliente As QUETOOL.txtTexto
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents grbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblVigenciaDesde As System.Windows.Forms.Label
    Friend WithEvents DtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents lblVigenciaHasta As System.Windows.Forms.Label
    Friend WithEvents DtpFFin As QUETOOL.dtpFecha
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents TxtDetalle As QUETOOL.txtTexto
    Friend WithEvents lblParticipacion As System.Windows.Forms.Label
    Friend WithEvents lblObsVenta As System.Windows.Forms.Label
    Friend WithEvents lblObsCompra As System.Windows.Forms.Label
    Friend WithEvents lblObsFinanza As System.Windows.Forms.Label
    Friend WithEvents TxtParticipacion As QUETOOL.txtTexto
    Friend WithEvents TxtObsVenta As QUETOOL.txtTexto
    Friend WithEvents TxtObsCompra As QUETOOL.txtTexto
    Friend WithEvents TxtObsFinanza As QUETOOL.txtTexto
    Friend WithEvents lblNroConvenio As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoExtra1 As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoExtra2 As System.Windows.Forms.Label
    Friend WithEvents TxtDescuentoExtra1 As QUETOOL.txtTexto
    Friend WithEvents grbDescuentoVenta As System.Windows.Forms.GroupBox
    Friend WithEvents grbDescuentoCompra As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDctoVenta1 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta2 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta3 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta4 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta5 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoCompra5 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoCompra4 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoCompra3 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoCompra2 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoCompra1 As QUETOOL.txtTexto
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents TxtDescuentoExtra2 As QUETOOL.txtTexto
    Friend WithEvents lblDesCliente As System.Windows.Forms.Label
    Friend WithEvents TxtCodMedio As QUETOOL.txtTexto
    Friend WithEvents cboMedio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TxtNroConvenio As QUETOOL.txtTexto
    Friend WithEvents TxtIdConvenio As QUETOOL.txtTexto
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcpr As QUETOOL.txtTexto
    Friend WithEvents lblcpr As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkConRentabilidad As QUETOOL.chkCheck
    Friend WithEvents ChkSinRentabilidad As QUETOOL.chkCheck
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabPrincipal As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabCampaña As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabSistema As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugConvenios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugConveniosEnviados As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents mpbEnvioMail As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents BackgroundWorkerEnvio As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtUsuariosAutorizados As QUETOOL.txtTexto
    Friend WithEvents UsuariosAprobador As System.Windows.Forms.Label
    Friend WithEvents lnkAnexos As System.Windows.Forms.LinkLabel
    Friend WithEvents cboTipoSoporte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Medio", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Soporte", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Cliente", 2)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Producto", 3)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Convenio", 4)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fec_Inicio", 5)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fec_Fin", 6)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle", 7)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Participacion", 8)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programa", 9)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_1", 10)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_2", 11)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_3", 12)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_4", 13)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_5", 14)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_1", 15)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_2", 16)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_3", 17)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_4", 18)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_5", 19)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Extra_1", 20)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Extra_2", 21)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imp_Neto_Venta", 22)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imp_Neto_Compra", 23)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Compra", 24)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Venta", 25)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Finanzas", 26)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana", 27)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Convenio", 28)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora_Inicio", 29)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora_Fin", 30)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Convenio", 31)
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
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Medio", 0)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Soporte", 1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Cliente", 2)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Producto", 3)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Convenio", 4)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fec_Inicio", 5)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fec_Fin", 6)
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Detalle", 7)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Participacion", 8)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Programa", 9)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_1", 10)
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_2", 11)
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_3", 12)
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_4", 13)
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Venta_5", 14)
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_1", 15)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_2", 16)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_3", 17)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_4", 18)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Compra_5", 19)
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Extra_1", 20)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desc_Extra_2", 21)
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imp_Neto_Venta", 22)
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imp_Neto_Compra", 23)
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Compra", 24)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Venta", 25)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Obs_Finanzas", 26)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana", 27)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Convenio", 28)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora_Inicio", 29)
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora_Fin", 30)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Convenio", 31)
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoConvenio))
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("uToolbar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("NuevoComo")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Grabar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mostrar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("NuevoComo")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Grabar")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Limpiar")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Salir")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Mostrar")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.tabCampaña = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugConvenios = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.tabSistema = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ugConveniosEnviados = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtMensaje = New System.Windows.Forms.RichTextBox
        Me.pnlFiltro = New System.Windows.Forms.Panel
        Me.grbDatos = New System.Windows.Forms.GroupBox
        Me.lnkAnexos = New System.Windows.Forms.LinkLabel
        Me.mpbEnvioMail = New DevExpress.XtraEditors.MarqueeProgressBarControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkConRentabilidad = New QUETOOL.chkCheck
        Me.ChkSinRentabilidad = New QUETOOL.chkCheck
        Me.txtcpr = New QUETOOL.txtTexto
        Me.lblcpr = New System.Windows.Forms.Label
        Me.TxtIdConvenio = New QUETOOL.txtTexto
        Me.TxtNroConvenio = New QUETOOL.txtTexto
        Me.TxtDescuentoExtra2 = New QUETOOL.txtTexto
        Me.TxtDescuentoExtra1 = New QUETOOL.txtTexto
        Me.lblDescuentoExtra2 = New System.Windows.Forms.Label
        Me.lblDescuentoExtra1 = New System.Windows.Forms.Label
        Me.lblNroConvenio = New System.Windows.Forms.Label
        Me.TxtObsFinanza = New QUETOOL.txtTexto
        Me.TxtObsCompra = New QUETOOL.txtTexto
        Me.TxtObsVenta = New QUETOOL.txtTexto
        Me.TxtParticipacion = New QUETOOL.txtTexto
        Me.lblObsFinanza = New System.Windows.Forms.Label
        Me.lblObsCompra = New System.Windows.Forms.Label
        Me.lblObsVenta = New System.Windows.Forms.Label
        Me.lblParticipacion = New System.Windows.Forms.Label
        Me.TxtDetalle = New QUETOOL.txtTexto
        Me.lblDetalle = New System.Windows.Forms.Label
        Me.DtpFFin = New QUETOOL.dtpFecha
        Me.lblVigenciaHasta = New System.Windows.Forms.Label
        Me.DtpFInicio = New QUETOOL.dtpFecha
        Me.lblVigenciaDesde = New System.Windows.Forms.Label
        Me.grbIngresoParametros = New System.Windows.Forms.GroupBox
        Me.txtUsuariosAutorizados = New QUETOOL.txtTexto
        Me.UsuariosAprobador = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grbDescuentoCompra = New System.Windows.Forms.GroupBox
        Me.TxtDctoCompra5 = New QUETOOL.txtTexto
        Me.TxtDctoCompra4 = New QUETOOL.txtTexto
        Me.TxtDctoCompra3 = New QUETOOL.txtTexto
        Me.TxtDctoCompra2 = New QUETOOL.txtTexto
        Me.TxtDctoCompra1 = New QUETOOL.txtTexto
        Me.cboTipoSoporte = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.grbDescuentoVenta = New System.Windows.Forms.GroupBox
        Me.TxtDctoVenta5 = New QUETOOL.txtTexto
        Me.TxtDctoVenta4 = New QUETOOL.txtTexto
        Me.TxtDctoVenta3 = New QUETOOL.txtTexto
        Me.TxtDctoVenta2 = New QUETOOL.txtTexto
        Me.TxtDctoVenta1 = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboMedio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.TxtCodMedio = New QUETOOL.txtTexto
        Me.lblDesCliente = New System.Windows.Forms.Label
        Me.TxtImporteCompra = New QUETOOL.txtTexto
        Me.TxtImporteVenta = New QUETOOL.txtTexto
        Me.lblImporteVenta = New System.Windows.Forms.Label
        Me.lblImporteCompra = New System.Windows.Forms.Label
        Me.grbDiaSemana = New System.Windows.Forms.GroupBox
        Me.ChkSabadoDomingo = New QUETOOL.chkCheck
        Me.ChkDomingo = New QUETOOL.chkCheck
        Me.ChkSabado = New QUETOOL.chkCheck
        Me.ChkViernes = New QUETOOL.chkCheck
        Me.ChkJueves = New QUETOOL.chkCheck
        Me.ChkMiercoles = New QUETOOL.chkCheck
        Me.ChkLunesViernes = New QUETOOL.chkCheck
        Me.ChkMartes = New QUETOOL.chkCheck
        Me.ChkLunes = New QUETOOL.chkCheck
        Me.TxtHFin = New QUETOOL.txtTexto
        Me.lblHoraFin = New System.Windows.Forms.Label
        Me.TxtHInicio = New QUETOOL.txtTexto
        Me.lblHoraInicio = New System.Windows.Forms.Label
        Me.lblDesProducto = New System.Windows.Forms.Label
        Me.lblDesSoporte = New System.Windows.Forms.Label
        Me.TxtProducto = New QUETOOL.txtTexto
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.TxtCodProducto = New QUETOOL.txtTexto
        Me.TxtCodSoporte = New QUETOOL.txtTexto
        Me.lblProducto = New System.Windows.Forms.Label
        Me.lblSoporte = New System.Windows.Forms.Label
        Me.lblMedio = New System.Windows.Forms.Label
        Me.txtCliente = New QUETOOL.txtTexto
        Me.txtCodCliente = New QUETOOL.txtTexto
        Me.lblCliente = New System.Windows.Forms.Label
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.tabPrincipal = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.BackgroundWorkerEnvio = New System.ComponentModel.BackgroundWorker
        Me.tabCampaña.SuspendLayout()
        CType(Me.ugConvenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSistema.SuspendLayout()
        CType(Me.ugConveniosEnviados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltro.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        CType(Me.mpbEnvioMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbIngresoParametros.SuspendLayout()
        Me.grbDescuentoCompra.SuspendLayout()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDescuentoVenta.SuspendLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDiaSemana.SuspendLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCampaña
        '
        Me.tabCampaña.Controls.Add(Me.ugConvenios)
        Me.tabCampaña.Controls.Add(Me.Splitter2)
        Me.tabCampaña.Location = New System.Drawing.Point(1, 20)
        Me.tabCampaña.Name = "tabCampaña"
        Me.tabCampaña.Size = New System.Drawing.Size(1244, 321)
        '
        'ugConvenios
        '
        Me.ugConvenios.Anchor = System.Windows.Forms.AnchorStyles.None
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugConvenios.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.DataType = GetType(Integer)
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.DataType = GetType(Integer)
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.DataType = GetType(Integer)
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.DataType = GetType(Integer)
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.DataType = GetType(Integer)
        UltraGridColumn5.Header.Caption = "Convenio"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance3
        UltraGridColumn6.DataType = GetType(Date)
        UltraGridColumn6.Header.Caption = "Vigente Desde"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaskInput = "dd/mm/yyyy"
        UltraGridColumn6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn6.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance4
        UltraGridColumn7.DataType = GetType(Date)
        UltraGridColumn7.Header.Caption = "Vigente Hasta"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskInput = "dd/mm/yyyy"
        UltraGridColumn7.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn7.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn11.CellAppearance = Appearance5
        UltraGridColumn11.DataType = GetType(Double)
        UltraGridColumn11.Format = ""
        UltraGridColumn11.Header.Caption = "Dcto. Vta 1"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn11.MaskInput = "nnn.nn"
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn12.CellAppearance = Appearance6
        UltraGridColumn12.DataType = GetType(Double)
        UltraGridColumn12.Header.Caption = "Dcto. Vta 2"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn12.MaskInput = "nnn.nn"
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn13.CellAppearance = Appearance7
        UltraGridColumn13.DataType = GetType(Double)
        UltraGridColumn13.Header.Caption = "Dcto. Vta 3"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn13.MaskInput = "nnn.nn"
        UltraGridColumn13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn13.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellAppearance = Appearance8
        UltraGridColumn14.DataType = GetType(Double)
        UltraGridColumn14.Header.Caption = "Dcto. Vta 4"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn14.MaskInput = "nnn.nn"
        UltraGridColumn14.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn14.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance9
        UltraGridColumn15.DataType = GetType(Double)
        UltraGridColumn15.Header.Caption = "Dcto. Vta 5"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn15.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn15.MaskInput = "nnn.nn"
        UltraGridColumn15.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn15.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn21.DataType = GetType(Double)
        UltraGridColumn21.Header.Caption = "Dcto. Extra 1"
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn21.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn21.MaskInput = "nnn.nn"
        UltraGridColumn21.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn21.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn22.CellAppearance = Appearance10
        UltraGridColumn22.DataType = GetType(Double)
        UltraGridColumn22.Header.Caption = "Dcto. Extra 2"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn22.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn22.MaskInput = "nnn.nn"
        UltraGridColumn22.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn22.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn23.CellAppearance = Appearance11
        UltraGridColumn23.DataType = GetType(Double)
        UltraGridColumn23.Header.Caption = "Importe Venta"
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn23.MaskInput = "$ nnnnnnnnn.nn"
        UltraGridColumn23.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn23.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn24.CellAppearance = Appearance12
        UltraGridColumn24.DataType = GetType(Double)
        UltraGridColumn24.Header.Caption = "Importe Compra"
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn24.MaskInput = "$ nnnnnnnnn.nn"
        UltraGridColumn24.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn24.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn29.DataType = GetType(Integer)
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.CellAppearance = Appearance13
        UltraGridColumn30.Header.Caption = "Hora Inicio"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.MaskInput = ""
        UltraGridColumn30.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn30.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.CellAppearance = Appearance14
        UltraGridColumn31.Header.Caption = "Hora Fin"
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.MaskInput = ""
        UltraGridColumn31.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn31.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        UltraGridBand1.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand1.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand1.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        UltraGridBand1.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand1.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand1.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand1.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand1.Override.HeaderAppearance = Appearance15
        Me.ugConvenios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugConvenios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugConvenios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConvenios.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.ugConvenios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugConvenios.DisplayLayout.GroupByBox.Hidden = True
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance18.BackColor2 = System.Drawing.SystemColors.Control
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConvenios.DisplayLayout.GroupByBox.PromptAppearance = Appearance18
        Me.ugConvenios.DisplayLayout.MaxColScrollRegions = 1
        Me.ugConvenios.DisplayLayout.MaxRowScrollRegions = 1
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugConvenios.DisplayLayout.Override.ActiveCellAppearance = Appearance19
        Appearance20.BackColor = System.Drawing.SystemColors.Highlight
        Appearance20.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugConvenios.DisplayLayout.Override.ActiveRowAppearance = Appearance20
        Me.ugConvenios.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ugConvenios.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugConvenios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugConvenios.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugConvenios.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugConvenios.DisplayLayout.Override.CellAppearance = Appearance22
        Me.ugConvenios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugConvenios.DisplayLayout.Override.CellPadding = 0
        Appearance23.BackColor = System.Drawing.SystemColors.Control
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConvenios.DisplayLayout.Override.GroupByRowAppearance = Appearance23
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugConvenios.DisplayLayout.Override.HeaderAppearance = Appearance24
        Me.ugConvenios.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Me.ugConvenios.DisplayLayout.Override.RowAppearance = Appearance25
        Me.ugConvenios.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.HideFilteredOutRows
        Me.ugConvenios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConvenios.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugConvenios.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugConvenios.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        Me.ugConvenios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugConvenios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugConvenios.FlatMode = True
        Me.ugConvenios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugConvenios.Location = New System.Drawing.Point(7, 6)
        Me.ugConvenios.Name = "ugConvenios"
        Me.ugConvenios.Size = New System.Drawing.Size(1228, 313)
        Me.ugConvenios.TabIndex = 49
        Me.ugConvenios.TabStop = False
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(1241, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 321)
        Me.Splitter2.TabIndex = 48
        Me.Splitter2.TabStop = False
        '
        'tabSistema
        '
        Me.tabSistema.Controls.Add(Me.ugConveniosEnviados)
        Me.tabSistema.Controls.Add(Me.txtMensaje)
        Me.tabSistema.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabSistema.Name = "tabSistema"
        Me.tabSistema.Size = New System.Drawing.Size(1244, 321)
        '
        'ugConveniosEnviados
        '
        Me.ugConveniosEnviados.Anchor = System.Windows.Forms.AnchorStyles.None
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugConveniosEnviados.DisplayLayout.Appearance = Appearance27
        UltraGridColumn33.DataType = GetType(Integer)
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.DataType = GetType(Integer)
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.DataType = GetType(Integer)
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.DataType = GetType(Integer)
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn36.Hidden = True
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn37.CellAppearance = Appearance28
        UltraGridColumn37.DataType = GetType(Integer)
        UltraGridColumn37.Header.Caption = "Convenio"
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.CellAppearance = Appearance29
        UltraGridColumn38.DataType = GetType(Date)
        UltraGridColumn38.Header.Caption = "Vigente Desde"
        UltraGridColumn38.Header.VisiblePosition = 5
        UltraGridColumn38.MaskInput = "dd/mm/yyyy"
        UltraGridColumn38.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn38.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.CellAppearance = Appearance30
        UltraGridColumn39.DataType = GetType(Date)
        UltraGridColumn39.Header.Caption = "Vigente Hasta"
        UltraGridColumn39.Header.VisiblePosition = 6
        UltraGridColumn39.MaskInput = "dd/mm/yyyy"
        UltraGridColumn39.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn39.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn40.Header.VisiblePosition = 7
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 8
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 9
        UltraGridColumn42.Hidden = True
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn43.CellAppearance = Appearance31
        UltraGridColumn43.DataType = GetType(Double)
        UltraGridColumn43.Format = ""
        UltraGridColumn43.Header.Caption = "Dcto. Vta 1"
        UltraGridColumn43.Header.VisiblePosition = 10
        UltraGridColumn43.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn43.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn43.MaskInput = "nnn.nn"
        UltraGridColumn43.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn43.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn44.CellAppearance = Appearance32
        UltraGridColumn44.DataType = GetType(Double)
        UltraGridColumn44.Header.Caption = "Dcto. Vta 2"
        UltraGridColumn44.Header.VisiblePosition = 11
        UltraGridColumn44.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn44.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn44.MaskInput = "nnn.nn"
        UltraGridColumn44.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn44.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn45.CellAppearance = Appearance33
        UltraGridColumn45.DataType = GetType(Double)
        UltraGridColumn45.Header.Caption = "Dcto. Vta 3"
        UltraGridColumn45.Header.VisiblePosition = 12
        UltraGridColumn45.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn45.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn45.MaskInput = "nnn.nn"
        UltraGridColumn45.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn45.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn46.CellAppearance = Appearance34
        UltraGridColumn46.DataType = GetType(Double)
        UltraGridColumn46.Header.Caption = "Dcto. Vta 4"
        UltraGridColumn46.Header.VisiblePosition = 13
        UltraGridColumn46.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn46.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn46.MaskInput = "nnn.nn"
        UltraGridColumn46.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn46.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn47.CellAppearance = Appearance35
        UltraGridColumn47.DataType = GetType(Double)
        UltraGridColumn47.Header.Caption = "Dcto. Vta 5"
        UltraGridColumn47.Header.VisiblePosition = 14
        UltraGridColumn47.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn47.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn47.MaskInput = "nnn.nn"
        UltraGridColumn47.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn47.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn48.Header.VisiblePosition = 15
        UltraGridColumn49.Header.VisiblePosition = 16
        UltraGridColumn50.Header.VisiblePosition = 17
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn52.Header.VisiblePosition = 19
        UltraGridColumn53.DataType = GetType(Double)
        UltraGridColumn53.Header.Caption = "Dcto. Extra 1"
        UltraGridColumn53.Header.VisiblePosition = 20
        UltraGridColumn53.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn53.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn53.MaskInput = "nnn.nn"
        UltraGridColumn53.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn53.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn54.CellAppearance = Appearance36
        UltraGridColumn54.DataType = GetType(Double)
        UltraGridColumn54.Header.Caption = "Dcto. Extra 2"
        UltraGridColumn54.Header.VisiblePosition = 21
        UltraGridColumn54.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn54.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        UltraGridColumn54.MaskInput = "nnn.nn"
        UltraGridColumn54.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn54.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn55.CellAppearance = Appearance37
        UltraGridColumn55.DataType = GetType(Double)
        UltraGridColumn55.Header.Caption = "Importe Venta"
        UltraGridColumn55.Header.VisiblePosition = 22
        UltraGridColumn55.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn55.MaskInput = "$ nnnnnnnnn.nn"
        UltraGridColumn55.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn55.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn56.CellAppearance = Appearance38
        UltraGridColumn56.DataType = GetType(Double)
        UltraGridColumn56.Header.Caption = "Importe Compra"
        UltraGridColumn56.Header.VisiblePosition = 23
        UltraGridColumn56.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn56.MaskInput = "$ nnnnnnnnn.nn"
        UltraGridColumn56.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn56.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn57.Header.VisiblePosition = 24
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 25
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 26
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 27
        UltraGridColumn60.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn61.DataType = GetType(Integer)
        UltraGridColumn61.Header.VisiblePosition = 28
        UltraGridColumn61.Hidden = True
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.CellAppearance = Appearance39
        UltraGridColumn62.Header.Caption = "Hora Inicio"
        UltraGridColumn62.Header.VisiblePosition = 29
        UltraGridColumn62.MaskInput = ""
        UltraGridColumn62.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn62.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.CellAppearance = Appearance40
        UltraGridColumn63.Header.Caption = "Hora Fin"
        UltraGridColumn63.Header.VisiblePosition = 30
        UltraGridColumn63.MaskInput = ""
        UltraGridColumn63.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn63.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn64.Header.VisiblePosition = 31
        UltraGridColumn64.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand2.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        UltraGridBand2.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        UltraGridBand2.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        UltraGridBand2.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand2.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        UltraGridBand2.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        UltraGridBand2.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand2.Override.HeaderAppearance = Appearance41
        Me.ugConveniosEnviados.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugConveniosEnviados.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugConveniosEnviados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConveniosEnviados.DisplayLayout.GroupByBox.Appearance = Appearance42
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConveniosEnviados.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance43
        Me.ugConveniosEnviados.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugConveniosEnviados.DisplayLayout.GroupByBox.Hidden = True
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance44.BackColor2 = System.Drawing.SystemColors.Control
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugConveniosEnviados.DisplayLayout.GroupByBox.PromptAppearance = Appearance44
        Me.ugConveniosEnviados.DisplayLayout.MaxColScrollRegions = 1
        Me.ugConveniosEnviados.DisplayLayout.MaxRowScrollRegions = 1
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Appearance45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugConveniosEnviados.DisplayLayout.Override.ActiveCellAppearance = Appearance45
        Appearance46.BackColor = System.Drawing.SystemColors.Highlight
        Appearance46.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugConveniosEnviados.DisplayLayout.Override.ActiveRowAppearance = Appearance46
        Me.ugConveniosEnviados.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.ugConveniosEnviados.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ugConveniosEnviados.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.ugConveniosEnviados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugConveniosEnviados.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Me.ugConveniosEnviados.DisplayLayout.Override.CardAreaAppearance = Appearance47
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Appearance48.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugConveniosEnviados.DisplayLayout.Override.CellAppearance = Appearance48
        Me.ugConveniosEnviados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugConveniosEnviados.DisplayLayout.Override.CellPadding = 0
        Appearance49.BackColor = System.Drawing.SystemColors.Control
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.ugConveniosEnviados.DisplayLayout.Override.GroupByRowAppearance = Appearance49
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Left
        Me.ugConveniosEnviados.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.ugConveniosEnviados.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance51.BackColor = System.Drawing.SystemColors.Window
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Me.ugConveniosEnviados.DisplayLayout.Override.RowAppearance = Appearance51
        Me.ugConveniosEnviados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugConveniosEnviados.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.ugConveniosEnviados.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugConveniosEnviados.DisplayLayout.Override.TemplateAddRowAppearance = Appearance52
        Me.ugConveniosEnviados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugConveniosEnviados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugConveniosEnviados.FlatMode = True
        Me.ugConveniosEnviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugConveniosEnviados.Location = New System.Drawing.Point(5, 2)
        Me.ugConveniosEnviados.Name = "ugConveniosEnviados"
        Me.ugConveniosEnviados.Size = New System.Drawing.Size(1236, 317)
        Me.ugConveniosEnviados.TabIndex = 10
        Me.ugConveniosEnviados.TabStop = False
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Location = New System.Drawing.Point(378, 115)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(469, 93)
        Me.txtMensaje.TabIndex = 9
        Me.txtMensaje.Text = ""
        '
        'pnlFiltro
        '
        Me.pnlFiltro.Controls.Add(Me.grbDatos)
        Me.pnlFiltro.Controls.Add(Me.grbIngresoParametros)
        Me.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltro.Location = New System.Drawing.Point(0, 24)
        Me.pnlFiltro.Name = "pnlFiltro"
        Me.pnlFiltro.Size = New System.Drawing.Size(1246, 279)
        Me.pnlFiltro.TabIndex = 1
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lnkAnexos)
        Me.grbDatos.Controls.Add(Me.mpbEnvioMail)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Controls.Add(Me.ChkConRentabilidad)
        Me.grbDatos.Controls.Add(Me.ChkSinRentabilidad)
        Me.grbDatos.Controls.Add(Me.txtcpr)
        Me.grbDatos.Controls.Add(Me.lblcpr)
        Me.grbDatos.Controls.Add(Me.TxtIdConvenio)
        Me.grbDatos.Controls.Add(Me.TxtNroConvenio)
        Me.grbDatos.Controls.Add(Me.TxtDescuentoExtra2)
        Me.grbDatos.Controls.Add(Me.TxtDescuentoExtra1)
        Me.grbDatos.Controls.Add(Me.lblDescuentoExtra2)
        Me.grbDatos.Controls.Add(Me.lblDescuentoExtra1)
        Me.grbDatos.Controls.Add(Me.lblNroConvenio)
        Me.grbDatos.Controls.Add(Me.TxtObsFinanza)
        Me.grbDatos.Controls.Add(Me.TxtObsCompra)
        Me.grbDatos.Controls.Add(Me.TxtObsVenta)
        Me.grbDatos.Controls.Add(Me.TxtParticipacion)
        Me.grbDatos.Controls.Add(Me.lblObsFinanza)
        Me.grbDatos.Controls.Add(Me.lblObsCompra)
        Me.grbDatos.Controls.Add(Me.lblObsVenta)
        Me.grbDatos.Controls.Add(Me.lblParticipacion)
        Me.grbDatos.Controls.Add(Me.TxtDetalle)
        Me.grbDatos.Controls.Add(Me.lblDetalle)
        Me.grbDatos.Controls.Add(Me.DtpFFin)
        Me.grbDatos.Controls.Add(Me.lblVigenciaHasta)
        Me.grbDatos.Controls.Add(Me.DtpFInicio)
        Me.grbDatos.Controls.Add(Me.lblVigenciaDesde)
        Me.grbDatos.Location = New System.Drawing.Point(695, 6)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(540, 273)
        Me.grbDatos.TabIndex = 103
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos del Convenio"
        '
        'lnkAnexos
        '
        Me.lnkAnexos.AutoSize = True
        Me.lnkAnexos.Location = New System.Drawing.Point(7, 253)
        Me.lnkAnexos.Name = "lnkAnexos"
        Me.lnkAnexos.Size = New System.Drawing.Size(83, 13)
        Me.lnkAnexos.TabIndex = 132
        Me.lnkAnexos.TabStop = True
        Me.lnkAnexos.Text = "Anexar archivos"
        '
        'mpbEnvioMail
        '
        Me.mpbEnvioMail.EditValue = 0
        Me.mpbEnvioMail.Location = New System.Drawing.Point(279, 249)
        Me.mpbEnvioMail.Name = "mpbEnvioMail"
        Me.mpbEnvioMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.mpbEnvioMail.Properties.EndColor = System.Drawing.Color.Maroon
        Me.mpbEnvioMail.Properties.StartColor = System.Drawing.Color.Maroon
        Me.mpbEnvioMail.Size = New System.Drawing.Size(247, 18)
        Me.mpbEnvioMail.TabIndex = 131
        Me.mpbEnvioMail.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Tipo Confidencial :"
        '
        'ChkConRentabilidad
        '
        Me.ChkConRentabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkConRentabilidad.Location = New System.Drawing.Point(213, 96)
        Me.ChkConRentabilidad.Name = "ChkConRentabilidad"
        Me.ChkConRentabilidad.Size = New System.Drawing.Size(112, 20)
        Me.ChkConRentabilidad.TabIndex = 129
        Me.ChkConRentabilidad.Text = "Con Rentabilidad"
        '
        'ChkSinRentabilidad
        '
        Me.ChkSinRentabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSinRentabilidad.Location = New System.Drawing.Point(105, 96)
        Me.ChkSinRentabilidad.Name = "ChkSinRentabilidad"
        Me.ChkSinRentabilidad.Size = New System.Drawing.Size(104, 20)
        Me.ChkSinRentabilidad.TabIndex = 128
        Me.ChkSinRentabilidad.Text = "Sin Rentabilidad"
        '
        'txtcpr
        '
        Me.txtcpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcpr.ConDecimal = False
        Me.txtcpr.Location = New System.Drawing.Point(427, 17)
        Me.txtcpr.Maximo = 0
        Me.txtcpr.MaxLength = 6
        Me.txtcpr.Name = "txtcpr"
        Me.txtcpr.Size = New System.Drawing.Size(56, 20)
        Me.txtcpr.SoloLetra = False
        Me.txtcpr.SoloNumero = False
        Me.txtcpr.TabIndex = 126
        Me.txtcpr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblcpr
        '
        Me.lblcpr.Location = New System.Drawing.Point(386, 21)
        Me.lblcpr.Name = "lblcpr"
        Me.lblcpr.Size = New System.Drawing.Size(92, 13)
        Me.lblcpr.TabIndex = 127
        Me.lblcpr.Text = "CPR:"
        '
        'TxtIdConvenio
        '
        Me.TxtIdConvenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdConvenio.ConDecimal = False
        Me.TxtIdConvenio.Location = New System.Drawing.Point(160, 70)
        Me.TxtIdConvenio.Maximo = 0
        Me.TxtIdConvenio.Name = "TxtIdConvenio"
        Me.TxtIdConvenio.ReadOnly = True
        Me.TxtIdConvenio.Size = New System.Drawing.Size(38, 20)
        Me.TxtIdConvenio.SoloLetra = False
        Me.TxtIdConvenio.SoloNumero = False
        Me.TxtIdConvenio.TabIndex = 123
        Me.TxtIdConvenio.TabStop = False
        Me.TxtIdConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIdConvenio.Visible = False
        '
        'TxtNroConvenio
        '
        Me.TxtNroConvenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNroConvenio.ConDecimal = False
        Me.TxtNroConvenio.Location = New System.Drawing.Point(100, 70)
        Me.TxtNroConvenio.Maximo = 0
        Me.TxtNroConvenio.Name = "TxtNroConvenio"
        Me.TxtNroConvenio.ReadOnly = True
        Me.TxtNroConvenio.Size = New System.Drawing.Size(56, 20)
        Me.TxtNroConvenio.SoloLetra = False
        Me.TxtNroConvenio.SoloNumero = False
        Me.TxtNroConvenio.TabIndex = 122
        Me.TxtNroConvenio.TabStop = False
        Me.TxtNroConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescuentoExtra2
        '
        Me.TxtDescuentoExtra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescuentoExtra2.ConDecimal = False
        Me.TxtDescuentoExtra2.Location = New System.Drawing.Point(325, 40)
        Me.TxtDescuentoExtra2.Maximo = 0
        Me.TxtDescuentoExtra2.MaxLength = 6
        Me.TxtDescuentoExtra2.Name = "TxtDescuentoExtra2"
        Me.TxtDescuentoExtra2.Size = New System.Drawing.Size(56, 20)
        Me.TxtDescuentoExtra2.SoloLetra = False
        Me.TxtDescuentoExtra2.SoloNumero = False
        Me.TxtDescuentoExtra2.TabIndex = 3
        Me.TxtDescuentoExtra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescuentoExtra1
        '
        Me.TxtDescuentoExtra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescuentoExtra1.ConDecimal = False
        Me.TxtDescuentoExtra1.Location = New System.Drawing.Point(325, 16)
        Me.TxtDescuentoExtra1.Maximo = 0
        Me.TxtDescuentoExtra1.MaxLength = 6
        Me.TxtDescuentoExtra1.Name = "TxtDescuentoExtra1"
        Me.TxtDescuentoExtra1.Size = New System.Drawing.Size(56, 20)
        Me.TxtDescuentoExtra1.SoloLetra = False
        Me.TxtDescuentoExtra1.SoloNumero = False
        Me.TxtDescuentoExtra1.TabIndex = 2
        Me.TxtDescuentoExtra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDescuentoExtra2
        '
        Me.lblDescuentoExtra2.Location = New System.Drawing.Point(203, 44)
        Me.lblDescuentoExtra2.Name = "lblDescuentoExtra2"
        Me.lblDescuentoExtra2.Size = New System.Drawing.Size(105, 13)
        Me.lblDescuentoExtra2.TabIndex = 119
        Me.lblDescuentoExtra2.Text = "Descuento Extra 2:"
        '
        'lblDescuentoExtra1
        '
        Me.lblDescuentoExtra1.Location = New System.Drawing.Point(203, 19)
        Me.lblDescuentoExtra1.Name = "lblDescuentoExtra1"
        Me.lblDescuentoExtra1.Size = New System.Drawing.Size(105, 13)
        Me.lblDescuentoExtra1.TabIndex = 118
        Me.lblDescuentoExtra1.Text = "Descuento Extra 1:"
        '
        'lblNroConvenio
        '
        Me.lblNroConvenio.Location = New System.Drawing.Point(10, 74)
        Me.lblNroConvenio.Name = "lblNroConvenio"
        Me.lblNroConvenio.Size = New System.Drawing.Size(88, 13)
        Me.lblNroConvenio.TabIndex = 117
        Me.lblNroConvenio.Text = "Nro. Convenio:"
        '
        'TxtObsFinanza
        '
        Me.TxtObsFinanza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObsFinanza.ConDecimal = False
        Me.TxtObsFinanza.Location = New System.Drawing.Point(326, 68)
        Me.TxtObsFinanza.Maximo = 0
        Me.TxtObsFinanza.MaxLength = 80
        Me.TxtObsFinanza.Name = "TxtObsFinanza"
        Me.TxtObsFinanza.Size = New System.Drawing.Size(203, 20)
        Me.TxtObsFinanza.SoloLetra = False
        Me.TxtObsFinanza.SoloNumero = False
        Me.TxtObsFinanza.TabIndex = 8
        '
        'TxtObsCompra
        '
        Me.TxtObsCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObsCompra.ConDecimal = False
        Me.TxtObsCompra.Location = New System.Drawing.Point(104, 225)
        Me.TxtObsCompra.Maximo = 0
        Me.TxtObsCompra.MaxLength = 80
        Me.TxtObsCompra.Name = "TxtObsCompra"
        Me.TxtObsCompra.Size = New System.Drawing.Size(425, 20)
        Me.TxtObsCompra.SoloLetra = False
        Me.TxtObsCompra.SoloNumero = False
        Me.TxtObsCompra.TabIndex = 7
        '
        'TxtObsVenta
        '
        Me.TxtObsVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObsVenta.ConDecimal = False
        Me.TxtObsVenta.Location = New System.Drawing.Point(104, 200)
        Me.TxtObsVenta.Maximo = 0
        Me.TxtObsVenta.MaxLength = 80
        Me.TxtObsVenta.Name = "TxtObsVenta"
        Me.TxtObsVenta.Size = New System.Drawing.Size(425, 20)
        Me.TxtObsVenta.SoloLetra = False
        Me.TxtObsVenta.SoloNumero = False
        Me.TxtObsVenta.TabIndex = 6
        '
        'TxtParticipacion
        '
        Me.TxtParticipacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtParticipacion.ConDecimal = False
        Me.TxtParticipacion.Location = New System.Drawing.Point(104, 175)
        Me.TxtParticipacion.Maximo = 0
        Me.TxtParticipacion.MaxLength = 40
        Me.TxtParticipacion.Name = "TxtParticipacion"
        Me.TxtParticipacion.Size = New System.Drawing.Size(425, 20)
        Me.TxtParticipacion.SoloLetra = False
        Me.TxtParticipacion.SoloNumero = False
        Me.TxtParticipacion.TabIndex = 5
        '
        'lblObsFinanza
        '
        Me.lblObsFinanza.Location = New System.Drawing.Point(204, 71)
        Me.lblObsFinanza.Name = "lblObsFinanza"
        Me.lblObsFinanza.Size = New System.Drawing.Size(122, 18)
        Me.lblObsFinanza.TabIndex = 112
        Me.lblObsFinanza.Text = "Leyenda. Confidencial"
        '
        'lblObsCompra
        '
        Me.lblObsCompra.Location = New System.Drawing.Point(7, 227)
        Me.lblObsCompra.Name = "lblObsCompra"
        Me.lblObsCompra.Size = New System.Drawing.Size(92, 13)
        Me.lblObsCompra.TabIndex = 111
        Me.lblObsCompra.Text = "Obs. de Compra:"
        '
        'lblObsVenta
        '
        Me.lblObsVenta.Location = New System.Drawing.Point(7, 202)
        Me.lblObsVenta.Name = "lblObsVenta"
        Me.lblObsVenta.Size = New System.Drawing.Size(84, 13)
        Me.lblObsVenta.TabIndex = 110
        Me.lblObsVenta.Text = "Obs. de Venta:"
        '
        'lblParticipacion
        '
        Me.lblParticipacion.Location = New System.Drawing.Point(6, 179)
        Me.lblParticipacion.Name = "lblParticipacion"
        Me.lblParticipacion.Size = New System.Drawing.Size(72, 13)
        Me.lblParticipacion.TabIndex = 109
        Me.lblParticipacion.Text = "Participación:"
        '
        'TxtDetalle
        '
        Me.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDetalle.ConDecimal = False
        Me.TxtDetalle.Location = New System.Drawing.Point(59, 122)
        Me.TxtDetalle.Maximo = 0
        Me.TxtDetalle.MaxLength = 550
        Me.TxtDetalle.Multiline = True
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.Size = New System.Drawing.Size(470, 46)
        Me.TxtDetalle.SoloLetra = False
        Me.TxtDetalle.SoloNumero = False
        Me.TxtDetalle.TabIndex = 4
        '
        'lblDetalle
        '
        Me.lblDetalle.Location = New System.Drawing.Point(9, 126)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(44, 13)
        Me.lblDetalle.TabIndex = 107
        Me.lblDetalle.Text = "Detalle:"
        '
        'DtpFFin
        '
        Appearance53.FontData.SizeInPoints = 9.0!
        Me.DtpFFin.Appearance = Appearance53
        Me.DtpFFin.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFFin.FlatMode = True
        Me.DtpFFin.Location = New System.Drawing.Point(100, 45)
        Me.DtpFFin.Name = "DtpFFin"
        Me.DtpFFin.Size = New System.Drawing.Size(98, 21)
        Me.DtpFFin.TabIndex = 1
        Me.DtpFFin.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaHasta
        '
        Me.lblVigenciaHasta.Location = New System.Drawing.Point(10, 49)
        Me.lblVigenciaHasta.Name = "lblVigenciaHasta"
        Me.lblVigenciaHasta.Size = New System.Drawing.Size(88, 13)
        Me.lblVigenciaHasta.TabIndex = 104
        Me.lblVigenciaHasta.Text = "Vigencia Hasta:"
        '
        'DtpFInicio
        '
        Appearance54.FontData.SizeInPoints = 9.0!
        Me.DtpFInicio.Appearance = Appearance54
        Me.DtpFInicio.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpFInicio.FlatMode = True
        Me.DtpFInicio.Location = New System.Drawing.Point(100, 20)
        Me.DtpFInicio.Name = "DtpFInicio"
        Me.DtpFInicio.Size = New System.Drawing.Size(98, 21)
        Me.DtpFInicio.TabIndex = 0
        Me.DtpFInicio.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblVigenciaDesde
        '
        Me.lblVigenciaDesde.Location = New System.Drawing.Point(10, 24)
        Me.lblVigenciaDesde.Name = "lblVigenciaDesde"
        Me.lblVigenciaDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblVigenciaDesde.TabIndex = 102
        Me.lblVigenciaDesde.Text = "Vigencia Desde:"
        '
        'grbIngresoParametros
        '
        Me.grbIngresoParametros.Controls.Add(Me.txtUsuariosAutorizados)
        Me.grbIngresoParametros.Controls.Add(Me.UsuariosAprobador)
        Me.grbIngresoParametros.Controls.Add(Me.Label2)
        Me.grbIngresoParametros.Controls.Add(Me.grbDescuentoCompra)
        Me.grbIngresoParametros.Controls.Add(Me.cboTipoSoporte)
        Me.grbIngresoParametros.Controls.Add(Me.grbDescuentoVenta)
        Me.grbIngresoParametros.Controls.Add(Me.Label5)
        Me.grbIngresoParametros.Controls.Add(Me.cboMedio)
        Me.grbIngresoParametros.Controls.Add(Me.TxtCodMedio)
        Me.grbIngresoParametros.Controls.Add(Me.lblDesCliente)
        Me.grbIngresoParametros.Controls.Add(Me.TxtImporteCompra)
        Me.grbIngresoParametros.Controls.Add(Me.TxtImporteVenta)
        Me.grbIngresoParametros.Controls.Add(Me.lblImporteVenta)
        Me.grbIngresoParametros.Controls.Add(Me.lblImporteCompra)
        Me.grbIngresoParametros.Controls.Add(Me.grbDiaSemana)
        Me.grbIngresoParametros.Controls.Add(Me.TxtHFin)
        Me.grbIngresoParametros.Controls.Add(Me.lblHoraFin)
        Me.grbIngresoParametros.Controls.Add(Me.TxtHInicio)
        Me.grbIngresoParametros.Controls.Add(Me.lblHoraInicio)
        Me.grbIngresoParametros.Controls.Add(Me.lblDesProducto)
        Me.grbIngresoParametros.Controls.Add(Me.lblDesSoporte)
        Me.grbIngresoParametros.Controls.Add(Me.TxtProducto)
        Me.grbIngresoParametros.Controls.Add(Me.TxtSoporte)
        Me.grbIngresoParametros.Controls.Add(Me.TxtCodProducto)
        Me.grbIngresoParametros.Controls.Add(Me.TxtCodSoporte)
        Me.grbIngresoParametros.Controls.Add(Me.lblProducto)
        Me.grbIngresoParametros.Controls.Add(Me.lblSoporte)
        Me.grbIngresoParametros.Controls.Add(Me.lblMedio)
        Me.grbIngresoParametros.Controls.Add(Me.txtCliente)
        Me.grbIngresoParametros.Controls.Add(Me.txtCodCliente)
        Me.grbIngresoParametros.Controls.Add(Me.lblCliente)
        Me.grbIngresoParametros.Location = New System.Drawing.Point(2, 6)
        Me.grbIngresoParametros.Name = "grbIngresoParametros"
        Me.grbIngresoParametros.Size = New System.Drawing.Size(683, 267)
        Me.grbIngresoParametros.TabIndex = 1
        Me.grbIngresoParametros.TabStop = False
        Me.grbIngresoParametros.Text = "Ingreso de Parámetros"
        '
        'txtUsuariosAutorizados
        '
        Me.txtUsuariosAutorizados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuariosAutorizados.ConDecimal = False
        Me.txtUsuariosAutorizados.Enabled = False
        Me.txtUsuariosAutorizados.Location = New System.Drawing.Point(416, 79)
        Me.txtUsuariosAutorizados.Maximo = 0
        Me.txtUsuariosAutorizados.MaxLength = 14
        Me.txtUsuariosAutorizados.Multiline = True
        Me.txtUsuariosAutorizados.Name = "txtUsuariosAutorizados"
        Me.txtUsuariosAutorizados.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtUsuariosAutorizados.Size = New System.Drawing.Size(254, 74)
        Me.txtUsuariosAutorizados.SoloLetra = True
        Me.txtUsuariosAutorizados.SoloNumero = False
        Me.txtUsuariosAutorizados.TabIndex = 134
        '
        'UsuariosAprobador
        '
        Me.UsuariosAprobador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsuariosAprobador.Image = CType(resources.GetObject("UsuariosAprobador.Image"), System.Drawing.Image)
        Me.UsuariosAprobador.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.UsuariosAprobador.Location = New System.Drawing.Point(389, 108)
        Me.UsuariosAprobador.Name = "UsuariosAprobador"
        Me.UsuariosAprobador.Size = New System.Drawing.Size(21, 21)
        Me.UsuariosAprobador.TabIndex = 133
        Me.UsuariosAprobador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(348, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 36)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Usuario Autorizador:"
        '
        'grbDescuentoCompra
        '
        Me.grbDescuentoCompra.Controls.Add(Me.TxtDctoCompra5)
        Me.grbDescuentoCompra.Controls.Add(Me.TxtDctoCompra4)
        Me.grbDescuentoCompra.Controls.Add(Me.TxtDctoCompra3)
        Me.grbDescuentoCompra.Controls.Add(Me.TxtDctoCompra2)
        Me.grbDescuentoCompra.Controls.Add(Me.TxtDctoCompra1)
        Me.grbDescuentoCompra.Location = New System.Drawing.Point(7, 212)
        Me.grbDescuentoCompra.Name = "grbDescuentoCompra"
        Me.grbDescuentoCompra.Size = New System.Drawing.Size(333, 48)
        Me.grbDescuentoCompra.TabIndex = 1
        Me.grbDescuentoCompra.TabStop = False
        Me.grbDescuentoCompra.Text = "Descuentos de Compra"
        '
        'TxtDctoCompra5
        '
        Me.TxtDctoCompra5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoCompra5.ConDecimal = False
        Me.TxtDctoCompra5.Location = New System.Drawing.Point(258, 20)
        Me.TxtDctoCompra5.Maximo = 0
        Me.TxtDctoCompra5.MaxLength = 6
        Me.TxtDctoCompra5.Name = "TxtDctoCompra5"
        Me.TxtDctoCompra5.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoCompra5.SoloLetra = False
        Me.TxtDctoCompra5.SoloNumero = False
        Me.TxtDctoCompra5.TabIndex = 133
        Me.TxtDctoCompra5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoCompra4
        '
        Me.TxtDctoCompra4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoCompra4.ConDecimal = False
        Me.TxtDctoCompra4.Location = New System.Drawing.Point(194, 20)
        Me.TxtDctoCompra4.Maximo = 0
        Me.TxtDctoCompra4.MaxLength = 6
        Me.TxtDctoCompra4.Name = "TxtDctoCompra4"
        Me.TxtDctoCompra4.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoCompra4.SoloLetra = False
        Me.TxtDctoCompra4.SoloNumero = False
        Me.TxtDctoCompra4.TabIndex = 132
        Me.TxtDctoCompra4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoCompra3
        '
        Me.TxtDctoCompra3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoCompra3.ConDecimal = False
        Me.TxtDctoCompra3.Location = New System.Drawing.Point(133, 20)
        Me.TxtDctoCompra3.Maximo = 0
        Me.TxtDctoCompra3.MaxLength = 6
        Me.TxtDctoCompra3.Name = "TxtDctoCompra3"
        Me.TxtDctoCompra3.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoCompra3.SoloLetra = False
        Me.TxtDctoCompra3.SoloNumero = False
        Me.TxtDctoCompra3.TabIndex = 131
        Me.TxtDctoCompra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoCompra2
        '
        Me.TxtDctoCompra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoCompra2.ConDecimal = False
        Me.TxtDctoCompra2.Location = New System.Drawing.Point(72, 20)
        Me.TxtDctoCompra2.Maximo = 0
        Me.TxtDctoCompra2.MaxLength = 6
        Me.TxtDctoCompra2.Name = "TxtDctoCompra2"
        Me.TxtDctoCompra2.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoCompra2.SoloLetra = False
        Me.TxtDctoCompra2.SoloNumero = False
        Me.TxtDctoCompra2.TabIndex = 130
        Me.TxtDctoCompra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoCompra1
        '
        Me.TxtDctoCompra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoCompra1.ConDecimal = False
        Me.TxtDctoCompra1.Location = New System.Drawing.Point(10, 20)
        Me.TxtDctoCompra1.Maximo = 0
        Me.TxtDctoCompra1.MaxLength = 6
        Me.TxtDctoCompra1.Name = "TxtDctoCompra1"
        Me.TxtDctoCompra1.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoCompra1.SoloLetra = False
        Me.TxtDctoCompra1.SoloNumero = False
        Me.TxtDctoCompra1.TabIndex = 129
        Me.TxtDctoCompra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.AutoSize = True
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Location = New System.Drawing.Point(60, 72)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.ReadOnly = True
        Me.cboTipoSoporte.Size = New System.Drawing.Size(252, 19)
        Me.cboTipoSoporte.TabIndex = 4
        '
        'grbDescuentoVenta
        '
        Me.grbDescuentoVenta.Controls.Add(Me.TxtDctoVenta5)
        Me.grbDescuentoVenta.Controls.Add(Me.TxtDctoVenta4)
        Me.grbDescuentoVenta.Controls.Add(Me.TxtDctoVenta3)
        Me.grbDescuentoVenta.Controls.Add(Me.TxtDctoVenta2)
        Me.grbDescuentoVenta.Controls.Add(Me.TxtDctoVenta1)
        Me.grbDescuentoVenta.Location = New System.Drawing.Point(6, 159)
        Me.grbDescuentoVenta.Name = "grbDescuentoVenta"
        Me.grbDescuentoVenta.Size = New System.Drawing.Size(334, 48)
        Me.grbDescuentoVenta.TabIndex = 0
        Me.grbDescuentoVenta.TabStop = False
        Me.grbDescuentoVenta.Text = "Descuentos de Venta"
        '
        'TxtDctoVenta5
        '
        Me.TxtDctoVenta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta5.ConDecimal = False
        Me.TxtDctoVenta5.Location = New System.Drawing.Point(262, 20)
        Me.TxtDctoVenta5.Maximo = 0
        Me.TxtDctoVenta5.MaxLength = 6
        Me.TxtDctoVenta5.Name = "TxtDctoVenta5"
        Me.TxtDctoVenta5.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta5.SoloLetra = False
        Me.TxtDctoVenta5.SoloNumero = False
        Me.TxtDctoVenta5.TabIndex = 128
        Me.TxtDctoVenta5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta4
        '
        Me.TxtDctoVenta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta4.ConDecimal = False
        Me.TxtDctoVenta4.Location = New System.Drawing.Point(199, 20)
        Me.TxtDctoVenta4.Maximo = 0
        Me.TxtDctoVenta4.MaxLength = 6
        Me.TxtDctoVenta4.Name = "TxtDctoVenta4"
        Me.TxtDctoVenta4.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta4.SoloLetra = False
        Me.TxtDctoVenta4.SoloNumero = False
        Me.TxtDctoVenta4.TabIndex = 127
        Me.TxtDctoVenta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta3
        '
        Me.TxtDctoVenta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta3.ConDecimal = False
        Me.TxtDctoVenta3.Location = New System.Drawing.Point(137, 20)
        Me.TxtDctoVenta3.Maximo = 0
        Me.TxtDctoVenta3.MaxLength = 6
        Me.TxtDctoVenta3.Name = "TxtDctoVenta3"
        Me.TxtDctoVenta3.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta3.SoloLetra = False
        Me.TxtDctoVenta3.SoloNumero = False
        Me.TxtDctoVenta3.TabIndex = 126
        Me.TxtDctoVenta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta2
        '
        Me.TxtDctoVenta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta2.ConDecimal = False
        Me.TxtDctoVenta2.Location = New System.Drawing.Point(73, 20)
        Me.TxtDctoVenta2.Maximo = 0
        Me.TxtDctoVenta2.MaxLength = 6
        Me.TxtDctoVenta2.Name = "TxtDctoVenta2"
        Me.TxtDctoVenta2.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta2.SoloLetra = False
        Me.TxtDctoVenta2.SoloNumero = False
        Me.TxtDctoVenta2.TabIndex = 125
        Me.TxtDctoVenta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta1
        '
        Me.TxtDctoVenta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta1.ConDecimal = False
        Me.TxtDctoVenta1.Location = New System.Drawing.Point(10, 20)
        Me.TxtDctoVenta1.Maximo = 0
        Me.TxtDctoVenta1.MaxLength = 6
        Me.TxtDctoVenta1.Name = "TxtDctoVenta1"
        Me.TxtDctoVenta1.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta1.SoloLetra = False
        Me.TxtDctoVenta1.SoloNumero = False
        Me.TxtDctoVenta1.TabIndex = 124
        Me.TxtDctoVenta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "T. Soporte"
        '
        'cboMedio
        '
        Me.cboMedio.AutoSize = True
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.FlatMode = True
        Me.cboMedio.Location = New System.Drawing.Point(104, 48)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(208, 19)
        Me.cboMedio.TabIndex = 3
        '
        'TxtCodMedio
        '
        Me.TxtCodMedio.AcceptsReturn = True
        Me.TxtCodMedio.AcceptsTab = True
        Me.TxtCodMedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodMedio.ConDecimal = False
        Me.TxtCodMedio.Location = New System.Drawing.Point(60, 48)
        Me.TxtCodMedio.Maximo = 0
        Me.TxtCodMedio.MaxLength = 5
        Me.TxtCodMedio.Name = "TxtCodMedio"
        Me.TxtCodMedio.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodMedio.SoloLetra = False
        Me.TxtCodMedio.SoloNumero = True
        Me.TxtCodMedio.TabIndex = 2
        '
        'lblDesCliente
        '
        Me.lblDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesCliente.Image = CType(resources.GetObject("lblDesCliente.Image"), System.Drawing.Image)
        Me.lblDesCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesCliente.Location = New System.Drawing.Point(316, 24)
        Me.lblDesCliente.Name = "lblDesCliente"
        Me.lblDesCliente.Size = New System.Drawing.Size(21, 21)
        Me.lblDesCliente.TabIndex = 1
        Me.lblDesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtImporteCompra
        '
        Me.TxtImporteCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtImporteCompra.ConDecimal = False
        Me.TxtImporteCompra.Location = New System.Drawing.Point(592, 51)
        Me.TxtImporteCompra.Maximo = 0
        Me.TxtImporteCompra.MaxLength = 14
        Me.TxtImporteCompra.Name = "TxtImporteCompra"
        Me.TxtImporteCompra.Size = New System.Drawing.Size(70, 20)
        Me.TxtImporteCompra.SoloLetra = False
        Me.TxtImporteCompra.SoloNumero = False
        Me.TxtImporteCompra.TabIndex = 11
        Me.TxtImporteCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImporteVenta
        '
        Me.TxtImporteVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtImporteVenta.ConDecimal = False
        Me.TxtImporteVenta.Location = New System.Drawing.Point(428, 49)
        Me.TxtImporteVenta.Maximo = 0
        Me.TxtImporteVenta.MaxLength = 14
        Me.TxtImporteVenta.Name = "TxtImporteVenta"
        Me.TxtImporteVenta.Size = New System.Drawing.Size(70, 20)
        Me.TxtImporteVenta.SoloLetra = False
        Me.TxtImporteVenta.SoloNumero = False
        Me.TxtImporteVenta.TabIndex = 10
        Me.TxtImporteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImporteVenta
        '
        Me.lblImporteVenta.Location = New System.Drawing.Point(346, 53)
        Me.lblImporteVenta.Name = "lblImporteVenta"
        Me.lblImporteVenta.Size = New System.Drawing.Size(80, 13)
        Me.lblImporteVenta.TabIndex = 107
        Me.lblImporteVenta.Text = "Importe Venta:"
        '
        'lblImporteCompra
        '
        Me.lblImporteCompra.Location = New System.Drawing.Point(504, 51)
        Me.lblImporteCompra.Name = "lblImporteCompra"
        Me.lblImporteCompra.Size = New System.Drawing.Size(91, 29)
        Me.lblImporteCompra.TabIndex = 106
        Me.lblImporteCompra.Text = "Importe Compra:"
        '
        'grbDiaSemana
        '
        Me.grbDiaSemana.Controls.Add(Me.ChkSabadoDomingo)
        Me.grbDiaSemana.Controls.Add(Me.ChkDomingo)
        Me.grbDiaSemana.Controls.Add(Me.ChkSabado)
        Me.grbDiaSemana.Controls.Add(Me.ChkViernes)
        Me.grbDiaSemana.Controls.Add(Me.ChkJueves)
        Me.grbDiaSemana.Controls.Add(Me.ChkMiercoles)
        Me.grbDiaSemana.Controls.Add(Me.ChkLunesViernes)
        Me.grbDiaSemana.Controls.Add(Me.ChkMartes)
        Me.grbDiaSemana.Controls.Add(Me.ChkLunes)
        Me.grbDiaSemana.Location = New System.Drawing.Point(359, 159)
        Me.grbDiaSemana.Name = "grbDiaSemana"
        Me.grbDiaSemana.Size = New System.Drawing.Size(311, 101)
        Me.grbDiaSemana.TabIndex = 12
        Me.grbDiaSemana.TabStop = False
        Me.grbDiaSemana.Text = "Día de la semana"
        '
        'ChkSabadoDomingo
        '
        Me.ChkSabadoDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSabadoDomingo.Location = New System.Drawing.Point(163, 17)
        Me.ChkSabadoDomingo.Name = "ChkSabadoDomingo"
        Me.ChkSabadoDomingo.Size = New System.Drawing.Size(125, 24)
        Me.ChkSabadoDomingo.TabIndex = 1
        Me.ChkSabadoDomingo.Text = "Sabado-Domingo"
        '
        'ChkDomingo
        '
        Me.ChkDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkDomingo.Location = New System.Drawing.Point(145, 66)
        Me.ChkDomingo.Name = "ChkDomingo"
        Me.ChkDomingo.Size = New System.Drawing.Size(67, 24)
        Me.ChkDomingo.TabIndex = 8
        Me.ChkDomingo.Text = "Domingo"
        '
        'ChkSabado
        '
        Me.ChkSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSabado.Location = New System.Drawing.Point(78, 66)
        Me.ChkSabado.Name = "ChkSabado"
        Me.ChkSabado.Size = New System.Drawing.Size(61, 24)
        Me.ChkSabado.TabIndex = 7
        Me.ChkSabado.Text = "Sábado"
        '
        'ChkViernes
        '
        Me.ChkViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkViernes.Location = New System.Drawing.Point(11, 66)
        Me.ChkViernes.Name = "ChkViernes"
        Me.ChkViernes.Size = New System.Drawing.Size(61, 24)
        Me.ChkViernes.TabIndex = 6
        Me.ChkViernes.Text = "Viernes"
        '
        'ChkJueves
        '
        Me.ChkJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkJueves.Location = New System.Drawing.Point(213, 44)
        Me.ChkJueves.Name = "ChkJueves"
        Me.ChkJueves.Size = New System.Drawing.Size(58, 24)
        Me.ChkJueves.TabIndex = 5
        Me.ChkJueves.Text = "Jueves"
        '
        'ChkMiercoles
        '
        Me.ChkMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkMiercoles.Location = New System.Drawing.Point(132, 44)
        Me.ChkMiercoles.Name = "ChkMiercoles"
        Me.ChkMiercoles.Size = New System.Drawing.Size(70, 24)
        Me.ChkMiercoles.TabIndex = 4
        Me.ChkMiercoles.Text = "Miércoles"
        '
        'ChkLunesViernes
        '
        Me.ChkLunesViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLunesViernes.Location = New System.Drawing.Point(12, 17)
        Me.ChkLunesViernes.Name = "ChkLunesViernes"
        Me.ChkLunesViernes.Size = New System.Drawing.Size(104, 24)
        Me.ChkLunesViernes.TabIndex = 0
        Me.ChkLunesViernes.Text = "Lunes-Viernes"
        '
        'ChkMartes
        '
        Me.ChkMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkMartes.Location = New System.Drawing.Point(67, 44)
        Me.ChkMartes.Name = "ChkMartes"
        Me.ChkMartes.Size = New System.Drawing.Size(57, 24)
        Me.ChkMartes.TabIndex = 3
        Me.ChkMartes.Text = "Martes"
        '
        'ChkLunes
        '
        Me.ChkLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLunes.Location = New System.Drawing.Point(12, 44)
        Me.ChkLunes.Name = "ChkLunes"
        Me.ChkLunes.Size = New System.Drawing.Size(54, 24)
        Me.ChkLunes.TabIndex = 2
        Me.ChkLunes.Text = "Lunes"
        '
        'TxtHFin
        '
        Me.TxtHFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHFin.ConDecimal = False
        Me.TxtHFin.Location = New System.Drawing.Point(556, 24)
        Me.TxtHFin.Maximo = 0
        Me.TxtHFin.MaxLength = 5
        Me.TxtHFin.Name = "TxtHFin"
        Me.TxtHFin.Size = New System.Drawing.Size(83, 20)
        Me.TxtHFin.SoloLetra = False
        Me.TxtHFin.SoloNumero = False
        Me.TxtHFin.TabIndex = 9
        Me.TxtHFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(503, 28)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(54, 13)
        Me.lblHoraFin.TabIndex = 102
        Me.lblHoraFin.Text = "Hora Fin:"
        '
        'TxtHInicio
        '
        Me.TxtHInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHInicio.ConDecimal = False
        Me.TxtHInicio.Location = New System.Drawing.Point(410, 24)
        Me.TxtHInicio.Maximo = 0
        Me.TxtHInicio.MaxLength = 5
        Me.TxtHInicio.Name = "TxtHInicio"
        Me.TxtHInicio.Size = New System.Drawing.Size(87, 20)
        Me.TxtHInicio.SoloLetra = False
        Me.TxtHInicio.SoloNumero = False
        Me.TxtHInicio.TabIndex = 8
        Me.TxtHInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(348, 26)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(66, 16)
        Me.lblHoraInicio.TabIndex = 100
        Me.lblHoraInicio.Text = "Hora Inicio:"
        '
        'lblDesProducto
        '
        Me.lblDesProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesProducto.Enabled = False
        Me.lblDesProducto.Image = CType(resources.GetObject("lblDesProducto.Image"), System.Drawing.Image)
        Me.lblDesProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesProducto.Location = New System.Drawing.Point(316, 120)
        Me.lblDesProducto.Name = "lblDesProducto"
        Me.lblDesProducto.Size = New System.Drawing.Size(21, 21)
        Me.lblDesProducto.TabIndex = 7
        Me.lblDesProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesSoporte
        '
        Me.lblDesSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesSoporte.Enabled = False
        Me.lblDesSoporte.Image = CType(resources.GetObject("lblDesSoporte.Image"), System.Drawing.Image)
        Me.lblDesSoporte.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesSoporte.Location = New System.Drawing.Point(316, 96)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 5
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(104, 120)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 99
        Me.TxtProducto.TabStop = False
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(104, 96)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(208, 20)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 98
        Me.TxtSoporte.TabStop = False
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.AcceptsReturn = True
        Me.TxtCodProducto.AcceptsTab = True
        Me.TxtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodProducto.ConDecimal = False
        Me.TxtCodProducto.Location = New System.Drawing.Point(60, 120)
        Me.TxtCodProducto.Maximo = 0
        Me.TxtCodProducto.MaxLength = 5
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.ReadOnly = True
        Me.TxtCodProducto.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodProducto.SoloLetra = False
        Me.TxtCodProducto.SoloNumero = True
        Me.TxtCodProducto.TabIndex = 6
        '
        'TxtCodSoporte
        '
        Me.TxtCodSoporte.AcceptsReturn = True
        Me.TxtCodSoporte.AcceptsTab = True
        Me.TxtCodSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSoporte.ConDecimal = False
        Me.TxtCodSoporte.Location = New System.Drawing.Point(60, 96)
        Me.TxtCodSoporte.Maximo = 0
        Me.TxtCodSoporte.MaxLength = 5
        Me.TxtCodSoporte.Name = "TxtCodSoporte"
        Me.TxtCodSoporte.ReadOnly = True
        Me.TxtCodSoporte.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodSoporte.SoloLetra = False
        Me.TxtCodSoporte.SoloNumero = True
        Me.TxtCodSoporte.TabIndex = 5
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(3, 120)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 93
        Me.lblProducto.Text = "Producto"
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Location = New System.Drawing.Point(3, 96)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(44, 13)
        Me.lblSoporte.TabIndex = 83
        Me.lblSoporte.Text = "Soporte"
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(3, 50)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 82
        Me.lblMedio.Text = "Medio"
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(104, 24)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 11
        Me.txtCliente.TabStop = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.AcceptsTab = True
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.ConDecimal = False
        Me.txtCodCliente.Location = New System.Drawing.Point(60, 24)
        Me.txtCodCliente.Maximo = 0
        Me.txtCodCliente.MaxLength = 5
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.SoloLetra = False
        Me.txtCodCliente.SoloNumero = True
        Me.txtCodCliente.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(3, 26)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 9
        Me.lblCliente.Text = "Cliente"
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.ShowFullMenusDelay = 500
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.Settings.AllowCustomize = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockRight = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowDockTop = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowFloating = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.AllowHiding = Infragistics.Win.DefaultableBoolean.[False]
        UltraToolbar1.Settings.BorderStyleDocked = Infragistics.Win.UIElementBorderStyle.None
        UltraToolbar1.Settings.GrabHandleStyle = Infragistics.Win.UltraWinToolbars.GrabHandleStyle.None
        UltraToolbar1.Settings.ToolDisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways
        UltraToolbar1.Text = "uToolbar"
        ButtonTool6.InstanceProps.IsFirstInGroup = True
        ButtonTool8.InstanceProps.IsFirstInGroup = True
        UltraToolbar1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool7, ButtonTool8})
        Me.UltraToolbarsManager1.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        ButtonTool9.SharedProps.Caption = "Nuevo"
        ButtonTool10.SharedProps.Caption = "Nuevo Como"
        ButtonTool11.SharedProps.Caption = "Grabar"
        ButtonTool12.SharedProps.Caption = "Eliminar"
        ButtonTool12.SharedProps.Visible = False
        ButtonTool13.SharedProps.Caption = "Limpiar"
        ButtonTool14.SharedProps.Caption = "Salir"
        ButtonTool15.SharedProps.Caption = "Mostrar"
        ButtonTool16.SharedProps.Caption = "Modificar"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool16})
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Left
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 24)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Left"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 621)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Right
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1246, 24)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Right"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 621)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Top
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Top"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1246, 24)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom
        '
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 645)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Name = "_frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom"
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1246, 0)
        Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'tabPrincipal
        '
        Appearance55.FontData.BoldAsString = "True"
        Appearance55.ForeColor = System.Drawing.Color.Blue
        Me.tabPrincipal.ActiveTabAppearance = Appearance55
        Me.tabPrincipal.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabPrincipal.Controls.Add(Me.tabCampaña)
        Me.tabPrincipal.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabPrincipal.Controls.Add(Me.tabSistema)
        Me.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPrincipal.Location = New System.Drawing.Point(0, 303)
        Me.tabPrincipal.Name = "tabPrincipal"
        Me.tabPrincipal.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabPrincipal.Size = New System.Drawing.Size(1246, 342)
        Me.tabPrincipal.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.tabPrincipal.TabIndex = 52
        UltraTab1.Key = "Convenios"
        UltraTab1.TabPage = Me.tabCampaña
        UltraTab1.Text = "Convenios"
        UltraTab2.Key = "Convenios_Enviados"
        UltraTab2.TabPage = Me.tabSistema
        UltraTab2.Text = "Convenios Enviados"
        Me.tabPrincipal.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1244, 321)
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(612, 410)
        '
        'BackgroundWorkerEnvio
        '
        '
        'frmMantenimientoConvenio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1246, 645)
        Me.Controls.Add(Me.tabPrincipal)
        Me.Controls.Add(Me.pnlFiltro)
        Me.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._frmMantenimientoConvenio_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantenimientoConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Convenios"
        Me.tabCampaña.ResumeLayout(False)
        CType(Me.ugConvenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSistema.ResumeLayout(False)
        CType(Me.ugConveniosEnviados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltro.ResumeLayout(False)
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        CType(Me.mpbEnvioMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbIngresoParametros.ResumeLayout(False)
        Me.grbIngresoParametros.PerformLayout()
        Me.grbDescuentoCompra.ResumeLayout(False)
        Me.grbDescuentoCompra.PerformLayout()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDescuentoVenta.ResumeLayout(False)
        Me.grbDescuentoVenta.PerformLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDiaSemana.ResumeLayout(False)
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Privadas"
    Private mTipoConvenioApertura As TipoConvenio = TipoConvenio.Tarifa
    Private mChkGeneral As Boolean
    Private mChkParticular As Boolean
    Private mClosePage As Boolean = False
    Private mdsConvenioGrilla As DataSet
    Private mdtConvenioGrilla As DataTable
    Private mdrConvenioGrilla As DataRow
    Private mIsNuevoComo As Boolean = False
    Private ObsLeyendaSinRentabilidad As String = "Sin Rentabilidad"  'AG TC
    Private ObsLeyendaConRentabilidad As String = "Con Rentabilidad"    'AG TC
    Private ObsLeyendaConRentaFacturaProveedor As String = "FC PROVEEDOR" 'AG TC
    Private ObsLlevaNC As String = "NC PROVEEDOR" 'AG TC
    Private ITipoConfidencial As Integer 'AG TC
    Private mTRentabilidad As Integer 'AG TC
    Shared mInstancia As frmMantenimientoConvenio
    Private IniciofromDefaulConfidencialidad As Boolean
    Private ModoEdicion As Boolean
    Private mAnexos As New List(Of AnexoConvenio)

    'AG 23/04/2015 =====================================
    Dim CodusuarioAutorizado As Integer
    Dim EstadoConvenio As Integer
    Private mdtConvenioPendienteGrilla As DataTable
    Private mdrConvenioPendienteGrilla As DataRow
    Private mdsConvenioPendienteGrilla As DataSet
    Dim GrillaFormato As New GrillaFormato

    Dim cuerpo As String
    Dim envioExitoso As Boolean
    Dim MailSend As String
    Dim MailTo As String
    Dim MailCopia As String
    Dim asunto As String
    Dim IdUnicoCodigoConvenio As String
    Public dtUsuarioAprobadores As New DataTable
    Public dtUsuarioSeleccionado As DataTable
    Dim ControlUnaCopiaMia As Boolean = False
    '===================================================

#End Region

#Region "Variables y Propiedades Publicas"

    Public Enum TipoConvenio As Integer
        Descuento = 0
        Tarifa = 1
        CPR = 2
    End Enum

    Public Enum TipoConfidencial As Integer 'AG TC
        ConfidencialidadNula = -1
        SinRentabilidad = 0
        ConRentabilidad = 1
    End Enum

    Public WriteOnly Property TipoApertura() As TipoConvenio
        Set(ByVal Value As TipoConvenio)
            mTipoConvenioApertura = Value
        End Set
    End Property

    Public Property TRentabilidad() As Integer
        Get
            Return mTRentabilidad
        End Get
        Set(ByVal Value As Integer)
            mTRentabilidad = Value
        End Set
    End Property

    Public Property pdtUsuarioAprobadores() As DataTable
        Get
            Return dtUsuarioAprobadores
        End Get
        Set(ByVal Value As DataTable)
            dtUsuarioAprobadores = Value
        End Set
    End Property

    Public Property pdtUsuarioSeleccionado() As DataTable
        Get
            Return dtUsuarioSeleccionado
        End Get
        Set(ByVal Value As DataTable)
            dtUsuarioSeleccionado = Value
        End Set
    End Property

    Public Enum TipoRentabilidad As Integer 'AG TC
        LlevaNC = 0
        FPro = 1
    End Enum

#End Region

    Public Shared Property Instancia() As frmMantenimientoConvenio
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmMantenimientoConvenio
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmMantenimientoConvenio)
            mInstancia = Value
        End Set
    End Property

#Region "Eventos"
    Private Sub frmMantenimientoConvenio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lnkAnexos.Enabled = False
        Try
            'AG Velocidad Cache -------------------------------------------------------------
            'Dim OMsl As New Maestros
            'Activo.DTProveedorCache = OMsl.ProveedorTraerTodos(Constantes.COD_PAIS_ARGENTINA)
            '---------------------------------------------------------------------------------------------------------------------
            Call InicializarControles()
            Call OcultarControles()
            Call BuscarMedios()
            Call HabilitarControles(False)
            Call InicializarGrilla()

            Call OcultarControlesGrillaPendiente() 'AG 23/04/2015
            Call InicializarGrillaEnviados() 'AG 23/04/2015


            GrillaFormato.HabilitarFiltro(ugConvenios, DefaultableBoolean.True) 'AG 23/04/2015
            GrillaFormato.HabilitarFiltro(ugConveniosEnviados, DefaultableBoolean.True) 'AG 23/04/2015
            GrillaFormato.AutoAjustarColumnas(Me.ugConveniosEnviados) 'AG 23/04/2015

            GrillaFormato.CambiarTamañoColumna(ugConveniosEnviados, 130, "Estado")

            If mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
                GrillaFormato.CambiarTamañoColumna(ugConveniosEnviados, 85, "Cpr")
            End If

            'mpbEnvioMail.Properties.ShowTitle = True
            'mpbEnvioMail.Properties.Stopped = True

        Catch ex As Exception
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Private Sub frmMantenimientoConvenio_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mClosePage = True
    End Sub

    Private Sub TxtHInicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHInicio.LostFocus
        Call AplicarFormatoHora(TxtHInicio, True)
    End Sub

    Private Sub TxtHFin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHFin.LostFocus
        Call AplicarFormatoHora(TxtHFin, False)
    End Sub

    Private Sub TxtImporteVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporteVenta.LostFocus
        Call AplicarFormatoImporte(TxtImporteVenta, True)
    End Sub

    Private Sub TxtImporteCompra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtImporteCompra.LostFocus
        Call AplicarFormatoImporte(TxtImporteCompra, False)
    End Sub

    Private Sub ChkLunesViernes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkLunesViernes.CheckedChanged
        If mChkParticular Then Return
        mChkGeneral = True
        If Me.ChkLunesViernes.Checked Then
            Me.ChkLunes.Checked = True
            Me.ChkMartes.Checked = True
            Me.ChkMiercoles.Checked = True
            Me.ChkJueves.Checked = True
            Me.ChkViernes.Checked = True
        Else
            Me.ChkLunes.Checked = False
            Me.ChkMartes.Checked = False
            Me.ChkMiercoles.Checked = False
            Me.ChkJueves.Checked = False
            Me.ChkViernes.Checked = False
        End If
        mChkGeneral = False
    End Sub

    Private Sub ChkSabadoDomingo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkSabadoDomingo.CheckedChanged
        If mChkParticular Then Return
        mChkGeneral = True
        If Me.ChkSabadoDomingo.Checked Then
            Me.ChkSabado.Checked = True
            Me.ChkDomingo.Checked = True
        Else
            Me.ChkSabado.Checked = False
            Me.ChkDomingo.Checked = False
        End If
        mChkGeneral = False
    End Sub

    Private Sub ChkLunes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkLunes.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Lunes)
    End Sub

    Private Sub ChkMartes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkMartes.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Martes)
    End Sub

    Private Sub ChkMiercoles_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkMiercoles.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Miercoles)
    End Sub

    Private Sub ChkJueves_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkJueves.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Jueves)
    End Sub

    Private Sub ChkViernes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkViernes.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Viernes)
    End Sub

    Private Sub ChkSabado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkSabado.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Sabado)
    End Sub

    Private Sub ChkDomingo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkDomingo.CheckedChanged
        Call ValidarDiaSemana(DiasSemana.Domingo)
    End Sub

    Private Sub TxtDescuentoExtra1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescuentoExtra1.LostFocus
        'Call AplicarFormatoPorcentaje(TxtDescuentoExtra1)
    End Sub

    Private Sub TxtDescuentoExtra2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescuentoExtra2.LostFocus
        'Call AplicarFormatoPorcentaje(TxtDescuentoExtra2)
    End Sub

    Private Sub TxtDctoVenta1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta1.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta1)
    End Sub

    Private Sub TxtDctoVenta2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta2.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta2)
    End Sub

    Private Sub TxtDctoVenta3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta3.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta3)
    End Sub

    Private Sub TxtDctoVenta4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta4.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta4)
    End Sub

    Private Sub TxtDctoVenta5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta5.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta5)
    End Sub

    Private Sub TxtDctoCompra1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoCompra1.LostFocus
        Call AplicarFormatoPorcentajeCompra(TxtDctoCompra1)
    End Sub

    Private Sub TxtDctoCompra2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoCompra2.LostFocus
        Call AplicarFormatoPorcentajeCompra(TxtDctoCompra2)
    End Sub

    Private Sub TxtDctoCompra3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoCompra3.LostFocus
        Call AplicarFormatoPorcentajeCompra(TxtDctoCompra3)
    End Sub

    Private Sub TxtDctoCompra4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoCompra4.LostFocus
        Call AplicarFormatoPorcentajeCompra(TxtDctoCompra4)
    End Sub

    Private Sub TxtDctoCompra5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoCompra5.LostFocus
        Call AplicarFormatoPorcentajeCompra(TxtDctoCompra5)
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        Dim Cliente As String = txtCliente.Text.Trim
        TxtCodProducto.Text = String.Empty
        TxtProducto.Text = String.Empty
        If Cliente <> "" Then
            TxtCodProducto.ReadOnly = False
            lblDesProducto.Enabled = True
        Else
            TxtCodProducto.ReadOnly = True
            lblDesProducto.Enabled = False
        End If
        mdtConvenioGrilla.Rows.Clear()

        'AG 23/04/2015 ==================================
        mdtConvenioPendienteGrilla.Rows.Clear()
        '================================================

        Call InicializarControles()
        Call CargarHoraEspecial()
    End Sub

    Private Sub txtCodCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCliente.Validated
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoCliente <> "" Then
            Dim Usu As New Usuario
            Try
                Usu.IDPerfil_Datos = Activo.IDPerfil_Datos
                If CodigoCliente = 3 Then
                    Usu.IDPerfil_Datos = 1
                End If

                txtCliente.Text = Usu.ObtenerDescripcion(CodigoCliente)
                If txtCliente.Text = String.Empty Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodCliente.Text = String.Empty
                    txtCodCliente.Select()
                    Exit Sub
                Else
                    TxtCodProducto.ReadOnly = False
                    lblProducto.Enabled = True
                    Call CargarHoraEspecial()
                End If
            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                txtCliente.Text = String.Empty
                txtCodCliente.Text = String.Empty
                txtCodCliente.Select()
                Exit Sub
            End Try
        Else
            txtCliente.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesCliente.Click
        Dim Busqueda As New frmBuscar
        Busqueda.CargarFormulario(SeccionActiva.Cliente, txtCliente, txtCodCliente, "id_cliente", "descripcion", "Código", "Cliente")
        Busqueda.ShowDialog()
    End Sub

    Private Sub TxtCodMedio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodMedio.LostFocus
        Dim CodMedio As String = TxtCodMedio.Text.Trim
        If CodMedio <> String.Empty Then
            Call Combo_Position(cboMedio, "ID_MEDIO", CodMedio)
            If cboMedio.SelectedItem Is Nothing OrElse cboMedio.SelectedItem.DataValue Is Nothing Then
                Mensaje("El código de medio no existe.", TipoMensaje.Informacion)
                TxtCodSoporte.ReadOnly = True
                lblDesSoporte.Enabled = False
                cboTipoSoporte.ReadOnly = True
                TxtCodMedio.Text = String.Empty
                TxtCodMedio.Focus()
            Else
                TxtCodSoporte.ReadOnly = False
                lblDesSoporte.Enabled = True
                cboTipoSoporte.ReadOnly = False
                Call CargarHoraEspecial()
                Me.SelectNextControl(cboMedio, True, True, True, True)
            End If
        Else
            cboMedio.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboMedio_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedio.SelectionChanged
        If cboMedio.SelectedItem Is Nothing OrElse cboMedio.SelectedItem.DataValue Is Nothing Then
            TxtCodMedio.Text = String.Empty
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
            cboTipoSoporte.ReadOnly = True
        Else
            TxtCodMedio.Text = cboMedio.SelectedItem.DataValue("ID_MEDIO")
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
            cboTipoSoporte.ReadOnly = False
            ' RM 27/6/2011 -----------------------------------------------------------------------------------------------------
            If mTipoConvenioApertura = TipoConvenio.Descuento Then
                'If (Me.cboMedio.SelectedIndex = 4 Or Me.cboMedio.SelectedIndex = 7) Then

                lblImporteVenta.Visible = True
                lblImporteVenta.Text = "Bruto Venta"
                TxtImporteVenta.Visible = True
                lblImporteCompra.Visible = True
                TxtImporteCompra.Visible = True
                ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = False
                ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = False

                'Else
                '    lblImporteVenta.Visible = False
                '    TxtImporteVenta.Visible = False
                '    TxtImporteVenta.Enabled = False
                '    lblImporteCompra.Visible = False
                '    TxtImporteCompra.Visible = False
                '    TxtImporteCompra.Enabled = False
                '    ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = True
                '    ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = True
                'End If

            End If
            ' ---------------------------------------------------------------------------------------------------------------------------------
            Call CargarTipoSoporte(cboMedio.SelectedItem.DataValue("ID_MEDIO"))
            Call CargarHoraEspecial()
        End If
    End Sub

    Private Sub cboTipoSoporte_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.SelectionChanged
        mdtConvenioGrilla.Rows.Clear()

        'AG 23/04/2015 ==================================
        mdtConvenioPendienteGrilla.Rows.Clear()
        '================================================

        Call InicializarControles()
        Call CargarHoraEspecial()
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty
        If cboTipoSoporte.SelectedItem Is Nothing OrElse cboTipoSoporte.SelectedItem.DataValue Is Nothing Then
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        Else
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
        End If
    End Sub

    Private Sub TxtCodSoporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodSoporte.LostFocus
        Dim CodigoSoporte As String = TxtCodSoporte.Text.Trim
        Dim CodigoMedio As String = TxtCodMedio.Text.Trim
        Dim CodigoTipoSoporte As Integer
        If Not cboTipoSoporte.SelectedItem Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte") Is DBNull.Value Then
            CodigoTipoSoporte = cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte")
        End If
        If CodigoSoporte <> String.Empty AndAlso CodigoMedio <> String.Empty Then
            Dim Sop As New Soportes
            Try

                Sop.Id_medio = CodigoMedio
                Sop.Id_soporte = CodigoSoporte
                Sop.Id_tipo_soporte = CodigoTipoSoporte
                Dim dtSoporte As DataTable = Sop.ObtenerSoportesMediosConvenio

                If dtSoporte Is Nothing OrElse dtSoporte.Rows.Count <= 0 Then
                    Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                    TxtCodSoporte.Text = String.Empty
                    TxtCodSoporte.Select()
                    Exit Sub
                End If
                TxtSoporte.Text = dtSoporte.Rows(0)("Descripcion")
                Call CargarHoraEspecial()
            Catch ex As Exception
                Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                TxtSoporte.Text = String.Empty
                TxtCodSoporte.Text = ""
                TxtCodSoporte.Select()
                Exit Sub
            End Try
        Else
            TxtSoporte.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesSoporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesSoporte.Click
        Dim CodigoMedio As String = TxtCodMedio.Text.Trim
        If CodigoMedio <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Dim TipoSoporte As Integer
            If Not cboTipoSoporte.SelectedItem Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte") Is DBNull.Value Then
                TipoSoporte = cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte")
            End If
            Busqueda.CargarFormulario(SeccionActiva.SoportesConvenios, TxtSoporte, TxtCodSoporte, "id_soporte", "descripcion", "Código", "Soporte", CodigoMedio, TipoSoporte)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub TxtCodProducto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProducto.LostFocus
        Dim CodigoProducto As String = TxtCodProducto.Text.Trim
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoProducto <> String.Empty AndAlso CodigoCliente <> String.Empty Then
            Dim Prod As New Productos
            Dim producto As New DataTable

            Try
                Prod.Id_cliente = CodigoCliente
                producto = Prod.TraerProductos

                If producto Is Nothing OrElse producto.Rows.Count = 0 OrElse producto.Select("Id_Producto = " & CodigoProducto).Length = 0 Then
                    Mensajes.Mensaje("El Producto No Existe  o No Pertenece al Cliente Selccionado")
                    TxtCodProducto.Text = ""
                    TxtCodProducto.Select()
                    Exit Sub
                Else
                    TxtProducto.Text = producto.Select("Id_Producto = " & CodigoProducto)(0)("Descripcion")
                    Call CargarHoraEspecial()
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Selccionado")
                TxtCodProducto.Text = ""
                TxtCodProducto.Select()
                Exit Sub
            End Try
        Else
            TxtProducto.Text = String.Empty
        End If
    End Sub

    Private Sub lblDesProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesProducto.Click
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoCliente <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Busqueda.CargarFormulario(SeccionActiva.Producto, TxtProducto, TxtCodProducto, "id_producto", "descripcion", "Código", "Producto", CodigoCliente)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        mIsNuevoComo = False
        Select Case e.Tool.Key
            Case "Nuevo"
                Me.mAnexos.Clear()
                Me.lnkAnexos.Enabled = True
                Call InicializarControles()
                Call HabilitarControles(True)
                Call CargarHoraEspecial()

                'AG 23/04/2015 =======================================================

                TxtNroConvenio.Text = String.Empty
                TxtIdConvenio.Text = String.Empty
                EstadoConvenio = Int(EstadosConvenios.Pendiente_Aprobacion)
                Me.pdtUsuarioAprobadores = Nothing
                Me.pdtUsuarioSeleccionado = Nothing
                ControlUnaCopiaMia = True
                '=====================================================================
            Case "NuevoComo"
                If mdtConvenioGrilla.Rows.Count > 0 AndAlso TxtNroConvenio.Text.Trim <> String.Empty Then
                    Me.mAnexos.Clear()
                    Me.lnkAnexos.Enabled = True
                    Call HabilitarControles(True)
                    TxtNroConvenio.Text = String.Empty
                    TxtIdConvenio.Text = String.Empty
                    mIsNuevoComo = True

                    'AG 23/04/2015 =======================================================
                    EstadoConvenio = Int(EstadosConvenios.Pendiente_Aprobacion)
                    Me.pdtUsuarioAprobadores = Nothing
                    Me.pdtUsuarioSeleccionado = Nothing
                    Me.txtUsuariosAutorizados.Text = ""
                    ControlUnaCopiaMia = True
                    '=====================================================================

                Else
                    Mensaje("Debe seelccionar un convenio.", TipoMensaje.Informacion)
                End If
            Case "Modificar"
                If mdtConvenioGrilla.Rows.Count > 0 AndAlso TxtNroConvenio.Text.Trim <> String.Empty Then
                    Me.lnkAnexos.Enabled = True
                    Call HabilitarControles(True)

                    'AG 23/04/2015 =======================================================
                    EstadoConvenio = Int(EstadosConvenios.Modificado) 'AG 23/04/2015 
                    ControlUnaCopiaMia = True
                    Me.pdtUsuarioAprobadores = Nothing
                    Me.pdtUsuarioSeleccionado = Nothing
                    Me.txtUsuariosAutorizados.Text = ""
                    '=====================================================================

                    'AG CCPR +++++++++++++++++++++++++++++++++++++++++++
                    If Me.ugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "C" Then
                        Dim SConvenio As New Spots
                        If SConvenio.ControlConvenioAplicado(Me.ugConvenios.ActiveRow.Cells("id_Convenio").Value) = True Then
                            Me.txtcpr.Enabled = False 'AG CCPR
                            Me.txtcpr.BackColor = Color.LightGray
                        Else
                            Me.txtcpr.Enabled = True 'AG CCPR
                            Me.txtcpr.BackColor = Color.White
                        End If
                    End If

                    'OBTENGO ANEXOS
                    Dim Convenio As New Convenios
                    Dim DtAnexos As DataTable = Convenio.ObtenerAnexosConvenio(CInt(TxtIdConvenio.Text))
                    Me.mAnexos.Clear()
                    For Each DrAnexo As DataRow In DtAnexos.Rows
                        Dim oAnexoConvenio As New AnexoConvenio
                        oAnexoConvenio.Bytes = DrAnexo("ANEXO")
                        oAnexoConvenio.Extension = DrAnexo("TIPO")
                        oAnexoConvenio.IdAnexo = DrAnexo("COD_ANEXO")
                        oAnexoConvenio.IdConvenio = DrAnexo("ID_CONVENIO")
                        oAnexoConvenio.NombreArchivo = DrAnexo("NOMBRE")
                        Me.mAnexos.Add(oAnexoConvenio)
                    Next
                Else
                    Mensaje("Debe seelccionar un convenio.", TipoMensaje.Informacion)
                End If
            Case "Grabar"
                Call GrabarConvenio()
                Me.lnkAnexos.Enabled = True
            Case "Eliminar"
                If mdtConvenioGrilla.Rows.Count > 0 AndAlso TxtNroConvenio.Text.Trim <> String.Empty AndAlso TxtIdConvenio.Text.Trim <> String.Empty Then
                    'AG CCPR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If Me.ugConvenios.ActiveRow.Cells("Tipo_Convenio").Value = "C" Then
                        Dim SConvenio As New Spots
                        If SConvenio.ControlConvenioAplicado(Me.ugConvenios.ActiveRow.Cells("id_Convenio").Value) = True Then
                            Mensaje("El Convenio Nro: " & Me.ugConvenios.ActiveRow.Cells("cod_Convenio").Value.ToString & " , no puede ser eliminado debido a que se encuentra aplicado a un ejercicio", TipoMensaje.Informacion)
                        Else
                            Call EliminarConvenio()
                        End If
                    Else
                        Call EliminarConvenio()
                    End If
                End If
            Case "Limpiar"
                Me.mAnexos.Clear()
                Me.lnkAnexos.Enabled = True
                Call InicializarControles()
                Call mdtConvenioGrilla.Rows.Clear()

                'AG 23/04/2015 ==================================
                mdtConvenioPendienteGrilla.Rows.Clear()
                Me.pdtUsuarioAprobadores = Nothing
                Me.pdtUsuarioSeleccionado = Nothing
                ControlUnaCopiaMia = True
                EstadoConvenio = 0
                '================================================

            Case "Salir"
                Me.Close()
            Case "Mostrar"
                If CargarConvenios() Then
                    'AG 23/04/2015 ==========================
                    Call CargarConveniosPendientes()
                    CambiarColorCelda()

                    Me.pdtUsuarioAprobadores = Nothing
                    Me.pdtUsuarioSeleccionado = Nothing
                    Me.txtUsuariosAutorizados.Text = ""
                    ControlUnaCopiaMia = True
                    EstadoConvenio = 0
                    '========================================
                    If mdtConvenioGrilla.Rows.Count <= 0 Then
                        Mensaje("No existen convenios con los datos seleccionados.", TipoMensaje.Informacion)
                    End If
                End If
        End Select
    End Sub

    Private Sub ugConvenios_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs)
        Call HabilitarControles(False)
        Call PopularDatos()
    End Sub

    Private Sub TxtSoporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSoporte.TextChanged
        mdtConvenioGrilla.Rows.Clear()
        Call InicializarControles()

        'AG 23/04/2015 ===========================
        mdtConvenioPendienteGrilla.Rows.Clear()
        '=========================================

        Call CargarHoraEspecial()
    End Sub

    Private Sub TxtProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProducto.TextChanged

        'LG - AG 30/03/2016 ==================================
        'mdtConvenioGrilla.Rows.Clear()
        'mdtConvenioPendienteGrilla.Rows.Clear()
        'If Not mIsNuevoComo Then
        '    Call InicializarControles()
        'End If
        '================================================

        Call CargarHoraEspecial()
    End Sub

    Private Sub TxtCodMedio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodMedio.TextChanged
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty
        If TxtCodMedio.Text.Trim <> String.Empty Then
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
            cboTipoSoporte.ReadOnly = False
        Else
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
            cboTipoSoporte.ReadOnly = True
        End If

        mdtConvenioGrilla.Rows.Clear()
        'AG 23/04/2015 ==================================
        mdtConvenioPendienteGrilla.Rows.Clear()
        '================================================
        Call InicializarControles()
        Call CargarHoraEspecial()
    End Sub
#End Region

#Region "Metodos Privados"

    Private Sub InicializarGrilla()
        mdsConvenioGrilla = New DataSet
        mdtConvenioGrilla = New DataTable

        mdtConvenioGrilla.Columns.Add("Cod_Medio", GetType(Integer))
        mdtConvenioGrilla.Columns.Add("Cod_Soporte", GetType(Integer))
        mdtConvenioGrilla.Columns.Add("Cod_Cliente", GetType(Integer))
        mdtConvenioGrilla.Columns.Add("Cod_Producto", GetType(Integer))
        mdtConvenioGrilla.Columns.Add("Cod_Convenio", GetType(Integer))
        'AG 09/06/2014 ===============================================
        'mdtConvenioGrilla.Columns.Add("Convenio_mms", GetType(Integer))
        '============================================================
        'AG CCPR +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
            mdtConvenioGrilla.Columns.Add("Cpr", GetType(Double)) 'AG CCPR
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        mdtConvenioGrilla.Columns.Add("Fec_Inicio", GetType(DateTime))
        mdtConvenioGrilla.Columns.Add("Fec_Fin", GetType(DateTime))
        mdtConvenioGrilla.Columns.Add("Detalle", GetType(String))
        mdtConvenioGrilla.Columns.Add("Participacion", GetType(String))
        mdtConvenioGrilla.Columns.Add("Programa", GetType(String))
        mdtConvenioGrilla.Columns.Add("Desc_Venta_1", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Venta_2", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Venta_3", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Venta_4", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Venta_5", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Compra_1", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Compra_2", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Compra_3", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Compra_4", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Compra_5", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Extra_1", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Desc_Extra_2", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Imp_Neto_Venta", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Imp_Neto_Compra", GetType(Double))
        mdtConvenioGrilla.Columns.Add("Obs_Compra", GetType(String))
        mdtConvenioGrilla.Columns.Add("Obs_Venta", GetType(String))
        mdtConvenioGrilla.Columns.Add("Obs_Finanzas", GetType(String))
        mdtConvenioGrilla.Columns.Add("Semana", GetType(String))
        mdtConvenioGrilla.Columns.Add("Id_Convenio", GetType(Integer))
        mdtConvenioGrilla.Columns.Add("Hora_Inicio", GetType(String))
        mdtConvenioGrilla.Columns.Add("Hora_Fin", GetType(String))
        mdtConvenioGrilla.Columns.Add("Tipo_Convenio", GetType(String))
        'AG TC ==========================================================
        mdtConvenioGrilla.Columns.Add("TCONFIDENCIAL", GetType(Integer))
        '================================================================

        mdsConvenioGrilla.Tables.Add(mdtConvenioGrilla)
        ugConvenios.DataSource = mdsConvenioGrilla
        ugConvenios.DataBind()

        Dim CellCultureInfo As New CultureInfo("en-US")
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_1").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_2").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_3").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_4").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_5").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_1").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_2").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_3").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_4").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_5").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Extra_1").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Extra_2").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").FormatInfo = CellCultureInfo
        ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").FormatInfo = CellCultureInfo
        ''ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Format = "G"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Format = "#.00"
        'AG 03/11/2010 --------------------------------------------------------------------------------------
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Format = "#.00"
        ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Format = "#.00"
        '----------------------------------------------------------------------------------------------------------
        If mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
            ugConvenios.DisplayLayout.Bands(0).Columns("Cpr").Format = "#.00" 'AG CCPR
        End If

        'AG TC ======================================================================
        ugConvenios.DisplayLayout.Bands(0).Columns("TCONFIDENCIAL").Hidden = True
        '============================================================================
    End Sub

    Private Sub InicializarGrillaEnviados()

        'AG 24/04/2015 ===============================

        mdsConvenioPendienteGrilla = New DataSet
        mdtConvenioPendienteGrilla = New DataTable

        mdtConvenioPendienteGrilla.Columns.Add("Estado", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Cod_Medio", GetType(Integer))
        mdtConvenioPendienteGrilla.Columns.Add("Cod_Soporte", GetType(Integer))
        mdtConvenioPendienteGrilla.Columns.Add("Cod_Cliente", GetType(Integer))
        mdtConvenioPendienteGrilla.Columns.Add("Cod_Producto", GetType(Integer))
        mdtConvenioPendienteGrilla.Columns.Add("Cod_Convenio", GetType(Integer))
        If mTipoConvenioApertura = TipoConvenio.CPR Then
            mdtConvenioPendienteGrilla.Columns.Add("Cpr", GetType(Double))
        End If
        mdtConvenioPendienteGrilla.Columns.Add("Fec_Inicio", GetType(DateTime))
        mdtConvenioPendienteGrilla.Columns.Add("Fec_Fin", GetType(DateTime))
        mdtConvenioPendienteGrilla.Columns.Add("Detalle", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Participacion", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Programa", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Venta_1", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Venta_2", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Venta_3", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Venta_4", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Venta_5", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Compra_1", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Compra_2", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Compra_3", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Compra_4", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Compra_5", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Extra_1", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Desc_Extra_2", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Imp_Neto_Venta", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Imp_Neto_Compra", GetType(Double))
        mdtConvenioPendienteGrilla.Columns.Add("Obs_Compra", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Obs_Venta", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Obs_Finanzas", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Semana", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Id_Convenio", GetType(Integer))
        mdtConvenioPendienteGrilla.Columns.Add("Hora_Inicio", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Hora_Fin", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("Tipo_Convenio", GetType(String))
        mdtConvenioPendienteGrilla.Columns.Add("TCONFIDENCIAL", GetType(Integer))

        mdsConvenioPendienteGrilla.Tables.Add(mdtConvenioPendienteGrilla)


        Me.ugConveniosEnviados.DataSource = mdsConvenioPendienteGrilla
        Me.ugConveniosEnviados.DataBind()

        Dim CellCultureInfo As New CultureInfo("en-US")

        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_1").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_2").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_3").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_4").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_5").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_1").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_2").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_3").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_4").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_5").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Extra_1").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Extra_2").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").FormatInfo = CellCultureInfo
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Format = "#.00"
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Format = "#.00"

        If mTipoConvenioApertura = TipoConvenio.CPR Then
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Cpr").Format = "#.00"
        End If

        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("TCONFIDENCIAL").Hidden = True

    End Sub

    Private Sub InicializarControles()
        TxtImporteVenta.Text = "$ 0.00"
        TxtImporteCompra.Text = "$ 0.00"
        TxtDescuentoExtra1.Text = "" '--"0.00"
        TxtDescuentoExtra2.Text = "" '--"0.00"
        TxtDctoVenta1.Text = "0.00"
        TxtDctoVenta2.Text = "0.00"
        TxtDctoVenta3.Text = "0.00"
        TxtDctoVenta4.Text = "0.00"
        TxtDctoVenta5.Text = "0.00"
        TxtDctoCompra1.Text = "0.00"
        TxtDctoCompra2.Text = "0.00"
        TxtDctoCompra3.Text = "0.00"
        TxtDctoCompra4.Text = "0.00"
        TxtDctoCompra5.Text = "0.00"
        txtcpr.Text = "0.00" ' AG CCPR
        TxtHInicio.Text = String.Empty
        TxtHFin.Text = String.Empty
        TxtDetalle.Text = String.Empty
        TxtParticipacion.Text = String.Empty
        TxtObsVenta.Text = String.Empty
        TxtObsCompra.Text = String.Empty
        TxtObsFinanza.Text = String.Empty
        ChkLunes.Checked = False
        ChkMartes.Checked = False
        ChkMiercoles.Checked = False
        ChkJueves.Checked = False
        ChkViernes.Checked = False
        ChkSabado.Checked = False
        ChkDomingo.Checked = False
        DtpFInicio.Value = Today
        DtpFFin.Value = New DateTime(Today.Year, 12, 31)
        TxtNroConvenio.Text = String.Empty

        'AG TC =================================================
        ChkSinRentabilidad.Checked = True
        ITipoConfidencial = TipoConfidencial.SinRentabilidad
        Me.TxtObsFinanza.Text = ObsLeyendaSinRentabilidad.ToUpper
        Me.TxtObsFinanza.Enabled = False
        IniciofromDefaulConfidencialidad = False
        Me.TxtDescuentoExtra1.Text = "0.00"
        Me.TxtDescuentoExtra2.Text = "0.00"
        Me.TxtDescuentoExtra1.Enabled = False
        Me.TxtDescuentoExtra2.Enabled = False
        '=======================================================
        Me.txtUsuariosAutorizados.Text = ""

    End Sub

    Private Sub OcultarControles()

        Dim Titulo As New StringBuilder(Me.Text)
        If mTipoConvenioApertura = TipoConvenio.Tarifa Then
            Titulo.Append(" - Convenios de Tarifa Plana")
            'pnlDescuento.Visible = False
            'AG 23/04/2015 ============================
            grbDescuentoVenta.Visible = False
            grbDescuentoCompra.Visible = False
            '==========================================
            Me.txtcpr.Visible = False 'AG CCPR
            Me.lblcpr.Visible = False 'AG CCPR
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Hidden = True
        ElseIf mTipoConvenioApertura = TipoConvenio.Descuento Then
            Titulo.Append(" - Convenios de Descuento")
            lblImporteVenta.Visible = True
            TxtImporteVenta.Visible = True
            lblImporteCompra.Visible = True
            TxtImporteCompra.Visible = True
            Me.txtcpr.Visible = False 'AG CCPR
            Me.lblcpr.Visible = False 'AG CCPR
            ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = False
            ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = False
        ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
            Titulo.Append(" - Convenios de CPR")
            lblImporteVenta.Visible = False
            TxtImporteVenta.Visible = False
            lblImporteCompra.Visible = False
            TxtImporteCompra.Visible = False
            'pnlDescuento.Visible = False
            'AG 23/04/2015 ============================
            grbDescuentoVenta.Visible = False
            grbDescuentoCompra.Visible = False
            '==========================================
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = True
            ugConvenios.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = True
        End If

        'AG 09/06/2014 =========================================================
        ugConvenios.DisplayLayout.Bands(0).Columns("id_convenio").Hidden = False
        ugConvenios.DisplayLayout.Bands(0).Columns("id_convenio").Header.VisiblePosition = 3
        Listas.CambiarTituloColumna(ugConvenios, "id_convenio", "Cod.Convenio")
        '=======================================================================

        Me.Text = Titulo.ToString
    End Sub

    Private Sub OcultarControlesGrillaPendiente()

        Dim Titulo As New StringBuilder(Me.Text)

        If mTipoConvenioApertura = TipoConvenio.Tarifa Then
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Hidden = True
        ElseIf mTipoConvenioApertura = TipoConvenio.Descuento Then
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = False
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = False
        ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_1").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_2").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_3").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_4").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Venta_5").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_1").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_2").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_3").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_4").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Desc_Compra_5").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Venta").Hidden = True
            ugConveniosEnviados.DisplayLayout.Bands(0).Columns("Imp_Neto_Compra").Hidden = True
        End If

        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("id_convenio").Hidden = False
        ugConveniosEnviados.DisplayLayout.Bands(0).Columns("id_convenio").Header.VisiblePosition = 3
        Listas.CambiarTituloColumna(ugConveniosEnviados, "id_convenio", "Cod.Convenio")

    End Sub

    Private Sub AplicarFormatoHora(ByVal pTexto As QUETOOL.txtTexto, ByVal pInicio As Boolean)
        If mClosePage Then Return
        Dim Hora As String = pTexto.Text.Trim
        If Hora <> String.Empty Then
            If Not AplicarFormatoHora(Hora, pInicio) Then
                pTexto.Text = String.Empty
                pTexto.Focus()
                Exit Sub
            End If
        Else
            pTexto.Text = String.Empty
        End If
    End Sub

    Private Function AplicarFormatoHora(ByVal pHora As String, ByVal pInicio As Boolean) As Boolean
        Dim Message As New StringBuilder
        Dim HoraFinal As New StringBuilder
        Dim ParteHora As String() = pHora.Split(":")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789:"

        Message.Append("El Formato de la Hora es incorrecta.")
        Message.Append(vbCrLf)

        'Valida que no existan caracteres no permitidos
        If Not ValidarCaracteres(pHora, CaracteresPermitidos) OrElse ParteHora.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda de la hora
        Parte = String.Empty
        For Index As Integer = 0 To ParteHora(0).Length - 1
            If ParteHora(0).Substring(Index, 1) <> 0 Then
                Parte = ParteHora(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteHora(0) = Parte
        Else
            ParteHora(0) = 0
        End If

        If ParteHora.Length = 1 Then 'No se ingresó ":"
            If ParteHora(0) = 0 Then 'Si escribio solo ceros
                If pInicio Then
                    TxtHInicio.Text = String.Empty
                Else
                    TxtHFin.Text = String.Empty
                End If
                Return True
            End If
            Select Case ParteHora(0).Length
                Case 1
                    If ParteHora(0) < 6 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append("0")
                    HoraFinal.Append(ParteHora(0))
                    HoraFinal.Append(":")
                    If pInicio Then
                        HoraFinal.Append("00")
                    Else
                        HoraFinal.Append("59")
                    End If
                Case 2
                    If ParteHora(0) > 29 AndAlso ParteHora(0).Substring(1, 1) > 5 Then
                        Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0) <= 29 Then
                        If ParteHora(0) < 10 Then
                            HoraFinal.Append("0")
                        End If
                        HoraFinal.Append(ParteHora(0))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0) <= 29 Then
                        If pInicio Then
                            HoraFinal.Append("00")
                        Else
                            HoraFinal.Append("59")
                        End If
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 1))
                        HoraFinal.Append("0")
                    End If
                Case 3
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        If ParteHora(0).Substring(1, 2) > 59 Then
                            Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    Else
                        If ParteHora(0).Substring(2, 1) > 5 Then
                            Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    End If
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(2, 1))
                        HoraFinal.Append("0")
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 2))
                    End If
                Case 4
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0).Substring(2, 2) > 59 Then
                        Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    HoraFinal.Append(":")
                    HoraFinal.Append(ParteHora(0).Substring(2, 2))
                Case 5
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
            End Select
        Else
            'Valida si hay solo ceros en los minutos
            Parte = String.Empty
            For Index As Integer = 0 To ParteHora(1).Length - 1
                If ParteHora(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteHora(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteHora(1) = 0
            End If
            If ParteHora(0) = 0 AndAlso ParteHora(1) = 0 Then
                If pInicio Then
                    TxtHInicio.Text = String.Empty
                Else
                    TxtHFin.Text = String.Empty
                End If
                Return True
            End If
            If ParteHora(0) < 6 OrElse ParteHora(0) > 29 Then
                Message.Append("La hora debe ser mayor a 6 y menor a 29")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
            If ParteHora(1) <> String.Empty Then
                If ParteHora(1) < 0 OrElse (ParteHora(1).Length = 1 AndAlso ParteHora(1) > 5) OrElse ParteHora(1) > 59 Then
                    Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
                If ParteHora(0) = 29 AndAlso ParteHora(1) > 59 Then
                    Message.Append("La hora debe ser mayor a 6:00 y menor a 29:59")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
            End If
            If ParteHora(0).Length = 1 Then
                HoraFinal.Append("0")
            End If
            HoraFinal.Append(ParteHora(0))
            HoraFinal.Append(":")
            If ParteHora(1) <> String.Empty Then
                HoraFinal.Append(ParteHora(1))
                If ParteHora(1).Length = 1 Then
                    HoraFinal.Append("0")
                End If
            Else
                If pInicio Then
                    HoraFinal.Append("00")
                Else
                    HoraFinal.Append("59")
                End If
            End If
        End If
        If pInicio Then
            TxtHInicio.Text = HoraFinal.ToString
        Else
            TxtHFin.Text = HoraFinal.ToString
        End If
        Return True
    End Function

    Private Sub AplicarFormatoImporte(ByVal pTexto As QUETOOL.txtTexto, ByVal pVenta As Boolean)
        If mClosePage Then Return
        Dim Importe As String = pTexto.Text.Replace("$", "").Trim
        If Importe <> String.Empty Then
            If Not AplicarFormatoImporte(Importe, pVenta) Then
                pTexto.Text = "$ 0.00"
                pTexto.Focus()
            End If
        Else
            pTexto.Text = "$ 0.00"
        End If
    End Sub

    Private Function AplicarFormatoImporte(ByVal pImporte As String, ByVal pVenta As Boolean) As Boolean
        Dim Message As New StringBuilder
        Dim ImporteFinal As New StringBuilder
        Dim ParteImporte As String() = pImporte.Split(".")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789."

        Message.Append("El Importe es incorrecto.")
        Message.Append(vbCrLf)

        If Not ValidarCaracteres(pImporte, CaracteresPermitidos) OrElse ParteImporte.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda del importe
        Parte = String.Empty
        For Index As Integer = 0 To ParteImporte(0).Length - 1
            If ParteImporte(0).Substring(Index, 1) <> 0 Then
                Parte = ParteImporte(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteImporte(0) = Parte
        Else
            ParteImporte(0) = 0
        End If

        If ParteImporte.Length = 2 Then 'Se ingresó "." (decimal)
            Parte = String.Empty
            For Index As Integer = 0 To ParteImporte(1).Length - 1
                If ParteImporte(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteImporte(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteImporte(1) = 0
            End If
            If ParteImporte(1).Length > 2 Then
                Message.Append("Los centavos deben ser menor a 99")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
        End If
        If ParteImporte(0).Length > 9 Then
            Message.Append("El importe debe ser menor a 999999999")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        ImporteFinal.Append("$ ")
        ImporteFinal.Append(ParteImporte(0))
        ImporteFinal.Append(".")
        If ParteImporte.Length = 2 Then
            ImporteFinal.Append(ParteImporte(1))
            If ParteImporte(1).Length = 1 Then
                ImporteFinal.Append("0")
            End If
        Else
            ImporteFinal.Append("00")
        End If

        If pVenta Then
            TxtImporteVenta.Text = ImporteFinal.ToString
        Else
            TxtImporteCompra.Text = ImporteFinal.ToString
        End If
        Return True
    End Function

    Private Sub AplicarFormatoPorcentajeCompra(ByVal pTexto As QUETOOL.txtTexto)
        If mClosePage Then Return
        Dim Descuento As String = pTexto.Text.Trim
        If Descuento <> String.Empty Then
            If Not AplicarFormatoPorcentajeCompra(pTexto, Descuento) Then
                pTexto.Text = "0.00"
                pTexto.Focus()
            End If
        Else
            pTexto.Text = "0.00"
        End If
    End Sub

    Private Sub AplicarFormatoPorcentaje(ByVal pTexto As QUETOOL.txtTexto)
        If mClosePage Then Return
        Dim Descuento As String = pTexto.Text.Trim
        If Descuento <> String.Empty Then
            If Not AplicarFormatoPorcentaje(pTexto, Descuento) Then
                pTexto.Text = "0.00"
                pTexto.Focus()
            End If
        Else
            pTexto.Text = "0.00"
        End If
    End Sub

    Private Function AplicarFormatoPorcentajeCompra(ByVal pTexto As QUETOOL.txtTexto, ByVal pDescuento As String) As Boolean
        Dim Message As New StringBuilder
        Dim DescuentoFinal As New StringBuilder
        Dim ParteDescuento As String() = pDescuento.Split(".")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789.-"
        Dim bEsNegativo As Boolean = False
        Message.Append("El Descuento es incorrecto.")
        Message.Append(vbCrLf)

        If Not ValidarCaracteres(pDescuento, CaracteresPermitidos) OrElse ParteDescuento.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda del importe
        Parte = String.Empty

        For Index As Integer = 0 To ParteDescuento(0).Length - 1
            ''MODIFICACION PARA PODER GUARDAR DESCUENTOS EN NEGATIVO(RECARGOS) DCAIME
            If ParteDescuento(0).Contains("-") Then
                bEsNegativo = True
                ParteDescuento(0) = ParteDescuento(0).Replace("-", "")
            End If
            If ParteDescuento(0).Substring(Index, 1) <> 0 Then
                Parte = ParteDescuento(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteDescuento(0) = Parte
        Else
            ParteDescuento(0) = 0
        End If

        If ParteDescuento.Length = 2 Then 'Se ingresó "." (decimal)
            Parte = String.Empty
            For Index As Integer = 0 To ParteDescuento(1).Length - 1
                If ParteDescuento(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteDescuento(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteDescuento(1) = 0
            End If
            If ParteDescuento(1).Length > 2 Then
                Message.Append("Los decimales del porcentaje deben ser menor a 99")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
        End If
        If ParteDescuento(0) > 100 OrElse (ParteDescuento(0) = 100 AndAlso ParteDescuento.Length = 2 AndAlso ParteDescuento(1) > 0) Then
            Message.Append("El porcentaje debe ser menor o igual a 100")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        If bEsNegativo = True Then
            DescuentoFinal.Append("-" & ParteDescuento(0))
        Else
            DescuentoFinal.Append(ParteDescuento(0))
        End If

        bEsNegativo = False
        DescuentoFinal.Append(".")
        If ParteDescuento.Length = 2 Then
            DescuentoFinal.Append(ParteDescuento(1))
            If ParteDescuento(1).Length = 1 Then
                DescuentoFinal.Append("0")
            End If
        Else
            DescuentoFinal.Append("00")
        End If

        pTexto.Text = DescuentoFinal.ToString
        Return True
    End Function

    Private Function AplicarFormatoPorcentaje(ByVal pTexto As QUETOOL.txtTexto, ByVal pDescuento As String) As Boolean
        Dim Message As New StringBuilder
        Dim DescuentoFinal As New StringBuilder
        Dim ParteDescuento As String() = pDescuento.Split(".")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789.-"
        Dim bEsNegativo As Boolean = False

        Message.Append("El Descuento es incorrecto.")
        Message.Append(vbCrLf)

        If Not ValidarCaracteres(pDescuento, CaracteresPermitidos) OrElse ParteDescuento.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda del importe
        Parte = String.Empty
        For Index As Integer = 0 To ParteDescuento(0).Length - 1
            'AG 03/11/2010 -------------------------------------------------
            If ParteDescuento(0).Contains("-") Then
                bEsNegativo = True
                ParteDescuento(0) = ParteDescuento(0).Replace("-", "")
            End If
            '--------------------------------------------------------------------
            If ParteDescuento(0).Substring(Index, 1) <> 0 Then
                Parte = ParteDescuento(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteDescuento(0) = Parte
        Else
            ParteDescuento(0) = 0
        End If

        If ParteDescuento.Length = 2 Then 'Se ingresó "." (decimal)
            Parte = String.Empty
            For Index As Integer = 0 To ParteDescuento(1).Length - 1
                If ParteDescuento(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteDescuento(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteDescuento(1) = 0
            End If
            If ParteDescuento(1).Length > 2 Then
                Message.Append("Los decimales del porcentaje deben ser menor a 99")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
        End If
        If ParteDescuento(0) > 100 OrElse (ParteDescuento(0) = 100 AndAlso ParteDescuento.Length = 2 AndAlso ParteDescuento(1) > 0) Then
            Message.Append("El porcentaje debe ser menor o igual a 100")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        If bEsNegativo = True Then
            DescuentoFinal.Append("-" & ParteDescuento(0))
        Else
            DescuentoFinal.Append(ParteDescuento(0))
        End If

        bEsNegativo = False

        'DescuentoFinal.Append(ParteDescuento(0))
        DescuentoFinal.Append(".")
        If ParteDescuento.Length = 2 Then
            DescuentoFinal.Append(ParteDescuento(1))
            If ParteDescuento(1).Length = 1 Then
                DescuentoFinal.Append("0")
            End If
        Else
            DescuentoFinal.Append("00")
        End If

        pTexto.Text = DescuentoFinal.ToString
        Return True
    End Function

    Private Function ValidarCaracteres(ByVal pValor As String, ByVal pCaracteresPermitidos As String) As Boolean
        Dim Existe As Boolean
        For Index As Integer = 0 To pValor.Length - 1
            Existe = False
            For IndexCaracter As Integer = 0 To pCaracteresPermitidos.Length - 1
                If pValor.Substring(Index, 1) = pCaracteresPermitidos.Substring(IndexCaracter, 1) Then
                    Existe = True
                    Exit For
                End If
            Next
            If Not Existe Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub ValidarDiaSemana(ByVal pDia As DiasSemana)
        If mChkGeneral Then Return
        mChkParticular = True
        Select Case pDia
            Case DiasSemana.Lunes, DiasSemana.Martes, DiasSemana.Miercoles, DiasSemana.Jueves, DiasSemana.Viernes
                If ChkLunes.Checked AndAlso ChkMartes.Checked AndAlso ChkMiercoles.Checked AndAlso ChkJueves.Checked AndAlso ChkViernes.Checked Then
                    ChkLunesViernes.Checked = True
                ElseIf Not ChkLunes.Checked OrElse Not ChkMartes.Checked OrElse Not ChkMiercoles.Checked OrElse Not ChkJueves.Checked OrElse Not ChkViernes.Checked Then
                    ChkLunesViernes.Checked = False
                End If
            Case DiasSemana.Sabado, DiasSemana.Domingo
                If ChkSabado.Checked AndAlso ChkDomingo.Checked Then
                    ChkSabadoDomingo.Checked = True
                ElseIf Not ChkSabado.Checked OrElse Not ChkDomingo.Checked Then
                    ChkSabadoDomingo.Checked = False
                End If
        End Select
        mChkParticular = False
    End Sub

    Private Sub BuscarMedios()

        Dim Medios As New Soportes
        Dim dtMedio As DataTable

        'AG 30/12/2015 Velocidad =============
        'dtMedio = Medios.ObtenerMediosConvenios
        dtMedio = Activo.DTMediosCache
        '=====================================

        Call Combo_Load(cboMedio, dtMedio, "Descripcion", False)
    End Sub

    Private Sub CargarTipoSoporte(ByVal pIdMedio As Integer)
        Dim TS As New Tipos_soporte
        Dim TSoportes As DataTable

        TS.Id_medio = pIdMedio
        TSoportes = TS.TraerTipoSoporteMedio
        Call Combo_Load(cboTipoSoporte, TSoportes, "Descripcion", False)
    End Sub

    Private Sub Combo_Load(ByVal pCombo As UltraComboEditor, ByVal pDataTable As DataTable, ByVal pDisplay As String, ByVal pObligatorio As Boolean)
        pCombo.Items.Clear()
        pCombo.Enabled = True
        If pDataTable Is Nothing OrElse pDataTable.Rows.Count = 0 Then
            pCombo.Enabled = False
        Else
            Combo_Populate(pCombo, pDataTable, pDisplay, Not pObligatorio)
        End If
    End Sub

    Private Sub Combo_Populate(ByRef pCombo As UltraComboEditor, ByVal pobjTable As DataTable, ByVal pstrDisplayText As String, Optional ByVal pblnEsSeleccioneOpcion As Boolean = True)
        Dim objItem As ValueListItem
        Dim objRow As DataRow

        If pblnEsSeleccioneOpcion = True Then
            objItem = New ValueListItem
            objItem.DisplayText = ""
            objItem.DataValue = Nothing
            pCombo.Items.Add(objItem)
        End If

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow(pstrDisplayText)
            pCombo.Items.Add(objItem)
        Next

        If pCombo.Items.Count <> 0 Then
            pCombo.SelectedIndex = 0
        End If
    End Sub

    Private Sub Combo_Position(ByVal pCombo As UltraComboEditor, ByVal pColumnName As String, ByVal pValue As String)
        For ItemCount As Integer = 0 To pCombo.Items.Count - 1
            If Not pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue Is Nothing AndAlso pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue(pColumnName) = pValue Then
                pCombo.SelectedIndex = ItemCount
                Return
            End If
        Next
        pCombo.SelectedIndex = 0
    End Sub

    Private Sub HabilitarControles(ByVal pHabilitar As Boolean)
        TxtHInicio.Enabled = pHabilitar
        TxtHFin.Enabled = pHabilitar
        TxtImporteVenta.Enabled = pHabilitar
        TxtImporteCompra.Enabled = pHabilitar
        ChkLunesViernes.Enabled = pHabilitar
        ChkSabadoDomingo.Enabled = pHabilitar
        ChkLunes.Enabled = pHabilitar
        ChkMartes.Enabled = pHabilitar
        ChkMiercoles.Enabled = pHabilitar
        ChkJueves.Enabled = pHabilitar
        ChkViernes.Enabled = pHabilitar
        ChkSabado.Enabled = pHabilitar
        ChkDomingo.Enabled = pHabilitar
        DtpFInicio.Enabled = pHabilitar
        DtpFFin.Enabled = pHabilitar
        TxtNroConvenio.Enabled = pHabilitar

        TxtDetalle.Enabled = pHabilitar
        TxtParticipacion.Enabled = pHabilitar
        TxtObsVenta.Enabled = pHabilitar
        TxtObsCompra.Enabled = pHabilitar

        TxtDctoVenta1.Enabled = pHabilitar
        TxtDctoVenta2.Enabled = pHabilitar
        TxtDctoVenta3.Enabled = pHabilitar
        TxtDctoVenta4.Enabled = pHabilitar
        TxtDctoVenta5.Enabled = pHabilitar
        TxtDctoCompra1.Enabled = pHabilitar
        TxtDctoCompra2.Enabled = pHabilitar
        TxtDctoCompra3.Enabled = pHabilitar
        TxtDctoCompra4.Enabled = pHabilitar
        TxtDctoCompra5.Enabled = pHabilitar

        'TxtDescuentoExtra1.Enabled = pHabilitar
        'TxtDescuentoExtra2.Enabled = pHabilitar
        'TxtObsFinanza.Enabled = pHabilitar

        Me.txtcpr.Enabled = pHabilitar
        Me.ChkSinRentabilidad.Enabled = pHabilitar
        Me.ChkConRentabilidad.Enabled = pHabilitar

        'If Me.ChkSinRentabilidad.Enabled = False And Me.ChkConRentabilidad.Enabled = False Then
        TxtDescuentoExtra1.Enabled = pHabilitar
        TxtDescuentoExtra2.Enabled = pHabilitar
        'End If
    End Sub

    Private Function CargarConvenios() As Boolean

        Dim Cliente As String = txtCodCliente.Text.Trim
        Dim Medio As String = TxtCodMedio.Text.Trim
        Dim Soporte As String = TxtCodSoporte.Text.Trim
        Dim Producto As String = TxtCodProducto.Text.Trim
        Dim ParteCompleto As String()
        Dim Parte As ArrayList
        Dim Index, ParteLength As Integer
        Dim Filtro As StringBuilder

        If Cliente = String.Empty Then
            Mensaje("Debe seleccionar un cliente.", TipoMensaje.Informacion)
            Return False
        End If
        If Medio = String.Empty Then
            Mensaje("Debe seleccionar un medio.", TipoMensaje.Informacion)
            Return False
        End If
        If Soporte = String.Empty Then
            Mensaje("Debe seleccionar un soporte.", TipoMensaje.Informacion)
            Return False
        End If
        If Producto = String.Empty Then
            Producto = -1
        End If



        Dim Convenio As New Convenios
        Dim dtConvenios As DataTable

        Convenio.Id_cliente = Cliente
        Convenio.Id_medio = Medio
        Convenio.Id_soporte = Soporte
        'AG TC ===============================================================
        If ITipoConfidencial = TipoConfidencial.SinRentabilidad Then
            Me.ChkSinRentabilidad.Checked = True
            Me.ChkConRentabilidad.Checked = False
        ElseIf ITipoConfidencial = TipoConfidencial.ConRentabilidad Then
            Me.ChkConRentabilidad.Checked = True
            Me.ChkSinRentabilidad.Checked = False
        End If
        '=====================================================================

        dtConvenios = Convenio.ObtenerConvenios(2, -1, Producto)
        mdtConvenioGrilla.Rows.Clear()
        'AG 23/04/2015 ==================================
        mdtConvenioPendienteGrilla.Rows.Clear()
        '================================================

        If Not dtConvenios Is Nothing AndAlso dtConvenios.Rows.Count > 0 Then
            Filtro = New StringBuilder
            Filtro.Append("Tipo_Convenio = '")
            If mTipoConvenioApertura = TipoConvenio.Tarifa Then
                Filtro.Append("T'")
            ElseIf mTipoConvenioApertura = TipoConvenio.Descuento Then
                Filtro.Append("D'")
            ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then 'AG CCPR
                Filtro.Append("C'")
            End If
            For Each drConvenios As DataRow In dtConvenios.Select(Filtro.ToString, "Convenio DESC")
                mdrConvenioGrilla = mdtConvenioGrilla.NewRow

                If mTipoConvenioApertura = TipoConvenio.CPR Then
                    If drConvenios("CPR") Is DBNull.Value Then
                        mdrConvenioGrilla("Cpr") = 0
                    Else
                        mdrConvenioGrilla("Cpr") = drConvenios("CPR") 'AG CCPR
                    End If
                End If
                mdrConvenioGrilla("Cod_Medio") = drConvenios("id_medio")
                mdrConvenioGrilla("Cod_Soporte") = drConvenios("Cod_Soporte")
                mdrConvenioGrilla("Cod_Cliente") = drConvenios("id_cliente")
                mdrConvenioGrilla("Cod_Producto") = drConvenios("id_Producto")
                mdrConvenioGrilla("Cod_Convenio") = drConvenios("Convenio")
                'AG 09/06/2014 ===================================================
                mdrConvenioGrilla("id_Convenio") = drConvenios("id_Convenio")
                '==================================================================
                mdrConvenioGrilla("Fec_Inicio") = drConvenios("Fecha Inicio")
                mdrConvenioGrilla("Fec_Fin") = drConvenios("Fecha Fin")
                mdrConvenioGrilla("Detalle") = drConvenios("Detalle")
                mdrConvenioGrilla("Participacion") = drConvenios("Participacion")
                mdrConvenioGrilla("Programa") = drConvenios("Programa")
                If drConvenios("Desc Venta") <> String.Empty Then
                    ParteCompleto = drConvenios("Desc Venta").ToString.Split(" ")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 5 Then
                        mdrConvenioGrilla("Desc_Venta_1") = Parte(0).ToString
                        mdrConvenioGrilla("Desc_Venta_2") = Parte(1).ToString
                        mdrConvenioGrilla("Desc_Venta_3") = Parte(2).ToString
                        mdrConvenioGrilla("Desc_Venta_4") = Parte(3).ToString
                        mdrConvenioGrilla("Desc_Venta_5") = Parte(4).ToString
                    End If
                End If

                If drConvenios("Desc Compra") <> String.Empty Then
                    ParteCompleto = drConvenios("Desc Compra").ToString.Split(" ")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 5 Then
                        mdrConvenioGrilla("Desc_Compra_1") = Parte(0).ToString
                        mdrConvenioGrilla("Desc_Compra_2") = Parte(1).ToString
                        mdrConvenioGrilla("Desc_Compra_3") = Parte(2).ToString
                        mdrConvenioGrilla("Desc_Compra_4") = Parte(3).ToString
                        mdrConvenioGrilla("Desc_Compra_5") = Parte(4).ToString
                    End If
                End If

                If drConvenios("Desc Extra") <> String.Empty Then
                    ParteCompleto = drConvenios("Desc Extra").ToString.Split(" ")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 2 Then
                        mdrConvenioGrilla("Desc_Extra_1") = Parte(0)
                        mdrConvenioGrilla("Desc_Extra_2") = Parte(1)
                    End If
                End If
                mdrConvenioGrilla("Imp_Neto_Venta") = drConvenios("Importe Venta")
                mdrConvenioGrilla("Imp_Neto_Compra") = drConvenios("Importe Compra")
                mdrConvenioGrilla("Obs_Compra") = drConvenios("obs compra")
                mdrConvenioGrilla("Obs_Venta") = drConvenios("obs venta")
                If drConvenios("obs finanza") Is DBNull.Value Then
                    mdrConvenioGrilla("Obs_Finanzas") = String.Empty
                Else
                    mdrConvenioGrilla("Obs_Finanzas") = drConvenios("obs finanza")
                End If
                'AG TC ================================================
                If drConvenios("TCONFIDENCIAL") Is DBNull.Value Then
                    mdrConvenioGrilla("TCONFIDENCIAL") = -1
                Else
                    mdrConvenioGrilla("TCONFIDENCIAL") = drConvenios("TCONFIDENCIAL") 'AG CCPR
                End If
                '=====================================================
                mdrConvenioGrilla("Semana") = drConvenios("Semana")
                mdrConvenioGrilla("Id_Convenio") = drConvenios("Id_Convenio")
                mdrConvenioGrilla("Tipo_Convenio") = drConvenios("Tipo_Convenio")

                If drConvenios("Hora") <> String.Empty Then
                    ParteCompleto = drConvenios("Hora").ToString.Split("a")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 2 Then
                        If Parte(0).ToString.Trim <> ":" Then
                            mdrConvenioGrilla("Hora_Inicio") = Parte(0)
                        Else
                            mdrConvenioGrilla("Hora_Inicio") = String.Empty
                        End If
                        If Parte(1).ToString.Trim <> ":" Then
                            mdrConvenioGrilla("Hora_Fin") = Parte(1)
                        Else
                            mdrConvenioGrilla("Hora_Fin") = String.Empty
                        End If
                    End If
                End If

                mdtConvenioGrilla.Rows.Add(mdrConvenioGrilla)
            Next
        End If
        Return True
    End Function

    Private Function CargarConveniosPendientes() As Boolean

        'AG 23/04/2015 =====================================================

        Dim Cliente As String = txtCodCliente.Text.Trim
        Dim Medio As String = TxtCodMedio.Text.Trim
        Dim Soporte As String = TxtCodSoporte.Text.Trim
        Dim Producto As String = TxtCodProducto.Text.Trim

        Dim ParteCompleto As String()
        Dim Parte As ArrayList
        Dim Index, ParteLength As Integer
        Dim Filtro As StringBuilder

        If Producto = String.Empty Then
            Producto = -1
        End If

        Dim Convenio As New Convenios
        Dim dtConveniosEnviados As DataTable

        Convenio.Id_cliente = Cliente
        Convenio.Id_medio = Medio
        Convenio.Id_soporte = Soporte

        'AG TC ===============================================================
        'If ITipoConfidencial = TipoConfidencial.SinRentabilidad Then
        '    Me.ChkSinRentabilidad.Checked = True
        '    Me.ChkConRentabilidad.Checked = False
        'ElseIf ITipoConfidencial = TipoConfidencial.ConRentabilidad Then
        '    Me.ChkConRentabilidad.Checked = True
        '    Me.ChkSinRentabilidad.Checked = False
        'End If
        '=====================================================================

        dtConveniosEnviados = Convenio.ObtenerConveniosPendientes(2, -1, Producto)
        mdtConvenioPendienteGrilla.Rows.Clear()


        If Not dtConveniosEnviados Is Nothing AndAlso dtConveniosEnviados.Rows.Count > 0 Then

            Filtro = New StringBuilder
            Filtro.Append("Tipo_Convenio = '")
            If mTipoConvenioApertura = TipoConvenio.Tarifa Then
                Filtro.Append("T'")
            ElseIf mTipoConvenioApertura = TipoConvenio.Descuento Then
                Filtro.Append("D'")
            ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then 'AG CCPR
                Filtro.Append("C'")
            End If

            For Each drConveniosenviados As DataRow In dtConveniosEnviados.Select(Filtro.ToString, "Convenio DESC")
                mdrConvenioPendienteGrilla = mdtConvenioPendienteGrilla.NewRow

                If mTipoConvenioApertura = TipoConvenio.CPR Then
                    If drConveniosenviados("CPR") Is DBNull.Value Then
                        mdrConvenioPendienteGrilla("Cpr") = 0
                    Else
                        mdrConvenioPendienteGrilla("Cpr") = drConveniosenviados("CPR")
                    End If
                End If

                mdrConvenioPendienteGrilla("Estado") = drConveniosenviados("Estado")

                mdrConvenioPendienteGrilla("Cod_Medio") = drConveniosenviados("id_medio")
                mdrConvenioPendienteGrilla("Cod_Soporte") = drConveniosenviados("Cod_Soporte")
                mdrConvenioPendienteGrilla("Cod_Cliente") = drConveniosenviados("id_cliente")
                mdrConvenioPendienteGrilla("Cod_Producto") = drConveniosenviados("id_Producto")
                mdrConvenioPendienteGrilla("Cod_Convenio") = drConveniosenviados("Convenio")
                mdrConvenioPendienteGrilla("id_Convenio") = drConveniosenviados("id_Convenio")
                mdrConvenioPendienteGrilla("Fec_Inicio") = drConveniosenviados("Fecha Inicio")
                mdrConvenioPendienteGrilla("Fec_Fin") = drConveniosenviados("Fecha Fin")
                mdrConvenioPendienteGrilla("Detalle") = drConveniosenviados("Detalle")
                mdrConvenioPendienteGrilla("Participacion") = drConveniosenviados("Participacion")
                mdrConvenioPendienteGrilla("Programa") = drConveniosenviados("Programa")


                If drConveniosenviados("Desc Venta") <> String.Empty Then

                    ParteCompleto = drConveniosenviados("Desc Venta").ToString.Split(" ")
                    Parte = New ArrayList

                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 5 Then
                        mdrConvenioPendienteGrilla("Desc_Venta_1") = Parte(0).ToString
                        mdrConvenioPendienteGrilla("Desc_Venta_2") = Parte(1).ToString
                        mdrConvenioPendienteGrilla("Desc_Venta_3") = Parte(2).ToString
                        mdrConvenioPendienteGrilla("Desc_Venta_4") = Parte(3).ToString
                        mdrConvenioPendienteGrilla("Desc_Venta_5") = Parte(4).ToString
                    End If
                End If

                If drConveniosenviados("Desc Compra") <> String.Empty Then
                    ParteCompleto = drConveniosenviados("Desc Compra").ToString.Split(" ")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 5 Then
                        mdrConvenioPendienteGrilla("Desc_Compra_1") = Parte(0).ToString
                        mdrConvenioPendienteGrilla("Desc_Compra_2") = Parte(1).ToString
                        mdrConvenioPendienteGrilla("Desc_Compra_3") = Parte(2).ToString
                        mdrConvenioPendienteGrilla("Desc_Compra_4") = Parte(3).ToString
                        mdrConvenioPendienteGrilla("Desc_Compra_5") = Parte(4).ToString
                    End If
                End If

                If drConveniosenviados("Desc Extra") <> String.Empty Then

                    ParteCompleto = drConveniosenviados("Desc Extra").ToString.Split(" ")
                    Parte = New ArrayList

                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 2 Then
                        mdrConvenioPendienteGrilla("Desc_Extra_1") = Parte(0)
                        mdrConvenioPendienteGrilla("Desc_Extra_2") = Parte(1)
                    End If
                End If

                mdrConvenioPendienteGrilla("Imp_Neto_Venta") = drConveniosenviados("Importe Venta")
                mdrConvenioPendienteGrilla("Imp_Neto_Compra") = drConveniosenviados("Importe Compra")
                mdrConvenioPendienteGrilla("Obs_Compra") = drConveniosenviados("obs compra")
                mdrConvenioPendienteGrilla("Obs_Venta") = drConveniosenviados("obs venta")

                If drConveniosenviados("obs finanza") Is DBNull.Value Then
                    mdrConvenioPendienteGrilla("Obs_Finanzas") = String.Empty
                Else
                    mdrConvenioPendienteGrilla("Obs_Finanzas") = drConveniosenviados("obs finanza")
                End If

                If drConveniosenviados("TCONFIDENCIAL") Is DBNull.Value Then
                    mdrConvenioPendienteGrilla("TCONFIDENCIAL") = -1
                Else
                    mdrConvenioPendienteGrilla("TCONFIDENCIAL") = drConveniosenviados("TCONFIDENCIAL") 'AG CCPR
                End If

                mdrConvenioPendienteGrilla("Semana") = drConveniosenviados("Semana")
                mdrConvenioPendienteGrilla("Id_Convenio") = drConveniosenviados("Id_Convenio")
                mdrConvenioPendienteGrilla("Tipo_Convenio") = drConveniosenviados("Tipo_Convenio")

                If drConveniosenviados("Hora") <> String.Empty Then

                    ParteCompleto = drConveniosenviados("Hora").ToString.Split("a")
                    Parte = New ArrayList
                    For Index = 0 To ParteCompleto.Length - 1
                        If ParteCompleto(Index) <> String.Empty Then
                            Parte.Add(ParteCompleto(Index))
                        End If
                    Next

                    If Parte.Count = 2 Then
                        If Parte(0).ToString.Trim <> ":" Then
                            mdrConvenioPendienteGrilla("Hora_Inicio") = Parte(0)
                        Else
                            mdrConvenioPendienteGrilla("Hora_Inicio") = String.Empty
                        End If
                        If Parte(1).ToString.Trim <> ":" Then
                            mdrConvenioPendienteGrilla("Hora_Fin") = Parte(1)
                        Else
                            mdrConvenioPendienteGrilla("Hora_Fin") = String.Empty
                        End If
                    End If
                End If

                mdtConvenioPendienteGrilla.Rows.Add(mdrConvenioPendienteGrilla)
            Next
        End If

        Return True

    End Function

    Private Sub PopularDatos()
        Dim Semana As String = ugConvenios.ActiveRow.Cells("Semana").Text
        If Semana <> String.Empty AndAlso Semana.Length = 7 Then
            For Index As Integer = 0 To Semana.Length - 1
                Select Case Index
                    Case 0
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkLunes.Checked = True
                        Else
                            ChkLunes.Checked = False
                        End If
                    Case 1
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkMartes.Checked = True
                        Else
                            ChkMartes.Checked = False
                        End If
                    Case 2
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkMiercoles.Checked = True
                        Else
                            ChkMiercoles.Checked = False
                        End If
                    Case 3
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkJueves.Checked = True
                        Else
                            ChkJueves.Checked = False
                        End If
                    Case 4
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkViernes.Checked = True
                        Else
                            ChkViernes.Checked = False
                        End If
                    Case 5
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkSabado.Checked = True
                        Else
                            ChkSabado.Checked = False
                        End If
                    Case 6
                        If Semana.Substring(Index, 1).ToUpper = "S" Then
                            ChkDomingo.Checked = True
                        Else
                            ChkDomingo.Checked = False
                        End If
                End Select
            Next
        End If

        TxtHInicio.Text = ugConvenios.ActiveRow.Cells("Hora_Inicio").Text
        TxtHFin.Text = ugConvenios.ActiveRow.Cells("Hora_Fin").Text
        TxtImporteVenta.Text = ugConvenios.ActiveRow.Cells("Imp_Neto_Venta").Text
        TxtImporteCompra.Text = ugConvenios.ActiveRow.Cells("Imp_Neto_Compra").Text
        DtpFInicio.Value = Convert.ToDateTime(ugConvenios.ActiveRow.Cells("Fec_Inicio").Text)
        DtpFFin.Value = Convert.ToDateTime(ugConvenios.ActiveRow.Cells("Fec_Fin").Text)
        TxtNroConvenio.Text = ugConvenios.ActiveRow.Cells("Cod_Convenio").Text
        TxtIdConvenio.Text = ugConvenios.ActiveRow.Cells("Id_Convenio").Text
        TxtDescuentoExtra1.Text = ugConvenios.ActiveRow.Cells("Desc_Extra_1").Text
        TxtDescuentoExtra2.Text = ugConvenios.ActiveRow.Cells("Desc_Extra_2").Text
        TxtDetalle.Text = ugConvenios.ActiveRow.Cells("Detalle").Text
        TxtParticipacion.Text = ugConvenios.ActiveRow.Cells("Participacion").Text
        TxtObsVenta.Text = ugConvenios.ActiveRow.Cells("Obs_Venta").Text
        TxtObsCompra.Text = ugConvenios.ActiveRow.Cells("Obs_Compra").Text
        TxtObsFinanza.Text = ugConvenios.ActiveRow.Cells("Obs_Finanzas").Text
        TxtDctoVenta1.Text = ugConvenios.ActiveRow.Cells("Desc_Venta_1").Text
        TxtDctoVenta2.Text = ugConvenios.ActiveRow.Cells("Desc_Venta_2").Text
        TxtDctoVenta3.Text = ugConvenios.ActiveRow.Cells("Desc_Venta_3").Text
        TxtDctoVenta4.Text = ugConvenios.ActiveRow.Cells("Desc_Venta_4").Text
        TxtDctoVenta5.Text = ugConvenios.ActiveRow.Cells("Desc_Venta_5").Text
        ''TxtDctoCompra1.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_1").Text ''CAMBIAMOS A VALUE.TOSTRING PORQUE NO TRANSFORMA BIEN EL VALOR, POR LO TANTO NO LO MUESTRA EN LA CAJA DE TEXTO  //DCAIME
        'TxtDctoCompra1.Text = IIf(ugConvenios.ActiveRow.Cells("Desc_Compra_1").Value = 0, ugConvenios.ActiveRow.Cells("Desc_Compra_1").Text, ugConvenios.ActiveRow.Cells("Desc_Compra_1").Value.ToString)
        'TxtDctoCompra2.Text = IIf(ugConvenios.ActiveRow.Cells("Desc_Compra_2").Value = 0, ugConvenios.ActiveRow.Cells("Desc_Compra_2").Text, ugConvenios.ActiveRow.Cells("Desc_Compra_2").Value.ToString)
        'TxtDctoCompra3.Text = IIf(ugConvenios.ActiveRow.Cells("Desc_Compra_3").Value = 0, ugConvenios.ActiveRow.Cells("Desc_Compra_3").Text, ugConvenios.ActiveRow.Cells("Desc_Compra_3").Value.ToString)
        'TxtDctoCompra4.Text = IIf(ugConvenios.ActiveRow.Cells("Desc_Compra_4").Value = 0, ugConvenios.ActiveRow.Cells("Desc_Compra_4").Text, ugConvenios.ActiveRow.Cells("Desc_Compra_4").Value.ToString)
        'TxtDctoCompra5.Text = IIf(ugConvenios.ActiveRow.Cells("Desc_Compra_5").Value = 0, ugConvenios.ActiveRow.Cells("Desc_Compra_5").Text, ugConvenios.ActiveRow.Cells("Desc_Compra_5").Value.ToString)
        TxtDctoCompra1.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_1").Text
        TxtDctoCompra2.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_2").Text
        TxtDctoCompra3.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_3").Text
        TxtDctoCompra4.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_4").Text
        TxtDctoCompra5.Text = ugConvenios.ActiveRow.Cells("Desc_Compra_5").Text

        'LFG - 30/03/2016
        TxtCodProducto.Text = ugConvenios.ActiveRow.Cells("Cod_Producto").Text
        If TxtCodProducto.Text.ToString <> "0" Then
            ObtenerDescripcionProducto()
        Else
            TxtCodProducto.Text = ""
            TxtProducto.Text = ""
        End If
        'LFG - 30/03/2016

        If mTipoConvenioApertura = TipoConvenio.CPR Then
            txtcpr.Text = ugConvenios.ActiveRow.Cells("Cpr").Text 'AG CCPR
        End If

        'AG TC ==================================================================================================
        If ugConvenios.ActiveRow.Cells("TCONFIDENCIAL").Text = "0" Then
            Me.ChkSinRentabilidad.Checked = True
            Me.ChkSinRentabilidad.CheckState = CheckState.Checked
            Me.ChkConRentabilidad.Checked = False
            Me.ChkConRentabilidad.CheckState = CheckState.Unchecked
            ITipoConfidencial = TipoConfidencial.SinRentabilidad
        ElseIf ugConvenios.ActiveRow.Cells("TCONFIDENCIAL").Text = "1" Then
            Me.ChkConRentabilidad.Checked = True
            Me.ChkConRentabilidad.CheckState = CheckState.Checked
            Me.ChkSinRentabilidad.Checked = False
            Me.ChkSinRentabilidad.CheckState = CheckState.Unchecked
            ITipoConfidencial = TipoConfidencial.ConRentabilidad
        ElseIf ugConvenios.ActiveRow.Cells("TCONFIDENCIAL").Text = "-1" Then
            Me.ChkConRentabilidad.Checked = False
            Me.ChkSinRentabilidad.Checked = False
            Me.ChkSinRentabilidad.CheckState = CheckState.Unchecked
            Me.ChkConRentabilidad.CheckState = CheckState.Unchecked
            ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
        End If
        '========================================================================================================
    End Sub

    Private Sub CargarHoraEspecial()
        If TxtHInicio.Enabled AndAlso TxtHFin.Enabled Then
            Dim CodigoMedio As String = TxtCodMedio.Text.Trim
            If CodigoMedio <> String.Empty Then
                Dim IdMedio As Integer = Convert.ToInt32(CodigoMedio)
                If IdMedio >= 3 AndAlso IdMedio <= 5 Then
                    TxtHInicio.Text = "06:00"
                    TxtHFin.Text = "29:59"
                    ChkLunes.Checked = True
                    ChkMartes.Checked = True
                    ChkMiercoles.Checked = True
                    ChkJueves.Checked = True
                    ChkViernes.Checked = True
                    ChkSabado.Checked = True
                    ChkDomingo.Checked = True
                End If
            End If
        End If
    End Sub

    Private Sub GrabarConvenio()

        If ValidarDatos() Then
            Dim Convenio As New Convenios
            Call ObtenerConvenio(Convenio)
            If TxtNroConvenio.Text.Trim = String.Empty Then
                'Nuevo convenio
                Convenio.Agregar()
            Else
                'Modificacion de convenio
                Convenio.Modificar()
            End If

            Dim producto As Integer = 0
            If Not String.IsNullOrEmpty(Me.TxtCodProducto.Text) Then
                producto = CInt(Me.TxtCodProducto.Text)
            End If

            'BORRO ANEXOS
            If Not String.IsNullOrEmpty(Me.TxtIdConvenio.Text) Then
                Convenio.BorrarAnexosConvenio(CInt(Me.TxtIdConvenio.Text))
            End If

            'GUARDO ANEXOS            
            For Each anexo As AnexoConvenio In Me.mAnexos
                Convenio.InsertarAnexoConvenio(CInt(Me.TxtCodMedio.Text), CInt(Me.TxtCodSoporte.Text), CInt(Me.txtCodCliente.Text), producto, anexo.Bytes, anexo.Extension, anexo.NombreArchivo)
            Next

            Call CargarConvenios()

            'AG 23/04/2015 ==========================
            mpbEnvioMail.Visible = True
            Call CargarConveniosPendientes()
            Call CambiarColorCelda()

            If pdtUsuarioSeleccionado.Rows.Count > 0 Then
                Dim Link As String
                Dim ClaveIdConvenios As String = GenerateNewGUID()

                If mTipoConvenioApertura = TipoConvenio.Descuento Then
                    Link = Convenio.ObtenerLinkConvenio("D")
                ElseIf mTipoConvenioApertura = TipoConvenio.Tarifa Then
                    Link = Convenio.ObtenerLinkConvenio("T")
                ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then
                    Link = Convenio.ObtenerLinkConvenio("C")
                End If

                For Each RowMail As DataRow In Me.pdtUsuarioSeleccionado.Rows
                    Call InicializarControlesMail(Convenio, CInt(RowMail("COD_USUARIO")), Link, ClaveIdConvenios)
                    Call EnviarMail()
                Next

                'Envio el mail solo a la persona que envia el convenio a aprobar sin el LINK ====================
                Call InicializarControlesMail(Convenio, -1, Link, ClaveIdConvenios)
                Call EnviarMail()
                '================================================================================================
                IdUnicoCodigoConvenio = ""

                If envioExitoso Then
                    mpbEnvioMail.Enabled = False
                    mpbEnvioMail.Text = ""
                    mpbEnvioMail.Visible = False
                    Mensaje("Se envio el E-mail de manerea exitosa a los Usuarios Seleccionados . " + vbCr + " Verifique el envío en su dirección de correo electrónico", TipoMensaje.Informacion)
                End If

            End If

            'Mensaje("la grabación se realizó con éxito.", TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub EliminarConvenio()
        If Mensaje("Está seguro que desea eliminar el convenio ?", TipoMensaje.SiNo) = DialogResult.Yes Then
            Dim IdConvenio As Integer = TxtIdConvenio.Text.Trim
            Dim Convenio As New Convenios
            Convenio.Id_convenio = IdConvenio
            Convenio.Borrar()
            Mensaje("la eliminación se realizó con éxito.", TipoMensaje.Informacion)
            Call CargarConvenios()
            'AG 23/04/2015 ==========================
            Call CargarConveniosPendientes()
            Call CambiarColorCelda()
            '========================================
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        If txtCodCliente.Text.Trim = String.Empty Then
            Mensaje("Debe seleccionar un cliente.", TipoMensaje.Informacion)
            txtCodCliente.Focus()
            Return False
        End If
        If TxtCodMedio.Text.Trim = String.Empty Then
            Mensaje("Debe seleccionar un medio.", TipoMensaje.Informacion)
            TxtCodMedio.Focus()
            Return False
        End If
        If TxtCodSoporte.Text.Trim = String.Empty Then
            Mensaje("Debe seleccionar un soporte.", TipoMensaje.Informacion)
            TxtCodSoporte.Focus()
            Return False
        End If
        If TxtHInicio.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar hora de inicio.", TipoMensaje.Informacion)
            TxtHInicio.Focus()
            Return False
        End If
        If TxtHFin.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar hora de fin.", TipoMensaje.Informacion)
            TxtHFin.Focus()
            Return False
        End If
        If Convert.ToInt32(TxtHInicio.Text.Replace(":", "").Trim) >= Convert.ToInt32(TxtHFin.Text.Replace(":", "").Trim) Then
            Mensaje("La hora de fin debe ser mayor a la hora de inicio.", TipoMensaje.Informacion)
            TxtHInicio.Focus()
            Return False
        End If
        If mTipoConvenioApertura = TipoConvenio.Tarifa Then
            If ObtenerNeto(TxtImporteVenta.Text.Trim) < 0 Then
                Mensaje("Debe ingresar un importe de venta.", TipoMensaje.Informacion)
                TxtImporteVenta.Focus()
                Return False
            End If
            If ObtenerNeto(TxtImporteCompra.Text.Trim) < 0 Then
                Mensaje("Debe ingresar un importe de compra.", TipoMensaje.Informacion)
                TxtImporteCompra.Focus()
                Return False
            End If
        End If
        If Not ChkLunes.Checked AndAlso Not ChkMartes.Checked AndAlso Not ChkMiercoles.Checked AndAlso Not ChkJueves.Checked AndAlso Not ChkViernes.Checked AndAlso Not ChkSabado.Checked AndAlso Not ChkDomingo.Checked Then
            Mensaje("Debe seleccionar un dia de la semana.", TipoMensaje.Informacion)
            ChkLunes.Focus()
            Return False
        End If
        If DtpFInicio.Value Is DBNull.Value Then
            Mensaje("Debe ingresar fecha de vigencia desde.", TipoMensaje.Informacion)
            DtpFInicio.Focus()
            Return False
        End If
        If DtpFFin.Value Is DBNull.Value Then
            Mensaje("Debe ingresar fecha de vigencia hasta.", TipoMensaje.Informacion)
            DtpFFin.Focus()
            Return False
        End If
        If Convert.ToDateTime(DtpFInicio.Value).Date > Convert.ToDateTime(DtpFFin.Value).Date Then
            Mensaje("La fecha de vigencia hasta debe ser mayor a igual a la fecha de vigencia desde.", TipoMensaje.Informacion)
            DtpFInicio.Focus()
            Return False
        End If
        If mTipoConvenioApertura = TipoConvenio.CPR Then 'AG CCPR
            If CDbl(Me.txtcpr.Text.Trim) < 0 Or CDbl(Me.txtcpr.Text.Trim) = 0 Then
                Mensaje("Debe ingresar el valor del CPR.", TipoMensaje.Informacion)
                Me.txtcpr.Focus()
                Return False
            End If
        End If

        'AG 17/01/2013 +++++++++++++++++++
        If Me.mTipoConvenioApertura = TipoConvenio.Descuento Or Me.mTipoConvenioApertura = TipoConvenio.Tarifa Or Me.mTipoConvenioApertura = TipoConvenio.CPR Then
            If Me.TxtDescuentoExtra1.Text.Trim = "" Then
                Me.TxtDescuentoExtra1.Text = "0.00" 'AG TC
                'Mensaje("El descuento extra 1 ( Confidencial ) no puede ser nulo o vacio.", TipoMensaje.Informacion)
                'Me.TxtDescuentoExtra1.Focus()
                'Return False
            End If

            If Me.TxtDescuentoExtra2.Text.Trim = "" Then
                Me.TxtDescuentoExtra2.Text = "0.00" 'AG TC
                'Mensaje("El descuento extra 2 ( Confidencial ) no puede ser nulo o vacio.", TipoMensaje.Informacion)
                'Me.TxtDescuentoExtra2.Focus()
                'Return False
            End If
        End If
        '++++++++++++++++++++++++++++++


        'AG TC Valido que se de Sin Confidencialidad y que los descuentos esten en CERO ==============================================================

        If Me.ChkSinRentabilidad.Checked = True And ITipoConfidencial = TipoConfidencial.SinRentabilidad And ChkConRentabilidad.Checked = False Then
            If Me.TxtDescuentoExtra2.Text.Trim <> "0.00" And Me.TxtDescuentoExtra1.Text.Trim <> "0.00" Then
                Mensaje("Los convenios Tipo SIN RENTABILIDAD, deben tener valores en Cero (0) .", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If

            If Me.TxtDescuentoExtra1.Text.Trim <> "0.00" And Me.TxtDescuentoExtra2.Text.Trim <> "" Then
                Mensaje("Los convenios Tipo SIN RENTABILIDAD, deben tener valores en Cero (0) .", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If

            If Me.TxtDescuentoExtra2.Text.Trim <> "0.00" And Me.TxtDescuentoExtra1.Text.Trim <> "" Then
                Mensaje("Los convenios Tipo SIN RENTABILIDAD, deben tener valores en Cero (0) .", TipoMensaje.Informacion)
                TxtDescuentoExtra2.Focus()
                Return False
            End If
        End If

        If Me.ChkConRentabilidad.Checked = True And ITipoConfidencial = TipoConfidencial.ConRentabilidad And ChkSinRentabilidad.Checked = False Then
            If Me.TxtDescuentoExtra1.Text.Trim = "" And Me.TxtDescuentoExtra2.Text.Trim = "" Then
                Mensaje("Los descuentos extras, no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If

            If Me.TxtDescuentoExtra1.Text.Trim = "0.00" And Me.TxtDescuentoExtra2.Text.Trim <> "" Then 'OK
                'Mensaje("Los descuentos extras, no deben tener valores en Cero (0) .", TipoMensaje.Informacion)
                'TxtDescuentoExtra1.Focus()
                'Return False
            End If

            If Me.TxtDescuentoExtra2.Text.Trim = "0.00" And Me.TxtDescuentoExtra1.Text.Trim = "0.00" Then
                Mensaje("Los descuentos extras, no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If


            If ObtenerNeto(TxtDescuentoExtra1.Text.Trim) <= 0 And ObtenerNeto(TxtDescuentoExtra2.Text.Trim) <= 0 Then
                Mensaje("Los descuentos extras no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If

            'REVISAR QUE NO PINCHE CUANDO SE INGRESA UN VALOR NEGATIVO =================

            If ObtenerNeto(TxtDescuentoExtra1.Text.Trim) < 0 Then
                Mensaje("Los descuentos extras no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
                TxtDescuentoExtra1.Focus()
                Return False
            End If

            If ObtenerNeto(TxtDescuentoExtra2.Text.Trim) < 0 Then
                Mensaje("Los descuentos extras no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
                TxtDescuentoExtra2.Focus()
                Return False
            End If


            'AG 23/04/2015 =========================================
            If Me.txtUsuariosAutorizados.Text = "" Then
                Mensaje("Debe seleccionar el Usuario de Aprobacion del Convenio  ", TipoMensaje.Informacion)
                Return False
            End If
            '=======================================================

            'If IsNumeric(TxtDescuentoExtra1.Text.Trim) = False Then
            '    Mensaje("Los descuentos extras, no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
            '    TxtDescuentoExtra1.Focus()
            '    Return False
            'End If

            'If IsNumeric(TxtDescuentoExtra2.Text.Trim) = False Then
            '    Mensaje("Los descuentos extras, no deben tener valores en Cero (0) o Menor.", TipoMensaje.Informacion)
            '    TxtDescuentoExtra1.Focus()
            '    Return False
            'End If

        End If


        If Me.ChkSinRentabilidad.CheckState = CheckState.Unchecked And Me.ChkConRentabilidad.CheckState = CheckState.Unchecked Then
            Mensaje("Los convenios deben tener seleccionado Confidencialidad. " & vbCrLf & "     ( SIN RENTABILIDAD o CON RENTABILIDAD )  ", TipoMensaje.Informacion)
            Me.ChkSinRentabilidad.Focus()
            Return False
        End If

        'AG 23/04/2015 =======================================================================================
        If Me.txtUsuariosAutorizados.Text = "" Then
            Mensaje("Debe seleccionar el Usuario autorizador de convenios  ", TipoMensaje.Informacion)
            Return False
        End If
        '=====================================================================================================

        If EstadoConvenio = 0 Then
            Mensaje("Debe seleccionar la Accion que desea realizar.   " + vbCr + vbCr + "    NUEVO - NUEVO COMO - MODIFICAR ", TipoMensaje.Informacion)
            Return False
        End If

        '============================================================================================================================================

        If Me.mAnexos.Count = 0 Then
            Mensaje("Debe adjuntar un anexo para el convenio.", TipoMensaje.Informacion)
            Return False
        End If

        ' Comentó RM 28/6/2011-----------------------------------------------------------------------------------
        'If mTipoConvenioApertura = TipoConvenio.Descuento Then
        '    Dim Descuento As Double
        '    Dim bhayDesc As Boolean = False
        '    Descuento += ObtenerDescuento(TxtDctoVenta1.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoVenta2.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoVenta3.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoVenta4.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoVenta5.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoCompra1.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoCompra2.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoCompra3.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoCompra4.Text.Trim)
        '    Descuento += ObtenerDescuento(TxtDctoCompra5.Text.Trim)
        '    If Descuento = 0 Then
        '        Mensaje("Debe ingresar al menos un descuento.", TipoMensaje.Informacion)
        '        TxtDctoVenta1.Focus()
        '        Return False
        '    End If
        'End If
        '----------------------------------------------------------------------------------------------
        Return True
    End Function

    Private Sub ObtenerConvenio(ByRef Convenio As Convenios)

        Convenio.Id_medio = TxtCodMedio.Text.Trim
        Convenio.Id_soporte = TxtCodSoporte.Text.Trim
        Convenio.Id_cliente = txtCodCliente.Text.Trim
        If TxtCodProducto.Text.Trim <> String.Empty Then
            Convenio.Id_producto = TxtCodProducto.Text.Trim
        Else
            Convenio.Id_producto = 0
        End If
        If TxtIdConvenio.Text.Trim <> String.Empty Then
            Convenio.Id_convenio = TxtIdConvenio.Text.Trim
        Else
            Convenio.Id_convenio = 0
        End If
        Convenio.F_inicio = DtpFInicio.Value
        Convenio.F_fin = DtpFFin.Value
        Convenio.Detalle = TxtDetalle.Text.Trim
        Convenio.Participacion = TxtParticipacion.Text.Trim
        Convenio.Programa = ObtenerNombrePrograma()
        Convenio.Dcto1 = ObtenerDescuento(TxtDctoVenta1.Text.Trim)
        Convenio.Dcto2 = ObtenerDescuento(TxtDctoVenta2.Text.Trim)
        Convenio.Dcto3 = ObtenerDescuento(TxtDctoVenta3.Text.Trim)
        Convenio.Dcto4 = ObtenerDescuento(TxtDctoVenta4.Text.Trim)
        Convenio.Dcto5 = ObtenerDescuento(TxtDctoVenta5.Text.Trim)
        Convenio.DctoCompra1 = ObtenerDescuento(TxtDctoCompra1.Text.Trim)
        Convenio.DctoCompra2 = ObtenerDescuento(TxtDctoCompra2.Text.Trim)
        Convenio.DctoCompra3 = ObtenerDescuento(TxtDctoCompra3.Text.Trim)
        Convenio.DctoCompra4 = ObtenerDescuento(TxtDctoCompra4.Text.Trim)
        Convenio.DctoCompra5 = ObtenerDescuento(TxtDctoCompra5.Text.Trim)
        Convenio.DctoExtra1 = ObtenerDescuento(TxtDescuentoExtra1.Text.Trim)
        Convenio.DctoExtra2 = ObtenerDescuento(TxtDescuentoExtra2.Text.Trim)
        Convenio.Neto = ObtenerNeto(TxtImporteVenta.Text.Trim)
        Convenio.NetoCompra = ObtenerNeto(TxtImporteCompra.Text.Trim)
        Convenio.Observaciones = String.Empty
        Convenio.Obs_Compra = TxtObsCompra.Text.Trim
        Convenio.Obs_Venta = TxtObsVenta.Text.Trim
        Convenio.Obs_Extra = String.Empty
        Convenio.Obs_Finanzas = TxtObsFinanza.Text.Trim 'AG TC Se visualiza la observacion de confidencialidad
        Convenio.Semana = ObtenerSemana()
        Convenio.Hh_desde = ObtenerHoraMinuto(TxtHInicio.Text.Trim, 0)
        Convenio.Hh_hasta = ObtenerHoraMinuto(TxtHFin.Text.Trim, 0)
        Convenio.Mm_desde = ObtenerHoraMinuto(TxtHInicio.Text.Trim, 1)
        Convenio.Mm_hasta = ObtenerHoraMinuto(TxtHFin.Text.Trim, 1)

        'AG CCPR ++++++++++++++++++++++++++++++++++++++++++++
        If mTipoConvenioApertura = TipoConvenio.Tarifa Then
            Convenio.Tipo_convenio = "T"
            Convenio.CPRDecimal = 0
        ElseIf mTipoConvenioApertura = TipoConvenio.Descuento Then
            Convenio.Tipo_convenio = "D"
            Convenio.CPRDecimal = 0
        ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then   'AG CCPR
            Convenio.Tipo_convenio = "C"
            Convenio.CPRDecimal = ObtenerCPR(Me.txtcpr.Text)
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG TC ===============================================================================================================
        If Me.ChkSinRentabilidad.Checked = True And ITipoConfidencial = TipoConfidencial.SinRentabilidad Then 'AG TC Valido con Rentabilidad
            Convenio.Tipo_Confidencial = ITipoConfidencial
            'Convenio.Tipo_Confidencial = TipoConfidencial.SinRentabilidad   'AG TC Guardo valor 0 (Cero)
        ElseIf Me.ChkConRentabilidad.Checked = True And ITipoConfidencial = TipoConfidencial.ConRentabilidad Then
            Convenio.Tipo_Confidencial = ITipoConfidencial
            'Convenio.Tipo_Confidencial = TipoConfidencial.SinRentabilidad   'AG TC Guardo valor 1 (Uno)
        End If
        '=====================================================================================================================


        'AG 23/04/2015 ====================================================================================
        Convenio.IdUsuarioCreacion = Int(Activo.CodUsuarioMms)
        Convenio.IdUsuarioAprobacion = ArmarTextoCodigosUsuarios(dtUsuarioSeleccionado)
        Convenio.IdEstado = EstadoConvenio
        IdUnicoCodigoConvenio = GenerateNewGUID()
        Convenio.ClaveidConvenio = IdUnicoCodigoConvenio
        EstadoConvenio = 0
        '==================================================================================================

        Convenio.F_modi = Today
        Convenio.U_modi = Activo.Login
    End Sub

    Private Function ObtenerDescuento(ByVal pValue As String) As Double
        Dim Resultado As Double
        If pValue <> String.Empty Then
            Dim CellCultureInfo As New CultureInfo("en-US")
            Resultado = Resultado.Parse(pValue, CellCultureInfo)
        End If
        Return Resultado
    End Function

    Private Function ObtenerNeto(ByVal pValue As String) As Double
        Dim Resultado As Double
        pValue = pValue.Replace("$", "").Trim
        If pValue <> String.Empty Then
            Dim CellCultureInfo As New CultureInfo("en-US")
            Resultado = Resultado.Parse(pValue, CellCultureInfo)
        End If
        Return Resultado
    End Function

    Private Function ObtenerCPR(ByVal pValue As String) As Double
        Dim Resultado As Double
        pValue = pValue.Replace(",", ".").Trim
        If pValue <> String.Empty Then
            Dim CellCultureInfo As New CultureInfo("en-US")
            Resultado = Resultado.Parse(pValue, CellCultureInfo)
        End If
        Return Resultado
    End Function

    Private Function ObtenerNombrePrograma() As String
        Dim Programa As New StringBuilder
        Programa.Append("DE ")
        Programa.Append(TxtHInicio.Text.Trim)
        Programa.Append(" A ")
        Programa.Append(TxtHFin.Text.Trim)
        Programa.Append(" Hs.")
        Return Programa.ToString
    End Function

    Private Function ObtenerSemana() As String
        Dim Semana As New StringBuilder

        If ChkLunes.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkMartes.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkMiercoles.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkJueves.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkViernes.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkSabado.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If
        If ChkDomingo.Checked Then
            Semana.Append("S")
        Else
            Semana.Append("N")
        End If

        Return Semana.ToString
    End Function

    Private Function ObtenerHoraMinuto(ByVal pValue As String, ByVal pParteHora As Integer) As Short
        Dim ParteHora As String() = pValue.Split(":")
        If ParteHora.Length > pParteHora Then
            Return ParteHora(pParteHora)
        End If
        Return 0
    End Function

#End Region

    Private Sub ChkSinRentabilidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSinRentabilidad.CheckedChanged
        'AG TC ======================================================================
        ChkConRentabilidad.Checked = False
        ChkConRentabilidad.CheckState = CheckState.Unchecked
        '============================================================================
    End Sub

    Private Sub ChkConRentabilidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkConRentabilidad.CheckedChanged
        'AG TC ======================================================================
        ChkSinRentabilidad.Checked = False
        ChkSinRentabilidad.CheckState = CheckState.Unchecked
        '============================================================================

    End Sub

    Private Sub ChkConRentabilidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkConRentabilidad.Click

        ChkConRentabilidad.Checked = True

        Me.TxtDescuentoExtra1.Enabled = True
        Me.TxtDescuentoExtra2.Enabled = True

        If ChkConRentabilidad.Checked = True And Me.ChkSinRentabilidad.Checked = False Then

            '===== CONTROLES DE VALIDACION DE COMBINACION DE INGRESO DE DATOS ===========
            'Control Descuento 1
            If Me.TxtDescuentoExtra1.Text.Trim = "" And TxtDescuentoExtra2.Text.Trim = "0" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If Me.TxtDescuentoExtra1.Text.Trim = "" And TxtDescuentoExtra2.Text.Trim = "0.00" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            'Control Descuento 2
            If Me.TxtDescuentoExtra2.Text.Trim = "" And TxtDescuentoExtra1.Text.Trim = "0" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If Me.TxtDescuentoExtra2.Text.Trim = "" And TxtDescuentoExtra1.Text.Trim = "0.00" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If


            If Me.TxtDescuentoExtra1.Text.Trim = "" And Me.TxtDescuentoExtra2.Text.Trim = "" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If Me.TxtDescuentoExtra1.Text.Trim = "0" And Me.TxtDescuentoExtra2.Text.Trim = "0" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If Me.TxtDescuentoExtra1.Text.Trim = "0.00" And Me.TxtDescuentoExtra2.Text.Trim = "0.00" Then
                Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If ObtenerNeto(TxtDescuentoExtra1.Text.Trim) < 0 Then
                Mensaje("Los convenios Tipo CON RENTABILIDAD, NO deben tener valores nenor a Cero (0).", TipoMensaje.Informacion)
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra1.Focus()
                Exit Sub
            End If

            If ObtenerNeto(TxtDescuentoExtra2.Text.Trim) < 0 Then
                Mensaje("Los convenios Tipo CON RENTABILIDAD, NO deben tener valores nenor a Cero (0).", TipoMensaje.Informacion)
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra2.Focus()
                Exit Sub
            End If

            If ObtenerNeto(TxtDescuentoExtra1.Text.Trim) <= 0 And ObtenerNeto(TxtDescuentoExtra2.Text.Trim) <= 0 Then
                Mensaje("Los convenios Tipo CON RENTABILIDAD, NO deben tener valores nenor a Cero (0).", TipoMensaje.Informacion)
                ChkConRentabilidad.Checked = False
                Me.ChkSinRentabilidad.Checked = False
                Me.TxtObsFinanza.Text = ""
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
                Me.TxtDescuentoExtra2.Focus()
                Exit Sub
            End If

            'If IsNumeric(TxtDescuentoExtra1.Text.Trim) = False Then
            '    Mensaje("Los convenios Tipo CON RENTABILIDAD, deben tener valores Numericos .", TipoMensaje.Informacion)
            '    ChkConRentabilidad.Checked = False
            '    Me.ChkSinRentabilidad.Checked = False
            '    Me.TxtObsFinanza.Text = ""
            '    ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
            '    Me.TxtDescuentoExtra1.Focus()
            '    Exit Sub
            'End If


            'If IsNumeric(TxtDescuentoExtra2.Text.Trim) = False Then
            '    Mensaje("Los convenios Tipo CON RENTABILIDAD, deben tener valores Numericos .", TipoMensaje.Informacion)
            '    ChkConRentabilidad.Checked = False
            '    Me.ChkSinRentabilidad.Checked = False
            '    Me.TxtObsFinanza.Text = ""
            '    ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
            '    Me.TxtDescuentoExtra2.Focus()
            '    Exit Sub
            'End If
            '==============================================================================================

            Me.ChkSinRentabilidad.Checked = False 'Fuerzo a asignarle el valor del checks

            If ITipoConfidencial = TipoConfidencial.ConRentabilidad Then
                ChkConRentabilidad.Checked = True
                If Mensaje("Desea modificar la Leyenda del Convenio " & vbCrLf & "      ( CON RENTABILIDAD )?", TipoMensaje.SiNo) = DialogResult.Yes Then
                    Dim oFrmSeleccionRentabilidad As New frmSeleccionarTConvRentabilidad
                    Me.mInstancia = Me
                    oFrmSeleccionRentabilidad.TRentabilidadAnterior = TRentabilidad
                    oFrmSeleccionRentabilidad.ShowDialog()
                    Me.TxtObsFinanza.Text = ""
                    If TRentabilidad = TipoRentabilidad.LlevaNC Then
                        Me.TxtObsFinanza.Text = ObsLlevaNC.ToUpper
                    ElseIf TRentabilidad = TipoRentabilidad.FPro Then
                        Me.TxtObsFinanza.Text = ObsLeyendaConRentaFacturaProveedor.ToUpper
                    End If
                    ITipoConfidencial = TipoConfidencial.ConRentabilidad 'Flags Uno (1)
                Else
                    Exit Sub
                End If
                Exit Sub
            End If
            '***
            If Mensaje("Seguro que desea seleccionar el convenio " & vbCrLf & " de tipo ( CON RENTABILIDAD ) ?", TipoMensaje.SiNo) = DialogResult.Yes Then
                Dim oFrmSeleccionRentabilidad As New frmSeleccionarTConvRentabilidad
                Me.mInstancia = Me
                oFrmSeleccionRentabilidad.ShowDialog()
                Me.TxtObsFinanza.Enabled = True '
                If TRentabilidad = TipoRentabilidad.LlevaNC Then
                    Me.TxtObsFinanza.Text = ObsLlevaNC.ToUpper
                ElseIf TRentabilidad = TipoRentabilidad.FPro Then
                    Me.TxtObsFinanza.Text = ObsLeyendaConRentaFacturaProveedor.ToUpper
                End If
                Me.TxtObsFinanza.Enabled = False '
                ITipoConfidencial = TipoConfidencial.ConRentabilidad 'Flags Uno (1)
            Else
                ITipoConfidencial = TipoConfidencial.ConfidencialidadNula 'Blanqueo el indice de tipo confidencial para evitar que no se guarde con dato que sea o CERO o UNO
                ChkConRentabilidad.Checked = False
                Me.TxtObsFinanza.Enabled = True '
                Me.TxtDescuentoExtra1.Text = ""
                Me.TxtDescuentoExtra2.Text = ""
                Me.TxtObsFinanza.Text = ""
                Me.TxtObsFinanza.Enabled = False '
            End If

        End If



        'AG Codigo Original ============================================================
        'If ChkConRentabilidad.Checked = True And Me.ChkSinRentabilidad.Checked = False Then
        '    If Me.TxtDescuentoExtra1.Text.Trim <> "" And Me.TxtDescuentoExtra2.Text.Trim <> "" And Me.TxtDescuentoExtra1.Text.Trim <> "0" And Me.TxtDescuentoExtra2.Text.Trim <> "0" And Me.TxtDescuentoExtra1.Text.Trim <> "0.00" And Me.TxtDescuentoExtra2.Text.Trim <> "0.00" Then  'AG TC Valido si los valores NO son 0 o NULOS entonces es de tipo Con confidencial
        '        Me.ChkSinRentabilidad.Checked = False 'Fuerzo a asignarle el valor del checks
        '        If ITipoConfidencial = TipoConfidencial.ConRentabilidad Then
        '            ChkConRentabilidad.Checked = True
        '            If Mensaje("Desea modificar la Leyenda del Convenio " & vbCrLf & "      ( CON RENTABILIDAD )?", TipoMensaje.SiNo) = DialogResult.Yes Then
        '                Dim oFrmSeleccionRentabilidad As New frmSeleccionarTConvRentabilidad
        '                Me.mInstancia = Me
        '                oFrmSeleccionRentabilidad.TRentabilidadAnterior = TRentabilidad
        '                oFrmSeleccionRentabilidad.ShowDialog()
        '                Me.TxtObsFinanza.Text = ""
        '                If TRentabilidad = TipoRentabilidad.LlevaNC Then
        '                    Me.TxtObsFinanza.Text = ObsLlevaNC.ToUpper
        '                ElseIf TRentabilidad = TipoRentabilidad.FPro Then
        '                    Me.TxtObsFinanza.Text = ObsLeyendaConRentaFacturaProveedor.ToUpper
        '                End If
        '                ITipoConfidencial = TipoConfidencial.ConRentabilidad 'Flags Uno (1)
        '            Else
        '                Exit Sub
        '            End If
        '            Exit Sub
        '        End If
        '        '***
        '        If Mensaje("Seguro que desea seleccionar el convenio " & vbCrLf & " de tipo ( CON RENTABILIDAD ) ?", TipoMensaje.SiNo) = DialogResult.Yes Then
        '            Dim oFrmSeleccionRentabilidad As New frmSeleccionarTConvRentabilidad
        '            Me.mInstancia = Me
        '            oFrmSeleccionRentabilidad.ShowDialog()
        '            Me.TxtObsFinanza.Enabled = True '
        '            If TRentabilidad = TipoRentabilidad.LlevaNC Then
        '                Me.TxtObsFinanza.Text = ObsLlevaNC.ToUpper
        '            ElseIf TRentabilidad = TipoRentabilidad.FPro Then
        '                Me.TxtObsFinanza.Text = ObsLeyendaConRentaFacturaProveedor.ToUpper
        '            End If
        '            Me.TxtObsFinanza.Enabled = False '
        '            ITipoConfidencial = TipoConfidencial.ConRentabilidad 'Flags Uno (1)
        '        Else
        '            ITipoConfidencial = TipoConfidencial.ConfidencialidadNula 'Blanqueo el indice de tipo confidencial para evitar que no se guarde con dato que sea o CERO o UNO
        '            ChkConRentabilidad.Checked = False
        '            Me.TxtObsFinanza.Enabled = True '
        '            Me.TxtDescuentoExtra1.Text = ""
        '            Me.TxtDescuentoExtra2.Text = ""
        '            Me.TxtObsFinanza.Text = ""
        '            Me.TxtObsFinanza.Enabled = False '
        '        End If
        '    Else
        '        Mensaje("Los convenios de tipo ( CON RENTABILIDAD ) " & vbCrLf & " deben contener descuentos confidenciales. ", TipoMensaje.Informacion)
        '        If Me.TxtDescuentoExtra1.Text.Trim = "" And Me.TxtDescuentoExtra2.Text.Trim = "" Then
        '            Me.TxtDescuentoExtra1.Focus()
        '        End If

        '        If Me.TxtDescuentoExtra1.Text.Trim = "0.00" And Me.TxtDescuentoExtra2.Text.Trim = "0.00" Then
        '            Me.TxtDescuentoExtra1.Focus()
        '        End If

        '        If Me.TxtDescuentoExtra1.Text.Trim = "" Then
        '            Me.TxtDescuentoExtra1.Focus()
        '        End If
        '        If Me.TxtDescuentoExtra2.Text.Trim = "" Then
        '            Me.TxtDescuentoExtra2.Focus()
        '        End If
        '        ITipoConfidencial = TipoConfidencial.ConfidencialidadNula
        '        ChkConRentabilidad.Checked = False
        '        Me.ChkSinRentabilidad.Checked = False
        '        Me.TxtObsFinanza.Text = ""
        '    End If
        'End If
        '====================================================================================================
    End Sub

    Private Sub ChkSinRentabilidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkSinRentabilidad.Click

        'If IniciofromDefaulConfidencialidad = False Then
        '    Me.TxtObsFinanza.Text = ObsLeyendaSinRentabilidad.ToUpper
        '    ITipoConfidencial = TipoConfidencial.SinRentabilidad
        '    IniciofromDefaulConfidencialidad = True
        '    ChkSinRentabilidad.Checked = True
        '    Exit Sub
        'End If

        ChkSinRentabilidad.Checked = True

        If ITipoConfidencial = TipoConfidencial.SinRentabilidad Then
            Mensaje("Ya se encuentra seleccionado " & vbCrLf & "      ( SIN RENTABILIDAD )", TipoMensaje.Informacion)
            Exit Sub
        End If

        If ChkSinRentabilidad.Checked = True And Me.ChkConRentabilidad.Checked = False Then
            If Me.TxtDescuentoExtra1.Text.Trim <> "" Or Me.TxtDescuentoExtra2.Text.Trim <> "" Or Me.TxtDescuentoExtra1.Text <> "0" Or Me.TxtDescuentoExtra2.Text <> "0" Then  'AG TC Valido los si los valores son 0 o NULOS entonces es de tipo Sin confidencial
                Me.ChkConRentabilidad.Checked = False 'Fuerzo a asignarle el valor del checks
                If Mensaje("Está seguro que desea seleccionar el convenio de tipo ( SIN RENTABILIDAD ) ?", TipoMensaje.SiNo) = DialogResult.Yes Then
                    Me.TxtDescuentoExtra1.Text = "0.00"
                    Me.TxtDescuentoExtra2.Text = "0.00"
                    Me.TxtDescuentoExtra1.Enabled = False
                    Me.TxtDescuentoExtra2.Enabled = False
                    ITipoConfidencial = TipoConfidencial.SinRentabilidad  ' Flags Cero (0)
                    Me.TxtObsFinanza.Enabled = True '
                    Me.TxtObsFinanza.Text = ObsLeyendaSinRentabilidad.ToUpper
                    Me.TxtDescuentoExtra1.Text = "0.00"
                    Me.TxtDescuentoExtra2.Text = "0.00"
                    Me.TxtObsFinanza.Enabled = False  '
                Else
                    ITipoConfidencial = TipoConfidencial.ConRentabilidad
                    ChkConRentabilidad.Checked = True
                    ChkConRentabilidad.CheckState = CheckState.Checked
                    ChkConRentabilidad.Focus()
                    Me.ChkSinRentabilidad.CheckState = CheckState.Unchecked
                    Me.TxtDescuentoExtra1.Enabled = True
                    Me.TxtDescuentoExtra2.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Function BuscarUsuariosAprobacion() As DataTable

        Dim ObjConvenios As New Convenios
        Dim dtUsuarioAutorizado As DataTable
        Dim CodCompaniaActual As Integer

        CodCompaniaActual = Int(Activo.CodCampaniaActualMms)

        dtUsuarioAutorizado = ObjConvenios.ObtenerUsuariosAutorizado(CodCompaniaActual)

        Return dtUsuarioAutorizado

    End Function

    Private Sub gntGantt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ugConvenios_AfterRowActivate1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ugConvenios.AfterRowActivate
        Call HabilitarControles(False)
        Call PopularDatos()
        Me.mAnexos.Clear()
        Me.lnkAnexos.Enabled = False
    End Sub

#Region "EnvioMail"

    Private Sub InicializarControlesMail(ByRef Convenio As Convenios, ByVal CodUsuario As Integer, ByVal Link As String, ByVal ClaveIdConvenio As String)

        Dim ObConvenios As New Convenios
        Dim Link1 As String = Link
        Dim LinkConvenio As String = "CodigoConvenio="
        Dim LinkUsuarioAprobador As String = "CodigoUsuario="
        Dim LinkFinal As String
        Dim DesTipoConvenio As String

        If mTipoConvenioApertura = TipoConvenio.Descuento Then
            DesTipoConvenio = "Descuento"
        ElseIf mTipoConvenioApertura = TipoConvenio.Tarifa Then
            DesTipoConvenio = "Tarifa Plana"
        ElseIf mTipoConvenioApertura = TipoConvenio.CPR Then
            DesTipoConvenio = "Cpr"
        End If


        If CodUsuario = -1 Then 'Envio el mail solo a la persona que pide autorizacion sin el link
            MailSend = ObtenerMailUsuario(CInt(Activo.CodUsuarioMms)).ToString()
            MailTo = MailSend
        Else   'Envio el mail solo a las persona que autorizan con el link
            MailSend = ObtenerMailUsuario(CInt(Activo.CodUsuarioMms)).ToString()
            MailTo = ObtenerMailUsuario(CodUsuario)
            MailCopia = "" 'MailSend
        End If

        
        asunto = ""

        Dim mensajeMail As New System.Text.StringBuilder()
        Dim MailConvenio As String
        Dim LeyendaNuevoOModificacion As String
        Dim Lineas As String


        If TxtIdConvenio.Text = "" Then
            MailConvenio = ObConvenios.ObtenerUltimoConvenio(CInt(txtCodCliente.Text.Trim), CInt(TxtCodMedio.Text.Trim), CInt(TxtCodSoporte.Text.Trim))
            LeyendaNuevoOModificacion = "Resumen del Nuevo Convenio"
            Lineas = "-------------------------------"
        Else
            LeyendaNuevoOModificacion = "Resumen de la Modificacion del Convenio"
            Lineas = "-------------------------------------------"
            MailConvenio = TxtIdConvenio.Text
        End If

        LinkConvenio += IdUnicoCodigoConvenio.ToString.Trim
        LinkUsuarioAprobador += CodUsuario.ToString.Trim

        LinkFinal += Link1 + LinkConvenio + "&" + LinkUsuarioAprobador

        LinkFinal = LinkFinal.Trim

        Dim MailCliente As String = Me.txtCliente.Text.ToString()
        Dim MailMedio As String = Me.cboMedio.Text.ToString()
        Dim MailTipoSoporte As String = cboTipoSoporte.Text.ToString()
        Dim MailSoporte As String = Me.TxtSoporte.Text.ToString()
        Dim MailUsuarioCreacion As String = Activo.Nombre.ToString().ToUpper + " " + Activo.Apellido1.ToString().ToUpper
        Dim MailFechaCreacion As String = CStr(Date.Now.Day).PadLeft(2, "0") + "/" + CStr(Date.Now.Month).PadLeft(2, "0") + "/" + CStr(Date.Now.Year)
        Dim MailHoraCreacion As String = CStr(Date.Now.Hour).PadLeft(2, "0") + ":" + CStr(Date.Now.Minute).PadLeft(2, "0") + ":" + CStr(Date.Now.Second).PadLeft(2, "0") + " Hs."
        Dim NomapellidoUsuario As String = Activo.Nombre.ToString() + " " + Activo.Apellido1.ToString()
        Dim DescuentoExtra1 As String = Me.TxtDescuentoExtra1.Text.Replace(".", ",") + " %"
        Dim DescuentoExtra2 As String = Me.TxtDescuentoExtra2.Text.Replace(".", ",") + " %"
        Dim LeyendaConfidencial As String = Me.TxtObsFinanza.Text

        Dim CompaniaConvenio As String = " -- Compania:" + ObtenerDescripcionCompania(Int(Activo.CodCampaniaActualMms))

        NomapellidoUsuario = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(NomapellidoUsuario)

        asunto = "Solicitud Aprobacion de Convenio Nro: " + MailConvenio.ToString() + CompaniaConvenio
        mensajeMail.Append("<html>")
        mensajeMail.Append("<body>")
        mensajeMail.Append("<br> " + LeyendaNuevoOModificacion + " <b></b>")
        mensajeMail.Append("<br> " + Lineas + " <b></b>")
        mensajeMail.Append("<br>Nro Convenio : <b>" + MailConvenio + " </b>")
        mensajeMail.Append("<br>Tipo Convenio : <b>" + DesTipoConvenio.ToString().ToUpper() + " </b>")
        mensajeMail.Append("<br>Cliente : <b>" + MailCliente + " </b>")
        mensajeMail.Append("<br>Medio : <b>" + MailMedio + " </b>")
        mensajeMail.Append("<br>Tipo Soporte : <b>" + MailTipoSoporte + " </b>")
        mensajeMail.Append("<br>Soporte : <b>" + MailSoporte + " </b>")
        mensajeMail.Append("<br><br><br>Descuentos Confidenciales<b></b>")
        mensajeMail.Append("<br>---------------------------<b></b>")
        mensajeMail.Append("<br>Leyenda Confidencial : <b>" + LeyendaConfidencial + " </b>")
        mensajeMail.Append("<br>Descuento Conf 1 : <b>" + DescuentoExtra1 + " </b>")
        mensajeMail.Append("<br>Descuento Conf 2 : <b>" + DescuentoExtra2 + " </b>")
        mensajeMail.Append("<br><br><br>Datos de Creacion<b></b>")
        mensajeMail.Append("<br>-------------------<b></b>")
        mensajeMail.Append("<br>Usuario Nombre y Apellido : <b>" + MailUsuarioCreacion + " </b>")
        mensajeMail.Append("<br>Fecha Creacion : <b>" + MailFechaCreacion + " </b>")
        mensajeMail.Append("<br>Hora Creacion : <b>" + MailHoraCreacion + " </b>")
        mensajeMail.Append("<br>-------------------<b></b>")
        mensajeMail.Append("<br><br>Compania : <b>" + ObtenerDescripcionCompania(Int(Activo.CodCampaniaActualMms).ToString()) + " </b>")

        If -1 <> CodUsuario Then
            mensajeMail.Append("<br><br>Link de acceso Aprobacion Convenio : <b> <a href=" + LinkFinal + ">LINK!!!!</a> ")
        End If

        mensajeMail.Append("<br><br><br>Atte<b></b>")
        mensajeMail.Append("<br>" + NomapellidoUsuario + " </b>")

        mensajeMail.Append("</body>")
        mensajeMail.Append("</html>")

        cuerpo = mensajeMail.ToString()
        Me.mpbEnvioMail.Enabled = False



    End Sub

    Private Function GenerateNewGUID() As String

        Dim xGUID As String = System.Guid.NewGuid.ToString()

        Return xGUID

    End Function

    Private Sub EnviarMail()

        mpbEnvioMail.Properties.ShowTitle = True
        mpbEnvioMail.Visible = True
        mpbEnvioMail.Enabled = True
        mpbEnvioMail.Text = "Enviando mail a los Usuarios Autorizadores..."

        Try

            Dim mail As New Mail()

            mail.From = MailSend
            mail.To = MailTo
            'mail.To = MailCopia
            mail.Subject = asunto
            mail.Body = cuerpo
            mail.isHTML = True
            mail.Send()
            envioExitoso = True

        Catch ex As Exception
            envioExitoso = False
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        'AG No se utiliza =====================================
        'BackgroundWorkerEnvio.WorkerReportsProgress = True
        'BackgroundWorkerEnvio.WorkerSupportsCancellation = True
        'BackgroundWorkerEnvio.RunWorkerAsync()
        '======================================================

    End Sub

    Private Sub BackgroundWorkerEnvio_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles BackgroundWorkerEnvio.DoWork

        Try

            Dim mail As New Mail()

            mail.From = MailSend
            mail.To = MailTo
            mail.To = MailCopia
            mail.Subject = asunto
            mail.Body = cuerpo
            mail.isHTML = True
            mail.Send()
            envioExitoso = True

        Catch ex As Exception
            envioExitoso = False
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Sub

    Public Function ConvertToHTML(ByVal Box As RichTextBox) As String

        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Short
        Dim lngOriginalStart As Long
        Dim lngOriginalLength As Long
        Dim intCount As Integer
        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then Exit Function
        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters

        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size

        ' Include first 'style' parameters in the HTML
        strHTML += "<span style=""font-family: " & strFont & _
          "; font-size: " & shtSize & "pt; color: " _
                          & strColour & """>"
        ' Include bold tag, if required
        If blnBold = True Then
            strHTML += "<b>"
        End If
        ' Include italic tag, if required
        If blnItalic = True Then
            strHTML += "<i>"
        End If
        ' Finally, add our first character
        strHTML += Box.Text.Substring(0, 1)
        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) = _
                   Convert.ToChar(10) Then
                strHTML += "<br>"
            End If
            ' Check/implement any changes in style
            If Box.SelectionColor.ToKnownColor.ToString <> strColour Or Box.SelectionFont.FontFamily.Name _
               <> strFont Or Box.SelectionFont.Size <> shtSize _
               Then
                strHTML += "</span><span style=""font-family: " _
                  & Box.SelectionFont.FontFamily.Name & _
                  "; font-size: " & Box.SelectionFont.Size & _
                  "pt; color: " & _
                  Box.SelectionColor.ToKnownColor.ToString & """>"
            End If
            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then
                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If
            End If
            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If
            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)
            ' Update variables with current style
            strColour = Box.SelectionColor.ToKnownColor.ToString
            blnBold = Box.SelectionFont.Bold
            blnItalic = Box.SelectionFont.Italic
            strFont = Box.SelectionFont.FontFamily.Name
            shtSize = Box.SelectionFont.Size
        Next
        ' Close off any open bold/italic tags
        If blnBold = True Then strHTML += ""
        If blnItalic = True Then strHTML += ""
        ' Terminate outstanding HTML tags
        strHTML += "</span></html>"
        ' Restore original RichTextBox selection
        Box.Select(lngOriginalStart, lngOriginalLength)
        ' Return HTML
        Return strHTML
    End Function

    Private Sub BackgroundWorkerEnvio_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnvio.RunWorkerCompleted

        mpbEnvioMail.Enabled = False
        mpbEnvioMail.Text = ""
        mpbEnvioMail.Visible = False

        If e.Cancelled Then
            Mensaje("Se canceló el envío", TipoMensaje.DeError)
        Else
            If envioExitoso Then
                Mensaje("Se envio el E-mail de manerea exitosa a los Usuarios Seleccionados . " + vbCr + " Verifique el envío en su dirección de correo electrónico", TipoMensaje.Informacion)
            End If
        End If

    End Sub

    Private Function ValidarMails(ByVal pMails As String) As Boolean

        Dim esValido As Boolean = False
        Dim mails As List(Of String) = pMails.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries).ToList()
        If mails.Count > 0 Then
            esValido = True
            For Each mail As String In mails
                If esValido Then
                    esValido = Regex.IsMatch(mail.Trim(), "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                Else
                    Exit For
                End If
            Next
        End If
        Return esValido
    End Function

    Public Function ObtenerMailUsuario(ByVal CodUsuario As Integer) As String

        Dim mail As String = String.Empty
        Dim parametos As New Dictionary(Of String, Object)
        Dim dt As DataTable
        Dim ObjConvenio As New Convenios

        'parametos.Add("cod_usuario", CodUsuario)
        'dt = Sqlhelper.ExecuteProcedure("PKG_AR_USUARIO", "SELECT_FROM_MAIL", "Data", parametos)

        dt = ObjConvenio.ObtenerMailUsuarios(CodUsuario)

        If dt.Rows.Count > 0 Then
            mail = dt.Rows(0).Item("mail_usuario").ToString()
        End If

        Return mail

    End Function

    Private Function ArmarTextoCodigosUsuarios(ByVal Dt As DataTable) As String

        Dim Texto As String
        Dim CantTotalLetas As Integer
        Dim TextoFinal As String

        If Dt.Rows.Count > 0 Then
            For Each RowUusario As DataRow In Dt.Rows
                Texto += RowUusario("COD_USUARIO").ToString() + ";"
            Next
        End If

        CantTotalLetas = Texto.Length
        TextoFinal = Texto.Substring(0, CantTotalLetas - 1)

        Return TextoFinal

        Return Texto

    End Function

    Private Sub UsuariosAprobador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosAprobador.Click

        Dim frmAprobadores As New frnUsuariosAprobadores
        Me.mInstancia = Me
        dtUsuarioAprobadores = AnexarColumnaSeleccion(BuscarUsuariosAprobacion())
        frmAprobadores.DtUsuarios = dtUsuarioAprobadores


        frmAprobadores.ShowDialog()

    End Sub

    Private Function AnexarColumnaSeleccion(ByVal Dt As DataTable) As DataTable

        With Dt.Columns
            .Add("Seleccion", GetType(Boolean))
        End With

        For Each DrFila As DataRow In Dt.Rows
            DrFila("Seleccion") = False
        Next

        Return Dt

    End Function

    Private Sub CambiarColorCelda()

        For Each b As UltraGridBand In Me.ugConveniosEnviados.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To Me.ugConveniosEnviados.Rows.Count - 1
                If Me.ugConveniosEnviados.Rows(i).Cells("Estado").Value = "Rechazado" Then
                    Me.ugConveniosEnviados.Rows(i).Cells("Estado").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Cod_Medio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Cod_Soporte").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Cod_Cliente").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Cod_Producto").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Cod_Convenio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("id_Convenio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Fec_Inicio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Fec_Fin").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Detalle").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Participacion").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Programa").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Venta_1").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Venta_2").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Venta_3").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Venta_4").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Venta_5").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Compra_1").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Compra_2").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Compra_3").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Compra_4").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Compra_5").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Extra_1").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Desc_Extra_2").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Imp_Neto_Venta").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Imp_Neto_Compra").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Obs_Compra").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Obs_Venta").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Obs_Finanzas").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("TCONFIDENCIAL").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Semana").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Id_Convenio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Tipo_Convenio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Hora_Inicio").Appearance.ForeColor = Color.Red
                    Me.ugConveniosEnviados.Rows(i).Cells("Hora_Fin").Appearance.ForeColor = Color.Red
                End If
            Next
        Next

    End Sub

    Private Function ObtenerDescripcionCompania(ByVal CodCompania As Integer) As String

        Dim DescripcionCompania As String

        Select Case CodCompania
            Case 35
                DescripcionCompania = " HAVAS MEDIA"
            Case 36
                DescripcionCompania = " ARENA"
            Case 37
                DescripcionCompania = " MEDIA CONTACTS"
            Case 38
                DescripcionCompania = " PROXIMIA"
            Case 39
                DescripcionCompania = " HAVAS SPORTS"
            Case 40
                DescripcionCompania = " AFFIPERF"
            Case 41
                DescripcionCompania = " FORWARD"
            Case 42
                DescripcionCompania = " SOCIALYSE"

        End Select


        Return DescripcionCompania

    End Function

#End Region

    'LFG - 30/03/2016
    Private Sub ObtenerDescripcionProducto()
        Dim CodigoProducto As String = TxtCodProducto.Text.Trim
        Dim CodigoCliente As String = txtCodCliente.Text.Trim
        If CodigoProducto <> String.Empty AndAlso CodigoCliente <> String.Empty Then
            Dim Prod As New Productos
            Dim producto As New DataTable

            Try
                Prod.Id_cliente = CodigoCliente
                producto = Prod.TraerProductos

                If producto Is Nothing OrElse producto.Rows.Count = 0 OrElse producto.Select("Id_Producto = " & CodigoProducto).Length = 0 Then
                    Mensajes.Mensaje("El Producto No Existe  o No Pertenece al Cliente Selccionado")
                    TxtCodProducto.Text = ""
                    TxtCodProducto.Select()
                    Exit Sub
                Else
                    TxtProducto.Text = producto.Select("Id_Producto = " & CodigoProducto)(0)("Descripcion")
                    Call CargarHoraEspecial()
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Seleccionado")
                TxtCodProducto.Text = ""
                TxtCodProducto.Select()
                Exit Sub
            End Try
        Else
            TxtProducto.Text = String.Empty
        End If
    End Sub
    'LFG - 30/03/2016

    Private Sub TxtCodSoporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodSoporte.TextChanged

    End Sub

    Private Sub lnkAnexos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAnexos.LinkClicked
        Dim frmAnexos As New frmAnexosConvenio
        frmAnexos.Anexos = Me.mAnexos
        frmAnexos.ShowDialog()
        Me.mAnexos = frmAnexos.Anexos
    End Sub

    Private Sub ugConveniosEnviados_AfterColPosChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterColPosChangedEventArgs) Handles ugConveniosEnviados.AfterColPosChanged

    End Sub
End Class

Public Enum EstadosConvenios
    Pendiente_Aprobacion = 1
    Aprobado = 2
    Rechazado = 3
    Modificado = 4
End Enum
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing
Imports Framework.Mensajes
Imports System.Text
Imports Infragistics.Win.UltraWinEditors
Imports System.Globalization
Imports MSL
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class ReporteConvenioLog



#Region "Variables y Proiedades"

    Dim mId_Convenio As Integer
    Dim mCod_Convenio As Integer
    Dim mDtConvenioLog As DataTable
    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato

    Public Property Cod_Convenio() As Integer
        Get
            Return mCod_Convenio
        End Get
        Set(ByVal Value As Integer)
            mCod_Convenio = Value
        End Set
    End Property

    Public Property Id_Convenio() As Integer
        Get
            Return mId_Convenio
        End Get
        Set(ByVal Value As Integer)
            mId_Convenio = Value
        End Set
    End Property

    Public Property DtConvenioLog() As DataTable
        Get
            Return mDtConvenioLog
        End Get
        Set(ByVal Value As DataTable)
            mDtConvenioLog = Value
        End Set
    End Property

#End Region


#Region "Eventos"

    Private Sub ReporteConvenioLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.uigGrillaConvenios.DataSource = DtConvenioLog

        AplicarFormatoGrilla()
        AplicarFormatoCeldas()
        CambiarNombreColumnas()
        AliniaTitulosColumnas()
        AliniarDatosCeldas()
        GrillaFormato.AcivarOperacion(uigGrillaConvenios)
        GrillaFormato.AutoAjustarColumnas(Me.uigGrillaConvenios)
        'CambiarColorCelda()

        Me.txtnroconvenio.Text = CStr(Id_Convenio)
        Me.txtregistrosCantidad.Text = DtConvenioLog.Rows.Count.ToString()

    End Sub

    Private Sub cmdExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub


    Private Sub uigGrillaConvenios_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uigGrillaConvenios.InitializeLayout
        Me.uigGrillaConvenios.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
    End Sub

#End Region


#Region "Metodos"

    Private Sub AliniaTitulosColumnas()

        With uigGrillaConvenios.DisplayLayout.Bands(0)
            .Columns("id_medio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Medio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SOPORTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("id_cliente").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CLIENTE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("id_producto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PRODUCTO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("cod_convenio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha Inicio").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha Fin").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Detalle").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PARTICIPACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PROGRAMA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_VENTA_1").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_VENTA_2").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_VENTA_3").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_VENTA_4").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_VENTA_5").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_COMPRA_1").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_COMPRA_2").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_COMPRA_3").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_COMPRA_4").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_COMPRA_5").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_EXTRA_1").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_EXTRA_2").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("IMP_NETO_VENTA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("IMP_NETO_COMPRA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("OBS_VENTA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("OBS_COMPRA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("OBS_EXTRA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("OBS_FINANZAS").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HORA_DESDE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HORA_HASTA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("COD_CONV_TARIFA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FECHA_MODIF").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("USER_MODIF").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_CONVENIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TIPO_CONVENIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TCONFIDENCIAL").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SEMANA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HORA_MODIFICACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub AliniarDatosCeldas()

        With uigGrillaConvenios.DisplayLayout.Bands(0)
            .Columns("id_medio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Medio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("SOPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("id_cliente").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("CLIENTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("id_producto").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PRODUCTO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("cod_convenio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha Inicio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Fecha Fin").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("Detalle").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("PARTICIPACION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("PROGRAMA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("DESC_VENTA_1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_VENTA_2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_VENTA_3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_VENTA_4").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_VENTA_5").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_COMPRA_1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_COMPRA_2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_COMPRA_3").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_COMPRA_4").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_COMPRA_5").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_EXTRA_1").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("DESC_EXTRA_2").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("IMP_NETO_VENTA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("IMP_NETO_COMPRA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("OBS_VENTA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("OBS_COMPRA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("OBS_EXTRA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("OBS_FINANZAS").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("HORA_DESDE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("HORA_HASTA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("COD_CONV_TARIFA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("FECHA_MODIF").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("USER_MODIF").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("ID_CONVENIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TIPO_CONVENIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("TCONFIDENCIAL").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("SEMANA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("HORA_MODIFICACION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left


        End With

    End Sub

    Private Function AplicarFormatoGrilla()

        GrillaFormato.HabilitarFiltro(Me.uigGrillaConvenios, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "id_medio", "Medio", "SOPORTE", "id_cliente", "CLIENTE", "id_producto", "PRODUCTO", "cod_convenio")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "Fecha Inicio", "Fecha Fin", "Detalle", "PARTICIPACION", "PROGRAMA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_VENTA_1", "DESC_VENTA_2", "DESC_VENTA_3", "DESC_VENTA_4", "DESC_VENTA_5")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_COMPRA_1", "DESC_COMPRA_2", "DESC_COMPRA_3", "DESC_COMPRA_4", "DESC_COMPRA_5")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_EXTRA_1", "DESC_EXTRA_2", "IMP_NETO_VENTA", "IMP_NETO_COMPRA", "OBS_VENTA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "OBS_COMPRA", "OBS_EXTRA", "OBS_FINANZAS", "HORA_DESDE", "HORA_HASTA", "SEMANA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "COD_CONV_TARIFA", "FECHA_MODIF", "USER_MODIF", "ID_CONVENIO", "TIPO_CONVENIO", "TCONFIDENCIAL", "HORA_MODIFICACION")

    End Function

    Private Function AplicarFormatoCeldas()

        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_VENTA_1", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_VENTA_2", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_VENTA_3", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_VENTA_4", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_VENTA_5", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_COMPRA_1", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_COMPRA_2", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_COMPRA_3", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_COMPRA_4", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_COMPRA_5", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_EXTRA_1", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "DESC_EXTRA_2", Formato.General)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "IMP_NETO_VENTA", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.uigGrillaConvenios, "IMP_NETO_COMPRA", Formato.Moneda)

    End Function

    Private Function CambiarNombreColumnas()

        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "id_medio", "Cod.Medio")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "Medio", "Medio")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "SOPORTE", "Soporte")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "id_cliente", "Cod.Cliente")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "CLIENTE", "Cliente")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "id_producto", "Cod.Producto")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "PRODUCTO", "Producto")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "cod_convenio", "Cod.Convenio")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "ID_CONVENIO", "Convenio MMS")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "Fecha Inicio", "Fecha Inicio")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "Fecha Fin", "Fecha Fin")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "Detalle", "Detalle")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "PARTICIPACION", "Participacion")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "PROGRAMA", "Programa")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_VENTA_1", "Desc. Venta 1")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_VENTA_2", "Desc. Venta 2")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_VENTA_3", "Desc. Venta 3")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_VENTA_4", "Desc. Venta 4")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_VENTA_5", "Desc. Venta 5")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_COMPRA_1", "Desc. Compra 1")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_COMPRA_2", "Desc. Compra 2")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_COMPRA_3", "Desc. Compra 3")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_COMPRA_4", "Desc. Compra 4")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_COMPRA_5", "Desc. Compra 5")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_EXTRA_1", "Desc. Extra 1")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_EXTRA_2", "Desc. Extra 2")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "IMP_NETO_VENTA", "Imp. Neto Venta")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "IMP_NETO_COMPRA", "Imp. Neto Compra")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "OBS_VENTA", "Obs. Venta")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "OBS_COMPRA", "Obs. Compra")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "OBS_EXTRA", "Obs. Extra")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "OBS_FINANZAS", "Obs. Finanzas")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "HORA_DESDE", "Hora Desde")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "HORA_HASTA", "Hora Hasta")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "COD_CONV_TARIFA", "Cod. Conv Tarifa")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "FECHA_MODIF", "F. Modificacion")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "USER_MODIF", "Usu. Modificacion")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "TIPO_CONVENIO", "Tipo Convenioe")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "TCONFIDENCIAL", "Tipo Condidencial")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "SEMANA", "Semana")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "HORA_MODIFICACION", "Hora Modificacion")

    End Function

    Private Sub CambiarColorCelda()

        For Each b As UltraGridBand In Me.uigGrillaConvenios.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To Me.uigGrillaConvenios.Rows.Count - 1
                With Me.uigGrillaConvenios.Rows(i)
                    .Cells("ID_MEDIO").Appearance.BackColor = Color.LightCoral
                    .Cells("SOPORTE").Appearance.BackColor = Color.LightCoral
                    .Cells("CLIENTE").Appearance.BackColor = Color.LightCoral
                    .Cells("PRODUCTO").Appearance.BackColor = Color.LightCoral
                    .Cells("ID_CONVENIO").Appearance.BackColor = Color.LightCoral
                    .Cells("Fecha Fin").Appearance.BackColor = Color.LightCoral
                    .Cells("PARTICIPACION").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_VENTA_1").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_VENTA_3").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_VENTA_5").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_COMPRA_1").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_COMPRA_3").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_COMPRA_5").Appearance.BackColor = Color.LightCoral
                    .Cells("DESC_EXTRA_2").Appearance.BackColor = Color.LightCoral
                    .Cells("IMP_NETO_COMPRA").Appearance.BackColor = Color.LightCoral
                    .Cells("OBS_COMPRA").Appearance.BackColor = Color.LightCoral
                    .Cells("OBS_FINANZAS").Appearance.BackColor = Color.LightCoral
                    .Cells("HORA_DESDE").Appearance.BackColor = Color.LightCoral
                    .Cells("COD_CONV_TARIFA").Appearance.BackColor = Color.LightCoral
                    .Cells("USER_MODIF").Appearance.BackColor = Color.LightCoral
                    .Cells("TCONFIDENCIAL").Appearance.BackColor = Color.LightCoral
                    '.Cells("HORA_MODIFICACION").Appearance.BackColor = Color.Beige
                End With
            Next
        Next

    End Sub

    Private Sub ExportarExcel()

        SaveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
        If SaveFileDialog.ShowDialog = DialogResult.OK Then
            Dim Excel As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
            Try
                Excel.Export(Me.uigGrillaConvenios, SaveFileDialog.FileName)
                Mensaje("El archivo se grabó con éxito.", TipoMensaje.Informacion)
            Catch ioex As IO.IOException
                Mensaje(ioex.Message, TipoMensaje.DeError)
            End Try
        End If

    End Sub

#End Region

End Class
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

Public Class frmAvisosAjuste

    Dim DtAvisosAjustar As DataTable
    Dim DtAvisosAjustarClone As DataTable
    Dim NroPresupuesto As Integer
    Dim GrillaFormato As New GrillaFormato
    Dim OCMacheo As Control_Macheo
    Dim LOrdenesExistente As List(Of Integer)
    Dim ControlAjustes As Boolean

    Public Property mNroPresupuesto() As Integer
        Get
            Return NroPresupuesto
        End Get
        Set(ByVal Value As Integer)
            NroPresupuesto = Value
        End Set
    End Property

    Public Property mDtAjustarAvisos() As DataTable
        Get
            Return DtAvisosAjustar
        End Get
        Set(ByVal Value As DataTable)
            DtAvisosAjustar = Value
        End Set
    End Property

    Private Sub frmAvisosAjuste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ClonarDtAvisosAjustar()
        ValidarAjustesExistentes()
        CargarGrilla()
        Me.txtnropresupuesto.Text = CStr(NroPresupuesto)

        If DtAvisosAjustarClone.Rows.Count = 0 Then
            MsgBox("Los avisos seleccionados, ya se encuentran ajustadas.", MsgBoxStyle.Information)
            Me.cmdAjustar.Enabled = False
            Exit Sub
        End If

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        DtAvisosAjustarClone = Nothing
        Me.Close()
    End Sub

    Private Sub AplicarFormatoGrilla()

        '============================= Oculto las columnas que no se utilizan=============================
        Listas.OcultarColumnas(Me.ugAjustes, "cod_soporte", "Observaciones", "btnobservaciones")
        Listas.OcultarColumnas(Me.ugAjustes, "cod_soporte", "Observaciones", "btnobservaciones", "ORDEN_ORIGINAL")
        Listas.CambiarTituloColumna(Me.ugAjustes, "ORDEN_AJUSTADA", "Orden Ajuste")
        Listas.CambiarTituloColumna(Me.ugAjustes, "IMPORTE_AJUSTADO", "Neto Ajuste")
        Listas.CambiarTituloColumna(Me.ugAjustes, "SEPARADOR", "")
        '============================= Alineo el contenido de las celdas ================================
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Orden", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Cod_Soporte", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Soporte", Infragistics.Win.HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Fecha", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Hora", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Duracion", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Programa", Infragistics.Win.HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Neto", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "Material", Infragistics.Win.HAlign.Left)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "ORDEN_ORIGINAL", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "ORDEN_AJUSTADA", Infragistics.Win.HAlign.Center)
        GrillaFormato.CambiarAlineacionColumna(Me.ugAjustes, "IMPORTE_AJUSTADO", Infragistics.Win.HAlign.Center)
        '============================= Inhabilito la edicion de las celdas ===============================
        GrillaFormato.HabilitarEdicionColumna(Me.ugAjustes, Activation.NoEdit, True)
        '============================= Le doy formato a la grila =====================================
        With ugAjustes.DisplayLayout.Bands(0)
            .Columns("Neto").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("Neto").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("IMPORTE_AJUSTADO").MaskInput = "-nnn,nnn,nnn.nn"
            .Columns("IMPORTE_AJUSTADO").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
            .Columns("Orden").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Soporte").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Fecha").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Hora").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Duracion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Programa").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Observaciones").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Material").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Neto").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ORDEN_AJUSTADA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("IMPORTE_AJUSTADO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("SEPARADOR").Width = 20
            .Columns("Duracion").Width = 70
            .Columns("Hora").Width = 85
        End With
        
        Me.ugAjustes.DisplayLayout.Bands(0).Columns("Fecha").CellActivation = Activation.NoEdit
        Me.ugAjustes.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        Me.ugAjustes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

        AplicarColorCeldaSeparador()

    End Sub

    Private Sub AplicarColorCeldaSeparador()
        For Each DrGrilla As UltraGridRow In Me.ugAjustes.Rows
            DrGrilla.Cells("SEPARADOR").Appearance.BackColor = Color.Gray
        Next
    End Sub

    Private Sub CargarGrilla()

        If DtAvisosAjustar.Rows.Count > 0 Then
            AnexarColumnas()
            ugAjustes.DataSource = DtAvisosAjustarClone
            AplicarFormatoGrilla()
        End If

    End Sub

    Private Sub ClonarDtAvisosAjustar()
        DtAvisosAjustarClone = DtAvisosAjustar.Clone
        DtAvisosAjustarClone = DtAvisosAjustar.Copy
    End Sub

    Private Sub cmdAjustar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAjustar.Click

        Dim DtAjustar As New DataTable
        Dim LAvisosAjuste As New List(Of AvisosAjustes)
        Dim ResultInsert As String
        Dim LOrdenesAjustadas As New List(Of AvisosAjustes)


        If DtAvisosAjustar.Rows.Count > 0 Then
            If ControlAjustes = False Then
                OCMacheo = New Control_Macheo
                LAvisosAjuste = CargarListaOrdenAjustar()
                ResultInsert = OCMacheo.InsertarAvisosAjuste(LAvisosAjuste)
                If ResultInsert = "" Then
                    LOrdenesAjustadas = OCMacheo.GenerarAjusteAutomatico(CInt(Activo.CodCampaniaActualMms), CInt(Me.txtnropresupuesto.Text))
                Else
                    Mensaje("No pudieron insertarse las Ordenes a Ajustar.")
                End If
                If LOrdenesAjustadas.Count > 0 Then
                    EnlazarOrdenesAjustadas(LAvisosAjuste)
                    ugAjustes.DataSource = EnlazarOrdenesAjustadas(LOrdenesAjustadas)
                    AplicarFormatoGrilla()
                    Mensaje("Los Avisos seleccionados se Ajustaron exitosamente.!", TipoMensaje.Informacion)
                    ControlAjustes = True
                    'AG 05/05/2014 Descomentar para el pase a produccion =========================
                    Ajuste_Spots_SpotDetalle()
                    '=============================================================================
                Else
                    Mensaje("Los Avisos seleccionados no se Ajustaron.", TipoMensaje.Informacion)
                End If
            Else
                MsgBox("Los avisos seleccionados, ya se encuentran ajustadas.", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Function Ajuste_Spots_SpotDetalle()

        'AG 05/05/2014 =================================================================
        Dim ValorImporteCalculado As Double
        OCMacheo = New Control_Macheo


        If Not Me.ugAjustes.Rows Is Nothing Then
            For Each RowOrden As UltraGridRow In ugAjustes.Rows
                ValorImporteCalculado = (RowOrden.Cells("Neto").Value / RowOrden.Cells("Duracion").Value) * -1
                OCMacheo.Realizar_Ajuste(RowOrden.Cells("Orden").Value, ValorImporteCalculado, ValorImporteCalculado, RowOrden.Cells("Duracion").Value, RowOrden.Cells("ORDEN_AJUSTADA").Value)
            Next
        End If

        '====================================================================================

    End Function

    Private Function ArmarDtOrdenAjustar()

        Dim DtOrdenAjustar As New DataTable

        With DtOrdenAjustar
            .Columns.Add("cod_compania", GetType(Integer))
            .Columns.Add("cod_presupuesto", GetType(Integer))
            .Columns.Add("cod_orden_origen", GetType(Integer))
            .Columns.Add("cod_orden_nuevo", GetType(Integer))
            .Columns.Add("fecha_enviada", GetType(DateTime))
            .Columns.Add("ind_estado", GetType(Integer))
            .Columns.Add("cod_usuario", GetType(Integer))
        End With

        Return DtOrdenAjustar

    End Function

    Private Sub EliminarColumnas()
        DtAvisosAjustar.Columns.Remove("SEPARADOR")
        DtAvisosAjustar.Columns.Remove("ORDEN_ORIGINAL")
        DtAvisosAjustar.Columns.Remove("ORDEN_AJUSTADA")
        DtAvisosAjustar.Columns.Remove("IMPORTE_AJUSTADO")
    End Sub

    Private Sub AnexarColumnas()

        With DtAvisosAjustarClone
            .Columns.Add("SEPARADOR", GetType(String))
            .Columns.Add("ORDEN_ORIGINAL", GetType(Integer))
            .Columns.Add("ORDEN_AJUSTADA", GetType(Integer))
            .Columns.Add("IMPORTE_AJUSTADO", GetType(Double))
        End With
    End Sub

    Private Function CargarListaOrdenAjustar() As List(Of AvisosAjustes)

        Dim LAvisosAjuste As New List(Of AvisosAjustes)
        Dim AvisoAjustar As AvisosAjustes

        For Each RowAjustar As DataRow In Me.DtAvisosAjustarClone.Rows
            AvisoAjustar = New AvisosAjustes
            With AvisoAjustar
                .CodigoCompania = CInt(Activo.CodCampaniaActualMms)
                .CodigoPresupuesto = CInt(Me.txtnropresupuesto.Text)
                .CodigoOrdenOrigen = RowAjustar("Orden")
                .CodigoOrdenNuevo = 0
                .fechaEnviado = Date.Now
                .CodigoEstado = 0
                .CodigoUsuario = CInt(Activo.CodUsuarioMms)
            End With
            LAvisosAjuste.Add(AvisoAjustar)
        Next

        Return LAvisosAjuste

    End Function

    Private Function EnlazarOrdenesAjustadas(ByVal lAvisosAjustar As List(Of AvisosAjustes)) As DataTable

        Dim OAvisoAjuste As AvisosAjustes
        Dim i As Integer
        Dim RowAjuste() As DataRow
        Dim DtResultadoAjuste As New DataTable

        For i = 0 To lAvisosAjustar.Count - 1
            OAvisoAjuste = New AvisosAjustes
            OAvisoAjuste = lAvisosAjustar.Item(i)
            RowAjuste = DtAvisosAjustarClone.Select("Orden='" & OAvisoAjuste.CodigoOrdenOrigen & "'")
            If RowAjuste.Length > 0 Then
                RowAjuste(0)("ORDEN_ORIGINAL") = OAvisoAjuste.CodigoOrdenOrigen
                RowAjuste(0)("ORDEN_AJUSTADA") = OAvisoAjuste.CodigoOrdenNuevo
                If Not OAvisoAjuste.ImporteAjusatdo Is Nothing Then
                    RowAjuste(0)("IMPORTE_AJUSTADO") = Double.Parse(OAvisoAjuste.ImporteAjusatdo.ToString)
                Else
                    RowAjuste(0)("IMPORTE_AJUSTADO") = 0
                End If
            End If
        Next

        DtResultadoAjuste = DtAvisosAjustarClone
        Return DtResultadoAjuste
    End Function

    Private Sub ValidarAjustesExistentes()

        Dim oCMacheo As New Control_Macheo
        Dim DrExistente As DataRow()
        Dim DrEliminar As DataRow()
        Dim i, j As Integer

        LOrdenesExistente = oCMacheo.ValidarAjustesExistentes(CInt(Activo.CodCampaniaActualMms), CInt(NroPresupuesto))

        If LOrdenesExistente.Count > 0 Then
            For i = 0 To LOrdenesExistente.Count - 1
                DrExistente = DtAvisosAjustarClone.Select("Orden=" & LOrdenesExistente(i))
                If DrExistente.Length > 0 Then
                    For j = 0 To DrExistente.Length - 1
                        DtAvisosAjustarClone.Rows.Remove(DrExistente(j))
                        DtAvisosAjustarClone.AcceptChanges()
                    Next j
                End If
            Next
        End If

    End Sub

End Class
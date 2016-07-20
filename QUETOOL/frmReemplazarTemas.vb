Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing

Public Class frmReemplazarTemas

    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato
    Dim _FDesde As Date
    Dim _FHasta As Date
    Dim _ReemplazoFDesde As Date
    Dim _ReemplazoFHasta As Date
    Dim DtTemasReemplazo As New DataTable
    Dim _DtTemasReemplazoFinal As New DataTable
    Dim _DtTemasSeleccionadoFinal As New DataTable
    Dim _DtTemasViejosEliminar As New DataTable
    Dim _DtSpotDetalle As New DataTable
    Dim _DtSpot As New DataTable
    Dim _DtTemasCampania As DataTable
    Dim _DtTemasHoja As DataTable
    Dim ResultadoValidacion As Boolean = False
    Dim valortipoObjetico As Double
    Dim TipoError As Integer
    Dim _CantAvisosComprados As Integer
    Dim _InversionTotalCompradas As Double
    Dim _AperturaFormulario As Boolean
    Dim _TipoAplicacion As Integer
    Dim CantidadAvisosEntreFechas As Integer
    Dim _CantidadAvisoPermitidos As Integer
    Dim DtTemasNuevos As DataTable
    Dim DtTema As DataTable
    Dim ControlPasePorcentajeTema As Boolean = False
    Dim ControlMensajePorcentajeTemas As Boolean = False
    Dim dtControlCerrar As DataTable

#Region "Propiedades"

    Public Property AperturaFormulario() As Boolean
        Get
            Return _AperturaFormulario
        End Get
        Set(ByVal value As Boolean)
            _AperturaFormulario = value
        End Set
    End Property

    Public Property CantidadAvisoPermitidos() As Integer
        Get
            Return _CantidadAvisoPermitidos
        End Get
        Set(ByVal value As Integer)
            _CantidadAvisoPermitidos = value
        End Set
    End Property

    Public Property FDesde() As Date
        Get
            Return _FDesde
        End Get
        Set(ByVal value As Date)
            _FDesde = value
        End Set
    End Property

    Public Property FHasta() As Date
        Get
            Return _FHasta
        End Get
        Set(ByVal value As Date)
            _FHasta = value
        End Set
    End Property

    Public Property ReemplazoFDesde() As Date
        Get
            Return _ReemplazoFDesde
        End Get
        Set(ByVal value As Date)
            _ReemplazoFDesde = value
        End Set
    End Property

    Public Property ReemplazoFHasta() As Date
        Get
            Return _ReemplazoFHasta
        End Get
        Set(ByVal value As Date)
            _ReemplazoFHasta = value
        End Set
    End Property

    Public Property DtTemasCampania() As DataTable
        Get
            Return _DtTemasCampania
        End Get
        Set(ByVal value As DataTable)
            _DtTemasCampania = value
        End Set
    End Property

    Public Property DtTemasHoja() As DataTable
        Get
            Return _DtTemasHoja
        End Get
        Set(ByVal value As DataTable)
            _DtTemasHoja = value
        End Set
    End Property

    Public Property DtTemasReemplazoFinal() As DataTable
        Get
            Return _DtTemasReemplazoFinal
        End Get
        Set(ByVal value As DataTable)
            _DtTemasReemplazoFinal = value
        End Set
    End Property

    Public Property DtTemasSeleccionadoFinal() As DataTable
        Get
            Return _DtTemasSeleccionadoFinal
        End Get
        Set(ByVal value As DataTable)
            _DtTemasSeleccionadoFinal = value
        End Set
    End Property

    Public Property DtSpot() As DataTable
        Get
            Return _DtSpot
        End Get
        Set(ByVal value As DataTable)
            _DtSpot = value
        End Set
    End Property

    Public Property DtSpotDetalle() As DataTable
        Get
            Return _DtSpotDetalle
        End Get
        Set(ByVal value As DataTable)
            _DtSpotDetalle = value
        End Set
    End Property

    Public Property TipoAplicacion() As Integer
        Get
            Return _TipoAplicacion
        End Get
        Set(ByVal value As Integer)
            _TipoAplicacion = value
        End Set
    End Property

    Public Property CantAvisosComprados() As Integer
        Get
            Return _CantAvisosComprados
        End Get
        Set(ByVal value As Integer)
            _CantAvisosComprados = value
        End Set
    End Property

    Public Property InversionTotalCompradas() As Double
        Get
            Return _InversionTotalCompradas
        End Get
        Set(ByVal value As Double)
            _InversionTotalCompradas = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmReemplazarTemas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'If frmEjercicio.Instancia._ReemplazarCancelar = False Then
        '    frmEjercicio.Instancia._ReemplazarCancelar = False
        'Else
        '    frmEjercicio.Instancia._ReemplazarCancelar = True
        'End If

    End Sub

    Private Sub frmReemplazarTemas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarDatosIniciales()
        AnexarFilaTotalPorcentajes()

        uigTemas.DataSource = Me.DtTemasHoja
        Me.uigTemasNuevos.DataSource = Me.DtTemasCampania
        FormatoGrillas()
        CambiarColorFilaTotal()
        CrearDtDtTemasReemplazoFinal()
        CrearDtDtTemasSeleccionadoFinal()

        frmEjercicio.Instancia._ReemplazarCancelar = False

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click

        frmEjercicio.Instancia._ReemplazarCancelar = True
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        ' Valido las Fechas ingresadas --------------------------------------------------------------------------------------
        TipoError = ValidarFechasIngresadas()

        If TipoError = 1 Then
            MsgBox("La Fecha Desde del Sistema Ingresada debe, ser menor a la Fecha Hasta del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        ElseIf TipoError = 2 Then
            MsgBox("La Fecha Hasta del Sistema Ingresada debe, ser mayor a la Fecha Desde del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------------------------------------------


        ' Valido las Fechas Fin ingresadas --------------------------------------------------------------------------------------
        TipoError = ControlFechaInicioSistema()

        If TipoError = 1 Then
            MsgBox("La Fecha Desde Ingresada, no puede ser menor a la Fecha Inicio del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        ElseIf TipoError = 2 Then
            MsgBox("La Fecha Desde del Sistema Ingresada, no puede ser mayor a la Fecha Fin del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------------------------------------------


        ' Valido las Fechas Fin ingresadas --------------------------------------------------------------------------------------
        TipoError = ControlFechaFinSistema()

        If TipoError = 1 Then
            MsgBox("La Fecha Hasta Ingresada, no puede ser mayor a la Fecha Fin del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        ElseIf TipoError = 2 Then
            MsgBox("La Fecha Hasta Ingresada debe, no pueder ser menor a la Fecha Fin del Sistema", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------------------------------------------

        If ValidarPorcentajesXTemaReemplazo() = True Then
            MsgBox("Los valores de los porcentaje, no pueden ser NULOS o Menor a 0 (Cero). ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If

        If ValidarTotalPorcentajeFinal() = True Then
            MsgBox("El valor total de los PORCENTAJE, no es aceptable. ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If


        If ValidarCantAvisos_ImporteCorrectos() = True Then
            If EnuTipoAplicacion.INVERSION = TipoAplicacion Then
                MsgBox("El valor del Importe calculado permitido, no permite ejecutar este proceso. ", MsgBoxStyle.Information, "Everest")
                LimpiarDtCargados()
                Exit Sub
            ElseIf EnuTipoAplicacion.GRPS = TipoAplicacion Then
                MsgBox("El valor de la Cantidad Avisos calculado permitido, no permite ejecutar este proceso. ", MsgBoxStyle.Information, "Everest")
                LimpiarDtCargados()
                Exit Sub
            End If
        End If

        CargarVariables()

        ObtenerCantidadTotalAvisos()
        ObtenerInversionMaximaXTema()

        DtTema = CargarDtTemasSeleccionados()
        DtTemasNuevos = CargarDtReemplazoTemas()


        With frmEjercicio.Instancia
            ._ReemplazoFDesde = dtpFechaInicioD.Value
            ._ReemplazoFHasta = dtpFechaFinD.Value
            ._ReemplazoTemasTipoObjetivo = Me.TipoAplicacion
            ._CantidadAvisosPermitidosReemplazo = _CantidadAvisoPermitidos
            ._DtReemplazoFinal = DtTemasNuevos
            ._DtReemplazoSeleccionados = DtTema
            ._DtReemplazoDetalleSpot = CargarDtSpotDetalleAvisosNuevos()
            ._DtReemplazoAvisosEliminar = _DtTemasViejosEliminar
            ._ReemplazarCancelar = False
        End With

        Me.Close()
    End Sub

    Private Sub uigTemasNuevos_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles uigTemasNuevos.AfterCellUpdate

        Select Case e.Cell.Column.Key
            Case "PORCENTAJE"
                Dim ResultadoTotalTema As Double

                ResultadoTotalTema = AutoSumaTotalPorcentajeTemasNuevo()
                If ControlPasePorcentajeTema = False Then
                    If ResultadoTotalTema >= 0 And ResultadoTotalTema <= 100 Then
                        ControlPasePorcentajeTema = True
                        Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("PORCENTAJE").Value = ResultadoTotalTema
                    Else
                        If ControlMensajePorcentajeTemas = False Then
                            ControlMensajePorcentajeTemas = True
                            Mensajes.Mensaje("El valor del Total Porcentaje, por TEMA REEMPLAZO no es un valor aceptable.", TipoMensaje.Informacion)
                        End If
                    End If
                Else
                    ControlPasePorcentajeTema = False
                    Exit Sub
                End If

        End Select
        ControlMensajePorcentajeTemas = False
    End Sub

    Private Sub uigTemasNuevos_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles uigTemasNuevos.CellDataError

        If Me.uigTemasNuevos.ActiveCell Is Nothing Then
            Exit Sub
        End If

        With uigTemasNuevos.ActiveCell.Column
            Select Case .Key
                Case "PORCENTAJE"
                    If Not IsNumeric(uigTemasNuevos.ActiveCell.Text) Then
                        Mensajes.Mensaje("Este campo solo admite numeros con 2 decimales", TipoMensaje.Informacion)
                        e.RestoreOriginalValue = False
                        uigTemasNuevos.ActiveCell.Value = 0
                    End If
            End Select
        End With
        e.RaiseErrorEvent = False

    End Sub

    Private Sub uigTemasNuevos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uigTemasNuevos.KeyDown

        Dim EnEdicion As Boolean = Me.uigTemasNuevos.ActiveCell.IsInEditMode

        If Not Me.uigTemasNuevos.ActiveRow Is Nothing AndAlso Me.uigTemasNuevos.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not uigTemasNuevos.ActiveCell Is Nothing Then
                    If Not uigTemasNuevos.ActiveCell.IsInEditMode Then
                        uigTemasNuevos.ActiveCell.Value = ""
                    End If
                End If
            End If
        End If

        Select Case e.KeyValue

            Case Keys.Delete
                uigTemasNuevos.ActiveCell.Value = 0

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then
                    uigTemasNuevos.PerformAction(ExitEditMode, False, False)
                Else
                    uigTemasNuevos.PerformAction(EnterEditMode, False, False)
                End If
                uigTemasNuevos.UpdateData()

        End Select

    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarDatosIniciales()

        Me.dtpFechaInicioD.Value = Me._FDesde
        Me.dtpFechaFinD.Value = Me._FHasta
        Me.rdgrp.Checked = True
        Me.rdinversion.Checked = False

    End Sub

    Private Sub FormatoGrillas()

        'Grilla TEMAS HOJA ==============================================================
        Listas.CambiarTituloColumna(Me.uigTemas, "TemaHoja", "Tema Aplicado")
        Listas.CambiarTituloColumna(Me.uigTemas, "DURACION", "Duracion")

        GrillaFormato.CambiarAlineacionColumna(Me.uigTemas, HAlign.Right)
        GrillaFormato.HabilitarFiltro(Me.uigTemas, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigTemas, Activation.NoEdit, "TemaHoja", "DURACION")
        GrillaFormato.AutoAjustarColumnas(Me.uigTemas, "TemaHoja")
        GrillaFormato.AutoAjustarColumnas(Me.uigTemas, "DURACION")


        With Me.uigTemas.DisplayLayout.Bands(0)
            .Columns("TemaHoja").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DURACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("TemaHoja").Width = 100
            .Columns("DURACION").Width = 100
            .Columns("SEL").Width = 60
        End With


        'Grilla TEMAS REEMPLAZAR  ==============================================================
        Listas.CambiarTituloColumna(Me.uigTemasNuevos, "Tema", "Tema Reemplazo")
        Listas.CambiarTituloColumna(Me.uigTemasNuevos, "DURACION", "Duracion")
        Listas.CambiarTituloColumna(Me.uigTemasNuevos, "PORCENTAJE", "Porcentaje")
        GrillaFormato.CambiarFormatoColumna(Me.uigTemasNuevos, "PORCENTAJE", Formato.Decimales)
        GrillaFormato.CambiarAlineacionColumna(Me.uigTemasNuevos, HAlign.Right)
        GrillaFormato.HabilitarFiltro(Me.uigTemasNuevos, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigTemasNuevos, Activation.NoEdit, "Tema", "DURACION")
        GrillaFormato.AutoAjustarColumnas(Me.uigTemasNuevos, "Tema")
        GrillaFormato.AutoAjustarColumnas(Me.uigTemasNuevos, "DURACION")

        With Me.uigTemasNuevos.DisplayLayout.Bands(0)
            .Columns("Tema").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DURACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PORCENTAJE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Tema").Width = 130
            .Columns("PORCENTAJE").Width = 100
            .Columns("DURACION").Width = 100
        End With

        GrillaFormato.HabilitarCelda(Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("PORCENTAJE"), Activation.NoEdit)

    End Sub

    Private Function CargarDtReemplazoTemas() As DataTable

        Dim DrFilaFinal As DataRow

        If Not Me.uigTemasNuevos.Rows Is Nothing Then
            For Each RowTemaReemplazo As UltraGridRow In uigTemasNuevos.Rows
                If RowTemaReemplazo.Cells("TEMA").Value <> "TOTAL PORCENTAJE" Then
                    If RowTemaReemplazo.Cells("Sel").Value = True Then
                        DrFilaFinal = _DtTemasReemplazoFinal.NewRow()
                        DrFilaFinal("TEMA_NUEVO") = RowTemaReemplazo.Cells("Tema").Value
                        DrFilaFinal("DURACION") = RowTemaReemplazo.Cells("DURACION").Value
                        DrFilaFinal("CANTTEMAS") = CalcularCantidadAvisosPermitidos(RowTemaReemplazo.Cells("PORCENTAJE").Value)
                        DrFilaFinal("IMPORTE") = CalcularImportePermitidos(RowTemaReemplazo.Cells("PORCENTAJE").Value)
                        DrFilaFinal("PORCENTAJE") = RowTemaReemplazo.Cells("PORCENTAJE").Value
                        DrFilaFinal("FINAL_LIMITE") = EnuFinalizar.INICIADO
                        _DtTemasReemplazoFinal.Rows.Add(DrFilaFinal)
                        _DtTemasReemplazoFinal.AcceptChanges()
                    End If
                End If
            Next
        End If


        _DtTemasReemplazoFinal = OrdenarDtReemplazo(_DtTemasReemplazoFinal)

        Return _DtTemasReemplazoFinal

    End Function

    Private Function OrdenarDtReemplazo(ByVal DtPriorizar As DataTable) As DataTable

        Dim FilaOrden As DataRow()
        Dim FilaNueva As DataRow
        Dim DtOrdenado As New DataTable

        If EnuTipoAplicacion.GRPS = TipoAplicacion Then
            FilaOrden = DtPriorizar.Select("", "CANTTEMAS DESC")
            If FilaOrden.Length > 0 Then
                DtOrdenado = DtPriorizar.Clone
                For h As Integer = 0 To FilaOrden.Length - 1
                    FilaNueva = DtOrdenado.NewRow
                    DtOrdenado.ImportRow(FilaOrden(h))
                Next
                DtOrdenado.AcceptChanges()
            End If
        ElseIf EnuTipoAplicacion.INVERSION = TipoAplicacion Then
            FilaOrden = DtPriorizar.Select("", "IMPORTE DESC")
            If FilaOrden.Length > 0 Then
                DtOrdenado = DtPriorizar.Clone
                For t As Integer = 0 To FilaOrden.Length - 1
                    FilaNueva = DtOrdenado.NewRow
                    DtOrdenado.ImportRow(FilaOrden(t))
                Next
                DtOrdenado.AcceptChanges()
            End If
        End If


        Return DtOrdenado


    End Function

    Private Function CargarDtTemasSeleccionados() As DataTable

        Dim DrFila As DataRow

        If Not Me.uigTemas.Rows Is Nothing Then
            For Each RowTema As UltraGridRow In uigTemas.Rows
                If RowTema.Cells("Sel").Value = True Then
                    DrFila = _DtTemasSeleccionadoFinal.NewRow()
                    DrFila("TEMA") = RowTema.Cells("TemaHoja").Value
                    _DtTemasSeleccionadoFinal.Rows.Add(DrFila)
                    _DtTemasSeleccionadoFinal.AcceptChanges()
                End If
            Next
        End If

        Return _DtTemasSeleccionadoFinal

    End Function

    Private Function CalcularCantidadAvisosPermitidos(ByVal Porcentage As Double) As Integer

        Dim Resultado As Integer = 0

        Resultado = Math.Truncate((_CantidadAvisoPermitidos * Porcentage) / 100)

        Return Resultado

    End Function

    Private Function CalcularImportePermitidos(ByVal Porcentage As Double) As Double

        Dim Resultado As Double

        Resultado = Math.Round((Me.InversionTotalCompradas * Porcentage) / 100, 2)

        Return Resultado

    End Function

    Private Sub CrearDtDtTemasReemplazoFinal()

        _DtTemasReemplazoFinal.Columns.Add("TEMA_NUEVO", GetType(String))
        _DtTemasReemplazoFinal.Columns.Add("DURACION", GetType(Integer))
        _DtTemasReemplazoFinal.Columns.Add("CANTTEMAS", GetType(Integer))
        _DtTemasReemplazoFinal.Columns.Add("IMPORTE", GetType(Double))
        _DtTemasReemplazoFinal.Columns.Add("PORCENTAJE", GetType(Double))
        _DtTemasReemplazoFinal.Columns.Add("FINAL_LIMITE", GetType(Integer))

    End Sub

    Private Sub CrearDtDtTemasSeleccionadoFinal()
        _DtTemasSeleccionadoFinal.Columns.Add("TEMA", GetType(String))
    End Sub

    Private Function ValidarDatos() As Boolean


        'If Me.txtvalortipoObjetico.Text <> "" Then
        '    If Not IsNumeric(Me.txtvalortipoObjetico.Text) Then
        '        MsgBox("Debe Ingresar un Valor Numerico, para el Objetivo", MsgBoxStyle.Information, "Distribuidor de Pases")
        '        Me.txtvalortipoObjetico.Focus()
        '        ResultadoValidacion = True
        '        Exit Function
        '    Else
        '        Me.valortipoObjetico = Me.txtvalortipoObjetico.Text
        '        ResultadoValidacion = False
        '    End If
        'End If

        'If Me.txtvalortipoObjetico.Text <> "" Then
        '    If CDbl(Me.txtvalortipoObjetico.Text) <= 0 Then
        '        MsgBox("Debe Ingresar un Valor Numerico, para el Objetivo MAYOR a Cero.", MsgBoxStyle.Information, "Distribuidor de Pases")
        '        Me.txtvalortipoObjetico.Focus()
        '        ResultadoValidacion = True
        '        Exit Function
        '    Else
        '        Me.valortipoObjetico = Me.txtvalortipoObjetico.Text
        '        ResultadoValidacion = False
        '    End If
        'End If

    End Function

    Private Function ValidarFechasIngresadas() As Integer

        Dim TipoError As Integer

        If CDate(dtpFechaInicioD.Value) > CDate(dtpFechaFinD.Value) Then
            dtpFechaInicioD.Value = FDesde
            TipoError = 1
        End If

        If CDate(dtpFechaFinD.Value) < CDate(dtpFechaInicioD.Value) Then
            dtpFechaFinD.Value = FHasta
            TipoError = 2
        End If

        Return TipoError

    End Function

    Private Function ControlFechaInicioSistema() As Integer

        Dim TipoError As Integer

        If CDate(dtpFechaInicioD.Value) < FDesde Then
            dtpFechaInicioD.Value = FDesde
            TipoError = 1
        End If

        If CDate(dtpFechaInicioD.Value) > FHasta Then
            dtpFechaInicioD.Value = FDesde
            TipoError = 2
        End If

        Return TipoError

    End Function

    Private Function ControlFechaFinSistema() As Integer

        Dim TipoError As Integer

        If CDate(dtpFechaFinD.Value) > FHasta Then
            dtpFechaFinD.Value = FHasta
            TipoError = 1
        End If

        If CDate(dtpFechaFinD.Value) < FDesde Then
            dtpFechaFinD.Value = FHasta
            TipoError = 2
        End If

        Return TipoError

    End Function

    Private Function ObtenerCantidadTotalAvisos()

        Dim DRow As DataRow()

        If Not Me.uigTemas.Rows Is Nothing Then
            For Each RowTema As UltraGridRow In uigTemas.Rows
                If RowTema.Cells("Sel").Value = True Then
                    For Each Row As DataRow In DtSpotDetalle.Rows
                        If CDate(Row("F_SPOT")) >= Me.dtpFechaInicioD.Value And CDate(Row("F_SPOT")) <= Me.dtpFechaFinD.Value Then
                            If Row("ID_TEMA") = RowTema.Cells("TemaHoja").Value Then
                                CantidadAvisosEntreFechas += 1
                            End If
                        End If
                    Next
                End If
            Next
        End If

        _CantidadAvisoPermitidos = CantidadAvisosEntreFechas

    End Function

    Private Function ObtenerInversionMaximaXTema()

        Dim DRow As DataRow()
        Dim Duracion As Integer
        Dim Neto As Double
        Dim Resultado As Double

        If Not Me.uigTemas.Rows Is Nothing Then
            For Each RowTema As UltraGridRow In uigTemas.Rows
                If RowTema.Cells("Sel").Value = True Then
                    For Each Row As DataRow In DtSpotDetalle.Rows
                        If CDate(Row("F_SPOT")) >= Me.dtpFechaInicioD.Value And CDate(Row("F_SPOT")) <= Me.dtpFechaFinD.Value Then
                            If Row("ID_TEMA") = RowTema.Cells("TemaHoja").Value Then
                                DRow = Me.DtSpot.Select("ID_SPOT=" & Row("ID_SPOT"))
                                If DRow.Length > 0 Then
                                    Neto = DRow(0)("NETO")
                                    Duracion = RowTema.Cells("Duracion").Value
                                    Resultado += Neto * Duracion
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        End If

        Me._InversionTotalCompradas = Resultado

    End Function

    Private Function ValidarPorcentajesXTemaReemplazo() As Boolean

        Dim DrFila As DataRow
        Dim Resultado As Boolean

        If Not Me.uigTemasNuevos.Rows Is Nothing Then
            For Each RowValidar As UltraGridRow In uigTemasNuevos.Rows

                If RowValidar.Cells("Sel").Value = True Then
                    If Not RowValidar.Cells("PORCENTAJE").Value Is System.DBNull.Value Then
                        If RowValidar.Cells("PORCENTAJE").Value > 0 Then
                            Resultado = False
                        Else
                            Resultado = True
                            Return Resultado
                            Exit Function
                        End If
                    Else
                        Resultado = True
                        Return Resultado
                        Exit Function
                    End If
                End If
            Next
        End If

        Return Resultado

    End Function

    Private Function ValidarCantAvisos_ImporteCorrectos() As Boolean

        Dim Resultado As Boolean

        If Not _DtTemasReemplazoFinal Is Nothing Then
            If _DtTemasReemplazoFinal.Rows.Count > 0 Then
                For Each RowValidar As DataRow In _DtTemasReemplazoFinal.Rows
                    If EnuTipoAplicacion.INVERSION = TipoAplicacion Then
                        If RowValidar("IMPORTE") = 0 Then
                            Resultado = True
                            Return Resultado
                            Exit Function
                        End If
                    ElseIf EnuTipoAplicacion.GRPS = TipoAplicacion Then
                        If RowValidar("CANTTEMAS") = 0 Then
                            Resultado = True
                            Return Resultado
                            Exit Function
                        End If
                    End If
                Next
            Else
                Resultado = True
                Return Resultado
                Exit Function
            End If
        Else
            Resultado = True
            Return Resultado
            Exit Function
        End If

        Return Resultado

    End Function

    Private Sub CargarVariables()

        Me._ReemplazoFDesde = Me.dtpFechaInicioD.Value
        Me._ReemplazoFHasta = Me.dtpFechaFinD.Value

        If rdgrp.Checked = True Then
            Me.TipoAplicacion = EnuTipoAplicacion.GRPS
        ElseIf Me.rdinversion.Checked = True Then
            Me.TipoAplicacion = EnuTipoAplicacion.INVERSION
        End If

    End Sub

    Private Sub LimpiarDtCargados()

        _DtTemasReemplazoFinal.Clear()
        _DtTemasSeleccionadoFinal.Clear()

    End Sub

    Private Function CargarDtSpotDetalleAvisosNuevos() As DataTable

        Dim DtDetalleNuevo As New DataTable
        Dim DtIDSpot As DataTable = Me.DtSpotDetalle.DefaultView.ToTable(True, "ID_SPOT")
        Dim DtSpotDetalleLimpio As New DataTable
        Dim DrFilaNueva As DataRow
        Dim ControlAvisosPermitidos As Integer
        Dim TemaNuevoReemplazo As String
        Dim CantidadAvisosPermitidoXTemaNuevo As Integer
        Dim ControlCantidadAvisosTotalPermitido As Integer
        Dim IndiceAvisos As Integer
        Dim DiaAviso As Date
        Dim DiaAvisoAnterior As Date
        Dim DiaAvisoProximo As Date
        Dim DtAgrupado As DataTable
        Dim DrRowControl As DataRow()
        Dim DrRowFechaAviso As DataRow()
        Dim SalirForAvisos As Boolean


        If EnuTipoAplicacion.GRPS = TipoAplicacion Then

            Dim DtSpotTemas As DataTable

            Dim ControlSalidaDtAgrupado As Boolean

            'AG 22/05/2014 =====================
            Dim IndiceTemaNuevo As Integer = 0
            Dim CantFilaTemaNuevo As Integer = _DtTemasReemplazoFinal.Rows.Count
            '===================================

            'AG Creo el DT DEtalle Nuevo =====================================
            DtDetalleNuevo.Columns.Add("ID_SPOT", GetType(Integer))
            DtDetalleNuevo.Columns.Add("F_SPOT", GetType(String))
            DtDetalleNuevo.Columns.Add("TEMA_NUEVO", GetType(String))
            '=================================================================

            DtSpotDetalleLimpio = ExtraerRegistrosSuciosDtDetalle()


            DtSpotTemas = ObtenerDtAvisosControl(DtSpotDetalleLimpio)

            'AG CargarDt Con Temas a Eliminar en la Hoja de Planificacion =============
            _DtTemasViejosEliminar = ObtenerTemasViejosEliminar(DtSpotDetalleLimpio)
            '==========================================================================

            DtIDSpot = DtSpotDetalleLimpio.DefaultView.ToTable(True, "ID_SPOT")
            DtAgrupado = AgruparXIdSpot_FechaSpot(DtSpotDetalleLimpio)


            'AG 30/05/2014 CODIGO ANTERIOR =======================================================================================================================================
            'For Each RowIdSpot As DataRow In DtIDSpot.Rows
            '    DiaAviso = CDate("01/01/1000")
            '    ControlCantidadAvisosTotalPermitido = 0
            '    For Each RowTemaReemplazo As DataRow In DtSpotTemas.Select("ID_SPOT= " & RowIdSpot("ID_SPOT"))
            '        TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
            '        CantidadAvisosPermitidoXTemaNuevo = CInt(RowTemaReemplazo("CANTIDAD"))
            '        DiaAviso = CDate("01/01/1000")
            '        ControlAvisosPermitidos = 0
            '        IndiceTemaNuevo = 0
            '        '======================================================================================================================================================
            '        If ControlCantidadAvisosTotalPermitido > DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
            '            Exit For
            '        End If
            '        CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) * CantidadAvisosPermitidoXTemaNuevo
            '        '=======================================================================================================================================================
            '        If ControlCantidadAvisosTotalPermitido <= _CantidadAvisoPermitidos Then
            '            For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

            '                If DtSpotTemas.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CANTIDAD") <= DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "TEMA_NUEVO= '" & TemaNuevoReemplazo.ToString() & "'AND ID_SPOT= " & RowIdSpot("ID_SPOT")) Then
            '                    Exit For
            '                End If

            '                If DiaAviso = CDate("01/01/1000") Then
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                ElseIf DiaAviso > _ReemplazoFHasta Then
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                ElseIf DiaAviso <= _ReemplazoFHasta Then
            '                    DiaAviso = DiaAviso.AddDays(1).ToShortDateString
            '                End If

            '                'Salida del For por ID SPOT ======================================================================================
            '                For Each RowAgrupado As DataRow In DtAgrupado.Select("ID_SPOT = " & RowIdSpot("ID_SPOT"))
            '                    If RowAgrupado("ControlagregarAvisos") >= RowAgrupado("CantidadAvisos") Or RowAgrupado("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO Then
            '                        ControlSalidaDtAgrupado = True
            '                    Else
            '                        ControlSalidaDtAgrupado = False
            '                    End If
            '                Next
            '                '================================================================================================================

            '                If DiaAviso <= _ReemplazoFHasta Then
            '                    If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
            '                        DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
            '                        If DrRowFechaAviso.Length > 0 Then
            '                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT")).Length > 0 Then
            '                                If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
            '                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT").ToString.Trim & "") Then
            '                                        DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                        DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
            '                                        DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                        DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                        DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                        DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                        DtAgrupado.AcceptChanges()
            '                                        ControlAvisosPermitidos += 1
            '                                        ControlCantidadAvisosTotalPermitido += 1
            '                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
            '                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
            '                                                DtDetalleNuevo.Rows.Remove(DrFilaNueva)
            '                                                DtAgrupado.AcceptChanges()
            '                                                ControlAvisosPermitidos -= 1
            '                                                ControlCantidadAvisosTotalPermitido -= 1
            '                                                IndiceTemaNuevo -= 1
            '                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
            '                                            End If
            '                                        End If
            '                                    End If
            '                                Else
            '                                    DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                    DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
            '                                    DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                    DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                    DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                    DtAgrupado.AcceptChanges()
            '                                    ControlAvisosPermitidos += 1
            '                                    ControlCantidadAvisosTotalPermitido += 1
            '                                End If
            '                            End If
            '                        End If
            '                    Else
            '                        Exit For 'Se pude quita el for
            '                    End If
            '                Else
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                    If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
            '                        DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
            '                        If DrRowFechaAviso.Length > 0 Then
            '                            If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
            '                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & "") Then
            '                                    DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                    DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
            '                                    DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                    DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                    DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                    DtAgrupado.AcceptChanges()
            '                                    ControlAvisosPermitidos += 1
            '                                    ControlCantidadAvisosTotalPermitido += 1
            '                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
            '                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
            '                                            DtDetalleNuevo.Rows.Remove(DrFilaNueva)
            '                                            DtAgrupado.AcceptChanges()
            '                                            ControlAvisosPermitidos -= 1
            '                                            ControlCantidadAvisosTotalPermitido -= 1
            '                                            IndiceTemaNuevo -= 1
            '                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
            '                                        End If
            '                                    End If
            '                                End If
            '                            End If
            '                        End If
            '                    Else
            '                        Exit For 'Se pude quita el for
            '                    End If
            '                End If
            '            Next
            '        Else
            '            DtDetalleNuevo.AcceptChanges()
            '        End If
            '    Next
            'Next
            'FIN CODIGO ANTERIOR =======================================================================================================================================================================================


            For Each RowIdSpot As DataRow In DtIDSpot.Rows
                DiaAviso = CDate("01/01/1000")
                ControlCantidadAvisosTotalPermitido = 0

                For Each RowTemaReemplazo As DataRow In DtSpotTemas.Select("ID_SPOT= " & RowIdSpot("ID_SPOT"))

                    TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
                    CantidadAvisosPermitidoXTemaNuevo = CInt(RowTemaReemplazo("CANTIDAD"))
                    DiaAviso = CDate("01/01/1000")
                    ControlAvisosPermitidos = 0

                    IndiceTemaNuevo = 0
                    '======================================================================================================================================================
                    If ControlCantidadAvisosTotalPermitido > DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                        Exit For
                    End If

                    CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) * DtSpotTemas.Compute("Sum(Cantidad)", "") * 300
                    '=======================================================================================================================================================
                    If ControlCantidadAvisosTotalPermitido <= _CantidadAvisoPermitidos Then
                        For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

                            'nuevo control 29/05/2014
                            If DtSpotTemas.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CANTIDAD") = DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "TEMA_NUEVO= '" & TemaNuevoReemplazo.ToString() & "'AND ID_SPOT= " & RowIdSpot("ID_SPOT")) Then
                                Exit For
                            End If


                            If DiaAviso = CDate("01/01/1000") Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso > _ReemplazoFHasta Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso <= _ReemplazoFHasta Then
                                DiaAviso = DiaAviso.AddDays(1).ToShortDateString
                            End If


                            'Salida del For por ID SPOT ======================================================================================
                            For Each RowAgrupado As DataRow In DtAgrupado.Select("ID_SPOT = " & RowIdSpot("ID_SPOT"))
                                If RowAgrupado("ControlagregarAvisos") >= RowAgrupado("CantidadAvisos") Or RowAgrupado("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO Then
                                    ControlSalidaDtAgrupado = True
                                Else
                                    ControlSalidaDtAgrupado = False
                                End If
                            Next
                            '================================================================================================================

                            If DiaAviso <= _ReemplazoFHasta Then
                                If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
                                    DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
                                    If DrRowFechaAviso.Length > 0 Then
                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT")).Length > 0 Then
                                            If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT").ToString.Trim & "") Then
                                                    DrFilaNueva = DtDetalleNuevo.NewRow()
                                                    DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                    DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                                    DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                    DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                    DtAgrupado.AcceptChanges()
                                                    ControlAvisosPermitidos += 1
                                                    ControlCantidadAvisosTotalPermitido += 1
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                            DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                            DtAgrupado.AcceptChanges()
                                                            ControlAvisosPermitidos -= 1
                                                            ControlCantidadAvisosTotalPermitido -= 1
                                                            IndiceTemaNuevo -= 1
                                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                        End If
                                                    End If
                                                End If
                                            Else
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlAvisosPermitidos += 1
                                                ControlCantidadAvisosTotalPermitido += 1
                                            End If
                                        End If
                                    End If
                                Else
                                    Exit For 'Se pude quita el for
                                End If
                            Else
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                                If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
                                    DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
                                    If DrRowFechaAviso.Length > 0 Then
                                        If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & "") Then
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlAvisosPermitidos += 1
                                                ControlCantidadAvisosTotalPermitido += 1
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                        DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                        DtAgrupado.AcceptChanges()
                                                        ControlAvisosPermitidos -= 1
                                                        ControlCantidadAvisosTotalPermitido -= 1
                                                        IndiceTemaNuevo -= 1
                                                        DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    Exit For 'Se pude quita el for
                                End If
                            End If
                        Next
                    Else
                        DtDetalleNuevo.AcceptChanges()
                    End If
                Next
            Next
            'AG FIN CODIGO NUEVO =================================================================================================================================================================



        ElseIf EnuTipoAplicacion.INVERSION = TipoAplicacion Then

            Dim IdSpot As Integer
            Dim NetoSpot As Double
            Dim NetoCompraNueva As Double
            Dim AcumuladorCompraNuevaXTemaNuevo As Double
            Dim ImporteMaximoPermitidoXTemaNuevo As Double
            Dim DuracionTemaNuevo As Integer
            Dim CalculoNuevoTema As Double
            Dim ControlSalidaDtAgrupado As Boolean
            Dim DtControlInversion As DataTable

            'AG Creo el DT DEtalle Nuevo =====================================
            DtDetalleNuevo.Columns.Add("ID_SPOT", GetType(Integer))
            DtDetalleNuevo.Columns.Add("F_SPOT", GetType(String))
            DtDetalleNuevo.Columns.Add("TEMA_NUEVO", GetType(String))
            '=================================================================

            DtSpotDetalleLimpio = ExtraerRegistrosSuciosDtDetalle()

            'AG CargarDt Con Temas a Eliminar en la Hoja de Planificacion =============
            _DtTemasViejosEliminar = ObtenerTemasViejosEliminar(DtSpotDetalleLimpio)
            '==========================================================================

            DtIDSpot = ObtenerDtSpot(DtSpotDetalleLimpio) 'DtSpotDetalleLimpio.DefaultView.ToTable(True, "ID_SPOT", "NETO")

            DtControlInversion = ObtenerDtImportesControl(DtSpotDetalleLimpio, Me.DtSpot)

            DtAgrupado = AgruparXIdSpot_FechaSpot(DtSpotDetalleLimpio)

            'AG 30/05/2014 CODIGO ANTERIOR =======================================================================================================================================
            'For Each RowSpot As DataRow In DtIDSpot.Rows

            '    ControlSalidaDtAgrupado = False
            '    DiaAviso = CDate("01/01/1000")
            '    ControlCantidadAvisosTotalPermitido = 0
            '    IdSpot = RowSpot("ID_SPOT")
            '    NetoSpot = RowSpot("NETO")
            '    AcumuladorCompraNuevaXTemaNuevo = 0
            '    ControlCantidadAvisosTotalPermitido = 0

            '    For Each RowTemaReemplazo As DataRow In DtControlInversion.Select("ID_SPOT= " & RowSpot("ID_SPOT"))

            '        TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
            '        ImporteMaximoPermitidoXTemaNuevo = CDbl(RowTemaReemplazo("IMPORTE"))
            '        DuracionTemaNuevo = RowTemaReemplazo("DURACION")
            '        DiaAviso = CDate("01/01/1000")
            '        ControlAvisosPermitidos = 0 'puede que no se use
            '        AcumuladorCompraNuevaXTemaNuevo = 0


            '        If ControlCantidadAvisosTotalPermitido = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
            '            Exit For
            '        End If
            '        CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) * DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT"))

            '        If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then

            '            For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

            '                If DiaAviso = CDate("01/01/1000") Then
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                ElseIf DiaAviso > _ReemplazoFHasta Then
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                ElseIf DiaAviso <= _ReemplazoFHasta Then
            '                    DiaAviso = DiaAviso.AddDays(1).ToShortDateString
            '                End If
            '                If DiaAviso <= _ReemplazoFHasta Then
            '                    If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
            '                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
            '                            If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
            '                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
            '                                    CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
            '                                    DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                    DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
            '                                    DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                    DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                    DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                    DtAgrupado.AcceptChanges()
            '                                    ControlCantidadAvisosTotalPermitido += 1
            '                                    AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
            '                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
            '                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
            '                                            DtDetalleNuevo.Rows.Remove(DrFilaNueva)
            '                                            DtAgrupado.AcceptChanges()
            '                                            ControlAvisosPermitidos -= 1
            '                                            ControlCantidadAvisosTotalPermitido -= 1
            '                                            AcumuladorCompraNuevaXTemaNuevo = AcumuladorCompraNuevaXTemaNuevo - Math.Round(CalculoNuevoTema, 2)
            '                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
            '                                        End If
            '                                    End If
            '                                End If
            '                            Else
            '                                CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
            '                                DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
            '                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                DtAgrupado.AcceptChanges()
            '                                ControlCantidadAvisosTotalPermitido += 1
            '                                AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
            '                            End If
            '                        End If
            '                    Else
            '                        _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
            '                        _DtTemasReemplazoFinal.AcceptChanges()
            '                        Exit For
            '                    End If
            '                Else
            '                    DiaAviso = _ReemplazoFDesde.ToShortDateString
            '                    If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
            '                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
            '                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
            '                                CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
            '                                DrFilaNueva = DtDetalleNuevo.NewRow()
            '                                DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
            '                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
            '                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
            '                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
            '                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
            '                                DtAgrupado.AcceptChanges()
            '                                ControlCantidadAvisosTotalPermitido += 1
            '                                AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)

            '                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
            '                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
            '                                        DtDetalleNuevo.Rows.Remove(DrFilaNueva)
            '                                        DtAgrupado.AcceptChanges()
            '                                        ControlAvisosPermitidos -= 1
            '                                        ControlCantidadAvisosTotalPermitido -= 1
            '                                        AcumuladorCompraNuevaXTemaNuevo = AcumuladorCompraNuevaXTemaNuevo - Math.Round(CalculoNuevoTema, 2)
            '                                        DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
            '                                    End If
            '                                End If
            '                            End If

            '                        End If
            '                    Else
            '                        _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
            '                        _DtTemasReemplazoFinal.AcceptChanges()
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '        Else
            '            Exit For 'Supero la Cantidad de Importe para ese tema nuevo
            '        End If
            '    Next
            'Next
            'AG FIN CODIGO ANTERIOR ==============================================================================================================================================================


            'AG 30/05/2014 CODIGO NUEVO =========================================================================================================================================
            For Each RowSpot As DataRow In DtIDSpot.Rows

                ControlSalidaDtAgrupado = False
                DiaAviso = CDate("01/01/1000")
                ControlCantidadAvisosTotalPermitido = 0
                IdSpot = RowSpot("ID_SPOT")
                NetoSpot = RowSpot("NETO")
                AcumuladorCompraNuevaXTemaNuevo = 0
                ControlCantidadAvisosTotalPermitido = 0

                For Each RowTemaReemplazo As DataRow In DtControlInversion.Select("ID_SPOT= " & RowSpot("ID_SPOT"))
                    TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
                    ImporteMaximoPermitidoXTemaNuevo = CDbl(RowTemaReemplazo("IMPORTE"))
                    DuracionTemaNuevo = RowTemaReemplazo("DURACION")
                    DiaAviso = CDate("01/01/1000")
                    ControlAvisosPermitidos = 0 'puede que no se use
                    AcumuladorCompraNuevaXTemaNuevo = 0


                    If ControlCantidadAvisosTotalPermitido = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
                        Exit For
                    End If

                    CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) * DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) * 300

                    If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then

                        For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

                            If DiaAviso = CDate("01/01/1000") Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso > _ReemplazoFHasta Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso <= _ReemplazoFHasta Then
                                DiaAviso = DiaAviso.AddDays(1).ToShortDateString
                            End If
                            If DiaAviso <= _ReemplazoFHasta Then
                                If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
                                        If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
                                                CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlCantidadAvisosTotalPermitido += 1
                                                AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                    End If
                                                End If
                                            End If
                                        Else
                                            CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                            DrFilaNueva = DtDetalleNuevo.NewRow()
                                            DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                            DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                            DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                            DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                            DtAgrupado.AcceptChanges()
                                            ControlCantidadAvisosTotalPermitido += 1
                                            AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
                                        End If
                                    End If
                                Else
                                    _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
                                    _DtTemasReemplazoFinal.AcceptChanges()
                                    Exit For
                                End If
                            Else
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                                If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
                                            CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                            DrFilaNueva = DtDetalleNuevo.NewRow()
                                            DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                            DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                            DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                            DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                            DtAgrupado.AcceptChanges()
                                            ControlCantidadAvisosTotalPermitido += 1
                                            AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)

                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                'IF DE MAS QUITAR 
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                End If
                                            End If
                                        End If

                                    End If
                                Else
                                    _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
                                    _DtTemasReemplazoFinal.AcceptChanges()
                                    Exit For
                                End If
                            End If
                        Next
                    Else
                        Exit For 'Supero la Cantidad de Importe para ese tema nuevo
                    End If
                Next
            Next
            'AG FIN CODIGO NUEVO ========================================================================================================================================================

        End If

        DtDetalleNuevo.AcceptChanges()

        Return DtDetalleNuevo

    End Function

    Private Function AgruparXIdSpot_FechaSpot(ByVal Dt As DataTable) As DataTable

        Dim DtSpotAgrupado As DataTable = Dt.DefaultView.ToTable(True, "ID_SPOT", "F_SPOT")
        Dim Drfila As DataRow


        If DtSpotAgrupado.Rows.Count > 0 Then
            DtSpotAgrupado.Columns.Add("CantidadAvisos", GetType(Integer))
            DtSpotAgrupado.Columns.Add("ControlagregarAvisos", GetType(Integer))
            DtSpotAgrupado.Columns.Add("FinAgregarAvisos", GetType(Integer))
        End If


        For Each Drfila In DtSpotAgrupado.Rows
            Drfila("CantidadAvisos") = Dt.Compute("Count(F_SPOT)", "F_SPOT = '" & Drfila("F_SPOT") & "' AND ID_SPOT=" & Drfila("ID_SPOT").ToString.Trim & "")
            Drfila("ControlagregarAvisos") = 0
            Drfila("F_SPOT") = CDate(Drfila("F_SPOT")).ToShortDateString
            Drfila("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO
        Next

        DtSpotAgrupado.AcceptChanges()

        Return DtSpotAgrupado

    End Function

    Private Function ObtenerDtSpot(ByVal Dt As DataTable) As DataTable

        Dim DtIDSpot As DataTable = Dt.DefaultView.ToTable(True, "ID_SPOT")

        Dim DtTemporal As New DataTable
        Dim RowSpot As DataRow
        Dim FilaNueva As DataRow
        Dim Resultado As DataRow()

        With DtTemporal.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("NETO", GetType(Double))
        End With


        For Each RowSpot In DtIDSpot.Rows
            Resultado = _DtSpot.Select("ID_SPOT=" & RowSpot("ID_SPOT"))
            If Resultado.Length > 0 Then
                FilaNueva = DtTemporal.NewRow
                FilaNueva("ID_SPOT") = Resultado(0)("ID_SPOT")
                FilaNueva("NETO") = Resultado(0)("NETO")
                DtTemporal.Rows.Add(FilaNueva)
                DtTemporal.AcceptChanges()
            End If
        Next

        Return DtTemporal

    End Function

    Private Function ExtraerRegistrosSuciosDtDetalle() As DataTable

        Dim DtNuevoTema As New DataTable
        Dim DtNuevoFinal As New DataTable
        Dim DtNuevoFinalOrdenado As New DataTable

        Dim DrTemporal As DataRow()
        Dim FilaNueva As DataRow
        Dim FilaOrden As DataRow()
        Dim i As Integer


        DtNuevoTema = DtSpotDetalle.Clone
        DtNuevoFinal = DtSpotDetalle.Clone

        If DtSpotDetalle.Rows.Count > 0 Then

            'AG Limpio por TEMAS PERMITIDOS ============================
            For Each RowTemaSeleccionado As DataRow In _DtTemasSeleccionadoFinal.Rows
                DrTemporal = DtSpotDetalle.Select("ID_TEMA='" & RowTemaSeleccionado("TEMA").ToString() & "'")
                If DrTemporal.Length > 0 Then
                    For i = 0 To DrTemporal.Length - 1
                        FilaNueva = DtNuevoTema.NewRow
                        DtNuevoTema.ImportRow(DrTemporal(i))
                    Next
                End If
            Next
            DtNuevoTema.AcceptChanges()


            'AG Limpio por FECHAS PERMITIDAS ============================
            For Each RowFecha As DataRow In DtNuevoTema.Rows
                If CDate(RowFecha("F_SPOT")) >= Me.dtpFechaInicioD.Value And CDate(RowFecha("F_SPOT")) <= Me.dtpFechaFinD.Value Then
                    FilaNueva = DtNuevoFinal.NewRow
                    DtNuevoFinal.ImportRow(RowFecha)
                End If
            Next

            DtNuevoFinal.AcceptChanges()


            'AG Ordeno por ID_SPOT ============================
            FilaOrden = DtNuevoFinal.Select("", "ID_SPOT DESC")
            If FilaOrden.Length > 0 Then
                DtNuevoFinalOrdenado = DtNuevoFinal.Clone
                For o As Integer = 0 To FilaOrden.Length - 1
                    FilaNueva = DtNuevoFinalOrdenado.NewRow
                    DtNuevoFinalOrdenado.ImportRow(FilaOrden(o))
                Next
                DtNuevoFinalOrdenado.AcceptChanges()
            End If

            Return DtNuevoFinalOrdenado

        End If

        Return DtNuevoFinalOrdenado

    End Function

    Private Function ObtenerDtAvisosControl(ByVal Dt As DataTable) As DataTable

        Dim DtIDSpot As DataTable = Dt.DefaultView.ToTable(True, "ID_SPOT")
        Dim DtTema As DataTable = Dt.DefaultView.ToTable(True, "ID_TEMA")
        Dim CantidadAvisosXSpot As Integer
        Dim DtNuevoFinal As New DataTable
        Dim DtTemporal As New DataTable
        Dim DtTemporal2 As New DataTable
        Dim FilaNueva As DataRow
        Dim FilaOrden As DataRow()


        With DtTemporal.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("CANTIDAD_AVISOS", GetType(Integer))
        End With


        With DtTemporal2.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("TEMA_NUEVO", GetType(String))
            .Add("CANTIDAD", GetType(Integer))
        End With


        For Each RowIdSpot As DataRow In DtIDSpot.Rows
            CantidadAvisosXSpot = Dt.Compute("Count(ID_SPOT)", "ID_SPOT =" & RowIdSpot("ID_SPOT") & "")
            FilaNueva = DtTemporal.NewRow
            FilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
            FilaNueva("CANTIDAD_AVISOS") = CantidadAvisosXSpot
            DtTemporal.Rows.Add(FilaNueva)
        Next


        For Each Row As DataRow In DtTemporal.Rows
            For Each RowPorcentaje As DataRow In _DtTemasReemplazoFinal.Rows
                FilaNueva = DtTemporal2.NewRow
                FilaNueva("ID_SPOT") = Row("ID_SPOT")
                FilaNueva("TEMA_NUEVO") = RowPorcentaje("TEMA_NUEVO")
                FilaNueva("CANTIDAD") = (Row("CANTIDAD_AVISOS") * RowPorcentaje("PORCENTAJE")) / 100
                DtTemporal2.Rows.Add(FilaNueva)
            Next
        Next

        Return DtTemporal2


    End Function

    Private Function ObtenerDtImportesControl(ByVal DtDetalle As DataTable, ByVal DtSpot As DataTable) As DataTable

        Dim DtIDSpot As DataTable = DtSpot
        Dim DtTema As DataTable = DtDetalle.DefaultView.ToTable(True, "ID_TEMA")
        Dim CantidadAvisosXTema As Integer
        Dim DtNuevoFinal As New DataTable
        Dim DtTemporal As New DataTable
        Dim DtTemporal2 As New DataTable
        Dim DtTemporal3 As New DataTable
        Dim FilaNueva As DataRow
        Dim FilaOrden As DataRow()


        With DtTemporal.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("TEMA_ORIGEN", GetType(String))
            .Add("DURACION", GetType(Integer))
            .Add("CANTIDAD_TEMAS", GetType(Integer))
            .Add("TOTAL_X_TEMA", GetType(Double))
        End With


        With DtTemporal3.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("IMPORTE_SPOT", GetType(Double))
        End With

        With DtTemporal2.Columns
            .Add("ID_SPOT", GetType(Integer))
            .Add("TEMA_NUEVO", GetType(String))
            .Add("DURACION", GetType(Integer))
            .Add("IMPORTE", GetType(Double))

        End With



        For Each RowIdSpot As DataRow In DtIDSpot.Rows
            For Each RowTema As DataRow In DtTema.Rows
                CantidadAvisosXTema = DtDetalle.Compute("Count(ID_TEMA)", "ID_TEMA= '" & RowTema("ID_TEMA") & "'AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
                FilaNueva = DtTemporal.NewRow
                FilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                FilaNueva("CANTIDAD_TEMAS") = CantidadAvisosXTema
                FilaNueva("TEMA_ORIGEN") = RowTema("ID_TEMA")
                FilaNueva("DURACION") = DtDetalle.Select("ID_TEMA= '" & RowTema("ID_TEMA") & "'AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("DURACION")
                FilaNueva("TOTAL_X_TEMA") = Math.Round(FilaNueva("DURACION") * FilaNueva("CANTIDAD_TEMAS") * RowIdSpot("NETO"), 2)
                DtTemporal.Rows.Add(FilaNueva)
            Next
        Next


        For Each RowIdSpot As DataRow In DtIDSpot.Rows
            FilaNueva = DtTemporal3.NewRow
            FilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
            FilaNueva("IMPORTE_SPOT") = DtTemporal.Compute("Sum(TOTAL_X_TEMA)", "ID_SPOT= " & RowIdSpot("ID_SPOT"))
            DtTemporal3.Rows.Add(FilaNueva)
        Next


        For Each Row As DataRow In DtTemporal3.Rows
            For Each RowPorcentaje As DataRow In _DtTemasReemplazoFinal.Rows
                FilaNueva = DtTemporal2.NewRow
                FilaNueva("ID_SPOT") = Row("ID_SPOT")
                FilaNueva("TEMA_NUEVO") = RowPorcentaje("TEMA_NUEVO")
                FilaNueva("DURACION") = RowPorcentaje("DURACION")
                FilaNueva("IMPORTE") = (Row("IMPORTE_SPOT") * RowPorcentaje("PORCENTAJE")) / 100
                DtTemporal2.Rows.Add(FilaNueva)
            Next
        Next

        Return DtTemporal2


    End Function

    Private Function ObtenerTemasViejosEliminar(ByVal DtTemporal As DataTable) As DataTable

        Dim DtTemasEliminar As New DataTable
        Dim FilaNueva As DataRow

        If DtTemporal.Rows.Count > 0 Then

            With DtTemasEliminar.Columns
                .Add("ID_SPOT", GetType(Integer))
                .Add("ID_SPOT_DETALLE", GetType(Integer))
                .Add("F_SPOT", GetType(String))
                .Add("TEMA_ANTERIOR", GetType(String))
                .Add("SPOT_ESTADO", GetType(String))
            End With

            For Each RowTemaViejo As DataRow In DtTemporal.Rows
                FilaNueva = DtTemasEliminar.NewRow
                FilaNueva("ID_SPOT") = RowTemaViejo("ID_SPOT")
                FilaNueva("ID_SPOT_DETALLE") = RowTemaViejo("ID_SPOT_DETALLE")
                FilaNueva("F_SPOT") = RowTemaViejo("F_SPOT")
                FilaNueva("TEMA_ANTERIOR") = RowTemaViejo("ID_TEMA")
                FilaNueva("SPOT_ESTADO") = RowTemaViejo("ID_SPOT_ESTADO")
                DtTemasEliminar.Rows.Add(FilaNueva)
            Next
            DtTemasEliminar.AcceptChanges()
        End If

        Return DtTemasEliminar

    End Function

    Private Function AutoSumaTotalPorcentajeTemasNuevo() As Double

        Dim TotalPorcentajeTema As Double


        If Not Me.uigTemas.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.uigTemasNuevos.Rows
                If Not RowGrilla.Cells("PORCENTAJE").Value Is System.DBNull.Value Then
                    If RowGrilla.Cells("TEMA").Value <> "TOTAL PORCENTAJE" Then
                        If RowGrilla.Cells("PORCENTAJE").Value > 0 Then
                            TotalPorcentajeTema += RowGrilla.Cells("PORCENTAJE").Value
                        End If
                    End If
                End If
            Next
        End If

        Return TotalPorcentajeTema

    End Function

    Private Sub AnexarFilaTotalPorcentajes()

        Dim RowPorcentaje As DataRow

        RowPorcentaje = DtTemasCampania.NewRow()
        RowPorcentaje("TEMA") = "TOTAL PORCENTAJE"
        DtTemasCampania.Rows.Add(RowPorcentaje)
        DtTemasCampania.AcceptChanges()


        For Each Dr As DataRow In DtTemasCampania.Rows
            If Dr("TEMA") = "TOTAL PORCENTAJE" Then
                Dr("Sel") = False
            End If
        Next

    End Sub

    Private Function ValidarTotalPorcentajeFinal() As Boolean

        Dim ControlTotalporcentajeTemas As Double
        Dim Resultado As Boolean = False

        
        If Not Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("PORCENTAJE").Value Is System.DBNull.Value Then
            ControlTotalporcentajeTemas = Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("PORCENTAJE").Value
        Else
            ControlTotalporcentajeTemas = -1
        End If


        If ControlTotalporcentajeTemas < 0 Or ControlTotalporcentajeTemas > 100 Or ControlTotalporcentajeTemas < 100 Then
            Resultado = True
            Return Resultado
            Exit Function
        End If


    End Function

    Private Sub CambiarColorFilaTotal()

        Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("TEMA").Appearance.BackColor = Color.Beige
        Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("PORCENTAJE").Appearance.BackColor = Color.Beige
        Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("DURACION").Appearance.BackColor = Color.Beige
        Me.uigTemasNuevos.Rows(Me.uigTemasNuevos.Rows.Count - 1).Cells("Sel").Appearance.BackColor = Color.Beige

    End Sub

    Private Function OrdenarDtNuevoSpotByFechas(ByVal DtAvisos As DataTable) As DataTable
        'No se Utiliza 
        Dim RowOrdenadoFechas As DataRow()
        Dim RowOrdenadoIdSpot As DataRow()
        Dim DtOrdenadoFechas As DataTable = DtAvisos.Clone
        Dim DtOrdenadoIdSpot As DataTable


        RowOrdenadoFechas = DtAvisos.Select("", "F_SPOT ASC")

        If RowOrdenadoFechas.Length > 0 Then
            If RowOrdenadoFechas.Length > 0 Then
                For i As Integer = 0 To RowOrdenadoFechas.Length - 1
                    DtOrdenadoFechas.ImportRow(RowOrdenadoFechas(i))
                Next
            End If
        End If

        
        Return DtOrdenadoFechas

    End Function

#End Region


#Region "Metodos Sin emplear"

    Private Function CargarDtSpotDetalleAvisosNuevos_NO_ANDA() As DataTable

        Dim DtDetalleNuevo As New DataTable
        Dim DtIDSpot As DataTable = Me.DtSpotDetalle.DefaultView.ToTable(True, "ID_SPOT")
        Dim DtSpotDetalleLimpio As New DataTable
        Dim DrFilaNueva As DataRow
        Dim ControlAvisosPermitidos As Integer
        Dim TemaNuevoReemplazo As String
        Dim CantidadAvisosPermitidoXTemaNuevo As Integer
        Dim ControlCantidadAvisosTotalPermitido As Integer
        Dim IndiceAvisos As Integer
        Dim DiaAviso As Date
        Dim DiaAvisoAnterior As Date
        Dim DiaAvisoProximo As Date
        Dim DtAgrupado As DataTable
        Dim DrRowControl As DataRow()
        Dim DrRowFechaAviso As DataRow()
        Dim SalirForAvisos As Boolean


        If EnuTipoAplicacion.GRPS = TipoAplicacion Then

            Dim ControlSalidaDtAgrupado As Boolean

            'AG 22/05/2014 =====================
            Dim IndiceTemaNuevo As Integer = 0
            Dim CantFilaTemaNuevo As Integer = _DtTemasReemplazoFinal.Rows.Count
            '===================================

            'AG Creo el DT DEtalle Nuevo =====================================
            DtDetalleNuevo.Columns.Add("ID_SPOT", GetType(Integer))
            DtDetalleNuevo.Columns.Add("F_SPOT", GetType(String))
            DtDetalleNuevo.Columns.Add("TEMA_NUEVO", GetType(String))
            '=================================================================

            DtSpotDetalleLimpio = ExtraerRegistrosSuciosDtDetalle()

            'AG CargarDt Con Temas a Eliminar en la Hoja de Planificacion =============
            _DtTemasViejosEliminar = ObtenerTemasViejosEliminar(DtSpotDetalleLimpio)
            '==========================================================================

            DtIDSpot = DtSpotDetalleLimpio.DefaultView.ToTable(True, "ID_SPOT")

            DtAgrupado = AgruparXIdSpot_FechaSpot(DtSpotDetalleLimpio)


            For Each RowIdSpot As DataRow In DtIDSpot.Rows

                DiaAviso = CDate("01/01/1000")
                ControlCantidadAvisosTotalPermitido = 0

                'IndiceTemaNuevo = 0

                For Each RowTemaReemplazo As DataRow In _DtTemasReemplazoFinal.Select("FINAL_LIMITE = " & EnuFinalizar.INICIADO)

                    TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
                    CantidadAvisosPermitidoXTemaNuevo = CInt(RowTemaReemplazo("CANTTEMAS"))
                    DiaAviso = CDate("01/01/1000")
                    ControlAvisosPermitidos = 0

                    IndiceTemaNuevo = 0
                    '======================================================================================================================================================
                    If ControlCantidadAvisosTotalPermitido > DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                        Exit For
                    End If
                    CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) * CantidadAvisosPermitidoXTemaNuevo
                    '=======================================================================================================================================================
                    If ControlCantidadAvisosTotalPermitido <= _CantidadAvisoPermitidos Then
                        For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

                            If _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("CANTTEMAS") <= DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "TEMA_NUEVO= '" & TemaNuevoReemplazo.ToString() & "'") Then
                                _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
                                _DtTemasReemplazoFinal.AcceptChanges()
                                Exit For
                            End If

                            If DiaAviso = CDate("01/01/1000") Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso > _ReemplazoFHasta Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso <= _ReemplazoFHasta Then
                                DiaAviso = DiaAviso.AddDays(1).ToShortDateString
                            End If


                            'Salida del For por ID SPOT ======================================================================================
                            For Each RowAgrupado As DataRow In DtAgrupado.Select("ID_SPOT = " & RowIdSpot("ID_SPOT"))
                                If RowAgrupado("ControlagregarAvisos") >= RowAgrupado("CantidadAvisos") Or RowAgrupado("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO Then
                                    ControlSalidaDtAgrupado = True
                                Else
                                    ControlSalidaDtAgrupado = False
                                End If
                            Next

                            'If ControlSalidaDtAgrupado = True Then
                            '    Exit For
                            'End If
                            '================================================================================================================

                            If DiaAviso <= _ReemplazoFHasta Then
                                If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
                                    DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
                                    If DrRowFechaAviso.Length > 0 Then
                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT")).Length > 0 Then
                                            If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT").ToString.Trim & "") Then
                                                    DrFilaNueva = DtDetalleNuevo.NewRow()
                                                    DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                    DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString

                                                    'AG 22/05/2014 ===============================================
                                                    DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo

                                                    'If IndiceTemaNuevo < CantFilaTemaNuevo Then
                                                    '    If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                    '        DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                    '        IndiceTemaNuevo += 1
                                                    '    End If
                                                    'Else
                                                    '    IndiceTemaNuevo = 0
                                                    '    If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                    '        DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                    '        IndiceTemaNuevo += 1
                                                    '    End If
                                                    'End If
                                                    '===============================================================

                                                    DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                    DtAgrupado.AcceptChanges()
                                                    ControlAvisosPermitidos += 1
                                                    ControlCantidadAvisosTotalPermitido += 1
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                            DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                            DtAgrupado.AcceptChanges()
                                                            ControlAvisosPermitidos -= 1
                                                            ControlCantidadAvisosTotalPermitido -= 1
                                                            IndiceTemaNuevo -= 1
                                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                        End If
                                                    End If
                                                End If
                                            Else
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString

                                                'AG 22/05/2014 ==============================================
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo

                                                'If IndiceTemaNuevo < CantFilaTemaNuevo Then
                                                '    'If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                '    DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                '    IndiceTemaNuevo += 1
                                                '    'End If
                                                'Else
                                                '    IndiceTemaNuevo = 0
                                                '    'If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                '    DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                '    IndiceTemaNuevo += 1
                                                '    'End If
                                                'End If
                                                '===============================================================

                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlAvisosPermitidos += 1
                                                ControlCantidadAvisosTotalPermitido += 1
                                            End If
                                        End If
                                    End If
                                Else
                                    Exit For 'Se pude quita el for
                                End If
                            Else
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                                If ControlAvisosPermitidos <= CantidadAvisosPermitidoXTemaNuevo Then
                                    DrRowFechaAviso = DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))
                                    If DrRowFechaAviso.Length > 0 Then
                                        'If DtDetalleNuevo.Rows.Count > DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then 'AG 22/05/2014 Original
                                        If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowIdSpot("ID_SPOT")) Then
                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & "") Then
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowIdSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString

                                                'AG 22/05/2014 =======================
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                'If IndiceTemaNuevo < CantFilaTemaNuevo Then

                                                '    If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                '        DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                '        IndiceTemaNuevo += 1
                                                '    End If
                                                'Else
                                                '    IndiceTemaNuevo = 0
                                                '    If DtDetalleNuevo.Compute("Count(TEMA_NUEVO)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowIdSpot("ID_SPOT") & " AND TEMA_NUEVO = '" & _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString() & "'") <= CInt(_DtTemasReemplazoFinal(IndiceTemaNuevo)("CANTTEMAS").ToString()) Then
                                                '        DrFilaNueva("TEMA_NUEVO") = _DtTemasReemplazoFinal(IndiceTemaNuevo)("TEMA_NUEVO").ToString()
                                                '        IndiceTemaNuevo += 1
                                                '    End If
                                                'End If
                                                '=====================================

                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlAvisosPermitidos += 1
                                                ControlCantidadAvisosTotalPermitido += 1
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                        DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                        DtAgrupado.AcceptChanges()
                                                        ControlAvisosPermitidos -= 1
                                                        ControlCantidadAvisosTotalPermitido -= 1
                                                        IndiceTemaNuevo -= 1
                                                        DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowIdSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    Exit For 'Se pude quita el for
                                End If
                            End If
                        Next
                    Else
                        DtDetalleNuevo.AcceptChanges()
                    End If
                Next
            Next

        ElseIf EnuTipoAplicacion.INVERSION = TipoAplicacion Then

            Dim IdSpot As Integer
            Dim NetoSpot As Double
            Dim NetoCompraNueva As Double
            Dim AcumuladorCompraNuevaXTemaNuevo As Double
            Dim ImporteMaximoPermitidoXTemaNuevo As Double
            Dim DuracionTemaNuevo As Integer
            Dim CalculoNuevoTema As Double
            Dim ControlSalidaDtAgrupado As Boolean

            'AG Creo el DT DEtalle Nuevo =====================================
            DtDetalleNuevo.Columns.Add("ID_SPOT", GetType(Integer))
            DtDetalleNuevo.Columns.Add("F_SPOT", GetType(String))
            DtDetalleNuevo.Columns.Add("TEMA_NUEVO", GetType(String))
            '=================================================================

            DtSpotDetalleLimpio = ExtraerRegistrosSuciosDtDetalle()

            'AG CargarDt Con Temas a Eliminar en la Hoja de Planificacion =============
            _DtTemasViejosEliminar = ObtenerTemasViejosEliminar(DtSpotDetalleLimpio)
            '==========================================================================

            DtIDSpot = ObtenerDtSpot(DtSpotDetalleLimpio) 'DtSpotDetalleLimpio.DefaultView.ToTable(True, "ID_SPOT", "NETO")

            DtAgrupado = AgruparXIdSpot_FechaSpot(DtSpotDetalleLimpio)


            For Each RowSpot As DataRow In DtIDSpot.Rows

                ControlSalidaDtAgrupado = False
                DiaAviso = CDate("01/01/1000")
                ControlCantidadAvisosTotalPermitido = 0
                IdSpot = RowSpot("ID_SPOT")
                NetoSpot = RowSpot("NETO")
                AcumuladorCompraNuevaXTemaNuevo = 0
                ControlCantidadAvisosTotalPermitido = 0

                For Each RowTemaReemplazo As DataRow In _DtTemasReemplazoFinal.Select("FINAL_LIMITE = " & EnuFinalizar.INICIADO)

                    TemaNuevoReemplazo = RowTemaReemplazo("TEMA_NUEVO")
                    ImporteMaximoPermitidoXTemaNuevo = CDbl(RowTemaReemplazo("IMPORTE"))
                    DuracionTemaNuevo = RowTemaReemplazo("DURACION")
                    DiaAviso = CDate("01/01/1000")
                    ControlAvisosPermitidos = 0 'puede que no se use
                    AcumuladorCompraNuevaXTemaNuevo = 0


                    If ControlCantidadAvisosTotalPermitido = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
                        Exit For
                    End If
                    CantidadAvisosPermitidoXTemaNuevo = DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT")) * DtAgrupado.Compute("Sum(CantidadAvisos)", "ID_SPOT=" & RowSpot("ID_SPOT"))

                    If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then

                        For IndiceAvisos = 0 To CantidadAvisosPermitidoXTemaNuevo - 1

                            If DiaAviso = CDate("01/01/1000") Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso > _ReemplazoFHasta Then
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                            ElseIf DiaAviso <= _ReemplazoFHasta Then
                                DiaAviso = DiaAviso.AddDays(1).ToShortDateString
                            End If


                            'Salida del For por ID SPOT ======================================================================================
                            For Each RowAgrupado As DataRow In DtAgrupado.Select("ID_SPOT = " & RowSpot("ID_SPOT"))
                                If RowAgrupado("ControlagregarAvisos") >= RowAgrupado("CantidadAvisos") Or RowAgrupado("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO Then
                                    ControlSalidaDtAgrupado = True
                                Else
                                    ControlSalidaDtAgrupado = False
                                End If
                            Next

                            'AG 22/05/2014 ================================
                            'If ControlSalidaDtAgrupado = True Then
                            '    Exit For
                            'End If
                            '==============================================
                            '================================================================================================================

                            If DiaAviso <= _ReemplazoFHasta Then
                                If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
                                        If DtDetalleNuevo.Rows.Count >= DtAgrupado.Compute("Count(ID_SPOT)", "ID_SPOT=" & RowSpot("ID_SPOT")) Then
                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
                                                CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                                DrFilaNueva = DtDetalleNuevo.NewRow()
                                                DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                                DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                                DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                                DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                                DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                                DtAgrupado.AcceptChanges()
                                                ControlCantidadAvisosTotalPermitido += 1
                                                AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                        DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                        DtAgrupado.AcceptChanges()
                                                        ControlAvisosPermitidos -= 1
                                                        ControlCantidadAvisosTotalPermitido -= 1
                                                        AcumuladorCompraNuevaXTemaNuevo = AcumuladorCompraNuevaXTemaNuevo - Math.Round(CalculoNuevoTema, 2)
                                                        DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                    End If
                                                End If
                                            End If
                                        Else
                                            CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                            DrFilaNueva = DtDetalleNuevo.NewRow()
                                            DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                            DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                            DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                            DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                            DtAgrupado.AcceptChanges()
                                            ControlCantidadAvisosTotalPermitido += 1
                                            AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)
                                        End If
                                    End If
                                Else
                                    _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
                                    _DtTemasReemplazoFinal.AcceptChanges()
                                    Exit For
                                End If
                            Else
                                DiaAviso = _ReemplazoFDesde.ToShortDateString
                                If AcumuladorCompraNuevaXTemaNuevo <= ImporteMaximoPermitidoXTemaNuevo Then
                                    If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT")).Length > 0 Then
                                        If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") <= DtDetalleNuevo.Compute("Count(F_SPOT)", "F_SPOT = '" & DiaAviso & "' AND ID_SPOT=" & RowSpot("ID_SPOT").ToString.Trim & "") Then
                                            CalculoNuevoTema = NetoSpot * DuracionTemaNuevo
                                            DrFilaNueva = DtDetalleNuevo.NewRow()
                                            DrFilaNueva("ID_SPOT") = RowSpot("ID_SPOT")
                                            DrFilaNueva("F_SPOT") = DiaAviso.ToShortDateString
                                            DrFilaNueva("TEMA_NUEVO") = TemaNuevoReemplazo
                                            DtDetalleNuevo.Rows.Add(DrFilaNueva)
                                            DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") += 1
                                            DtAgrupado.AcceptChanges()
                                            ControlCantidadAvisosTotalPermitido += 1
                                            AcumuladorCompraNuevaXTemaNuevo += Math.Round(CalculoNuevoTema, 2)

                                            If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.PERMITIDO Then
                                                If DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("ControlagregarAvisos") > DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("CantidadAvisos") Then
                                                    DtDetalleNuevo.Rows.Remove(DrFilaNueva)
                                                    DtAgrupado.AcceptChanges()
                                                    ControlAvisosPermitidos -= 1
                                                    ControlCantidadAvisosTotalPermitido -= 1
                                                    AcumuladorCompraNuevaXTemaNuevo = AcumuladorCompraNuevaXTemaNuevo - Math.Round(CalculoNuevoTema, 2)
                                                    DtAgrupado.Select("F_SPOT = '" & CDate(DiaAviso).ToShortDateString & "' AND ID_SPOT= " & RowSpot("ID_SPOT"))(0)("FinAgregarAvisos") = EnuControlAgregarAvisos.NO_PERMITIDO
                                                End If
                                            End If
                                        End If

                                    End If
                                Else
                                    _DtTemasReemplazoFinal.Select("TEMA_NUEVO = '" & TemaNuevoReemplazo & "'")(0)("FINAL_LIMITE") = EnuFinalizar.FINALIZADO
                                    _DtTemasReemplazoFinal.AcceptChanges()
                                    Exit For
                                End If
                            End If
                        Next
                    Else
                        Exit For 'Supero la Cantidad de Importe para ese tema nuevo
                    End If
                Next
            Next

        End If



        DtDetalleNuevo.AcceptChanges()

        Return DtDetalleNuevo

    End Function

#End Region

End Class

Public Enum EnuTipoAplicacion
    INVERSION = 1
    GRPS = 2
End Enum

Public Enum EnuControlAgregarAvisos
    PERMITIDO = 1
    NO_PERMITIDO = 2
End Enum

Public Enum EnuFinalizar
    INICIADO = 0
    FINALIZADO = 1
End Enum
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing

Public Class frmDistribuidor

#Region "Variables y Objetos"

    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato

    Dim _IdCampania As Integer
    Dim _FDesde As Date
    Dim _FHasta As Date
    Dim DtSoporteDistribuidor As New DataTable
    Dim DtTemasDistribuidor As New DataTable
    Dim _DtTemasCampania As DataTable
    Dim _DtSoportesHoja As DataTable
    Dim ResultadoValidacion As Boolean = False
    Dim valortipoObjetico, avisos As Double
    Dim TipoError As Integer
    Dim AperturaFormulario As Boolean
    Dim _TipoObjetivo As Integer
    Dim _DistribuidorValorObjetivo As Double
    Dim _DistribuidorValorAvisos As Double
    Dim _DistribuidorTipoFranja As Integer
    Dim _DistribuidorConjunto As New DataTable
    Dim TotalPorcentajeSoportes As Boolean
    Dim TotalPorcentajeTemas As Boolean
    Dim ControlPasePorcentajeSoporte As Boolean = False
    Dim ControlPasePorcentajeTema As Boolean = False
    Dim ControlMensajePorcentajeSoporte As Boolean = False
    Dim ControlMensajePorcentajeTemas As Boolean = False
    Dim ControlPorcentajeSoporteNegativo As Boolean = False
    Dim ControlPorcentajeTemaNegativo As Boolean = False
    Dim ControlDatosVaciosFinal As Boolean = False

#End Region

#Region "Propiedades"

    Public Property _AperturaFormulario() As Boolean
        Get
            Return AperturaFormulario
        End Get
        Set(ByVal value As Boolean)
            AperturaFormulario = value
        End Set
    End Property

    Public Property IdCampania() As Integer
        Get
            Return _IdCampania
        End Get
        Set(ByVal value As Integer)
            _IdCampania = value
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

    Public Property DtTemasCampania() As DataTable
        Get
            Return _DtTemasCampania
        End Get
        Set(ByVal value As DataTable)
            _DtTemasCampania = value
        End Set
    End Property

    Public Property DtSoportesHoja() As DataTable
        Get
            Return _DtSoportesHoja
        End Get
        Set(ByVal value As DataTable)
            _DtSoportesHoja = value
        End Set
    End Property

    Public Property TipoObjetivo() As Integer
        Get
            Return _TipoObjetivo
        End Get
        Set(ByVal value As Integer)
            _TipoObjetivo = value
        End Set
    End Property

    Public Property DistribuidorValorObjetivo() As Double
        Get
            Return _DistribuidorValorObjetivo
        End Get
        Set(ByVal value As Double)
            _DistribuidorValorObjetivo = value
        End Set
    End Property

    Public Property DistribuidorValorAvisos() As Double
        Get
            Return _DistribuidorValorAvisos
        End Get
        Set(ByVal value As Double)
            _DistribuidorValorAvisos = value
        End Set
    End Property

    Public Property DistribuidorTipoFranja() As Integer
        Get
            Return _DistribuidorTipoFranja
        End Get
        Set(ByVal value As Integer)
            _DistribuidorTipoFranja = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmDistribuidor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If frmEjercicio.Instancia._DistribuidorCancelar = False Then
            frmEjercicio.Instancia._DistribuidorCancelar = False
        Else
            frmEjercicio.Instancia._DistribuidorCancelar = True
        End If

    End Sub

    Private Sub frmDistribuidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _DtTemasCampania = frmEjercicio.Instancia._DtTemasCampania
        _DtSoportesHoja = frmEjercicio.Instancia._DtSoporteHoja

        'AnexarFilaTotalPorcentajes()

        uigTemas.DataSource = _DtTemasCampania
        Me.iugSoportes.DataSource = _DtSoportesHoja

        CargarDatosIniciales()
        CargarGrillas()
        HabilitarControles()
        CambiarColorCelda()
        'CambiarColorFilaTotal()
        InhabilitarCeldaTotalPorcentaje()

        Me.txttotaltemas.ReadOnly = True
        txtPorcentajeSoporte.ReadOnly = True

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


        If ValidarTotalPorcentajeFinal() = True Then
            MsgBox("El valor total de los PORCENTAJE, no es aceptable. ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If

        RefrescarDts()
        CargarVariables()
        CrearDtDistribuidorConjunto()


        With frmEjercicio.Instancia
            ._DistribuidorFDesde = dtpFechaInicioD.Value
            ._DistribuidorFHasta = dtpFechaFinD.Value
            ._DtDistribuidorSoporte = Me.DtSoporteDistribuidor
            ._DtDistribuidorTemas = Me.DtTemasDistribuidor
            ._DistribuidorTipoObjetivo = Me.TipoObjetivo
            ._DistribuidorValorObjetivo = Me.DistribuidorValorObjetivo
            ._DistribuidorValorAvisos = Me.DistribuidorValorAvisos
            ._DistribuidorTipoFranja = Me.DistribuidorTipoFranja
            ._DistribuidorConjunto = CargarDtDistribuidorConjunto()
            ._DistribuidorCancelar = False
        End With

        Me.Close()

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click

        frmEjercicio.Instancia._DistribuidorCancelar = True
        Me.Close()
    End Sub

    Private Sub iugSoportes_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugSoportes.AfterCellUpdate

        Select Case e.Cell.Column.Key
            Case "PORCENTAJE"
                Me.ValidarDatos()
                If ResultadoValidacion = True Then
                    Exit Sub
                End If
                ObtenerCalculadoXSoporte()
                Dim ResultadoTotalPorcentaje As Double

                If Not Me.iugSoportes.ActiveRow.Cells("PORCENTAJE").Value Is System.DBNull.Value Then

                    If Me.iugSoportes.ActiveRow.Cells("PORCENTAJE").Value < 0 Then
                        Mensajes.Mensaje("El valor del Porcentaje ingresado debe ser MAYOR a 0.", TipoMensaje.Informacion)
                        Exit Sub
                    End If

                    ResultadoTotalPorcentaje = AutoSumaTotalPorcentajeSoporte()
                    If ControlPasePorcentajeSoporte = False Then
                        If ResultadoTotalPorcentaje >= 0 And ResultadoTotalPorcentaje <= 100 Then
                            'ControlPasePorcentajeSoporte = True

                            'AG 20/05/2014 =====================================
                            txtPorcentajeSoporte.Text = ResultadoTotalPorcentaje
                            txtPorcentajeSoporte.ReadOnly = True
                            'Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("PORCENTAJE").Value = ResultadoTotalPorcentaje
                            '===================================================================================
                        Else
                            If ControlMensajePorcentajeSoporte = False Then
                                ControlMensajePorcentajeSoporte = False
                                Mensajes.Mensaje("El valor del Total Porcentaje, por SOPORTE no es un valor aceptable.", TipoMensaje.Informacion)
                            End If
                        End If
                    Else
                        ControlPasePorcentajeSoporte = False
                        Exit Sub
                    End If
                End If
        End Select
        ControlMensajePorcentajeSoporte = False

    End Sub

    Private Sub iugSoportes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iugSoportes.KeyDown

        Dim EnEdicion As Boolean = Me.iugSoportes.ActiveCell.IsInEditMode

        If Not Me.iugSoportes.ActiveRow Is Nothing AndAlso Me.iugSoportes.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not iugSoportes.ActiveCell Is Nothing Then
                    If Not iugSoportes.ActiveCell.IsInEditMode Then
                        iugSoportes.ActiveCell.Value = ""
                    End If
                End If
            End If
        End If

        Select Case e.KeyValue

            Case Keys.Delete
                iugSoportes.ActiveCell.Value = 0

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then
                    iugSoportes.PerformAction(ExitEditMode, False, False)
                Else
                    iugSoportes.PerformAction(EnterEditMode, False, False)
                End If
                iugSoportes.UpdateData()

        End Select

    End Sub

    Private Sub uigTemas_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles uigTemas.AfterCellUpdate

        Select Case e.Cell.Column.Key
            Case "PORCENTAJE"
                Dim ResultadoTotalTema As Double
                ResultadoTotalTema = AutoSumaTotalPorcentajeTemas()
                If ControlPasePorcentajeTema = False Then
                    If ResultadoTotalTema >= 0 And ResultadoTotalTema <= 100 Then
                        'ControlPasePorcentajeTema = False

                        'AG 20/05/2014 =====================================
                        Me.txttotaltemas.Text = ResultadoTotalTema
                        Me.txttotaltemas.ReadOnly = True
                        'Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("PORCENTAJE").Value = ResultadoTotalTema
                        '===================================================
                    Else
                        If ControlMensajePorcentajeTemas = False Then
                            ControlMensajePorcentajeTemas = False
                            Mensajes.Mensaje("El valor del Total Porcentaje, por TEMA no es un valor aceptable.", TipoMensaje.Informacion)
                        End If
                    End If
                Else
                    ControlPasePorcentajeTema = False
                    Exit Sub
                End If

        End Select
        ControlMensajePorcentajeTemas = False


    End Sub

    Private Sub uigTemas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uigTemas.KeyDown

        Dim EnEdicion As Boolean = Me.uigTemas.ActiveCell.IsInEditMode

        If Not Me.uigTemas.ActiveRow Is Nothing AndAlso Me.uigTemas.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not uigTemas.ActiveCell Is Nothing Then
                    If Not uigTemas.ActiveCell.IsInEditMode Then
                        uigTemas.ActiveCell.Value = ""
                    End If
                End If
            End If
        End If

        Select Case e.KeyValue

            Case Keys.Delete
                uigTemas.ActiveCell.Value = 0

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then
                    uigTemas.PerformAction(ExitEditMode, False, False)
                Else
                    uigTemas.PerformAction(EnterEditMode, False, False)
                End If
                uigTemas.UpdateData()

        End Select

    End Sub

    Private Sub uigTemas_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles uigTemas.CellDataError

        If Me.uigTemas.ActiveCell Is Nothing Then
            Exit Sub
        End If

        With uigTemas.ActiveCell.Column
            Select Case .Key
                Case "PORCENTAJE"
                    If Not IsNumeric(uigTemas.ActiveCell.Text) Then
                        Mensajes.Mensaje("Este campo solo admite numeros con 2 decimales", TipoMensaje.Informacion)
                        e.RestoreOriginalValue = False
                        uigTemas.ActiveCell.Value = 0
                    End If
            End Select
        End With
        e.RaiseErrorEvent = False

    End Sub

    Private Sub iugSoportes_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles iugSoportes.CellDataError

        If Me.iugSoportes.ActiveCell Is Nothing Then
            Exit Sub
        End If

        With iugSoportes.ActiveCell.Column
            Select Case .Key
                Case "PORCENTAJE"
                    If Not .DataType Is GetType(String) Then
                        Mensajes.Mensaje("Este campo solo admite numeros con 2 decimales", TipoMensaje.Informacion)
                        e.RestoreOriginalValue = False
                        iugSoportes.ActiveCell.Value = 0
                    End If
            End Select
        End With
        e.RaiseErrorEvent = False

    End Sub

    Private Sub txtvalortipoObjetico_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvalortipoObjetico.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcularPorcentajeGrillaSoporte()
        End If
    End Sub

    Private Sub txtvalortipoObjetico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalortipoObjetico.LostFocus
        If Me.txtvalortipoObjetico.Text <> "" Then
            CalcularPorcentajeGrillaSoporte()
        End If
    End Sub


    Private Sub txtvalortipoObjetico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalortipoObjetico.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub txtAvisos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAvisos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtvalortipoObjetico.Focus()
        End If
    End Sub

    Private Sub txtAvisos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAvisos.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CrearDtDistribuidorConjunto()

        _DistribuidorConjunto.Columns.Add("ID_SOPORTE", GetType(Integer))
        _DistribuidorConjunto.Columns.Add("ID_TEMA", GetType(String))
        _DistribuidorConjunto.Columns.Add("DURACION", GetType(String))
        _DistribuidorConjunto.Columns.Add("IMPORTE", GetType(Single))
        _DistribuidorConjunto.Columns.Add("IMPORTE_CONTROL", GetType(Single))
        _DistribuidorConjunto.Columns.Add("GRPS", GetType(Single))
        _DistribuidorConjunto.Columns.Add("GRPS_CONTROL", GetType(Single))

    End Sub

    Private Sub CargarDatosIniciales()

        Me.dtpFechaInicioD.Value = Me._FDesde
        Me.dtpFechaFinD.Value = Me._FHasta
        Me.rdinversion.Checked = True
        Me.rdgrps.Checked = False
        Me.rdfranjaratalto.Checked = True
        Me.rdcprbajo.Checked = False

    End Sub

    Private Sub CargarGrillas()

        FormatoGrillas()

    End Sub

    Private Sub FormatoGrillas()

        'Grilla SOPORTES
        Listas.CambiarTituloColumna(Me.iugSoportes, "DESCRIPCION", "Soporte")
        Listas.CambiarTituloColumna(Me.iugSoportes, "PORCENTAJE", "Porcentaje")
        Listas.CambiarTituloColumna(Me.iugSoportes, "VALOR", "Valor")
        Listas.OcultarColumnas(Me.iugSoportes, "ID_SOPORTE")
        GrillaFormato.CambiarFormatoColumna(Me.iugSoportes, "VALOR", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugSoportes, "PORCENTAJE", Formato.Decimales)
        GrillaFormato.HabilitarFiltro(Me.iugSoportes, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.iugSoportes, Activation.NoEdit, "DESCRIPCION", "VALOR")
        GrillaFormato.AutoAjustarColumnas(Me.iugSoportes, "DESCRIPCION")

        With Me.iugSoportes.DisplayLayout.Bands(0)
            .Columns("DESCRIPCION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PORCENTAJE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("VALOR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

        '===============================================================================================
        'Grilla TEMAS
        Listas.CambiarTituloColumna(Me.uigTemas, "TEMA", "Tema")
        Listas.CambiarTituloColumna(Me.uigTemas, "PORCENTAJE", "Porcentaje")
        Listas.CambiarTituloColumna(Me.uigTemas, "DURACION", "Duracion")
        GrillaFormato.CambiarFormatoColumna(Me.uigTemas, "PORCENTAJE", Formato.Decimales)
        GrillaFormato.CambiarAlineacionColumna(Me.uigTemas, HAlign.Right)
        GrillaFormato.HabilitarFiltro(Me.uigTemas, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigTemas, Activation.NoEdit, "TEMA", "DURACION")
        GrillaFormato.AutoAjustarColumnas(Me.uigTemas, "TEMA")

        With Me.uigTemas.DisplayLayout.Bands(0)
            .Columns("TEMA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("PORCENTAJE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DURACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Function ObtenerCalculadoXSoporte() As Double

        Dim InversionXSoporte As Double
        Dim PorcentajeXSoporte As Double
        Dim ValorObjetivo As Double

        If Me.iugSoportes.ActiveRow.Cells("PORCENTAJE").Value Is DBNull.Value Then
            PorcentajeXSoporte = 0
        Else
            PorcentajeXSoporte = Me.iugSoportes.ActiveRow.Cells("PORCENTAJE").Value
        End If

        ValorObjetivo = Me.txtvalortipoObjetico.Text

        InversionXSoporte = (ValorObjetivo * PorcentajeXSoporte) / 100

        Me.iugSoportes.ActiveRow.Cells("VALOR").Value = InversionXSoporte

    End Function

    Private Function AutoSumaTotalPorcentajeSoporte() As Double

        Dim TotalPorcentajeSoporte As Double

        If Not Me.iugSoportes.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.iugSoportes.Rows
                If Not RowGrilla.Cells("PORCENTAJE").Value Is System.DBNull.Value Then
                    'If RowGrilla.Cells("DESCRIPCION").Value <> "TOTAL PORCENTAJE" Then
                    If RowGrilla.Cells("PORCENTAJE").Value > 0 Then
                        TotalPorcentajeSoporte += RowGrilla.Cells("PORCENTAJE").Value
                        'End If
                    End If
                End If
            Next
        End If

        Return TotalPorcentajeSoporte

    End Function

    Private Function AutoSumaTotalPorcentajeTemas() As Double

        Dim TotalPorcentajeTema As Double

        If Not Me.uigTemas.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.uigTemas.Rows
                If Not RowGrilla.Cells("PORCENTAJE").Value Is System.DBNull.Value Then
                    'If RowGrilla.Cells("TEMA").Value <> "TOTAL PORCENTAJE" Then
                    If RowGrilla.Cells("PORCENTAJE").Value > 0 Then
                        TotalPorcentajeTema += RowGrilla.Cells("PORCENTAJE").Value
                    End If
                    'End If
                End If
            Next
        End If

        Return TotalPorcentajeTema

    End Function

    Private Sub HabilitarControles()

    End Sub

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

    Private Function ValidarDatos() As Boolean

        If Me.txtvalortipoObjetico.Text = "" Then
            MsgBox("El Valor no puede ser vacio, para el Objetivo", MsgBoxStyle.Information, "Distribuidor de Pases")
            Me.txtvalortipoObjetico.Focus()
            ResultadoValidacion = True
            Exit Function
        End If

        If Me.txtAvisos.Text = "" Then
            MsgBox("El Valor no puede ser vacio, para los Avisos", MsgBoxStyle.Information, "Distribuidor de Pases")
            Me.txtAvisos.Focus()
            ResultadoValidacion = True
            Exit Function
        End If


        If Me.txtvalortipoObjetico.Text <> "" Then
            If Not IsNumeric(Me.txtvalortipoObjetico.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico, para el Objetivo", MsgBoxStyle.Information, "Distribuidor de Pases")
                Me.txtvalortipoObjetico.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.valortipoObjetico = Me.txtvalortipoObjetico.Text
                ResultadoValidacion = False
            End If
        End If

        If Me.txtAvisos.Text <> "" Then
            If Not IsNumeric(Me.txtAvisos.Text) Then
                MsgBox("Debe Ingresar un Valor Numerico, para los Avisos", MsgBoxStyle.Information, "Distribuidor de Pases")
                Me.txtAvisos.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.avisos = Me.txtAvisos.Text
                ResultadoValidacion = False
            End If
        End If

        If Me.txtvalortipoObjetico.Text <> "" Then
            If CDbl(Me.txtvalortipoObjetico.Text) <= 0 Then
                MsgBox("Debe Ingresar un Valor Numerico, para el Objetivo MAYOR a Cero.", MsgBoxStyle.Information, "Distribuidor de Pases")
                Me.txtvalortipoObjetico.Focus()
                ResultadoValidacion = True
                Exit Function
            Else
                Me.valortipoObjetico = Me.txtvalortipoObjetico.Text
                ResultadoValidacion = False
            End If
        End If

    End Function

    Private Sub CalcularPorcentajeGrillaSoporte()

        Dim ValorObjetivo As Double
        Dim InversionXSoporte As Double

        ValidarDatos()

        If ResultadoValidacion = True Then
            Exit Sub
        End If

        If Not Me.iugSoportes.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.iugSoportes.Rows
                If Not RowGrilla.Cells("PORCENTAJE").Value Is System.DBNull.Value Then
                    If RowGrilla.Cells("PORCENTAJE").Value > 0 Then
                        ValorObjetivo = Me.txtvalortipoObjetico.Text
                        InversionXSoporte = (ValorObjetivo * RowGrilla.Cells("PORCENTAJE").Value) / 100
                        RowGrilla.Cells("VALOR").Value = InversionXSoporte
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub LimpiarGrillaSoporte()

        If Not Me.iugSoportes.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.iugSoportes.Rows
                RowGrilla.Cells("PORCENTAJE").Value = ""
                RowGrilla.Cells("VALOR").Value = ""
            Next
        End If

    End Sub

    Private Sub RefrescarDts()

        Me.DtSoporteDistribuidor = Me.iugSoportes.DataSource
        Me.DtTemasDistribuidor = Me.uigTemas.DataSource

    End Sub

    Private Sub CargarVariables()

        If rdgrps.Checked = True Then
            Me.TipoObjetivo = EnuTipoObjetivo.GRPS
        ElseIf Me.rdinversion.Checked = True Then
            Me.TipoObjetivo = EnuTipoObjetivo.INVERSION
        End If

        Me.DistribuidorValorObjetivo = Me.txtvalortipoObjetico.Text
        Me.DistribuidorValorAvisos = Me.txtAvisos.Text

        If Me.rdfranjaratalto.Checked = True Then
            DistribuidorTipoFranja = EnuTipoFranja.RATMASALTO
        ElseIf Me.rdcprbajo.Checked = True Then
            DistribuidorTipoFranja = EnuTipoFranja.CPRMASBAJO
        End If

      

    End Sub

    Private Sub CambiarColorCelda()

        For Each b As UltraGridBand In Me.iugSoportes.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To Me.iugSoportes.Rows.Count - 1
                Me.iugSoportes.Rows(i).Cells("DESCRIPCION").Appearance.BackColor = Color.Beige
            Next
        Next


        For Each b As UltraGridBand In Me.uigTemas.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To Me.uigTemas.Rows.Count - 1
                Me.uigTemas.Rows(i).Cells("TEMA").Appearance.BackColor = Color.Bisque
            Next
        Next

    End Sub

    Private Sub CambiarColorFilaTotal()

        'Grilla de SOPORTES
        Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("DESCRIPCION").Appearance.BackColor = Color.Beige
        Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("PORCENTAJE").Appearance.BackColor = Color.Beige
        Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("VALOR").Appearance.BackColor = Color.Beige
        Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("ID_SOPORTE").Appearance.BackColor = Color.Beige

        'Grilla de TEMAS
        Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("TEMA").Appearance.BackColor = Color.Bisque
        Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("PORCENTAJE").Appearance.BackColor = Color.Bisque
        Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("DURACION").Appearance.BackColor = Color.Bisque


    End Sub

    Private Function CargarDtDistribuidorConjunto() As DataTable

        Dim DrNuevaDistribuidor As DataRow
        Dim RowFilaEliminar As DataRow()

        If DtSoporteDistribuidor.Rows.Count > 0 And DtTemasDistribuidor.Rows.Count > 0 Then

            For Each DrSoporte As DataRow In DtSoporteDistribuidor.Select("VALOR >=0")
                For Each DrTema As DataRow In DtTemasDistribuidor.Rows
                    DrNuevaDistribuidor = _DistribuidorConjunto.NewRow()
                    DrNuevaDistribuidor("ID_SOPORTE") = DrSoporte("ID_SOPORTE")
                    DrNuevaDistribuidor("ID_TEMA") = DrTema("TEMA")
                    DrNuevaDistribuidor("DURACION") = DrTema("DURACION")
                    If DrTema("TEMA") <> "TOTAL PORCENTAJE" And DrSoporte("DESCRIPCION") <> "TOTAL PORCENTAJE" Then
                        If Not DrTema("PORCENTAJE") Is DBNull.Value Then
                            If DrTema("PORCENTAJE") > 0 Then
                                DrNuevaDistribuidor("IMPORTE") = ObtenerValorImporteXTema(DrSoporte("VALOR"), DrTema("PORCENTAJE"))
                                DrNuevaDistribuidor("GRPS") = ObtenerValorImporteXTema(DrSoporte("VALOR"), DrTema("PORCENTAJE"))
                                DrNuevaDistribuidor("IMPORTE_CONTROL") = 0
                                DrNuevaDistribuidor("GRPS_CONTROL") = 0
                                _DistribuidorConjunto.Rows.Add(DrNuevaDistribuidor)
                                _DistribuidorConjunto.AcceptChanges()
                            End If
                        End If
                    End If
                Next
            Next
        End If

        Return _DistribuidorConjunto

    End Function

    Private Function ValidarDatosCompletoFinal() As Boolean

        For Each DrSoporte As DataRow In DtSoporteDistribuidor.Rows
            If DrSoporte("VALOR") Is DBNull.Value Then
                Return True
                Exit Function
            End If
        Next
    End Function

    Private Function ObtenerValorImporteXTema(ByVal ValorSoporte As Double, ByVal PorcentajeTema As Double) As Double

        Dim Resultado As Double

        If ValorSoporte > 0 And PorcentajeTema > 0 Then
            Resultado = (ValorSoporte * PorcentajeTema) / 100
        End If

        Return Resultado

    End Function

    Private Sub AnexarFilaTotalPorcentajes()

        'Dim RowPorcentaje As DataRow

        'RowPorcentaje = _DtTemasCampania.NewRow()
        'RowPorcentaje("TEMA") = "TOTAL PORCENTAJE"
        '_DtTemasCampania.Rows.Add(RowPorcentaje)
        '_DtTemasCampania.AcceptChanges()


        'RowPorcentaje = _DtSoportesHoja.NewRow()
        'RowPorcentaje("DESCRIPCION") = "TOTAL PORCENTAJE"
        '_DtSoportesHoja.Rows.Add(RowPorcentaje)
        '_DtSoportesHoja.AcceptChanges()



    End Sub

    Private Sub InhabilitarCeldaTotalPorcentaje()

        'GrillaFormato.HabilitarCelda(Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("PORCENTAJE"), Activation.NoEdit)
        'GrillaFormato.HabilitarCelda(Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("PORCENTAJE"), Activation.NoEdit)

    End Sub

    Private Function ValidarTotalPorcentajeFinal() As Boolean

        Dim ControlTotalporcentajeSoporte As Double
        Dim ControlTotalporcentajeTemas As Double
        Dim Resultado As Boolean = False

        ' AGREGO VALIDACION DE PORCENTAJES NULOS (AN 05-10-2015)
        If String.IsNullOrEmpty(txtPorcentajeSoporte.Text) Or String.IsNullOrEmpty(txttotaltemas.Text) Then
            Resultado = True
            Return Resultado
            Exit Function
        End If

        'If Not Me.iugSoportes.Rows(Me.iugSoportes.Rows.Count - 1).Cells("PORCENTAJE").Value Is System.DBNull.Value Then
        ControlTotalporcentajeSoporte = txtPorcentajeSoporte.Text
        'Else
        'ControlTotalporcentajeSoporte = -1
        'End If


        'If Not Me.uigTemas.Rows(Me.uigTemas.Rows.Count - 1).Cells("PORCENTAJE").Value Is System.DBNull.Value Then


        ControlTotalporcentajeTemas = Me.txttotaltemas.Text
        'Else
        'ControlTotalporcentajeTemas = -1
        'End If

        'AG 20/05/2014 ================
        'If ControlTotalporcentajeTemas >= 99.85 Then
        'End If
        '================================

        If ControlTotalporcentajeSoporte < 0 Or ControlTotalporcentajeSoporte > 100 Or ControlTotalporcentajeSoporte < 99.9 Then
            Resultado = True
            Return Resultado
            Exit Function
        End If

        If ControlTotalporcentajeTemas < 0 Or ControlTotalporcentajeTemas > 100 Or ControlTotalporcentajeTemas < 99.9 Then
            Resultado = True
            Return Resultado
            Exit Function
        End If



    End Function

#End Region



    
End Class

Public Enum EnuTipoObjetivo
    INVERSION = 1
    GRPS = 2
End Enum

Public Enum EnuTipoFranja
    RATMASALTO = 1
    CPRMASBAJO = 2
End Enum
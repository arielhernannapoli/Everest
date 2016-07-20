Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Shared
Imports System.DateTime

Public Class frmAuspicio

#Region "Variables"

    Dim _IdCampania As Integer
    Dim _IdSistema As Integer
    Dim _IdTarifa As Integer
    Dim _IdCliente As Integer
    Dim _IdMedio As Integer
    Dim _IdSoporte As Integer
    Dim _FSistemaDesde As String
    Dim _FSistemaHasta As String
    Dim DtTemasCampania As New DataTable
    Dim DtTemasSeleccionados As New DataTable
    Dim DtTemasUsados As New DataTable
    Dim CantTemas As Integer
    Dim CantDiasEmision As Integer
    Dim CantDiasNoEmision As Integer
    Dim ImporteBruto As Double
    Dim CDiasComprar As Double
    Dim MaxSpotPermitidos As Integer
    Dim ImpUnitarioTema As Double
    Dim ImpTotalTema As Double
    Dim AvisosXDia As Integer
    Dim DtAvisosComprados As New DataTable
    Dim Formato As String = "#,##0.00"
    Dim FechaDesde As Date
    Dim FechaHasta As Date
    Dim DiaSemana As New ArrayList
    Dim DiaSinEmision As New ArrayList
    Dim NuevoDiaEmision As New ArrayList
    Dim TemasSeleccionados As String
    Dim DtDiasProgramacion As DataTable
    Dim CantNuevoDiaEmision As Integer
    Dim FDesde As Date
    Dim FHasta As Date
    Dim _Cancelar As Boolean
    Dim DtTemas As New DataTable

    'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
    Dim mControlTipoAuspicio As Integer
    Dim mDtTemasExistentesEjercicio As DataTable
    '---------------------------------------------------------------------------------------------

    Dim _DtTemasUtilizados As DataTable

#End Region

#Region "Propiedades"

    Public Property DtTemasUtilizados() As DataTable
        Get
            Return _DtTemasUtilizados
        End Get
        Set(ByVal value As DataTable)
            _DtTemasUtilizados = value
        End Set
    End Property

    'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
    Public Property ControlTipoAuspicio() As Integer
        Get
            Return mControlTipoAuspicio
        End Get
        Set(ByVal value As Integer)
            mControlTipoAuspicio = value
        End Set
    End Property

    Public Property DtTemasExistentesEjercicio() As DataTable
        Get
            Return mDtTemasExistentesEjercicio
        End Get
        Set(ByVal value As DataTable)
            mDtTemasExistentesEjercicio = value
        End Set
    End Property
    '---------------------------------------------------------------------------------------------
    Public Property IdCampania() As Integer
        Get
            Return _IdCampania
        End Get
        Set(ByVal value As Integer)
            _IdCampania = value
        End Set
    End Property

    Public Property IdSistema() As Integer
        Get
            Return _IdSistema
        End Get
        Set(ByVal value As Integer)
            _IdSistema = value
        End Set
    End Property

    Public Property FDesdeSistema() As String
        Get
            Return _FSistemaDesde
        End Get
        Set(ByVal value As String)
            _FSistemaDesde = value
        End Set
    End Property

    Public Property FHastaSistema() As String
        Get
            Return _FSistemaHasta
        End Get
        Set(ByVal value As String)
            _FSistemaHasta = value
        End Set
    End Property

    Public Property IdTarifa() As Integer
        Get
            Return _IdTarifa
        End Get
        Set(ByVal value As Integer)
            _IdTarifa = value
        End Set
    End Property
    Public Property IdCliente() As Integer
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As Integer)
            _IdCliente = value
        End Set
    End Property

    Public Property IdMedio() As Integer
        Get
            Return _IdMedio
        End Get
        Set(ByVal value As Integer)
            _IdMedio = value
        End Set
    End Property

    Public Property IdSoporte() As Integer
        Get
            Return _IdSoporte
        End Get
        Set(ByVal value As Integer)
            _IdSoporte = value
        End Set
    End Property

    Public Property Cancelar() As Boolean
        Get
            Return _Cancelar
        End Get
        Set(ByVal value As Boolean)
            _Cancelar = value
        End Set
    End Property

    Public Property DtTemasEjercicio() As DataTable
        Get
            Return DtTemasUsados
        End Get
        Set(ByVal value As DataTable)
            DtTemasUsados = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub ChfrmAuspicio_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        DtTemasUsados = frmEjercicio.Instancia.DtTemasUtilizados
        'DtTemasUsados = DtTemasUtilizados()

        ObtenerFechaSistemas()

        'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
        If mControlTipoAuspicio = 1 Then
            DtTemas = EliminarTemas(mDtTemasExistentesEjercicio, ObtenerTemasXCampanias(Me.IdCampania))
        Else
            DtTemas = ObtenerTemasXCampanias(Me.IdCampania)
        End If
        '---------------------------------------------------------------------------------------------

        Me.iugTemas.DataSource = CargarDtTemasCampanias(DtTemas)

        iugTemas.DisplayLayout.Bands(0).Columns("Valoriza?").Hidden = True

        'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
        'If mControlTipoAuspicio = 1 Then
        '    Me.dtpFechaInicioD.Enabled = False
        '    Me.dtpFechaFinD.Enabled = False
        '    Me.GroupBox3.Enabled = False
        'End If
        '---------------------------------------------------------------------------------------------

        ArmarEstructuraDtTemasSeleccionados()
        ArmarEstructuraDtAvisosComprados()
        ObtenerDiasEmision()
        Listas.CambiarTituloColumna(Me.iugTemas, "Tema", "   Tema - Producto - Material")
        Listas.CambiarTituloColumna(Me.iugTemas, "CantAvisos", "Cant. Avisos")

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim TipoError As Integer

        If CargarDtTemasSeleccionados() = False Then
            MsgBox("No selecciono ningun tema, para ejecutar la operacion", MsgBoxStyle.Information, "Everest 1.0.0.2")
            Exit Sub
        End If

        'If ControlImporte = False Then
        '    MsgBox("Debe ingresar el Importe Bruto, para ejecutar la operacion", MsgBoxStyle.Information, "Everest 1.0.0.2")
        '    Exit Sub
        'End If

        'If ControlDias = False Then
        'MsgBox("Debe ingresar la cantidad de dias, para ejecutar la operacion", MsgBoxStyle.Information, "Everest 1.0.0.2")
        'Exit Sub
        'End If


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

        'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
        If mControlTipoAuspicio = 1 Then
            With frmEjercicio.Instancia
                CargarDtSinAvisos(ArmarEstructuraDtSinAvisos())
                .ControlTipoAuspicio = mControlTipoAuspicio
                .DtAuspicio = CargarDtSinAvisos(ArmarEstructuraDtSinAvisos()).Copy
                If Me.TxtImporteD.Text = "" Then
                    .MontoBrutoAuspicio = CDbl(0)
                Else
                    .MontoBrutoAuspicio = CDbl(Me.TxtImporteD.Text)
                End If

            End With
        Else
            ObtenerTemas()
            CargarDtAvisos()
            CalcularImporteBruto()

            With frmEjercicio.Instancia
                .ControlTipoAuspicio = mControlTipoAuspicio
                .DtAuspicio = DtAvisosComprados.Copy
                .MontoBrutoAuspicio = ImporteBruto
                .ImporteAuspicioTema = Math.Round(CDbl(ImpUnitarioTema), 2)
            End With

        End If
        '---------------------------------------------------------------------------------------------

        Me.Close()

    End Sub

#End Region

#Region "Procedimientos y Funciones"

    Private Function ObtenerFechaSistemas()

        Dim oSistemas As New Sistemas
        Dim DtSistemas As DataTable

        With oSistemas
            .Id_campania = Me.IdCampania
            .Id_sistema = Me.IdSistema
            DtSistemas = .ObtenerSistemasFechas
        End With

        For Each dr As DataRow In DtSistemas.Rows
            Me.dtpFechaInicioD.Value = dr("Fecha_Inicio")
            Me.dtpFechaFinD.Value = dr("Fecha_fin")

            FDesde = CDate(dr("Fecha_Inicio"))
            FHasta = CDate(dr("Fecha_fin"))
        Next

    End Function

    Private Function CargarDtTemasCampanias(ByVal Dt As DataTable) As DataTable

        Dim Row As DataRow
        Dim DrDatos As DataRow
        Dim Productos() As DataRow
        Dim List As New ValueList

        ArmarEstructuraDtAuspicio()

        For Each Tema As DataRow In DtTemas.Rows
            Row = DtTemasCampania.NewRow
            Productos = DtTemasUsados.Select("ID_TEMA='" & Tema("ID_TEMA") & "'")
            Row("Tema") = Tema("ID_TEMA") & " - " & Productos(0)("Producto") & " - " & Productos(0)("Material")
            'Row("Duracion") = DrDatos("Duracion")
            Row("Duracion") = Productos(0)("Duracion")
            Row("Activa") = False
            Row("CantAvisos") = 0
            Row("Valoriza?") = False
            DtTemasCampania.Rows.Add(Row)
        Next

        Return DtTemasCampania
    End Function

    Private Function ObtenerTemasXCampanias(ByVal IdCampania As Integer) As DataTable

        Dim oTemas As New Temas
        Dim DtTemas As DataTable

        With oTemas
            .Id_campania = IdCampania
            DtTemas = .ObtenerTemasCampaña
        End With

        If DtTemas.Rows.Count = 0 Then
            Mensajes.Mensaje("No existen Temas, asignadas a esta Campaña", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
        Else
            Return DtTemas
        End If

    End Function

    Private Sub ArmarEstructuraDtAuspicio()

        With DtTemasCampania
            .Columns.Add("Tema", GetType(String))
            .Columns.Add("Duracion", GetType(String))
            .Columns.Add("Activa", GetType(Boolean))
            .Columns.Add("CantAvisos", GetType(Integer))
            .Columns.Add("Valoriza?", GetType(Boolean))
            .AcceptChanges()
        End With

    End Sub

    Private Sub ArmarEstructuraDtTemasSeleccionados()

        With DtTemasSeleccionados
            .Columns.Add("Tema", GetType(String))
            .Columns.Add("importe", GetType(Double))
            .Columns.Add("Valoriza?", GetType(String))
            .Columns.Add("CantAvisos", GetType(Integer))
            .AcceptChanges()
        End With

    End Sub

    Private Sub ArmarEstructuraDtAvisosComprados()

        With DtAvisosComprados
            .Columns.Add("Tema", GetType(String))
            .Columns.Add("FEmision", GetType(String))
            .Columns.Add("ValorTema", GetType(String))
            .AcceptChanges()
        End With

    End Sub

    Private Function CargarDtTemasSeleccionados() As Boolean

        Dim Row As DataRow
        Dim strTema As String
        Dim strValorTema As String

        CargarDtTemasSeleccionados = True

        For Each r As UltraGridRow In iugTemas.Rows
            If r.Cells("Activa").Value = True Then
                Row = DtTemasSeleccionados.NewRow
                'Row("Tema") = r.Cells("Tema").Value
                strTema = r.Cells("Tema").Value
                If r.Cells("Valoriza?").Value = True Then
                    strValorTema = "1"
                Else
                    strValorTema = "0"
                End If
                Row("CantAvisos") = r.Cells("CantAvisos").Value
                Row("Tema") = strTema.Substring(0, 1)
                'Row("Valoriza?") = strTema.Substring(0, 1) + strValorTema

                DtTemasSeleccionados.Rows.Add(Row)
            End If
        Next

        If DtTemasSeleccionados.Rows.Count > 0 Then
            CantTemas = DtTemasSeleccionados.Rows.Count
        Else
            CargarDtTemasSeleccionados = False
        End If

    End Function

    Private Sub ObtenerTemas()

        For Each Row As DataRow In DtTemasSeleccionados.Rows
            Dim value As String = Row("Tema").ToString
            TemasSeleccionados += value.Substring(0, 1)
        Next

    End Sub

    Private Function ControlImporte() As Boolean

        ControlImporte = True

        If Me.TxtImporteD.Text = "" Then
            ControlImporte = False
        End If

    End Function

    Private Function ControlDias() As Boolean

        ControlDias = True

        If Me.TxtAvisosDias.Text = "" Then
            ControlDias = False
        End If

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

    Private Sub ObtenerDiasEmision()

        Dim oProgramacion As New Tarifas_tv

        With oProgramacion
            .Id_cliente = Me.IdCliente
            .Id_medio = Me.IdMedio
            .Id_tarifa_tv = Me.IdTarifa
            .Id_soporte = Me.IdSoporte
            .F_inicio_vig = CDate(dtpFechaInicioD.Value)
            .F_fin_vig = CDate(dtpFechaFinD.Value)

            DtDiasProgramacion = .TraerDiasEmision()

        End With

        ObtenerDiasMarcados()

    End Sub

    Private Function ObtenerDiasMarcados()

        Dim CantDiasSistema As Integer
        Dim i As Integer
        Dim Marca As String

        FechaDesde = CDate(dtpFechaInicioD.Value)
        FechaHasta = CDate(dtpFechaFinD.Value)

        'Obtengo la cantidad de dias que hay entre la Fecha Desde y Fecha Hasta del Calendario
        CantDiasSistema = DateDiff(DateInterval.Day, FechaDesde, FechaHasta)

        'Obtengo los dias marcados con X, siendo estos los dias que se emiten el programa por semana
        For Each Row As DataRow In DtDiasProgramacion.Rows
            Marca = IIf(IsDBNull(Row.Item("D_L")), "", Row.Item("D_L"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Lunes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_M")), "", Row.Item("D_M"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Martes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_X")), "", Row.Item("D_X"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Miercoles)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_J")), "", Row.Item("D_J"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Jueves)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_V")), "", Row.Item("D_V"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Viernes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_S")), "", Row.Item("D_S"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Sabado)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_D")), "", Row.Item("D_D"))
            If Marca = "X" Then
                DiaSemana.Add(Activo.DiaSemana.Domingo)
                Marca = ""
            End If

        Next

        'Obtiene la cantidad de dias que se emite el programa desde la fecha desde, hasta la fecha hasta
        For i = 0 To CantDiasSistema

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Monday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Lunes) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Tuesday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Martes) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Wednesday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Miercoles) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Thursday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Jueves) > -1 Then
                    CantDiasEmision += 1
                End If
            End If


            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Friday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Viernes) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Sabado) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Domingo) > -1 Then
                    CantDiasEmision += 1
                End If
            End If

        Next

    End Function

    Private Function ObtenerDiasNoEmision()

        Dim Marca As String
        Dim i As Integer

        'Obtengo los dias no marcados con X, siendo estos los dias que no se emiten el programa por semana
        For Each Row As DataRow In DtDiasProgramacion.Rows
            Marca = IIf(IsDBNull(Row.Item("D_L")), "", Row.Item("D_L"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Lunes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_M")), "", Row.Item("D_M"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Martes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_X")), "", Row.Item("D_X"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Miercoles)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_J")), "", Row.Item("D_J"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Jueves)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_V")), "", Row.Item("D_V"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Viernes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_S")), "", Row.Item("D_S"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Sabado)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_D")), "", Row.Item("D_D"))
            If Marca = "" Then
                DiaSinEmision.Add(Activo.DiaSemana.Domingo)
                Marca = ""
            End If

        Next


        'Obtiene la cantidad de dias que NO se emite el programa desde la fecha desde, hasta la fecha hasta
        For i = 0 To CDiasComprar

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Monday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Lunes) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Tuesday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Martes) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Wednesday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Miercoles) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Thursday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Jueves) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If


            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Friday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Viernes) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Sabado) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then
                If DiaSinEmision.IndexOf(Activo.DiaSemana.Domingo) > -1 Then
                    CantDiasNoEmision += 1
                End If
            End If

        Next

    End Function

    Private Function ObtenerDiasEmisionActualizado()

        Dim Marca As String
        Dim i As Integer

        'Obtengo los dias marcados con X, siendo estos los dias que se emiten el programa por semana
        For Each Row As DataRow In DtDiasProgramacion.Rows
            Marca = IIf(IsDBNull(Row.Item("D_L")), "", Row.Item("D_L"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Lunes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_M")), "", Row.Item("D_M"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Martes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_X")), "", Row.Item("D_X"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Miercoles)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_J")), "", Row.Item("D_J"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Jueves)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_V")), "", Row.Item("D_V"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Viernes)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_S")), "", Row.Item("D_S"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Sabado)
                Marca = ""
            End If

            Marca = IIf(IsDBNull(Row.Item("D_D")), "", Row.Item("D_D"))
            If Marca = "X" Then
                NuevoDiaEmision.Add(Activo.DiaSemana.Domingo)
                Marca = ""
            End If

        Next


        'Obtiene la cantidad de dias que se emite el programa desde la fecha desde, hasta la fecha hasta
        For i = 0 To CDiasComprar

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Monday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Lunes) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Tuesday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Martes) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Wednesday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Miercoles) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Thursday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Jueves) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If


            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Friday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Viernes) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Sabado) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then
                If NuevoDiaEmision.IndexOf(Activo.DiaSemana.Domingo) > -1 Then
                    CantNuevoDiaEmision += 1
                End If
            End If

        Next

    End Function

    Private Function CalcularImporteBruto()

        If Me.TxtImporteD.Text = "" Then
            ImporteBruto = 0
        Else
            ImporteBruto = Me.TxtImporteD.Text
        End If

        'FechaDesde = CDate(dtpFechaInicio.Value)

        ObtenerDiasNoEmision()
        ObtenerDiasEmisionActualizado()

        Dim strTema As String
        Dim cantAvisos As Integer
        Dim cantRegisterGrid As Integer = DtAvisosComprados.Rows.Count '

        ''Obtengo segun la cantidad de temas la cantidad de avisos total para calcular el importe
        'For Each r As UltraGridRow In iugTemas.Rows
        '    If r.Cells("Valoriza?").Value = True Then
        '        cantAvisos += r.Cells("CantAvisos").Value
        '    End If
        'Next

        ''Realiza el calculo sobre el importe que se va a calcular.
        Dim totalTemaDividir As Integer = cantRegisterGrid * cantAvisos
        Dim ImporteIngresado As Double
        If Me.TxtImporteD.Text = "" Then
            ImporteIngresado = 0
        Else
            ImporteIngresado = Convert.ToDouble(Me.TxtImporteD.Text)
        End If

        Dim TotalAmount = ImporteIngresado / totalTemaDividir

        ImpUnitarioTema = TotalAmount



    End Function

    Private Function CargarDtAvisos() As DataTable

        Dim i, j As Integer
        Dim TotalDias As String
        Dim Row As DataRow
        Dim TotalAvisosXDia As Integer
        Dim CantAvisos As Integer
        Dim DtDiasControl As New DataTable
        Dim DrowsFecha() As DataRow

        TotalAvisosXDia = CantTemas * AvisosXDia

        FechaDesde = CDate(dtpFechaInicioD.Value)
        FechaHasta = CDate(dtpFechaFinD.Value)

        CDiasComprar = DateDiff(DateInterval.Day, FechaDesde, FechaHasta)

        TotalDias = CInt(CDiasComprar)

        DtDiasControl = CargarDiasSeleccionados()

        For i = 0 To TotalDias

            Row = DtAvisosComprados.NewRow
            '************************** Cargo Avisos en el Dia LUNES  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Monday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Lunes) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("Tema") = strTema
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia MARTES  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Tuesday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Martes) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("Tema") = strTema
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia MIERCOLES  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Wednesday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Miercoles) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("Tema") = strTema
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia JUEVES  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Thursday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Jueves) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("Tema") = strTema
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia VIERNES  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Friday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Viernes) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("Tema") = strTema
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia SABADO  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Sabado) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("Tema") = strTema
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If

            '************************** Cargo Avisos en el Dia DOMINGO  *********************************
            If FechaDesde.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then
                If DiaSemana.IndexOf(Activo.DiaSemana.Domingo) > -1 Then
                    DrowsFecha = DtDiasControl.Select("FechaDia='" & FechaDesde.AddDays(i).ToShortDateString & "'")
                    If DrowsFecha.Length > 0 Then
                        Dim strTema As String = String.Empty
                        For Each Letra As DataRow In DtTemasSeleccionados.Rows
                            Dim CantAvisosTemp As Integer
                            CantAvisosTemp = Letra("CantAvisos")
                            For j = 0 To CantAvisosTemp - 1
                                strTema += Letra("Tema")
                            Next j
                            Row("Tema") = strTema
                            Row("ValorTema") += Letra("Valoriza?") + "-"
                        Next
                        Row("FEmision") = FechaDesde.AddDays(i).ToShortDateString
                        DtAvisosComprados.Rows.Add(Row)
                    End If
                End If
            End If
        Next i

    End Function

    'AGuzzardi Auspicio Nuevo ------------------------------------------------------------

    Private Function EliminarTemas(ByVal DtTemaEjercicioExistente As DataTable, ByVal DtTemasDB As DataTable) As DataTable

        Dim Dr, DRow As DataRow
        Dim Letra As String

        Dim DtTemaFiltrado As DataTable = DtTemasDB.Clone

        For Each DRow In DtTemaEjercicioExistente.Rows
            Letra = DRow("Id_tema")
            For Each Dr In DtTemasDB.Select("ID_TEMA = '" & Letra & "'")
                DtTemaFiltrado.ImportRow(Dr)
            Next
        Next

        Return DtTemaFiltrado

    End Function

    'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
    Private Function ArmarEstructuraDtSinAvisos() As DataTable

        Dim DtTemasSinAvisos As New DataTable

        With DtTemasSinAvisos
            .Columns.Add("Tema", GetType(String))
            .Columns.Add("Control_Importe", GetType(Integer))
            .AcceptChanges()
        End With

        Return DtTemasSinAvisos

    End Function

    'AGuzzardi Auspicio Nuevo ------------------------------------------------------------
    Private Function CargarDtSinAvisos(ByVal Dt As DataTable) As DataTable

        Dim Rows As DataRow

        For Each r As UltraGridRow In iugTemas.Rows
            If r.Cells("Activa").Value = True Then
                Rows = Dt.NewRow
                If r.Cells("Valoriza?").Value = True And r.Cells("Activa").Value = True Then
                    Rows("Control_Importe") = 1
                End If
                If r.Cells("Valoriza?").Value = False And r.Cells("Activa").Value = True Then
                    Rows("Control_Importe") = 0
                End If
                Rows("Tema") = r.Cells("Tema").Value.ToString.Substring(0, 1)
                Dt.Rows.Add(Rows)
            End If

        Next

        Return Dt

    End Function

    Private Function CargarDiasSeleccionados() As DataTable

        Dim Dia As Integer
        Dim FechaDesde, FechaHasta As Date
        Dim Cantdias As Integer
        Dim i As Integer
        Dim DtControlDias As New DataTable
        Dim Rows As DataRow

        FechaDesde = Me.dtpFechaInicioD.Value
        FechaHasta = Me.dtpFechaFinD.Value

        Cantdias = DateDiff(DateInterval.Day, FechaDesde, FechaHasta) + 1
        FechaDesde = Me.dtpFechaInicioD.Value

        DtControlDias = CrearDtControlDias(DtControlDias)

        For i = 0 To Cantdias
            If FechaDesde.AddDays(i).ToShortDateString() >= Me.dtpFechaInicioD.Value And FechaDesde.AddDays(i).ToShortDateString() <= Me.dtpFechaFinD.Value Then
                Dia = FechaDesde.AddDays(i).DayOfWeek
                Rows = DtControlDias.NewRow
                Select Case Dia
                    Case DayOfWeek.Monday
                        If Me.chkLunes.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Tuesday
                        If Me.chkMartes.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Wednesday
                        If Me.chkMiercoles.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Thursday
                        If Me.chkJueves.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Friday
                        If Me.chkViernes.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Saturday
                        If Me.chkSabado.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                    Case DayOfWeek.Sunday
                        If Me.chkDomingo.Checked = True Then
                            Rows("FechaDia") = FechaDesde.AddDays(i).ToShortDateString
                            DtControlDias.Rows.Add(Rows)
                        End If
                End Select

            End If
        Next i

        Return DtControlDias

    End Function

    Private Function CrearDtControlDias(ByVal Dt As DataTable) As DataTable

        With Dt
            .Columns.Add("FechaDia", GetType(String))
            .AcceptChanges()
        End With

        Return Dt

    End Function
#End Region


End Class


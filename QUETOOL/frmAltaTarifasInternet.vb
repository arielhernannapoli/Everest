Imports MPG.DBL
Imports System.Text
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Framework.Mensajes
Imports Infragistics.Win.Printing
Imports MSL
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Shared

Public Class frmAltaTarifasInternet

#Region "Declaracion de Variables"

    Public mid_medio As Integer
    Public mid_cliente As Integer
    Public mid_soporte As Integer
    Public mIdTipoSoporte As Integer
    Public mdescmedio As String
    Public mdesccliente As String
    Public mdescTiposoporte As String
    Public mdescsoporte As String
    Public mfvigencia As Date
    Public mTarifaElegida As Long
    Public mSoloVigentes As Boolean
    Dim EspacioBlanco As String = "  "
    Dim DtNuevaTarifa As New DataTable
    Dim DtActualizarTarifa As New DataTable
    Dim DtEliminarTarifa As New DataTable
    Dim mDtTarifasUbicaciones As New DataTable
    Dim ListTarifasUbicaciones As ListBox
    Dim OperacionSeleccionada As Integer = OperacionActiva.MostrarTarifa
    Dim NombreDtCambios As String
    Dim IDTarifaSiguiente As Integer
    Shared mInstancia As frmAltaTarifasInternet
    Dim ListUbicacionesTarias As ListBox
    Dim IndiceGrilla As Integer
    '============= Variables Mensajes de ERRORES =====================================================
    Dim MensajeSinUbicaciones As String = "Debe ingresar UBICACIONES en la Tarifa. "
    Dim MensajeSinTipoFormato As String = "Debe ingresar TIPO FORMATO en la Tarifa. "
    Dim MensajeSinFormato As String = "Debe ingresar FORMATO en la Tarifa. "
    Dim MensajeSinModalidadCompra As String = "Debe ingresar MODALIDAD de COMPRA en la Tarifa. "
    Dim MensajeSinBruto As String = "Debe ingresar el IMPORTE BRUTO en la Tarifa. "
    Dim MensajeSinFechaVigenciaInicio As String = "Debe ingresar la FECHA VIGENCIA INICIO. "
    Dim MensajeSinFechaVigenciaFin As String = "Debe ingresar la FECHA VIGENCIA FIN. "
    Dim MensajeFechaVigenciaInicioMayoraFechaFin As String = "La FECHA VIGENCIA INICIO debe ser MENOR a la FECHA VIGENCIA FIN. "
    Dim MensajeFechaVigenciaFinMenoraFechaInicio As String = "La FECHA VIGENCIA FIN debe ser MAYOR a la FECHA VIGENCIA INICIO. "
    '============== Variables Mensajes Confirmacion ===================================================
    Dim MensajeConfirmacionOkAltaOperacion As String = "El alta de la NUEVA TARIFA, se realizo con exito.! "
    Dim MensajeConfirmacionOkModificarOperacion As String = "La modificacion de la TARIFA seleccionada, se realizo con exito.! "
    Dim MensajeConfirmacionEliminacionTarifa As String = "La eliminacion de la TARIFA seleccionada, se realizo con exito.! "
    Dim MensajeConfirmacionElimninacionTarifaNueva As String = "Desea cancelar el ALTA de la NUEVA TARIFA. "
    '============== Variables Mensajes Generales =======================================================
    Dim MensajeInformacionOperacion As String = "No activo ninguna Operacion, para la tarifa seleccionada. "
    Dim MensajePreguntaNuevaTarifa As String = "Desea agregar una NUEVA TARIFA?. "
    Dim MensajePreguntaModificarTarifa As String = "Desea modificar la TARIFA seleccionada ?. "
    Dim MensajePreguntaEliminacionTarifa As String = "Desea eliminar la TARIFA seleccionada?. "
    Dim MensjaePreguntaSalir As String = "Desea salir del modulo de Tarifas Internet?. "
    Dim MensajeTarifaExistente As String = "Ya existe una TARIFA cargada, para ese soporte y fecha de Vigencia. "

#End Region

#Region "Declaracion de Objetos"

    Dim OFormatos As Formatos
    Dim OSecciones As Secciones
    Dim OColocaciones As Colocaciones
    Dim OTarifaInternet As Tarifas_Internet
    Dim GrillaFormato As New GrillaFormato

    'Declaracion de Objetos Listas para Combos de la Grilla
    Private vlistUbicacion As ValueList   '= Secciones en MMS
    Private vlistTipoFormato As ValueList '= Colocacion en MMS
    Private vlistFormatos As ValueList    '= Formato en MMS
    Private vlistModalidadCompra As ValueList  '= Tipo Planificacion Tabla SPOTS

#End Region

#Region "Declaracion de Propiedades"

    Public Shared Property Instancia() As frmAltaTarifasInternet
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmAltaTarifasInternet
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmAltaTarifasInternet)
            mInstancia = Value
        End Set
    End Property

    Public Property UbicacionesSeleccionadasList() As ListBox
        Get
            Return ListUbicacionesTarias
        End Get
        Set(ByVal Value As ListBox)
            ListUbicacionesTarias = Value
        End Set
    End Property

    Public Property DtUbicacionesTarifas() As DataTable
        Get
            Return mDtTarifasUbicaciones
        End Get
        Set(ByVal Value As DataTable)
            mDtTarifasUbicaciones = Value
        End Set
    End Property

    Public Property IdMedio() As Integer
        Get
            Return mid_medio
        End Get
        Set(ByVal Value As Integer)
            mid_medio = Value
        End Set
    End Property

    Public Property DescMedio() As String
        Get
            Return mdescmedio
        End Get
        Set(ByVal Value As String)
            mdescmedio = Value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return mid_cliente
        End Get
        Set(ByVal Value As Integer)
            mid_cliente = Value
        End Set
    End Property

    Public Property DescCliente() As String
        Get
            Return mdesccliente
        End Get
        Set(ByVal Value As String)
            mdesccliente = Value
        End Set
    End Property

    Public Property IdTipoSoporte() As Integer
        Get
            Return mIdTipoSoporte
        End Get
        Set(ByVal Value As Integer)
            mIdTipoSoporte = Value
        End Set
    End Property

    Public Property DescTipoSoporte() As String
        Get
            Return mdescTiposoporte
        End Get
        Set(ByVal Value As String)
            mdescTiposoporte = Value
        End Set
    End Property

    Public Property IdSoporte() As Integer
        Get
            Return mid_soporte
        End Get
        Set(ByVal Value As Integer)
            mid_soporte = Value
        End Set
    End Property

    Public Property DescSoporte() As String
        Get
            Return mdescsoporte
        End Get
        Set(ByVal Value As String)
            mdescsoporte = Value
        End Set
    End Property

    Public Property FVigencia() As Date
        Get
            Return mfvigencia
        End Get
        Set(ByVal Value As Date)
            mfvigencia = Value
        End Set
    End Property

    Public Property SoloVigentes() As Boolean
        Get
            Return mSoloVigentes
        End Get
        Set(ByVal Value As Boolean)
            mSoloVigentes = Value
        End Set
    End Property

#End Region

#Region "Eventos"

#Region "Eventos Formulario y Botones"

    Private Sub frmAltaTarifasInternet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CargarDatosCabezeraDatosMaestros()
        ConfigurarCabezeraDatosMaestros()
        ArmarEstructuraDtTarifaUbicaciones()
        ObtenerCargaInicial()
        OcultarColumnas()
        AliniaTitulosColumnas()
        InhabilitarEdicionGrilla()

    End Sub

    Private Sub BtoAgregarFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoAgregarFila.Click

        OperacionSeleccionada = OperacionActiva.NuevaTarifa

        'If Mensajes.Mensaje(MensajePreguntaNuevaTarifa, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        ObtenerSiguienteIDTarifa()
        AgregarNuevaFilaGrilla()
        mDtTarifasUbicaciones.Rows.Clear()
        IndiceGrilla = iugTarifas.ActiveRow.Index
        AliniaTitulosColumnas()
        AliniarDatosCeldas()
        'End If

    End Sub

    Private Sub BtoActualizarFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoActualizarFila.Click

        If Mensajes.Mensaje(MensajePreguntaModificarTarifa, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            OperacionSeleccionada = OperacionActiva.ActualizarTarifa
            IndiceGrilla = iugTarifas.ActiveRow.Index
            'iugTarifas.ActiveRow.Appearance.BackColor = Color.LightSeaGreen
            iugTarifas.ActiveRow.Selected = True
        End If

    End Sub

    Private Sub BtoEliminarFila_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoEliminarFila.Click

        If OperacionSeleccionada = OperacionActiva.NuevaTarifa Then
            If Mensajes.Mensaje(MensajeConfirmacionElimninacionTarifaNueva, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                iugTarifas.ActiveRow.Delete()
                OperacionSeleccionada = OperacionActiva.MostrarTarifa
            End If
            Exit Sub
        End If

        OperacionSeleccionada = OperacionActiva.EliminarTarifa
        IndiceGrilla = iugTarifas.ActiveRow.Index

        If Mensajes.Mensaje(MensajePreguntaEliminacionTarifa, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Dim DrEliminar As DataRow()
            Dim i As Integer
            OTarifaInternet.Id_tarifa = iugTarifas.ActiveRow.Cells("ID_TARIFA").Value
            OTarifaInternet.Borrar()
            OTarifaInternet.pId_tarifa = iugTarifas.ActiveRow.Cells("ID_TARIFA").Value
            OTarifaInternet.EliminarTarifasUbicaciones()

            ObtenerCargaInicial()
            OcultarColumnas()
            AliniaTitulosColumnas()
            AliniarDatosCeldas()
            InhabilitarEdicionGrilla()

            'If Not iugTarifas.ActiveRow.Cells("UBICACION").Value Is DBNull.Value Then
            '    DrEliminar = mDtTarifasUbicaciones.Select("ID_TARIFA =" & CInt(iugTarifas.ActiveRow.Cells("ID_TARIFA").Value))
            '    If DrEliminar.Length > 0 Then
            '        For i = 0 To DrEliminar.Length - 1
            '            mDtTarifasUbicaciones.Rows.Remove(DrEliminar(i))
            '        Next
            '    End If
            'End If

            Mensajes.Mensaje(MensajeConfirmacionEliminacionTarifa, TipoMensaje.Informacion, MessageBoxDefaultButton.Button2)
            OperacionSeleccionada = OperacionActiva.MostrarTarifa
        End If

    End Sub

    Private Sub BtoSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtoSalir.Click

        If Mensajes.Mensaje(MensjaePreguntaSalir, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

#End Region


#Region "Eventos Grilla"

    Private Sub iugTarifas_ClickCellButton1(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugTarifas.ClickCellButton

        Dim IndexError As Integer
        Dim IndexErrorDB As Integer

        If e.Cell.Column.Header.Column.Header.Caption = "Confirmar" Then
            IndexError = Validaciones()

            HabilitarEdicionFila(iugTarifas.ActiveRow.Index)

            Select Case IndexError
                Case TiposErrores.SinUbicaciones
                    MsgBox(MensajeSinUbicaciones, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinTipoFormato
                    MsgBox(MensajeSinTipoFormato, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinFormato
                    MsgBox(MensajeSinFormato, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinModalidadCompra
                    MsgBox(MensajeSinModalidadCompra, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinFechaVigenciaInicio
                    MsgBox(MensajeSinFechaVigenciaInicio, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinFechaVigenciaFin
                    MsgBox(MensajeSinFechaVigenciaFin, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.SinBruto
                    MsgBox(MensajeSinBruto, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.FechaVigenciaInicioMayoraFechaFin
                    MsgBox(MensajeFechaVigenciaInicioMayoraFechaFin, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.FechaVigenciaFinMenoraFechaInicio
                    MsgBox(MensajeFechaVigenciaFinMenoraFechaInicio, MsgBoxStyle.Information)
                    Exit Sub
                Case TiposErrores.OperacionNoSeleccionada
                    MsgBox(MensajeInformacionOperacion, MsgBoxStyle.Information)
                    Exit Sub
            End Select
            IndexErrorDB = Guardar()
            If IndexErrorDB = TiposErrores.TarifaExistenteCargada Then
                MsgBox(MensajeTarifaExistente, MsgBoxStyle.Information)
                iugTarifas.ActiveRow.Selected = True
                Exit Sub
            End If
            InhabilitarEdicionGrilla()
            Select Case OperacionSeleccionada
                Case OperacionActiva.ActualizarTarifa
                    Mensajes.Mensaje(MensajeConfirmacionOkModificarOperacion, TipoMensaje.Informacion, MessageBoxDefaultButton.Button2)
                Case OperacionActiva.NuevaTarifa
                    Mensajes.Mensaje(MensajeConfirmacionOkAltaOperacion, TipoMensaje.Informacion, MessageBoxDefaultButton.Button2)
            End Select
            OperacionSeleccionada = OperacionActiva.MostrarTarifa
        End If

    End Sub

    Private Sub iugTarifas_DoubleClickCell1(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles iugTarifas.DoubleClickCell

        If e.Cell.Column.Header.Column.Header.Caption = "Ubicacion" Then
            Dim OFrmUbicacionInt As New frmFiltrarUbicacionesInt
            OTarifaInternet = New Tarifas_Internet

            With OFrmUbicacionInt
                .IdTarifa = iugTarifas.ActiveRow.Cells("ID_TARIFA").Value
                frmAltaTarifasInternet.Instancia = Me
                'AG revisar ==================================================
                If OperacionSeleccionada = OperacionActiva.ActualizarTarifa Then
                    'OTarifaInternet.pId_tarifa = iugTarifas.ActiveRow.Cells("ID_TARIFA").Value
                    'mDtTarifasUbicaciones = CargarUbicacionesDescripcion(OTarifaInternet.TraerTarifasUbicaciones())
                    If Not iugTarifas.ActiveRow.Cells("UBICACION").Value Is System.DBNull.Value Then
                        mDtTarifasUbicaciones = ObtenerRegistrodUbicacionesAconfirmar(iugTarifas.ActiveRow.Cells("UBICACION").Value, iugTarifas.ActiveRow.Cells("ID_TARIFA").Value)
                        .DtTarifasUbicaciones = mDtTarifasUbicaciones
                    End If
                End If

                If OperacionSeleccionada = OperacionActiva.NuevaTarifa Then
                    .DtTarifasUbicaciones = mDtTarifasUbicaciones
                End If
                '=================================================================
                If OperacionSeleccionada = OperacionActiva.MostrarTarifa Then
                    .TipoApertura = TipoVisualizacion.MostrarSinEditar
                    'OTarifaInternet.pId_tarifa = iugTarifas.ActiveRow.Cells("ID_TARIFA").Value
                    'mDtTarifasUbicaciones = CargarUbicacionesDescripcion(OTarifaInternet.TraerTarifasUbicaciones())
                    If Not iugTarifas.ActiveRow.Cells("UBICACION").Value Is System.DBNull.Value Then
                        mDtTarifasUbicaciones = ObtenerRegistrodUbicacionesAconfirmar(iugTarifas.ActiveRow.Cells("UBICACION").Value, iugTarifas.ActiveRow.Cells("ID_TARIFA").Value)
                        .DtTarifasUbicaciones = mDtTarifasUbicaciones
                    End If
                Else
                    .TipoApertura = TipoVisualizacion.MostrarParaEditar
                End If
                .ShowDialog()
                iugTarifas.ActiveRow.Cells("UBICACION").Value = ObtenerUbicacionesSeleccionadas(iugTarifas.ActiveRow.Cells("ID_TARIFA").Value).ToString
            End With
        End If

        If e.Cell.Column.Header.Column.Header.Caption = "Costo Unit. Bruto" Then
            HabilitarEdicionFila(iugTarifas.ActiveRow.Index)
        End If


    End Sub

    Private Sub iugTarifas_InitializeLayout1(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugTarifas.InitializeLayout

        CambiarNombreColumnas(e)
        CambiarFormatoColumnasDropDownList(e)
        CambiarFormatoColumnasDropCalendario(e)
        CambiarFormatoColumnasMoneda(e)
        CambiarFormatoColumnaBotton(e)
        'iugTarifas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

    End Sub

    Private Function Validaciones() As Integer

        Dim IndexError As Integer = TiposErrores.SinErrores

        If OperacionSeleccionada = OperacionActiva.ActualizarTarifa Or OperacionSeleccionada = OperacionActiva.NuevaTarifa Then

            If Not iugTarifas.ActiveRow Is Nothing Then
                If iugTarifas.ActiveRow.Cells("UBICACION").Value Is DBNull.Value Or iugTarifas.ActiveRow.Cells("UBICACION").Value Is Nothing Then
                    IndexError = TiposErrores.SinUbicaciones
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("ID_TIPO_FORMATO").Value = 0 Or iugTarifas.ActiveRow.Cells("ID_TIPO_FORMATO").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinTipoFormato
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("ID_FORMATO").Value = 0 Or iugTarifas.ActiveRow.Cells("ID_FORMATO").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinFormato
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("ID_TIPO_COMPRA").Value = 0 Or iugTarifas.ActiveRow.Cells("ID_TIPO_COMPRA").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinTipoFormato
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("F_INICIO").Value = Nothing Or iugTarifas.ActiveRow.Cells("F_INICIO").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinFechaVigenciaInicio
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("F_FIN").Value = Nothing Or iugTarifas.ActiveRow.Cells("F_FIN").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinFechaVigenciaFin
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("BRUTO").Value Is DBNull.Value Then
                    IndexError = TiposErrores.SinBruto
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("F_INICIO").Value > iugTarifas.ActiveRow.Cells("F_FIN").Value Then
                    IndexError = TiposErrores.FechaVigenciaInicioMayoraFechaFin
                    Return IndexError
                    Exit Function
                End If

                If iugTarifas.ActiveRow.Cells("F_FIN").Value < iugTarifas.ActiveRow.Cells("F_INICIO").Value Then
                    IndexError = TiposErrores.FechaVigenciaFinMenoraFechaInicio
                    Return IndexError
                    Exit Function
                End If

            End If
        Else
            IndexError = TiposErrores.OperacionNoSeleccionada
            Return IndexError
            Exit Function
        End If

    End Function

#End Region

#End Region

#Region "Metodos"

    Private Sub CargarDatosCabezeraDatosMaestros()

        Me.txtNombreUsuario.Text = EspacioBlanco + Activo.Nombre.ToString.ToUpper
        Me.txtApellidoUsuario.Text = EspacioBlanco + Activo.Apellido1.ToString.ToUpper
        Me.txtDesCliente.Text = EspacioBlanco + Me.DescCliente
        Me.txtDesMedio.Text = EspacioBlanco + Me.DescMedio
        Me.TxtSoporte.Text = EspacioBlanco + Me.DescSoporte
        Me.dtpFecha.Value = Date.Now

    End Sub

    Private Sub ConfigurarCabezeraDatosMaestros()

        'Inabilito los controles de la Cabecera
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtApellidoUsuario.ReadOnly = True
        Me.txtDesCliente.ReadOnly = True
        Me.txtDesMedio.ReadOnly = True
        Me.TxtSoporte.ReadOnly = True
        Me.dtpFecha.ReadOnly = True

        'Color de Fondo de los controles de la Cabecera
        Me.txtNombreUsuario.BackColor = Color.GhostWhite
        Me.txtApellidoUsuario.BackColor = Color.GhostWhite
        Me.txtDesCliente.BackColor = Color.GhostWhite
        Me.txtDesMedio.BackColor = Color.GhostWhite
        Me.TxtSoporte.BackColor = Color.GhostWhite
        Me.dtpFecha.Value = Color.GhostWhite

    End Sub

    Private Sub ObtenerCargaInicial()

        OTarifaInternet = New Tarifas_Internet
        Dim DtTarifasInternet As New DataTable

        With OTarifaInternet
            .Id_cliente = Me.IdCliente
            .Id_soporte = Me.IdSoporte
            If Me.SoloVigentes = True Then
                .FVigenciaTilde = Me.FVigencia
                DtTarifasInternet = .TraerTodosConVigencia()
            Else
                DtTarifasInternet = .TraerTodosSinVigencia()
            End If
        End With

        Me.iugTarifas.DataSource = DtTarifasInternet

        If DtTarifasInternet.Rows.Count = 0 Or DtTarifasInternet Is Nothing Then
            'MsgBox("No se encontraron Tafifas Cargadas, para los Filtros Ingresados", vbInformation, "Carga Tarifas Internet")
        Else
            CargarUbicacionesTextoGrilla(Me.iugTarifas.DataSource)
            PoblarDtActualizarTarifa(DtTarifasInternet)
        End If


    End Sub

    Private Function CargarUbicacionesTextoGrilla(ByVal DtTarifasCargadas As DataTable)

        Dim DrUbicaciones() As DataRow
        Dim o As Integer
        Dim Ubicacion As String
        Dim DtUbicacionTarifas As New DataTable
        OTarifaInternet = New Tarifas_Internet

        For Each RowGrilla As UltraGridRow In Me.iugTarifas.Rows
            Ubicacion = ""
            OTarifaInternet.pId_tarifa = CInt(RowGrilla.Cells("ID_TARIFA").Value)
            DtUbicacionTarifas = OTarifaInternet.TraerTarifasUbicaciones
            For Each Dr As DataRow In DtUbicacionTarifas.Rows
                Ubicacion += ObtenerUbicacionescargarGrilla(CStr(Dr("ID_UBICACION")))
            Next
            If Ubicacion <> "" Then
                RowGrilla.Cells("UBICACION").Value = Ubicacion.Remove(Ubicacion.LastIndexOf("|"), 1).Trim
            End If

        Next

    End Function

    Private Function CargarUbicacionesDescripcion(ByVal DtUbicaciones As DataTable) As DataTable

        Dim DrUbicaciones() As DataRow
        Dim o As Integer
        Dim Ubicacion As String
        Dim DtUbicacionTarifas As New DataTable
        OTarifaInternet = New Tarifas_Internet

        For Each Rregistro As DataRow In DtUbicaciones.Rows
            DrUbicaciones = Activo.DTSeccionesInternetCache.Select("ID_Seccion = '" & Rregistro("ID_UBICACION").ToString() & "'")
            If DrUbicaciones.Length > 0 Then
                Rregistro("Ubicacion_descripcion") = DrUbicaciones(0)("DESCRIPCION").ToString
            End If
        Next

        Return DtUbicaciones

    End Function

    Private Function ObtenerSiguienteIDTarifa() As Integer

        OTarifaInternet = New Tarifas_Internet
        IDTarifaSiguiente = OTarifaInternet.ObtenerSiguienteIDTarifa

    End Function

    Private Sub CambiarNombreColumnas(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        Listas.CambiarTituloColumna(Me.iugTarifas, "UBICACION", "Ubicacion")
        Listas.CambiarTituloColumna(Me.iugTarifas, "ID_TIPO_FORMATO", "Tipo Formato")
        Listas.CambiarTituloColumna(Me.iugTarifas, "ID_FORMATO", "Formato")
        Listas.CambiarTituloColumna(Me.iugTarifas, "ID_TIPO_COMPRA", "Modalidad Compra")
        Listas.CambiarTituloColumna(Me.iugTarifas, "F_INICIO", "F.Inicio Vigencia")
        Listas.CambiarTituloColumna(Me.iugTarifas, "F_FIN", "F.Fin Vigencia")
        Listas.CambiarTituloColumna(Me.iugTarifas, "BRUTO", "Costo Unit. Bruto")

    End Sub

    Private Sub CambiarFormatoColumnasDropDownList(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_TIPO_COMPRA"))
        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_TIPO_FORMATO"))
        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_FORMATO"))

    End Sub

    Private Sub CambiarFormatoColumnasDropCalendario(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoDropDownCalendar(e.Layout.Bands(0).Columns("F_INICIO"))
        AplicarFormatoDropDownCalendar(e.Layout.Bands(0).Columns("F_FIN"))

    End Sub

    Private Sub CambiarFormatoColumnasMoneda(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoCurrency(e.Layout.Bands(0).Columns("BRUTO"))

    End Sub

    Private Sub CambiarFormatoColumnaBotton(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoBotton(e.Layout.Bands(0).Columns("BTOCONFIRMAR"))

    End Sub

    Private Sub OcultarColumnas()

        Listas.OcultarColumnas(Me.iugTarifas, "ID_TARIFA", "ID_SOPORTE", "ID_TIPO_SOPORTE", "ID_CLIENTE")

    End Sub

    Private Sub AnexarColumnas()

        With iugTarifas.DisplayLayout.Bands(0)
            .Columns.Add("BtoConfirmar")
            .Columns("BtoConfirmar").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            .Columns("BtoConfirmar").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("BtoConfirmar").Style = ColumnStyle.Button
            .Columns("BtoConfirmar").CellAppearance.BackColor = System.Drawing.Color.Gray
            .Columns("BtoConfirmar").CellAppearance.ForeColor = System.Drawing.Color.White
            .Columns("BtoConfirmar").Header.Caption = ""
            .Columns("BtoConfirmar").Width = 85
        End With


    End Sub

#Region "Metodos Grilla"

    Private Sub AplicarFormatoCabecera(ByRef pColumna As UltraGridColumn, ByVal pEncabezado As String, Optional ByVal pInd_Fijo As Integer = 0, Optional ByVal pNumerico As Boolean = False)
        pColumna.Header.Caption = pEncabezado
        pColumna.Header.Appearance.TextHAlign = HAlign.Center
        If pInd_Fijo > 0 Then
            pColumna.Width = pInd_Fijo
        End If
        If pNumerico Then
            pColumna.CellAppearance.TextHAlign = HAlign.Right
        End If
    End Sub

    Private Sub AplicarFormatoDropDownList(ByRef pColumna As UltraGridColumn)

        Dim Lista As ValueList

        Select Case pColumna.Key
            Case "ID_TIPO_COMPRA"
                Lista = ObtenerModalidadCompra()
            Case "ID_TIPO_FORMATO"
                Lista = ObtenerTipoFormato()
            Case "ID_FORMATO"
                Lista = ObtenerFormatos()
        End Select

        With pColumna
            .ValueList = Lista
            .Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            .ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Width = 140
        End With
        
    End Sub

    Private Sub AplicarFormatoDropDownCalendar(ByRef pColumna As UltraGridColumn)

        With pColumna
            '.CellActivation = UltraWinGrid.Activation.AllowEdit
            .Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar
            .ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Width = 130
        End With

    End Sub

    Private Sub AplicarFormatoCurrency(ByRef pColumna As UltraGridColumn)

        GrillaFormato.CambiarFormatoColumna(Me.iugTarifas, "bruto", Formato.Moneda)

    End Sub

    Private Sub AplicarFormatoBotton(ByRef pColumna As UltraGridColumn)

        With pColumna
            .ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Style = ColumnStyle.Button
            .CellAppearance.BackColor = System.Drawing.Color.DarkGray
            .CellAppearance.ForeColor = System.Drawing.Color.White
            .Header.Caption = "Confirmar"
            .Width = 95
        End With
        
    End Sub

    Private Sub AliniaTitulosColumnas()

        With iugTarifas.DisplayLayout.Bands(0)
            .Columns("UBICACION").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_TIPO_FORMATO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_FORMATO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_TIPO_COMPRA").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("F_INICIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("F_FIN").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("BRUTO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("BTOCONFIRMAR").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub AliniarDatosCeldas()

        With iugTarifas.DisplayLayout.Bands(0)
            .Columns("UBICACION").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_TIPO_FORMATO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_FORMATO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("ID_TIPO_COMPRA").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("F_INICIO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("F_FIN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("BRUTO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("BTOCONFIRMAR").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Function AgregarNuevaFilaGrilla()

        CargarFilaNuevoDt()
        ObtenerTipoFormato()
        ObtenerFormatos()
        ObtenerSecciones()
        ObtenerModalidadCompra()

    End Function

    Private Function ObtenerUbicacionesSeleccionadas(ByVal IdTarifa As Integer) As String

        Dim Ubicaciones As String
        Dim DrUbicaciones() As DataRow

        DrUbicaciones = mDtTarifasUbicaciones.Select("ID_tarifa = " & IdTarifa)

        If DrUbicaciones.Length > 0 Then
            For i As Integer = 0 To DrUbicaciones.Length - 1

                If i = DrUbicaciones.Length - 1 Then
                    Ubicaciones += DrUbicaciones(i)("ID_UBICACION").ToString + " - " + DrUbicaciones(i)("Ubicacion_DESCRIPCION").ToString
                Else
                    Ubicaciones += DrUbicaciones(i)("ID_UBICACION").ToString + " - " + DrUbicaciones(i)("Ubicacion_DESCRIPCION").ToString + " | "
                End If
            Next
        Else
            Ubicaciones = ""
        End If

        Return Ubicaciones

    End Function

    Private Function ObtenerUbicacionescargarGrilla(ByVal IdSeccion As String) As String

        Dim Ubicaciones As String
        Dim DrUbicaciones() As DataRow

        DrUbicaciones = Activo.DTSeccionesInternetCache.Select("ID_Seccion = '" & IdSeccion & "'")

        If DrUbicaciones.Length > 0 Then
            For i As Integer = 0 To DrUbicaciones.Length - 1
                'If i = DrUbicaciones.Length - 1 Then
                'Ubicaciones += DrUbicaciones(i)("ID_Seccion").ToString + " - " + DrUbicaciones(i)("DESCRIPCION").ToString
                'Else
                Ubicaciones += DrUbicaciones(i)("ID_Seccion").ToString + " - " + DrUbicaciones(i)("DESCRIPCION").ToString + " | "
                'End If
            Next
        Else
            Ubicaciones = ""
        End If

        Return Ubicaciones
    End Function

    Private Sub HabilitarEdicionFila(ByVal FilaIndex As Integer)
        GrillaFormato.HabilitarEdicionColumna(Me.iugTarifas, Activation.AllowEdit, "BRUTO")
    End Sub

    Private Sub InhabilitarEdicionGrilla()
        GrillaFormato.HabilitarEdicionColumna(Me.iugTarifas, Activation.NoEdit, "UBICACION")
    End Sub

#End Region

#Region "Metodos Nueva Fila Grilla"

    Private Sub CargarFilaNuevoDt()

        Dim dtGrilla As New DataTable
        Dim drFilaNueva As DataRow

        dtGrilla = iugTarifas.DataSource
        drFilaNueva = dtGrilla.NewRow()
        drFilaNueva("ID_TARIFA") = IDTarifaSiguiente
        drFilaNueva("ID_TIPO_COMPRA") = 0
        drFilaNueva("ID_FORMATO") = 0
        drFilaNueva("ID_TIPO_FORMATO") = 0
        drFilaNueva("F_INICIO") = Date.Today
        drFilaNueva("F_FIN") = CDate("31/12/" + CStr(CInt(Date.Today.Year.ToString) + 1))
        dtGrilla.Rows.Add(drFilaNueva)
        iugTarifas.DataSource = dtGrilla
        iugTarifas.Rows(dtGrilla.Rows.Count - 1).Activated = True

    End Sub

#End Region

#Region "Metodos Busqueda datos Combos"

    Private Function ObtenerTipoFormato() As ValueList

        Dim DtColocaciones As New DataTable
        OColocaciones = New Colocaciones
        vlistTipoFormato = New ValueList

        OColocaciones.Id_Medio = Me.IdMedio
        DtColocaciones = OColocaciones.ObtenerColocaciones
        vlistTipoFormato.ValueListItems.Add("0", " ")

        If Not DtColocaciones Is Nothing Then
            For Each RowColocaciones As DataRow In DtColocaciones.Rows
                vlistTipoFormato.ValueListItems.Add(RowColocaciones("ID_COLOCACION"), RowColocaciones("DESCRIPCION"))
            Next
        End If

        Return vlistTipoFormato

    End Function

    Private Function ObtenerFormatos() As ValueList

        Dim DtFormatos As New DataTable
        OFormatos = New Formatos
        vlistFormatos = New ValueList

        OFormatos.Id_Medio = Me.IdMedio
        DtFormatos = OFormatos.ObtenerFormatos
        vlistFormatos.ValueListItems.Add(0, " ")

        If Not DtFormatos Is Nothing Then
            For Each RowFormato As DataRow In DtFormatos.Rows
                vlistFormatos.ValueListItems.Add(RowFormato("ID_ANUNCIO"), RowFormato("DESCRIPCION"))
            Next
        End If

        Return vlistFormatos

    End Function

    Private Function ObtenerSecciones() As DataTable

        Dim OMaestro As New Maestros

        If Activo.DTSeccionesInternetCache Is Nothing Then
            Activo.DTSeccionesInternetCache = OMaestro.seccionesObtener(Me.IdMedio)
        End If

        Return Activo.DTSeccionesInternetCache

    End Function

    Private Function ObtenerModalidadCompra() As ValueList

        Dim DtModalidadCompras As New DataTable
        OTarifaInternet = New Tarifas_Internet
        vlistModalidadCompra = New ValueList

        DtModalidadCompras = OTarifaInternet.TraerModalidadCompra()
        vlistModalidadCompra.ValueListItems.Add(0, " ")

        If Not DtModalidadCompras Is Nothing Then
            For Each RowModalidadCompras As DataRow In DtModalidadCompras.Rows
                vlistModalidadCompra.ValueListItems.Add(RowModalidadCompras("ID_TIPO_COMPRA"), RowModalidadCompras("DESCRIPCION"))
            Next
        End If

        Return vlistModalidadCompra

    End Function

    Private Function ObtenerRegistrodUbicacionesAconfirmar(ByVal registro As String, ByVal IdTarifa As Integer) As DataTable

        Dim Dt As New DataTable
        Dim TramaSeparadaNivel1() As String
        Dim TramaSeparadaNivel2() As String
        Dim i As Integer
        Dim Dr As DataRow

        Dt.Columns.Add("ID_TARIFA", GetType(Integer))
        Dt.Columns.Add("ID_UBICACION", GetType(Integer))
        Dt.Columns.Add("UBICACION_DESCRIPCION", GetType(String))

        TramaSeparadaNivel1 = registro.Split("|")

        If TramaSeparadaNivel1.Length > 0 Then
            For i = 0 To TramaSeparadaNivel1.Length - 1
                Dr = Dt.NewRow()
                TramaSeparadaNivel2 = TramaSeparadaNivel1(i).Split("-")
                If TramaSeparadaNivel2.Length > 0 Then
                    Dr("ID_TARIFA") = IdTarifa
                    If Not Dr("ID_UBICACION") Is System.DBNull.Value Then
                        Dr("ID_UBICACION") = Int(TramaSeparadaNivel2(0).Trim)
                        Dr("UBICACION_DESCRIPCION") = TramaSeparadaNivel2(1).Trim
                    Else
                        Dr("ID_UBICACION") = 0
                        Dr("UBICACION_DESCRIPCION") = ""
                    End If
                    
                    Dt.Rows.Add(Dr)
                End If
            Next

        End If

        Return Dt
    End Function

#End Region

#Region "Metodos Dts"

    Private Sub ArmarEstructuraDtTarifaUbicaciones()

        With mDtTarifasUbicaciones
            .Columns.Add("ID_TARIFA", GetType(Integer))
            .Columns.Add("ID_UBICACION", GetType(Integer))
            .Columns.Add("UBICACION_DESCRIPCION", GetType(String))
        End With
    End Sub

    Private Function PoblarDtActualizarTarifa(ByVal DtDatosTarifas As DataTable) As DataTable

        For Each Rregistro As DataRow In DtDatosTarifas.Rows
            Me.DtActualizarTarifa.ImportRow(Rregistro)
        Next

    End Function

#End Region

#Region "Metodos Almacenaciento de Datos DB"

    Private Function Guardar() As Integer

        Dim DRowsUbicaciones() As DataRow
        Dim i As Integer
        OTarifaInternet = New Tarifas_Internet
        Dim IndiceRespuestaOperacionDB As Integer

        '======== Datos para insertar en la Tabla TARIFAS_INTERNET ====================================
        Dim ID_TARIFA As Integer = CInt(iugTarifas.ActiveRow.Cells("ID_TARIFA").Value)
        Dim UBICACION As String = CStr(iugTarifas.ActiveRow.Cells("UBICACION").Value)
        Dim ID_TIPO_FORMATO As Integer = CInt(iugTarifas.ActiveRow.Cells("ID_TIPO_FORMATO").Value)
        Dim ID_FORMATO As Integer = CInt(iugTarifas.ActiveRow.Cells("ID_FORMATO").Value)
        Dim ID_TIPO_COMPRA As Integer = CInt(iugTarifas.ActiveRow.Cells("ID_TIPO_COMPRA").Value)
        Dim ID_SOPORTE As Integer = Me.IdSoporte
        Dim ID_TIPO_SOPORTE As Integer = -1
        Dim ID_CLIENTE As Integer = Me.IdCliente
        Dim F_INICIO As Date = CDate(iugTarifas.ActiveRow.Cells("F_INICIO").Value)
        Dim F_FIN As Date = CDate(iugTarifas.ActiveRow.Cells("F_FIN").Value)
        Dim BRUTO As Double = CDbl(iugTarifas.ActiveRow.Cells("BRUTO").Value)
        '======== Datos para insertar en la Tabla TARIFAS_INTERNET_UBICACIONES ========================

        Select Case OperacionSeleccionada

            Case OperacionActiva.NuevaTarifa 'Verifico la existencia de la tarifa nueva para esos parametros ingresados
                ''AG 02/11/2013 === Comento este codigo para quitar la validacion al momento del INSERT funciona
                'With OTarifaInternet
                '    .Id_soporte = ID_SOPORTE
                '    .Id_cliente = ID_CLIENTE
                '    .F_inicio = F_INICIO
                '    .F_fin = F_FIN
                '    If .VerificarTarifaExistente() Then
                '        IndiceRespuestaOperacionDB = TiposErrores.TarifaExistenteCargada
                '        Return IndiceRespuestaOperacionDB
                '        Exit Function
                '    End If
                'End With

                With OTarifaInternet
                    .Id_Tipo_Formato = ID_TIPO_FORMATO
                    .Id_Formato = ID_FORMATO
                    .Id_Tipo_Compra = ID_TIPO_COMPRA
                    .Id_soporte = ID_SOPORTE
                    .Id_cliente = ID_CLIENTE
                    .Id_Tipo_soporte = ID_TIPO_SOPORTE
                    .F_inicio = F_INICIO
                    .F_fin = F_FIN
                    .Bruto = BRUTO
                    .IdUsuario = Activo.IDUsuarioMMS
                    ID_TARIFA = .Agregar()
                End With

                If ID_TARIFA > 0 Then
                    With OTarifaInternet
                        DRowsUbicaciones = mDtTarifasUbicaciones.Select("ID_TARIFA =" & CInt(iugTarifas.ActiveRow.Cells("ID_TARIFA").Value))
                        If DRowsUbicaciones.Length > 0 Then
                            For i = 0 To DRowsUbicaciones.Length - 1
                                .pId_tarifa = ID_TARIFA
                                .pIdUbicacion = CInt(DRowsUbicaciones(i)("ID_UBICACION"))
                                .pIdUsuario = Activo.IDUsuarioMMS
                                .AgregarTarifasUbicaciones()
                                DRowsUbicaciones(i)("ID_TARIFA") = ID_TARIFA 'Actualizo el IdTarifa Temporal por el nuevo de la Base De Datos
                            Next
                        End If
                    End With
                End If
                'Reemplazo los ID_TARIFA Temporales por los REALES y NUEVOS
                iugTarifas.ActiveRow.Cells("ID_TARIFA").Value = ID_TARIFA

            Case OperacionActiva.ActualizarTarifa
                'AG 02/11/2013 === Comento este codigo para quitar la validacion al momento del UPdate funciona
                'With OTarifaInternet 'Verifico la existencia de la tarifa nueva para esos parametros ingresados
                '    .Id_soporte = ID_SOPORTE
                '    .Id_cliente = ID_CLIENTE
                '    .F_inicio = F_INICIO
                '    .F_fin = F_FIN
                '    If .VerificarTarifaExistente() Then
                '        IndiceRespuestaOperacionDB = TiposErrores.TarifaExistenteCargada
                '        Return IndiceRespuestaOperacionDB
                '        Exit Function
                '    End If
                'End With
                '======================================================================================================
                With OTarifaInternet
                    .Id_tarifa = ID_TARIFA
                    .Id_Tipo_Formato = ID_TIPO_FORMATO
                    .Id_Formato = ID_FORMATO
                    .Id_Tipo_Compra = ID_TIPO_COMPRA
                    .Id_soporte = ID_SOPORTE
                    .Id_cliente = ID_CLIENTE
                    .Id_Tipo_soporte = ID_TIPO_SOPORTE
                    .F_inicio = F_INICIO
                    .F_fin = F_FIN
                    .Bruto = BRUTO
                    .IdUsuario = Activo.IDUsuarioMMS
                    .Modificar()
                End With
                DRowsUbicaciones = mDtTarifasUbicaciones.Select("ID_TARIFA =" & CInt(iugTarifas.ActiveRow.Cells("ID_TARIFA").Value))
                If DRowsUbicaciones.Length > 0 Then
                    OTarifaInternet.Id_tarifa = ID_TARIFA
                    OTarifaInternet.EliminarTarifasUbicaciones()
                    For i = 0 To DRowsUbicaciones.Length - 1
                        OTarifaInternet.pId_tarifa = ID_TARIFA
                        OTarifaInternet.pIdUbicacion = CInt(DRowsUbicaciones(i)("ID_UBICACION"))
                        OTarifaInternet.pIdUsuario = Activo.IDUsuarioMMS
                        OTarifaInternet.AgregarTarifasUbicaciones()
                    Next
                End If
        End Select

    End Function

#End Region


#End Region

#Region "Enums Empleados"

    Public Enum OperacionActiva
        NuevaTarifa = 1
        ActualizarTarifa = 2
        EliminarTarifa = 4
        MostrarTarifa = 6
    End Enum

    Public Enum TiposErrores
        SinErrores = 0
        SinUbicaciones = 1
        SinTipoFormato = 2
        SinFormato = 3
        SinModalidadCompra = 4
        SinBruto = 5
        SinFechaVigenciaInicio = 6
        SinFechaVigenciaFin = 7
        FechaVigenciaInicioMayoraFechaFin = 8
        FechaVigenciaFinMenoraFechaInicio = 9
        OperacionNoSeleccionada = 10
        TarifaExistenteCargada = 11
    End Enum

    Public Enum TipoVisualizacion
        MostrarSinEditar = 1
        MostrarParaEditar = 2
    End Enum

    Public Enum RespuestaOperacionDB
        OperacionOkDB = 1
        OperacionNoOkDB = 2
    End Enum

#End Region

#Region "Metodos y Eventos sin Utilizacion"

    Private Sub iugTarifas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iugTarifas.KeyDown

        'If Me.iugTarifas.ActiveCell Is Nothing Then
        '    Exit Sub
        'End If

        'Dim EnEdicion As Boolean = Me.iugTarifas.ActiveCell.IsInEditMode

        'If Not Me.iugTarifas.ActiveRow Is Nothing AndAlso Me.iugTarifas.ActiveRow.Selected Then

        '    If e.KeyCode = Keys.Delete Then
        '        If Not Me.iugTarifas.ActiveCell Is Nothing Then
        '            If Not Me.iugTarifas.ActiveCell.IsInEditMode Then
        '                Me.iugTarifas.ActiveCell.Value = ""
        '            End If
        '        End If
        '    End If
        'End If

        'Select Case e.KeyValue

        '    Case Keys.Delete
        '        Me.iugTarifas.ActiveCell.Value = 0

        '    Case Keys.Enter, Keys.F2
        '        e.Handled = True

        '        If EnEdicion Then
        '            Me.iugTarifas.PerformAction(ExitEditMode, False, False)
        '        Else
        '            Me.iugTarifas.PerformAction(EnterEditMode, False, False)
        '        End If
        '        Me.iugTarifas.UpdateData()

        'End Select
    End Sub

    Private Sub iugTarifas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugTarifas.MouseUp

        'Dim aUIElement As Infragistics.Win.UIElement
        'Try
        '    aUIElement = iugTarifas.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
        '    Dim aRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        '    aRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
        '    If Not aRow Is Nothing Then
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    ' no hago nada, lo pongo porque si toca en algun momento los desplazamientos de la grilla, da error y no se modifica nada
        'End Try

        'If Me.iugTarifas.ActiveRow.Cells Is Nothing Then ' esta seleccionado una fila que esta agrupada
        '    'iugTarifas.ActiveRow.RowSelectorAppearance.BackColor = Color.LightSalmon
        'End If

    End Sub

#End Region


End Class
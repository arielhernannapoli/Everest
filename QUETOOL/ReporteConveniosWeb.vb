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

Public Class ReporteConveniosWeb

#Region "Propiedades"

    Dim GrillAdmin As GrillAdmin
    Dim GrillaFormato As New GrillaFormato

#End Region

#Region "Eventos"


    Private Sub ReporteConveniosWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Call BuscarMedios()
            Call CargarEstados()

            cboEstado.SelectedIndex = 0
        Catch ex As Exception
            Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim Cliente As String = txtCodCliente.Text.Trim
        Dim Medio As String = TxtCodMedio.Text.Trim
        Dim Soporte As String = TxtCodSoporte.Text.Trim
        Dim idEstado As Integer

        Dim ObConvevios As New Convenios
        Dim DtResultado As DataTable

        'Filtros Obligatorios ====================================================
        If Cliente = String.Empty Then
            Mensaje("Debe seleccionar un Cliente y Tipo de Vigencia Obligatorios.", TipoMensaje.Informacion)
            Exit Sub
        End If
        '=========================================================================

        'Filtros Optativos + los Obligatorios =========================================
        If Medio = String.Empty Then
            Medio = -1
        End If

        If Soporte = String.Empty Then
            Soporte = -1
        End If

        If Me.cboestado.SelectedItem Is Nothing OrElse Me.cboestado.SelectedItem.DataValue Is Nothing Then
            idEstado = 2
        Else
            idEstado = CInt(Me.cboestado.Value("id_estado"))
        End If


        Me.uigGrillaConvenios.DataSource = Nothing
        Me.txtregistrosCantidad.Text = ""

        DtResultado = ObConvevios.ObtenerReporteConveniosWeb(Cliente, Medio, Soporte, CDate(Me.dtpFVigencia.Value), idEstado)

        If DtResultado.Rows.Count > 0 Then

            DtResultado = FiltrarXTipoSoporte(DtResultado)
            Me.txtregistrosCantidad.Text = DtResultado.Rows.Count.ToString()
            Me.uigGrillaConvenios.DataSource = DtResultado
            AplicarFormatoGrilla()
            AplicarFormatoCeldas()
            CambiarNombreColumnas()
            AliniaTitulosColumnas()
            AliniarDatosCeldas()
            GrillaFormato.AcivarOperacion(uigGrillaConvenios)
            GrillaFormato.AutoAjustarColumnas(Me.uigGrillaConvenios)
            CambiarColorCelda()
        Else
            MsgBox("No se encontraron encontraron registros, para esos filtros seleccionados.", MsgBoxStyle.Information, "Everest")
            Me.txtregistrosCantidad.Text = ""
        End If
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Me.uigGrillaConvenios.DataSource = Nothing
        Me.txtregistrosCantidad.Text = ""
    End Sub

    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click
        ExportarExcel()
    End Sub

    Private Sub lblDesSoporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDesSoporte.Click
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

    Private Sub lblDesCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDesCliente.Click
        Dim Busqueda As New frmBuscar
        Busqueda.CargarFormulario(SeccionActiva.Cliente, txtCliente, txtCodCliente, "id_cliente", "descripcion", "Código", "Cliente")
        Busqueda.ShowDialog()
    End Sub

    Private Sub txtCodCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCliente.TextChanged
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty
        If TxtCodMedio.Text.Trim <> String.Empty Then
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
        Else
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        End If

    End Sub

    Private Sub txtCodCliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCliente.Validated
        Dim CodigoCliente As String = txtCodCliente.Text.Trim

        If CodigoCliente <> "" Then
            Dim Usu As New Usuario
            Try

                txtCliente.Text = Usu.ObtenerDescripcion(CodigoCliente)
                If txtCliente.Text = String.Empty Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodCliente.Text = String.Empty
                    txtCodCliente.Select()
                    Exit Sub
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

    Private Sub TxtCodMedio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodMedio.LostFocus
        Dim CodMedio As String = TxtCodMedio.Text.Trim

        If CodMedio <> String.Empty Then
            Call Combo_Position(cboMedio, "ID_MEDIO", CodMedio)
            If cboMedio.SelectedItem Is Nothing OrElse cboMedio.SelectedItem.DataValue Is Nothing Then
                MsgBox("El código de medio no existe.", MsgBoxStyle.Information)
                TxtCodSoporte.ReadOnly = True
                lblDesSoporte.Enabled = False
                TxtCodMedio.Text = String.Empty
                TxtCodMedio.Focus()
            Else
                TxtCodSoporte.ReadOnly = False
                lblDesSoporte.Enabled = True
                cboTipoSoporte.ReadOnly = False
                Me.SelectNextControl(cboMedio, True, True, True, True)
            End If
        Else
            cboMedio.SelectedIndex = 0
        End If
    End Sub

    Private Sub TxtCodMedio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodMedio.TextChanged
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty

        If TxtCodMedio.Text.Trim <> String.Empty Then
            TxtCodSoporte.ReadOnly = False
            lblDesSoporte.Enabled = True
        Else
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        End If
        'Call InicializarControles()
    End Sub

    Private Sub cboMedio_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMedio.SelectionChanged
        If cboMedio.SelectedItem Is Nothing OrElse cboMedio.SelectedItem.DataValue Is Nothing Then
            TxtCodMedio.Text = String.Empty
            'TxtCodSoporte.ReadOnly = True
            'lblDesSoporte.Enabled = False
            'cboTipoSoporte.ReadOnly = True
        Else
            TxtCodMedio.Text = cboMedio.SelectedItem.DataValue("ID_MEDIO")
            'TxtCodSoporte.ReadOnly = False
            'lblDesSoporte.Enabled = True
            cboTipoSoporte.ReadOnly = False

            Call CargarTipoSoporte(cboMedio.SelectedItem.DataValue("ID_MEDIO"))
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

    Private Sub cboTipoSoporte_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.SelectionChanged
        TxtCodSoporte.Text = String.Empty
        TxtSoporte.Text = String.Empty
        If cboTipoSoporte.SelectedItem Is Nothing OrElse cboTipoSoporte.SelectedItem.DataValue Is Nothing Then
            TxtCodSoporte.ReadOnly = True
            lblDesSoporte.Enabled = False
        Else
            'TxtCodSoporte.ReadOnly = False
            'lblDesSoporte.Enabled = True
        End If
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

        End With

    End Sub

    Private Function AplicarFormatoGrilla()

        GrillaFormato.HabilitarFiltro(Me.uigGrillaConvenios, DefaultableBoolean.True)
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_ESTADO", "usuario")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "id_medio", "Medio", "SOPORTE", "id_cliente", "CLIENTE", "id_producto", "PRODUCTO", "cod_convenio")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "Fecha Inicio", "Fecha Fin", "Detalle", "PARTICIPACION", "PROGRAMA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_VENTA_1", "DESC_VENTA_2", "DESC_VENTA_3", "DESC_VENTA_4", "DESC_VENTA_5")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_COMPRA_1", "DESC_COMPRA_2", "DESC_COMPRA_3", "DESC_COMPRA_4", "DESC_COMPRA_5")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "DESC_EXTRA_1", "DESC_EXTRA_2", "IMP_NETO_VENTA", "IMP_NETO_COMPRA", "OBS_VENTA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "OBS_COMPRA", "OBS_EXTRA", "OBS_FINANZAS", "HORA_DESDE", "HORA_HASTA", "SEMANA")
        GrillaFormato.HabilitarEdicionColumna(Me.uigGrillaConvenios, Activation.NoEdit, "COD_CONV_TARIFA", "FECHA_MODIF", "USER_MODIF", "ID_CONVENIO", "TIPO_CONVENIO", "TCONFIDENCIAL")

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

        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "DESC_ESTADO", "Estado")
        Listas.CambiarTituloColumna(Me.uigGrillaConvenios, "usuario", "Usuario")
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

    End Function

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

    Private Sub BuscarMedios()

        Dim Medios As New Soportes
        Dim dtMedio As DataTable

        dtMedio = Medios.ObtenerMediosConvenios
        Call Combo_Load(cboMedio, dtMedio, "Descripcion", False)

    End Sub

    Private Sub CargarTipoSoporte(ByVal pIdMedio As Integer)

        Dim TS As New Tipos_soporte
        Dim TSoportes As DataTable

        TS.Id_medio = pIdMedio
        TSoportes = TS.TraerTipoSoporteMedio
        Call Combo_Load(cboTipoSoporte, TSoportes, "Descripcion", False)

    End Sub

    Private Sub CargarEstados()

        Dim OConvenio As New Convenios
        Dim DtEstados As DataTable

        DtEstados = OConvenio.ObtenerEstadosConvenios()
        Call Combo_Load(cboestado, DtEstados, "Desc_estado", False)

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

        'If pCombo.Items.Count <> 0 Then
        '    pCombo.SelectedIndex = 0
        'End If

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

    Private Sub CambiarColorCelda()

        For Each b As UltraGridBand In Me.uigGrillaConvenios.DisplayLayout.Bands
            Dim i As Integer
            For i = 0 To Me.uigGrillaConvenios.Rows.Count - 1
                With Me.uigGrillaConvenios.Rows(i)
                    .Cells("ID_MEDIO").Appearance.BackColor = Color.Beige
                    .Cells("SOPORTE").Appearance.BackColor = Color.Beige
                    .Cells("CLIENTE").Appearance.BackColor = Color.Beige
                    .Cells("PRODUCTO").Appearance.BackColor = Color.Beige
                    .Cells("ID_CONVENIO").Appearance.BackColor = Color.Beige
                    .Cells("Fecha Fin").Appearance.BackColor = Color.Beige
                    .Cells("PARTICIPACION").Appearance.BackColor = Color.Beige
                    .Cells("DESC_VENTA_1").Appearance.BackColor = Color.Beige
                    .Cells("DESC_VENTA_3").Appearance.BackColor = Color.Beige
                    .Cells("DESC_VENTA_5").Appearance.BackColor = Color.Beige
                    .Cells("DESC_COMPRA_1").Appearance.BackColor = Color.Beige
                    .Cells("DESC_COMPRA_3").Appearance.BackColor = Color.Beige
                    .Cells("DESC_COMPRA_5").Appearance.BackColor = Color.Beige
                    .Cells("DESC_EXTRA_2").Appearance.BackColor = Color.Beige
                    .Cells("IMP_NETO_COMPRA").Appearance.BackColor = Color.Beige
                    .Cells("OBS_COMPRA").Appearance.BackColor = Color.Beige
                    .Cells("OBS_FINANZAS").Appearance.BackColor = Color.Beige
                    .Cells("HORA_DESDE").Appearance.BackColor = Color.Beige
                    .Cells("COD_CONV_TARIFA").Appearance.BackColor = Color.Beige
                    .Cells("USER_MODIF").Appearance.BackColor = Color.Beige
                    .Cells("TCONFIDENCIAL").Appearance.BackColor = Color.Beige
                End With
            Next
        Next

    End Sub

    Private Function FiltrarXTipoSoporte(ByVal resultado As DataTable)

        Dim DtFinal As New DataTable
        Dim DtFinalTipoSoporte As New DataTable
        Dim RowFinalTipoSoporte() As DataRow
        Dim RowFinalSoporte() As DataRow

        Dim Medio As String = TxtCodMedio.Text.Trim
        Dim Soporte As String = TxtCodSoporte.Text.Trim
        Dim TSoporte As String
        Dim Filter As String

        If Not cboTipoSoporte.SelectedItem Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue Is Nothing AndAlso Not cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte") Is DBNull.Value Then
            TSoporte = cboTipoSoporte.SelectedItem.DataValue("Id_Tipo_Soporte").ToString().Trim
            Filter = "id_medio = " & Medio & " and cod_tipo_soporte = " & TSoporte
        End If

        If Filter <> "" Then
            DtFinal = resultado.Clone()
            RowFinalTipoSoporte = Activo.DTSoportesCache.Select(Filter)

            For i As Integer = 0 To RowFinalTipoSoporte.Count - 1
                RowFinalSoporte = resultado.Select("id_medio = " & RowFinalTipoSoporte(i)("id_medio") & "and id_soporte = " & RowFinalTipoSoporte(i)("id_soporte"))
                If RowFinalSoporte.Length > 0 Then
                    For e As Integer = 0 To RowFinalSoporte.Count - 1
                        DtFinal.Rows.Add(RowFinalSoporte(e).ItemArray)
                    Next
                End If
            Next
        Else
            DtFinal = resultado
        End If

        'If DtFinal.Rows.Count > 0 Then
        '    DtFinal = QuitarDuplicados(DtFinal)
        'End If


        Return DtFinal

    End Function

#End Region

End Class
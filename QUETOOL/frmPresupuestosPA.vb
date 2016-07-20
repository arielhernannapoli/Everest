Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.Text
Imports Framework.Mensajes
Imports Framework
Imports MSL
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System
Imports System.Linq

Public Class frmPresupuestosPA

#Region "Variables"

    Dim mAnioPauta, mMesPauta, mPresupuestoPC, mIdMedio As Integer
    Dim mDtSoportesPauta As New DataTable
    Dim mDtPresupuestoPA As New DataTable
    Dim DtPresupuestoMMSPA As New DataTable
    Dim mDtAvisosEnvioCompras As New DataTable
    Dim mDtAvisosEnvioComprasCache As New DataTable
    Dim mDtPCPAAsociadoFinal As New DataTable
    Dim mDtPCPAExistente As New DataTable
    Dim OSoporte As New Soportes
    Dim GrillaFormato As New GrillaFormato
    Dim OEnvioCompras As Envio_Compras
    Dim DtPCPASeleccionados As New DataTable
    Dim DtExistentes As New DataTable
    Dim mIdCampana As Integer
    Dim mIdsubCampana As Integer
    Dim mDtFiltroSoporte As New DataTable
    Dim mNoActualizar As Boolean
    Dim mControl As Boolean

#End Region

#Region "Propiedades"

    Public Property NoActualizar() As Boolean
        Get
            Return mNoActualizar
        End Get
        Set(ByVal value As Boolean)
            mNoActualizar = value
        End Set

    End Property

    Public Property IdCampana() As Integer
        Get
            Return mIdCampana
        End Get
        Set(ByVal value As Integer)
            mIdCampana = value
        End Set

    End Property

    Public Property IdSubCampana() As Integer
        Get
            Return mIdsubCampana
        End Get
        Set(ByVal value As Integer)
            mIdsubCampana = value
        End Set

    End Property

    Public Property IdMedio() As Integer
        Get
            Return mIdMedio
        End Get
        Set(ByVal value As Integer)
            mIdMedio = value
        End Set

    End Property

    Public Property MesPauta() As Integer
        Get
            Return mMesPauta
        End Get
        Set(ByVal value As Integer)
            mMesPauta = value
        End Set
    End Property

    Public Property AnioPauta() As Integer
        Get
            Return mAnioPauta
        End Get
        Set(ByVal value As Integer)
            mAnioPauta = value
        End Set
    End Property

    Public Property PresupuestoPC() As Integer
        Get
            Return mPresupuestoPC
        End Get
        Set(ByVal value As Integer)
            mPresupuestoPC = value
        End Set
    End Property

    Public Property DtPCPAExistente() As DataTable
        Get
            Return mDtPCPAExistente
        End Get
        Set(ByVal value As DataTable)
            mDtPCPAExistente = value
        End Set
    End Property

    Public Property DtSoportesPauta() As DataTable
        Get
            Return mDtSoportesPauta
        End Get
        Set(ByVal value As DataTable)
            mDtSoportesPauta = value
        End Set
    End Property

    Public Property DtPCPAAsociadoFinal() As DataTable
        Get
            Return mDtPCPAAsociadoFinal
        End Get
        Set(ByVal value As DataTable)
            mDtPCPAAsociadoFinal = value
        End Set
    End Property

    Public Property DtPresupuestoPA() As DataTable
        Get
            Return mDtPresupuestoPA
        End Get
        Set(ByVal value As DataTable)
            mDtPresupuestoPA = value
        End Set
    End Property

    Public Property DtAvisosEnvioCompras() As DataTable
        Get
            Return mDtAvisosEnvioCompras
        End Get
        Set(ByVal value As DataTable)
            mDtAvisosEnvioCompras = value
        End Set
    End Property


    Public Property DtFiltroSoporte() As DataTable
        Get
            Return mDtFiltroSoporte
        End Get
        Set(ByVal value As DataTable)
            mDtFiltroSoporte = value
        End Set
    End Property


#End Region
    
#Region "Eventos"

    Private Sub frmPresupuestosPA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ArmarEstructuraDtDtPCPASeleccionados()
        'DtFiltroSoporte = CalcularTotalesXSoporte(DtAvisosEnvioCompras)
        iugPautaSoporte.DataSource = DtFiltroSoporte
        FormatearGrillaPresupuestoPC()
        OEnvioCompras = New Envio_Compras
        If Me.NoActualizar = False Then
            DtExistentes = OEnvioCompras.ObtenerPACargadosConcatenadosTemp(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, 0, 0, 0, 0, 0, Me.IdMedio, 1)
            If DtExistentes.Rows.Count = 0 Then
                DtExistentes = OEnvioCompras.ObtenerPACargadosConcatenados(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, 0, 0, 0, 0, 0, Me.IdMedio, 1)
            End If
            DtExistentes.Columns.Add("Autorizado", GetType(Boolean))
            ActualizarSaldoDisponibles() 'Revisar bien esta actualizacion automatica de saldos disponibles
            CargarDtSeleccionados(DtExistentes)

        Else
            DtExistentes = OEnvioCompras.ObtenerPACargadosConcatenados(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, 0, 0, 0, 0, 0, Me.IdMedio, 1)
            DtExistentes.Columns.Add("Autorizado", GetType(Boolean))
            ActualizarSaldoDisponibles() 'Revisar bien esta actualizacion automatica de saldos disponibles
            CargarDtSeleccionados(DtExistentes)
        End If

        Me.lblinversion.Text = "Inversion Seleccionada : " & AnioPauta.ToString
        If DtFiltroSoporte.Rows.Count > 0 Then
            Me.txttinversion.Text = DtFiltroSoporte.Compute("Sum(TotalSoporteEnvio)", "ANIO=" & CInt(AnioPauta))
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FilaNueva As DataRow
        Dim Fila As DataRow
        Dim CodPresupuestoPC As Integer
        Dim anio, mes, CodSoporte As Integer
        Dim Rows() As DataRow
        Dim MensajeConfirmacion, MensajeYaExistente, MensajeNada, MensajeEliminado As String
        Dim ControlMensaje As Integer = 0

        MensajeConfirmacion = "Se confirmado la seleccion del P.A, para el soporte seleccionado. "
        MensajeYaExistente = "Ya existe un Presupuesto P.A, para este soporte RELACIONADO y CONFIRMADO. "
        MensajeNada = "Debe seleccionar un Presupuesto P.A, para el soporte. "
        MensajeEliminado = "Se elimino la RELACION y CONFIRMACION, del presupuesto P.A asociado al soporte. "

        'AG 22/07/2013 ===============================
        'Valido si se destildo un presupuesto ya cargado
        For Each RowPresupuestoEliminar As UltraGridRow In uigpanticipado.Rows
            If RowPresupuestoEliminar.Cells("SelPA").Value = False Then
                Rows = DtPCPASeleccionados.Select("PresupuestoPC = " & CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value) & " AND PresupuestoPA = " & RowPresupuestoEliminar.Cells("CodPresupuestoPA").Value & " AND CodSoporte = " & CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value) & " AND mes = " & CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)) 'Agregar cod_soporte
                If Rows.Length = 1 Then ' Se encuentra y se elimina 
                    DtPCPASeleccionados.Rows.Remove(Rows(0))
                    RowPresupuestoEliminar.Cells("SelPA").Value = False
                    ControlMensaje = 4
                End If
            End If
        Next
        '===============================================================

        For Each RowPresupuesto As UltraGridRow In uigpanticipado.Rows
            If RowPresupuesto.Cells("SelPA").Value = True Then
                If DtPCPASeleccionados.Rows.Count = 0 Then 'Esta Vacio
                    anio = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("anio").Value)
                    mes = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)
                    CodSoporte = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value)
                    CodPresupuestoPC = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
                    FilaNueva = DtPCPASeleccionados.NewRow
                    FilaNueva("codCompania") = CInt(Activo.CodCampaniaActualMms)
                    FilaNueva("codCampana") = Me.IdCampana
                    FilaNueva("codSubCampana") = Me.IdSubCampana
                    FilaNueva("PresupuestoPA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
                    FilaNueva("PresupuestoPC") = CodPresupuestoPC
                    FilaNueva("anio") = anio
                    FilaNueva("mes") = mes
                    FilaNueva("CodSoporte") = CodSoporte
                    FilaNueva("SaldoPAPermitido") = RowPresupuesto.Cells("Saldo").Value
                    FilaNueva("SaldoPCEnvio") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporteEnvio").Value
                    DtPCPASeleccionados.Rows.Add(FilaNueva)
                    RowPresupuesto.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
                    RowPresupuesto.Cells("SelPA").Value = True
                    'GrillaFormato.HabilitarCelda(RowPresupuesto.Cells("SelPA"), Activation.NoEdit)
                    ' RowPresupuesto.Cells("SelPA").Activation = Activation.Disabled
                    ControlMensaje = 1    
                    'AG =============================== PROBAR ESTO ULTIMO AGREGADO ANTES DE QUE SE CAIGA LA BASE DE TEST
                    ' COMENTO TODO ESTE CODIGO PORQUE PINCHA Y NO SE PARA QUE SIRVE. REVISAR!!! (AN 07-09-2015)
                    'Fila = DtExistentes.NewRow
                    'Fila("COD_COMPANIA") = CInt(Activo.CodCampaniaActualMms)
                    'Fila("COD_CAMPANA") = Me.IdCampana
                    'Fila("COD_SUBCAMPANA") = Me.IdSubCampana
                    'Fila("COD_PRESUPUESTO_PC") = CodPresupuestoPC
                    'Fila("COD_PRESUPUESTO_PA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
                    'Fila("ANO") = anio
                    'Fila("MES") = mes
                    'Fila("COD_SOPORTE") = CodPresupuestoPC
                    'Fila("SALDO_PA_PERMITIDO") = RowPresupuesto.Cells("Saldo").Value
                    'Fila("SALDO_PC_ENVIO") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporteEnvio").Value
                    'DtExistentes.Rows.Add(Fila)
                    '================================
                Else
                    CodPresupuestoPC = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
                    anio = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("anio").Value)
                    mes = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)
                    CodSoporte = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value)
                    Rows = DtPCPASeleccionados.Select("PresupuestoPC = " & CodPresupuestoPC & " AND CodSoporte = " & CodSoporte & " AND mes = " & mes & " AND anio = " & anio)
                    If Rows.Length > 0 Then 'Ya existe seleccionado para ese soporte
                        ControlMensaje = 3
                        If Me.uigpanticipado.ActiveRow.Cells.Item("SelPA").Value = True Then
                            ControlMensaje = 3
                            Me.uigpanticipado.ActiveRow.Cells.Item("SelPA").Value = False
                        End If
                        Dim RowsPA() As DataRow
                        For Each RowPresupuestPa As UltraGridRow In uigpanticipado.Rows
                            If RowPresupuestPa.Cells("SelPA").Value = True Then
                                RowsPA = DtPCPASeleccionados.Select("PresupuestoPA = " & RowPresupuestPa.Cells("CodPresupuestoPA").Value & " AND CodSoporte = " & RowPresupuestPa.Cells("CodSoporte").Value & " AND PresupuestoPA = " & CInt(RowPresupuestPa.Cells("CodPresupuestoPA").Value))
                                If RowsPA.Length = 0 Then
                                    RowPresupuestPa.Cells("SelPA").Value = False
                                End If
                            End If
                        Next

                    Else
                        FilaNueva = DtPCPASeleccionados.NewRow
                        FilaNueva("codCompania") = Activo.CodCampaniaActualMms
                        FilaNueva("codCampana") = Me.IdCampana
                        FilaNueva("codSubCampana") = Me.IdSubCampana
                        FilaNueva("PresupuestoPA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
                        FilaNueva("PresupuestoPC") = CodPresupuestoPC
                        FilaNueva("anio") = anio
                        FilaNueva("mes") = mes
                        FilaNueva("CodSoporte") = CodSoporte
                        FilaNueva("SaldoPAPermitido") = RowPresupuesto.Cells("Saldo").Value
                        FilaNueva("SaldoPCEnvio") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporteEnvio").Value
                        DtPCPASeleccionados.Rows.Add(FilaNueva)
                        ControlMensaje = 2
                        RowPresupuesto.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
                        RowPresupuesto.Cells("SelPA").Value = True
                        'GrillaFormato.HabilitarCelda(RowPresupuesto.Cells("SelPA"), Activation.NoEdit)
                        'RowPresupuesto.Cells("SelPA").Activation = Activation.Disabled
                        'Mensajes.Mensaje("Los datos fueron actualizados correctamente. ", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
                    End If
                    End If
            End If
        Next

        '=============================================

        'For Each RowPresupuesto As UltraGridRow In uigpanticipado.Rows
        '    If RowPresupuesto.Cells("SelPA").Value = True Then
        '        If DtPCPASeleccionados.Rows.Count = 0 Then 'Esta Vacio
        '            anio = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("anio").Value)
        '            mes = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)
        '            CodSoporte = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value)
        '            CodPresupuestoPC = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
        '            FilaNueva = DtPCPASeleccionados.NewRow
        '            FilaNueva("codCompania") = CInt(Activo.CodCampaniaActualMms)
        '            FilaNueva("codCampana") = Me.IdCampana
        '            FilaNueva("codSubCampana") = Me.IdSubCampana
        '            FilaNueva("PresupuestoPA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
        '            FilaNueva("PresupuestoPC") = CodPresupuestoPC
        '            FilaNueva("anio") = anio
        '            FilaNueva("mes") = mes
        '            FilaNueva("CodSoporte") = CodSoporte
        '            FilaNueva("SaldoPAPermitido") = RowPresupuesto.Cells("Saldo").Value
        '            FilaNueva("SaldoPCEnvio") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporte").Value
        '            DtPCPASeleccionados.Rows.Add(FilaNueva)
        '            RowPresupuesto.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
        '            RowPresupuesto.Cells("SelPA").Value = True
        '            'GrillaFormato.HabilitarCelda(RowPresupuesto.Cells("SelPA"), Activation.NoEdit)
        '            ' RowPresupuesto.Cells("SelPA").Activation = Activation.Disabled
        '            'ControlMensaje = 1
        '            Mensajes.Mensaje("Los datos fueron actualizados correctamente. ", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
        '            'AG =============================== PROBAR ESTO ULTIMO AGREGADO ANTES DE QUE SE CAIGA LA BASE DE TEST
        '            Fila = DtExistentes.NewRow
        '            Fila("COD_COMPANIA") = CInt(Activo.CodCampaniaActualMms)
        '            Fila("COD_CAMPANA") = Me.IdCampana
        '            Fila("COD_SUBCAMPANA") = Me.IdSubCampana
        '            Fila("COD_PRESUPUESTO_PC") = CodPresupuestoPC
        '            Fila("COD_PRESUPUESTO_PA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
        '            Fila("ANO") = anio
        '            Fila("MES") = mes
        '            Fila("COD_SOPORTE") = CodPresupuestoPC
        '            Fila("SALDO_PA_PERMITIDO") = RowPresupuesto.Cells("Saldo").Value
        '            Fila("SALDO_PC_ENVIO") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporte").Value
        '            DtExistentes.Rows.Add(Fila)
        '            '================================
        '        Else
        '            CodPresupuestoPC = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
        '            anio = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("anio").Value)
        '            mes = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)
        '            CodSoporte = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value)
        '            Rows = DtPCPASeleccionados.Select("PresupuestoPC = " & CodPresupuestoPC & " AND PresupuestoPA = " & RowPresupuesto.Cells("CodPresupuestoPA").Value & " AND CodSoporte = " & CodSoporte & " AND mes = " & CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)) 'Agregar cod_soporte
        '            If Rows.Length = 0 Then
        '                FilaNueva = DtPCPASeleccionados.NewRow
        '                FilaNueva("codCompania") = Activo.CodCampaniaActualMms
        '                FilaNueva("codCampana") = Me.IdCampana
        '                FilaNueva("codSubCampana") = Me.IdSubCampana
        '                FilaNueva("PresupuestoPA") = RowPresupuesto.Cells("CodPresupuestoPA").Value
        '                FilaNueva("PresupuestoPC") = CodPresupuestoPC
        '                FilaNueva("anio") = anio
        '                FilaNueva("mes") = mes
        '                FilaNueva("CodSoporte") = CodSoporte
        '                FilaNueva("SaldoPAPermitido") = RowPresupuesto.Cells("Saldo").Value
        '                FilaNueva("SaldoPCEnvio") = Me.iugPautaSoporte.ActiveRow.Cells.Item("TotalSoporte").Value
        '                DtPCPASeleccionados.Rows.Add(FilaNueva)
        '                'ControlMensaje = 2
        '                RowPresupuesto.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
        '                RowPresupuesto.Cells("SelPA").Value = True
        '                'GrillaFormato.HabilitarCelda(RowPresupuesto.Cells("SelPA"), Activation.NoEdit)
        '                'RowPresupuesto.Cells("SelPA").Activation = Activation.Disabled
        '                Mensajes.Mensaje("Los datos fueron actualizados correctamente. ", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
        '            Else
        '                RowPresupuesto.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
        '                RowPresupuesto.Cells("SelPA").Value = True
        '                'GrillaFormato.HabilitarCelda(RowPresupuesto.Cells("SelPA"), Activation.NoEdit)
        '                'RowPresupuesto.Cells("SelPA").Activation = Activation.Disabled
        '                ControlMensaje = 3
        '            End If
        '        End If
        '    End If
        'Next


        Select Case ControlMensaje
            Case 0
                Mensajes.Mensaje(MensajeNada, TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            Case 1
                Mensajes.Mensaje(MensajeConfirmacion, TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            Case 2
                Mensajes.Mensaje(MensajeConfirmacion, TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            Case 3
                Mensajes.Mensaje(MensajeYaExistente, TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            Case 4
                Mensajes.Mensaje(MensajeEliminado, TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
        End Select

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtdia.Text = ""
        Me.txtBuscar.Text = ""
    End Sub

    Private Function ActualizarSaldoDisponibles()

        Dim Dr As DataRow
        Dim dtResultado As New DataTable
        Dim OEnvioCompras As New Envio_Compras
        Dim Drs As DataRow
        Dim Rows() As DataRow

        If DtExistentes.Rows.Count > 0 Then
            For Each Dr In DtExistentes.Rows
                dtResultado = OEnvioCompras.ObtenerPresupuestoPASaldo(Dr("COD_COMPANIA"), mIdMedio, Activo.IDCliente, Dr("COD_SOPORTE"), "01/01/1900", "01/01/1900", 0)
                If dtResultado.Rows.Count > 0 Then
                    Rows = dtResultado.Select("CodPresupuestoPA = " & Dr("Cod_Presupuesto_PA"))
                    If Rows.Length > 0 Then
                        Dr("SALDO_PA_PERMITIDO") = Rows(0)("Saldo")
                    End If
                End If

            Next
        End If

    End Function

    Private Sub btoelegir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoelegir.Click

        Dim CodSoporteSel As Integer
        OEnvioCompras = New Envio_Compras
        Dim Dr As DataRow
        Dim DrExistente() As DataRow
        Dim PresupuestoPC As Integer
        Dim Ano, Mes As Integer

        If Me.iugPautaSoporte.ActiveRow Is Nothing And Me.iugPautaSoporte.ActiveCell Is Nothing Then
            Mensajes.Mensaje("Debe seleccionar el soporte, para la Relacion con el P.Anticipado", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        CodSoporteSel = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("cod_soporte").Value)
        DtPresupuestoMMSPA = OEnvioCompras.ObtenerPresupuestoPASaldo(Activo.CodCampaniaActualMms, mIdMedio, Activo.IDCliente, CodSoporteSel, "01/01/1900", "01/01/1900", 0)

        If DtPresupuestoMMSPA.Rows.Count > 0 Then
            If DtPresupuestoMMSPA.Rows(0)("CodPresupuestoPA") = -1 Then
                Mensajes.Mensaje("No se encontraron Presupuestos Anticipados para el soporte seleccionado. ", TipoMensaje.Informacion, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        End If

        'AG ======================================================================================================
        If DtExistentes.Rows.Count > 0 Then
            For Each Dr In DtPresupuestoMMSPA.Rows
                Dr("CodPresupuestoPC") = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
                Dr("CodSoporte") = CodSoporteSel
            Next
            PresupuestoPC = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("PresupuestoPC").Value)
            Ano = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("anio").Value)
            Mes = CInt(Me.iugPautaSoporte.ActiveRow.Cells.Item("mes").Value)
            For Each Dr In DtPresupuestoMMSPA.Rows
                DrExistente = DtPCPASeleccionados.Select("PresupuestoPA = " & Dr("CodPresupuestoPA") & " AND codsoporte = " & CodSoporteSel & " AND anio = " & Ano & " AND mes = " & Mes & " AND PresupuestoPC = " & PresupuestoPC & " AND codCampana = " & Me.IdCampana & " AND codSubCampana = " & Me.IdSubCampana)
                If DrExistente.Length > 0 Then
                    Dr("SelPA") = True 'Aqui tilda el check del presupuesto PA 
                End If
            Next
        End If
        '==========================================================================================================

        Me.uigpanticipado.DataSource = DtPresupuestoMMSPA
        FormatearGrillaPresupuestoPA()

        If DtPCPASeleccionados.Rows.Count > 0 Then 'ag eXISTE
            For Each r As UltraGridRow In Me.uigpanticipado.Rows
                If r.Cells("SelPA").Value = True Then
                    r.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
                End If
            Next
        End If

        If DtPCPASeleccionados.Rows.Count > 0 Then  'ag eXISTE
            If DtExistentes.Columns.Count < 9 Then 'ag 22/07/2013 
                CargarDtPCPAExistentes(DtPresupuestoMMSPA, Activo.CodCampaniaActualMms, Ano, Mes, CodSoporteSel)
            End If
        End If

        'AG Valido que se cargue los PA seleccionados cuando cambia de soporte y el anterior tiene seleccionado =====
        If DtExistentes.Rows.Count < DtPCPASeleccionados.Rows.Count And DtPCPASeleccionados.Rows.Count > 0 Then
            For Each Fila As UltraGridRow In Me.uigpanticipado.Rows
                Dim R() As DataRow
                R = DtPCPASeleccionados.Select("PresupuestoPA = " & CInt(Fila.Cells("CodPresupuestoPA").Value) & " AND codsoporte = " & CodSoporteSel & " AND anio = " & Ano & " AND mes = " & Mes)
                If R.Length > 0 Then
                    Fila.Cells("SelPA").Appearance.ForeColor = Color.GhostWhite
                    Fila.Cells("SelPA").Value = True
                    'GrillaFormato.HabilitarCelda(Fila.Cells("SelPA"), Activation.NoEdit)
                    'Fila.Cells("SelPA").Activation = Activation.Disabled
                End If
            Next
        End If
        '=============================================================================================================
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Filtro As String
        Dim Texto As String = txtBuscar.Text

        Texto = Texto.Replace("'", "''")
        Filtro = "soporte like '%" & Texto & "%'"

        If Me.txtBuscar.Text = "" Then
            iugPautaSoporte.DataSource = DtFiltroSoporte
        End If

        Me.iugPautaSoporte.DataSource = Me.FiltrarDT(DtFiltroSoporte, Filtro, "soporte ASC", 0)

    End Sub

    Private Sub txtdia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdia.TextChanged

        Dim Filtro As String
        Dim Texto As String = txtdia.Text

        Texto = Texto.Replace("'", "''")
        Filtro = "mes = " & Texto & ""

        Me.iugPautaSoporte.DataSource = Me.FiltrarDT(DtFiltroSoporte, Filtro, "mes ASC", 1)

        Me.txttinversion.Text = CalcularTotalesXDia()
    End Sub

    Private Sub txtBuscar_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

        Dim Filtro As String
        Dim Texto As String = txtBuscar.Text

        Texto = Texto.Replace("'", "''")
        Filtro = "soporte like '%" & Texto & "%'"

        If Me.txtBuscar.Text = "" Then
            iugPautaSoporte.DataSource = DtFiltroSoporte
        End If

        Me.iugPautaSoporte.DataSource = Me.FiltrarDT(DtFiltroSoporte, Filtro, "soporte ASC", 0)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim OEnvioCompras As New Envio_Compras
        Dim Dr As DataRow

        If DtPCPASeleccionados Is Nothing Then
        Else
            If DtPCPASeleccionados.Rows.Count > 0 Then
                For Each Dr In DtPCPASeleccionados.Rows
                    OEnvioCompras.EliminarTempPA(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, Dr("PresupuestoPC"), Dr("PresupuestoPA"), Dr("anio"), Dr("mes"), mIdMedio, Dr("codsoporte"), CInt(Activo.CodUsuarioMms))
                    OEnvioCompras.InsertarRelacionPCPAEverestTemp(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, Dr("PresupuestoPC"), Dr("PresupuestoPA"), Dr("codsoporte"), Dr("anio"), Dr("mes"), CInt(Activo.CodUsuarioMms), Dr("SaldoPAPermitido"), Dr("SaldoPCEnvio"), 0, mIdMedio)
                Next
            End If
        End If

        frmEnviarCompras.Instancia.DtRelacionPCPAFinal = RecorrerDtFinalAutorizarEnvios(DtPCPASeleccionados.Copy)
        Me.Close()

    End Sub

    Private Sub iugPautaSoporte_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles iugPautaSoporte.BeforeSelectChange
        iugPautaSoporte.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
        iugPautaSoporte.DisplayLayout.MaxRowScrollRegions = 1

        If Me.uigpanticipado.Rows.Count > 0 Then
            Me.uigpanticipado.DataSource = Nothing
        End If

    End Sub

    Private Sub uigpanticipado_BeforeSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles uigpanticipado.BeforeSelectChange
        uigpanticipado.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
        uigpanticipado.DisplayLayout.MaxRowScrollRegions = 1
    End Sub

    Private Function ExistenCambios() As Boolean

        Dim OEnvioCompras As New Envio_Compras
        Dim DtBaseTemp As New DataTable
        Dim DrTemp() As DataRow
        Dim DrSelec() As DataRow
        Dim DrExistente() As DataRow
        Dim DrSeleccionado As DataRow
        Dim DrSel As DataRow
        Dim Resultado As Boolean

        DtBaseTemp = OEnvioCompras.ObtenerPACargadosConcatenadosTemp(CInt(Activo.CodCampaniaActualMms), Me.IdCampana, Me.IdSubCampana, 0, 0, 0, 0, 0, Me.IdMedio, 1)

        If DtPCPASeleccionados Is Nothing Then
        Else
            If DtPCPASeleccionados.Rows.Count > DtExistentes.Rows.Count Then
                For Each DrSeleccionado In DtPCPASeleccionados.Rows
                    DrExistente = DtExistentes.Select("COD_COMPANIA = " & DrSeleccionado("codCompania") & " AND COD_CAMPANA = " & DrSeleccionado("codCampana") & " AND COD_SUBCAMPANA = " & DrSeleccionado("codSubCampana") & " AND COD_PRESUPUESTO_PC = " & DrSeleccionado("PresupuestoPC") & " AND COD_PRESUPUESTO_PA = " & DrSeleccionado("PresupuestoPA") & " AND COD_SOPORTE = " & DrSeleccionado("codsoporte") & " AND ANO = " & DrSeleccionado("anio") & " AND MES = " & DrSeleccionado("mes"))
                    If DrExistente.Length = 0 Then
                        Resultado = True
                        Exit For
                    Else
                        Resultado = False
                    End If
                Next
            End If

            If DtBaseTemp.Rows.Count >= DtPCPASeleccionados.Rows.Count Then
                For Each DrSel In DtBaseTemp.Rows
                    DrSelec = DtPCPASeleccionados.Select("codCompania = " & DrSel("COD_COMPANIA") & " AND codCampana = " & DrSel("COD_CAMPANA") & " AND codSubCampana = " & DrSel("COD_SUBCAMPANA") & " AND PresupuestoPC = " & DrSel("COD_PRESUPUESTO_PC") & " AND PresupuestoPA = " & DrSel("COD_PRESUPUESTO_PA") & " AND codsoporte = " & DrSel("COD_SOPORTE") & " AND anio = " & DrSel("ANO") & " AND mes = " & DrSel("MES"))
                    If DrSelec.Length = 0 Then
                        Resultado = True
                        Exit For
                    Else
                        Resultado = False
                    End If
                Next
            End If
        End If

        Return Resultado

    End Function

#End Region


#Region "Metodos"

    Private Sub FormatearGrillaPresupuestoPA()

        Listas.CambiarTituloColumna(Me.uigpanticipado, "DesSoporte", "Soporte")
        Listas.CambiarTituloColumna(Me.uigpanticipado, "CodPresupuestoPA", "Presupuesto P.A")
        Listas.CambiarTituloColumna(Me.uigpanticipado, "Saldo", "Saldo Disponible")
        Listas.CambiarTituloColumna(Me.uigpanticipado, "SelPA", "Seleccion")
        Listas.OcultarColumnas(Me.uigpanticipado, "CodPresupuestoPC", "CodSoporte")
        GrillaFormato.CambiarFormatoColumna(Me.uigpanticipado, "Saldo", Formato.Decimales)
        GrillaFormato.HabilitarEdicionColumna(Me.uigpanticipado, Activation.NoEdit, "DesSoporte", "CodPresupuestoPA", "Saldo")

        With uigpanticipado.DisplayLayout.Bands(0)
            .Columns("SelPA").CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns("SelPA").ButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
            .Columns("SelPA").Style = ColumnStyle.CheckBox
            .Columns("SelPA").ButtonDisplayStyle = Infragistics.Win.DefaultableBoolean.False
        End With

    End Sub

    Private Sub FormatearGrillaPresupuestoPC()
        Listas.CambiarTituloColumna(Me.iugPautaSoporte, "anio", "Año")
        Listas.CambiarTituloColumna(Me.iugPautaSoporte, "mes", "Mes")
        Listas.CambiarTituloColumna(Me.iugPautaSoporte, "PresupuestoPC", "Presupuesto PC")
        Listas.CambiarTituloColumna(Me.iugPautaSoporte, "soporte", "Soporte")
        Listas.CambiarTituloColumna(Me.iugPautaSoporte, "TotalSoporteEnvio", "Total X Soporte")
        Listas.OcultarColumnas(Me.iugPautaSoporte, "cod_soporte")
        GrillaFormato.CambiarFormatoColumna(Me.iugPautaSoporte, "TotalSoporteEnvio", Formato.Decimales)
        GrillaFormato.HabilitarEdicionColumna(Me.iugPautaSoporte, Activation.NoEdit, False)

    End Sub

    Private Function ArmarEstructuraDtPresupuestoPA()

    End Function

    Private Function ArmarEstructuraDtSoportesPauta()

        With DtSoportesPauta.Columns
            .Add("anio", GetType(Integer))
            .Add("mes", GetType(Integer))
            .Add("PresupuestoPC", GetType(Integer))
            .Add("cod_soporte", GetType(Integer))
            .Add("soporte", GetType(String))
            .Add("TotalSoporte", GetType(Double))
        End With

        Return DtSoportesPauta

    End Function

    Private Function ArmarEstructuraDtDtPCPASeleccionados()

        With DtPCPASeleccionados.Columns
            .Add("codCompania", GetType(Integer))
            .Add("codCampana", GetType(Integer))
            .Add("codSubCampana", GetType(Integer))
            .Add("anio", GetType(Integer))
            .Add("mes", GetType(Integer))
            .Add("PresupuestoPC", GetType(Integer))
            .Add("PresupuestoPA", GetType(Integer))
            .Add("codsoporte", GetType(Integer))
            .Add("SaldoPCEnvio", GetType(Double)) 'AG 23/07
            .Add("SaldoPAPermitido", GetType(Double)) 'AG 23/07
            .Add("Autorizado", GetType(Boolean)) 'AG 23/07
        End With
    End Function

    Private Function CalcularTotalesXSoporte(ByVal Dt As DataTable) As DataTable

        Dim DrSoporte, DrAvisos, FilaNueva As DataRow
        DtSoportesPauta = ArmarEstructuraDtSoportesPauta()
        'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
        'Dim DtSoportes As DataTable = DtAvisosEnvioCompras.DefaultView.ToTable(True, "CODIGOSOPORTE", "CODIGOMEDIO", "MES", "ANIO")
        Dim DtSoportes As DataTable = DtAvisosEnvioCompras.DefaultView.ToTable(True, "SOPORTE", "MEDIO", "MES", "ANIO", "EJERCICIO", "SISTEMA", "PRODUCTO", "TEMA", "FECHADESDE", "FECHAHASTA", "PRESUPUESTO")
        Dim Rows() As DataRow
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtSoportesPauta.Clone

        For Each DrSoporte In DtSoportes.Rows
            FilaNueva = DtSoportesPauta.NewRow
            FilaNueva("anio") = DrSoporte("ANIO")
            FilaNueva("mes") = DrSoporte("MES")
            'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
            'Rows = DtAvisosEnvioCompras.Select("CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))
            Rows = DtAvisosEnvioCompras.Select("SOPORTE = " & DrSoporte("SOPORTE") & "AND MES = " & DrSoporte("MES"))
            FilaNueva("PresupuestoPC") = CInt(Rows(0)("PresupuestoPC").ToString)
            'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
            'FilaNueva("cod_soporte") = DrSoporte("CODIGOSOPORTE")
            FilaNueva("cod_soporte") = DrSoporte("SOPORTE")
            With OSoporte
                'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
                '.Id_medio = DrSoporte("CODIGOMEDIO")
                .Id_medio = DrSoporte("MEDIO")
                FilaNueva("soporte") = .ObtenerDescripcion(FilaNueva("cod_soporte"))
            End With
            'COMENTO POR NUEVO DESARROLLO DE ENVIO LIGERO
            'FilaNueva("TotalSoporte") = DtAvisosEnvioCompras.Compute("Sum(IMPORTECOMPRANETO)", "CODIGOSOPORTE = " & DrSoporte("CODIGOSOPORTE") & "AND MES = " & DrSoporte("MES"))

            Dim oEnvioComprasLigero As New Envio_Ligero_MMS
            Dim retorno As DataTable = oEnvioComprasLigero.Obtener_Total_Soportes_PA_TV(Activo.IDCampaña, DrSoporte("SISTEMA"), DrSoporte("EJERCICIO"), DrSoporte("PRODUCTO"), DrSoporte("SOPORTE"), DrSoporte("TEMA"), DrSoporte("FECHADESDE"), DrSoporte("FECHAHASTA"), DrSoporte("MES"), DrSoporte("ANIO"), Activo.CodCampaniaActualMms, Me.IdSubCampana, Me.IdCampana, DrSoporte("PRESUPUESTO"))

            'NUEVO DESARROLLO DE ENVIO LIGERO (AN 07-09-2015)
            If Not retorno Is Nothing Then
                FilaNueva("TotalSoporteEnvio") = 0 'retorno.Rows(0)("IMPORTE_COMPRA_NETO_MMS")
            Else
                FilaNueva("TotalSoporteEnvio") = 0
            End If

            DtSoportesPauta.Rows.Add(FilaNueva)
        Next
        DtSoportesPauta.DefaultView.Sort = ("Mes")

        Return DtSoportesPauta

    End Function

    Private Sub CargarDtPCPAExistentes(ByVal Dt As DataTable, ByVal CodCompania As Integer, ByVal Ano As Integer, ByVal Mes As Integer, ByVal CodSoporte As Integer)

        Dim Dr As DataRow
        Dim FilaNueva As DataRow
        Dim Rows() As DataRow

        If DtPCPASeleccionados.Rows.Count = 0 Then
            For Each Dr In Dt.Rows
                If Dr("SelPA") = True Then
                    FilaNueva = DtPCPASeleccionados.NewRow
                    FilaNueva("codCompania") = CodCompania
                    FilaNueva("codCampana") = Me.IdCampana
                    FilaNueva("codSubCampana") = Me.IdSubCampana
                    FilaNueva("PresupuestoPC") = CInt(Dr("CODPRESUPUESTOPC"))
                    FilaNueva("PresupuestoPA") = CInt(Dr("CODPRESUPUESTOPA"))
                    FilaNueva("codsoporte") = CodSoporte
                    FilaNueva("anio") = Ano
                    FilaNueva("mes") = Mes
                    DtPCPASeleccionados.Rows.Add(FilaNueva)
                End If
            Next
        Else
            For Each Dr In Dt.Rows
                If Dr("SelPA") = True Then
                    Rows = DtPCPASeleccionados.Select("PresupuestoPC = " & CInt(Dr("CodPresupuestoPC")) & " AND PresupuestoPA = " & CInt(Dr("CodPresupuestoPA")) & " AND codsoporte = " & CodSoporte) 'Agregar cod_soporte
                    If Rows.Length = 0 Then
                        'AG 22/07/2013 
                        If DtExistentes.Columns.Count < 9 Then
                            FilaNueva = DtPCPASeleccionados.NewRow
                            FilaNueva("codCompania") = CodCompania
                            FilaNueva("codCampana") = Me.IdCampana
                            FilaNueva("codSubCampana") = Me.IdSubCampana
                            FilaNueva("PresupuestoPC") = CInt(Dr("CODPRESUPUESTOPC"))
                            FilaNueva("PresupuestoPA") = CInt(Dr("CODPRESUPUESTOPA"))
                            FilaNueva("anio") = Ano
                            FilaNueva("mes") = Mes
                            FilaNueva("CodSoporte") = CodSoporte
                            DtPCPASeleccionados.Rows.Add(FilaNueva)
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub CargarDtSeleccionados(ByVal Dt As DataTable)

        Dim DrExistente As DataRow
        Dim FilaNueva As DataRow

        For Each DrExistente In DtExistentes.Rows
            FilaNueva = DtPCPASeleccionados.NewRow
            FilaNueva("codCompania") = DrExistente("COD_COMPANIA")
            FilaNueva("codCampana") = DrExistente("COD_CAMPANA")
            FilaNueva("codSubCampana") = DrExistente("COD_SUBCAMPANA")
            FilaNueva("PresupuestoPC") = DrExistente("COD_PRESUPUESTO_PC")
            FilaNueva("PresupuestoPA") = DrExistente("COD_PRESUPUESTO_PA")
            FilaNueva("anio") = DrExistente("ANO")
            FilaNueva("mes") = DrExistente("MES")
            FilaNueva("CodSoporte") = DrExistente("COD_SOPORTE")
            FilaNueva("SaldoPCEnvio") = DrExistente("SALDO_PC_ENVIO")
            FilaNueva("SaldoPAPermitido") = DrExistente("SALDO_PA_PERMITIDO")
            If Not DrExistente("SALDO_PA_PERMITIDO") Is DBNull.Value And Not DrExistente("SALDO_PC_ENVIO") Is DBNull.Value Then
                If DrExistente("SALDO_PA_PERMITIDO") > DrExistente("SALDO_PC_ENVIO") Then
                    FilaNueva("Autorizado") = True 'Permite Enviar 
                Else
                    FilaNueva("Autorizado") = False 'NO Permite Enviar 
                End If
            End If
            DtPCPASeleccionados.Rows.Add(FilaNueva)
        Next

    End Sub

    Private Function FiltrarDT(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Orden As String, ByVal TipoBusqueda As Integer) As DataTable

        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()
        If TipoBusqueda = 0 Then
            If Me.txtBuscar.Text <> "" Then
                Filas = Dt.Select(Filtro, Orden)

                For Each Dr As DataRow In Filas
                    DtNuevo.ImportRow(Dr)
                Next
            End If
        Else
            If Me.txtdia.Text <> "" Then
                Filas = Dt.Select(Filtro, Orden)

                For Each Dr As DataRow In Filas
                    DtNuevo.ImportRow(Dr)
                Next
            End If
        End If

        If DtNuevo.Rows.Count = 0 Then
            DtNuevo = DtFiltroSoporte
        End If
        Return DtNuevo

    End Function

    Private Function CalcularTotalesXDia() As Double

        Dim ResultadoTotalxDia As Double

        If Me.txtdia.Text <> "" Then
            Me.lblinversion.Text = "Inversion x Mes : " & Me.txtdia.Text
            Dim valor As Array = DtFiltroSoporte.Select("MES=" & CInt(Me.txtdia.Text))
            If valor.Length > 0 Then
                ResultadoTotalxDia = DtFiltroSoporte.Compute("Sum(TotalSoporteEnvio)", "MES=" & CInt(Me.txtdia.Text))
            Else
                ResultadoTotalxDia = 0
            End If
        Else
            Me.lblinversion.Text = "Inversion x Año : " & AnioPauta.ToString
            ResultadoTotalxDia = DtFiltroSoporte.Compute("Sum(TotalSoporteEnvio)", "ANIO=" & CInt(AnioPauta))
        End If

        Return ResultadoTotalxDia

    End Function

    Private Function RecorrerDtFinalAutorizarEnvios(ByVal DtTemp As DataTable) As DataTable

        Dim Dr As DataRow

        For Each Dr In DtTemp.Rows
            If Dr("SaldoPAPermitido") >= Dr("SaldoPCEnvio") Then
                Dr("Autorizado") = True 'Permite Enviar 
            Else
                Dr("Autorizado") = False 'NO Permite Enviar 
            End If
        Next

        Return DtTemp

    End Function

    Private Function CalcularInversionPermitida(ByVal Dt As DataTable) As DataTable

        Dim DtTemp As New DataTable
        Dim DrDistint, FilaNueva As DataRow
        Dim DtDistint As DataTable = Dt.DefaultView.ToTable(True, "codCompania", "codCampana", "CodSubCampana", "codsoporte", "PresupuestoPA", "SaldoPAPermitido")
        Dim TotalCalculado As Double

        DtTemp = Dt.Clone

        For Each DrDistint In DtDistint.Rows
            FilaNueva = DtTemp.NewRow
            FilaNueva("codCompania") = DrDistint("codCompania")
            FilaNueva("codCampana") = DrDistint("codCampana")
            FilaNueva("CodSubCampana") = DrDistint("CodSubCampana")
            FilaNueva("PresupuestoPA") = DrDistint("PresupuestoPA")
            TotalCalculado = Dt.Compute("Sum(SaldoPCEnvio)", "codsoporte = " & DrDistint("codsoporte"))
            If TotalCalculado > DrDistint("SaldoPAPermitido") Then
                FilaNueva("Autorizado") = False
            Else
                FilaNueva("Autorizado") = True
            End If
            FilaNueva("SaldoPCEnvio") = TotalCalculado
            FilaNueva("SaldoPAPermitido") = DrDistint("SaldoPAPermitido")
            DtTemp.Rows.Add(FilaNueva)
        Next

        Return DtTemp

    End Function

#End Region


End Class

Public Class frmFiltrarSoporteInternet

    Dim mId_plaza As Integer
    Dim mId_medio As Integer
    Dim mId_tipo_soporte As Integer

    Dim mCancelado As Boolean

    Dim mListaSoportes As ArrayList
    Dim Item As ItemLista

    Dim bsSoportes As New BindingSource
    Dim dtSoportes As DataTable

#Region "Propiedades"

    Public Property id_plaza() As Integer
        Get
            Return mId_plaza
        End Get
        Set(ByVal Value As Integer)
            mId_plaza = Value
        End Set
    End Property

    Public Property Id_medio() As Integer
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Integer)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_tipo_soporte() As Integer
        Get
            Return mId_tipo_soporte
        End Get
        Set(ByVal Value As Integer)
            mId_tipo_soporte = Value
        End Set
    End Property

    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal Value As Boolean)
            mCancelado = Value
        End Set
    End Property

    Public Property ListaSoportes() As ArrayList
        Get
            If mListaSoportes Is Nothing Then
                mListaSoportes = New ArrayList
            End If

            Return mListaSoportes
        End Get
        Set(ByVal Value As ArrayList)
            mListaSoportes = Value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        AgregarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Private Sub frmFiltrarSoporteInternet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim S As New Soportes
        CargarTipoSoporte()


        S.Id_plaza = Me.id_plaza
        S.Id_medio = Me.Id_medio
        'S.Id_tipo_soporte = Me.Id_tipo_soporte

        S.Id_tipo_soporte = Me.cboTipoSoporte.Value

        'S.Id_tipo_soporte = Me.cboTipoSoporte.SelectedRow.Cells("Id_tipo_soporte").Value

        dtSoportes = S.FiltrarSoportesMMSVigencia(Me.Id_medio, S.Id_tipo_soporte, Me.id_plaza, True)

        CargarGrid(dtSoportes)
        ConfigurarControles()

    End Sub

    Private Sub cmdAgregarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTodos.Click
        AgregarTodosSoportes()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Private Sub cmdQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitar.Click
        SacarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()
    End Sub

    Private Sub cmdQuitarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTodos.Click
        SacarSoporteTodos()

        Dim S As New Soportes
        grdBuscar.DataSource = Nothing
        S.Id_plaza = Me.id_plaza
        S.Id_medio = Me.Id_medio

        'S.Id_tipo_soporte = Me.cboTipoSoporte.Value
        S.Id_tipo_soporte = Me.cboTipoSoporte.SelectedRow.Cells("Id_tipo_soporte").Value
        dtSoportes = S.FiltrarSoportesMMSVigencia(Me.Id_medio, S.Id_tipo_soporte, Me.id_plaza, True)
        CargarGrid(dtSoportes)
        ConfigurarControles()

        'grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Filtro As String

        Dim Texto As String = txtBuscar.Text
        Texto = Texto.Replace("'", "''")
        Filtro = "DESCRIPCION like '%" & Texto & "%'"

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = Me.FiltrarDT(dtSoportes, Filtro, "DESCRIPCION ASC")
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.lstSoportesSeleccionados.Items.Count = 0 Then
            Mensajes.Mensaje("Debe Seleccionar al menos un Soporte", TipoMensaje.Informacion)
            Exit Sub
        End If
        Me.ListaSoportes.AddRange(Me.lstSoportesSeleccionados.Items)
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cancelado = True
        Dim Ejer As EjercicioActivo

        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio
        Activo.EjerciciosCargados.Remove(Ejer)
        Me.Close()
    End Sub

    Private Sub CargarTipoSoporte()
        'tipo soporte
        Dim TS As New Tipos_soporte
        Dim dtTS As DataTable
        'If Not CboMedio.Value Is Nothing Then
        'el harcode del id_medio esta en el store
        TS.Id_medio = Activo.Medios.Internet
        Activo.IDMedio = Activo.Medios.Internet
        dtTS = TS.TraerTipoSoporte

        If Not dtTS Is Nothing AndAlso dtTS.Rows.Count > 0 Then
            Listas.CargarCombo(Me.cboTipoSoporte, dtTS, "Id_tipo_soporte", "descripcion")
            Listas.OcultarColumnas(cboTipoSoporte, "Id_Tipo_soporte", "id_medio")
            Listas.OcultarHeader(cboTipoSoporte)
            cboTipoSoporte.Enabled = True
            cboTipoSoporte.Rows(0).Selected = True
        Else
            cboTipoSoporte.DataSource = Nothing
            cboTipoSoporte.Enabled = False
        End If
        'Else
        'cboTipoSoporte.DataSource = Nothing
        'cboTipoSoporte.Enabled = False
        'End If
    End Sub

    Private Sub cboTipoSoporte_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.ValueChanged

        Dim S As New Soportes
        grdBuscar.DataSource = Nothing
        S.Id_plaza = Me.id_plaza
        S.Id_medio = Me.Id_medio

        'S.Id_tipo_soporte = Me.cboTipoSoporte.Value
        S.Id_tipo_soporte = Me.cboTipoSoporte.SelectedRow.Cells("Id_tipo_soporte").Value
        dtSoportes = S.FiltrarSoportesMMSVigencia(Me.Id_medio, S.Id_tipo_soporte, Me.id_plaza, True)
        'AG ==========================================================
        dtSoportes = QuitarSoporteSeleccionados(dtSoportes)
        '=============================================================
        CargarGrid(dtSoportes)
        ConfigurarControles()
    End Sub

#End Region


#Region "Metodos"

    Private Function ValidarSoporteyaElegido(ByVal IdSoporte As Integer) As Boolean

        Dim dr As DataRow
        Dim Resultado As Boolean

        For Each soporte As ItemLista In lstSoportesSeleccionados.Items
            'dr = dtSoportes.NewRow
            If IdSoporte = soporte.ID Then
                Resultado = True
                Exit For
            Else
                Resultado = False
            End If
        Next
        'lstSoportesSeleccionados.Items.Clear()

        Return Resultado

    End Function

    Private Sub AgregarSoporte()
        Dim dr As DataRow

        If grdBuscar.Selected.Rows.Count = 0 Then
            Exit Sub
        End If


        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grdBuscar.Selected.Rows()
            dr = dtSoportes.Select("ID_SOPORTE = " & fila.Cells("ID_SOPORTE").Value)(0)
            'AG ======================================
            If ValidarSoporteyaElegido(fila.Cells("ID_SOPORTE").Value) = True Then
                MessageBox.Show(dr("DESCRIPCION") & " Ya se encuentra seleccionado", "Everest - Selección de soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '=========================================
            AgregarSoporte(dr)
        Next

    End Sub

    Private Sub AgregarTodosSoportes()
        Dim dr As DataRow

        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grdBuscar.Rows()
            dr = dtSoportes.Select("ID_SOPORTE = " & fila.Cells("ID_SOPORTE").Value)(0)
            AgregarSoporte(dr)
        Next

    End Sub

    Private Sub SacarSoporteTodos()

        'Dim dr As DataRow
        'For Each soporte As ItemLista In lstSoportesSeleccionados.Items
        'dr = dtSoportes.NewRow
        'dr("ID_SOPORTE") = soporte.ID
        'dr("DESCRIPCION") = soporte.Descripcion
        'dtSoportes.Rows.Add(dr)
        'Next

        lstSoportesSeleccionados.Items.Clear()

    End Sub

    Private Function FiltrarDT(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Orden As String) As DataTable
        'devuelve un data table filtrado y ordenado por los parametros que se pasan
        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()
        Filas = Dt.Select(Filtro, Orden)


        For Each Dr As DataRow In Filas
            DtNuevo.ImportRow(Dr)
        Next

        Return DtNuevo

    End Function

    Private Sub SacarSoporte()

        While Not Me.lstSoportesSeleccionados.SelectedItem Is Nothing
            Dim dr As DataRow
            dr = dtSoportes.NewRow
            Dim item As ItemLista = DirectCast(lstSoportesSeleccionados.SelectedItem, ItemLista)
            dr("ID_SOPORTE") = item.ID
            dr("DESCRIPCION") = item.Descripcion
            dtSoportes.Rows.Add(dr)
            Me.lstSoportesSeleccionados.Items.Remove(Me.lstSoportesSeleccionados.SelectedItem)
        End While
    End Sub

    Private Sub AgregarItem(ByVal Lista As ListBox, ByVal dr As DataRow)
        Item = New ItemLista
        Item.ID = IIf(IsDBNull(dr("ID_SOPORTE")), 0, dr("ID_SOPORTE"))
        Item.Descripcion = IIf(IsDBNull(dr("DESCRIPCION")), "", dr("DESCRIPCION"))

        Lista.Items.Add(Item)

    End Sub

    Private Sub AgregarSoporte(ByVal dr As DataRow)

        Dim T As New Tarifas_tv
        Dim s As New Sistemas

        s.Id_campania = Activo.IDCampaña
        s.Id_sistema = Activo.IDSistema
        s.BuscarPorID()

        T.Id_cliente = Activo.IDCliente
        T.Id_medio = Activo.IDMedio
        T.Id_soporte = dr("ID_SOPORTE")
        T.F_inicio_vig = s.F_inicio
        T.F_fin_vig = s.F_fin

        Dim SoportesVigentes As Integer = T.ComprobarSoporteVigente
        If Activo.IDMedio = 1 Or Activo.IDMedio = 6 Then
            If Me.Id_tipo_soporte <> 4 Then
                If SoportesVigentes <= 0 Then
                    MessageBox.Show(dr("DESCRIPCION") & " no Posee Programas Vigentes", "Everest - Selección de soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If

        AgregarItem(Me.lstSoportesSeleccionados, dr)

        dtSoportes.Rows.Remove(dr)

    End Sub

    Private Sub AgregarTodos2()

        Dim Borrados As New ArrayList
        Dim T As New Tarifas_tv
        Dim s As New Sistemas
        Dim dr As DataRow

        s.Id_campania = Activo.IDCampaña
        s.Id_sistema = Activo.IDSistema
        s.BuscarPorID()

        For i As Integer = 0 To grdBuscar.Rows.Count - 1
            dr = dtSoportes.Select("ID_SOPORTE = " & grdBuscar.Rows(i).Cells("ID_SOPORTE").Value)(0)

            T.Id_cliente = Activo.IDCliente
            T.Id_medio = Activo.IDMedio
            T.Id_soporte = dr("ID_SOPORTE")
            T.F_inicio_vig = s.F_inicio
            T.F_fin_vig = s.F_fin

            If Activo.IDMedio = 6 Or Activo.IDMedio = 1 Then
                Dim SoportesVigentes As Integer = T.ComprobarSoporteVigente
                If SoportesVigentes <= 0 Then
                    Mensajes.Mensaje(dr("DESCRIPCION") & " no Posee Programas Vigentes", TipoMensaje.Informacion)
                Else
                    AgregarItem(Me.lstSoportesSeleccionados, dr)
                    dtSoportes.Rows.Remove(dr)
                End If
            End If
        Next

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()

    End Sub

    Private Sub CargarGrid(ByVal dt As DataTable)

        grdBuscar.DataSource = dt
        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False

        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.Bands(0).ColHeadersVisible = False
        grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
        grdBuscar.DisplayLayout.Bands(0).Columns(1).Hidden = True

        grdBuscar.DisplayLayout.Bands(0).Columns(2).Hidden = True
    End Sub

    Private Sub ConfigurarControles()
        lstSoportesSeleccionados.ValueMember = "ID"
        lstSoportesSeleccionados.DisplayMember = "Descripcion"
        grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
    End Sub

    Public Function QuitarSoporteSeleccionados(ByVal Dt As DataTable) As DataTable

        Dim FilaQuitar As DataRow()

        For Each soporte As ItemLista In lstSoportesSeleccionados.Items
            FilaQuitar = Dt.Select("id_soporte=" & soporte.ID)
            If FilaQuitar.Length > 0 Then
                Dt.Rows.Remove(FilaQuitar(0))
            End If
            Me.lstSoportesSeleccionados.Items.Remove(Me.lstSoportesSeleccionados.SelectedItem)
        Next

        Return Dt

    End Function

#End Region


    
    
End Class
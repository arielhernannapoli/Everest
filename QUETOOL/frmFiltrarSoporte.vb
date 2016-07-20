Public Class frmFiltrarSoporte
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarTodos As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTodos As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents grdBuscar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lstSoportesSeleccionados As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstSoportesSeleccionados = New System.Windows.Forms.ListBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdQuitar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdAgregarTodos = New System.Windows.Forms.Button
        Me.cmdQuitarTodos = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSoportesSeleccionados
        '
        Me.lstSoportesSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSoportesSeleccionados.Location = New System.Drawing.Point(365, 27)
        Me.lstSoportesSeleccionados.Name = "lstSoportesSeleccionados"
        Me.lstSoportesSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSoportesSeleccionados.Size = New System.Drawing.Size(270, 301)
        Me.lstSoportesSeleccionados.TabIndex = 1
        '
        'cmdAgregar
        '
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregar.Location = New System.Drawing.Point(320, 86)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(37, 38)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "4"
        '
        'cmdQuitar
        '
        Me.cmdQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitar.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitar.Location = New System.Drawing.Point(320, 174)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(37, 38)
        Me.cmdQuitar.TabIndex = 4
        Me.cmdQuitar.Text = "3"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(10, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 2)
        Me.Label1.TabIndex = 4
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(543, 346)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(452, 346)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdAgregarTodos
        '
        Me.cmdAgregarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarTodos.Location = New System.Drawing.Point(320, 130)
        Me.cmdAgregarTodos.Name = "cmdAgregarTodos"
        Me.cmdAgregarTodos.Size = New System.Drawing.Size(37, 38)
        Me.cmdAgregarTodos.TabIndex = 3
        Me.cmdAgregarTodos.Text = "8"
        '
        'cmdQuitarTodos
        '
        Me.cmdQuitarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarTodos.Location = New System.Drawing.Point(320, 218)
        Me.cmdQuitarTodos.Name = "cmdQuitarTodos"
        Me.cmdQuitarTodos.Size = New System.Drawing.Size(37, 38)
        Me.cmdQuitarTodos.TabIndex = 5
        Me.cmdQuitarTodos.Text = "7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Soportes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Soportes Seleccionados"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(12, 27)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(300, 20)
        Me.txtBuscar.TabIndex = 11
        '
        'grdBuscar
        '
        Me.grdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdBuscar.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdBuscar.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdBuscar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdBuscar.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdBuscar.FlatMode = True
        Me.grdBuscar.Location = New System.Drawing.Point(12, 53)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(300, 275)
        Me.grdBuscar.TabIndex = 12
        '
        'frmFiltrarSoporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(644, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdQuitarTodos)
        Me.Controls.Add(Me.cmdAgregarTodos)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdQuitar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.lstSoportesSeleccionados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltrarSoporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir soporte"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

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


    Private Sub frmFiltrarSoporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim S As New Soportes

        If id_plaza = 0 Then
            Mensajes.Mensaje("No se Paso la Plaza. QUETOOL.frmFiltrarSoporte_Load", TipoMensaje.DeError)
        End If

        If Id_medio = 0 Then
            Mensajes.Mensaje("No se Paso el Medio. QUETOOL.frmFiltrarSoporte_Load", TipoMensaje.DeError)
        End If

        If Me.Id_tipo_soporte = 0 Then
            Mensajes.Mensaje("No se Paso el Tipo de Soporte. QUETOOL.frmFiltrarSoporte_Load", TipoMensaje.DeError)
        End If

        S.Id_plaza = Me.id_plaza
        S.Id_medio = Me.Id_medio
        S.Id_tipo_soporte = Me.Id_tipo_soporte

        dtSoportes = S.FiltrarSoportesMMSVigencia(Me.Id_medio, Me.Id_tipo_soporte, Me.id_plaza, True)

        CargarGrid(dtSoportes)
        ConfigurarControles()

    End Sub

    Private Sub ConfigurarControles()
        lstSoportesSeleccionados.ValueMember = "ID"
        lstSoportesSeleccionados.DisplayMember = "Descripcion"

        grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended

    End Sub

    Private Sub CargarGrid(ByVal dt As DataTable)
        grdBuscar.DataSource = dt

        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False

        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.Bands(0).ColHeadersVisible = False
        grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
        grdBuscar.DisplayLayout.Bands(0).Columns(1).Hidden = True

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        AgregarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
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

    Private Sub AgregarItem(ByVal Lista As ListBox, ByVal dr As DataRow)
        Item = New ItemLista
        Item.ID = IIf(IsDBNull(dr("ID_SOPORTE")), 0, dr("ID_SOPORTE"))
        Item.Descripcion = IIf(IsDBNull(dr("DESCRIPCION")), "", dr("DESCRIPCION"))

        Lista.Items.Add(Item)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTodos.Click
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

    Private Sub lbSoportesSeleccionados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSoportesSeleccionados.DoubleClick
        SacarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.lstSoportesSeleccionados.Items.Count = 0 Then
            Mensajes.Mensaje("Debe Seleccionar al menos un Soporte", TipoMensaje.Informacion)
            Exit Sub
        End If
        Me.ListaSoportes.AddRange(Me.lstSoportesSeleccionados.Items)
        Me.Close()

    End Sub

    Private Sub lstSoportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lstSoportesSeleccionados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSoportesSeleccionados.SelectedIndexChanged

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Filtro As String

        Dim Texto As String = txtBuscar.Text
        Texto = Texto.Replace("'", "''")
        Filtro = "DESCRIPCION like '%" & Texto & "%'"

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = Me.FiltrarDT(dtSoportes, Filtro, "DESCRIPCION ASC")
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        If e.KeyCode = Keys.Enter And Me.grdBuscar.Selected.Rows.Count = 1 Then
            cmdAgregar_Click(txtBuscar, System.EventArgs.Empty)
        End If

        If e.KeyCode = Keys.Down Then
            Me.grdBuscar.Select()
            If Me.grdBuscar.Rows.Count > 0 Then
                grdBuscar.Rows(0).Selected = True
            End If
        End If

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

    Private Sub grdBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdBuscar.KeyDown

        If e.KeyCode = Keys.Enter And Me.grdBuscar.Selected.Rows.Count = 1 Then
            cmdAgregar_Click(txtBuscar, System.EventArgs.Empty)
        End If

    End Sub

    Private Sub grdBuscar_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdBuscar.DoubleClickRow
        AgregarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Private Sub AgregarSoporte()
        Dim dr As DataRow

        If grdBuscar.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grdBuscar.Selected.Rows()
            dr = dtSoportes.Select("ID_SOPORTE = " & fila.Cells("ID_SOPORTE").Value)(0)
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

        Dim dr As DataRow

        For Each soporte As ItemLista In lstSoportesSeleccionados.Items
            dr = dtSoportes.NewRow

            dr("ID_SOPORTE") = soporte.ID
            dr("DESCRIPCION") = soporte.Descripcion

            dtSoportes.Rows.Add(dr)
        Next

        lstSoportesSeleccionados.Items.Clear()

    End Sub

    Private Sub cmdQuitarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTodos.Click
        SacarSoporteTodos()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()

    End Sub
End Class

Imports System.Text

Public Class frmFiltrarSoporteTema
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
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstSoportesSeleccionados As System.Windows.Forms.ListBox
    Friend WithEvents cmdAgregarSoporte As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarSoporte As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarSoporteTodos As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarSoporteTodos As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdQuitarTemaTodos As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTemaTodos As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarTema As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTema As System.Windows.Forms.Button
    Friend WithEvents lstTemasSeleccionados As System.Windows.Forms.ListBox
    Friend WithEvents grdBuscar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lstTemas As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstSoportesSeleccionados = New System.Windows.Forms.ListBox
        Me.cmdAgregarSoporte = New System.Windows.Forms.Button
        Me.cmdQuitarSoporte = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdAgregarSoporteTodos = New System.Windows.Forms.Button
        Me.cmdQuitarSoporteTodos = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdQuitarTemaTodos = New System.Windows.Forms.Button
        Me.cmdAgregarTemaTodos = New System.Windows.Forms.Button
        Me.cmdQuitarTema = New System.Windows.Forms.Button
        Me.cmdAgregarTema = New System.Windows.Forms.Button
        Me.lstTemasSeleccionados = New System.Windows.Forms.ListBox
        Me.lstTemas = New System.Windows.Forms.ListBox
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtBuscar = New System.Windows.Forms.TextBox
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSoportesSeleccionados
        '
        Me.lstSoportesSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSoportesSeleccionados.Location = New System.Drawing.Point(420, 21)
        Me.lstSoportesSeleccionados.Name = "lstSoportesSeleccionados"
        Me.lstSoportesSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSoportesSeleccionados.Size = New System.Drawing.Size(370, 236)
        Me.lstSoportesSeleccionados.TabIndex = 1
        '
        'cmdAgregarSoporte
        '
        Me.cmdAgregarSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarSoporte.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarSoporte.Location = New System.Drawing.Point(379, 58)
        Me.cmdAgregarSoporte.Name = "cmdAgregarSoporte"
        Me.cmdAgregarSoporte.Size = New System.Drawing.Size(35, 35)
        Me.cmdAgregarSoporte.TabIndex = 2
        Me.cmdAgregarSoporte.Text = "4"
        '
        'cmdQuitarSoporte
        '
        Me.cmdQuitarSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarSoporte.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarSoporte.Location = New System.Drawing.Point(379, 140)
        Me.cmdQuitarSoporte.Name = "cmdQuitarSoporte"
        Me.cmdQuitarSoporte.Size = New System.Drawing.Size(35, 35)
        Me.cmdQuitarSoporte.TabIndex = 4
        Me.cmdQuitarSoporte.Text = "3"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(-4, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(812, 3)
        Me.Label1.TabIndex = 4
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(707, 544)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(621, 544)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdAgregarSoporteTodos
        '
        Me.cmdAgregarSoporteTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarSoporteTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarSoporteTodos.Location = New System.Drawing.Point(379, 99)
        Me.cmdAgregarSoporteTodos.Name = "cmdAgregarSoporteTodos"
        Me.cmdAgregarSoporteTodos.Size = New System.Drawing.Size(35, 35)
        Me.cmdAgregarSoporteTodos.TabIndex = 3
        Me.cmdAgregarSoporteTodos.Text = "8"
        '
        'cmdQuitarSoporteTodos
        '
        Me.cmdQuitarSoporteTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarSoporteTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarSoporteTodos.Location = New System.Drawing.Point(378, 181)
        Me.cmdQuitarSoporteTodos.Name = "cmdQuitarSoporteTodos"
        Me.cmdQuitarSoporteTodos.Size = New System.Drawing.Size(36, 35)
        Me.cmdQuitarSoporteTodos.TabIndex = 5
        Me.cmdQuitarSoporteTodos.Text = "7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Soportes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(417, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Soportes Seleccionados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(436, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Temas Seleccionados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Temas"
        '
        'cmdQuitarTemaTodos
        '
        Me.cmdQuitarTemaTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTemaTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarTemaTodos.Location = New System.Drawing.Point(378, 441)
        Me.cmdQuitarTemaTodos.Name = "cmdQuitarTemaTodos"
        Me.cmdQuitarTemaTodos.Size = New System.Drawing.Size(37, 35)
        Me.cmdQuitarTemaTodos.TabIndex = 16
        Me.cmdQuitarTemaTodos.Text = "7"
        '
        'cmdAgregarTemaTodos
        '
        Me.cmdAgregarTemaTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTemaTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarTemaTodos.Location = New System.Drawing.Point(378, 359)
        Me.cmdAgregarTemaTodos.Name = "cmdAgregarTemaTodos"
        Me.cmdAgregarTemaTodos.Size = New System.Drawing.Size(37, 35)
        Me.cmdAgregarTemaTodos.TabIndex = 14
        Me.cmdAgregarTemaTodos.Text = "8"
        '
        'cmdQuitarTema
        '
        Me.cmdQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTema.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarTema.Location = New System.Drawing.Point(378, 400)
        Me.cmdQuitarTema.Name = "cmdQuitarTema"
        Me.cmdQuitarTema.Size = New System.Drawing.Size(37, 35)
        Me.cmdQuitarTema.TabIndex = 15
        Me.cmdQuitarTema.Text = "3"
        '
        'cmdAgregarTema
        '
        Me.cmdAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTema.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarTema.Location = New System.Drawing.Point(379, 319)
        Me.cmdAgregarTema.Name = "cmdAgregarTema"
        Me.cmdAgregarTema.Size = New System.Drawing.Size(36, 35)
        Me.cmdAgregarTema.TabIndex = 13
        Me.cmdAgregarTema.Text = "4"
        '
        'lstTemasSeleccionados
        '
        Me.lstTemasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTemasSeleccionados.Location = New System.Drawing.Point(421, 280)
        Me.lstTemasSeleccionados.Name = "lstTemasSeleccionados"
        Me.lstTemasSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTemasSeleccionados.Size = New System.Drawing.Size(370, 236)
        Me.lstTemasSeleccionados.TabIndex = 12
        '
        'lstTemas
        '
        Me.lstTemas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTemas.Location = New System.Drawing.Point(3, 280)
        Me.lstTemas.Name = "lstTemas"
        Me.lstTemas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTemas.Size = New System.Drawing.Size(369, 236)
        Me.lstTemas.Sorted = True
        Me.lstTemas.TabIndex = 11
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
        Me.grdBuscar.Location = New System.Drawing.Point(3, 47)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(369, 210)
        Me.grdBuscar.TabIndex = 20
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(3, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(369, 20)
        Me.txtBuscar.TabIndex = 19
        '
        'frmFiltrarSoporteTema
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdQuitarTemaTodos)
        Me.Controls.Add(Me.cmdAgregarTemaTodos)
        Me.Controls.Add(Me.cmdQuitarTema)
        Me.Controls.Add(Me.cmdAgregarTema)
        Me.Controls.Add(Me.lstTemasSeleccionados)
        Me.Controls.Add(Me.lstTemas)
        Me.Controls.Add(Me.cmdQuitarSoporteTodos)
        Me.Controls.Add(Me.cmdAgregarSoporteTodos)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdQuitarSoporte)
        Me.Controls.Add(Me.cmdAgregarSoporte)
        Me.Controls.Add(Me.lstSoportesSeleccionados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltrarSoporteTema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir Soporte"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables privadas"
    Private mId_plaza As Integer
    Private mId_medio As Integer
    Private mId_tipo_soporte As Integer
    Private mCancelado, mPrimeraCarga As Boolean
    Private mListaSoportes, mListaTemas As ArrayList
    Private Item, ItemTema As ItemLista
    Private dtTemas As New DataTable
    Dim dtSoportes As DataTable
#End Region

#Region "Propiedades Publicas"
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

    Public Property PrimeraCarga() As Boolean
        Get
            Return mPrimeraCarga
        End Get
        Set(ByVal Value As Boolean)
            mPrimeraCarga = Value
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

    Public Property ListaTemas() As ArrayList
        Get
            If mListaTemas Is Nothing Then
                mListaTemas = New ArrayList
            End If

            Return mListaTemas
        End Get
        Set(ByVal Value As ArrayList)
            mListaTemas = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmFiltrarSoporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim S As New Soportes
        Dim T As New Temas

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

        'JJP - Busco sólo los soportes vigentes y se carga el grid.
        dtSoportes = S.FiltrarSoportesMMSVigencia(Me.Id_medio, Me.Id_tipo_soporte, Me.id_plaza, True)
        CargarGrid(dtSoportes)

        dtTemas.CaseSensitive = True
        T.Id_campania = Activo.IDCampaña
        dtTemas = T.ObtenerTemasPorCampaña(True)

        Listas.CargarList(lstTemas, dtTemas, "ID_TEMA", "TEMA")
        ConfigurarControles()

    End Sub

    Private Sub cmdAgregarSoporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSoporte.Click
        AgregarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Private Sub cmdAgregarSoporteTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarSoporteTodos.Click
        AgregarSoporteTodos()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub

    Private Sub cmdQuitarSoporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarSoporte.Click
        SacarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()

    End Sub

    Private Sub cmdQuitarSoporteTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarSoporteTodos.Click
        SacarSoporteTodos()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()

    End Sub

    Private Sub lstSoportesSeleccionados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSoportesSeleccionados.DoubleClick
        SacarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Select()

    End Sub

    Private Sub cmdAgregarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTema.Click
        If Me.lstTemas.Items.Count = 0 Or Me.lstTemas.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        AgregarTema()
    End Sub

    Private Sub cmdAgregarTemaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarTemaTodos.Click
        AgregarTemaTodos()
    End Sub

    Private Sub cmdQuitarTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTema.Click
        SacarTema()
    End Sub

    Private Sub cmdQuitarTemaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitarTemaTodos.Click
        SacarTemaTodos()
    End Sub

    Private Sub lstTemas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTemas.DoubleClick
        If Me.lstTemas.Items.Count = 0 Or Me.lstTemas.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        AgregarTema()
    End Sub

    Private Sub lstTemasSeleccionados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTemasSeleccionados.DoubleClick
        SacarTema()
    End Sub

    Private Sub lstTemas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTemas.Click
        If Me.lstTemas.Items.Count = 0 Then
            Exit Sub
        End If
        ItemTema = lstTemas.SelectedItem
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If mPrimeraCarga Then
            If Me.lstSoportesSeleccionados.Items.Count = 0 Then
                Mensajes.Mensaje("Debe Seleccionar al menos un Soporte", TipoMensaje.Informacion)
                Exit Sub
            End If
            If Me.lstTemasSeleccionados.Items.Count = 0 Then
                Mensajes.Mensaje("Debe Seleccionar al menos un Tema", TipoMensaje.Informacion)
                Exit Sub
            End If
        Else
            If Me.lstSoportesSeleccionados.Items.Count = 0 AndAlso Me.lstTemasSeleccionados.Items.Count = 0 Then
                Mensajes.Mensaje("Debe Seleccionar al menos un Soporte o un Tema", TipoMensaje.Informacion)
                Exit Sub
            End If
        End If

        Me.ListaSoportes.AddRange(Me.lstSoportesSeleccionados.Items)
        Me.ListaTemas.AddRange(Me.lstTemasSeleccionados.Items)
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
#End Region

#Region "Metodos Privados"
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

    Private Sub AgregarSoporteTodos()
        Dim dr As DataRow

        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grdBuscar.Rows()
            dr = dtSoportes.Select("ID_SOPORTE = " & fila.Cells("ID_SOPORTE").Value)(0)
            AgregarSoporte(dr)
        Next

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

    Private Sub AgregarTema()
        Dim Agregar As Boolean
        Dim Material As String
        Dim IdTema As String
        Dim Filtro As StringBuilder
        Dim CantidadElementos, Index, CantidadNoAgregar As Integer
        Dim Cargas As New SortedList
        Dim CargasNoAgregar As New SortedList

        Me.lstTemasSeleccionados.ValueMember = "ID"
        Me.lstTemasSeleccionados.DisplayMember = "Descripcion"

        For Index = 0 To Me.lstTemas.SelectedItems.Count - 1
            Agregar = True
            IdTema = CType(Me.lstTemas.SelectedItems.Item(Index), ItemLista).ID
            Filtro = New StringBuilder
            Filtro.Append("Id_Tema = '")
            Filtro.Append(IdTema)
            Filtro.Append("'")
            For Each Tema As DataRow In dtTemas.Select(Filtro.ToString)
                If Tema("Id_Material") = "-1" Then
                    Agregar = False
                End If
            Next
            If Agregar Then
                CantidadElementos += 1
                Cargas.Add(CantidadElementos, Me.lstTemas.SelectedItems.Item(Index))
            Else
                CantidadNoAgregar += 1
                CargasNoAgregar.Add(CantidadNoAgregar, IdTema)
            End If
        Next

        Call MostrarMensajeError(CargasNoAgregar)

        For Index = 1 To Cargas.Count
            Me.lstTemasSeleccionados.Items.Add(Cargas(Index))
            Me.lstTemas.Items.Remove(Cargas(Index))
        Next
    End Sub

    Private Sub MostrarMensajeError(ByVal pCargasNoAgregar As SortedList)
        Dim MensajeError As New StringBuilder
        Dim Index As Integer

        If pCargasNoAgregar.Count = 0 Then Exit Sub

        If pCargasNoAgregar.Count > 1 Then
            MensajeError.Append("Los temas ")
        Else
            MensajeError.Append("El tema ")
        End If
        For Index = 1 To pCargasNoAgregar.Count
            MensajeError.Append(pCargasNoAgregar(Index))
            If Index < pCargasNoAgregar.Count Then
                MensajeError.Append(",")
            End If
        Next
        If pCargasNoAgregar.Count > 1 Then
            MensajeError.Append(" seleccionados no tienen un material asignado.")
        Else
            MensajeError.Append(" seleccionado no tiene un material asignado.")
        End If
        If MensajeError.Length > 0 Then
            Mensajes.Mensaje(MensajeError.ToString, TipoMensaje.Informacion)
        End If
    End Sub

    Private Sub AgregarTemaTodos()
        For Index As Integer = 0 To Me.lstTemas.Items.Count - 1
            Me.lstTemas.SetSelected(Index, True)
        Next
        Call AgregarTema()
    End Sub

    Private Sub SacarTema()
        While Not Me.lstTemasSeleccionados.SelectedItem Is Nothing
            Me.lstTemas.Items.Add(Me.lstTemasSeleccionados.SelectedItem)
            Me.lstTemasSeleccionados.Items.Remove(Me.lstTemasSeleccionados.SelectedItem)
        End While
    End Sub

    Private Sub SacarTemaTodos()
        Me.lstTemas.Items.AddRange(Me.lstTemasSeleccionados.Items)
        Me.lstTemasSeleccionados.Items.Clear()
    End Sub
#End Region

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Filtro As String

        Dim Texto As String = txtBuscar.Text
        Texto = Texto.Replace("'", "''")
        Filtro = "DESCRIPCION like '%" & Texto & "%'"

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = Me.FiltrarDT(dtSoportes, Filtro, "DESCRIPCION ASC")
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

    Private Sub txtBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        If e.KeyCode = Keys.Enter And Me.grdBuscar.Selected.Rows.Count = 1 Then
            cmdAgregarSoporte_Click(txtBuscar, System.EventArgs.Empty)
        End If

        If e.KeyCode = Keys.Down Then
            Me.grdBuscar.Select()
            If Me.grdBuscar.Rows.Count > 0 Then
                grdBuscar.Rows(0).Selected = True
            End If
        End If

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

    Private Sub ConfigurarControles()
        Me.lstSoportesSeleccionados.ValueMember = "ID"
        Me.lstSoportesSeleccionados.DisplayMember = "Descripcion"

        grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
    End Sub

    Private Sub AgregarItem(ByVal Lista As ListBox, ByVal dr As DataRow)
        Item = New ItemLista
        Item.ID = IIf(IsDBNull(dr("ID_SOPORTE")), 0, dr("ID_SOPORTE"))
        Item.Descripcion = IIf(IsDBNull(dr("DESCRIPCION")), "", dr("DESCRIPCION"))

        Lista.Items.Add(Item)

    End Sub

    Private Sub grdBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdBuscar.KeyDown

        If e.KeyCode = Keys.Enter And Me.grdBuscar.Selected.Rows.Count = 1 Then
            cmdAgregarSoporte_Click(txtBuscar, System.EventArgs.Empty)
        End If

    End Sub

    Private Sub grdBuscar_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grdBuscar.DoubleClickRow
        AgregarSoporte()

        grdBuscar.DataSource = dtSoportes
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub
End Class




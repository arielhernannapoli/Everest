Imports Infragistics
Imports Infragistics.Win
Public Class frmCargaTarifa
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtSoporte As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuOpciones As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCargaTarifa))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.mnuOpciones = New System.Windows.Forms.ContextMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.txtSoporte = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Lime
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(811, 28)
        Me.ToolBar1.TabIndex = 58
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Tag = "nuevo"
        Me.ToolBarButton1.ToolTipText = "Nuevo"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 2
        Me.ToolBarButton2.Tag = "guardar"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 7
        Me.ToolBarButton3.Tag = "imprimir"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 6
        Me.ToolBarButton5.Tag = "borrar"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 3
        Me.ToolBarButton6.Tag = "nuevo2"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGrid1.ContextMenu = Me.mnuOpciones
        Me.UltraGrid1.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance1
        Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.UltraGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UltraGrid1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.UltraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance4
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Appearance5.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.UltraGrid1.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.UltraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.UltraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.Location = New System.Drawing.Point(3, 66)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(805, 437)
        Me.UltraGrid1.TabIndex = 63
        '
        'mnuOpciones
        '
        Me.mnuOpciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Nuevo a partir del Seleccionado"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Eliminar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitulo.Location = New System.Drawing.Point(1, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(807, 27)
        Me.lblTitulo.TabIndex = 88
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSoporte
        '
        Me.txtSoporte.BackColor = System.Drawing.SystemColors.Control
        Me.txtSoporte.Location = New System.Drawing.Point(430, 40)
        Me.txtSoporte.Name = "txtSoporte"
        Me.txtSoporte.Size = New System.Drawing.Size(247, 19)
        Me.txtSoporte.TabIndex = 92
        Me.txtSoporte.Text = "txtSoporte"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Control
        Me.txtCliente.Location = New System.Drawing.Point(55, 39)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(216, 19)
        Me.txtCliente.TabIndex = 91
        Me.txtCliente.Text = "txtCliente"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 18)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Soporte:"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 4
        Me.ToolBarButton7.Tag = "soporte"
        Me.ToolBarButton7.ToolTipText = "Cambiar Soporte"
        '
        'frmCargaTarifa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(811, 504)
        Me.Controls.Add(Me.txtSoporte)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCargaTarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Tarifas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mCeldaActiva As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim FechaElegida As Date
    Public Index As Integer
    Public id_medio As Integer
    Public id_cliente As Integer
    Public id_soporte As Integer
    Public solovigentes As Boolean
    Public desccliente As String
    Public descsoporte As String
    Public fvigencia As Date
    Public TarifaElegida As Long
    Public tipoSoporte As TipoAudiencia
    Dim findeanio As New Date(Now.Date.Year, 12, 31)

    Dim x As Integer, y As Integer

    Dim t As New Tarifas_tv
    Public Property CeldaActiva() As Infragistics.Win.UltraWinGrid.UltraGridCell
        Get
            Return mCeldaActiva
        End Get
        Set(ByVal Value As Infragistics.Win.UltraWinGrid.UltraGridCell)
            mCeldaActiva = Value
        End Set
    End Property
    Public Sub cargarGrid()


        t.Id_medio = Me.id_medio
        t.Id_cliente = Me.id_cliente
        t.Id_soporte = Me.id_soporte
        t.F_inicio_vig = Me.fvigencia


        If solovigentes Then
            UltraGrid1.DataSource = t.TraerTodosConVigencia()
        Else
            UltraGrid1.DataSource = t.TraerTodosSinVigencia()
        End If

        Listas.CambiarTituloColumna(Me.UltraGrid1, "descripcion", "TELEREPORT")
    End Sub
    Private Sub frmCargaTarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtCliente.Text = desccliente
        txtSoporte.Text = descsoporte
        cargarGrid()

    End Sub

    Private Sub CambiarSoporte()
        Dim F As New frmElegirTarifa
        F.PopularCliente = True
        F.MedioSeleccionado = Me.id_medio
        f.idCliente = me.id_cliente
        F.ShowDialog()

        If F.Cancelar Then
            Exit Sub
        Else
            Dim ct As New frmCargaTarifa
            Dim s As New Soportes

            s.Id_soporte = F.idSoporte
            s.Id_medio = F.MedioSeleccionado
            s.BuscarPorID_Soporte()

            Me.id_cliente = F.idCliente
            Me.id_soporte = F.idSoporte
            Me.desccliente = F.DescripcionCliente
            Me.descsoporte = F.DescripcionSoporte
            Me.tipoSoporte = IIf(s.Id_tipo_soporte = 1, 0, 1)
            ' linea agregada gwinkler
            Me.solovigentes = F.SoloVigentes
            ' fin agrgado
            Me.fvigencia = F.dtpFecha.DateTime.Date
            Me.id_medio = F.idmedio

            txtCliente.Text = desccliente
            txtSoporte.Text = descsoporte
            cargarGrid()
        End If
        F.Close()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        Select Case e.Button.Tag
            Case "nuevo"
                Dim f As New frmAltaTarifa
                f.id_cliente.Text = Me.id_cliente
                f.id_soporte.Text = Me.id_soporte
                f.txtCliente.Text = Me.desccliente
                f.txtSoporte.Text = Me.descsoporte
                f.TipoSoporte = Me.tipoSoporte
                f.inicializarComponentes()

                f.ShowDialog()

                cargarGrid()

            Case "guardar"

                Dim i As Integer
                Dim id As Integer
                Dim f_fin As Date
                Dim f_inicio As Date

                Dim dt As New DataTable
                dt = UltraGrid1.DataSource.GetChanges

                If Not dt Is Nothing Then
                    Dim dr As DataRow
                    For Each dr In dt.Rows
                        id = dr("id_Tarifa_Tv")

                        f_inicio = dr("Inicio Vigencia")
                        f_fin = dr("Fin Vigencia")

                        If f_inicio > f_fin Then
                            Mensajes.Mensaje("Programa: " + dr(1) + Chr(10) + Chr(13) + "La fecha de fin de vigencia debe ser posterior o igual a la fecha de inicio de vigencia. ")
                        Else
                            Try
                                t.ActualizarVigencia(id, f_fin)
                            Catch ex As Oracle.DataAccess.Client.OracleException
                                Mensajes.Mensaje("Error al intentar guardar los datos")
                            End Try
                        End If
                    Next
                End If

            Case "imprimir"

            Case "nuevo2"
                Me.NuevoApertirDeexistente()

            Case "borrar"
                Borrar()

            Case "soporte"
                Call CambiarSoporte()

        End Select
    End Sub
    Private Sub Borrar()
        If UltraGrid1.ActiveRow Is Nothing Then
            Exit Sub
        End If
        ' Dim indice As Integer
        Dim mensajero As New Mensajes
        Dim res As Integer

        'indice = UltraGrid1.ActiveRow.Index

        Dim st As String
        Dim tt As New Tarifas_tv
        tt.Id_tarifa_tv = UltraGrid1.Rows(Index).Cells(0).Value()

        Dim tienePautasAsociadas As Boolean = Int32.Parse((tt.TienePautasAsociadas().Rows(0)("TIENE_PAUTAS").ToString())) = 1

        If (tienePautasAsociadas) Then
            MsgBox("La tarifa seleccionada tiene pautas asociadas y no puede ser eliminada", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        st = "¿Esta seguro que desea borrar el programa:  " + UltraGrid1.Rows.GetRowWithListIndex(Index).Cells(1).Value()
        st = st + "?  Recuerde que esta opcion es irreversible y que si hay pautas asociadas a esa tarifa desaparecerá la relacion."
        If mensajero.Mensaje(st, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then ' si
            ' borra
            MsgBox("Chan! eliminado" + CStr(UltraGrid1.Rows(Index).Cells(0).Value()))
            

            tt.Borrar()
            cargarGrid()
        End If
    End Sub
    Private Function AnularVigencia() As Boolean


        Dim T As New Tarifas_tv

        T.Id_tarifa_tv = UltraGrid1.ActiveRow.Cells(0).Value
        T.BuscarPorID()



        Try
            T.F_fin_vig = FechaElegida.AddDays(-1)
            T.Modificar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub CargarDatos()
        Dim tt As New Tarifas_tv
        'Dim indice As Integer
        Dim id_Tarifa As Int64
        'indice =' mCeldaActiva.Row.Index
        id_Tarifa = Me.TarifaElegida
        tt.Id_tarifa_tv = id_Tarifa
        tt.BuscarPorID()

        Dim f As New frmAltaTarifa
        f.Text = "Nueva tarifa"
        f.id_cliente.Text = Me.id_cliente
        f.id_soporte.Text = Me.id_soporte
        f.txtCliente.Text = Me.desccliente
        f.txtSoporte.Text = Me.descsoporte


        ' f.id_tarifa_tv.Text = tt.Id_tarifa_tv

        f.txtPrograma.Text = tt.Programa
        If tt.D_l = "X" Then
            f.ChkLunes.Checked = True
        End If
        If tt.D_m = "X" Then
            f.ChkMartes.Checked = True
        End If
        If tt.D_x = "X" Then
            f.ChkMiercoles.Checked = True
        End If
        If tt.D_j = "X" Then
            f.ChkJueves.Checked = True
        End If
        If tt.D_v = "X" Then
            f.ChkViernes.Checked = True
        End If
        If tt.D_s = "X" Then
            f.ChkSabado.Checked = True
        End If
        If tt.D_d = "X" Then
            f.ChkDomingo.Checked = True
        End If
        f.TxtHInicio.Text = Format(tt.H_desde, "00") + ":" + Format(tt.M_desde, "00")
        f.TxtHFin.Text = Format(tt.H_hasta, "00") + ":" + Format(tt.M_hasta, "00")
        'f.DtpFInicio.Value = tt.F_inicio_vig
        'Cambio para que Gudarde La fecha Nueva 


        f.DtpFFin.Value = findeanio
        f.DtpFInicio.Value = FechaElegida


        If tt.Ind_especial = "1" Then
            f.ChkEvento.Checked = True
        End If

        f.txtIDPrograma.Text = tt.Id_programa
        f.TxtTarifa.Text = tt.Bruto

        'f.ocultar_agregar()
        f.pasa_tarifa_Tv(tt)

        f.ShowDialog()
        If Not f.Cancelar Then
            cargarGrid()
        End If
    End Sub

    Private Function devolverhora(ByVal s As String) As Integer
        ' devuelve la hora dado un string en formato hh:mm
        Dim i As Integer

        i = CInt(s.Split(":").GetValue(0))
        Return i

    End Function

    Private Function devolverminutos(ByVal s As String) As Integer
        ' devuelve los minutos dado un string en formato hh:mm
        Dim i As Integer

        i = CInt(s.Split(":").GetValue(1))
        Return i
    End Function


    Private Sub UltraGrid1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGrid1.InitializeLayout

        Dim i As Integer

        UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1

        With UltraGrid1.DisplayLayout.Bands(0)

            For i = 0 To 15
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next

            ' id_Tarifa_Tv
            .Columns(0).Hidden = True
            'programa de tarifas_tv
            .Columns(1).Width = 200
            .Columns(1).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            ' Programa de programas
            .Columns(2).Width = 200
            .Columns(2).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            ' l m x j v s d
            For i = 3 To 9
                .Columns(i).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns(i).Width = 20
            Next
            .Columns(8).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(9).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke


            ' h inicio
            .Columns(10).Width = 60
            .Columns(10).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            ' h fin
            .Columns(11).Width = 60
            .Columns(11).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            ' f vig ini
            .Columns(12).Width = 100
            .Columns(12).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            ' f vig fin
            .Columns(13).Width = 100
            .Columns(13).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownCalendar
            .Columns(13).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns(13).CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit

            ' evento
            .Columns(14).Width = 20
            ' importe
            .Columns(15).Width = 80
            '  .Columns(14).CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
            .Columns(15).Format = "C"
            .Columns(15).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns(15).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

        End With

    End Sub

    Private Function ControlarDobleClick() As Boolean
        Dim i As Integer

        'detecta que se hizo click sobre la barra
        i = Me.Left + Me.UltraGrid1.Left + Me.UltraGrid1.Width

        If x > i - 15 And x < i + 10 Then
            Return False
        End If

        Return True
        'cmdAceptar_Click(Me, System.EventArgs.Empty)
    End Function

    Private Sub UltraGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid1.DoubleClick
        If Me.UltraGrid1.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Dim f As New frmAltaTarifa

        f.idSoporte = Me.id_soporte
        f.IdCliente = Me.id_cliente
        f.DesCliente = Me.desccliente
        f.DesSoporte = Me.descsoporte

        f.CargarFormulario(UltraGrid1.ActiveRow.Cells(0).Value, True)
        If Not f.Cancelar Then
            cargarGrid()
        End If


    End Sub

    Private Sub UltraGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UltraGrid1.KeyDown

        Select Case e.KeyCode
            Case Keys.C
                If e.Control = True Then
                    If UltraGrid1.Selected.Cells.Count = 1 Then ' SOLO COPIA 1 CELDA POR VEZ
                        Dim cellSelected As Infragistics.Win.UltraWinGrid.UltraGridCell

                        cellSelected = UltraGrid1.Selected.Cells(0)
                        If cellSelected.Column.Index = 13 Then
                            Dim columna As Integer
                            Dim indice As Integer
                            Dim valor As Date

                            indice = UltraGrid1.ActiveRow.Index
                            valor = UltraGrid1.Rows(indice).Cells(13).Value()

                            Clipboard.SetDataObject(CType(valor, String), True)

                        End If
                    End If
                End If
            Case Keys.V ' pegar
                If e.Control = True Then
                    If UltraGrid1.Selected.Cells.Count > 0 Then ' se puede pegar si hay mas de 0 celdas seleccionadas

                        Dim cellSelected As Infragistics.Win.UltraWinGrid.UltraGridCell

                        For Each cellSelected In UltraGrid1.Selected.Cells
                            If cellSelected.Column.Index = 13 Then
                                Dim columna As Integer
                                Dim indice As Integer
                                Dim valor As Date

                                Dim iData As IDataObject = Clipboard.GetDataObject()
                                cellselected.Value = CType(iData.GetData(DataFormats.Text), Date)

                            End If
                        Next


                    End If
                End If
        End Select

    End Sub

    Private Sub UltraGrid1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UltraGrid1.MouseMove
        x = e.X
        y = e.Y
    End Sub


    Private Sub UltraGrid1_BeforeCellActivate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableCellEventArgs) Handles UltraGrid1.BeforeCellActivate
        Index = e.Cell.Row.Index

    End Sub
    Private Sub NuevoApertirDeexistente()
        If UltraGrid1.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Dim f As New FrmVigencia
        ' f.CeldaActiva = mCeldaActiva
        f.ShowDialog()
        If f.Cerrado Then
            Exit Sub
        End If
        Me.FechaElegida = f.Fecha
        ' Me.mCeldaActiva = f.CeldaActiva
        AnularVigencia()
        cargarGrid()
        CargarDatos()
        cargarGrid()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        NuevoApertirDeexistente()
    End Sub



    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Borrar()
    End Sub

    Private Sub UltraGrid1_BeforeRowActivate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.BeforeRowActivate
        If e.Row Is Nothing Then
            Exit Sub
        End If
        Try
            Me.TarifaElegida = e.Row.Cells(0).Value
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
End Class

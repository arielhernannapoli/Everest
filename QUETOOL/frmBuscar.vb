Imports System.Reflection

Public Enum BuscarPor
    ID
    Descripcion
End Enum

Public Class frmBuscar
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
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grdBuscar As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(8, 48)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(428, 21)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(278, 430)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(358, 430)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
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
        Me.lblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(434, 34)
        Me.lblTitulo.TabIndex = 87
        Me.lblTitulo.Text = "Buscar [Que Buscar]"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(-8, 420)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(514, 2)
        Me.Label18.TabIndex = 88
        '
        'grdBuscar
        '
        Me.grdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdBuscar.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdBuscar.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.grdBuscar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Me.grdBuscar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdBuscar.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.grdBuscar.FlatMode = True
        Me.grdBuscar.Location = New System.Drawing.Point(8, 76)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(428, 336)
        Me.grdBuscar.TabIndex = 1
        '
        'frmBuscar
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(442, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmBuscar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '// *** VARIABLES Y METODOS INTERNOS
#Region "Variables Internas"
    'guarda la seccion o tabla o datos que hay que buscar
    Dim QueBuscar As SeccionActiva
    'text box donde dejar los datos
    Dim TextDescripcion As TextBox
    Dim TextID As TextBox
    'nombre de la propiedad que devuelve en el TAG del text
    Dim PropiedadID As String
    Dim PropiedadDescripcion As String
    'guarda un ID auxiliar, por ejemplo para buscar todos las provincias de un pais
    Dim AuxID, AuxID2, AuxID3 As Integer

    'sirve para que no se produzca el efecto que cuando se mueve para abajo en el list, este no baja
    Dim SeMovioAbajo As Boolean = False

    Dim BuscarPor As BuscarPor

    Dim Dt As DataTable

    Dim TituloID As String
    Dim TituloDescripcion As String
#End Region

#Region "Metodos Internos"

    Public Sub CargarFormulario(ByVal QueBuscar As SeccionActiva, ByVal TextDescripcion As TextBox, ByVal TextID As TextBox, ByVal PropiedadID As String, ByVal PropiedadDescripcion As String, ByVal TituloID As String, ByVal TituloDescripcion As String, Optional ByVal AuxID As Integer = 0, Optional ByVal AuxID2 As Integer = 0, Optional ByVal AuxID3 As Integer = 0)
        Me.QueBuscar = QueBuscar
        Me.TextDescripcion = TextDescripcion
        Me.TextID = TextID
        Me.AuxID = AuxID
        Me.AuxID2 = AuxID2
        Me.AuxID3 = AuxID3
        Me.PropiedadID = PropiedadID
        Me.PropiedadDescripcion = PropiedadDescripcion

        Me.TituloID = TituloID
        Me.TituloDescripcion = TituloDescripcion

        Titulo = TituloDescripcion

        Buscar()
    End Sub

    Private WriteOnly Property Titulo() As String
        Set(ByVal Value As String)
            Me.lblTitulo.Text = "Buscar " & Value
        End Set
    End Property

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

    ''' <summary>
    ''' Establece la estructura del DataTable segun el medio.
    ''' </summary>
    ''' <returns>DataTable con la estructura.</returns>
    ''' <remarks></remarks> 
    Private Function SetFormatDtSoportesConvenios() As DataTable

        Dim _dtReturn As New DataTable
        If Activo.IDMedio = 6 Then
            _dtReturn.Columns.Add("ID_SOPORTE")
            _dtReturn.Columns.Add("DESCRIPCION")
            _dtReturn.Columns.Add("ID_MEDIO")
        Else
            _dtReturn.Columns.Add("ID_SOPORTE")
            _dtReturn.Columns.Add("DESCRIPCION")
            _dtReturn.Columns.Add("ID_MEDIO")
            _dtReturn.Columns.Add("ID_PROVEEDOR")
            _dtReturn.Columns.Add("ID_PROVEEDOR")
            _dtReturn.Columns.Add("DESPROVEEDOR")
            _dtReturn.Columns.Add("DESPLAZA")
        End If

        Dim _data As DataRow

        _data = _dtReturn.NewRow()

        _dtReturn.Rows.Add(_data)

        Return _dtReturn

    End Function

#End Region

#Region "Eventos de los controles del formulario"

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.TextDescripcion.Text = ""
        Me.TextID.Text = ""
    End Sub


    Public Sub Buscar()
        '*********************************************
        '*   AGREGAR EL CODIGO PARA BUSCAR ACA !!!   *
        '*********************************************
        Select Case Me.QueBuscar
            Case SeccionActiva.Cliente
                Dim U As New Usuario
                U.IDPerfil_Datos = Activo.IDPerfil_Datos
                'data set auxiliar para buscar datos
                Dt = U.obtenerClientes
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                ''OCULTAMOS LOS CAMPOS ID_PAIS ID_GRUPO DANIEL CAIME
                grdBuscar.DisplayLayout.Bands(0).Columns("id_pais").Hidden = True
                grdBuscar.DisplayLayout.Bands(0).Columns("id_grupo").Hidden = True
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
                ' agregado gwinkler
            Case SeccionActiva.Soporte
                Dim s As New Soportes
                s.Id_medio = AuxID
                If AuxID2 = 0 Then
                    Dt = s.TraerIDDescripcion
                Else
                    s.Id_tipo_soporte = AuxID2
                    s.Id_soporte = 0
                    Dt = s.ObtenerSoportesTipoSoporteID
                End If
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                'grdBuscar.ShowColumnChooser("DESCRIPCION")
                'grdBuscar.ShowColumnChooser("ID_SOPORTE")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            Case SeccionActiva.SoportesConvenios
                Dim s As New Soportes
                s.Id_medio = AuxID
                s.Id_tipo_soporte = AuxID2
                ''Warning: Jsperk - Cambiar por el que esta en el activo filtrandolo por ID_SOPORTE y MEDIO.
                ''Dt = s.TraerIDDescripcion '.TraerSopConvenio 
                Dt = s.TraerSoportesConvenio
                ''Dt = Me.SetFormatDtSoportesConvenios()

                grdBuscar.DataSource = Dt 'Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).Header.Caption = Me.TituloID
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).Width = 200
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).Width = 100
                'For Each C In Grilla.DisplayLayout.Bands(0).Columns
                '    If GrillAdmin.EsColumnaCalendario(C) Then
                '        C.Width = Tamaño
                '    End If
                'Next
                ' agregado gwinkler
            Case SeccionActiva.Programa
                Dim s As New Programas
                Dt = s.TraerIDDescripcion(AuxID2, AuxID)
                grdBuscar.DataSource = Dt
                'grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            Case SeccionActiva.Franja
                Dim F As New Franjas
                Dt = F.ObtenerPorCliente(Activo.IDCliente)
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            Case SeccionActiva.Materiales
                Dim m As New Materiales
                m.id_medio = AuxID3 'Activo.IDMedio
                m.Id_cliente = AuxID 'Activo.IDCliente
                m.Id_producto = AuxID2
                Dt = m.TraerMateriales()
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            Case SeccionActiva.Producto
                Dim p As New Productos
                p.Id_cliente = Me.AuxID
                Dt = p.TraerProductos
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
            Case SeccionActiva.Anunciantes
                Dim C As New Control_Macheo
                Dt = C.BuscarAnunciantes(0)
                grdBuscar.DataSource = Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC")
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).Header.Caption = Me.TituloID
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).Header.Caption = Me.TituloDescripcion
                Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
                Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        End Select

        'ajusta el ancho de las columnas a los datos
        'Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns

        If Me.QueBuscar <> SeccionActiva.Producto Then
            'Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
        Else
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).Hidden = True
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(2).PerformAutoResize()
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).Header.Caption = Me.TituloID
            Me.grdBuscar.DisplayLayout.Bands(0).Columns(2).Header.Caption = Me.TituloDescripcion
        End If
    End Sub

    Private Sub grdBuscar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdBuscar.DoubleClick
        Dim i As Integer

        'detecta que se hizo click en el encabezado de la grilla
        i = Me.Top + Me.grdBuscar.Top

        If Me.MousePosition.Y > i And Me.MousePosition.Y < i + 43 Then
            Exit Sub
        End If

        'detecta que se hizo click sobre la barra
        i = Me.Left + Me.grdBuscar.Left + Me.grdBuscar.Width

        If Me.MousePosition.X > i - 15 And Me.MousePosition.X < i + 10 Then
            Exit Sub
        End If

        cmdAceptar_Click(Me, System.EventArgs.Empty)
    End Sub

    Private Sub grdBuscar_BeforeRowActivate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles grdBuscar.BeforeRowActivate
        'pasa los datos de la grilla al text de destino
        Me.TextID.Text = e.Row.Cells(Me.PropiedadID).Text
        Me.TextDescripcion.Text = e.Row.Cells(Me.PropiedadDescripcion).Text
    End Sub

    Private Sub grdBuscar_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdBuscar.InitializeLayout
        'aplica el formato standard
        With Me.grdBuscar.DisplayLayout.Override
            .AllowDelete = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupBy = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
            .AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
            .AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            .AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
            .AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
            .CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        End With
    End Sub

    Private Sub frmBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cambia los nombres de las columnas

        Me.BuscarPor = BuscarPor.Descripcion

        Select Case QueBuscar
            Case SeccionActiva.Cliente
                Listas.CambiarTituloColumna(Me.grdBuscar, "id_cliente", "Código")
                Listas.CambiarTituloColumna(Me.grdBuscar, "descripcion", "Cliente")
            Case SeccionActiva.Soporte
                Listas.CambiarTituloColumna(Me.grdBuscar, "id_soporte", "Código")
                Listas.CambiarTituloColumna(Me.grdBuscar, "descripcion", "Soporte")
            Case SeccionActiva.Programa
                Listas.CambiarTituloColumna(Me.grdBuscar, "ID_PROGRAMA", "ID")
                Listas.CambiarTituloColumna(Me.grdBuscar, "Descripcion", "Programa")
            Case SeccionActiva.Franja
                Listas.OcultarColumnas(Me.grdBuscar, "id_franja", "h_desde", "h_hasta", "id_cliente")
                Listas.CambiarTituloColumna(Me.grdBuscar, "descripcion", "Franja")
            Case SeccionActiva.Materiales
                Listas.OcultarColumnas(Me.grdBuscar, "id_pais", "id_cliente", "id_producto", "id_medio")
                'Listas.OcultarColumnas(Me.grdBuscar, "id_material", "id_cliente", "id_producto", "id_procedencia", "version", "duracion")
                Listas.CambiarTituloColumna(Me.grdBuscar, "id_material", "Código")
                Listas.CambiarTituloColumna(Me.grdBuscar, "duracion", "Duracion")
                Listas.CambiarTituloColumna(Me.grdBuscar, "Descripcion", "Descripción")
        End Select

        Me.grdBuscar.DisplayLayout.MaxRowScrollRegions = 1

    End Sub

    Private Sub grdBuscar_BeforeSortChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeSortChangeEventArgs) Handles grdBuscar.BeforeSortChange
        If BuscarPor = BuscarPor.Descripcion Then
            BuscarPor = BuscarPor.ID
            Titulo = TituloID
        Else
            BuscarPor = BuscarPor.Descripcion
            Titulo = TituloDescripcion
        End If

        Me.grdBuscar.DataSource = Dt
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If Me.grdBuscar.Rows.Count = 0 Then
            Exit Sub
        End If

        'si no hay filas seleccionadas, sale no deja salir
        If Me.grdBuscar.Selected.Rows.Count = 0 Then
            Me.grdBuscar.Rows(0).Selected = True
        End If

        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Filtro As String

        'arma el filtro (busqueda en cualquier parte de la cadena)

        If BuscarPor = BuscarPor.Descripcion Then
            Dim Texto As String = txtBuscar.Text
            Texto = Texto.Replace("'", "''")
            Filtro = Me.PropiedadDescripcion & " like '%" & Texto & "%'"
        Else
            If txtBuscar.Text <> "" AndAlso IsNumeric(txtBuscar.Text) Then
                Filtro = Me.PropiedadID & " = " & txtBuscar.Text
            End If
        End If

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = Me.FiltrarDT(Dt, Filtro, Me.PropiedadDescripcion & " ASC")
    End Sub

    Private Sub txtBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown
        'si se da enter, ejecuta el Click del cmdAceptar
        If e.KeyCode = Keys.Enter And Me.grdBuscar.Selected.Rows.Count = 0 Then
            cmdAceptar_Click(txtBuscar, System.EventArgs.Empty)
        End If

        If e.KeyCode = Keys.Down Then
            Me.grdBuscar.Select()
        End If
    End Sub

    Private Sub lswBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Me.grdBuscar.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        'si se da enter, ejecuta el Click del cmdAceptar
        If e.KeyCode = Keys.Enter Then
            cmdAceptar_Click(txtBuscar, System.EventArgs.Empty)
        End If
    End Sub

#End Region
End Class


Imports System.Reflection
Imports System.Text
Imports Framework.Mensajes

Public Class frmBuscarPorPeriodo
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
    Friend WithEvents lblperiodoDesde As System.Windows.Forms.Label
    Friend WithEvents DtpPeriodoDesde As QUETOOL.dtpFecha
    Friend WithEvents DtpPeriodoHasta As QUETOOL.dtpFecha
    Friend WithEvents lblPeriodoHasta As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.DtpPeriodoDesde = New QUETOOL.dtpFecha
        Me.DtpPeriodoHasta = New QUETOOL.dtpFecha
        Me.lblperiodoDesde = New System.Windows.Forms.Label
        Me.lblPeriodoHasta = New System.Windows.Forms.Label
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpPeriodoDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpPeriodoHasta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtBuscar.Size = New System.Drawing.Size(316, 21)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(166, 430)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(246, 430)
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
        Me.lblTitulo.Size = New System.Drawing.Size(322, 34)
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
        Me.Label18.Size = New System.Drawing.Size(402, 2)
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
        Me.grdBuscar.Location = New System.Drawing.Point(8, 96)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(316, 312)
        Me.grdBuscar.TabIndex = 1
        '
        'DtpPeriodoDesde
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.DtpPeriodoDesde.Appearance = Appearance1
        Me.DtpPeriodoDesde.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpPeriodoDesde.FlatMode = True
        Me.DtpPeriodoDesde.Location = New System.Drawing.Point(88, 72)
        Me.DtpPeriodoDesde.Name = "DtpPeriodoDesde"
        Me.DtpPeriodoDesde.Size = New System.Drawing.Size(98, 21)
        Me.DtpPeriodoDesde.TabIndex = 89
        Me.DtpPeriodoDesde.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'DtpPeriodoHasta
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.DtpPeriodoHasta.Appearance = Appearance2
        Me.DtpPeriodoHasta.DateTime = New Date(2006, 10, 3, 0, 0, 0, 0)
        Me.DtpPeriodoHasta.FlatMode = True
        Me.DtpPeriodoHasta.Location = New System.Drawing.Point(226, 72)
        Me.DtpPeriodoHasta.Name = "DtpPeriodoHasta"
        Me.DtpPeriodoHasta.Size = New System.Drawing.Size(98, 21)
        Me.DtpPeriodoHasta.TabIndex = 90
        Me.DtpPeriodoHasta.Value = New Date(2006, 10, 3, 0, 0, 0, 0)
        '
        'lblperiodoDesde
        '
        Me.lblperiodoDesde.Location = New System.Drawing.Point(8, 76)
        Me.lblperiodoDesde.Name = "lblperiodoDesde"
        Me.lblperiodoDesde.Size = New System.Drawing.Size(88, 13)
        Me.lblperiodoDesde.TabIndex = 103
        Me.lblperiodoDesde.Text = "Período Desde:"
        '
        'lblPeriodoHasta
        '
        Me.lblPeriodoHasta.Location = New System.Drawing.Point(190, 76)
        Me.lblPeriodoHasta.Name = "lblPeriodoHasta"
        Me.lblPeriodoHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblPeriodoHasta.TabIndex = 105
        Me.lblPeriodoHasta.Text = "Hasta:"
        '
        'frmBuscarPorPeriodo
        '
        Me.AcceptButton = Me.cmdAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancelar
        Me.ClientSize = New System.Drawing.Size(330, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.DtpPeriodoHasta)
        Me.Controls.Add(Me.lblPeriodoHasta)
        Me.Controls.Add(Me.DtpPeriodoDesde)
        Me.Controls.Add(Me.lblperiodoDesde)
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmBuscarPorPeriodo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpPeriodoDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpPeriodoHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Internas"
    'guarda la seccion o tabla o datos que hay que buscar
    Dim QueBuscar As SeccionActiva
    'text box donde dejar los datos
    Dim TextDescripcion As TextBox
    Dim TextID As TextBox
    'nombre de la propiedad que devuelve en el TAG del text
    Dim PropiedadID As String
    Dim PropiedadDescripcion As String
    Dim PropiedadPeriodoDesde As String
    Dim PropiedadPeriodoHasta As String
    'guarda un ID auxiliar, por ejemplo para buscar todos las provincias de un pais
    Dim AuxID As Integer

    'sirve para que no se produzca el efecto que cuando se mueve para abajo en el list, este no baja
    Dim SeMovioAbajo As Boolean = False

    Dim BuscarPor As BuscarPor

    Dim Dt As DataTable

    Dim TituloID As String
    Dim TituloDescripcion As String
#End Region

#Region "Propiedades"
    Private WriteOnly Property Titulo() As String
        Set(ByVal Value As String)
            Me.lblTitulo.Text = "Buscar " & Value
        End Set
    End Property
#End Region

#Region "Metodos Privados"
    Public Sub CargarFormulario(ByVal QueBuscar As SeccionActiva, ByVal TextDescripcion As TextBox, ByVal TextID As TextBox, ByVal PropiedadID As String, ByVal PropiedadDescripcion As String, ByVal PropiedadPeriodoDesde As String, ByVal PropiedadPeriodoHasta As String, ByVal TituloID As String, ByVal TituloDescripcion As String, Optional ByVal AuxID As Integer = 0)
        Me.QueBuscar = QueBuscar
        Me.TextDescripcion = TextDescripcion
        Me.TextID = TextID
        Me.AuxID = AuxID
        Me.PropiedadID = PropiedadID
        Me.PropiedadDescripcion = PropiedadDescripcion
        Me.PropiedadPeriodoDesde = PropiedadPeriodoDesde
        Me.PropiedadPeriodoHasta = PropiedadPeriodoHasta

        Me.TituloID = TituloID
        Me.TituloDescripcion = TituloDescripcion

        Titulo = TituloDescripcion

        Buscar()
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

    Public Sub Buscar()
        Select Case Me.QueBuscar
            Case SeccionActiva.ProductoExterno
                Dim P As New Control_Macheo
                P.Cod_Cli = Me.AuxID
                Dt = P.BuscarSpots(Nothing)
                If Dt Is Nothing Or Dt.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron registros", "Búsqueda")
                Else
                    grdBuscar.DataSource = FiltrarRegistrosRepetidos(Me.FiltrarDT(Dt, "", Me.PropiedadDescripcion & " ASC"))
                    Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).Header.Caption = Me.TituloID
                    Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).Header.Caption = Me.TituloDescripcion
                    Me.grdBuscar.DisplayLayout.Bands(0).Columns(2).Hidden = True
                End If
        End Select

        'ajusta el ancho de las columnas a los datos
        Me.grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
        Me.grdBuscar.DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
    End Sub

    Private Function FiltrarRegistrosRepetidos(ByVal pTable As DataTable) As DataTable
        Dim Existe As Boolean
        Dim TablaNueva As DataTable = pTable.Clone

        For Each dr As DataRow In pTable.Rows
            Existe = False
            For Each drNueva As DataRow In TablaNueva.Rows
                If dr(Me.PropiedadID) = drNueva(Me.PropiedadID) Then
                    Existe = True
                    Exit For
                End If
            Next
            If Not Existe Then
                TablaNueva.ImportRow(dr)
            End If
        Next
        Return TablaNueva
    End Function

    Private Sub FiltrarDatos()
        Dim Filtro As New StringBuilder

        'arma el filtro (busqueda en cualquier parte de la cadena)
        
        If BuscarPor = BuscarPor.Descripcion Then
            Dim Texto As String = txtBuscar.Text
            Texto = Texto.Replace("'", "''")
            Filtro.Append(Me.PropiedadDescripcion)
            Filtro.Append(" like '%")
            Filtro.Append(Texto)
            Filtro.Append("%'")
        Else
            If txtBuscar.Text <> "" AndAlso IsNumeric(txtBuscar.Text) Then
                Filtro.Append(Me.PropiedadID)
                Filtro.Append(" = ")
                Filtro.Append(txtBuscar.Text)
            End If
        End If
        'PropiedadPeriodoDesde
        If Not DtpPeriodoDesde.Value Is Nothing Then
            Filtro.Append(" and ")
            Filtro.Append(Me.PropiedadPeriodoDesde)
            Filtro.Append(" >= '")
            Filtro.Append(Convert.ToDateTime(DtpPeriodoDesde.Value).ToString("dd/MM/yyyy"))
            Filtro.Append("'")
        End If
        If Not DtpPeriodoHasta.Value Is Nothing Then
            Filtro.Append(" and ")
            Filtro.Append(Me.PropiedadPeriodoHasta)
            Filtro.Append(" <= '")
            Filtro.Append(Convert.ToDateTime(DtpPeriodoHasta.Value).ToString("dd/MM/yyyy"))
            Filtro.Append("'")
        End If

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = FiltrarRegistrosRepetidos(Me.FiltrarDT(Dt, Filtro.ToString, Me.PropiedadDescripcion & " ASC"))
    End Sub
#End Region

#Region "Eventos"
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

    Private Sub frmBuscarPorPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtpPeriodoDesde.Value = DBNull.Value
        DtpPeriodoHasta.Value = DBNull.Value
        Me.BuscarPor = BuscarPor.Descripcion
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

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.TextDescripcion.Text = ""
        Me.TextID.Text = ""
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
        Call FiltrarDatos()
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

    Private Sub DtpPeriodoDesde_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpPeriodoDesde.AfterExitEditMode
        If Not DtpPeriodoDesde.Value Is Nothing Then
            If Not DtpPeriodoHasta.Value Is Nothing Then
                If Convert.ToDateTime(DtpPeriodoDesde.Value) > Convert.ToDateTime(DtpPeriodoHasta.Value) Then
                    Mensaje("El período desde debe ser menor o igual al período hasta.")
                    DtpPeriodoDesde.Value = DBNull.Value
                End If
            End If
        End If
        Call FiltrarDatos()
    End Sub

    Private Sub DtpPeriodoHasta_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpPeriodoHasta.AfterExitEditMode
        If Not DtpPeriodoHasta.Value Is Nothing Then
            If Not DtpPeriodoDesde.Value Is Nothing Then
                If Convert.ToDateTime(DtpPeriodoHasta.Value) < Convert.ToDateTime(DtpPeriodoDesde.Value) Then
                    Mensaje("El período hasta debe ser mayor o igual al período desde.")
                    DtpPeriodoHasta.Value = DBNull.Value
                End If
            End If
        End If
        Call FiltrarDatos()
    End Sub
#End Region

End Class

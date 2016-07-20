Imports Framework.Mensajes

Public Class frmBuscarIntercambio
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents btoNuevo As System.Windows.Forms.Button
    Friend WithEvents grdBuscar As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cod_intercambio", 0)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("f_inicio_intercambio", 1)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("f_fin_intercambio", 2)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe", 3)
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btoNuevo = New System.Windows.Forms.Button
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(0, 377)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(755, 3)
        Me.Label18.TabIndex = 91
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(592, 385)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 90
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(511, 385)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 89
        Me.cmdAceptar.Text = "Aceptar"
        '
        'grdBuscar
        '
        Me.grdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn1.CellAppearance = Appearance1
        UltraGridColumn1.Header.Caption = "Código"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 80
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.CellAppearance = Appearance2
        UltraGridColumn2.DataType = GetType(Date)
        UltraGridColumn2.Header.Caption = "Fecha Inicio"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaskInput = "dd/mm/yyyy"
        UltraGridColumn2.Width = 80
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.Caption = "Fecha Fin"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = "dd/mm/yyyy"
        UltraGridColumn3.Width = 80
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaskInput = "-nnn,nnn,nnn.nn"
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.grdBuscar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdBuscar.DisplayLayout.MaxColScrollRegions = 1
        Me.grdBuscar.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdBuscar.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdBuscar.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdBuscar.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdBuscar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdBuscar.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Edit
        Me.grdBuscar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.[Like]
        Me.grdBuscar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdBuscar.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.AppearancesOnly
        Me.grdBuscar.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdBuscar.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Vertical
        Me.grdBuscar.FlatMode = True
        Me.grdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdBuscar.Location = New System.Drawing.Point(5, 3)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(749, 371)
        Me.grdBuscar.TabIndex = 92
        '
        'btoNuevo
        '
        Me.btoNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btoNuevo.Location = New System.Drawing.Point(673, 385)
        Me.btoNuevo.Name = "btoNuevo"
        Me.btoNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btoNuevo.TabIndex = 93
        Me.btoNuevo.Text = "Nuevo"
        '
        'frmBuscarIntercambio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(757, 418)
        Me.Controls.Add(Me.btoNuevo)
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarIntercambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intercambios"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mIntercambios As DataTable
    Private mFechaIntercambio As DateTime
    Private mAceptar As Boolean = False
    Private mCodigoIntercambio As Double
    Shared mInstancia As frmBuscarIntercambio
    Public BuscarNuevo As Boolean = False
    Public IntercambioNuevo As String

#End Region

#Region "Propiedades Publicas"
    Public WriteOnly Property FechaIntercambio() As DateTime
        Set(ByVal Value As DateTime)
            mFechaIntercambio = Value
        End Set
    End Property

    Public ReadOnly Property Aceptar() As Boolean
        Get
            Return mAceptar
        End Get
    End Property

    Public ReadOnly Property CodigoIntercambio() As Double
        Get
            Return mCodigoIntercambio
        End Get
    End Property

    Public Shared Property Instancia() As frmBuscarIntercambio
        Get
            If mInstancia Is Nothing Then
                mInstancia = New frmBuscarIntercambio
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As frmBuscarIntercambio)
            mInstancia = Value
        End Set
    End Property

#End Region

#Region "Eventos"
    Private Sub frmBuscarIntercambio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarIntercambios()

        If Not mIntercambios Is Nothing Then
            Call SetearGrilla()
        End If

    End Sub

    Private Sub grdBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdBuscar.Click
        Call SeleccionarIntercambio()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If mCodigoIntercambio = 0 Then
            Mensaje("Debe seleccionar un Intercambio.")
        Else
            mAceptar = True
            Me.Close()
        End If
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub CargarIntercambios()
        Dim EnvioCompra As New Envio_Compras
        EnvioCompra.Id_Cliente = Activo.IDCliente
        EnvioCompra.Fecha_Desde = mFechaIntercambio

        'AG 18/09/2013 =========================================================
        Dim FInicio As String = "01/01/" + Date.Today.Year.ToString()
        Dim FFin As String = "31/12/" + Date.Today.Year.ToString()
        'Dim FDesde As DateTime = Convert.ToDateTime("01/01/2012").Date()
        'Dim FHasta As DateTime = Convert.ToDateTime("31/12/2012").Date()
        '=======================================================================
        mIntercambios = EnvioCompra.TraerIntercambiosMMS(CInt(Activo.IDCliente), Convert.ToDateTime(FInicio).Date(), Convert.ToDateTime(FFin).Date())

        If mIntercambios Is Nothing Then
            MsgBox("No se encontraron Intercambios cargados para este cliente")
            Exit Sub
        Else
            grdBuscar.DataSource = mIntercambios
        End If

    End Sub

    Private Sub SetearGrilla()
        With grdBuscar.DisplayLayout.Bands(0)

            'AG 18/09/2013 ==================================================================================
            'Nombre Campos Grilla ===============
            .Columns("cod_intercambio").Header.Caption = "Código"
            .Columns("des_intercambio").Header.Caption = "Descripcion"
            .Columns("f_inicio_intercambio").Header.Caption = "Fecha Inicio"
            .Columns("f_fin_intercambio").Header.Caption = "Fecha Fin"
            .Columns("importe").Header.Caption = "Importe"

            'Tamaño Campos Grilla ===============
            .Columns("cod_intercambio").Width = 80
            .Columns("des_intercambio").Width = 300
            .Columns("f_inicio_intercambio").Width = 100
            .Columns("f_fin_intercambio").Width = 100
            .Columns("importe").Width = 80

            'Formato Campos Grilla ==============
            .Columns("f_inicio_intercambio").MaskInput = "dd/mm/yyyy"
            .Columns("f_fin_intercambio").MaskInput = "dd/mm/yyyy"
            .Columns("importe").MaskInput = "-nnn,nnn,nnn.nn"

            'Alinieacion Campos Grilla ==========
            .Columns("cod_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("des_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("f_inicio_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("f_fin_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("importe").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center

            'AG Codigo Anterior =============================================================================
            '.Columns("cod_intercambio").Header.Caption = "Código"
            '.Columns("cod_proveedor").Header.Caption = "Cod. Prov."
            '.Columns("des_proveedor").Header.Caption = "Proveedor"
            '.Columns("f_inicio_intercambio").Header.Caption = "Fecha Inicio"
            '.Columns("f_fin_intercambio").Header.Caption = "Fecha Fin"
            '.Columns("cod_intercambio").Width = 80
            '.Columns("cod_proveedor").Width = 80
            '.Columns("des_proveedor").Width = 350
            '.Columns("f_inicio_intercambio").Width = 80
            '.Columns("f_fin_intercambio").Width = 80
            '.Columns("f_inicio_intercambio").MaskInput = "dd/mm/yyyy"
            '.Columns("f_fin_intercambio").MaskInput = "dd/mm/yyyy"
            '.Columns("cod_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '.Columns("cod_proveedor").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '.Columns("f_inicio_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            '.Columns("f_fin_intercambio").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            '=================================================================================================

        End With
    End Sub

    Private Sub SeleccionarIntercambio()
        If grdBuscar.Selected.Rows.Count > 0 Then
            mCodigoIntercambio = Convert.ToInt32(grdBuscar.Selected.Rows(0).Cells("cod_intercambio").Value)
        End If
    End Sub

    'AG 19/09/2013 ===========================================================================
    Private Sub btoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btoNuevo.Click

        Dim FrmAltaIntercambio As New ABMIntercambios
        frmBuscarIntercambio.Instancia = Me
        FrmAltaIntercambio.ShowDialog()

        If BuscarNuevo = True Then
            CargarIntercambios()
            SetearGrilla()
            BuscarNuevo = False
        End If


    End Sub

#End Region
End Class

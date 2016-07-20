Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid



Public Class frmTarifasAnteriores
    Inherits System.Windows.Forms.Form
    Private midTarifa As Integer
    Private mIdMedio As Integer
    Private mIdSoporte As Integer
    Private mIdCliente As Integer
    Private mCliente As String
    Private mSoporte As String
    Private mDesTele As String
    Private midTele As Integer
    Public TipoSoporte As TipoAudiencia

    Dim dtTarifa As New DataTable
    Public Property DesTele() As String
        Get
            Return mDesTele
        End Get
        Set(ByVal Value As String)
            mDesTele = Value
        End Set
    End Property
    Public Property idTele() As Integer
        Get
            Return midTele
        End Get
        Set(ByVal Value As Integer)
            midTele = Value
        End Set
    End Property
    Public Property Soporte() As String
        Get
            Return mSoporte
        End Get
        Set(ByVal Value As String)
            mSoporte = Value
        End Set
    End Property
    Public Property Cliente() As String
        Get
            Return mCliente
        End Get
        Set(ByVal Value As String)
            mCliente = Value
        End Set
    End Property
    Public Property idtarifa() As Integer
        Get
            Return midTarifa
        End Get
        Set(ByVal Value As Integer)
            midTarifa = Value
        End Set
    End Property
    Public Property IdMedio() As Integer
        Get
            Return mIdMedio
        End Get
        Set(ByVal Value As Integer)
            mIdMedio = Value
        End Set
    End Property
    Public Property IdCliente() As Integer
        Get
            Return mIdCliente
        End Get
        Set(ByVal Value As Integer)
            mIdCliente = Value
        End Set
    End Property
    Public Property IdSoporte() As Integer
        Get
            Return mIdSoporte
        End Get
        Set(ByVal Value As Integer)
            mIdSoporte = Value
        End Set
    End Property


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
    Friend WithEvents iugTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As QUETOOL.txtTexto
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDesc = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'iugTarifas
        '
        Me.iugTarifas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.iugTarifas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugTarifas.DisplayLayout.Appearance = Appearance1
        Me.iugTarifas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugTarifas.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugTarifas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugTarifas.DisplayLayout.GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna."
        Me.iugTarifas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        Me.iugTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.iugTarifas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugTarifas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugTarifas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugTarifas.FlatMode = True
        Me.iugTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugTarifas.Location = New System.Drawing.Point(8, 72)
        Me.iugTarifas.Name = "iugTarifas"
        Me.iugTarifas.Size = New System.Drawing.Size(920, 328)
        Me.iugTarifas.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 56)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.ConDecimal = False
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(64, 24)
        Me.txtDesc.Maximo = 0
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(848, 21)
        Me.txtDesc.SoloLetra = False
        Me.txtDesc.SoloNumero = False
        Me.txtDesc.TabIndex = 10
        Me.txtDesc.TabStop = False
        Me.txtDesc.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Programa"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Location = New System.Drawing.Point(770, 416)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.TabIndex = 26
        Me.cmdAgregar.Text = "Agregar"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Location = New System.Drawing.Point(850, 416)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.TabIndex = 27
        Me.cmdCerrar.Text = "Cerrar"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(37, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(891, 2)
        Me.Label1.TabIndex = 25
        '
        'frmTarifasAnteriores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iugTarifas)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTarifasAnteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifas Anteriores"
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub CargarTarifas()
        Dim tarifas As New Tarifas_tv
        Try
            tarifas.Id_soporte = mIdSoporte
            tarifas.Id_cliente = mIdCliente
            tarifas.Id_medio = IdMedio
            dtTarifa = tarifas.TraerTodosDelAño
            iugTarifas.DataSource = dtTarifa


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub iugTarifas_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugTarifas.InitializeLayout
        Dim i As Integer

        iugTarifas.DisplayLayout.MaxRowScrollRegions = 1

        With iugTarifas.DisplayLayout.Bands(0)

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
            .Columns(10).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(11).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(12).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(13).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(14).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(15).CellAppearance.BackColor = System.Drawing.Color.WhiteSmoke

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
            .Columns(2).Header.VisiblePosition = 15

            .Override.CellClickAction = CellClickAction.RowSelect

        End With
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        midTarifa = -1
        Me.Close()

    End Sub
    Private Sub TraerTarifas(Optional ByVal Prog As String = "")

        Try

            If Prog = "" Or Prog.IndexOf("'") > -1 Or Prog.IndexOf(Chr(34)) > -1 Then
                iugTarifas.DataSource = dtTarifa
            Else
                iugTarifas.DataSource = Listas.FiltrarDT(dtTarifa, "programa like '%" & Prog & "%'", "programa asc")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Agregar()
    End Sub
    Private Sub txtDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged
        TraerTarifas(Me.txtDesc.Text)
    End Sub
    Private Sub Agregar()
        If iugTarifas.ActiveRow Is Nothing Then
            Exit Sub
        End If
        midTarifa = iugTarifas.ActiveRow.Cells(0).Value
        mDesTele = IIf(iugTarifas.ActiveRow.Cells(2).Value Is DBNull.Value, "", iugTarifas.ActiveRow.Cells(2).Value)
        Me.TipoSoporte = TipoAudiencia.Abierta
        Me.Close()
    End Sub

    Private Sub iugTarifas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles iugTarifas.DoubleClick
        Agregar()
    End Sub

    Private Sub frmTarifasAnteriores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

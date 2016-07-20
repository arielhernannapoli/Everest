Public Class frmActualizarTarifasCongeladas
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal dtSoporte As DataTable, ByVal Programas As DataTable, ByVal F_Vigor As Date)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mDtProgramas = Programas.Copy
        Cargar(dtSoporte, F_Vigor)
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
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdAplicar As System.Windows.Forms.Button
    Friend WithEvents iugProgramas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSoporte As QUETOOL.cboCombo
    Friend WithEvents dtpFechaVig As QUETOOL.dtpFecha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugProgramas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdAplicar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFechaVig = New QUETOOL.dtpFecha
        Me.cboSoporte = New QUETOOL.cboCombo
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.iugProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtpFechaVig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugProgramas
        '
        Me.iugProgramas.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.iugProgramas.DisplayLayout.Appearance = Appearance1
        Me.iugProgramas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.iugProgramas.DisplayLayout.GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna"
        Me.iugProgramas.DisplayLayout.InterBandSpacing = 10
        Me.iugProgramas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugProgramas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.iugProgramas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugProgramas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugProgramas.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugProgramas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.iugProgramas.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.iugProgramas.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.iugProgramas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugProgramas.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.iugProgramas.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.iugProgramas.DisplayLayout.Override.RowSelectorWidth = 12
        Me.iugProgramas.DisplayLayout.Override.RowSpacingBefore = 2
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(247, Byte), CType(247, Byte), CType(249, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.iugProgramas.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.iugProgramas.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugProgramas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugProgramas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugProgramas.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(168, Byte), CType(167, Byte), CType(191, Byte))
        Me.iugProgramas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.iugProgramas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugProgramas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugProgramas.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.iugProgramas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.iugProgramas.Location = New System.Drawing.Point(12, 60)
        Me.iugProgramas.Name = "iugProgramas"
        Me.iugProgramas.Size = New System.Drawing.Size(476, 428)
        Me.iugProgramas.TabIndex = 17
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(400, 503)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(88, 24)
        Me.cmdSalir.TabIndex = 58
        Me.cmdSalir.Text = "Salir"
        '
        'cmdAplicar
        '
        Me.cmdAplicar.Location = New System.Drawing.Point(308, 503)
        Me.cmdAplicar.Name = "cmdAplicar"
        Me.cmdAplicar.Size = New System.Drawing.Size(88, 24)
        Me.cmdAplicar.TabIndex = 57
        Me.cmdAplicar.Text = "Aplicar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVig)
        Me.GroupBox1.Controls.Add(Me.cboSoporte)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 48)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Soporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha de Vigor"
        '
        'dtpFechaVig
        '
        Appearance7.FontData.SizeInPoints = 9.0!
        Me.dtpFechaVig.Appearance = Appearance7
        Me.dtpFechaVig.FlatMode = True
        Me.dtpFechaVig.Location = New System.Drawing.Point(336, 16)
        Me.dtpFechaVig.Name = "dtpFechaVig"
        Me.dtpFechaVig.Size = New System.Drawing.Size(124, 21)
        Me.dtpFechaVig.TabIndex = 5
        '
        'cboSoporte
        '
        Me.cboSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSoporte.DisplayMember = ""
        Me.cboSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboSoporte.FlatMode = True
        Me.cboSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSoporte.Location = New System.Drawing.Point(61, 16)
        Me.cboSoporte.Name = "cboSoporte"
        Me.cboSoporte.Size = New System.Drawing.Size(155, 21)
        Me.cboSoporte.TabIndex = 1
        Me.cboSoporte.Tag = "Tipo de Soporte del Sistema"
        Me.cboSoporte.ValueMember = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(0, 492)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 2)
        Me.Label3.TabIndex = 60
        '
        'frmActualizarTarifasCongeladas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(498, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAplicar)
        Me.Controls.Add(Me.iugProgramas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmActualizarTarifasCongeladas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Tarifas Congeladas"
        CType(Me.iugProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtpFechaVig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Dim mSalir As Boolean
    Dim mDtProgramas As DataTable
    Dim DtProgTT As DataTable
    Dim dtS As DataTable
    Dim mDt As New DataTable

    Public Property Dt()
        Get
            Return mDt
        End Get
        Set(ByVal Value)
            mDt = Value
        End Set
    End Property

    Public Property Salir() As Boolean
        Get
            Return mSalir
        End Get
        Set(ByVal Value As Boolean)
            mSalir = Value
        End Set
    End Property

#End Region

    Private Sub Cargar(ByVal dtSoporte As DataTable, ByVal f_vigor As Date)
        Dim s As New Soportes
        Dim Relacion As DataRelation
        Dim ds As New DataSet
        Dim strFiltro As String

        dtS = dtSoporte.Copy
        For Each row As DataRow In dtS.Rows
            s.Id_soporte = row("Id_soporte")
            s.Id_medio = Activo.IDMedio
            s.BuscarPorID_Soporte()
            row("Descripcion") = s.Descripcion
        Next

        Listas.CargarCombo(cboSoporte, dtS, "Id_Soporte", "Descripcion")
        Listas.OcultarColumnas(cboSoporte, "id_soporte")
        dtpFechaVig.Value = f_vigor

        With mDt
            .Columns.Add("Ok", GetType(Boolean))
            .Columns.Add("Id_Programa", GetType(Int64))
            .Columns.Add("Programa", GetType(String))
            .Columns.Add("Precio", GetType(Double))
        End With

        'cboSoporte.Rows(0).Activated = True
        'cboSoporte.Rows(0).Selected = True
        'iugProgramas.DataSource = TraerProgramas(1, cboSoporte.ActiveRow.Cells("Id_Soporte").Value, f_vigor)
    End Sub

    Private Function TraerProgramas(ByVal id_medio As Int16, ByVal id_soporte As Int32, ByVal F_Vigor As Date) As DataTable
        Dim t As New Tarifas_tv
        Dim strFiltro As String
        Dim rows() As DataRow
        Dim i As Integer

        t.Id_medio = 1
        t.Id_soporte = id_soporte
        t.F_inicio_vig = F_Vigor
        t.Id_cliente = 0 ' siempre ponemos cliente 0 porque no esta tomando la tarifa del cliente propio, sino una que no cargo, una generica
        DtProgTT = t.TraerTarifasCongeladas()

        ' genero el filtro para tener solo los programas que estan en la grilla.
        strFiltro = ""
        For Each row As DataRow In mDtProgramas.Rows
            If (Not IsDBNull(row("Id_Programa"))) Then
                strFiltro = strFiltro & row("Id_Programa") & ","
            End If
        Next

        If strFiltro <> "" Then
            rows = DtProgTT.Select("id_programa in (" & strFiltro.Substring(0, strFiltro.Length - 1) & ")")
        Else
            rows = DtProgTT.Select
        End If

        mDt.Rows.Clear()
        i = 0
        For Each row As DataRow In rows
            mDt.ImportRow(row)
            mDt.Rows(i).Item("Ok") = True
            i = i + 1
        Next
        TraerProgramas = mDt
    End Function

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Salir = True
        Me.Close()
    End Sub

    Private Sub cmdAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAplicar.Click
        Me.Salir = False
        Me.Close()
    End Sub

    Private Sub cboSoporte_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoporte.TextChanged
        If IsDate(dtpFechaVig.Value) Then
            Cursor.Current = Cursors.WaitCursor
            mDt = TraerProgramas(1, cboSoporte.ActiveRow.Cells("Id_Soporte").Value, dtpFechaVig.Value)
            iugProgramas.DataSource = mDt
            Listas.OcultarColumnas(iugProgramas, "id_programa")
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub dtpFechaVig_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaVig.TextChanged
        Try
            If Not IsDate(dtpFechaVig.Text) Then
                Exit Sub
            End If

            If Year(dtpFechaVig.Text) < 1980 Then
                Exit Sub
            End If

            If cboSoporte.Text <> "" Then
                Cursor.Current = Cursors.WaitCursor
                mDt = TraerProgramas(1, cboSoporte.ActiveRow.Cells("Id_Soporte").Value, dtpFechaVig.Text)
                iugProgramas.DataSource = mDt
                Listas.OcultarColumnas(iugProgramas, "id_programa")
                Cursor.Current = Cursors.Default
            End If
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub iugProgramas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugProgramas.MouseUp
        Try
            Dim aUIElement As Infragistics.Win.UIElement
            aUIElement = iugProgramas.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
            ' declare and retrieve a reference to the Cell
            Dim aRow As Infragistics.Win.UltraWinGrid.UltraGridRow
            aRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            ' if a cell was found display the band and column key
            If Not aRow Is Nothing Then
                If iugProgramas.ActiveRow.Cells("Ok").Value Then
                    iugProgramas.ActiveRow.Cells("Ok").Value = False
                Else
                    iugProgramas.ActiveRow.Cells("Ok").Value = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

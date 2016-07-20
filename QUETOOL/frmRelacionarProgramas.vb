Public Class frmRelacionarProgramas

    Inherits System.Windows.Forms.Form
    Dim GrillaFormato As New GrillaFormato
    Dim dtRelacionados As New DataTable
    Dim dtTarifas As DataTable
    Private searchHelper As WinGridKeyboardSearchHelper

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
    Friend WithEvents iugProgramasSugeridos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdDesmarcarProgramas As System.Windows.Forms.Button
    Friend WithEvents iugTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtIDSoporte As QUETOOL.txtTexto
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Label
    Friend WithEvents chkVigentes As QUETOOL.chkCheck
    Friend WithEvents cmdBuscarProgramas As System.Windows.Forms.Label
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ChkTodos As QUETOOL.chkCheck
    Friend WithEvents txtBuscar As QUETOOL.txtTexto
    Friend WithEvents CboMedio As QUETOOL.cboCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRelacionarProgramas))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.iugTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.iugProgramasSugeridos = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdDesmarcarProgramas = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdBuscarProgramas = New System.Windows.Forms.Label
        Me.chkVigentes = New QUETOOL.chkCheck
        Me.btnBuscar = New System.Windows.Forms.Label
        Me.TxtDescSoporte = New QUETOOL.txtTexto
        Me.TxtIDSoporte = New QUETOOL.txtTexto
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ChkTodos = New QUETOOL.chkCheck
        Me.txtBuscar = New QUETOOL.txtTexto
        Me.CboMedio = New QUETOOL.cboCombo
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugProgramasSugeridos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(0, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1008, 2)
        Me.Label1.TabIndex = 4
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Location = New System.Drawing.Point(900, 460)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.TabIndex = 7
        Me.cmdCerrar.Text = "Cerrar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Location = New System.Drawing.Point(820, 460)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        '
        'iugTarifas
        '
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
        Me.iugTarifas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.iugTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.iugTarifas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugTarifas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugTarifas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugTarifas.Dock = System.Windows.Forms.DockStyle.Left
        Me.iugTarifas.FlatMode = True
        Me.iugTarifas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugTarifas.Location = New System.Drawing.Point(0, 0)
        Me.iugTarifas.Name = "iugTarifas"
        Me.iugTarifas.Size = New System.Drawing.Size(650, 376)
        Me.iugTarifas.TabIndex = 15
        '
        'iugProgramasSugeridos
        '
        Me.iugProgramasSugeridos.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance3.BorderColor = System.Drawing.Color.DimGray
        Me.iugProgramasSugeridos.DisplayLayout.Appearance = Appearance3
        Me.iugProgramasSugeridos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Appearance4.BackColor = System.Drawing.Color.White
        Me.iugProgramasSugeridos.DisplayLayout.CaptionAppearance = Appearance4
        Me.iugProgramasSugeridos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugProgramasSugeridos.DisplayLayout.GroupByBox.Prompt = "Arrastre el encabezado de la columna aquí para agrupar por esa columna."
        Me.iugProgramasSugeridos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.iugProgramasSugeridos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.iugProgramasSugeridos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugProgramasSugeridos.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugProgramasSugeridos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.iugProgramasSugeridos.FlatMode = True
        Me.iugProgramasSugeridos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugProgramasSugeridos.Location = New System.Drawing.Point(654, 0)
        Me.iugProgramasSugeridos.Name = "iugProgramasSugeridos"
        Me.iugProgramasSugeridos.Size = New System.Drawing.Size(310, 376)
        Me.iugProgramasSugeridos.TabIndex = 16
        '
        'cmdDesmarcarProgramas
        '
        Me.cmdDesmarcarProgramas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDesmarcarProgramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDesmarcarProgramas.Location = New System.Drawing.Point(12, 460)
        Me.cmdDesmarcarProgramas.Name = "cmdDesmarcarProgramas"
        Me.cmdDesmarcarProgramas.Size = New System.Drawing.Size(142, 23)
        Me.cmdDesmarcarProgramas.TabIndex = 21
        Me.cmdDesmarcarProgramas.Text = "Desmarcar programas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboMedio)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmdBuscarProgramas)
        Me.GroupBox2.Controls.Add(Me.chkVigentes)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.TxtDescSoporte)
        Me.GroupBox2.Controls.Add(Me.TxtIDSoporte)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 69)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'cmdBuscarProgramas
        '
        Me.cmdBuscarProgramas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdBuscarProgramas.Image = CType(resources.GetObject("cmdBuscarProgramas.Image"), System.Drawing.Image)
        Me.cmdBuscarProgramas.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdBuscarProgramas.Location = New System.Drawing.Point(616, 44)
        Me.cmdBuscarProgramas.Name = "cmdBuscarProgramas"
        Me.cmdBuscarProgramas.Size = New System.Drawing.Size(21, 21)
        Me.cmdBuscarProgramas.TabIndex = 3
        Me.cmdBuscarProgramas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkVigentes
        '
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVigentes.Location = New System.Drawing.Point(524, 44)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(88, 24)
        Me.chkVigentes.TabIndex = 2
        Me.chkVigentes.Text = "Solo vigentes"
        '
        'btnBuscar
        '
        Me.btnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscar.Location = New System.Drawing.Point(116, 44)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(21, 21)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescSoporte
        '
        Me.TxtDescSoporte.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescSoporte.ConDecimal = False
        Me.TxtDescSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescSoporte.Location = New System.Drawing.Point(144, 44)
        Me.TxtDescSoporte.Maximo = 0
        Me.TxtDescSoporte.Name = "TxtDescSoporte"
        Me.TxtDescSoporte.ReadOnly = True
        Me.TxtDescSoporte.Size = New System.Drawing.Size(376, 21)
        Me.TxtDescSoporte.SoloLetra = False
        Me.TxtDescSoporte.SoloNumero = False
        Me.TxtDescSoporte.TabIndex = 10
        Me.TxtDescSoporte.TabStop = False
        Me.TxtDescSoporte.Text = ""
        '
        'TxtIDSoporte
        '
        Me.TxtIDSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDSoporte.ConDecimal = False
        Me.TxtIDSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDSoporte.Location = New System.Drawing.Point(56, 44)
        Me.TxtIDSoporte.Maximo = 0
        Me.TxtIDSoporte.MaxLength = 4
        Me.TxtIDSoporte.Name = "TxtIDSoporte"
        Me.TxtIDSoporte.Size = New System.Drawing.Size(56, 21)
        Me.TxtIDSoporte.SoloLetra = False
        Me.TxtIDSoporte.SoloNumero = True
        Me.TxtIDSoporte.TabIndex = 0
        Me.TxtIDSoporte.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.iugProgramasSugeridos)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.iugTarifas)
        Me.Panel1.Location = New System.Drawing.Point(12, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 376)
        Me.Panel1.TabIndex = 24
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(650, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 376)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'ChkTodos
        '
        Me.ChkTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkTodos.Location = New System.Drawing.Point(672, 12)
        Me.ChkTodos.Name = "ChkTodos"
        Me.ChkTodos.Size = New System.Drawing.Size(144, 20)
        Me.ChkTodos.TabIndex = 28
        Me.ChkTodos.Text = "Todos los programas"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.ConDecimal = False
        Me.txtBuscar.Enabled = False
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(668, 40)
        Me.txtBuscar.Maximo = 0
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(296, 21)
        Me.txtBuscar.SoloLetra = False
        Me.txtBuscar.SoloNumero = False
        Me.txtBuscar.TabIndex = 29
        Me.txtBuscar.TabStop = False
        Me.txtBuscar.Text = ""
        '
        'CboMedio
        '
        Me.CboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CboMedio.DisplayMember = ""
        Me.CboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.CboMedio.FlatMode = True
        Me.CboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMedio.Location = New System.Drawing.Point(56, 16)
        Me.CboMedio.Name = "CboMedio"
        Me.CboMedio.Size = New System.Drawing.Size(245, 21)
        Me.CboMedio.TabIndex = 81
        Me.CboMedio.Tag = ""
        Me.CboMedio.ValueMember = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Medio"
        '
        'frmRelacionarProgramas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(986, 491)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.ChkTodos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdDesmarcarProgramas)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRelacionarProgramas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar relación"
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugProgramasSugeridos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesmarcarProgramas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesmarcarProgramas.Click
        Dim oDP As New frmDesmarcarProgramas

        oDP.ShowDialog()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim p As New Programas
        Dim t As New Tarifas_tv


        If Not iugProgramasSugeridos.ActiveCell Is Nothing Then ' si tengo la celda activa, activo la fila
            iugProgramasSugeridos.Rows(iugProgramasSugeridos.ActiveCell.Row.Index).Activated = True
        Else
            If iugProgramasSugeridos.ActiveRow Is Nothing Then
                Mensajes.Mensaje("Debe seleccionar un programa sugerido", TipoMensaje.Informacion)
                Exit Sub
            End If
        End If

        If Not iugTarifas.ActiveCell Is Nothing Then ' si tengo la celda activa, activo la fila
            iugTarifas.Rows(iugTarifas.ActiveCell.Row.Index).Activated = True
        Else
            If iugTarifas.ActiveRow Is Nothing Then
                Mensajes.Mensaje("Debe seleccionar un programa", TipoMensaje.Informacion)
                Exit Sub
            End If
        End If

        Try
            If Mensajes.Mensaje("Desea relacionar " & iugProgramasSugeridos.ActiveRow.Cells("Descripcion").Value & " con " & iugTarifas.ActiveRow.Cells("Programa").Value, TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                t.Id_tarifa_tv = iugTarifas.ActiveRow.Cells("Id_Tarifa_Tv").Value
                t.BuscarPorID()
                t.Id_programa = iugProgramasSugeridos.ActiveRow.Cells("Id_Programa").Value
                t.Modificar()

                p.Id_programa = iugProgramasSugeridos.ActiveRow.Cells("Id_Programa").Value
                p.BuscarPorID()
                p.Marca = "X"
                p.Modificar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TraerProgramas(Optional ByVal Prog As String = "")
        Dim p As New Programas


        If iugTarifas.ActiveRow Is Nothing Then
            Exit Sub
        End If

        Try
            If Not ChkTodos.Checked Then
                p.Id_medio = Activo.IDMedio
                p.Id_soporte = TxtIDSoporte.Text
                p.Descripcion = iugTarifas.ActiveRow.Cells("Programa").Value
                iugProgramasSugeridos.DataSource = p.TraerPrgSugeridosPorSop
            Else
                p.Id_medio = Activo.IDMedio
                p.Id_soporte = TxtIDSoporte.Text

                'Agregado Cristian: Filtro incremental para buscar soportes
                If Prog = "" Or Prog.IndexOf("'") > -1 Or Prog.IndexOf(Chr(34)) > -1 Then
                    iugProgramasSugeridos.DataSource = p.TraerPrgPorSop
                Else
                    iugProgramasSugeridos.DataSource = Listas.FiltrarDT(p.TraerPrgPorSop, "descripcion like '%" & Prog & "%'", "descripcion asc")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub iugTarifas_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles iugTarifas.AfterSelectChange
        Dim p As New Programas

        If Me.iugTarifas.ActiveRow Is Nothing Then 'OrElse Me.iugTarifas.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        If Not TypeOf (iugTarifas.ActiveRow) Is Infragistics.Win.UltraWinGrid.UltraGridGroupByRow Then
            p.Id_medio = Activo.IDMedio
            p.Id_soporte = TxtIDSoporte.Text
            p.Descripcion = iugTarifas.ActiveRow.Cells("Programa").Value
            TraerProgramas()
        End If
    End Sub

    Private Sub iugTarifas_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugTarifas.InitializeLayout
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
        End With
    End Sub

    Private Sub TxtIDSoporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.Validated
        If TxtIDSoporte.Text <> "" Then

            Dim s As New Soportes

            Try
                s.Id_medio = Activo.IDMedio
                TxtDescSoporte.Text = s.ObtenerDescripcion(TxtIDSoporte.Text)

                If TxtDescSoporte.Text = "" Then
                    Mensajes.Mensaje("El soporte No Existe ")
                    TxtIDSoporte.Text = ""
                    TxtIDSoporte.Select()
                    Exit Sub
                End If

            Catch ex As Exception
                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Soporte, TxtDescSoporte, TxtIDSoporte, "id_soporte", "descripcion", "Código", "Soporte", Activo.IDMedio)

        F.ShowDialog()
    End Sub

    Private Sub cmdBuscarProgramas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarProgramas.Click
        Dim tarifas As New Tarifas_tv
        Dim ei As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs

        If TxtIDSoporte.Text <> "" Then
            Cursor.Current = Cursors.WaitCursor
            Try
                tarifas.Id_soporte = TxtIDSoporte.Text
                tarifas.Id_cliente = 0
                tarifas.Id_medio = Activo.IDMedio
                tarifas.F_inicio_vig = Now
                If chkVigentes.Checked Then
                    dtTarifas = tarifas.TraerTodosConVigencia
                Else
                    dtTarifas = tarifas.TraerTodosSinVigencia
                End If
                iugTarifas.DataSource = dtTarifas

            Catch ex As Exception
                Throw ex
            End Try
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub frmRelacionarProgramas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Activo.IDMedio = 1
        Call CargarMedios()
        FormatearGrillaSug()
        Me.searchHelper = New WinGridKeyboardSearchHelper(Me.iugProgramasSugeridos)
    End Sub

    Private Sub CargarMedios()
        Dim Medio As New Soportes
        Listas.CargarCombo(Me.CboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(CboMedio, "Id_Medio")
        Listas.OcultarHeader(CboMedio)
        CboMedio.SelectedRow = CboMedio.Rows(0)
    End Sub

    Private Sub TxtIDSoporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIDSoporte.TextChanged
        iugTarifas.DataSource = Nothing
    End Sub



    Private Sub FormatearGrillaSug()
        Dim i As Integer

        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns.Add("ID_PROGRAMA")
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns.Add("DESCRIPCION")
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns.Add("MARCA")
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns.Add("AUD").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button

        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(0).Width = 160
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(1).Width = 160
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(2).Width = 30
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(3).Width = 30

        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(0).Hidden = True
        iugProgramasSugeridos.DisplayLayout.Bands(0).Columns(3).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button

        iugTarifas.DisplayLayout.MaxRowScrollRegions = 1

        With iugProgramasSugeridos.DisplayLayout.Bands(0)

            For i = 0 To .Columns.Count - 1
                .Columns(i).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
        End With
    End Sub


    Private Sub iugProgramasSugeridos_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugProgramasSugeridos.ClickCellButton
        Dim f As New frmMostrarEmisiones


        f.Id_programa = iugProgramasSugeridos.ActiveRow.Cells("Id_Programa").Value
        f.Descripcion = iugProgramasSugeridos.ActiveRow.Cells("Descripcion").Value
        f.Id_Soporte = TxtIDSoporte.Text
        f.Id_Medio = CboMedio.Value
        f.ShowDialog()

    End Sub

    Private Sub frmRelacionarProgramas_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If (Not Me.searchHelper Is Nothing) Then
            Me.searchHelper.Dispose()
        End If
    End Sub




    Private Sub ChkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTodos.CheckedChanged
        txtBuscar.Enabled = ChkTodos.Checked
        txtBuscar.Text = ""

        TraerProgramas()
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        TraerProgramas(txtBuscar.Text.Trim)
    End Sub

    Private Sub CboMedio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboMedio.ValueChanged
        Activo.IDMedio = CboMedio.Value
        TxtIDSoporte.Text = String.Empty
        TxtDescSoporte.Text = String.Empty
    End Sub
End Class

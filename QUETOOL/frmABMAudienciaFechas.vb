Public Class frmABMAudienciaFechas
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipoSoporte As QUETOOL.cboCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboPlaza As QUETOOL.cboCombo
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAlta As System.Windows.Forms.Button
    Friend WithEvents cmdBaja As System.Windows.Forms.Button
    Friend WithEvents dtpFFin As QUETOOL.dtpFecha
    Friend WithEvents dtpFInicio As QUETOOL.dtpFecha
    Friend WithEvents txtSemana As QUETOOL.txtTexto
    Friend WithEvents txtAnio As QUETOOL.txtTexto
    Friend WithEvents iugFechas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSemana = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAnio = New QUETOOL.txtTexto
        Me.cboPlaza = New QUETOOL.cboCombo
        Me.Label25 = New System.Windows.Forms.Label
        Me.dtpFFin = New QUETOOL.dtpFecha
        Me.dtpFInicio = New QUETOOL.dtpFecha
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboTipoSoporte = New QUETOOL.cboCombo
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmdAlta = New System.Windows.Forms.Button
        Me.cmdBaja = New System.Windows.Forms.Button
        Me.cmdLimpiar = New System.Windows.Forms.Button
        Me.iugFechas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboPlaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSemana)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.cboPlaza)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.dtpFFin)
        Me.GroupBox1.Controls.Add(Me.dtpFInicio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboTipoSoporte)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtSemana
        '
        Me.txtSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemana.ConDecimal = False
        Me.txtSemana.Enabled = False
        Me.txtSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemana.Location = New System.Drawing.Point(314, 70)
        Me.txtSemana.Maximo = 0
        Me.txtSemana.MaxLength = 80
        Me.txtSemana.Name = "txtSemana"
        Me.txtSemana.Size = New System.Drawing.Size(168, 21)
        Me.txtSemana.SoloLetra = False
        Me.txtSemana.SoloNumero = False
        Me.txtSemana.TabIndex = 80
        Me.txtSemana.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(264, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Semana"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Año"
        '
        'txtAnio
        '
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.ConDecimal = False
        Me.txtAnio.Enabled = False
        Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(88, 70)
        Me.txtAnio.Maximo = 0
        Me.txtAnio.MaxLength = 80
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(168, 21)
        Me.txtAnio.SoloLetra = False
        Me.txtAnio.SoloNumero = False
        Me.txtAnio.TabIndex = 78
        Me.txtAnio.Text = ""
        '
        'cboPlaza
        '
        Me.cboPlaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboPlaza.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPlaza.DisplayMember = ""
        Me.cboPlaza.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboPlaza.FlatMode = True
        Me.cboPlaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlaza.Location = New System.Drawing.Point(314, 17)
        Me.cboPlaza.Name = "cboPlaza"
        Me.cboPlaza.Size = New System.Drawing.Size(168, 21)
        Me.cboPlaza.TabIndex = 76
        Me.cboPlaza.ValueMember = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(264, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 16)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "Plaza"
        '
        'dtpFFin
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFFin.Appearance = Appearance1
        Me.dtpFFin.Enabled = False
        Me.dtpFFin.FlatMode = True
        Me.dtpFFin.Location = New System.Drawing.Point(314, 43)
        Me.dtpFFin.Name = "dtpFFin"
        Me.dtpFFin.Size = New System.Drawing.Size(168, 21)
        Me.dtpFFin.TabIndex = 41
        '
        'dtpFInicio
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFInicio.Appearance = Appearance2
        Me.dtpFInicio.FlatMode = True
        Me.dtpFInicio.Location = New System.Drawing.Point(88, 43)
        Me.dtpFInicio.Name = "dtpFInicio"
        Me.dtpFInicio.Size = New System.Drawing.Size(168, 21)
        Me.dtpFInicio.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Fin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Fecha Inicio"
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoSoporte.DisplayMember = ""
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoSoporte.Location = New System.Drawing.Point(88, 17)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(168, 21)
        Me.cboTipoSoporte.TabIndex = 37
        Me.cboTipoSoporte.Tag = "Tipo de Soporte del Sistema"
        Me.cboTipoSoporte.ValueMember = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 16)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Tipo Soporte"
        '
        'cmdAlta
        '
        Me.cmdAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAlta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAlta.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdAlta.Location = New System.Drawing.Point(512, 8)
        Me.cmdAlta.Name = "cmdAlta"
        Me.cmdAlta.Size = New System.Drawing.Size(96, 21)
        Me.cmdAlta.TabIndex = 22
        Me.cmdAlta.Text = "Alta"
        '
        'cmdBaja
        '
        Me.cmdBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBaja.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdBaja.Location = New System.Drawing.Point(512, 40)
        Me.cmdBaja.Name = "cmdBaja"
        Me.cmdBaja.Size = New System.Drawing.Size(96, 21)
        Me.cmdBaja.TabIndex = 23
        Me.cmdBaja.Text = "Baja"
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLimpiar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.cmdLimpiar.Location = New System.Drawing.Point(512, 72)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(96, 21)
        Me.cmdLimpiar.TabIndex = 24
        Me.cmdLimpiar.Text = "Limpiar"
        '
        'iugFechas
        '
        Me.iugFechas.Cursor = System.Windows.Forms.Cursors.Default
        Appearance3.BackColor = System.Drawing.Color.White
        Me.iugFechas.DisplayLayout.Appearance = Appearance3
        Me.iugFechas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugFechas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.iugFechas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugFechas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Me.iugFechas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.iugFechas.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.iugFechas.DisplayLayout.Override.CellPadding = 3
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugFechas.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.iugFechas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance6.BorderColor = System.Drawing.Color.LightGray
        Appearance6.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugFechas.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.PowderBlue
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.iugFechas.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.iugFechas.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugFechas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugFechas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugFechas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugFechas.FlatMode = True
        Me.iugFechas.Location = New System.Drawing.Point(8, 112)
        Me.iugFechas.Name = "iugFechas"
        Me.iugFechas.Size = New System.Drawing.Size(600, 224)
        Me.iugFechas.TabIndex = 25
        '
        'frmABMAudienciaFechas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 341)
        Me.Controls.Add(Me.iugFechas)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdBaja)
        Me.Controls.Add(Me.cmdAlta)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMAudienciaFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Fecha de Audiencias"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cboPlaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmABMAudienciaFechas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tipo soporte
        Dim TS As New Tipos_soporte
        Dim AF As New Audiencias_fechas

        'el harcode del id_medio esta en el store
        TS.Id_medio = 1
        Listas.CargarCombo(Me.cboTipoSoporte, TS.TraerTipoSoporte, "Id_tipo_soporte", "descripcion")

        Listas.OcultarColumnas(cboTipoSoporte, "Id_Tipo_soporte", "id_medio")
        Listas.OcultarHeader(cboTipoSoporte)

        'carga la plaza
        Dim P As New Plazas

        Listas.CargarCombo(cboPlaza, P.TraerTodos, "id_plaza", "descripcion")

        Listas.OcultarHeader(cboPlaza)
        Listas.OcultarColumnas(cboPlaza, "id_plaza")

        Dim dt As DataTable

        dt = AF.ConsultaGrilla
        iugFechas.DataSource = dt

        AplicarFormato()
        FormatearGrilla()
        dtpFInicio.Value = Now.ToShortDateString
    End Sub
    Private Sub AplicarFormato()
        'Aplica un formato Standard a los ultra grid
        With iugFechas.DisplayLayout.Override
            .AllowDelete = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupBy = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
            .AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
            .AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            .SelectTypeCol = SelectType.None
            '.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
            .AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
            .CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        End With

        iugFechas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
    End Sub
    Private Sub dtpFInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFInicio.ValueChanged
        dtpFFin.Value = DateAdd(DateInterval.Day, 6, dtpFInicio.Value)
        txtSemana.Text = Listas.GetSemana(dtpFInicio.Value)
        If Val(txtSemana.Text) > 50 And Month(dtpFInicio.Value) = 1 Then
            txtAnio.Text = Year(dtpFInicio.Value) - 1
        Else
            txtAnio.Text = Year(dtpFInicio.Value)
        End If
    End Sub

    Private Sub cmdAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAlta.Click
        Dim af As New Audiencias_fechas
        Dim dt As DataTable

        If cboTipoSoporte.Value Is Nothing Then
            cboTipoSoporte.Select()
            Mensajes.Mensaje("Debe seleccionar un tipo de soporte")
            Exit Sub
        End If

        If cboPlaza.Value Is Nothing Then
            cboPlaza.Select()
            Mensajes.Mensaje("Debe seleccionar una plaza")
            Exit Sub
        End If

        af.Id_medio = 1
        af.Id_plaza = cboPlaza.Value
        af.Id_target = 0
        af.Id_tipo_soporte = cboTipoSoporte.Value
        af.Semana = txtSemana.Text
        af.Anio = txtAnio.Text
        af.F_inicio = dtpFInicio.Value
        af.F_fin = dtpFFin.Value

        If af.ConsultarCarga_Datos.Rows.Count = 0 Then
            af.Agregar()

            dt = af.ConsultaGrilla
            iugFechas.DataSource = dt

        Else
            Mensajes.Mensaje("Ya esta cargado")
        End If
        LimpiarPantalla()

    End Sub

    Private Sub FormatearGrilla()
        Listas.OcultarColumnas(Me.iugFechas, "id_tipo_soporte", "id_Plaza")

        'ajusta el ancho de las columnas al de los datos
        With Me.iugFechas
            .DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns

            .DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(2).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(3).PerformAutoResize()
        End With
    End Sub

    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        LimpiarPantalla()
    End Sub
    Private Sub LimpiarPantalla()
        cmdAlta.Enabled = True
        cmdBaja.Enabled = False
        cboTipoSoporte.Value = ""
        cboPlaza.Value = ""
        dtpFInicio.Value = Now.ToShortDateString

        cboTipoSoporte.Enabled = True
        cboPlaza.Enabled = True
        dtpFInicio.Enabled = True
    End Sub

    Private Sub iugFechas_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iugFechas.MouseUp
        Dim aUIElement As Infragistics.Win.UIElement
        Try
            aUIElement = iugFechas.DisplayLayout.UIElement.ElementFromPoint(New Point(e.X, e.Y))
            ' declare and retrieve a reference to the Cell
            Dim aRow As Infragistics.Win.UltraWinGrid.UltraGridRow
            aRow = aUIElement.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridRow))
            ' if a cell was found display the band and column key
            If Not aRow Is Nothing Then
                MostrarFila(iugFechas.ActiveRow)
                cmdAlta.Enabled = False
                cmdBaja.Enabled = True
                cboTipoSoporte.Enabled = False
                cboPlaza.Enabled = False
                dtpFInicio.Enabled = False
            End If
        Catch ex As Exception
            ' no hago nada, lo pongo porque si toca en algun momento los desplazamientos de la grilla, da error y no se modifica nada
        End Try

    End Sub

    Private Sub MostrarFila(ByVal r As Infragistics.Win.UltraWinGrid.UltraGridRow)
        cboTipoSoporte.Value = r.Cells("id_tipo_Soporte").Value
        cboPlaza.Value = r.Cells("id_plaza").Value
        dtpFInicio.Value = r.Cells("Fecha Inicio").Value
    End Sub

    Private Sub cmdBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaja.Click
        Dim af As New Audiencias_fechas
        Dim dt As DataTable

        If Mensajes.Mensaje("Desea eliminar la carga?", TipoMensaje.SiNo, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            af.Id_medio = 1
            af.Id_plaza = cboPlaza.Value
            af.Id_target = 0
            af.Id_tipo_soporte = cboTipoSoporte.Value
            af.Semana = txtSemana.Text
            af.Anio = txtAnio.Text
            af.F_inicio = dtpFInicio.Value
            af.F_fin = dtpFFin.Value

            af.BorrarCarga_Datos()
            dt = af.ConsultaGrilla
            iugFechas.DataSource = dt

        End If

        LimpiarPantalla()
    End Sub
End Class

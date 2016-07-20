Public Class frmDesmarcarProgramas
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
    Friend WithEvents iugProgramas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugProgramas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.iugProgramas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugProgramas
        '
        Me.iugProgramas.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText
        Appearance1.BorderColor = System.Drawing.Color.DimGray
        Me.iugProgramas.DisplayLayout.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.White
        Me.iugProgramas.DisplayLayout.CaptionAppearance = Appearance2
        Me.iugProgramas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False
        Me.iugProgramas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.iugProgramas.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.iugProgramas.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.iugProgramas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
        Me.iugProgramas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
        Me.iugProgramas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
        Me.iugProgramas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.iugProgramas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugProgramas.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ActiveCaption
        Me.iugProgramas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugProgramas.FlatMode = True
        Me.iugProgramas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.iugProgramas.Location = New System.Drawing.Point(8, 8)
        Me.iugProgramas.Name = "iugProgramas"
        Me.iugProgramas.Size = New System.Drawing.Size(456, 304)
        Me.iugProgramas.TabIndex = 16
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(310, 335)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 18
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(390, 335)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 19
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(-12, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 2)
        Me.Label1.TabIndex = 17
        '
        'frmDesmarcarProgramas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iugProgramas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDesmarcarProgramas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Desmarcar Programas"
        CType(Me.iugProgramas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim GrillaFormato As New GrillaFormato
    Dim dtP As DataTable

    Private Sub frmDesmarcarProgramas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim op As New Programas
        Dim c As New DataColumn

        dtP = op.BuscarProgramasMarcados(Activo.IDMedio)
        c.ColumnName = "bMarca"
        c.DataType = GetType(Boolean)
        c.DefaultValue = True
        dtP.Columns.Add(c)
        iugProgramas.DataSource = dtP
        FormatearGrillas()
        Listas.AplicarFormato(iugProgramas)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub FormatearGrillas()
        Dim i As Integer

        Listas.OcultarColumnas(Me.iugProgramas, "id_medio", "id_soporte", "id_programa_monitor", "Marca")
        Listas.CambiarTituloColumna(Me.iugProgramas, "id_programa", "Código")
        Listas.CambiarTituloColumna(Me.iugProgramas, "Descripcion", "Descripción")
        Listas.CambiarTituloColumna(Me.iugProgramas, "bmarca", "Marcado")
        'ajusta el ancho de las columnas al de los datos
        With Me.iugProgramas
            For i = 0 To .DisplayLayout.Bands(0).Columns.Count - 1
                .DisplayLayout.Bands(0).Columns(i).PerformAutoResize()
            Next
            .DisplayLayout.Bands(0).Columns("bMarca").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        End With
        GrillaFormato.CambiarColorColumna(Me.iugProgramas, Color.WhiteSmoke, 0, "id_programa", "bmarca")
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim p As New Programas

        p.ActualizarDataSet(dtP.DataSet, dtP.TableName)
        Me.Close()
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
                If iugProgramas.ActiveRow.Cells("bMarca").Value Then
                    iugProgramas.ActiveRow.Cells("bMarca").Value = False
                    iugProgramas.ActiveRow.Cells("Marca").Value = " "
                Else
                    iugProgramas.ActiveRow.Cells("bMarca").Value = True
                    iugProgramas.ActiveRow.Cells("Marca").Value = "X"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

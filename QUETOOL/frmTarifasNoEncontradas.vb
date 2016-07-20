Public Class frmTarifasNoEncontradas
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
    Friend WithEvents iugTarifas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.iugTarifas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdGuardar = New System.Windows.Forms.Button
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iugTarifas
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.iugTarifas.DisplayLayout.Appearance = Appearance1
        Me.iugTarifas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.iugTarifas.DisplayLayout.MaxColScrollRegions = 1
        Me.iugTarifas.DisplayLayout.MaxRowScrollRegions = 1
        Me.iugTarifas.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.iugTarifas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.iugTarifas.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.iugTarifas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugTarifas.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugTarifas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.iugTarifas.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTarifas.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.iugTarifas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTarifas.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.PowderBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.iugTarifas.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.iugTarifas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugTarifas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTarifas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.iugTarifas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.iugTarifas.FlatMode = True
        Me.iugTarifas.Location = New System.Drawing.Point(0, 0)
        Me.iugTarifas.Name = "iugTarifas"
        Me.iugTarifas.Size = New System.Drawing.Size(536, 304)
        Me.iugTarifas.TabIndex = 0
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(336, 312)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 24)
        Me.cmdAceptar.TabIndex = 7
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Location = New System.Drawing.Point(432, 312)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(104, 24)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Text = "Guardar"
        '
        'frmTarifasNoEncontradas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(538, 338)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.iugTarifas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTarifasNoEncontradas"
        Me.Text = "Programas No Encontrados en La Importacion"
        CType(Me.iugTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mDatos As DataTable
    Public Property Datos() As DataTable
        Get
            Return mDatos
        End Get
        Set(ByVal Value As DataTable)
            mDatos = Value
        End Set
    End Property
  
    Public Sub Cargar()
        iugTarifas.DataSource = Datos
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_Tarifa_Tv").Hidden = True
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_programa").Hidden = True
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_soporte").Hidden = True
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_Campania").Hidden = True
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_sistema").Hidden = True
        iugTarifas.DisplayLayout.Bands(0).Columns("Id_ejercicio").Hidden = True
        For Each c As Infragistics.Win.UltraWinGrid.UltraGridColumn In iugTarifas.DisplayLayout.Bands(0).Columns
            c.PerformAutoResize()
        Next
        'iugTarifas.DisplayLayout.Bands(0).Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.VisibleRows

    End Sub
    Private Sub Guardar()
        Dim Save As New SaveFileDialog
        Try
            Save.Filter = "*.xml |*.xml"
            Save.ShowDialog()
            If Save.FileName = "" Then
                Exit Sub
            End If
            Dim Ds As New DataSet
            Ds.Tables.Add(mDatos)

            Ds.WriteXml(Save.FileName)

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try


    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Guardar()
    End Sub

End Class

Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid

Public Class Form3
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents iugGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Datos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents mnuGrilla As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents iugDetalle As Infragistics.Win.UltraWinGrid.UltraGrid

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.iugGrid = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.mnuGrilla = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Datos = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.iugDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.iugGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'iugGrid
        '
        Me.iugGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iugGrid.ContextMenu = Me.mnuGrilla
        Me.iugGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.iugGrid.DataSource = Me.Datos
        Me.iugGrid.Location = New System.Drawing.Point(8, 8)
        Me.iugGrid.Name = "iugGrid"
        Me.iugGrid.Size = New System.Drawing.Size(916, 124)
        Me.iugGrid.TabIndex = 1
        Me.iugGrid.Text = "UltraGrid1"
        '
        'mnuGrilla
        '
        Me.mnuGrilla.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Duplicar Fila"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Comprar"
        '
        'Datos
        '
        '
        'iugDetalle
        '
        Me.iugDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iugDetalle.ContextMenu = Me.mnuGrilla
        Me.iugDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.iugDetalle.DataSource = Me.Datos
        Me.iugDetalle.Location = New System.Drawing.Point(8, 140)
        Me.iugDetalle.Name = "iugDetalle"
        Me.iugDetalle.Size = New System.Drawing.Size(916, 124)
        Me.iugDetalle.TabIndex = 2
        Me.iugDetalle.Text = "UltraGrid1"
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(932, 453)
        Me.Controls.Add(Me.iugDetalle)
        Me.Controls.Add(Me.iugGrid)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.iugGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Spot As New DataTable
    Dim Detalle As New DataTable
    Dim Ds As New DataSet

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim S As New Spots
        Dim Dr As DataRow
        Dim D As New Spots_detalle

        S.CargarEsquema(Spot)
        D.CargarEsquema(Detalle)

        With Spot
            dr = .NewRow

            Dr("ID_Spot") = 1
            Dr("ID_Campania") = 1
            Dr("ID_Sistema") = 1
            Dr("ID_Ejercicio") = 1
            Dr("ID_Soporte") = 13
            Dr("ID_Tarifa_Tv") = 1
            Dr("ID_Programa") = 257
            Dr("rat_prog_target_1") = 15
            Dr("rat_prog_target_2") = 15
            Dr("rat_tanda_target_1") = 15
            Dr("rat_tanda_target_2") = 15

            .Rows.Add(Dr)

            Me.iugGrid.DataSource = Spot
        End With

        With Detalle
            Dr = Detalle.NewRow

            Dr("id_spot") = 1
            Dr("id_spot_detalle") = 1

            Detalle.Rows.Add(Dr)

            Me.iugDetalle.DataSource = Detalle
        End With

        Ds.Tables.Add(Spot)
        Ds.Tables.Add(Detalle)

        Dim Re As New DataRelation("camsis", Spot.Columns("id_spot"), Detalle.Columns("id_spot"))

        Ds.Relations.Add(Re)

        Me.iugGrid.DataSource = Ds

        S.ActualizarDataSet(Ds, Spot.TableName)

        'D.ActualizarDataSet(Ds, Detalle.TableName)
    End Sub

    Private Sub CargarGrilla()
        iugGrid.DataSource = Datos

        With Datos.Band.Columns
            .Add("IDPrograma", Type.GetType("System.Integer"))
            .Add("Programa", Type.GetType("System.String"))
            .Add("Rating", Type.GetType("System.Single"))
        End With

        With Datos.Band.ChildBands.Add("Banda1").Columns
            .Add("IdPrograma", GetType(Integer))
            .Add("Tema", GetType(String))
        End With

        Dim Row As UltraDataRow

        Row = Me.Datos.Rows.Add
        Row("IDPrograma") = "1"
        Row("Programa") = "1/2 Falta"
        Row("Rating") = "12.2"

        Row = Me.Datos.Rows.Add
        Row("IDPrograma") = "2"
        Row("Programa") = "1/2"
        Row("Rating") = "100"

        Row = Me.Datos.Rows.Add()
        Row("IDPrograma") = "3"
        Row("Programa") = "1/2"
        Row("Rating") = "100"

        Row = Datos.Rows.Insert(0)
        Row("IDPrograma") = "5"
        Row("Programa") = "1/2"
        Row("Rating") = "100"

        Dim childRows As UltraDataRowsCollection = Me.Datos.Rows(2).GetChildRows("Banda1")
        childRows.SetCount(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim Indice As Integer = Me.iugGrid.Selected.Rows(0).Index

        Dim G As New GrillAdmin

        G.AgregarFila(Datos, Me.iugGrid, Indice, Spot, False)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim Indice As Integer = Me.iugGrid.Selected.Rows(0).Index

        Dim Campos As New ArrayList
        Dim T As New CampoTipo

        T.Campo = "idprograma"
        T.Tipo = GetType(Integer)
        Campos.Add(T)

        T = New CampoTipo
        T.Campo = "tema"
        T.Tipo = GetType(String)
        Campos.Add(T)

    End Sub

    Private Sub Datos_CellDataUpdated(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDataSource.CellDataUpdatedEventArgs) Handles Datos.CellDataUpdated

    End Sub
End Class

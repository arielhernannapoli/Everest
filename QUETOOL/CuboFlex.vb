Imports DevExpress.XtraPivotGrid
Imports System.IO
Imports System.Globalization

' NUEVO FORMULARIO DE CUBO DE DATOS (AN 06-10-2015)
Public Class CuboFlex
    Inherits System.Windows.Forms.Form

    Private path As String = String.Concat(IO.Path.GetDirectoryName(Application.ExecutablePath), "\pivot_", Activo.IDUsuario, ".xml")
    Private colapsar As Boolean
    Private totales As Boolean

    Private Sub CuboFlex_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing        
        Me.pivotFlex.SaveLayoutToXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout)
    End Sub

    Private Sub CuboFlex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        path = String.Concat(IO.Path.GetDirectoryName(Application.ExecutablePath), "\pivot_", Activo.IDUsuario, ".xml")
    End Sub

    Private Sub CuboFlex_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.pivotFlex.Width = Me.Width
        Me.pivotFlex.Height = Me.Height-60
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnColapsar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColapsar.Click
        If Not colapsar Then
            Me.pivotFlex.CollapseAll()
        Else
            Me.pivotFlex.ExpandAll()
        End If
        colapsar = Not colapsar
    End Sub

    Private Sub btnOcultarTotales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultarTotales.Click
        If Not totales Then
            Me.pivotFlex.OptionsView.ShowRowTotals = False
            Me.pivotFlex.OptionsView.ShowRowGrandTotals = False
            Me.pivotFlex.OptionsView.ShowColumnTotals = False
            Me.pivotFlex.OptionsView.ShowColumnGrandTotals = False
        Else
            Me.pivotFlex.OptionsView.ShowRowTotals = True
            Me.pivotFlex.OptionsView.ShowRowGrandTotals = True
            Me.pivotFlex.OptionsView.ShowColumnTotals = True
            Me.pivotFlex.OptionsView.ShowColumnGrandTotals = True
        End If
        totales = Not totales
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Dim OpenDLG As New SaveFileDialog
        Dim ArchDestino As String
        OpenDLG.InitialDirectory = "c:\"
        OpenDLG.Filter = "Archivos de Excel (*.xls)|*.xls"
        OpenDLG.FilterIndex = 1
        OpenDLG.RestoreDirectory = True

        If OpenDLG.ShowDialog() = DialogResult.OK Then
            ArchDestino = OpenDLG.FileName
            Me.pivotFlex.OptionsPrint.MergeRowFieldValues = False
            Me.pivotFlex.ExportToXls(ArchDestino)
            MsgBox("La exportación fue exitosa", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub btnExportarHtml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarHtml.Click
        Dim OpenDLG As New SaveFileDialog
        Dim ArchDestino As String
        OpenDLG.InitialDirectory = "c:\"
        OpenDLG.Filter = "Archivos de Html (*.html)|*.htm"
        OpenDLG.FilterIndex = 1
        OpenDLG.RestoreDirectory = True

        If OpenDLG.ShowDialog() = DialogResult.OK Then
            ArchDestino = OpenDLG.FileName
            Me.pivotFlex.OptionsPrint.MergeRowFieldValues = False
            Me.pivotFlex.ExportToHtml(ArchDestino)
            MsgBox("La exportación fue exitosa", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Me.pivotFlex.OptionsPrint.PageSettings.Landscape = True
        Me.pivotFlex.ShowPrintPreview() ' Print()
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()


    End Sub

    Public Sub New(ByVal spots As DataTable, ByVal spotsDetalles As DataTable, ByVal franjas As DataTable)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        franjas.TableName = "FRANJAS"

        ' Datos sin guardar para el cubo
        Dim datos = New DataSet
        datos.Tables.Add(spots)
        datos.Tables.Add(spotsDetalles)
        datos.Tables.Add(franjas)

        Dim relacion As New DataRelation("Relacion", spots.Columns("ID_SPOT"), spotsDetalles.Columns("ID_SPOT"))
        datos.Relations.Add(relacion)

        Dim s As New Sistemas
        s.Id_campania = Activo.IDCampaña
        s.Id_sistema = Activo.IDSistema
        s.BuscarPorID()

        Me.pivotFlex.LoadPivot(datos, s.Tipo_rating, s.F_inicio)
        
    End Sub

    Private Sub pivotFlex_EndRefresh(ByVal sender As Object, ByVal e As System.EventArgs) Handles pivotFlex.EndRefresh

    End Sub
End Class
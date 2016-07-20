Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmAvisosConfirmados
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
    Friend WithEvents ReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.ActiveViewIndex = -1
        Me.ReportViewer.DisplayBackgroundEdge = False
        Me.ReportViewer.DisplayGroupTree = False
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ReportSource = Nothing
        Me.ReportViewer.ShowCloseButton = False
        Me.ReportViewer.ShowGotoPageButton = False
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.ShowRefreshButton = False
        Me.ReportViewer.ShowTextSearchButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(672, 365)
        Me.ReportViewer.TabIndex = 1
        '
        'frmAvisosConfirmados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 365)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmAvisosConfirmados"
        Me.Text = "Avisos Confirmados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mDataSource As DataSet
    Private mNivelEjercicio As Boolean
#End Region

#Region "Propiedades Publicas"
    Public WriteOnly Property DataSource() As DataSet
        Set(ByVal Value As DataSet)
            mDataSource = Value
        End Set
    End Property

    Public WriteOnly Property NivelEjercicio() As Boolean
        Set(ByVal Value As Boolean)
            mNivelEjercicio = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAvisosConfirmados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mDataSource Is Nothing Then Me.Close()
        Dim Reporte As New rptAvisosConfirmados
        Dim Margenes As New CrystalDecisions.[Shared].PageMargins

        Reporte.SetDataSource(mDataSource)
        Reporte.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        Margenes.leftMargin = 0.09
        Margenes.rightMargin = 0.63
        Margenes.topMargin = 0.09
        Margenes.bottomMargin = 0.01

        Reporte.PrintOptions.ApplyPageMargins(Margenes)
        Reporte.SetParameterValue("@FiltroEjercicio", mNivelEjercicio)

         Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects
        Dim crReportObject As ReportObject
        Dim crSubreportObject As SubreportObject
        Dim subRepDoc As New ReportDocument

        crSections = Reporte.ReportDefinition.Sections
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
            For Each crReportObject In crReportObjects
                If crReportObject.Kind = ReportObjectKind.SubreportObject Then

                    'If you find a subreport, typecast the reportobject to a subreport object
                    crSubreportObject = CType(crReportObject, SubreportObject)

                    'Open the subreport
                    subRepDoc = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
                    'subRepDoc.SetDataSource(mDataSource)
                    For Each oTable As CrystalDecisions.CrystalReports.Engine.Table In subRepDoc.Database.Tables
                        oTable.SetDataSource(mDataSource)
                    Next

                End If
            Next
        Next


        ReportViewer.ReportSource = Reporte
        ReportViewer.Show()
    End Sub
#End Region

End Class

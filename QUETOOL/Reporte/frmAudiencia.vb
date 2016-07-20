Public Class frmAudiencia
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
        Me.ReportViewer.ShowExportButton = False
        Me.ReportViewer.ShowGotoPageButton = False
        Me.ReportViewer.ShowGroupTreeButton = False
        Me.ReportViewer.ShowRefreshButton = False
        Me.ReportViewer.ShowTextSearchButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(672, 365)
        Me.ReportViewer.TabIndex = 2
        '
        'frmAudiencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 365)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmAudiencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audiencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mDataSource As DataSet
#End Region

#Region "Propiedades Publicas"
    Public WriteOnly Property DataSource() As DataSet
        Set(ByVal Value As DataSet)
            mDataSource = Value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAudiencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mDataSource Is Nothing Then Me.Close()
        Dim Reporte As New rptAudienciaRadio
        Dim Margenes As New CrystalDecisions.[Shared].PageMargins

        Reporte.SetDataSource(mDataSource)

        Margenes.leftMargin = 1
        Margenes.rightMargin = 1
        Margenes.topMargin = 1
        Margenes.bottomMargin = 1

        Reporte.PrintOptions.ApplyPageMargins(Margenes)

        ReportViewer.ReportSource = Reporte
        ReportViewer.Show()
    End Sub
#End Region

End Class

Public Class frmPlanificacionModificadaLog
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
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
        Me.ReportViewer.TabIndex = 0
        '
        'frmPlanificacionModificadaLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 365)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmPlanificacionModificadaLog"
        Me.Text = "Planificaci�n Modificada Log"
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
    Private Sub frmPlanificacionModificadaLog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mDataSource Is Nothing Then Me.Close()
        Dim Reporte As New rptPlanificacionModificadaLog
        Dim Margenes As New CrystalDecisions.[Shared].PageMargins

        Reporte.SetDataSource(mDataSource)
        Reporte.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        Margenes.leftMargin = 0.089999999999999997
        Margenes.rightMargin = 0.63
        Margenes.topMargin = 0.089999999999999997
        Margenes.bottomMargin = 0.01

        Reporte.PrintOptions.ApplyPageMargins(Margenes)
        ReportViewer.ReportSource = Reporte
        ReportViewer.Show()
    End Sub
#End Region
    
End Class

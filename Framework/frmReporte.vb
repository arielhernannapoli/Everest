Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReporte
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
    Public WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.DisplayGroupTree = False
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Nothing
        Me.CRV.TabIndex = 0
        '
        'frmReporte
        '
        Me.Controls.Add(Me.CRV)
        Me.Name = "frmReporte"
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Function SetearConexionReporte(ByVal Reporte As ReportClass) As ReportClass
        '***
        'Recibe un reporte (dimensionado asi: Dim Reporte as New rptNombreReporte) y 
        'le carga los datos de conexion
        '***
        Dim Database As Database
        Dim Tables As Tables
        Dim Table As Table
        Dim TableLogOnInfo As TableLogOnInfo
        Dim ConnectionInfo As ConnectionInfo

        ConnectionInfo = New ConnectionInfo()
        With ConnectionInfo
            .ServerName = "127.0.0.1"
            .DatabaseName = "bus"
            .UserID = "sa"
            .Password = "cd"
        End With

        Database = Reporte.Database
        Tables = Database.Tables

        For Each Table In Tables
            TableLogOnInfo = Table.LogOnInfo
            TableLogOnInfo.ConnectionInfo = ConnectionInfo
            Table.ApplyLogOnInfo(TableLogOnInfo)
        Next

        Return Reporte
    End Function

End Class

Imports System.Configuration
Imports System.Collections.Generic
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine


Namespace ExportacionUtil

    Public Class ParametrosExportacionLegajos
#Region "Declaraciones"
        Private _gestorReportes As Dictionary(Of TipoExportacion, CrystalReportViewer)
        Private _numPresupuesto As Integer
        Private _numContrato As Integer
        Private _numCompania As Integer
        Private _codUsuario As Integer

        Private _param1 As Object

        Private _tipoExportacion As TipoExportacion

#End Region

#Region "Contructor"
        Public Sub New()
            GestoresReporte = New Dictionary(Of TipoExportacion, CrystalReportViewer)()
        End Sub
#End Region

#Region "Propiedades"
        Public Property GestoresReporte() As Dictionary(Of TipoExportacion, CrystalReportViewer)
            Get
                Return _gestorReportes
            End Get
            Set(ByVal value As Dictionary(Of TipoExportacion, CrystalReportViewer))
                _gestorReportes = value
            End Set
        End Property

        Public Property NumPresupuesto() As Integer
            Get
                Return _numPresupuesto
            End Get
            Set(ByVal value As Integer)
                _numPresupuesto = value
            End Set
        End Property

        Public Property NumContrato() As Integer
            Get
                Return _numContrato
            End Get
            Set(ByVal value As Integer)
                _numContrato = value
            End Set
        End Property

        Public Property NumCompania() As Integer
            Get
                Return _numCompania
            End Get
            Set(ByVal value As Integer)
                _numCompania = value
            End Set
        End Property

        Public Property CodUsuario() As Integer
            Get
                Return _codUsuario
            End Get
            Set(ByVal value As Integer)
                _codUsuario = value
            End Set
        End Property

        Public Property Param1() As Object
            Get
                Return _param1
            End Get
            Set(ByVal value As Object)
                _param1 = value
            End Set
        End Property

        Public Property TipoExportacion() As TipoExportacion
            Get
                Return _tipoExportacion
            End Get
            Set(ByVal value As TipoExportacion)
                _tipoExportacion = value
            End Set
        End Property

        Public Shared ReadOnly Property RutaExportacionControlMonitor() As String
            Get
                Return ConfigurationManager.AppSettings("CARPETA_LEGAJOS_CONTROL_MONITOR").ToString()
            End Get
        End Property

        Public Shared ReadOnly Property RutaExportacionCaratula() As String
            Get
                Return ConfigurationManager.AppSettings("CARPETA_LEGAJOS_CARATULA").ToString()
            End Get
        End Property

        Public Shared ReadOnly Property RutaExportacionOrdenInternet() As String
            Get
                Return ConfigurationManager.AppSettings("CARPETA_LEGAJOS_ORDEN_DIGITAL").ToString()
            End Get
        End Property
        Public Shared ReadOnly Property RutaCarpetaTemporal() As String
            Get
                Return ConfigurationManager.AppSettings("RUTA_CARPETA_TEMPORAL").ToString()
            End Get
        End Property
#End Region

    End Class

    Public Enum TipoExportacion
        Caratula = 1
        ControlMonitor = 2
        OrdenDigital = 3
    End Enum


End Namespace
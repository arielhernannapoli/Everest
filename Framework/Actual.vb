Public Class Actual
    'CLIENTES
    Private mIDCliente As Integer
    Private mCliente As String
    'CAMPAÑAS
    Private mIDCampaña As Integer
    Private mCampaña As String
    Private mFechaInicioCampaña As Date
    Private mFechaFinCampaña As Date
    Private mFechaDesdeCampaña As Date
    Private mFechaHastaCampaña As Date
    'SISTEMAS
    Private mIDSistema As Integer
    Private mSistema As String
    Private mFechaInicioSistema As Date
    Private mFechaFinSistema As Date
    Private mFechaInicioAudiencia As Date
    Private mFechaFinAudiencia As Date
    Private mIDMedio As Integer
    Private mIDTipoSoporte As Integer
    Private mIDPlaza As Integer
    Private mPlaza As String
    Private mTarget As String
    'EJERCICIOS
    Private mIDEjercicio As Integer
    Private mEjercicio As String
    Private mIDEstadoEjercicio As Integer
    Private mEstado As Integer
    Private mEspeciales As ArrayList

    Public Property Especiales() As ArrayList
        Get
            If mEspeciales Is Nothing Then
                mEspeciales = New ArrayList
            End If

            Return mEspeciales
        End Get
        Set(ByVal Value As ArrayList)
            mEspeciales = Value
        End Set
    End Property

    Public Property Target() As String
        Get
            Return mTarget
        End Get
        Set(ByVal Value As String)
            mTarget = Value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            Return mEstado
        End Get
        Set(ByVal Value As Integer)
            mEstado = Value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return mCliente
        End Get
        Set(ByVal Value As String)
            mCliente = Value
        End Set
    End Property

    Public Property FechaInicioAudiencia() As Date
        Get
            Return mFechaInicioAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaInicioAudiencia = Value
        End Set
    End Property

    Public Property FechaFinAudiencia() As Date
        Get
            Return mFechaFinAudiencia
        End Get
        Set(ByVal Value As Date)
            mFechaFinAudiencia = Value
        End Set
    End Property

    Public Property FechaDesdeCampaña() As Date
        Get
            Return mFechaDesdeCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaDesdeCampaña = Value
        End Set
    End Property

    Public Property FechaHastaCampaña() As Date
        Get
            Return mFechaHastaCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaHastaCampaña = Value
        End Set
    End Property

    Public Property IDCliente() As Integer
        Get
            Return mIDCliente
        End Get
        Set(ByVal Value As Integer)
            mIDCliente = Value
        End Set
    End Property

    Public Property IDCampaña() As Integer
        Get
            Return mIDCampaña
        End Get
        Set(ByVal Value As Integer)
            mIDCampaña = Value
        End Set
    End Property

    Public Property FechaInicioCampaña() As Date
        Get
            Return mFechaInicioCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaInicioCampaña = Value
        End Set
    End Property

    Public Property FechaFinCampaña() As Date
        Get
            Return mFechaFinCampaña
        End Get
        Set(ByVal Value As Date)
            mFechaFinCampaña = Value
        End Set
    End Property

    Public Property FechaInicioSistema() As Date
        Get
            Return mFechaInicioSistema
        End Get
        Set(ByVal Value As Date)
            mFechaInicioSistema = Value
        End Set
    End Property

    Public Property FechaFinSistema() As Date
        Get
            Return mFechaFinSistema
        End Get
        Set(ByVal Value As Date)
            mFechaFinSistema = Value
        End Set
    End Property

    Public Property IDSistema() As Integer
        Get
            Return mIDSistema
        End Get
        Set(ByVal Value As Integer)
            mIDSistema = Value
        End Set
    End Property

    Public Property IDEjercicio() As Integer
        Get
            Return mIDEjercicio
        End Get
        Set(ByVal Value As Integer)
            mIDEjercicio = Value
        End Set
    End Property

    Public Property IDMedio() As Integer
        Get
            Return mIDMedio
        End Get
        Set(ByVal Value As Integer)
            mIDMedio = Value
        End Set
    End Property

    Public Property IDTipoSoporte() As Integer
        Get
            Return mIDTipoSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDTipoSoporte = Value
        End Set
    End Property

    Public Property IDPlaza() As Integer
        Get
            Return mIDPlaza
        End Get
        Set(ByVal Value As Integer)
            mIDPlaza = Value
        End Set
    End Property

    Public Property Campaña() As String
        Get
            Return mCampaña
        End Get
        Set(ByVal Value As String)
            mCampaña = Value
        End Set
    End Property

    Public Property Sistema() As String
        Get
            Return mSistema
        End Get
        Set(ByVal Value As String)
            mSistema = Value
        End Set
    End Property

    Public Property Ejercicio() As String
        Get
            Return mEjercicio
        End Get
        Set(ByVal Value As String)
            mEjercicio = Value
        End Set
    End Property

    Public Property IDEstadoEjercicio() As Integer
        Get
            Return mIDEstadoEjercicio
        End Get
        Set(ByVal Value As Integer)
            mIDEstadoEjercicio = Value
        End Set
    End Property
End Class

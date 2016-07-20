Public Class Actual
    'CLIENTES
    Private mIDCliente As Integer
    Private mCliente As String
    'CAMPA�AS
    Private mIDCampa�a As Integer
    Private mCampa�a As String
    Private mFechaInicioCampa�a As Date
    Private mFechaFinCampa�a As Date
    Private mFechaDesdeCampa�a As Date
    Private mFechaHastaCampa�a As Date
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

    Public Property FechaDesdeCampa�a() As Date
        Get
            Return mFechaDesdeCampa�a
        End Get
        Set(ByVal Value As Date)
            mFechaDesdeCampa�a = Value
        End Set
    End Property

    Public Property FechaHastaCampa�a() As Date
        Get
            Return mFechaHastaCampa�a
        End Get
        Set(ByVal Value As Date)
            mFechaHastaCampa�a = Value
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

    Public Property IDCampa�a() As Integer
        Get
            Return mIDCampa�a
        End Get
        Set(ByVal Value As Integer)
            mIDCampa�a = Value
        End Set
    End Property

    Public Property FechaInicioCampa�a() As Date
        Get
            Return mFechaInicioCampa�a
        End Get
        Set(ByVal Value As Date)
            mFechaInicioCampa�a = Value
        End Set
    End Property

    Public Property FechaFinCampa�a() As Date
        Get
            Return mFechaFinCampa�a
        End Get
        Set(ByVal Value As Date)
            mFechaFinCampa�a = Value
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

    Public Property Campa�a() As String
        Get
            Return mCampa�a
        End Get
        Set(ByVal Value As String)
            mCampa�a = Value
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

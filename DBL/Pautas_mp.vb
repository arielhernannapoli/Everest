Public Class Pautas_mp
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
    Dim mId As Long
    Dim mAviso As Long
    Dim mPlaza As Long
    Dim mFecha As Date
    Dim mHora As String
    Dim mCanal As Integer
    Dim mTema As String
    Dim mPrograma As String

    Public Property Id() As Long
        Get
            Return mId
        End Get
        Set(ByVal Value As Long)
            mId = Value
        End Set
    End Property
    Public Property Aviso() As Long
        Get
            Return mAviso
        End Get
        Set(ByVal Value As Long)
            mAviso = Value
        End Set
    End Property
    Public Property Plaza() As Long
        Get
            Return mPlaza
        End Get
        Set(ByVal Value As Long)
            mPlaza = Value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal Value As Date)
            mFecha = Value
        End Set
    End Property
    Public Property Hora() As String
        Get
            Return mHora
        End Get
        Set(ByVal Value As String)
            mHora = Value
        End Set
    End Property
    Public Property Canal() As Integer
        Get
            Return mCanal
        End Get
        Set(ByVal Value As Integer)
            mCanal = Value
        End Set
    End Property

    Public Property tema() As String
        Get
            Return mTema
        End Get
        Set(ByVal Value As String)
            mTema = Value
        End Set
    End Property
    Public Property Programa() As String
        Get
            Return mPrograma
        End Get
        Set(ByVal Value As String)
            mPrograma = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("pautas_mp")
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        Me.Id = IIf(IsDBNull(dr("id")), 0, dr("id"))
        Me.Aviso = IIf(IsDBNull(dr("aviso")), 0, dr("aviso"))
        Me.Canal = IIf(IsDBNull(dr("canal")), 0, dr("canal"))
        Me.Fecha = IIf(IsDBNull(dr("fecha")), Nothing, dr("fecha"))
        Me.Hora = IIf(IsDBNull(dr("hora")), "", dr("hora"))
        Me.Programa = IIf(IsDBNull(dr("programa")), "", dr("programa"))
        Me.tema = IIf(IsDBNull(dr("tema")), "", dr("tema"))
        Me.Plaza = IIf(IsDBNull(dr("plaza")), 0, dr("plaza"))

    End Sub
    Public Overloads Function Agregar() As Object

        Dim valor As String
        'MyBase.Agregar(Id, Canal, Fecha, Hora, Programa, tema, Plaza)

        Me.Aviso = MyBase.Agregar(Id, Canal, Fecha, Hora, Programa, tema, Plaza).ToString()

    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Aviso, Id, Canal, Fecha, Hora, Programa.Substring(1, 20), tema, Plaza)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Aviso, Id)
    End Function
    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Aviso)
    End Sub
    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function
    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function

    Public Overloads Sub IniciarTransaccion()
        MyBase.IniciarTransaccion()
    End Sub

    Public Overloads Sub TerminarTransaccion()
        MyBase.TerminarTransaccion()
    End Sub

    Public Overloads Sub AbortarTransaccion()
        MyBase.AbortarTransaccion()
    End Sub
#End Region

#Region "Funciones Propias"
    Public Function NuevoID() As Long
        If MyBase.TraerDataSet("SPK_PAUTAS_MP.SP_NUEVO_ID").Tables(0).Rows.Count > 0 Then
            If IsDBNull(MyBase.TraerDataSet("SPK_PAUTAS_MP.SP_NUEVO_ID").Tables(0).Rows(0)("ID")) Then
                Return 0
            Else
                Return MyBase.TraerDataSet("SPK_PAUTAS_MP.SP_NUEVO_ID").Tables(0).Rows(0)("ID")
            End If
        End If

    End Function

    Public Function ObtenerUniverso(ByVal Pauta As Long) As DataTable
        'SP_SELECT_SESION
        Return MyBase.TraerDataSet("SPK_PAUTAS_MP.SP_SELECT_SESION", Pauta).Tables(0)
    End Function

    Public Function ObtenerUltimaFechaAudiencia() As Date
        Dim fecha As Date
        fecha = CDate(MyBase.TraerValor("SPK_PAUTAS_MP.SP_SELECT_ULTIMA_FECHA", Me.Plaza))
        Return fecha
    End Function

#End Region

    Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class

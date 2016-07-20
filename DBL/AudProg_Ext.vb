Public Class Audprog_ext
    Inherits Entidad

#Region "Propiedades"
    Dim mId_consulta As Int32
    Dim mFec_apr As DateTime
    Dim mCad_apr As String
    Dim mHor_apr As Int32
    Dim mId_trgt As Int32
    Dim mAme_apr As Single
    Dim mCon_apr As Int32
    Dim mTtv_apr As Single
    Dim mCob_apr As Int16
    Dim mVem_apr As Int16

    Public Property Id_consulta() As Int32
        Get
            Return mId_consulta
        End Get
        Set(ByVal Value As Int32)
            mId_consulta = Value
        End Set
    End Property

    Public Property Fec_apr() As DateTime
        Get
            Return mFec_apr
        End Get
        Set(ByVal Value As DateTime)
            mFec_apr = Value
        End Set
    End Property

    Public Property Cad_apr() As String
        Get
            Return mCad_apr
        End Get
        Set(ByVal Value As String)
            mCad_apr = Value
        End Set
    End Property

    Public Property Hor_apr() As Int32
        Get
            Return mHor_apr
        End Get
        Set(ByVal Value As Int32)
            mHor_apr = Value
        End Set
    End Property

    Public Property Id_trgt() As Int32
        Get
            Return mId_trgt
        End Get
        Set(ByVal Value As Int32)
            mId_trgt = Value
        End Set
    End Property

    Public Property Ame_apr() As Single
        Get
            Return mAme_apr
        End Get
        Set(ByVal Value As Single)
            mAme_apr = Value
        End Set
    End Property

    Public Property Con_apr() As Int32
        Get
            Return mCon_apr
        End Get
        Set(ByVal Value As Int32)
            mCon_apr = Value
        End Set
    End Property

    Public Property Ttv_apr() As Single
        Get
            Return mTtv_apr
        End Get
        Set(ByVal Value As Single)
            mTtv_apr = Value
        End Set
    End Property

    Public Property Cob_apr() As Int16
        Get
            Return mCob_apr
        End Get
        Set(ByVal Value As Int16)
            mCob_apr = Value
        End Set
    End Property

    Public Property Vem_apr() As Int16
        Get
            Return mVem_apr
        End Get
        Set(ByVal Value As Int16)
            mVem_apr = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Audprog_Ext")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_consulta, Fec_apr, Cad_apr, Hor_apr, Id_trgt, Ame_apr, Con_apr, Ttv_apr, Cob_apr, Vem_apr)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_consulta, Fec_apr, Cad_apr, Hor_apr, Id_trgt, Ame_apr, Con_apr, Ttv_apr, Cob_apr, Vem_apr)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_consulta)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    'Public Overloads Sub BuscarPorID()
    '    MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_consulta)
    'End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_consulta = IIf(IsDBNull(Dr("Id_consulta")), 0, Dr("Id_consulta"))
        Me.Fec_apr = IIf(IsDBNull(Dr("Fec_apr")), Nothing, Dr("Fec_apr"))
        Me.Cad_apr = IIf(IsDBNull(Dr("Cad_apr")), "", Dr("Cad_apr"))
        Me.Hor_apr = IIf(IsDBNull(Dr("Hor_apr")), 0, Dr("Hor_apr"))
        Me.Id_trgt = IIf(IsDBNull(Dr("Id_trgt")), 0, Dr("Id_trgt"))
        Me.Ame_apr = IIf(IsDBNull(Dr("Ame_apr")), 0, Dr("Ame_apr"))
        Me.Con_apr = IIf(IsDBNull(Dr("Con_apr")), 0, Dr("Con_apr"))
        Me.Ttv_apr = IIf(IsDBNull(Dr("Ttv_apr")), 0, Dr("Ttv_apr"))
        Me.Cob_apr = IIf(IsDBNull(Dr("Cob_apr")), 0, Dr("Cob_apr"))
        Me.Vem_apr = IIf(IsDBNull(Dr("Vem_apr")), 0, Dr("Vem_apr"))
    End Sub

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
    Public Overloads Function BuscarPorId() As DataSet
        Return TraerDataSet("Spk_" & MyBase.Tabla & ".sp_select_id", Id_consulta)
    End Function
#End Region

End Class

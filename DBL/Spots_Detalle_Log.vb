Public Class Spots_detalle_log
    Inherits Entidad

#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mDesc_campania As String
    Dim mId_sistema As Int32
    Dim mDesc_sistema As String
    Dim mId_ejercicio As Int32
    Dim mDesc_ejercicio As String
    Dim mId_spot As Int32
    Dim mId_spot_detalle As Int32
    Dim mPrograma As String
    Dim mH_icio As Int16
    Dim mH_f As Int16
    Dim mNeto As Double
    Dim mId_tema As String
    Dim mDcto1 As Single
    Dim mDcto2 As Single
    Dim mDcto3 As Single
    Dim mDcto4 As Single
    Dim mDcto5 As Single
    Dim mAccion As String
    Dim mU_accion As String
    Dim mF_accion As DateTime

    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
        End Set
    End Property

    Public Property Desc_campania() As String
        Get
            Return mDesc_campania
        End Get
        Set(ByVal Value As String)
            mDesc_campania = Value
        End Set
    End Property

    Public Property Id_sistema() As Int32
        Get
            Return mId_sistema
        End Get
        Set(ByVal Value As Int32)
            mId_sistema = Value
        End Set
    End Property

    Public Property Desc_sistema() As String
        Get
            Return mDesc_sistema
        End Get
        Set(ByVal Value As String)
            mDesc_sistema = Value
        End Set
    End Property

    Public Property Id_ejercicio() As Int32
        Get
            Return mId_ejercicio
        End Get
        Set(ByVal Value As Int32)
            mId_ejercicio = Value
        End Set
    End Property

    Public Property Desc_ejercicio() As String
        Get
            Return mDesc_ejercicio
        End Get
        Set(ByVal Value As String)
            mDesc_ejercicio = Value
        End Set
    End Property

    Public Property Id_spot() As Int32
        Get
            Return mId_spot
        End Get
        Set(ByVal Value As Int32)
            mId_spot = Value
        End Set
    End Property

    Public Property Id_spot_detalle() As Int32
        Get
            Return mId_spot_detalle
        End Get
        Set(ByVal Value As Int32)
            mId_spot_detalle = Value
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

    Public Property H_icio() As Int16
        Get
            Return mH_icio
        End Get
        Set(ByVal Value As Int16)
            mH_icio = Value
        End Set
    End Property

    Public Property H_f() As Int16
        Get
            Return mH_f
        End Get
        Set(ByVal Value As Int16)
            mH_f = Value
        End Set
    End Property

    Public Property Neto() As Double
        Get
            Return mNeto
        End Get
        Set(ByVal Value As Double)
            mNeto = Value
        End Set
    End Property

    Public Property Id_tema() As String
        Get
            Return mId_tema
        End Get
        Set(ByVal Value As String)
            mId_tema = Value
        End Set
    End Property

    Public Property Dcto1() As Single
        Get
            Return mDcto1
        End Get
        Set(ByVal Value As Single)
            mDcto1 = Value
        End Set
    End Property

    Public Property Dcto2() As Single
        Get
            Return mDcto2
        End Get
        Set(ByVal Value As Single)
            mDcto2 = Value
        End Set
    End Property

    Public Property Dcto3() As Single
        Get
            Return mDcto3
        End Get
        Set(ByVal Value As Single)
            mDcto3 = Value
        End Set
    End Property

    Public Property Dcto4() As Single
        Get
            Return mDcto4
        End Get
        Set(ByVal Value As Single)
            mDcto4 = Value
        End Set
    End Property

    Public Property Dcto5() As Single
        Get
            Return mDcto5
        End Get
        Set(ByVal Value As Single)
            mDcto5 = Value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return mAccion
        End Get
        Set(ByVal Value As String)
            mAccion = Value
        End Set
    End Property

    Public Property U_accion() As String
        Get
            Return mU_accion
        End Get
        Set(ByVal Value As String)
            mU_accion = Value
        End Set
    End Property

    Public Property F_accion() As DateTime
        Get
            Return mF_accion
        End Get
        Set(ByVal Value As DateTime)
            mF_accion = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("spots_detalle_log")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_campania, Desc_campania, Id_sistema, Desc_sistema, _
        Id_ejercicio, Desc_ejercicio, Id_spot, Id_spot_detalle, Programa, _
        H_icio, H_f, Neto, Id_tema, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, Accion, _
        U_accion, F_accion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_campania, Desc_campania, Id_sistema, Desc_sistema, Id_ejercicio, Desc_ejercicio, Id_spot, Id_spot_detalle, Programa, H_icio, H_f, Neto, Id_tema, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, Accion, U_accion, F_accion)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_campania)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_campania)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Desc_campania = IIf(IsDBNull(Dr("Desc_campania")), "", Dr("Desc_campania"))
        Me.Id_sistema = IIf(IsDBNull(Dr("Id_sistema")), 0, Dr("Id_sistema"))
        Me.Desc_sistema = IIf(IsDBNull(Dr("Desc_sistema")), "", Dr("Desc_sistema"))
        Me.Id_ejercicio = IIf(IsDBNull(Dr("Id_ejercicio")), 0, Dr("Id_ejercicio"))
        Me.Desc_ejercicio = IIf(IsDBNull(Dr("Desc_ejercicio")), "", Dr("Desc_ejercicio"))
        Me.Id_spot = IIf(IsDBNull(Dr("Id_spot")), 0, Dr("Id_spot"))
        Me.Id_spot_detalle = IIf(IsDBNull(Dr("Id_spot_detalle")), 0, Dr("Id_spot_detalle"))
        Me.Programa = IIf(IsDBNull(Dr("Programa")), "", Dr("Programa"))
        Me.H_icio = IIf(IsDBNull(Dr("H_icio")), 0, Dr("H_icio"))
        Me.H_f = IIf(IsDBNull(Dr("H_f")), 0, Dr("H_f"))
        Me.Neto = IIf(IsDBNull(Dr("Neto")), 0, Dr("Neto"))
        Me.Id_tema = IIf(IsDBNull(Dr("Id_tema")), "", Dr("Id_tema"))
        Me.Dcto1 = IIf(IsDBNull(Dr("Dcto1")), 0, Dr("Dcto1"))
        Me.Dcto2 = IIf(IsDBNull(Dr("Dcto2")), 0, Dr("Dcto2"))
        Me.Dcto3 = IIf(IsDBNull(Dr("Dcto3")), 0, Dr("Dcto3"))
        Me.Dcto4 = IIf(IsDBNull(Dr("Dcto4")), 0, Dr("Dcto4"))
        Me.Dcto5 = IIf(IsDBNull(Dr("Dcto5")), 0, Dr("Dcto5"))
        Me.Accion = IIf(IsDBNull(Dr("Accion")), "", Dr("Accion"))
        Me.U_accion = IIf(IsDBNull(Dr("U_accion")), "", Dr("U_accion"))
        Me.F_accion = IIf(IsDBNull(Dr("F_accion")), Nothing, Dr("F_accion"))
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
#End Region

End Class

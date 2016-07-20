Imports System.IO

Public Class Tandas_tva
    Inherits Entidad

#Region "Propiedades"
    Dim mId_tanda As Int64
    Dim mId_medio As Int16
    Dim mId_soporte As Int64
    Dim mId_plaza As Int16
    Dim mId_target As Int32
    Dim mF_programa As DateTime
    Dim mH_inicio As String
    Dim mH_fin As String

    Public Property Id_tanda() As Int64
        Get
            Return mId_tanda
        End Get
        Set(ByVal Value As Int64)
            mId_tanda = Value
        End Set
    End Property

    Public Property Id_medio() As Int16
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int16)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int64
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int64)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_plaza() As Int16
        Get
            Return mId_plaza
        End Get
        Set(ByVal Value As Int16)
            mId_plaza = Value
        End Set
    End Property

    Public Property Id_target() As Int32
        Get
            Return mId_target
        End Get
        Set(ByVal Value As Int32)
            mId_target = Value
        End Set
    End Property

    Public Property F_programa() As DateTime
        Get
            Return mF_programa
        End Get
        Set(ByVal Value As DateTime)
            mF_programa = Value
        End Set
    End Property

    Public Property H_inicio() As String
        Get
            Return mH_inicio
        End Get
        Set(ByVal Value As String)
            mH_inicio = Value
        End Set
    End Property

    Public Property H_fin() As String
        Get
            Return mH_fin
        End Get
        Set(ByVal Value As String)
            mH_fin = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Tandas_TVA")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_tanda, Id_medio, Id_soporte, Id_plaza, Id_target, F_programa, H_inicio, H_fin)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_tanda, Id_medio, Id_soporte, Id_plaza, Id_target, F_programa, H_inicio, H_fin)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_tanda)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_tanda)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_tanda = IIf(IsDBNull(Dr("Id_tanda")), 0, Dr("Id_tanda"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
        Me.Id_target = IIf(IsDBNull(Dr("Id_target")), 0, Dr("Id_target"))
        Me.F_programa = IIf(IsDBNull(Dr("F_programa")), Nothing, Dr("F_programa"))
        Me.H_inicio = IIf(IsDBNull(Dr("H_inicio")), "", Dr("H_inicio"))
        Me.H_fin = IIf(IsDBNull(Dr("H_fin")), "", Dr("H_fin"))
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

    Public Function AgregarTXT(ByRef f As StreamWriter)
        f.WriteLine(mId_tanda & ";" & mId_medio & ";" & mId_soporte & ";" & mId_plaza & ";" & mId_target & ";" & F_programa & ";" & H_inicio & ";" & H_fin)
    End Function

    Public Sub BorrarDatos_Carga(ByVal desde As Date, ByVal hasta As Date)
        Ejecutar("spk_" + Tabla + ".sp_delete_Datos_Carga", Id_plaza, Id_target, Id_medio, desde, hasta)
    End Sub

    Public Function TraerTandasPorHora() As DataTable
        Return Me.TraerDataSet("spk_" + Tabla + ".sp_select_tandas_por_hora", Id_medio, Id_soporte, Id_plaza, F_programa, Id_target, H_inicio, H_fin).Tables(0)
    End Function
#End Region

End Class

Imports System.Collections.Generic

'GG 19/05/2015 Dimensiones + CISOP
Public Class Tipo_Elemento_VP
    Inherits Entidad

#Region "Propiedades"
    Dim mIdTipoElemento As Integer
    Dim mDescripcion As String
    Dim mRequiereMedida As Boolean

    Public Property IdTipoElemento() As Integer
        Get
            Return mIdTipoElemento
        End Get
        Set(ByVal value As Integer)
            mIdTipoElemento = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property RequiereMedida() As Boolean
        Get
            Return mRequiereMedida
        End Get
        Set(ByVal Value As Boolean)
            mRequiereMedida = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("TIPO_ELEMENTO_VP")
    End Sub

    Public Overloads Function Agregar() As String
        Throw New NotImplementedException
    End Function

    Public Overloads Function Modificar() As String
        Throw New NotImplementedException
    End Function

    Public Overloads Function Borrar() As Integer
        Throw New NotImplementedException
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.IdTipoElemento = IIf(IsDBNull(Dr("Id_Tipo_Elemento")), 0, Dr("Id_Tipo_Elemento"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), 0, Dr("Descripcion"))
        Me.RequiereMedida = IIf(IsDBNull(Dr("Requiere_Medida")), False, Dr("Requiere_Medida"))
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

    Public Function ObtenerTiposElementosVP() As List(Of Tipo_Elemento_VP)
        Dim res As New List(Of Tipo_Elemento_VP)

        Dim dr As IDataReader = MyBase.TraerTodos.CreateDataReader

        While dr.Read
            Dim t As New Tipo_Elemento_VP
            t.ArmarObjeto(dr)
            res.Add(t)
        End While

        Return res
    End Function
#End Region

End Class

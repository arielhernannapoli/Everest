Imports MSL
Imports Framework
Public Class Plazas
    Inherits Entidad

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_plaza As Int32
    Dim mDescripcion As String

    Public Property Id_plaza() As Int32
        Get
            Return mId_plaza
        End Get
        Set(ByVal Value As Int32)
            mId_plaza = Value
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
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Plazas")
    End Sub

    'Public Overloads Function TraerTodos() As DataTable
    '    Return MyBase.TraerTodos()
    'End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_plaza)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
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
    Public Function PorAlternativa(ByVal IDCampaña As Integer, ByVal IDAlternativa As Integer) As DataTable

        'AGuzzardi Anexo los Pazas del MMS -------------------------------------------------------------------------------------------------------------------------------
        Return AnexarPlazaMMS(MyBase.TraerDataSet("spk_plazas.sp_select_por_alternativa", IDCampaña, IDAlternativa).Tables(0), "descripcion")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'AGuzzardi Codigo Original -----------------------------------------------------------------------------------------------------------
        'Return MyBase.TraerDataSet("spk_plazas.sp_select_por_alternativa", IDCampaña, IDAlternativa).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------------------------------
    End Function
#End Region

#Region "DATOS MMMS"
    Public Overloads Function TraerTodos() As DataTable
        oDatosMaestros = New Maestros
        If Activo.DTPlazaCache Is Nothing Then
            Activo.DTPlazaCache = oDatosMaestros.PlazasTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        End If
        Return Activo.DTPlazaCache
    End Function

#End Region

#Region "Procesos Anexos Descripcion Maestros MMS"

    Private Function AnexarPlazaMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else

            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.AcceptChanges()

            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTPlazaCache.Select("ID_PLAZA=" & r("id_plaza"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos

    End Function
#End region

End Class

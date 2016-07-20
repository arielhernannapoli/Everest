Imports MSL
Imports Framework

Public Class Tipos_soporte
    Inherits Entidad

    Dim oTipoSoporte As Maestros
#Region "Propiedades"
    Dim mId_medio As Int16
    Dim mId_tipo_soporte As Int16
    Dim mDescripcion As String

    Public Property Id_medio() As Int16
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int16)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_tipo_soporte() As Int16
        Get
            Return mId_tipo_soporte
        End Get
        Set(ByVal Value As Int16)
            mId_tipo_soporte = Value
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
        MyBase.New("tipos_soporte")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_medio, Id_tipo_soporte, Descripcion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_medio, Id_tipo_soporte, Descripcion)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_medio)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_medio)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_medio = Dr("Id_medio")
        Me.Id_tipo_soporte = Dr("Id_tipo_soporte")
        Me.Descripcion = Dr("Descripcion")
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
    'Public Function TraerTipoSoporte() As DataTable
    '    Return Me.TraerDataSet("spk_acceso_vistas.SP_SELECT_ALL_TIPO_SOPORTE", Me.Id_medio).Tables(0)
    'End Function
    Public Function TraerTipoSoporteMedio() As DataTable

        'AGuzzardi Modificaciones MMS ------------------------------------------------------------------------------------------------------------
        Dim DtTSoporteMedio As DataTable = Activo.DTTipoSoporteCache.Clone
        If Activo.DTTipoSoporteCache Is Nothing Then
            oTipoSoporte = New Maestros
            Activo.DTTipoSoporteCache = oTipoSoporte.ObtenerTipoSoportes(Constantes.COD_PAIS_ARGENTINA)
        End If

        'Filtro en el DtCaheTipoSoporte por Medio y cargo un nuevo DTable --------------------------------------------------------------
        For Each DrTSoporte As DataRow In Activo.DTTipoSoporteCache.Select("ID_MEDIO=" & Id_medio)
            DtTSoporteMedio.ImportRow(DrTSoporte)
        Next
        DtTSoporteMedio.Columns.Remove("DESC_MEDIO")
        DtTSoporteMedio.AcceptChanges()
        '--------------------------------------------------------------------------------------------------------------------------------------------------

        Return DtTSoporteMedio
        '--------------------------------------------------------------------------------------------------------------------------------------------------

        'AGuzzardi Codigo Original -----------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_acceso_vistas.SP_SELECT_TIPO_SOPORTE_MEDIO", Me.Id_medio).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------------------------------

    End Function
#End Region

#Region "DATOS MMS"
    Public Function TraerTipoSoporte() As DataTable
        oTipoSoporte = New Maestros
        Dim dt As DataTable
        dt = oTipoSoporte.TipoSoporteTraerByMedio(Constantes.COD_PAIS_ARGENTINA, Id_medio)
        Return dt
    End Function
#End Region

End Class


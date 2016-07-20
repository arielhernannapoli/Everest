Imports MSL
Imports Framework

Public Class Audiencias_fechas
    Inherits Entidad

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mAnio As Int16
    Dim mSemana As Int16
    Dim mF_inicio As DateTime
    Dim mF_fin As DateTime
    Dim mId_medio As Int16
    Dim mId_tipo_soporte As Int32
    Dim mId_target As Int32
    Dim mId_plaza As String

    Public Property Anio() As Int16
        Get
            Return mAnio
        End Get
        Set(ByVal Value As Int16)
            mAnio = Value
        End Set
    End Property

    Public Property Semana() As Int16
        Get
            Return mSemana
        End Get
        Set(ByVal Value As Int16)
            mSemana = Value
        End Set
    End Property

    Public Property F_inicio() As DateTime
        Get
            Return mF_inicio
        End Get
        Set(ByVal Value As DateTime)
            mF_inicio = Value
        End Set
    End Property

    Public Property F_fin() As DateTime
        Get
            Return mF_fin
        End Get
        Set(ByVal Value As DateTime)
            mF_fin = Value
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

    Public Property Id_tipo_soporte() As Int32
        Get
            Return mId_tipo_soporte
        End Get
        Set(ByVal Value As Int32)
            mId_tipo_soporte = Value
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

    Public Property Id_plaza() As String
        Get
            Return mId_plaza
        End Get
        Set(ByVal Value As String)
            mId_plaza = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Audiencias_fechas")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Anio, Semana, F_inicio, F_fin, Id_medio, Id_tipo_soporte, Id_target, Id_plaza)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Anio, Semana, F_inicio, F_fin, Id_medio, Id_tipo_soporte, Id_target, Id_plaza)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Anio)
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
        Me.Anio = IIf(IsDBNull(Dr("Anio")), 0, Dr("Anio"))
        Me.Semana = IIf(IsDBNull(Dr("Semana")), 0, Dr("Semana"))
        Me.F_inicio = IIf(IsDBNull(Dr("F_inicio")), Nothing, Dr("F_inicio"))
        Me.F_fin = IIf(IsDBNull(Dr("F_fin")), Nothing, Dr("F_fin"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_tipo_soporte = IIf(IsDBNull(Dr("Id_tipo_soporte")), 0, Dr("Id_tipo_soporte"))
        Me.Id_target = IIf(IsDBNull(Dr("Id_target")), 0, Dr("Id_target"))
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), "", Dr("Id_plaza"))
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
    Public Function ObtenerFechasAudiencias() As DataTable
        Return Me.TraerDataSet("Spk_" & MyBase.Tabla & ".sp_select", Me.Id_plaza, Me.Id_medio, Me.Id_tipo_soporte, Me.Id_target).Tables(0)
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Anio)
    End Sub

    Public Function ConsultarCarga_Datos() As DataTable
        ConsultarCarga_Datos = Me.TraerDataSet("Spk_Audiencias_Fechas.SP_SELECT_CARGA_DATOS", mId_plaza, mId_medio, mId_tipo_soporte, F_inicio, F_fin, mId_target).Tables(0)
    End Function

    Public Sub BorrarCarga_Datos()
        MyBase.Ejecutar("Spk_Audiencias_Fechas.SP_DELETE_CARGA_DATOS", mId_plaza, mId_medio, mId_tipo_soporte, mF_inicio, mF_fin, mId_target)
    End Sub
    Public Function ExisteSemana() As Boolean
        If MyBase.TraerDataSet("Spk_Audiencias_Fechas.SP_EXITE_SEMANA", mId_plaza, mId_medio, mId_tipo_soporte, mF_inicio).Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ConsultarFechaTarget() As Boolean
        ConsultarFechaTarget = True
    End Function

    Public Function BorrarFechaTarget() As Boolean
        BorrarFechaTarget = True
    End Function

    Public Function ConsultaGrilla()
        Dim dtAux As DataTable
        Dim rowAux As DataRow

        dtAux = Me.TraerDataSet("Spk_Audiencias_Fechas.SP_CONSULTA_GRILLA").Tables(0)

        For Each dr As DataRow In dtAux.Rows
            rowAux = Activo.DTTipoSoporteCache.Select("ID_MEDIO = " & dr("ID_MEDIO") & " AND ID_TIPO_SOPORTE = " & dr("ID_TIPO_SOPORTE"))(0)
            dr("DESCRIPCION") = rowAux("DESCRIPCION")
            rowAux = Activo.DTPlazaCache.Select("ID_PLAZA = " & dr("ID_PLAZA"))(0)
            dr("PLAZAS") = rowAux("DESCRIPCION")
        Next


        ConsultaGrilla = dtAux

        Return ConsultaGrilla

    End Function
    Public Function Consulta_Ultima_Fecha_Plaza() As Date
        Dim dt As DataTable
        Dim ret As Date
        Try
            dt = Me.TraerDataSet("Spk_Audiencias_Fechas.SP_ULTIMA_FECHA_PLAZA", Id_plaza, Id_medio, Id_tipo_soporte).Tables(0)
            ret = dt.Rows(0).Item("f_inicio")
        Catch ex As DataReaderVacioExcepcion
            ret = CDate("01/01/1800")
        Catch ex As Exception
            ret = CDate("01/01/1800")
        End Try

        Return ret
    End Function
    Public Function Consulta_Ultima_Fecha() As Date
        Dim dt As DataTable
        Dim ret As Date
        Try
            dt = Me.TraerDataSet("Spk_Audiencias_Fechas.SP_CONSULTA_ULTIMA_FECHA", Id_medio, Id_tipo_soporte).Tables(0)
            ret = dt.Rows(0).Item(0)
        Catch ex As DataReaderVacioExcepcion
            ret = CDate("01/01/1800")
        End Try

        Consulta_Ultima_Fecha = ret
    End Function
#End Region

End Class


Imports Framework
Imports MSL

Public Class Alternativas
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mId_alternativa As Int32
    Dim mDescripcion As String
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String

    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
        End Set
    End Property

    Public Property Id_alternativa() As Int32
        Get
            Return mId_alternativa
        End Get
        Set(ByVal Value As Int32)
            mId_alternativa = Value
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

    Public Property F_alta() As DateTime
        Get
            Return mF_alta
        End Get
        Set(ByVal Value As DateTime)
            mF_alta = Value
        End Set
    End Property

    Public Property U_alta() As String
        Get
            Return mU_alta
        End Get
        Set(ByVal Value As String)
            mU_alta = Value
        End Set
    End Property

    Public Property F_modi() As DateTime
        Get
            Return mF_modi
        End Get
        Set(ByVal Value As DateTime)
            mF_modi = Value
        End Set
    End Property

    Public Property U_modi() As String
        Get
            Return mU_modi
        End Get
        Set(ByVal Value As String)
            mU_modi = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Alternativas")
    End Sub

    Public Overloads Function Agregar() As Object
        Return Agregar(Id_campania, Descripcion, F_alta, U_alta, F_modi, U_modi)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_campania, Id_alternativa, Descripcion, F_alta, U_alta, F_modi, U_modi)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_campania, Id_alternativa)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_campania, Id_alternativa)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Id_alternativa = IIf(IsDBNull(Dr("Id_alternativa")), 0, Dr("Id_alternativa"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.F_alta = IIf(IsDBNull(Dr("F_alta")), Nothing, Dr("F_alta"))
        Me.U_alta = IIf(IsDBNull(Dr("U_alta")), "", Dr("U_alta"))
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("F_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), "", Dr("U_modi"))
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
    Public Function ObtenerPorCampaña() As DataTable
        Return Me.TraerDataSet("spk_alternativas.sp_select_all_alternativas", Me.Id_campania).Tables(0)
    End Function

    'sistemas, ejercicios y soportes completos para crear la alternativa
    Public Function ObtenerSoportesCompletos(ByVal pId_Medio As Integer) As DataTable

        'AGuzzardi Modificacion MMS --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Return AnexarSoporteMMS(Me.TraerDataSet("spk_alternativas.sp_select_crea_alternativa", Me.Id_campania, pId_Medio).Tables(0), "Soportes", True, "ID_SOPORTE")
        'Return EliminarColumnasDT(AnexarSoporteMMS(Me.TraerDataSet("spk_alternativas.sp_select_crea_alternativa", Me.Id_campania, pId_Medio).Tables(0), "Soportes", True, "ID_SOPORTE"), "id_medio")
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        'AGuzzardi Codigo Original ----------------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_alternativas.sp_select_crea_alternativa", Me.Id_campania, pId_Medio).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    'sistemas, ejercicios y soportes GUARDADOS EN LA ALTERNATIVA
    Public Function ObtenerSoportesGuardados() As DataTable

        'AGuzzardi Modificacion MMS ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Return AnexarSoporteMMS(Me.TraerDataSet("spk_alternativas.sp_select_soportes_alternativa", Me.Id_campania, Me.Id_alternativa).Tables(0), "Soportes", True, "ID_SOPORTE")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        'AGuzzardi Codigo Original ---------------------------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_alternativas.sp_select_soportes_alternativa", Me.Id_campania, Me.Id_alternativa).Tables(0)
        '------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    'TEMAS GUARDADOS EN LA ALTERNATIVA
    Public Function ObtenerTemasGuardados() As DataTable

        'AGuzzardi Modificacion MMS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim DtDatos, DtMMS As DataTable
        Dim OMsl As New Maestros
        DtDatos = Me.TraerDataSet("spk_alternativas.sp_select_temas_alternativa", Me.Id_campania, Me.Id_alternativa).Tables(0)
        If DtDatos.Rows.Count > 0 Then
            DtMMS = OMsl.MaterialesTraerTodos(Constantes.COD_PAIS_ARGENTINA, CInt(DtDatos.Rows(0)("id_cliente")), CInt(DtDatos.Rows(0)("id_producto")))
            Return EliminarColumnasDT(CargarDt_ObtenerTemasGuardados(DtDatos, DtMMS), "id_cliente")
        Else
            Return DtDatos
        End If
        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'AGuzzardi Codigo Original -----------------------------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_alternativas.sp_select_temas_alternativa", Me.Id_campania, Me.Id_alternativa).Tables(0)
        '------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Function ObtenerMinFIniSist() As Date
        Dim dt As DataTable
        Try
            dt = Me.TraerDataSet("spk_alternativas.sp_select_f_min_ini_sist", Me.Id_campania, Me.Id_alternativa).Tables(0)
            ObtenerMinFIniSist = dt.Rows(0).Item("fecha")
        Catch ex As Exception
            ObtenerMinFIniSist = Nothing
        End Try
    End Function
    Public Function ObtenerSoportesIbope() As DataTable

        'Creo el Dtable con la estructura original ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim DtSoporteIbote As DataTable
        Dim DtAlternativaSoporte As DataTable
        Dim DrAlternativaMedicion As DataRow
        Dim DrAlternativaIdEvaluacion As DataRow
        DtSoporteIbote = Me.ObtenerDatatable("DtSoporteIbope")

        'AGuzzardi 24/05/2010 Anexar Soportes MMS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        DtAlternativaSoporte = OGAdmin.AnexarSoportesMMS(Me.TraerDataSet("spk_alternativas.SP_ALTERNATIVA_SOPORTE_IBOPE", Me.Id_campania, Me.Id_alternativa).Tables(0), -1, "soporte", "Alternativa")
        'AGuzzardi Obtengo las Mediciones de la Base Dependiendo del IdPlaza -------------------------------------------------------------------------------
        If DtAlternativaSoporte.Rows.Count > 0 Then
            Dim ControlIdPlaza As Integer
            Dim Medicon As String
            With DtAlternativaSoporte
                .Columns.Add("MEDICION", GetType(String))
                .AcceptChanges()
            End With
            For Each r As DataRow In DtAlternativaSoporte.Rows
                If ControlIdPlaza <> CInt(r("id_plaza")) Then
                    Dim data As DataSet
                    data = Me.TraerDataSet("spk_alternativas.sp_select_medicion", r("id_plaza"))
                    If Not data Is Nothing And data.Tables.Count > 0 Then
                        If data.Tables(0).Rows.Count > 0 Then
                            DrAlternativaMedicion = data.Tables(0).Rows(0)
                            r("MEDICION") = DrAlternativaMedicion.ItemArray(1).ToString
                            ControlIdPlaza = r("id_plaza")
                            Medicon = DrAlternativaMedicion.ItemArray(1).ToString
                        Else
                            Medicon = 0
                        End If
                    Else
                        Medicon = 0
                    End If
                Else
                    r("MEDICION") = Medicon
                End If
            Next
        End If
        'AGuzzardi 24/05/2010 Obtengo el id de las evaluaciones y los id_Archivos de la Base de Datos -----------------------------------------------------------------------
        If DtAlternativaSoporte.Rows.Count > 0 Then
            Dim ControlIdCadena As String
            Dim Plaza As Integer
            Dim Id As Integer
            Dim Id_Archivo As String
            With DtAlternativaSoporte
                .Columns.Add("PLAZA", GetType(Integer))
                .Columns.Add("ID", GetType(Integer))
                .Columns.Add("ID_ARCHIVO", GetType(String))
                .AcceptChanges()
            End With
            For Each r As DataRow In DtAlternativaSoporte.Rows
                If ControlIdCadena <> CStr(r("ID_CADENA")) Then
                    Dim data As DataSet
                    data = Me.TraerDataSet("spk_alternativas.sp_select_cadena", r("ID_CADENA"))
                    If Not data Is Nothing And data.Tables.Count > 0 Then
                        If data.Tables(0).Rows.Count > 0 Then
                            DrAlternativaIdEvaluacion = data.Tables(0).Rows(0)
                            r("PLAZA") = DrAlternativaIdEvaluacion.ItemArray(0).ToString
                            r("ID") = DrAlternativaIdEvaluacion.ItemArray(2).ToString
                            r("ID_ARCHIVO") = DrAlternativaIdEvaluacion.ItemArray(3).ToString
                            ControlIdCadena = r("ID_CADENA")
                            Plaza = DrAlternativaIdEvaluacion.ItemArray(0).ToString
                            Id = DrAlternativaIdEvaluacion.ItemArray(2).ToString
                            Id_Archivo = DrAlternativaIdEvaluacion.ItemArray(3).ToString
                        End If
                    End If
                Else
                    r("PLAZA") = Plaza
                    r("ID") = Id
                    r("ID_ARCHIVO") = Id_Archivo
                End If
            Next
        End If
        'AGuzzardi 24/05/2010 Agrego y Cargo el Datatable final con la estructura de Evaluacion ------------------------------------------------------------
        If DtAlternativaSoporte.Rows.Count > 0 Then
            Dim Row As DataRow
            For Each DrDatos As DataRow In DtAlternativaSoporte.Rows
                Row = DtSoporteIbote.NewRow()
                Row("ID_SOPORTE") = DrDatos("ID_SOPORTE")
                Row("id_ibope") = DrDatos("ID")
                Row("PLAZA") = DrDatos("PLAZA")
                Row("MEDICION") = DrDatos("MEDICION")
                Row("ID_ARCHIVO") = DrDatos("ID_ARCHIVO")
                Row("soporte") = DrDatos("SOPORTE")
                DtSoporteIbote.Rows.Add(Row)
            Next
        End If

        Return DtSoporteIbote
        '-----------------------------------------------------------------------------------------------------------------------------------------------
        'AGuzzardi Codigo Anterior ----------------------------------------------------------------------------------------------------------------------------------------
        'Return MyBase.TraerDataSet("spk_alternativas.SP_ALTERNATIVA_SOPORTE_IBOPE", Me.Id_campania, Me.Id_alternativa).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function
    Public Function ObtenerMaxFFinSist() As Date
        Dim dt As DataTable
        Try
            dt = Me.TraerDataSet("spk_alternativas.sp_select_f_max_fin_sist", Me.Id_campania, Me.Id_alternativa).Tables(0)
            ObtenerMaxFFinSist = dt.Rows(0).Item("fecha")
        Catch ex As Exception
            ObtenerMaxFFinSist = Nothing
        End Try
    End Function
    Public Function ObtenerTarget() As Integer
        Dim dt As DataTable
        Try
            dt = Me.TraerDataSet("spk_alternativas.sp_select_target", Me.Id_campania, Me.Id_alternativa).Tables(0)
            ObtenerTarget = dt.Rows(0).Item("id_target_1")
        Catch ex As Exception
            ObtenerTarget = Nothing
        End Try
    End Function
#End Region

#Region "Procesos Varios Maestros MMS"

#Region "Anexos de Descripcion Maestros"

    Private Function AnexarSoporteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String, ByVal OrdenarCamposDT As Boolean, ByVal ColEliminar As String) As DataTable

        Dim ArrayIdSoportes As New ArrayList
        If ((DtBaseDatos Is Nothing) Or (DtBaseDatos.Rows.Count = 0)) Then
            Dim SoportesMMS As DataTable
            Return SoportesMMS
        End If
        DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
        DtBaseDatos.AcceptChanges()
        Try
            Dim Rows() As DataRow
            Dim r As DataRow
            For index As Integer = 0 To DtBaseDatos.Rows.Count - 1
                r = DtBaseDatos.Rows(index)
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r.Item("id_soporte") & " and " & "ID_MEDIO=" & r.Item("id_medio"))
                'Aguzzardi 18/05/2010 ---------------------------------------------------------------------------------------------------------------------------------------
                If Rows.Length > 0 Then
                    r.Item(NombreColumna) = (Rows(0).Item("DESCRIPCION").ToString & " - " & Rows(0).Item("id_soporte").ToString)
                    ArrayIdSoportes.Add(Rows(0).Item("id_soporte").ToString)
                End If
                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------
            Next

        Catch ex As Exception

        End Try

        DtBaseDatos.AcceptChanges()
        DtBaseDatos.Columns.Item("Soportes").SetOrdinal(5)
        DtBaseDatos.Columns.Item("ID_SOPORTE").SetOrdinal(6)
        DtBaseDatos.AcceptChanges()
        Return DtBaseDatos
    End Function

    Private Function EliminarColumnasDT(ByVal DtDatos As DataTable, ByVal ParamArray Parametros() As Object) As DataTable

        Dim i As Integer
        If Not DtDatos Is Nothing Then
            For i = 0 To Parametros.Length - 1
                DtDatos.Columns.Remove(Parametros(i).ToString)
            Next
            DtDatos.AcceptChanges()
            Return DtDatos
        End If

    End Function

#End Region

#Region "Funciones Cargas Datos MMS"
    Private Function CargarDt_ObtenerTemasGuardados(ByVal DtBaseDatos As DataTable, ByVal DtMMS As DataTable) As DataTable

        Dim _rowsSelect As DataRow()

        Dim idProducto As Integer
        Dim idCliente As Integer
        Dim idMaterial As Integer
        For Each dr As DataRow In DtBaseDatos.Rows
            idProducto = dr("id_producto")
            idCliente = dr("id_cliente")
            idMaterial = dr("id_material")

            _rowsSelect = Activo.DTProductosCache.Select("ID_PRODUCTO=" & idProducto & " and ID_CLIENTE=" & idCliente)
            If _rowsSelect.Length = 1 Then
                dr("DESCRIPCION") = _rowsSelect(0)("DESCRIPCION").ToString()
            Else
                dr("DESCRIPCION") = "Sin Producto"
            End If

            _rowsSelect = Activo.DTMaterialesCache.Select("ID_PRODUCTO=" & idProducto & " and ID_CLIENTE=" & idCliente & "and ID_MATERIAL = " & idMaterial)
            If _rowsSelect.Length = 1 Then
                dr("MATERIAL") = _rowsSelect(0)("DESCRIPCION").ToString()
            Else
                dr("MATERIAL") = "Sin Material"
            End If

            dr("TEMA") = dr("ID_TEMA") & " - " & dr("DESCRIPCION") & " - " & dr("MATERIAL")
        Next

        'JJP - OLD CODE
        'For index As Integer = 0 To DtBaseDatos.Rows.Count - 1
        '    Dim _idProducto As Integer = DtBaseDatos.Rows.Item(index).Item("id_producto")
        '    Dim _idCliente As Integer = DtBaseDatos.Rows.Item(index).Item("id_cliente")
        '    _rowsSelect = Activo.DTProductosCache.Select("ID_PRODUCTO=" & _idProducto & " and ID_CLIENTE=" & _idCliente)
        'Next

        'For index2 As Integer = 0 To _rowsSelect.Length - 1
        '    For indexTemp As Integer = 0 To DtBaseDatos.Rows.Count - 1
        '        Dim _idMaterial As String = DtBaseDatos.Rows(indexTemp)("ID_MATERIAL").ToString
        '        For index3 As Integer = 0 To DtMMS.Rows.Count - 1
        '            Dim _claveMaterial As String = DtMMS.Rows(index3)("ID_MATERIAL").ToString
        '            If (_idMaterial = _claveMaterial) Then
        '                DtBaseDatos.Rows.Item(indexTemp).Item("MATERIAL") = DtMMS.Rows.Item(index3).Item("DESCRIPCION").ToString
        '            End If
        '            index3 += 1
        '        Next

        '        DtBaseDatos.Rows.Item(indexTemp).Item("DESCRIPCION") = _rowsSelect(index2).Item("DESCRIPCION").ToString
        '        Dim descMaterial As String = DtBaseDatos.Rows.Item(indexTemp).Item("MATERIAL").ToString
        '        If descMaterial = String.Empty Or descMaterial = "" Then
        '            descMaterial = "Sin Material"
        '        End If
        '        DtBaseDatos.Rows.Item(indexTemp).Item("TEMA") = String.Concat(New String() {DtBaseDatos.Rows.Item(indexTemp).Item("id_tema").ToString, " - ", DtBaseDatos.Rows.Item(indexTemp).Item("DESCRIPCION").ToString, " - ", descMaterial})
        '    Next
        '    index2 += 1
        'Next


        Return DtBaseDatos
    End Function


#End Region

    Private Function ArmarEsquemaDataTable(ByVal DtNombre As String, ByVal ParamArray Parametros() As Object) As DataTable

        Dim DtGenerado As New DataTable

        If Parametros.Length > 0 Then
            Dim i As Integer
            Dim Esquema() As String
            Dim Columna As String
            Dim TipoDato As String
            DtGenerado.TableName = DtNombre.Trim
            For i = 0 To Parametros.Length - 1
                Esquema = Split(Parametros(i), "|")
                Columna = CStr(Esquema(0).ToString.Trim)
                TipoDato = CStr(Esquema(1).ToString.Trim)
                TipoDato = "Integer"
                With DtGenerado
                    .Columns.Add(Columna, System.Type.GetType("System." & TipoDato))
                    .AcceptChanges()
                End With
            Next i
        End If
        Return DtGenerado
    End Function

    Private Function ObtenerDatatable(ByVal nomDt As String)
        Dim DtGenerico As New DataTable
        DtGenerico.TableName = nomDt
        With DtGenerico.Columns
            .Add("ID_SOPORTE", GetType(Integer))
            .Add("id_ibope", GetType(Integer))
            .Add("PLAZA", GetType(Integer))
            .Add("MEDICION", GetType(String))
            .Add("ID_ARCHIVO", GetType(String))
            .Add("soporte", GetType(String))
        End With
        Return DtGenerico
    End Function
#End Region

    Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class

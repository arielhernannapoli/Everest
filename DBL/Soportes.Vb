Imports MSL
Imports Framework

Public Class Soportes
    Inherits Entidad
    Implements IDisposable

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_medio As Int32
    Dim mId_soporte As Int32
    Dim mDescripcion As String
    Dim mId_cadena As String
    Dim mId_tipo_soporte As Int32
    Dim mId_plaza As Int32

    Public Property Id_medio() As Int32
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int32)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int32
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int32)
            mId_soporte = Value
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

    Public Property Id_cadena() As String
        Get
            Return mId_cadena
        End Get
        Set(ByVal Value As String)
            mId_cadena = Value
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

    Public Property Id_plaza() As Int32
        Get
            Return mId_plaza
        End Get
        Set(ByVal Value As Int32)
            mId_plaza = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Soportes")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_medio, Id_soporte, Descripcion, Id_cadena, Id_tipo_soporte, Id_plaza)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_medio, Id_soporte, Descripcion, Id_cadena, Id_tipo_soporte, Id_plaza)
    End Function

    Public Overloads Function Borrar() As Object
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
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_cadena = IIf(IsDBNull(Dr("Id_cadena")), "", Dr("Id_cadena"))
        Me.Id_tipo_soporte = IIf(IsDBNull(Dr("Id_tipo_soporte")), 0, Dr("Id_tipo_soporte"))
        Me.Id_plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
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
    'Public Function ObtenerSoportes() As DataTable
    '    Return Me.TraerDataSet("spk_sistemas.sp_filtro_soportes_grilla", Me.Id_medio, Me.Id_tipo_soporte, Me.Id_plaza).Tables(0)
    'End Function

    'Public Function ObtenerSoportesDescripcion() As DataTable
    '    Return Me.TraerDataSet("spk_sistemas.sp_filtro_soportes_desc", Me.Id_medio, Me.Id_tipo_soporte, Me.Id_plaza).Tables(0)
    'End Function

    'Public Sub BuscarPorIDCadena(ByVal s() As Long)
    '    Dim dt As DataTable
    '    Dim i As Integer
    '    ' como puede haber dos cadenas con el mismo id, debo asegurarme que trae el id que le pase para evaluar
    '    dt = MyBase.TraerDataSet("SPK_ACCESO_VISTAS.SP_SOPORTES_ID_CADENA", Id_cadena).Tables(0)
    '    Array.Sort(s) ' ordeno para hacer el binary
    '    For Each row As DataRow In dt.Rows
    '        i = s.BinarySearch(s, row("Id_soporte"))
    '        If i >= 0 Then
    '            Exit For
    '        End If
    '    Next
    '    Me.Id_soporte = s(i)
    '    Me.BuscarPorID_Soporte()

    'End Sub

    '************* WILLY
    'Public Function BuscarPorID_Soporte()
    '    MyBase.TraerUno("SPK_ACCESO_VISTAS.SP_SOPORTES_ID", Id_soporte, Id_medio)
    'End Function

    Public Function TraerIDDescripcion() As DataTable
        'pasar abajo D_C
        Return ObtenerSoportes()
    End Function

    Public Function TraerSoportesConvenio() As DataTable 'ByVal id_medio As Integer, ByVal id_tipo_soporte As Integer) As DataTable
        Dim dt As New DataTable

        With dt.Columns
            .Add("descripcion", GetType(String))
            .Add("id_soporte", GetType(Integer))
        End With

        For Each drSop As DataRow In Activo.DTSoportesCache.Select("ID_MEDIO=" & Me.Id_medio & " and " & " COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte)
            dt.ImportRow(drSop)
        Next

        Return dt
    End Function
    Public Function TraerSopConvenio() As DataTable

        'AGuzzardi Codigo Modificado MMS ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        Dim DtFinal As DataTable
        If Me.Id_medio <> Activo.Medios.Radio Then
            DtFinal = EliminarFilasVacias(OGAdmin.EliminarColumnasDTMMS(OGAdmin.CargarDTMMS(Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_CONVENIOS", Me.Id_medio, Me.Id_tipo_soporte).Tables(0), Activo.CachesMMS.CacheSoportes, "descripcion"), Activo.CachesMMS.CacheMedios, "id_medio"), 2)
        Else
            Dim OMsl As New Maestros
            Dim DtSopCobertuta As DataTable


            With OGAdmin
                DtFinal = .EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.EliminarColumnasDTMMS(.EliminarColumnasDTMMS(BuscarConcatenarPlazas(AnexarMaestroConcateneo(Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_CONVENIOS", Me.Id_medio, Me.Id_tipo_soporte).Tables(0), Activo.CachesMMS.CacheProveedor, "DESPROVEEDOR"), Me.Id_medio, Me.Id_tipo_soporte, "desplaza"), Activo.CachesMMS.CacheProveedor, "id_proveedor", "DESPROVEEDOR"), Activo.CachesMMS.CacheMedios, "id_medio"), Activo.CachesMMS.CachePlazas, "id_plaza", "DESPLAZA"), Activo.CachesMMS.CacheTipoSoportes, "id_tipo_soporte")
            End With


        End If

        Return DtFinal

        'AGuzzardi Codigo Original -----------------------------------------------------------------------------------------------------------------------
    End Function


    Public Function ObtenerMedios() As DataTable
        'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------
        oDatosMaestros = New Maestros
        If Activo.DTMediosCache Is Nothing Then
            Activo.DTMediosCache = oDatosMaestros.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        End If
        Return Activo.DTMediosCache
    End Function

    Public Function ObtenerMediosConvenios() As DataTable
        'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------
        oDatosMaestros = New Maestros
        Dim DtMediosConvenio As DataTable
        DtMediosConvenio = oDatosMaestros.MediosTraerConvenios(Constantes.COD_PAIS_ARGENTINA)

        Return DtMediosConvenio

    End Function


    Public Function ObtenerSoportesMedios() As DataTable
        Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_MEDIO", Me.Id_medio).Tables(0)
    End Function

    Public Function ObtenerSoportesMediosID() As DataTable
        Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_MEDIO_ID", Me.Id_soporte, Me.Id_medio).Tables(0)
    End Function

    'NUEVA FUNCION QUE DEVUELVE EL TIPO DE SOPORTE PARA UN DETERMINADO SOPORTE/MEDIO (AN 11-11-2015)
    Public Function ObtenerTipoSoporteByMedioAndSoporte(ByVal idMedio As Integer, ByVal idSoporte As Integer) As Integer
        Dim dr() As DataRow
        Dim tipo_soporte As Integer
        dr = Activo.DTSoportesCache.Select(String.Format("id_medio={0} and id_soporte={1}", idMedio, idSoporte))

        If dr.Length > 0 Then
            tipo_soporte = dr.FirstOrDefault()("cod_tipo_soporte")
            Return tipo_soporte
        End If

        Return -1

    End Function

    Public Function ObtenerSoportesMediosConvenio() As DataTable

        'AGuzzardi Modificado MMS ----------------------------------------------------------------------------------------------------------------------------------------------------
        Dim OGAdmin As New GrillAdmin
        Dim dt As New DataTable
        With dt.Columns
            .Add("descripcion", GetType(String))
            .Add("id_soporte", GetType(Integer))
        End With

        For Each drSop As DataRow In Activo.DTSoportesCache.Select("id_soporte=" & Me.Id_soporte & " and " & "id_medio=" & Me.Id_medio) '& " and " & "cod_tipo_soporte=" & Me.Id_tipo_soporte)
            dt.ImportRow(drSop)
        Next

        With OGAdmin
            Return dt
            'Return .EliminarColumnasDTMMS(.CargarDTMMS(Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_MEDIO_CONVENIO", Me.Id_soporte, Me.Id_medio, Me.Id_tipo_soporte).Tables(0), Activo.CachesMMS.CacheSoportes, "descripcion"), Activo.CachesMMS.CacheMedios, "id_medio")
        End With

        'AGuzzardi Codigo Original ---- ------------------------------------------------------------------------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_MEDIO_CONVENIO", Me.Id_soporte, Me.Id_medio, Me.Id_tipo_soporte).Tables(0)
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Function ObtenerSoportesTipoSoporteID() As DataTable
        Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_TIPO_SOPORTE_ID", Me.Id_soporte, Me.Id_medio, Me.Id_tipo_soporte).Tables(0)
    End Function

    Public Function ObtenerSoportesMedioTipoSoporte() As DataTable
        Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES", Me.Id_medio, Me.Id_tipo_soporte).Tables(0)
    End Function

    Public Function ObtenerSoportesCampania(ByVal pIdCampania As Integer) As DataTable

        'AGuzzardi Anexar Soportes MMS --------------------------------------------------------
        ''DCAIME agregar descripcion de soportes 11/06/2010
        Dim OGAdmin As New GrillAdmin
        Dim dt As New DataTable
        Dim dtSop As New DataTable
        Dim drSop As DataRow
        With dtSop.Columns
            .Add("DES_SOPORTE", GetType(String))
            .Add("ID_SISTEMA", GetType(String))
            .Add("ID_EJERCICIO", GetType(String))
            .Add("ID_SOPORTE", GetType(String))
            .Add("ID_MEDIO", GetType(String))
        End With

        dt = Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_CAMPANIA", pIdCampania).Tables(0)
        For Each dr As DataRow In dt.Rows
            drSop = dtSop.NewRow()
            Me.Id_medio = dr.Item("ID_MEDIO")
            drSop.Item("DES_SOPORTE") = ObtenerDescripcion(dr.Item("ID_SOPORTE"))
            drSop.Item("ID_SISTEMA") = dr.Item("ID_SISTEMA")
            drSop.Item("ID_EJERCICIO") = dr.Item("ID_EJERCICIO")
            drSop.Item("ID_SOPORTE") = dr.Item("ID_SOPORTE")
            drSop.Item("ID_MEDIO") = dr.Item("ID_MEDIO")
            dtSop.Rows.Add(drSop)
        Next

        ''OGAdmin.AnexarSoportesMMS(dt, "des_soporte", "-1")
        Return dtSop

        '--------------------------------------------------------------------------------------
        'AGuzzardi codigo Original ------------------------------------------------------------
        'Return Me.TraerDataSet("spk_acceso_vistas.SP_SOPORTES_CAMPANIA", pIdCampania).Tables(0)
        '--------------------------------------------------------------------------------------
    End Function
#End Region

#Region "DATOS MMS"

    Public Function ObtenerSoportesMMSVistaMaterializada(ByVal IdPais As Integer) As DataTable

        Return Me.TraerDataSet("SPK_SOPORTES_MMS.SP_OBTENERSOPORTE_MMS", IdPais).Tables(0)
    End Function

    Public Sub ActualizarSoportes()
        Me.Ejecutar("INSERTAR_SOPORTE_MMS")

    End Sub

    Protected Sub ArmarObjetoMSL(ByVal dt As DataTable)
        For Each dr As DataRow In dt.Rows
            With Me
                .Id_medio = IIf(IsDBNull(dr.Item("id_medio")), 0, dr.Item("id_medio"))
                .Id_soporte = IIf(IsDBNull(dr.Item("id_soporte")), 0, dr.Item("id_soporte"))
                .Descripcion = IIf(IsDBNull(dr.Item("descripcion")), "", dr.Item("descripcion"))
                'jsperk - hack: Revisar con Willy el package para que recupere este valor (cadena).
                .Id_cadena = IIf(IsDBNull(dr.Item("id_cadena")), 0, dr.Item("id_cadena"))
                .Id_tipo_soporte = IIf(IsDBNull(dr.Item("cod_tipo_soporte")), 0, dr.Item("cod_tipo_soporte"))
                .Id_plaza = IIf(IsDBNull(dr.Item("cod_cobertura")), 0, dr.Item("cod_cobertura"))
            End With
        Next
    End Sub


    ''//developed by DANIEL CAIME
    Public Function BuscarPorID_Soporte() As DataTable
        oDatosMaestros = New Maestros
        ''

        'Dim dt As DataTable = oDatosMaestros.soporteObtenerXid(Id_medio, Id_soporte)
        'Dim dtTest As DataTable = oDatosMaestros.ObtenerTipoSoportes(Constantes.COD_PAIS_ARGENTINA)
        ''ArmarObjetoMSL(dt)
        'Antes dani ------------------------------------------------------------------------------------------------
        'Dim dtFilter As New DataTable()
        'Dim rows As DataRow()
        'Dim Filter As String = "id_medio = " & Id_medio & "and cod_tipo_soporte <> 4"
        'Dim sort As String = "descripcion"

        'dtFilter = Activo.DTSoportesCache.Clone

        'rows = Activo.DTSoportesCache.Select(Filter, sort)

        'For Each item As DataRow In rows
        '    dtFilter.ImportRow(item)
        'Next

        '' dtFilter.Rows.Add(rows)

        'ArmarObjetoMSL(dtFilter)

        'AGuzzardi 20/05/2010 -----------------------------------------------------------------------------------
        Dim Filter As String = "id_medio = " & Me.Id_medio & "and id_soporte = " & Me.Id_soporte
        Dim rows As DataRow()
        Dim dtFilter As New DataTable()
        dtFilter = Activo.DTSoportesCache.Clone
        rows = Activo.DTSoportesCache.Select(Filter)

        For Each item As DataRow In rows
            dtFilter.ImportRow(item)
        Next

        ArmarObjetoMSL(dtFilter)
        Return dtFilter
        '---------------------------------------------------------------------------------------------------------------

    End Function

    Public Function ObtenerDescripcion(ByVal id_soporte As Integer) As String
        Me.Id_soporte = id_soporte
        Return ObtenerDescripcionXid()
    End Function

    Public Function obtenerSoporteXid()
        Dim dt As DataTable
        oDatosMaestros = New Maestros
        dt = oDatosMaestros.SoporteTraerbyMedio(Constantes.COD_PAIS_ARGENTINA, Id_medio, Id_plaza, Id_tipo_soporte)
        Return dt
    End Function
    Public Function ObtenerSoportes() As DataTable
        'AGuzzardi Codigo No Utilizable -----------------------------------------------------------------------------------------------------------------
        'Dim dt As DataTable
        'oDatosMaestros = New Maestros
        ''CD Agregar filtro de tipo_soporte y plaza
        'dt = oDatosMaestros.SoporteTraerbyMedio(Constantes.COD_PAIS_ARGENTINA, Id_medio, Id_plaza, Id_tipo_soporte)
        'Return dt
        '---------------------------------------------------------------------------------------------------------------------------------------------------------
        'AGuzzardi Extraigo los Soportes del DTCahe Soporte ----------
        Return ObtenerSoportesMMS(Id_medio)
        '-----------------------------------------------------------------------------
    End Function
    Public Function ObtenerSoportesMMS(ByVal Id_Medio) As DataTable

        Dim DTSoportes As New DataTable

        With DTSoportes.Columns
            .Add("descripcion", GetType(String))
            .Add("id_soporte", GetType(Integer))
        End With


        For Each DrSoporte As DataRow In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio)
            DTSoportes.ImportRow(DrSoporte)
        Next

        Return DTSoportes

    End Function

    Public Function ObtenerMediosActivos() As DataTable
        oDatosMaestros = New Maestros
        'AGuzzardi Cargo DT Cache Medios --------------------------------------------------------
        If Activo.DTMediosCache Is Nothing Then
            Activo.DTMedios = oDatosMaestros.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        End If
        '---------------------------------------------------------------------------------
        'Codigo DC ---------------------------------------------------------
        'dt = oDatosMaestros.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        '---------------------------------------------------------------------------------

        Return Activo.DTMediosCache
    End Function
    Public Function ObtenerSoportesDescripcion() As DataTable
        Dim dt As DataTable
        oDatosMaestros = New Maestros
        dt = oDatosMaestros.SoporteTraerbyMedio(Constantes.COD_PAIS_ARGENTINA, Id_medio, Id_plaza, Id_tipo_soporte)
        Return dt 'oDatosMaestros.SoporteDescripcionObtener(Constantes.COD_PAIS_ARGENTINA, Id_medio, Id_soporte)
        'Return Me.TraerDataSet("spk_sistemas.sp_filtro_soportes_desc", Me.Id_medio, Me.Id_tipo_soporte, Me.Id_plaza).Tables(0)
    End Function
    Public Function ObtenerDescripcionXid() As String
        'oDatosMaestros = New Maestros
        'Return oDatosMaestros.SoporteDescripcionObtener(Constantes.COD_PAIS_ARGENTINA, Id_medio, Id_soporte)

        'AGuzzardi Extraido la Descripcion del Soporte del DTCache Soporte ---------------------------------------------
        Dim Rows() As DataRow
        Dim DesSoporte As String
        Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & Id_soporte & " and " & "ID_MEDIO=" & Id_medio)
        If Rows.Length > 0 Then
            DesSoporte = Rows(0)("descripcion").ToString
        End If
        Return DesSoporte
        '----------------------------------------------------------------------------------------------------------------------------------

    End Function


    Public Function AnexarMaestroConcateneo(ByVal DTBaseDatos As DataTable, ByVal CacheIndex As Integer, ByVal ParamArray Columna() As Object) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        Select Case CacheIndex
            Case Activo.CachesMMS.CacheProveedor
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTProveedorCache.Select("ID_PROVEEDOR=" & r("id_proveedor"))
                    For i = 0 To Rows.Length - 1
                        r(Columna(0)) = r(Columna(0)) & Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CachePlazas
                For Each r As DataRow In DTBaseDatos.Rows
                    Rows = Activo.DTPlazaCache.Select("ID_PLAZA=" & r("id_plaza"))
                    For i = 0 To Rows.Length - 1
                        r(Columna(0)) = r(Columna(0)) & "  -  " & Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
        End Select

        Return DTBaseDatos

    End Function

    Public Function BuscarConcatenarPlazas(ByVal DtDatos As DataTable, ByVal id_medio As Integer, ByVal id_tipo_soporte As Integer, ByVal Columna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer
        Dim Length As Integer

        For Each r As DataRow In DtDatos.Rows
            Rows = Activo.DTSoportesCache.Select("ID_MEDIO=" & id_medio & " and " & "cod_tipo_soporte=" & id_tipo_soporte & " and " & "id_soporte=" & r("id_soporte"))
            For i = 0 To Rows.Length - 1
                r("DESCRIPCION") &= r("DESPROVEEDOR").ToString & " - " & Rows(i).Item("DES_COBERTURA").ToString
            Next
        Next

        Return EliminarFilasVacias(DtDatos, 1)

    End Function

    Public Function EliminarFilasVacias(ByVal DtDatos As DataTable, ByVal Operacion As Integer) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer
        Dim Length As Integer

        Select Case Operacion
            Case 1 'Quita Filas que luego del caracter - este vacio
                For Each r As DataRow In DtDatos.Rows
                    Length = r("DESCRIPCION").ToString.Length
                    If r("DESCRIPCION").ToString.Substring(Length - 2, 1) = "-" Then
                        r.Delete()
                    End If
                Next
            Case 2 ' Quita filas que el campo Descripcion este vacio
                For Each r As DataRow In DtDatos.Rows
                    If r("DESCRIPCION").ToString = "" Then
                        r.Delete()
                    End If
                Next
        End Select

        DtDatos.AcceptChanges()
        Return DtDatos

    End Function

    Public Function FiltrarSoportesMMS(ByVal Id_Medio As Integer, ByVal Id_TipoSoporte As Integer, ByVal Id_Plaza As String) As DataTable
        Dim DTSoportes As New DataTable
        Dim dataCol As DataColumnCollection = DTSoportes.Columns
        dataCol.Add("descripcion", GetType(String))
        dataCol.Add("id_soporte", GetType(Integer))
        dataCol = Nothing
        Dim DrSoporte As DataRow
        For Each DrSoporte In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio & " and COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte & " and COD_COBERTURA=" & Id_Plaza)
            DTSoportes.ImportRow(DrSoporte)
        Next
        Return DTSoportes
    End Function

    Public Function FiltrarSoportesMMSVigencia(ByVal Id_Medio As Integer, ByVal Id_TipoSoporte As Integer, ByVal Id_Plaza As String, ByVal Vigente As Boolean) As DataTable
        Dim DTSoportes As New DataTable
        Dim dataCol As DataColumnCollection = DTSoportes.Columns
        dataCol.Add("descripcion", GetType(String))
        dataCol.Add("id_soporte", GetType(Integer))
        dataCol = Nothing
        Dim DrSoporte As DataRow

        'AG 22/10/2013 DIGITAL ======================================================================================================
        If Id_Medio = 2 Then
            DTSoportes.Columns.Add("COD_TIPO_SOPORTE", GetType(Integer))
            For Each DrSoporte In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio & " and COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte & " and VIGENTE=" & IIf(Vigente, 1, 0))
                DTSoportes.ImportRow(DrSoporte)
            Next
        Else
            For Each DrSoporte In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio & " and COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte & " and COD_COBERTURA=" & Id_Plaza & " and VIGENTE=" & IIf(Vigente, 1, 0))
                DTSoportes.ImportRow(DrSoporte)
            Next
        End If
        '============================================================================================================================
        'AG DIGITAL Anterior ===================================
        'For Each DrSoporte In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio & " and COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte & " and COD_COBERTURA=" & Id_Plaza & " and VIGENTE=" & IIf(Vigente, 1, 0))
        'DTSoportes.ImportRow(DrSoporte)
        'Next
        '========================================================

        Return DTSoportes
    End Function

    Public Function FiltrarSoportesMMSDescripcion(ByVal Id_Medio As Integer, ByVal Id_TipoSoporte As Integer, ByVal Id_Plaza As String, ByVal Vigente As Boolean, ByVal Texto As String) As DataTable
        Dim DTSoportes As New DataTable
        Dim dataCol As DataColumnCollection = DTSoportes.Columns
        dataCol.Add("descripcion", GetType(String))
        dataCol.Add("id_soporte", GetType(Integer))
        dataCol = Nothing
        Dim DrSoporte As DataRow
        For Each DrSoporte In Activo.DTSoportesCache.Select("ID_MEDIO=" & Id_Medio & " and COD_TIPO_SOPORTE=" & Me.Id_tipo_soporte & " and COD_COBERTURA=" & Id_Plaza & " and VIGENTE=" & IIf(Vigente, 1, 0) & " and DESCRIPCION like '%" & Texto & "%'")
            DTSoportes.ImportRow(DrSoporte)
        Next
        Return DTSoportes
    End Function

#End Region

    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar otro estado (objetos administrados).
            End If

            ' TODO: Liberar su propio estado (objetos no administrados).
            ' TODO: Establecer campos grandes como Null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class


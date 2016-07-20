Imports Framework
Imports MSL
Public Class Convenios
    Inherits Entidad
    Implements IDisposable
    Dim WithEvents DtDatosBase As New DataTable

#Region "Propiedades"
    Dim mId_medio As Int16
    Dim mId_soporte As Int16
    Dim mId_cliente As Int16
    Dim mId_producto As Int16
    Dim mId_convenio As Int64
    Dim mF_inicio As DateTime
    Dim mF_fin As DateTime
    Dim mDetalle As String
    Dim mParticipacion As String
    Dim mPrograma As String
    Dim mDcto1 As Single
    Dim mDcto2 As Single
    Dim mDcto3 As Single
    Dim mDcto4 As Single
    Dim mDcto5 As Single
    Dim mDctoCompra1 As Single
    Dim mDctoCompra2 As Single
    Dim mDctoCompra3 As Single
    Dim mDctoCompra4 As Single
    Dim mDctoCompra5 As Single
    Dim mDctoExtra1 As Single
    Dim mDctoExtra2 As Single
    Dim mNeto As Double
    Dim mNetoCompra As Double
    Dim mObservaciones As String
    Dim mObs_Compra As String
    Dim mObs_Venta As String
    Dim mObs_Extra As String
    Dim mObs_Finanzas As String
    Dim mSemana As String
    Dim mHh_desde As Int16
    Dim mHh_hasta As Int16
    Dim mMm_desde As Int16
    Dim mMm_hasta As Int16
    Dim mTipo_convenio As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mCPRDecimal As Double
    Dim mTipo_Confidencial As Int16 'AG TC
    Dim mIdUsuarioCreacion As Integer
    Dim mIdUsuarioAprobacion As String
    Dim mIdEstado As Integer
    Dim mClaveidConvenio As String

    Public Property Id_medio() As Int16
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int16)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_soporte() As Int16
        Get
            Return mId_soporte
        End Get
        Set(ByVal Value As Int16)
            mId_soporte = Value
        End Set
    End Property

    Public Property Id_cliente() As Int16
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Int16)
            mId_cliente = Value
        End Set
    End Property

    Public Property Id_producto() As Int16
        Get
            Return mId_producto
        End Get
        Set(ByVal Value As Int16)
            mId_producto = Value
        End Set
    End Property

    Public Property Id_convenio() As Int64
        Get
            Return mId_convenio
        End Get
        Set(ByVal Value As Int64)
            mId_convenio = Value
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

    Public Property Detalle() As String
        Get
            Return mDetalle
        End Get
        Set(ByVal Value As String)
            mDetalle = Value
        End Set
    End Property

    Public Property Participacion() As String
        Get
            Return mParticipacion
        End Get
        Set(ByVal Value As String)
            mParticipacion = Value
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

    Public Property DctoCompra1() As Single
        Get
            Return mDctoCompra1
        End Get
        Set(ByVal Value As Single)
            mDctoCompra1 = Value
        End Set
    End Property

    Public Property DctoCompra2() As Single
        Get
            Return mDctoCompra2
        End Get
        Set(ByVal Value As Single)
            mDctoCompra2 = Value
        End Set
    End Property

    Public Property DctoCompra3() As Single
        Get
            Return mDctoCompra3
        End Get
        Set(ByVal Value As Single)
            mDctoCompra3 = Value
        End Set
    End Property

    Public Property DctoCompra4() As Single
        Get
            Return mDctoCompra4
        End Get
        Set(ByVal Value As Single)
            mDctoCompra4 = Value
        End Set
    End Property

    Public Property DctoCompra5() As Single
        Get
            Return mDctoCompra5
        End Get
        Set(ByVal Value As Single)
            mDctoCompra5 = Value
        End Set
    End Property

    Public Property DctoExtra1() As Single
        Get
            Return mDctoExtra1
        End Get
        Set(ByVal Value As Single)
            mDctoExtra1 = Value
        End Set
    End Property

    Public Property DctoExtra2() As Single
        Get
            Return mDctoExtra2
        End Get
        Set(ByVal Value As Single)
            mDctoExtra2 = Value
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

    Public Property NetoCompra() As Double
        Get
            Return mNetoCompra
        End Get
        Set(ByVal Value As Double)
            mNetoCompra = Value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return mObservaciones
        End Get
        Set(ByVal Value As String)
            mObservaciones = Value
        End Set
    End Property

    Public Property Obs_Compra() As String
        Get
            Return mObs_Compra
        End Get
        Set(ByVal Value As String)
            mObs_Compra = Value
        End Set
    End Property

    Public Property Obs_Venta() As String
        Get
            Return mObs_Venta
        End Get
        Set(ByVal Value As String)
            mObs_Venta = Value
        End Set
    End Property

    Public Property Obs_Extra() As String
        Get
            Return mObs_Extra
        End Get
        Set(ByVal Value As String)
            mObs_Extra = Value
        End Set
    End Property

    Public Property Obs_Finanzas() As String
        Get
            Return mObs_Finanzas
        End Get
        Set(ByVal Value As String)
            mObs_Finanzas = Value
        End Set
    End Property

    Public Property Semana() As String
        Get
            Return mSemana
        End Get
        Set(ByVal Value As String)
            mSemana = Value
        End Set
    End Property

    Public Property Hh_desde() As Int16
        Get
            Return mHh_desde
        End Get
        Set(ByVal Value As Int16)
            mHh_desde = Value
        End Set
    End Property

    Public Property Hh_hasta() As Int16
        Get
            Return mHh_hasta
        End Get
        Set(ByVal Value As Int16)
            mHh_hasta = Value
        End Set
    End Property

    Public Property Mm_desde() As Int16
        Get
            Return mMm_desde
        End Get
        Set(ByVal Value As Int16)
            mMm_desde = Value
        End Set
    End Property

    Public Property Mm_hasta() As Int16
        Get
            Return mMm_hasta
        End Get
        Set(ByVal Value As Int16)
            mMm_hasta = Value
        End Set
    End Property

    Public Property Tipo_convenio() As String
        Get
            Return mTipo_convenio
        End Get
        Set(ByVal Value As String)
            mTipo_convenio = Value
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

    Public Property CPRDecimal() As Double
        Get
            Return mCPRDecimal
        End Get
        Set(ByVal Value As Double)
            mCPRDecimal = Value
        End Set
    End Property

    Public Property Tipo_Confidencial() As Int16 'AG TC
        Get
            Return mTipo_Confidencial
        End Get
        Set(ByVal Value As Int16)
            mTipo_Confidencial = Value
        End Set
    End Property

    Public Property IdUsuarioCreacion() As Integer
        Get
            Return mIdUsuarioCreacion
        End Get
        Set(ByVal Value As Integer)
            mIdUsuarioCreacion = Value
        End Set
    End Property

    Public Property IdUsuarioAprobacion() As String
        Get
            Return mIdUsuarioAprobacion
        End Get
        Set(ByVal Value As String)
            mIdUsuarioAprobacion = Value
        End Set
    End Property

    Public Property IdEstado() As Integer
        Get
            Return mIdEstado
        End Get
        Set(ByVal Value As Integer)
            mIdEstado = Value
        End Set
    End Property

    Public Property ClaveidConvenio() As String
        Get
            Return mClaveidConvenio
        End Get
        Set(ByVal Value As String)
            mClaveidConvenio = Value
        End Set
    End Property



#End Region

#Region "Funciones Web"

    Public Function ObtenerConveniosWeb() As DataTable
        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_OBTENER_CONVENIOS_WEB", Me.Id_convenio).Tables(0)
    End Function

    Public Function AutorizarConveniosWeb() As DataTable
        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_AUTORIZAR_WEB", Me.Id_convenio).Tables(0)
    End Function

    Public Function RechazarConveniosWeb() As DataTable
        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_RECHAZAR_WEB", Me.Id_convenio).Tables(0)
    End Function

#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Ar_Convenios")
    End Sub

    Public Overloads Function Agregar() As Object  'AG TC
        MyBase.Agregar(Id_medio, Id_soporte, Id_cliente, Id_producto, F_inicio, F_fin, Detalle, Participacion, Programa, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, DctoCompra1, DctoCompra2, DctoCompra3, DctoCompra4, DctoCompra5, DctoExtra1, DctoExtra2, Neto, NetoCompra, Obs_Compra, Obs_Venta, Obs_Extra, Semana, Hh_desde, Hh_hasta, Mm_desde, Mm_hasta, F_modi, U_modi, Tipo_convenio, Obs_Finanzas, CPRDecimal, Tipo_Confidencial, Me.IdUsuarioCreacion, Me.IdUsuarioAprobacion, Me.IdEstado, Me.ClaveidConvenio)
    End Function

    Public Overloads Function Modificar() As Object 'AG TC
        MyBase.Modificar(Id_convenio, F_inicio, F_fin, Detalle, Participacion, Programa, Dcto1, Dcto2, Dcto3, Dcto4, Dcto5, DctoCompra1, DctoCompra2, DctoCompra3, DctoCompra4, DctoCompra5, DctoExtra1, DctoExtra2, Neto, NetoCompra, Obs_Compra, Obs_Venta, Obs_Extra, Semana, Hh_desde, Hh_hasta, Mm_desde, Mm_hasta, F_modi, U_modi, Obs_Finanzas, CPRDecimal, Tipo_Confidencial, Me.IdUsuarioCreacion, Me.IdUsuarioAprobacion, Me.IdEstado, Me.ClaveidConvenio)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_convenio)
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
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.Id_producto = IIf(IsDBNull(Dr("Id_producto")), 0, Dr("Id_producto"))
        Me.Id_convenio = IIf(IsDBNull(Dr("Id_convenio")), 0, Dr("Id_convenio"))
        Me.F_inicio = IIf(IsDBNull(Dr("F_inicio")), Nothing, Dr("F_inicio"))
        Me.F_fin = IIf(IsDBNull(Dr("F_fin")), Nothing, Dr("F_fin"))
        Me.Detalle = IIf(IsDBNull(Dr("Detalle")), "", Dr("Detalle"))
        Me.Participacion = IIf(IsDBNull(Dr("Participacion")), "", Dr("Participacion"))
        Me.Programa = IIf(IsDBNull(Dr("Programa")), "", Dr("Programa"))
        Me.Dcto1 = IIf(IsDBNull(Dr("Dcto1")), 0, Dr("Dcto1"))
        Me.Dcto2 = IIf(IsDBNull(Dr("Dcto2")), 0, Dr("Dcto2"))
        Me.Dcto3 = IIf(IsDBNull(Dr("Dcto3")), 0, Dr("Dcto3"))
        Me.Dcto4 = IIf(IsDBNull(Dr("Dcto4")), 0, Dr("Dcto4"))
        Me.Dcto5 = IIf(IsDBNull(Dr("Dcto5")), 0, Dr("Dcto5"))
        Me.Neto = IIf(IsDBNull(Dr("Neto")), 0, Dr("Neto"))
        Me.Observaciones = IIf(IsDBNull(Dr("Observaciones")), "", Dr("Observaciones"))
        Me.Semana = IIf(IsDBNull(Dr("Semana")), "", Dr("Semana"))
        Me.Hh_desde = IIf(IsDBNull(Dr("Hh_desde")), 0, Dr("Hh_desde"))
        Me.Hh_hasta = IIf(IsDBNull(Dr("Hh_hasta")), 0, Dr("Hh_hasta"))
        Me.Mm_desde = IIf(IsDBNull(Dr("Mm_desde")), 0, Dr("Mm_desde"))
        Me.Mm_hasta = IIf(IsDBNull(Dr("Mm_hasta")), 0, Dr("Mm_hasta"))
        Me.Tipo_convenio = IIf(IsDBNull(Dr("Tipo_convenio")), "", Dr("Tipo_convenio"))
        Me.Tipo_Confidencial = Dr("TConfidencial")  'AG TC 
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
    Sub Dispose() Implements IDisposable.Dispose

    End Sub

    Public Function ValidarDuplicacionConvenios() As DataTable

        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_DUPLICAR", Me.Id_cliente, Me.F_inicio, Me.F_fin).Tables(0)

        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function ObtenerTipoConvenioSpot() As String

        Dim Dt As DataTable

        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS. SP_TIPO_CONVENIO_SPOT", Me.Id_medio, Me.Id_soporte, Me.Id_cliente, Me.Id_convenio).Tables(0)

        Return Dt.Rows(0)("TIPO_CONVENIO").ToString

        Try

        Catch ex As Exception

        End Try

    End Function


    Public Function ObtenerReporteConvenios(ByVal id_cliente As Integer, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal Vigencia As Integer) As DataTable

        Dim Dt As DataTable

        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS. SP_AR_REPORTE_CONVENIO", id_cliente, id_medio, id_soporte, Vigencia).Tables(0)

        If Dt.Rows.Count > 0 Then
            Dt = AnexarDescripcionSoporteMMS(Dt, "SOPORTE")
            Dt = AnexarDescripcionClienteMMS(Dt, "CLIENTE")
            Dt = AnexarDescripcionProductosMMS(Dt, "PRODUCTO")
            Dt = AnexarDescripcionMedioMMS(Dt, "MEDIO")
        End If

        Dt.Columns.Remove("ID_SOPORTE")

        Return Dt

    End Function

    Public Function ObtenerReporteConveniosEspecial(ByVal id_cliente As Integer, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal Vigencia As Integer) As DataTable

        Dim Dt As DataTable

        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_ESPECIAL", id_cliente, id_medio, id_soporte, Vigencia).Tables(0)

        If Dt.Rows.Count > 0 Then
            Dt = AnexarDescripcionSoporteMMS(Dt, "SOPORTE")
            Dt = AnexarDescripcionClienteMMS(Dt, "CLIENTE")
            Dt = AnexarDescripcionProductosMMS(Dt, "PRODUCTO")
            Dt = AnexarDescripcionMedioMMS(Dt, "MEDIO")
        End If

        Dt.Columns.Remove("ID_SOPORTE")

        Return Dt

    End Function

    Public Function ObtenerReporteConvenioDuplicar(ByVal id_cliente As Integer, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal Fvigencia As Date) As DataTable

        Dim Dt As DataTable

        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS. SP_AR_REPORTE_DUPLICAR", id_cliente, id_medio, id_soporte, Fvigencia).Tables(0)

        If Dt.Rows.Count > 0 Then
            Dt = AnexarDescripcionSoporteMMS(Dt, "SOPORTE")
            Dt = AnexarDescripcionClienteMMS(Dt, "CLIENTE")
            Dt = AnexarDescripcionProductosMMS(Dt, "PRODUCTO")
            Dt = AnexarDescripcionMedioMMS(Dt, "MEDIO")
        End If

        'Dt.Columns.Remove("ID_SOPORTE")

        Return Dt

    End Function

    Public Sub ActualizarFechaFin(ByVal cod_convenio As Integer, ByVal fecha_fin As Date, ByVal user As String, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal id_cliente As Integer)

        Me.Ejecutar("SPK_AR_CONVENIOS.SP_UPDATE_FECHA_FIN", cod_convenio, fecha_fin, user, id_medio, id_soporte, id_cliente)

    End Sub

    Public Sub InsertarDuplicado(ByVal cod_convenio As Integer, ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal user As String, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal id_cliente As Integer, ByVal id_cONVENIO As Integer)

        Me.Ejecutar("SPK_AR_CONVENIOS.SP_DUPLICAR_MASIVO", cod_convenio, fecha_inicio, fecha_fin, user, id_medio, id_soporte, id_cliente, id_cONVENIO)

    End Sub

    Public Sub InsertarAnexoConvenio(ByVal cod_medio As Integer, ByVal cod_soporte As Integer, ByVal cod_cliente As Integer, ByVal cod_producto As Integer, ByVal anexo As Byte(), ByVal tipo As String, ByVal nombre As String)
        Me.Ejecutar("SPK_AR_CONVENIOS.SP_INSERT_ANEXO", cod_medio, cod_soporte, cod_cliente, cod_producto, 0, 0, anexo, tipo, nombre)
    End Sub

    Public Sub BorrarAnexosConvenio(ByVal id_convenio As Integer)
        Me.Ejecutar("SPK_AR_CONVENIOS.SP_BORRAR_ANEXOS", id_convenio, 0)
    End Sub

    Public Sub BorrarAnexosConvenio(ByVal id_convenio As Integer, ByVal id_anexo As Integer)
        Me.Ejecutar("SPK_AR_CONVENIOS.SP_BORRAR_ANEXOS", id_convenio, id_anexo)
    End Sub

    Public Function ObtenerAnexosConvenio(ByVal id_convenio As Integer) As DataTable
        Dim Dt As DataTable
        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS.SP_OBTENER_ANEXOS", id_convenio).Tables(0)
        Return Dt
    End Function

    Public Function CargarGrillaxSoporte() As DataTable
        Try
            Dim DtConvenios As DataTable
            DtConvenios = AnexarProductosMMS(AnexarClienteMMS(AnexarSoporteMMS(MyBase.TraerDataSet("SPK_ACCESO_VISTAS.SP_CONVENIOS", Id_cliente, Id_soporte, Id_medio, F_inicio, F_fin).Tables(0), "DESCRIPCION"), "DESCRIPCION1"), "DESCRIPCION2")


            If DtConvenios Is Nothing Then
                Exit Function
            End If

            Dim DtConvenioFiltrado As DataTable = DtConvenios.Clone

            'AG CCPR 
            If Activo.TEjecicioActivo = 0 Then
                For Each dr As DataRow In DtConvenios.Rows
                    If dr.Item("tipo_convenio") = "D" Or dr.Item("tipo_convenio") = "T" Then
                        DtConvenioFiltrado.ImportRow(dr)
                    End If
                Next
                DtConvenioFiltrado.Columns.Remove("CPR")
            Else
                For Each dr As DataRow In DtConvenios.Rows
                    If dr.Item("tipo_convenio") = "C" Then
                        DtConvenioFiltrado.ImportRow(dr)
                    End If
                Next
            End If

            Return DtConvenioFiltrado

            'Return AnexarProductosMMS(AnexarClienteMMS(AnexarSoporteMMS(MyBase.TraerDataSet("SPK_ACCESO_VISTAS.SP_CONVENIOS", Id_cliente, Id_soporte, Id_medio, F_inicio, F_fin).Tables(0), "DESCRIPCION"), "DESCRIPCION1"), "DESCRIPCION2")

        Catch ex As DataReaderVacioExcepcion
            ' nada
        End Try
    End Function
    Public Function ObtenerConvenios(ByVal Vigencia As Integer, ByVal idTipoSoporte As Integer, ByVal IdProducto As Integer) As DataTable
        Try
            'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------------------------            '' modified by daniel caime 01/06/2010

            Dim DtDatosBase As DataTable
            Dim OGAdmin As New GrillAdmin
            Dim dt As New DataTable
            Dim DtTodos As New DataTable

            'AG 04/11/2010 Codigo nuevo ---------------------------------------------------------------------------------------------------------------
            If Id_cliente = -2 And IdProducto = -1 Then
                For Each DrCliente As DataRow In Activo.DTClientesCache.Rows
                    DtTodos = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO", Int(DrCliente("id_cliente").ToString), _
                        Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia).Tables(0)
                    If DtTodos.Rows.Count > 0 Then
                        If dt.Rows.Count = 0 Then
                            dt = DtTodos.Clone
                        End If
                    End If
                    For Each DrTodosConvenios As DataRow In DtTodos.Rows
                        dt.ImportRow(DrTodosConvenios)
                    Next
                    DtTodos = Nothing
                Next
            Else
                dt = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO", Id_cliente, _
                    Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia).Tables(0)
            End If
            With OGAdmin
                DtDatosBase = .CargarDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheTipoSoportes, "TIPO_SOPORTE"), Activo.CachesMMS.CacheClientes, "Cliente")
            End With

            Dim Rows() As DataRow
            Dim i As Integer
            For Each r As DataRow In DtDatosBase.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("cod_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r("Tipo_Soporte") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
                Next
            Next

            For Each r As DataRow In DtDatosBase.Rows
                If r("id_producto") = 0 Then
                    r("Producto") = "Todos"
                Else
                    DtDatosBase = OGAdmin.CargarDTMMS(DtDatosBase, Activo.CachesMMS.CacheProductos, "Producto")
                End If
            Next

            'AG 07/09/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Dim TipoSoporte() As DataRow
            Dim j As Integer
            TipoSoporte = Activo.DTSoportesCache.Select("cod_tipo_soporte=" & idTipoSoporte & " and " & "id_medio=" & Id_medio) '" and " & "cod_tipo_soporte=" & idTipoSoporte)
            DtDatosBase.Columns.Add("id_tsoporte", GetType(Integer))

            For Each e As DataRow In DtDatosBase.Rows
                For i = 0 To TipoSoporte.Length - 1
                    If TipoSoporte(i).Item("cod_tipo_soporte") = idTipoSoporte And TipoSoporte(i).Item("Id_medio") = e("id_medio") And TipoSoporte(i).Item("Id_soporte") = e("cod_soporte") Then
                        e("id_tsoporte") = TipoSoporte(i).Item("cod_tipo_soporte").ToString
                    End If
                Next
            Next

            Dim DtResultado As DataTable = DtDatosBase.Clone
            Dim DrResultado As DataRow

            For Each DrResultado In DtDatosBase.Select("id_medio=" & Id_medio & " and id_tsoporte=" & idTipoSoporte)
                DtResultado.ImportRow(DrResultado)
            Next
            If idTipoSoporte = -1 Then
               
            ElseIf idTipoSoporte > -1 Then
                DtDatosBase.Clear()
                DtDatosBase = DtResultado
            End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Return DtDatosBase

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ObtenerConveniosListar(ByVal Vigencia As Integer, ByVal idTipoSoporte As Integer, ByVal IdProducto As Integer) As DataTable
        Try
            'AGuzzardi Modificaciones MMS ----------------------------------------------------------------------------------------------------------            '' modified by daniel caime 01/06/2010

            Dim DtDatosBase As DataTable
            Dim OGAdmin As New GrillAdmin
            Dim dt As New DataTable
            Dim DtTodos As New DataTable

            'AG 04/11/2010 Codigo nuevo ---------------------------------------------------------------------------------------------------------------
            If Id_cliente = -2 And IdProducto = -1 Then
                For Each DrCliente As DataRow In Activo.DTClientesCache.Rows
                    DtTodos = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_LISTAR", Int(DrCliente("id_cliente").ToString), _
                        Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia, Activo.PerfilConvenios).Tables(0)
                    If DtTodos.Rows.Count > 0 Then
                        If dt.Rows.Count = 0 Then
                            dt = DtTodos.Clone
                        End If
                    End If
                    For Each DrTodosConvenios As DataRow In DtTodos.Rows
                        dt.ImportRow(DrTodosConvenios)
                    Next
                    DtTodos = Nothing
                Next
            Else
                dt = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_LISTAR", Id_cliente, _
                    Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia, Activo.PerfilConvenios).Tables(0)
            End If
            With OGAdmin
                DtDatosBase = .CargarDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheTipoSoportes, "TIPO_SOPORTE"), Activo.CachesMMS.CacheClientes, "Cliente")
            End With

            Dim Rows() As DataRow
            Dim i As Integer
            For Each r As DataRow In DtDatosBase.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("cod_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r("Tipo_Soporte") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
                Next
            Next

            For Each r As DataRow In DtDatosBase.Rows
                If r("id_producto") = 0 Then
                    r("Producto") = "Todos"
                Else
                    DtDatosBase = OGAdmin.CargarDTMMS(DtDatosBase, Activo.CachesMMS.CacheProductos, "Producto")
                End If
            Next

            'AG 07/09/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Dim TipoSoporte() As DataRow
            Dim j As Integer
            TipoSoporte = Activo.DTSoportesCache.Select("cod_tipo_soporte=" & idTipoSoporte & " and " & "id_medio=" & Id_medio) '" and " & "cod_tipo_soporte=" & idTipoSoporte)
            DtDatosBase.Columns.Add("id_tsoporte", GetType(Integer))

            For Each e As DataRow In DtDatosBase.Rows
                For i = 0 To TipoSoporte.Length - 1
                    If TipoSoporte(i).Item("cod_tipo_soporte") = idTipoSoporte And TipoSoporte(i).Item("Id_medio") = e("id_medio") And TipoSoporte(i).Item("Id_soporte") = e("cod_soporte") Then
                        e("id_tsoporte") = TipoSoporte(i).Item("cod_tipo_soporte").ToString
                    End If
                Next
            Next

            Dim DtResultado As DataTable = DtDatosBase.Clone
            Dim DrResultado As DataRow

            For Each DrResultado In DtDatosBase.Select("id_medio=" & Id_medio & " and id_tsoporte=" & idTipoSoporte)
                DtResultado.ImportRow(DrResultado)
            Next
            If idTipoSoporte = -1 Then

            ElseIf idTipoSoporte > -1 Then
                DtDatosBase.Clear()
                DtDatosBase = DtResultado
            End If
            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Return DtDatosBase

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ObtenerConveniosExportar(ByVal Vigencia As Integer, ByVal idTipoSoporte As Integer, ByVal IdProducto As Integer) As DataTable

        'AG 05/11/2010 Exportacion de Convenios ------------------------------------------------------------------------------------------------------------------
        Try
            Dim DtDatosBase As DataTable
            Dim OGAdmin As New GrillAdmin
            Dim dt As New DataTable
            Dim DtTodos As New DataTable

            If Id_cliente = -2 And IdProducto = -1 Then
                For Each DrCliente As DataRow In Activo.DTClientesCache.Rows
                    DtTodos = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_EXPORT", Int(DrCliente("id_cliente").ToString), _
                        Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia, Activo.PerfilConvenios).Tables(0) 'AG 29/04/2013 ============
                    If DtTodos.Rows.Count > 0 Then
                        If dt.Rows.Count = 0 Then
                            dt = DtTodos.Clone
                        End If
                    End If
                    For Each DrTodosConvenios As DataRow In DtTodos.Rows
                        dt.ImportRow(DrTodosConvenios)
                    Next
                    DtTodos = Nothing
                Next
            Else
                dt = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_EXPORT", Id_cliente, _
                    Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia, Activo.PerfilConvenios).Tables(0) 'AG 29/04/2013 ============
            End If

            With OGAdmin
                DtDatosBase = .CargarDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheTipoSoportes, "TIPO_SOPORTE"), Activo.CachesMMS.CacheClientes, "Cliente")
            End With

            Dim Rows() As DataRow
            Dim i As Integer
            For Each r As DataRow In DtDatosBase.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("cod_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r("Tipo_Soporte") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
                Next
            Next

            For Each r As DataRow In DtDatosBase.Rows
                If r("id_producto") = 0 Then
                    r("Producto") = "Todos"
                Else
                    DtDatosBase = OGAdmin.CargarDTMMS(DtDatosBase, Activo.CachesMMS.CacheProductos, "Producto")
                End If
            Next


            'Elimino las columnas que no se necesitan --------------------------------------------
            DtDatosBase.Columns.Remove("id_producto")
            DtDatosBase.AcceptChanges()
            '-------------------------------------------------------------------------------------------------
            Return DtDatosBase

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function VerExtras(ByVal id_usuario As Integer) As Boolean

        If Me.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIOS_EXTRA", id_usuario).Tables(0).Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function ObtenerExtra(ByVal Id_Usuario As Integer) As DataSet
        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIOS_EXTRA", Id_Usuario)
    End Function

    Public Function ObtenerNoVigentes() As DataTable

        Return MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_NOVIG", Id_cliente, Id_medio, Id_soporte).Tables(0)

    End Function

    Public Function ObtenerClienteVigentes() As DataTable

        Return MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_AR_CONVENIO_NOVIG", Id_cliente, Id_medio, Id_soporte).Tables(0)

    End Function

    'AG CCPR 
    Public Function ObtenerCPRCargado(ByVal IdCampaña As Integer, ByVal IdSistema As Integer, ByVal IdEjercicio As Integer, ByVal IdCliente As Integer) As DataTable
        Return Me.TraerDataSet("SPK_AR_CONVENIOS.SP_OBTENER_CPR_CARGADO", IdCampaña, IdSistema, IdEjercicio, IdCliente).Tables(0)
    End Function

    Public Function ObtenerLogConvenios(ByVal id_convenio As Integer) As DataTable

        Dim Dt As DataTable

        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS. SP_AR_LOG_CONVENIO", id_convenio).Tables(0)

        If Dt.Rows.Count > 0 Then
            Dt = AnexarDescripcionSoporteMMS(Dt, "SOPORTE")
            Dt = AnexarDescripcionClienteMMS(Dt, "CLIENTE")
            Dt = AnexarDescripcionProductosMMS(Dt, "PRODUCTO")
            Dt = AnexarDescripcionMedioMMS(Dt, "MEDIO")
        End If

        Dt.Columns.Remove("ID_SOPORTE")

        Return Dt

    End Function

    Public Function ObtenerEstadosConvenios() As DataTable
        Return MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_CONVENIO_ESTADOS").Tables(0)
    End Function

    Public Function ObtenerUsuariosAutorizado(ByVal CodCompaniaActual As Integer) As DataTable
        Return MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_USUARIOS_AUTORIZADOS", CodCompaniaActual).Tables(0)
    End Function

    Public Function ObtenerLinkConvenio(ByVal TipoConvenio As String) As String

        Dim DtResultado As DataTable
        Dim ResultadoLink As String

        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_LINK_CONVENIO", TipoConvenio).Tables(0)

        If DtResultado.Rows.Count > 0 Then
            ResultadoLink = DtResultado.Rows(0)("LINK").ToString()
        End If

        Return ResultadoLink

    End Function

    Public Function ObtenerUltimoConvenio(ByVal CodCliente As Integer, ByVal CodMedio As Integer, ByVal CodSoporte As Integer) As String

        Dim DtResultado As DataTable
        Dim UltimoCodigoConvenio As String

        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_ULTIMO_CODCONVENIO", CodCliente, CodMedio, CodSoporte).Tables(0)


        If DtResultado.Rows.Count > 0 Then
            UltimoCodigoConvenio = CStr(DtResultado.Rows(0)("COD_CONVENIO").ToString)
        Else
            UltimoCodigoConvenio = ""
        End If

        Return UltimoCodigoConvenio

    End Function

    Public Function ObtenerConveniosPendientes(ByVal Vigencia As Integer, ByVal idTipoSoporte As Integer, ByVal IdProducto As Integer) As DataTable

        Dim DtDatosBase As DataTable
        Dim OGAdmin As New GrillAdmin
        Dim dt As New DataTable
        Dim DtTodos As New DataTable

        Try

            If Id_cliente = -2 And IdProducto = -1 Then
                For Each DrCliente As DataRow In Activo.DTClientesCache.Rows
                    DtTodos = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_CONVENIO_PENDIENTES", Int(DrCliente("id_cliente").ToString), _
                                                 Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia).Tables(0)
                    If DtTodos.Rows.Count > 0 Then
                        If dt.Rows.Count = 0 Then
                            dt = DtTodos.Clone
                        End If
                    End If

                    For Each DrTodosConvenios As DataRow In DtTodos.Rows
                        dt.ImportRow(DrTodosConvenios)
                    Next
                    DtTodos = Nothing
                Next
            Else
                dt = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_CONVENIO_PENDIENTES", Id_cliente, _
                                        Id_medio, idTipoSoporte, Id_soporte, IdProducto, Vigencia).Tables(0)
            End If

            With OGAdmin
                DtDatosBase = .CargarDTMMS(.CargarDTMMS(dt, Activo.CachesMMS.CacheTipoSoportes, "TIPO_SOPORTE"), Activo.CachesMMS.CacheClientes, "Cliente")
            End With

            Dim Rows() As DataRow
            Dim i As Integer
            For Each r As DataRow In DtDatosBase.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("cod_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r("Tipo_Soporte") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
                Next
            Next

            For Each r As DataRow In DtDatosBase.Rows
                If r("id_producto") = 0 Then
                    r("Producto") = "Todos"
                Else
                    DtDatosBase = OGAdmin.CargarDTMMS(DtDatosBase, Activo.CachesMMS.CacheProductos, "Producto")
                End If
            Next

            'AG 07/09/2011 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Dim TipoSoporte() As DataRow
            Dim j As Integer
            TipoSoporte = Activo.DTSoportesCache.Select("cod_tipo_soporte=" & idTipoSoporte & " and " & "id_medio=" & Id_medio) '" and " & "cod_tipo_soporte=" & idTipoSoporte)
            DtDatosBase.Columns.Add("id_tsoporte", GetType(Integer))

            For Each e As DataRow In DtDatosBase.Rows
                For i = 0 To TipoSoporte.Length - 1
                    If TipoSoporte(i).Item("cod_tipo_soporte") = idTipoSoporte And TipoSoporte(i).Item("Id_medio") = e("id_medio") And TipoSoporte(i).Item("Id_soporte") = e("cod_soporte") Then
                        e("id_tsoporte") = TipoSoporte(i).Item("cod_tipo_soporte").ToString
                    End If
                Next
            Next

            Dim DtResultado As DataTable = DtDatosBase.Clone
            Dim DrResultado As DataRow

            For Each DrResultado In DtDatosBase.Select("id_medio=" & Id_medio & " and id_tsoporte=" & idTipoSoporte)
                DtResultado.ImportRow(DrResultado)
            Next
            If idTipoSoporte = -1 Then

            ElseIf idTipoSoporte > -1 Then
                DtDatosBase.Clear()
                DtDatosBase = DtResultado
            End If

            Return DtDatosBase

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

#Region "Procesos Anexos Descripcion Maestros MMS"

    Private Function AnexarSoporteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else

            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.AcceptChanges()

            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos
    End Function

    Private Function AnexarClienteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Then 'Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else
            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.AcceptChanges()

            'Agrego los Clientes del MMS ----------------------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTClientesCache.Select("ID_CLIENTE=" & r("id_cliente"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next

            'Agrego el Cliente 3 Generico de Convenios ---------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                If r("ID_CLIENTE") = 3 Then
                    r(NombreColumna) = "Cliente Genérico (CONVENIOS)"
                End If
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos

    End Function

    Private Function AnexarProductosMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Then 'Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else
            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.AcceptChanges()

            'Agrego la Descripcion del los productos MMS --------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("id_producto"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next

            'Agrego la Descripcion de´l producto Generico 0 ------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                If r("ID_PRODUCTO") = 0 Then
                    r(NombreColumna) = "Genérico"
                End If
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos
    End Function


    Private Function AnexarDescripcionSoporteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else


            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos
    End Function

    Private Function AnexarDescripcionClienteMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Then 'Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else
            'Agrego los Clientes del MMS ----------------------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTClientesCache.Select("ID_CLIENTE=" & r("id_cliente"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next

            'Agrego el Cliente 3 Generico de Convenios ---------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                If r("ID_CLIENTE") = 3 Then
                    r(NombreColumna) = "Cliente Genérico (CONVENIOS)"
                End If
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos

    End Function

    Private Function AnexarDescripcionProductosMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Then 'Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else

            'Agrego la Descripcion del los productos MMS --------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("id_producto"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next

            'Agrego la Descripcion de´l producto Generico 0 ------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                If r("ID_PRODUCTO") = 0 Then
                    r(NombreColumna) = "Genérico"
                End If
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos
    End Function


    Private Function AnexarDescripcionMedioMMS(ByVal DtBaseDatos As DataTable, ByVal NombreColumna As String) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        If DtBaseDatos Is Nothing Then 'Or DtBaseDatos.Rows.Count = 0 Then
            Exit Function
        Else
            'Agrego los Clientes del MMS ----------------------------------------------
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTMediosCache.Select("ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
            DtBaseDatos.AcceptChanges()
        End If
        Return DtBaseDatos

    End Function


#End Region

#End Region

    Public Function ObtenerReporteConveniosWeb(ByVal id_cliente As Integer, ByVal id_medio As Integer, ByVal id_soporte As Integer, ByVal fvigencia As Date, ByVal estado As Integer) As DataTable

        Dim Dt As DataTable


        Dt = Me.TraerDataSet("SPK_AR_CONVENIOS. SP_AR_REPORTE_WEB", id_cliente, id_medio, id_soporte, fvigencia, estado).Tables(0)

        If Dt.Rows.Count > 0 Then
            Dt = AnexarDescripcionSoporteMMS(Dt, "SOPORTE")
            Dt = AnexarDescripcionClienteMMS(Dt, "CLIENTE")
            Dt = AnexarDescripcionProductosMMS(Dt, "PRODUCTO")
            Dt = AnexarDescripcionMedioMMS(Dt, "MEDIO")
        End If


        Return Dt

    End Function

    Public Function ObtenerUsuAutorizadoConvenios(ByVal CodCompania As Integer, ByVal CodUsuario As Integer) As DataTable

        Dim DtResultado As DataTable

        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.VALIDAR_USUAUTORIZADO_CONVENIO", CodCompania, CodUsuario).Tables(0)

        Return DtResultado

    End Function

    Public Function ObtenerConveniosUsuEspecial(ByVal CodCompania As Integer, ByVal CodUsuario As Integer) As DataTable

        Dim DtResultado As DataTable

        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SP_USUARIOS_ESPECIALES", CodCompania, CodUsuario).Tables(0)

        Return DtResultado

    End Function

    Public Sub InsertarEspecial(ByVal cod_compania As Integer, ByVal cod_convenio As Integer, ByVal desc_extra_3 As Single, ByVal cod_usuario As Integer, ByVal Observacion_estra_3 As String)
        Me.Ejecutar("SPK_AR_CONVENIOS.SP_INSERT_ESPECIAL", cod_compania, cod_convenio, desc_extra_3, cod_usuario, Observacion_estra_3)
    End Sub

    Public Function ObtenerConveniosCPR(ByVal Id_Cliente As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime) As DataTable
        Dim DtResultado As DataTable
        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.CONVENIO_CPR_SEGUIMIENTO", Id_Cliente, FechaDesde, FechaHasta).Tables(0)
        Return DtResultado
    End Function

    Public Function ObtenerMailUsuarios(ByVal Id_Usuacio As Integer) As DataTable
        Dim DtResultado As DataTable
        DtResultado = MyBase.TraerDataSet("SPK_AR_CONVENIOS.SELECT_FROM_MAIL", Id_Usuacio).Tables(0)
        Return DtResultado
    End Function

    Public Function ObtenerConvenioxId() As DataTable
        Return MyBase.TraerDataSet("SPK_AR_CONVENIOS. SP_SELECT", Me.Id_medio, Me.Id_soporte, Me.Id_cliente, Me.Id_convenio).Tables(0)
    End Function
End Class























Imports Framework
Public Class Ejercicios
    Inherits Entidad

#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mId_sistema As Int32
    Dim mId_ejercicio As Int32
    Dim mDescripcion As String
    Dim mId_ejercicio_est As Int16
    Dim mObservacion As String
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mIDTipoEjercicio As Integer

    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
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

    Public Property Id_ejercicio() As Int32
        Get
            Return mId_ejercicio
        End Get
        Set(ByVal Value As Int32)
            mId_ejercicio = Value
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

    Public Property Id_ejercicio_est() As Int16
        Get
            Return mId_ejercicio_est
        End Get
        Set(ByVal Value As Int16)
            mId_ejercicio_est = Value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return mObservacion
        End Get
        Set(ByVal Value As String)
            mObservacion = Value
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

    Public Property IDTipoEjercicio() As Int32
        Get
            Return mIDTipoEjercicio
        End Get
        Set(ByVal Value As Int32)
            mIDTipoEjercicio = Value
        End Set
    End Property

#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Ejercicios")
    End Sub

    Public Overloads Function Agregar() As Object
        'AG 05/06/2014 ================================================================
        Return MyBase.Agregar(Id_campania, Id_sistema, Descripcion, Observacion, F_alta, U_alta, F_modi, U_modi, Me.IDTipoEjercicio)
        '==============================================================================
    End Function

    Public Overloads Function Modificar() As Object
        'AG 05/06/2014 ================================================================
        MyBase.Modificar(Id_campania, Id_sistema, Id_ejercicio, Descripcion, Id_ejercicio_est, Observacion, F_alta, U_alta, F_modi, U_modi, Me.IDTipoEjercicio)
        '==============================================================================
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_campania, Id_sistema, Id_ejercicio)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_campania, Id_sistema, Id_ejercicio)
        Catch ex As DataReaderVacioExcepcion
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.EjercicioInexistente, "Ejercicios.BuscarPorID")
        End Try
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Id_sistema = IIf(IsDBNull(Dr("Id_sistema")), 0, Dr("Id_sistema"))
        Me.Id_ejercicio = IIf(IsDBNull(Dr("Id_ejercicio")), 0, Dr("Id_ejercicio"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_ejercicio_est = IIf(IsDBNull(Dr("Id_ejercicio_est")), 0, Dr("Id_ejercicio_est"))
        Me.Observacion = IIf(IsDBNull(Dr("Observacion")), "", Dr("Observacion"))
        Me.F_alta = IIf(IsDBNull(Dr("F_alta")), Nothing, Dr("F_alta"))
        Me.U_alta = IIf(IsDBNull(Dr("U_alta")), 0, Dr("U_alta"))
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("F_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), 0, Dr("U_modi"))

        'AG 06/06/2014 ====================================================
        Me.IDTipoEjercicio = IIf(IsDBNull(Dr("id_tipo_ejercicio")), 0, Dr("id_tipo_ejercicio"))
        '==================================================================
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
    Public Function ObtenerSoportesSpots() As DataTable
        Dim OAdmin As New GrillAdmin

        Return OAdmin.AnexarSoportesMMS(Me.TraerDataSet("spk_sistemas.sp_filtro_soportes_spots", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio).Tables(0), -1, "Descripcion")

        'AGuzzardi Codigo Original ----------------------------------------------------------------------------------
        'Return Me.TraerDataSet("spk_sistemas.sp_filtro_soportes_spots", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio).Tables(0)
        '------------------------------------------------------------------------------------------------------------
    End Function
    Public Function ObtenerEjerciciosCliente(ByVal idCliente As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdMedio As Integer, ByVal TipoSoporte As Integer) As DataTable
        Return Me.TraerDataSet("spk_ejercicios.sp_ejercicios_cliente", idCliente, FechaInicio, FechaFin, IdMedio, TipoSoporte).Tables(0)
    End Function
    Public Function ObtenerEjerciciosCampaña() As DataTable
        Return Me.TraerDataSet("spk_ejercicios.sp_ejercicios_campania", Me.Id_campania).Tables(0)
    End Function
    Public Function ObtenerEjerciciosSistema() As DataTable
        Return Me.TraerDataSet("spk_ejercicios.sp_ejercicios_sistema", Me.Id_campania, Me.Id_sistema).Tables(0)
    End Function

    Public Sub Duplicar(ByVal New_id_Campania As Long, ByVal New_id_sistema As Long, ByVal Usuario As String, ByVal EsDupdeDup As Boolean)
        Dim antIdSistema As Long
        Dim antidCampania As Long
        Dim antidEjercicio As Long
        Dim newidEjercicio As Long

        Try
            Me.BuscarPorID()
            antidCampania = Me.Id_campania
            antIdSistema = Me.Id_sistema
            antidEjercicio = Me.Id_ejercicio

            Me.Id_campania = New_id_Campania
            Me.Id_sistema = New_id_sistema
            If EsDupdeDup Then
                Me.Descripcion = Me.Descripcion
            Else
                Me.Descripcion = Mid("Duplicado de " & Me.Descripcion, 1, 50)
            End If

            newidEjercicio = Me.Agregar()

            Me.Id_sistema = antIdSistema
            Me.Id_campania = antidCampania

            'AG 07/06/2016 =========================================
            Dim Obj As New Sistemas
            Dim DtMedio As New DataTable

            DtMedio = Obj.ObtenerMedioSistemaDuplicar(antidCampania, antIdSistema)
            If DtMedio.Rows.Count > 0 Then
                If CInt(DtMedio.Rows(0)("ID_MEDIO").ToString()) = Activo.Medios.Internet Then
                    Me.Ejecutar("SPK_DUPLICACION_EJERCICIO.SP_DUPLICA_INTERNET", antidCampania, New_id_Campania, antIdSistema, New_id_sistema, antidEjercicio, newidEjercicio, Usuario)
                Else
                    Me.Ejecutar("SPK_DUPLICACION_EJERCICIO.SP_DUPLICA", antidCampania, New_id_Campania, antIdSistema, New_id_sistema, antidEjercicio, newidEjercicio, Usuario)
                End If
            End If
            '=======================================================
            'AG Anterior ===============================================
            'If Activo.IDMedio = Activo.Medios.Internet Then
            '    Me.Ejecutar("SPK_DUPLICACION_EJERCICIO.SP_DUPLICA_INTERNET", antidCampania, New_id_Campania, antIdSistema, New_id_sistema, antidEjercicio, newidEjercicio, Usuario)
            'Else
            '    Me.Ejecutar("SPK_DUPLICACION_EJERCICIO.SP_DUPLICA", antidCampania, New_id_Campania, antIdSistema, New_id_sistema, antidEjercicio, newidEjercicio, Usuario)
            'End If
            '==============================================================
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub BorrarSpotsTodos()
        Me.Ejecutar("SPK_SPOTS.SP_DELETE_ALL", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio)
        Me.Borrar()
    End Sub

    'Public Sub BorrarSpots(ByVal usuario As String)
    '    Dim s As New Spots
    '    Dim sd As New Spots_detalle
    '    Dim dtS As DataTable
    '    Dim dtSD As DataTable

    '    Dim camp As New Campaña
    '    Dim Sist As New Sistemas
    '    Dim Ejer As New Ejercicios


    '    camp.ID_Campania = Me.Id_campania
    '    camp.BuscarPorID()

    '    Sist.Id_campania = Me.Id_campania
    '    Sist.Id_sistema = Me.Id_sistema
    '    Sist.BuscarPorID()

    '    ' Borro los spots detalle
    '    dtSD = sd.ObtenerSpotDetalle(Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio)
    '    For Each rsd As DataRow In dtSD.Rows
    '        Me.Ejecutar("SPK_SPOTS_DETALLE.SP_DELETE", rsd("id_spot"), rsd("id_spot_detalle"), rsd("f_spot"), rsd("id_tema"), rsd("duracion"), usuario, Now.ToShortDateString)
    '    Next

    '    ' Borro los spots.
    '    s.Id_campania = Me.Id_campania
    '    s.Id_sistema = Me.Id_sistema
    '    s.Id_ejercicio = Me.Id_ejercicio
    '    dtS = s.ObtenerSpots
    '    For Each rs As DataRow In dtS.Rows
    '        Me.Ejecutar("SPK_SPOTS.SP_DELETE", rs("id_spot"), Me.Id_campania, Me.Id_sistema, _
    '        Me.Id_ejercicio, rs("PROGRAMA"), rs("h_inicio"), rs("m_inicio"), rs("h_fin"), _
    '        rs("m_fin"), rs("bruto"), rs("dcto1"), rs("dcto2"), rs("dcto3"), rs("dcto4"), _
    '        rs("dcto5"), rs("rat_prog_target_1"), rs("rat_prog_target_2"), usuario, _
    '        Now.ToShortDateString, camp.Descripcion, Sist.Descripcion, Me.Descripcion)
    '    Next

    '    Me.Borrar()

    'End Sub

    Public Function HayEnviadosaCompras() As Integer
        Return Me.Ejecutar("SPK_EJERCICIOS.SP_CONTROL_DELETE", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio)
    End Function
    Public Function ObtenerEjerciciosImportar(ByVal idCampaña As Integer, ByVal idSistema As Integer, ByVal idEjercicio As Integer, ByVal Finicio As Date, ByVal Ffin As Date, ByVal temas As String) As DataTable
        Return Me.TraerDataSet("SPK_DUPLICACION_EJERCICIO.SP_IMPORTA_FILTRO_SPOTS", idCampaña, idSistema, idEjercicio, temas, Finicio, Ffin).Tables(0)
    End Function

    Public Sub ActualziarEstadoEjercicioTarifas(ByVal id_Campaña As Integer, ByVal id_sistema As Integer, ByVal id_ejercicio As Integer, ByVal id_estado_ejercicio As Integer)
        Me.Ejecutar("SPK_EJERCICIOS.SP_UPDATE_ESTADO_TARIFA", id_Campaña, id_sistema, id_ejercicio, id_estado_ejercicio)
    End Sub

#End Region

End Class


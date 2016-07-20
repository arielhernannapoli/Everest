Public Class Sistemas
    Inherits Entidad
    Implements IDisposable

#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mId_sistema As Int32
    Dim mDescripcion As String
    Dim mF_inicio As DateTime
    Dim mF_fin As DateTime
    Dim mF_inicio_aud As DateTime
    Dim mF_fin_aud As DateTime
    Dim mF_vigor As DateTime
    Dim mId_medio As Int16
    Dim mId_tipo_soporte As Int32
    Dim mDeflactacion As Single
    Dim mTipo_rating As String
    Dim mBrf_neto As Double
    Dim mBrf_bruto As Double
    Dim mBrf_grp1 As Double
    Dim mBrf_grp2 As Double
    Dim mBrf_grp3 As Double
    Dim mVar1_texto As String
    Dim mVar1_valor As Double
    Dim mVar2_texto As String
    Dim mVar2_valor As Double
    Dim mVar3_texto As String
    Dim mVar3_valor As Double
    Dim mVar4_texto As String
    Dim mVar4_valor As Double
    Dim mId_target_1 As Int32
    Dim mId_target_2 As Int32
    Dim mId_date_part As Int32
    Dim mId_sistema_est As Int16
    Dim mId_ejercicio_final As Int32
    Dim mF_alta As DateTime
    Dim mU_alta As String
    Dim mF_modi As DateTime
    Dim mU_modi As String
    Dim mID_Plaza As Integer

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

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
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

    Public Property F_inicio_aud() As DateTime
        Get
            Return mF_inicio_aud
        End Get
        Set(ByVal Value As DateTime)
            mF_inicio_aud = Value
        End Set
    End Property

    Public Property F_fin_aud() As DateTime
        Get
            Return mF_fin_aud
        End Get
        Set(ByVal Value As DateTime)
            mF_fin_aud = Value
        End Set
    End Property

    Public Property F_Vigencia_Opcional() As DateTime
        Get
            Return mF_vigor
        End Get
        Set(ByVal Value As DateTime)
            mF_vigor = Value
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

    Public Property Deflactacion() As Single
        Get
            Return mDeflactacion
        End Get
        Set(ByVal Value As Single)
            mDeflactacion = Value
        End Set
    End Property

    Public Property Tipo_rating() As String
        Get
            Return mTipo_rating
        End Get
        Set(ByVal Value As String)
            mTipo_rating = Value
        End Set
    End Property

    Public Property Brf_neto() As Double
        Get
            Return mBrf_neto
        End Get
        Set(ByVal Value As Double)
            mBrf_neto = Value
        End Set
    End Property

    Public Property Brf_bruto() As Double
        Get
            Return mBrf_bruto
        End Get
        Set(ByVal Value As Double)
            mBrf_bruto = Value
        End Set
    End Property

    Public Property Brf_grp1() As Double
        Get
            Return mBrf_grp1
        End Get
        Set(ByVal Value As Double)
            mBrf_grp1 = Value
        End Set
    End Property

    Public Property Brf_grp2() As Double
        Get
            Return mBrf_grp2
        End Get
        Set(ByVal Value As Double)
            mBrf_grp2 = Value
        End Set
    End Property

    Public Property Brf_grp3() As Double
        Get
            Return mBrf_grp3
        End Get
        Set(ByVal Value As Double)
            mBrf_grp3 = Value
        End Set
    End Property

    Public Property Var1_texto() As String
        Get
            Return mVar1_texto
        End Get
        Set(ByVal Value As String)
            mVar1_texto = Value
        End Set
    End Property

    Public Property Var1_valor() As Double
        Get
            Return mVar1_valor
        End Get
        Set(ByVal Value As Double)
            mVar1_valor = Value
        End Set
    End Property

    Public Property Var2_texto() As String
        Get
            Return mVar2_texto
        End Get
        Set(ByVal Value As String)
            mVar2_texto = Value
        End Set
    End Property

    Public Property Var2_valor() As Double
        Get
            Return mVar2_valor
        End Get
        Set(ByVal Value As Double)
            mVar2_valor = Value
        End Set
    End Property

    Public Property Var3_texto() As String
        Get
            Return mVar3_texto
        End Get
        Set(ByVal Value As String)
            mVar3_texto = Value
        End Set
    End Property

    Public Property Var3_valor() As Double
        Get
            Return mVar3_valor
        End Get
        Set(ByVal Value As Double)
            mVar3_valor = Value
        End Set
    End Property

    Public Property Var4_texto() As String
        Get
            Return mVar4_texto
        End Get
        Set(ByVal Value As String)
            mVar4_texto = Value
        End Set
    End Property

    Public Property Var4_valor() As Double
        Get
            Return mVar4_valor
        End Get
        Set(ByVal Value As Double)
            mVar4_valor = Value
        End Set
    End Property

    Public Property Id_target_1() As Int32
        Get
            Return mId_target_1
        End Get
        Set(ByVal Value As Int32)
            mId_target_1 = Value
        End Set
    End Property

    Public Property Id_target_2() As Int32
        Get
            Return mId_target_2
        End Get
        Set(ByVal Value As Int32)
            mId_target_2 = Value
        End Set
    End Property

    Public Property Id_date_part() As Int32
        Get
            Return mId_date_part
        End Get
        Set(ByVal Value As Int32)
            mId_date_part = Value
        End Set
    End Property

    Public Property Id_sistema_est() As Int16
        Get
            Return mId_sistema_est
        End Get
        Set(ByVal Value As Int16)
            mId_sistema_est = Value
        End Set
    End Property

    Public Property Id_ejercicio_final() As Int32
        Get
            Return mId_ejercicio_final
        End Get
        Set(ByVal Value As Int32)
            mId_ejercicio_final = Value
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

    Public Property ID_Plaza() As Integer
        Get
            Return mID_Plaza
        End Get
        Set(ByVal Value As Integer)
            mID_Plaza = Value
        End Set
    End Property

#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Sistemas")
    End Sub

    Public Overloads Function Agregar() As Object
        'busca el nuevo codigo de campaña

        'AG 22/10/2013 DIGITAL ========================
        If Id_medio = 2 Then
            Id_tipo_soporte = -1
        End If
        '==============================================

        Return MyBase.Agregar(Id_campania, Descripcion, F_inicio, _
        F_fin, F_inicio_aud, F_fin_aud, F_Vigencia_Opcional, Id_medio, Id_tipo_soporte _
        , Deflactacion, Tipo_rating, Brf_neto, Brf_bruto, _
        Brf_grp1, Brf_grp2, Brf_grp3, Var1_texto, Var1_valor, _
        Var2_texto, Var2_valor, Var3_texto, Var3_valor, Var4_texto, _
        Var4_valor, Id_target_1, Id_target_2, Id_date_part, Id_sistema_est, _
        Id_ejercicio_final, F_alta, U_alta, F_modi, U_modi, ID_Plaza)
    End Function

    Public Overloads Function Modificar() As Object

        'AG 22/10/2013 DIGITAL ========================
        If Id_medio = 2 Then
            Id_tipo_soporte = -1
        End If
        '==============================================
        Return MyBase.Modificar(Id_campania, Id_sistema, Descripcion, F_inicio, _
        F_fin, F_inicio_aud, F_fin_aud, F_Vigencia_Opcional, Id_medio, Id_tipo_soporte, _
        Deflactacion, Tipo_rating, Brf_neto, Brf_bruto, _
        Brf_grp1, Brf_grp2, Brf_grp3, Var1_texto, Var1_valor, _
        Var2_texto, Var2_valor, Var3_texto, Var3_valor, Var4_texto, _
        Var4_valor, Id_target_1, Id_target_2, Id_date_part, Id_sistema_est, _
        Id_ejercicio_final, F_alta, U_alta, F_modi, U_modi, ID_Plaza)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_campania, Id_sistema)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        Try
            MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Me.Id_campania, Me.Id_sistema)
        Catch ex As DataReaderVacioExcepcion
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.SistemaInexistente, "Sistemas.BuscarPorID")
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
        Me.ID_Plaza = IIf(IsDBNull(Dr("id_plaza")), 0, Dr("id_plaza"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.F_inicio = IIf(IsDBNull(Dr("F_inicio")), Nothing, Dr("F_inicio"))
        Me.F_fin = IIf(IsDBNull(Dr("F_fin")), Nothing, Dr("F_fin"))
        Me.F_inicio_aud = IIf(IsDBNull(Dr("F_inicio_aud")), Nothing, Dr("F_inicio_aud"))
        Me.F_fin_aud = IIf(IsDBNull(Dr("F_fin_aud")), Nothing, Dr("F_fin_aud"))
        Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_tipo_soporte = IIf(IsDBNull(Dr("Id_tipo_soporte")), 0, Dr("Id_tipo_soporte"))
        Me.Deflactacion = IIf(IsDBNull(Dr("Deflactacion")), 0, Dr("Deflactacion"))
        Me.Tipo_rating = IIf(IsDBNull(Dr("Tipo_rating")), "", Dr("Tipo_rating"))
        Me.Brf_neto = IIf(IsDBNull(Dr("Brf_neto")), 0, Dr("Brf_neto"))
        Me.Brf_bruto = IIf(IsDBNull(Dr("Brf_bruto")), 0, Dr("Brf_bruto"))
        Me.Brf_grp1 = IIf(IsDBNull(Dr("Brf_grp1")), 0, Dr("Brf_grp1"))
        Me.Brf_grp2 = IIf(IsDBNull(Dr("Brf_grp2")), 0, Dr("Brf_grp2"))
        Me.Brf_grp3 = IIf(IsDBNull(Dr("Brf_grp3")), 0, Dr("Brf_grp3"))
        Me.Var1_texto = IIf(IsDBNull(Dr("Var1_texto")), "", Dr("Var1_texto"))
        Me.Var1_valor = IIf(IsDBNull(Dr("Var1_valor")), 0, Dr("Var1_valor"))
        Me.Var2_texto = IIf(IsDBNull(Dr("Var2_texto")), "", Dr("Var2_texto"))
        Me.Var2_valor = IIf(IsDBNull(Dr("Var2_valor")), 0, Dr("Var2_valor"))
        Me.Var3_texto = IIf(IsDBNull(Dr("Var3_texto")), "", Dr("Var3_texto"))
        Me.Var3_valor = IIf(IsDBNull(Dr("Var3_valor")), 0, Dr("Var3_valor"))
        Me.Var4_texto = IIf(IsDBNull(Dr("Var4_texto")), "", Dr("Var4_texto"))
        Me.Var4_valor = IIf(IsDBNull(Dr("Var4_valor")), 0, Dr("Var4_valor"))
        Me.Id_target_1 = IIf(IsDBNull(Dr("Id_target_1")), 0, Dr("Id_target_1"))
        Me.Id_target_2 = IIf(IsDBNull(Dr("Id_target_2")), 0, Dr("Id_target_2"))
        Me.Id_date_part = IIf(IsDBNull(Dr("Id_date_part")), 0, Dr("Id_date_part"))
        Me.Id_ejercicio_final = IIf(IsDBNull(Dr("Id_ejercicio_final")), 0, Dr("Id_ejercicio_final"))
        Me.F_alta = IIf(IsDBNull(Dr("F_alta")), Nothing, Dr("F_alta"))
        Me.U_alta = IIf(IsDBNull(Dr("U_alta")), "", Dr("U_alta"))
        Me.F_modi = IIf(IsDBNull(Dr("F_modi")), Nothing, Dr("F_modi"))
        Me.U_modi = IIf(IsDBNull(Dr("U_modi")), "", Dr("U_modi"))

        Me.F_Vigencia_Opcional = IIf(IsDBNull(Dr("f_vigencia_opcional")), "01/01/0001", Dr("f_vigencia_opcional"))
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

    Public Function ObtenerMedioSistemaDuplicar(ByVal Idcampania As Integer, ByVal Idsistema As Integer) As DataTable
        Return Me.TraerDataSet("spk_sistemas.SP_OBTENER_MEDIO", Idcampania, Idsistema).Tables(0)
    End Function

    Public Function ObtenermedioAlternativa() As DataTable
        Return Me.TraerDataSet("spk_sistemas.SP_SELECT_SIST_EJERCICIO", Me.Id_campania, Me.Id_sistema, Me.Id_ejercicio_final).Tables(0)
    End Function

    Public Function ObtenerSistemasEjercicio() As DataTable
        Return Me.TraerDataSet("spk_sistemas.sp_sistemas_ejercicios", Me.Id_campania).Tables(0)
    End Function

    Public Function ObtenerSistemas() As DataTable
        Return Me.TraerDataSet("SPK_SISTEMAS.SP_SELECT_ALL", Me.Id_campania).Tables(0)
    End Function

    Public Function ObtenerSistemaEjercicioActivoSoportes() As DataTable
        Return Me.TraerDataSet("", Me.Id_campania).Tables(0)
    End Function

    Public Function VerificarSpotFueraRango() As Boolean
        Dim dt As DataTable

        dt = Me.TraerDataSet("spk_sistemas.sp_select_spot_fuera_rango", Me.Id_campania, Me.Id_sistema, Me.F_inicio, Me.F_fin).Tables(0)

        VerificarSpotFueraRango = (dt.Rows(0).Item(0) = 0)
    End Function

    Public Sub BorrarSpotFueraRango()
        Me.Ejecutar("SPK_SISTEMAS.sp_delete_spot_fuera_rango", Me.Id_campania, Me.Id_sistema, Me.F_inicio, Me.F_fin)
    End Sub

    Public Function VerificarSpotECFueraRango() As Boolean
        Dim dt As DataTable

        dt = Me.TraerDataSet("spk_sistemas.sp_select_spotEC_fuera_rango", Me.Id_campania, Me.Id_sistema, Me.F_inicio, Me.F_fin).Tables(0)

        VerificarSpotECFueraRango = (dt.Rows(0).Item(0) = 0)
    End Function

    Public Function Duplicar(ByVal New_Id_Campania As Long, ByVal esDupdeDup As Boolean) As Long
        Dim TipoSistema As Integer
        Me.BuscarPorID()

        If esDupdeDup Then
            Me.Descripcion = Me.Descripcion
        Else
            Me.Descripcion = Mid("Duplicado de " & Me.Descripcion, 1, 50)
        End If
        If Me.Id_ejercicio_final = 0 Then ' costo punto o estandar
            Me.Id_ejercicio_final = 0
        Else
            Me.Id_ejercicio_final = 1
        End If
        Me.Id_campania = New_Id_Campania
        Duplicar = Me.Agregar()
    End Function

    Public Function ObtenerSistemasFechas() As DataTable
        Return Me.TraerDataSet("SPK_SISTEMAS.SP_SELECT_FECHAS", Me.Id_campania, Me.Id_sistema).Tables(0)
    End Function

    'AG CP ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Function ObtenerTipoEjercicio(ByVal IdCampania As Integer, ByVal IdSistema As Integer) As Long

        Dim TipoEjercicio As Long
        Dim Dt As New DataTable
        Dim Dr As DataRow

        Dt = Me.TraerDataSet("SPK_SISTEMAS.SP_TIPO_EJERCICIO", IdCampania, IdSistema).Tables(0)

        For Each Dr In Dt.Rows
            TipoEjercicio = Dr("tejercicio")
        Next

        Return TipoEjercicio

    End Function
    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

#End Region

    Public Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class


Imports Framework
Public Class Soportes_Interior
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Medio As Int16
    Dim mId_Soporte As Int16
    Dim mDescripcion As String
    Dim mId_Cadena As String
    Dim mId_Tipo_Soporte As Int16
    Dim mId_Plaza As Int32
    Dim mCob_Cad As Int16
    Dim mVem_Cob As Int64

    Public Property Id_Medio() As Int16
        Get
            Return mId_Medio
        End Get
        Set(ByVal Value As Int16)
            mId_Medio = Value
        End Set
    End Property

    Public Property Id_Soporte() As Int16
        Get
            Return mId_Soporte
        End Get
        Set(ByVal Value As Int16)
            mId_Soporte = Value
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

    Public Property Id_Cadena() As String
        Get
            Return mId_Cadena
        End Get
        Set(ByVal Value As String)
            mId_Cadena = Value
        End Set
    End Property

    Public Property Id_Tipo_Soporte() As Int16
        Get
            Return mId_Tipo_Soporte
        End Get
        Set(ByVal Value As Int16)
            mId_Tipo_Soporte = Value
        End Set
    End Property

    Public Property Id_Plaza() As Int32
        Get
            Return mId_Plaza
        End Get
        Set(ByVal Value As Int32)
            mId_Plaza = Value
        End Set
    End Property

    Public Property Cob_Cad() As Int16
        Get
            Return mCob_Cad
        End Get
        Set(ByVal Value As Int16)
            mCob_Cad = Value
        End Set
    End Property

    Public Property Vem_Cob() As Int64
        Get
            Return mVem_Cob
        End Get
        Set(ByVal Value As Int64)
            mVem_Cob = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Soportes_Interior")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_Medio, Id_Soporte, Descripcion, Id_Cadena, Id_Tipo_Soporte, Id_Plaza, Cob_Cad, Vem_Cob)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_Medio, Id_Soporte, Descripcion, Id_Cadena, Id_Tipo_Soporte, Id_Plaza, Cob_Cad, Vem_Cob)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_Medio)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_Medio)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_Medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
        Me.Id_Soporte = IIf(IsDBNull(Dr("Id_soporte")), 0, Dr("Id_soporte"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_Cadena = IIf(IsDBNull(Dr("Id_cadena")), "", Dr("Id_cadena"))
        Me.Id_Tipo_Soporte = IIf(IsDBNull(Dr("Id_tipo_soporte")), 0, Dr("Id_tipo_soporte"))
        Me.Id_Plaza = IIf(IsDBNull(Dr("Id_plaza")), 0, Dr("Id_plaza"))
        Me.Cob_Cad = IIf(IsDBNull(Dr("Cob_cad")), 0, Dr("Cob_cad"))
        Me.Vem_Cob = IIf(IsDBNull(Dr("Vem_cob")), 0, Dr("Vem_cob"))
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
    Public Function BuscarPorID_Soporte()

        'AGuzzardi 08/06/2010 -------------------------
        CargarPorID_Soporte(Id_Soporte)
        '-------------------------------------------------------
        'Codigo Aneterio -------------------------------------------------------------------------------------
        'MyBase.TraerUno("SPK_ACCESO_VISTAS.SP_SOPORTES_INTERIOR_ID", Id_Soporte)
        '----------------------------------------------------------------------------------------------------------
    End Function

    Public Function TraerCodTom() As String
        Try
            TraerCodTom = MyBase.Ejecutar("SPK_ACCESO_VISTAS.SP_SOPORTES_TOM", Id_Soporte)
        Catch ex As DataReaderVacioExcepcion
            TraerCodTom = ""
        End Try

    End Function

    Private Sub CargarPorID_Soporte(ByVal Id_Soporte As Integer)

        Dim Rows() As DataRow
        Dim i As Integer
        Dim Length As Integer
        Dim dtSop_int As DataTable
        Rows = Activo.DTSoportesCache.Select("ID_MEDIO=" & 1 & " and " & "cod_tipo_soporte=" & 2 & " and " & "id_soporte=" & Id_Soporte)

        dtSop_int = TraerDataSet("SPK_ACCESO_VISTAS.SP_SOPORTES_INTERIOR_ID", Id_Soporte).Tables(0)

        For i = 0 To Rows.Length - 1
            Me.Id_Medio = 1
            Me.Id_Soporte = Id_Soporte
            Me.Descripcion = Rows(0).Item("DESCRIPCION").ToString()
            Me.Id_Cadena = Rows(0).Item("ID_CADENA").ToString()
            Me.Id_Tipo_Soporte = Rows(0).Item("COD_TIPO_SOPORTE").ToString()
            Me.Id_Plaza = Rows(0).Item("COD_COBERTURA").ToString()
            Me.Cob_Cad = dtSop_int.Rows(0).Item("COB_CAD")
            Me.Vem_Cob = dtSop_int.Rows(0).Item("VEM_COB")
        Next


    End Sub

#End Region

End Class

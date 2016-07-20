Imports MSL
Imports Framework
Public Class Clientes
    Inherits Entidad

#Region "Propiedades"
    Dim mId_cliente As Decimal
    Dim mDescripcion As String
    Dim mId_grupo As Decimal
    Dim mId_impuesto As Decimal
    Dim mId_empresa As Decimal
    Dim mId_grupo_planificacion As String
    Dim mServicio_agencia As Decimal

    Public Property Id_cliente() As Decimal
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Decimal)
            mId_cliente = Value
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

    Public Property Id_grupo() As Decimal
        Get
            Return mId_grupo
        End Get
        Set(ByVal Value As Decimal)
            mId_grupo = Value
        End Set
    End Property

    Public Property Id_impuesto() As Decimal
        Get
            Return mId_impuesto
        End Get
        Set(ByVal Value As Decimal)
            mId_impuesto = Value
        End Set
    End Property

    Public Property Id_empresa() As Decimal
        Get
            Return mId_empresa
        End Get
        Set(ByVal Value As Decimal)
            mId_empresa = Value
        End Set
    End Property

    Public Property Id_grupo_planificacion() As String
        Get
            Return mId_grupo_planificacion
        End Get
        Set(ByVal Value As String)
            mId_grupo_planificacion = Value
        End Set
    End Property

    Public Property Servicio_agencia() As Decimal
        Get
            Return mServicio_agencia
        End Get
        Set(ByVal Value As Decimal)
            mServicio_agencia = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Clientes")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_cliente, Descripcion, Id_grupo, Id_impuesto, Id_empresa, Id_grupo_planificacion, Servicio_agencia)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_cliente, Descripcion, Id_grupo, Id_impuesto, Id_empresa, Id_grupo_planificacion, Servicio_agencia)
    End Function

    Public Overloads Function Borrar() As Object
        MyBase.Borrar(Id_cliente)
    End Function
    'Public Overloads Function TraerTodos() As DataTable
    '    Return MyBase.TraerTodos()
    'End Function

    'Public Overloads Sub BuscarPorID()
    '    MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_cliente)
    'End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        Me.Id_grupo = IIf(IsDBNull(Dr("Id_grupo")), 0, Dr("Id_grupo"))
        Me.Id_impuesto = IIf(IsDBNull(Dr("Id_impuesto")), 0, Dr("Id_impuesto"))
        Me.Id_empresa = IIf(IsDBNull(Dr("Id_empresa")), 0, Dr("Id_empresa"))
        Me.Id_grupo_planificacion = IIf(IsDBNull(Dr("Id_grupo_planificacion")), "", Dr("Id_grupo_planificacion"))
        Me.Servicio_agencia = IIf(IsDBNull(Dr("Servicio_agencia")), 0, Dr("Servicio_agencia"))
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
    Public Function BuscarPorIDSAG() As String
        Dim oCliente As New Maestros
        Me.Servicio_agencia = CDbl(oCliente.ObtenerMedioPagosCliente(Constantes.COD_PAIS_ARGENTINA, Activo.CodCampaniaActualMms, Activo.IDCliente, Activo.IDMedio).ToString)
        Try
            'MyBase.TraerUno("spk_acceso_vistas.sp_clientes", id_cliente)
        Catch ex As DataReaderVacioExcepcion
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.ClienteInexistente, "Clientes.BuscarPorID")
        End Try
    End Function

    ''' <summary>
    ''' trae sags del cliente y medio
    ''' </summary>
    ''' <param name="f_inicio"></param>
    ''' <param name="f_fin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function BuscarPorIDSAG(ByVal f_inicio As Date, ByVal f_fin As Date) As DataTable
        Dim dtsag As DataTable
        dtsag = New DataTable
        dtsag.Rows.Add("2", "01/01/2010", "01/05/2010", "NO") ''test dcaime
        dtsag.Rows.Add("2", "01/06/2010", "01/11/2010", "SI")
        dtsag.AcceptChanges()
        Return dtsag
    End Function

    Public Function BuscarImpuesto(ByVal IDCliente As Integer) As DataTable
        Return MyBase.TraerDataSet("spk_acceso_vistas.sp_impuestos", IDCliente).Tables(0)
    End Function
#End Region

    ''DANIEL CAIME
#Region "DATOS MMS"

    ''' <summary>
    ''' obtiene datatable de los clientes a travez de MSL
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function TraerTodos() As DataTable
        Dim oMaestro As Maestros
        Return oMaestro.ClientesTraerTodos(MSL.Constantes.COD_PAIS_ESPANA)
    End Function

    Public Overloads Sub BuscarPorId()
        Dim oCliente As MSL.Maestros = New MSL.Maestros
        Dim dt As DataTable
        Dim DRows() As DataRow

        'AGuzzardi Extraigo la descripcion del cliente del DTCache Cliente -------------------------------------------------------------------------------------------------------
        If Activo.DTClientesCache Is Nothing Then
            dt = oCliente.ClientesTraerporID(Constantes.COD_PAIS_ARGENTINA, CInt(Me.Id_cliente))
            If (dt.Rows.Count > 0) Then
                With Me
                    .Id_cliente = dt.Rows(0).Item("id_cliente")
                    .Descripcion = dt.Rows(0).Item("descripcion")
                End With
            End If
        Else
            DRows = Activo.DTClientesCache.Select("ID_CLIENTE =" & CInt(Id_cliente) & " and " & "ID_PAIS=" & Constantes.COD_PAIS_ARGENTINA)
            If DRows.Length > 0 Then
                With Me
                    .Id_cliente = DRows(0)("id_cliente").ToString
                    .Descripcion = DRows(0)("descripcion").ToString
                End With
            End If
        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Sub

    'Public Function traerDescripcion(ByVal id_cliente As Integer) As String
    '    Dim oMaestro As Maestros
    '    Dim nomCliente As String
    '    Dim dt As DataTable
    '    dt = oMaestro.ClientesTraerporID(Constantes.COD_PAIS_ARGENTINA, id_cliente)
    '    'dt.Rows(0).Item("des"
    '    Return nomCliente
    'End Function

#End Region
End Class


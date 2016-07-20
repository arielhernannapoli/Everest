Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Enum TipoProcedimiento
    Agregar
    Modificar
    Borrar
End Enum

Public MustInherit Class Entidad
    Dim Svr As New OracleDatos
    Dim mTabla As String

    Sub New(ByVal Tabla As String)
        Me.Tabla = Tabla
    End Sub

    'guarda el nombre de la tabla, se usa para armar los nombres de los stores
    Public Property Tabla() As String
        Get
            Return mTabla
        End Get
        Set(ByVal Value As String)
            mTabla = Value
        End Set
    End Property

#Region "Funciones Generales de las Entidades"
    'ejecuta el store y devuelve el valor del 1er parametro
    Protected Overridable Function Agregar(ByVal ParamArray Parametros() As Object) As Object
        Return Svr.Ejecutar("spk_" + Tabla + ".sp_insert", Parametros)
    End Function

    'ejecuta el store y devuelve el valor del 1er parametro
    Protected Overridable Function Modificar(ByVal ParamArray Parametros() As Object) As Object

        Return Svr.Ejecutar("spk_" + Tabla + ".sp_update", Parametros)
    End Function

    'ejecuta el store y devuelve el valor del 1er parametro
    Protected Overridable Function Borrar(ByVal ParamArray Parametros() As Object) As Object
        Return Svr.Ejecutar("spk_" + Tabla + ".sp_delete", Parametros)
    End Function

    'ejecuta un data reader en capa 1, y llama la metodo ArmarObjeto para 
    'llenar las propiedades de las subclases
    Protected Overridable Sub TraerUno(ByVal Store As String, ByVal ParamArray Parametros() As Object)
        Dim Dr As OracleDataReader

        Dr = Me.EjecutarDataReader(Store, Parametros)

        'si es nothing, sale, sino, pregunta si tiene registros, si no tiene, sale
        If Dr Is Nothing OrElse Dr.Read = False Then
            Dr.Close()
            Svr.Desconectar()
            Throw New DataReaderVacioExcepcion("")
        End If

        'esta funcion se debe implementar en las subclases
        ArmarObjeto(Dr)

        'cuando no existe el store el DR es nothing
        If Not Dr Is Nothing Then
            Dr.Close()
            Svr.Desconectar()
        End If
    End Sub

    'ejecuta el store Select All y devuelve un DataSet
    Protected Overridable Function TraerTodos(ByVal ParamArray Parametros() As Object) As DataTable
        Return Svr.TraerDataSet("spk_" & Tabla & ".sp_select_all", Parametros).Tables(0)
    End Function

    Protected Function TraerValor(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Object
        Return Svr.TraerValor(Procedimiento, Parametros)
    End Function

    'pasa los datos del reader a las propiedades del objeto
    Protected MustOverride Sub ArmarObjeto(ByVal dr As IDataReader)
#End Region

#Region "Funciones de Asistencia"
    Public Function Ejecutar(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Object
        Ejecutar = Svr.Ejecutar(Procedimiento, Parametros)

        Svr.Desconectar()
    End Function

    Public Function EjecutarConectado(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Object
        EjecutarConectado = Svr.Ejecutar(Procedimiento, Parametros)
    End Function

    Public Sub Desconectar()
        Svr.Desconectar()
    End Sub

    Public Function TraerDataSet(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return Svr.TraerDataSet(Procedimiento, Parametros)
    End Function

    Protected Function CrearDataAdapter(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As OracleDataAdapter
        Try
            CrearDataAdapter = New OracleDataAdapter(Svr.Comando(Procedimiento, Parametros))
        Catch e As Exception
            MsgBox(e.Message)
        End Try
        Svr.Desconectar()
    End Function

    Public Sub CargarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String, ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object)
        CrearDataAdapter(Procedimiento, Parametros).Fill(Ds, NombreTabla)
    End Sub

    Protected Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal NombreTabla As String)
        Dim Da As New OracleDataAdapter

        Svr.EsActualizacionDataSet = True

        Da.InsertCommand = Svr.Comando("spk_" & Me.Tabla & ".sp_insert")
        Da.UpdateCommand = Svr.Comando("spk_" & Me.Tabla & ".sp_update")
        Da.DeleteCommand = Svr.Comando("spk_" & Me.Tabla & ".sp_delete")

        Svr.EsActualizacionDataSet = False

        Try
            Da.Update(Ds, NombreTabla)

            'se usan para contar las conexiones abiertas
            'frmConexion.Instancia.Estado(Svr.Conexion.State.ToString)
            'frmConexion.Instancia.Sumar()
        Catch ex As OracleException
            Svr.Desconectar()

            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        Svr.Desconectar()
    End Sub

    Public Sub ObtenerEsquema(ByVal Procedimiento As String, ByRef Dt As DataTable)
        If Dt Is Nothing Then
            Dt = New DataTable
        End If

        Try
            'Dim Da As OracleDataAdapter
            Me.CrearDataAdapter(Procedimiento).FillSchema(Dt, SchemaType.Source)
            'Da = CrearDataAdapter(Procedimiento)
            'Da.FillSchema(Dt, SchemaType.Source)
            'Da.Dispose()

        Catch ex As Exception
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        Me.Svr.Desconectar()
    End Sub

    Public Function TraerDataReader(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Try
            Return Svr.Comando(Procedimiento, Parametros).ExecuteReader
        Catch ex As OracleException
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try
    End Function

    Public Function EjecutarSQL(ByVal SQL As String) As DataSet
        EjecutarSQL = Svr.EjecutarSQL(SQL)

        Svr.Desconectar()
    End Function

    Protected Function EjecutarDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return Svr.TraerDataReader(Store, Parametros)
    End Function

    Protected Overridable Sub IniciarTransaccion()
        Svr.IniciarTransaccion()
    End Sub

    Protected Overridable Sub TerminarTransaccion()
        Svr.TerminarTransaccion()
    End Sub

    Protected Sub AbortarTransaccion()
        Svr.AbortarTransaccion()
    End Sub
#End Region

End Class

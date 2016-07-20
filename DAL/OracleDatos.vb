Imports System
Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Client.OracleCommandBuilder
Imports System.Collections

Public Class OracleDatos
    Protected mCadenaConexion As String

    Protected mConexion As OracleConnection
    Protected Transaccion As OracleTransaction

    Shared mColeccionComandos As New Hashtable
    Shared mUsuario As String
    Shared mContraseña As String = "C672B46CBB0F8535"
    Shared mBaseDatos As String

    Dim mIniciarTransaccion As Boolean = False
    Dim mEsActualizacionDataSet As Boolean

    Dim DBConexion As String = "DBConexion" 'AG DBCompania

    Public Property CadenaConexion() As String
        Get

            Dim XML As New AMS.Profile.Xml
            Dim StringConexionDB As String
            'AG DBCompania
            StringConexionDB = XML.GetValue(DBConexion, Activo.CodCampaniaActualMms.ToString())
            If StringConexionDB <> "" Then
                Activo.DBConexionTEC10GP = True
            Else
                Activo.DBConexionTEC10GP = False
                StringConexionDB = ""
            End If

            Return StringConexionDB
        End Get
        Set(ByVal Value As String)
            mCadenaConexion = Value
        End Set
    End Property

    Public Property EsActualizacionDataSet() As Boolean
        Get
            Return mEsActualizacionDataSet
        End Get
        Set(ByVal Value As Boolean)
            mEsActualizacionDataSet = Value
        End Set
    End Property

    Public Shared ReadOnly Property Usuario() As String
        Get
            If mUsuario = "" Then
                Dim XML As New AMS.Profile.Xml

                mUsuario = XML.GetValue("StringConexion", "Usuario")
            End If

            Return mUsuario
        End Get
    End Property

    Public Shared ReadOnly Property Contraseña() As String
        Get
            If mContraseña = "C672B46CBB0F8535" Then
                Dim XML As New AMS.Profile.Xml

                'mContraseña = XML.GetValue("StringConexion", "Contraseña")

                'desencripta
                Dim UC As New UsuarioConexion
                mContraseña = UC.DesencriptarContraseña(mContraseña)
            Else

            End If

            Return mContraseña
        End Get
    End Property

    Public Shared ReadOnly Property BaseDatos() As String
        Get
            If mBaseDatos = "" Then
                Dim XML As New AMS.Profile.Xml

                mBaseDatos = XML.GetValue("StringConexion", "BaseDatos")
            End If

            Return mBaseDatos
        End Get
    End Property

    'aca se conecta a la base de datos
    Public ReadOnly Property Conexion() As OracleConnection
        Get
            If mConexion Is Nothing Then
                mConexion = New OracleConnection(CadenaConexion)
            End If

            If mConexion.State <> ConnectionState.Open And Not Me.EsActualizacionDataSet Then
                Try
                    mConexion.Open() 'SE CONECTA a la base

                    'frmConexion.Instancia.Estado(mConexion.State.ToString)

                    'frmConexion.Instancia.Sumar()

                Catch ex As OracleException
                    ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.ConexionFallida)
                End Try
            End If

            Return mConexion
        End Get
    End Property

    'aca se desconecta de la base de datos
    Public Sub Desconectar()
        If Not mConexion Is Nothing AndAlso mConexion.State <> ConnectionState.Closed Then
            mConexion.Close()
            '     mConexion.Dispose()
        End If

        'If Not mConexion Is Nothing AndAlso mConexion.State = ConnectionState.Closed Then
        '    ' frmConexion.Instancia.Estado(mConexion.State.ToString)
        'End If
    End Sub

    Public Function Comando(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As OracleCommand
        'Dim EstaBorrando As Boolean = False
        'If Procedimiento.IndexOf("delete") > -1 AndAlso Procedimiento.IndexOf("Detalle") > -1 Then
        'EstaBorrando = True
        'End If
        'Try
        Dim Cmd As OracleCommand

        'AG DBCompania
        If Activo.DBConexionTEC10GP = False Then
            Exit Function
        End If

        'si el comando no existe en el buffer, crea uno nuevo
        If Not mColeccionComandos.Contains(Procedimiento) Then

            Dim AuxConexion As New OracleConnection(CadenaConexion)

            AuxConexion.Open()

            'AuxConexion.Close()
            'AuxConexion.Dispose()
            Cmd = New OracleCommand

            Cmd.CommandText = Procedimiento
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Connection = AuxConexion

            Dim TraerParametros As New OracleCommandBuilder

            TraerParametros.DeriveParameters(Cmd)

            If Me.EsActualizacionDataSet Then
                'If EstaBorrando Then
                'Cmd.Parameters.Add("p_id_estado_ejercicio", OracleDbType.Int16)
                'End If
                For Each P As OracleParameter In Cmd.Parameters
                    'If P.ParameterName = "p_id_estado_ejercicio" AndAlso EstaBorrando Then
                    '   P.Value = Activo.Estado
                    'Else
                    P.SourceColumn = P.ParameterName.Substring(2)
                    'End If
                Next

            End If

        AuxConexion.Close()
        AuxConexion.Dispose()

        'despues de crear un comando se guarda en el buffer
        mColeccionComandos.Add(Procedimiento, Cmd)
        Else
        'si exite el comando en el buffer, lo lee
        Cmd = DirectCast(mColeccionComandos.Item(Procedimiento), OracleCommand)
        End If

        'carga los parametros
        If Not Parametros Is Nothing AndAlso Parametros.Length > 0 Then
            CargarParametros(Cmd, Parametros)
        End If

        'inicia la transaccion cuando lo pide el negocio
        If mIniciarTransaccion AndAlso (Me.Transaccion Is Nothing OrElse Me.Transaccion.Connection Is Nothing) Then
            Me.Transaccion = Me.Conexion.BeginTransaction
        End If

        Cmd.Connection = Me.Conexion 'se conecta a la base
        Return Cmd
        'Catch ex As Exception
        '   MsgBox(ex.Message)
        'End Try

    End Function

    Protected Sub CargarParametros(ByVal Comando As OracleCommand, ByVal ParamArray Parametros() As Object)
        Dim i As Integer

        Try
            For i = 0 To Parametros.Length - 1
                Comando.Parameters(i).Value = Parametros.GetValue(i)
            Next
        Catch ex As IndexOutOfRangeException
            Mensajes.Mensaje("La Cantidad de Parámetros Pasados en la Clase No Coincide con los del Store Procedure", TipoMensaje.DeError)
        End Try
    End Sub

    Public Function Ejecutar(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Object

        Dim Cmd As OracleCommand

        Cmd = Comando(Procedimiento, Parametros)

        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mensajes.Mensaje("OracleDatos.Ejecutar: " & ex.Message, TipoMensaje.DeError)
            Throw ex
        End Try

        If (Procedimiento <> "INSERTAR_SOPORTE_MMS") Then   ' agregado gw 08/09/2014 para poder llamar a este procedimiento sin parametros
            'devuelve el valor del ultimo parametro
            If Cmd.Parameters.Item(Cmd.Parameters.Count - 1).Direction = ParameterDirection.InputOutput Or Cmd.Parameters.Item(Cmd.Parameters.Count - 1).Direction = ParameterDirection.Output Then
                Ejecutar = Cmd.Parameters.Item(Cmd.Parameters.Count - 1).Value
            End If
        End If

        If Not Me.mIniciarTransaccion Then
            Desconectar()
        End If
    End Function

    Protected Function CrearDataAdapter(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As OracleDataAdapter
        Return New OracleDataAdapter(Comando(Procedimiento, Parametros))
    End Function

    Public Function EjecutarSQL(ByVal SQL As String) As DataSet
        Dim Cmd As New OracleCommand
        Dim Ds As New DataSet
        Dim Da As New OracleDataAdapter

        Cmd.CommandText = SQL
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = Me.Conexion

        Da.SelectCommand = Cmd

        Try
            Da.Fill(Ds)
        Catch ex As OracleException
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        Desconectar()

        Return Ds
    End Function

    Public Function TraerDataSet(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataSet
        Dim Ds As New DataSet
        ' &&&
        Try
            'AG DBCompania
            If Activo.DBConexionTEC10GP = True Then
                CrearDataAdapter(Procedimiento, Parametros).Fill(Ds)
            Else
                Exit Function
            End If

            'CrearDataAdapter(Procedimiento, Parametros).Fill(Ds)
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        Desconectar()

        Return Ds
    End Function

    Public Function TraerDataTable(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As DataTable
        Return TraerDataSet(Procedimiento, Parametros).Tables(0).Copy
    End Function

    Public Function TraerDataReader(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return Comando(Procedimiento, Parametros).ExecuteReader
    End Function

    Public Function TraerValor(ByVal Procedimiento As String, ByVal ParamArray Parametros() As Object) As Object
        TraerValor = Comando(Procedimiento, Parametros).ExecuteScalar

        Desconectar()
    End Function

    Public Sub IniciarTransaccion()
        mIniciarTransaccion = True
    End Sub

    Public Sub TerminarTransaccion()
        Transaccion.Commit()
        mIniciarTransaccion = False
    End Sub

    Public Sub AbortarTransaccion()
        Transaccion.Rollback()
        mIniciarTransaccion = False
    End Sub
End Class

'Public Class InfoProc
'    'OBTENEMOS INFORMACION DE LOS PARAMETROS DE LOS STORES PROCEDURES, 
'    'SE USA EL DRIVER DE MICROSOFT
'    Public Shared Function ObtenerParametros(ByVal Cadena As String, ByVal Procedimiento As String, Optional ByVal EsActualizacionDataSet As Boolean = False) As OracleCommand
'        Dim AuxConexion As New System.Data.OracleClient.OracleConnection(Cadena)

'        Try
'            AuxConexion.Open()
'        Catch ex As System.Data.OracleClient.OracleException
'            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.ConexionFallida, Procedimiento)
'        End Try

'        'comando con el driver de microsoft
'        Dim CmdMicrosoft As New System.Data.OracleClient.OracleCommand

'        CmdMicrosoft.CommandText = Procedimiento
'        CmdMicrosoft.CommandType = CommandType.StoredProcedure
'        CmdMicrosoft.Connection = AuxConexion

'        Dim TraerParametros As New System.Data.OracleClient.OracleCommandBuilder

'        'carga los parametros en el comando con el driver de microsoft
'        Try
'            TraerParametros.DeriveParameters(CmdMicrosoft)

'            'excepcion del driver de MICROSFOT
'        Catch ex As System.Data.OracleClient.OracleException
'            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.LecturaParametrosFallido, Procedimiento)
'        End Try

'        AuxConexion.Close()
'        AuxConexion = Nothing

'        'comando con el driver de ORACLE
'        Dim CmdOracle As New OracleCommand

'        CmdOracle.CommandText = Procedimiento
'        CmdOracle.CommandType = CommandType.StoredProcedure

'        Dim P As OracleClient.OracleParameter

'        'hay que convertir los tipos de los parametros de Microsoft a Oracle
'        Dim TipoOracle As OracleDbType
'        Dim ParamOracle As Oracle.DataAccess.Client.OracleParameter

'        For Each P In CmdMicrosoft.Parameters
'            ParamOracle = New Oracle.DataAccess.Client.OracleParameter
'            ParamOracle.Precision = P.Precision
'            ParamOracle.Scale = P.Scale

'            'pasa de un tipo a otro
'            Select Case P.OracleType
'                Case OracleClient.OracleType.Cursor
'                    TipoOracle = OracleDbType.RefCursor

'                Case OracleClient.OracleType.VarChar
'                    TipoOracle = OracleDbType.Varchar2

'                Case OracleClient.OracleType.Number
'                    TipoOracle = OracleDbType.Double

'                Case OracleClient.OracleType.DateTime
'                    TipoOracle = OracleDbType.Date

'                Case OracleClient.OracleType.Char
'                    TipoOracle = OracleDbType.Char
'            End Select

'            ParamOracle.OracleDbType = TipoOracle
'            ParamOracle.ParameterName = P.ParameterName
'            ParamOracle.Direction = P.Direction

'            If EsActualizacionDataSet Then
'                ParamOracle.SourceColumn = P.ParameterName.Substring(2)
'            End If

'            'crea un parametros en el comando de ORACLE
'            '*** EL NOMBRE DEL PARAMETRO TIENE QUE SER SIEMPRE DE ESTE TIPO:
'            '                       "p_*"
'            'PARA PODER PASAR EL NOMBRE DE COLUMNA HAY QUE SACARLE 2 CARACTERES AL 
'            'NOMBRE DEL PARAMETRO
'            CmdOracle.Parameters.Add(ParamOracle)
'        Next

'        Return CmdOracle
'    End Function
'End Class
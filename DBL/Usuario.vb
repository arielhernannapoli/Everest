Imports MSL
Imports HM.Comun.Seguridad
Imports HM.Comun.Varios
Imports HM.Contratos.Entidad.Seguridad
Imports Framework

Public Class Usuario
    Inherits Entidad     
    'se usa para encriptar la contraseña
    Declare Sub EncriptaHex Lib "encriptadll.dll" Alias "?EncriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

    Declare Sub DesencriptaHex Lib "encriptadll.dll" Alias "?DesencriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

#Region "Propiedades"
    Dim mIDUsuario As Short
    Dim mLogin As String
    Dim mPassWd As String
    Dim mNombre As String
    Dim mApellido1 As String
    Dim mApellido2 As String
    Dim mIDPerfil_Datos As Short
    Dim mIDPerfil_Capacidades As Short

    Public Property IDPerfil_Capacidades() As Short
        Get
            Return mIDPerfil_Capacidades
        End Get
        Set(ByVal Value As Short)
            mIDPerfil_Capacidades = Value
        End Set
    End Property
    Public Property IDUsuario() As Short
        Get
            Return mIDUsuario
        End Get
        Set(ByVal Value As Short)
            mIDUsuario = Value
        End Set
    End Property

    Public Property Login() As String
        Get
            Return mLogin
        End Get
        Set(ByVal Value As String)
            mLogin = Value
        End Set
    End Property

    Public Property PassWd() As String
        Get
            Return mPassWd
        End Get
        Set(ByVal Value As String)
            mPassWd = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal Value As String)
            mNombre = Value
        End Set
    End Property

    Public Property Apellido1() As String
        Get
            Return mApellido1
        End Get
        Set(ByVal Value As String)
            mApellido1 = Value
        End Set
    End Property

    Public Property Apellido2() As String
        Get
            Return mApellido2
        End Get
        Set(ByVal Value As String)
            mApellido2 = Value
        End Set
    End Property

    Public Property IDPerfil_Datos() As Short
        Get
            Return mIDPerfil_Datos
        End Get
        Set(ByVal Value As Short)
            mIDPerfil_Datos = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Usuarios")
    End Sub

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        Try
            MyBase.TraerUno("spk_" & MyBase.Tabla & ".sp_select", Me.IDUsuario)
        Catch ex As DataReaderVacioExcepcion
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.UsuarioInexistente, "spk_" & MyBase.Tabla & ".sp_select")
        End Try
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        With Me
            .IDUsuario = IIf(IsDBNull(dr("id_usuario")), 0, dr("id_usuario"))
            .Login = dr("login") & ""
            .PassWd = dr("passwd") & ""
            .Nombre = dr("nombre") & ""
            .Apellido1 = dr("apellido1") & ""
            .Apellido2 = dr("apellido2") & ""
            .IDPerfil_Datos = dr("idperfil_datos") & ""
            .IDPerfil_Capacidades = dr("ID_PERFIL_CAPACIDADES") & ""
        End With
    End Sub

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
    'trae los clientes que puede ver el usuario
    Public Function obtenerClientes() As DataTable
        Dim oMaestro As Maestros = New Maestros

        'AGuzzardi Verifico que este cargado el DTCache de Cliente si esta nulo busco en los MSL
        If Activo.DTClientesCache Is Nothing Then
            Return oMaestro.ClientesTraerTodos(MSL.Constantes.COD_PAIS_ARGENTINA)
        Else
            Return Activo.DTClientesCache
        End If

    End Function

    Public Function ValidarUsuario(ByVal usuario As String, ByVal contrasena As String) As Usuario
        Dim oDato As MSL.DatosMms = New MSL.DatosMms
        Dim oMaestro As MSL.Maestros = New MSL.Maestros
        Dim oUsuario As Usuario
        Dim mmsUsuario As UsuarioEntidad = New UsuarioEntidad()
        ''valida el usuario.
        mmsUsuario = oDato.ValidarUsuarioMMS(usuario, contrasena)

        Dim DtPerfilConvenios As DataTable

        If IsNothing(mmsUsuario) Then
            MsgBox("usuario o contraseña incorrecto")
            'Exit Function
            Return Nothing
        End If

        ''Estos valores se utilizan para la interaccion con MMS.
        Activo.CodPaisMms = mmsUsuario.CodPais
        Activo.CodUsuarioMms = mmsUsuario.CodUsuario
        Activo.CodCampaniaActualMms = mmsUsuario.CodCompania
        Activo.CantidadDiasBloqueoPresupuestoMms = CInt(oMaestro.ObtenerDiasLimiteCreacionPresupuesto(mmsUsuario.CodCompania))

        oUsuario = New Usuario

        With oUsuario
            .IDUsuario = mmsUsuario.CodUsuario
            .Login = mmsUsuario.Login
            .PassWd = contrasena
            'JJP - No es útil tener encriptada la password de mms
            '.PassWd = mmsUsuario.Password
            .Nombre = mmsUsuario.Nombre
            .Apellido1 = mmsUsuario.Apellido1
            .Apellido2 = mmsUsuario.Apellido2
            .IDPerfil_Datos = 1 'mmsUsuario.CodCompania

            'Datos Activos ------------------------------------------------
            Activo.IDCompaniaMMS = mmsUsuario.CodCompania
            Activo.IDUsuarioMMS = mmsUsuario.CodUsuario
            Activo.CodCapacidad = 6
            Activo.IDUsuario = mmsUsuario.CodUsuario
            Activo.IDPerfil_Datos = 1
            Activo.Id_Delegacion = 1 ''Warning: Jsperk - No lo devuelve el objeto usuario, ver como implementacion futura.
            Activo.DBConexionTEC10GP = True 'AG DBCompania
            '-----------------------------------------------------------------
            '.IDPerfil_Capacidades = mmsUsuario.CapacidadesUsuario
        End With

        Return oUsuario

    End Function
    'Public Function ObtenerClientes() As DataTable
    '    Return MyBase.TraerDataSet("spk_seguridad.sp_datos_usuario_cliente", Me.IDPerfil_Datos).Tables(0)
    'End Function

    'se usa para buscar un cliente por codigo tomando los clientes validos para el perfil del usuario

    ''Datos descripcion de cliente se busca desde el objeto cliente(DATOS MMS) DANIEL CAIME
    Public Function ObtenerDescripcion(ByVal IDCliente As Integer) As String
        Dim oCliente As Clientes
        oCliente = New Clientes
        oCliente.Id_cliente = IDCliente
        oCliente.BuscarPorId()
        Return oCliente.Descripcion
        ''Return MyBase.TraerValor("spk_seguridad.sp_datos_cliente", Me.IDPerfil_Datos, IDCliente)
    End Function

    Public Sub ObtenerContraseña()
        Try
            Me.TraerUno("spk_seguridad.sp_passwd", Me.Login)
        Catch ex As DataReaderVacioExcepcion
            ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.UsuarioInexistente, "spk_seguridad.sp_passwd")
        End Try
    End Sub

    Public Function ObtenerContraseñaEncriptada(ByVal ContraseñaSinEcriptar As String) As String
        'hay que cargar los 16 espacios que tiene el campo de contraseña encriptada
        Dim Salida As String = "0123456789123456"

        EncriptaHex(ContraseñaSinEcriptar, Salida)

        Return Salida
    End Function

    'AG 10/06/2014 ===========================================================================
    Public Function ObtenerUsuariosSinPermisos() As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_USUARIOS_TODOS").Tables(0)
        Return Dt
    End Function

    Public Function ObtenerUsuariosConPermisos() As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_USUARIOS_CARGADOS").Tables(0)
        Return Dt
    End Function

    Public Sub Alta_Update_PermisosUsuario(ByVal id_usuario_admin As Integer, ByVal id_usuario_perfil As Integer, ByVal id_permiso As Integer)
        Me.Ejecutar("ADMIN_PERFILES.SP_UPDATE_PERFIL", id_usuario_admin, id_usuario_perfil, id_permiso)
    End Sub

    Public Sub Borrar_PermisosUsuario(ByVal id_usuario_admin As Integer, ByVal id_usuario_perfil As Integer)
        Me.Ejecutar("ADMIN_PERFILES.SP_DELETE_PERFIL", id_usuario_admin, id_usuario_perfil)
    End Sub

    Public Function PerfilesExistente() As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_PERFILES_EXISTENTES").Tables(0)
        Return Dt
    End Function

    Public Function PerfilesNuevos() As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_PERFILES_NUEVOS").Tables(0)
        Return Dt
    End Function

    Public Function BlanqueoGrilla() As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_USUARIOS_VACIOS_GRILLA").Tables(0)
        Return Dt
    End Function

    Public Function UsuariosAdminPerfiles(ByVal id_usuario_admin As Integer) As DataTable
        Dim Dt As New DataTable
        Dt = Me.TraerDataSet("ADMIN_PERFILES.SP_USUARIOS_ADMIN", id_usuario_admin).Tables(0)
        Return Dt
    End Function

    '===========================================================================================


#End Region

End Class

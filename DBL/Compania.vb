Imports MSL
Imports HM.Comun.Seguridad
Imports HM.Comun.Varios
Imports HM.Contratos.Entidad.Seguridad
Imports Framework

Public Class Compania
    Inherits Entidad
    'se usa para encriptar la contraseña
    Declare Sub EncriptaHex Lib "encriptadll.dll" Alias "?EncriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

    Declare Sub DesencriptaHex Lib "encriptadll.dll" Alias "?DesencriptaHex@Encripta@@QAEXPAD0@Z" _
    (ByVal sEntrada As String, ByVal sSalida As String)

#Region "Propiedades"
    Dim mIDCompania As Short
    Dim mDescripcion As String

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property IDCompania() As Short
        Get
            Return mIDCompania
        End Get
        Set(ByVal Value As Short)
            mIDCompania = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Companias")
    End Sub

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        Try
            'MyBase.TraerUno("spk_" & MyBase.Tabla & ".sp_select", Me.IDUsuario)
        Catch ex As DataReaderVacioExcepcion
            'ManejoExcepciones.ManejarExcepcion(ex, TipoExcepcion.UsuarioInexistente, "spk_" & MyBase.Tabla & ".sp_select")
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
        'With Me
        '    .IDUsuario = IIf(IsDBNull(dr("id_usuario")), 0, dr("id_usuario"))
        '    .Login = dr("login") & ""
        '    .PassWd = dr("passwd") & ""
        '    .Nombre = dr("nombre") & ""
        '    .Apellido1 = dr("apellido1") & ""
        '    .Apellido2 = dr("apellido2") & ""
        '    .IDPerfil_Datos = dr("idperfil_datos") & ""
        '    .IDPerfil_Capacidades = dr("ID_PERFIL_CAPACIDADES") & ""
        'End With
    End Sub
    Dim oDatosMaestros As Maestros
    Public Function ObtenerCompanias() As DataTable
        oDatosMaestros = New Maestros
        'AGuzzardi Cargo DT Cache Medios --------------------------------------------------------
        If Activo.DTCompaniasCache Is Nothing Then
            Activo.DTCompanias = oDatosMaestros.CompaniasTraerTodas(Constantes.COD_PAIS_ARGENTINA)
        End If
        '---------------------------------------------------------------------------------
        'Codigo DC ---------------------------------------------------------
        'dt = oDatosMaestros.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        '---------------------------------------------------------------------------------

        Return Activo.DTCompanias

    End Function

    Public Function ObtenerDelegacionByCodCompania(ByVal cod_compania As Short) As DataTable
        oDatosMaestros = New Maestros
        'AGuzzardi Cargo DT Cache Medios --------------------------------------------------------
        If Activo.DTDelegacionesCache Is Nothing Then
            Activo.DTDelegaciones = oDatosMaestros.ObtenerDelegacionByCodCompania(cod_compania)
        End If
        '---------------------------------------------------------------------------------
        'Codigo DC ---------------------------------------------------------
        'dt = oDatosMaestros.MediosTraerTodos(Constantes.COD_PAIS_ARGENTINA)
        '---------------------------------------------------------------------------------

        Return Activo.DTDelegaciones

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

End Class

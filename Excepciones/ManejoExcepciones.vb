Public Class ManejoExcepciones

    'manejado public al que accede la capa de negocios
    Public Shared Sub ManejarExcepcion(ByVal ex As Object, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        If TypeOf ex Is OracleException Then
            ManejarOracleException(ex, T, Procedimiento)
        End If

        If TypeOf ex Is OracleTypeException Then
            ManejarOracleTypeException(ex, T, Procedimiento)
        End If

        If TypeOf ex Is OracleNullValueException Then
            ManejarOracleNullValueException(ex, T, Procedimiento)
        End If

        If TypeOf ex Is DataReaderVacioExcepcion Then
            ManejarDataReaderVacioExcepcion(ex, T, Procedimiento)
        End If

        If TypeOf ex Is System.Data.OracleClient.OracleException Then
            ManejarOracleExceptionMicrosoft(ex, T, Procedimiento)
        End If

        If TypeOf ex Is ArgumentOutOfRangeException Then
            ManejarArgumentOutOfRangeException(ex, T, Procedimiento)
        End If

        'guarda el error en el archivo de texto si no es un error del Negocio
        If Not TypeOf ex Is NegocioExcepcion Then
            GuardarError(ex)
        End If
    End Sub

#Region "Manejadores de Excepciones"

    '*************************************************************************************'
    '**** AGREGAR MAS METODOS CUANDO SE QUIERAN LANZAR MAS EXCEPCIONES PERSONALIZADAS ****'
    '**** O AGREGAR MAS TIPOS DE EXCEPCIONES Y LEERLAS EN EL SELECT CASE              ****'
    '*************************************************************************************'

    Private Shared Sub ManejarException(ByVal ex As Exception, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'cualquier error
        Throw New QueToolExcepcion("Error No Identificado:" & vbCrLf & vbCrLf & ex.Message)
    End Sub

    Private Shared Sub ManejarOracleException(ByVal ex As OracleException, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'cualquier error de Oracle
        Select Case T
            Case TipoExcepcion.ConexionFallida
                Throw New ConexionFallidaExcepcion("No se Pudo Realizar la Conexión a la Base de Datos:" & vbCrLf & vbCrLf & ex.Message)
            Case TipoExcepcion.Otra
                Throw New BaseDatosExcepcion("Error en la Base de Datos:" & vbCrLf & vbCrLf & ex.Message)
        End Select
    End Sub

    Private Shared Sub ManejarOracleTypeException(ByVal ex As OracleTypeException, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'se paso un parametro con el tipo incorrecto
        Throw New BaseDatosExcepcion("Uno de los Campos Contiene un Tipo de Dato No Válido")
        GuardarError(ex)
    End Sub

    Private Shared Sub ManejarOracleNullValueException(ByVal ex As OracleNullValueException, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'se paso un parametro nulo
        Throw New BaseDatosExcepcion("Uno de los Campos Contiene un Valor Nulo")
    End Sub

    Private Shared Sub ManejarDataReaderVacioExcepcion(ByVal ex As DataReaderVacioExcepcion, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'cuando un datareader llega vacio
        Select Case T
            Case TipoExcepcion.UsuarioInexistente
                Throw New UsuarioInexistenteExcepcion("Debe Ingresar el Nombre de Usuario")
            Case TipoExcepcion.SistemaInexistente
                Throw New SistemaInexistenteExcepcion("El Sistema No Existe")
            Case TipoExcepcion.ClienteInexistente
                Throw New ClienteInexistenteExcepcion("El Cliente No Existe")
            Case TipoExcepcion.EjercicioInexistente
                Throw New EjercicioInexistenteExcepcion("El Ejercicio No Existe")
        End Select
    End Sub

    Private Shared Sub ManejarOracleExceptionMicrosoft(ByVal ex As System.Data.OracleClient.OracleException, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        'error en la clase InfoProc que hace el derive parameters
        Select Case T
            Case TipoExcepcion.ConexionFallida
                Throw New ConexionFallidaExcepcion("No se Pudo Realizar la Conexión a la Base de Datos:" & _
                vbCrLf & "Procedimiento: " & Procedimiento & _
                vbCrLf & ex.Message)
            Case TipoExcepcion.LecturaParametrosFallido
                Mensajes.Mensaje("No se Pudieron Leer los Parámetros del SP " & Procedimiento & ". Por las Siguientes Razones: " & vbCrLf & _
                ex.Message)
        End Select
    End Sub

    Private Shared Sub ManejarArgumentOutOfRangeException(ByVal ex As ArgumentOutOfRangeException, ByVal T As TipoExcepcion, Optional ByVal Procedimiento As String = "")
        Throw New BaseDatosExcepcion("La Cantidad de Parámetros es Incorrecta" & vbCrLf & "Compruebe la Función '" & Procedimiento & "'")
    End Sub

#End Region

    Private Shared Sub GuardarError(ByVal e As Exception, Optional ByVal Procedimiento As String = "")
        Dim Escribir = System.IO.File.AppendText(Application.StartupPath & "\Errores.txt")

        Escribir.WriteLine("Fecha: " & Date.Now) 'fecha
        Escribir.WriteLine("Usuario: " & Activo.Login & "(" & Activo.Nombre & " " & Activo.Apellido1 & ")")  'fecha
        Escribir.WriteLine("Descripción: " & e.Message) 'mensaje de error
        Escribir.WriteLine("Origen: " & e.StackTrace & vbCrLf) 'origen

        Escribir.Close()

        '*** CODIGO PARA MANDAR UN EMAIL
        'Dim Mail As New email.Mail()
        'Mail.EnviarMail("a", "esteban", _
        '"www.cerebrodigital.com.ar", "a", _
        '"Error " & Date.Now, F.Procedimiento & vbCrLf & e.Message & vbCrLf & e.StackTrace)

        Escribir = Nothing
    End Sub
End Class

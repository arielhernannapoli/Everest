Imports System.Reflection

Public Class Refleccion
    Public Shared Function ObtenerValorPropiedad(ByVal Objeto As Object, ByVal Propiedad As String) As Object
        Dim Tipo As System.Type
        Dim InfoPropiedad As PropertyInfo

        Tipo = Objeto.GetType

        InfoPropiedad = Tipo.GetProperty(Propiedad, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.Public)

        If InfoPropiedad Is Nothing Then
            MsgBox("La Propiedad No Existe", MsgBoxStyle.Critical, "Refleccion.ObtenerValorPropiedad")
            Return ""
        End If

        Return InfoPropiedad.GetValue(Objeto, Nothing)
    End Function

    Public Shared Sub SetearValorPropiedad(ByVal Objeto As Object, ByVal Propiedad As String, ByVal Valor As Object)
        Dim Tipo As System.Type
        Dim InfoPropiedad As PropertyInfo

        Tipo = Objeto.GetType

        InfoPropiedad = Tipo.GetProperty(Propiedad, BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.Public)

        If InfoPropiedad Is Nothing Then
            MsgBox("La Propiedad No Existe", MsgBoxStyle.Critical, "Refleccion.ObtenerValorPropiedad")
            Exit Sub
        End If

        Select Case InfoPropiedad.PropertyType.ToString
            Case "System.Int16"
                InfoPropiedad.SetValue(Objeto, CShort(Valor), Nothing)
            Case "System.String"
                InfoPropiedad.SetValue(Objeto, Valor, Nothing)
            Case "System.Boolean"
                InfoPropiedad.SetValue(Objeto, CBool(Valor), Nothing)
        End Select

    End Sub
End Class

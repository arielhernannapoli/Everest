Public Class TablaHash
    Dim H As Hashtable

    Default Public ReadOnly Property Item(ByVal Clave As String) As Object
        Get
            Clave = Clave.ToLower

            If H.Contains(Clave) Then
                Return H.Item(Clave)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub AgregarParametro(ByVal Clave As String, ByVal Valor As Object)

        'FALTA NO DEJAR GUARDAR NOTHING

        If H Is Nothing Then
            H = New Hashtable
        End If

        Clave = Clave.ToLower

        'cotrola que en la hash table no se ingresen claves duplicadas
        If Not H.Contains(Clave) Then
            'agrega una nueva clave
            H.Add(Clave, Valor)
        Else
            'si existe, modifica el valor
            H.Item(Clave) = Valor
        End If
    End Sub
End Class

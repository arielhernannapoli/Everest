Public Class ManejoABM
    Dim mABMs As Hashtable

    Private ReadOnly Property ABMs() As Hashtable
        Get
            If mABMs Is Nothing Then
                mABMs = New Hashtable
            End If

            Return mABMs
        End Get
    End Property

    Public Sub CargarControlABM(ByVal Clave As String, ByVal ControlABM As Control, ByRef Contenedor As Control, ByRef IABM As IABM, Optional ByVal Left As Short = 0, Optional ByVal Top As Short = 0)
        'carga posiciona un control ABM
        If Left = 0 Then
            ControlABM.Left = Contenedor.Left + 10
        End If

        ControlABM.Top = Top

        'agrega el control al Panel de ABMs
        Contenedor.Controls.Add(ControlABM)

        Clave = Clave.ToLower

        If Not ABMs.Contains(Clave) Then
            'guarda la clave que lo identifica y el indice de la
            'coleccion de controles donde esta guardado
            ABMs.Add(Clave, Contenedor.Controls.Count - 1)
        Else
            'pisa el valor de la clave pasada
            ABMs.Item(Clave) = Contenedor.Controls.Count - 1
        End If

        'pasa a la interfaz el control que se esta usando
        IABM = ControlABM
    End Sub

    Public Function RecuperarControl(ByVal Clave As String, ByVal Contenedor As Control) As IABM
        If Not ABMs.Item(Clave) Is Nothing Then
            Return Contenedor.Controls(ABMs.Item(Clave))
        End If
    End Function

    Public Function RecuperarControl(ByVal Clave As String, ByRef Contenedor As Control, ByRef IABM As IABM) As Boolean
        If Not ABMs.Item(Clave) Is Nothing Then
            IABM = Contenedor.Controls(ABMs.Item(Clave))
            Return True
        Else
            Return False
        End If
    End Function
End Class

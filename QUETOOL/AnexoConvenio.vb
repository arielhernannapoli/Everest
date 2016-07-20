Public Class AnexoConvenio

    Private _bytes As Byte()
    Public Property Bytes() As Byte()
        Get
            Return _bytes
        End Get
        Set(ByVal value As Byte())
            _bytes = value
        End Set
    End Property

    Private _extension As String
    Public Property Extension() As String
        Get
            Return _extension
        End Get
        Set(ByVal value As String)
            _extension = value
        End Set
    End Property

    Private _idAnexo As Integer
    Public Property IdAnexo() As Integer
        Get
            Return _idAnexo
        End Get
        Set(ByVal value As Integer)
            _idAnexo = value
        End Set
    End Property

    Private _idConvenio As Integer
    Public Property IdConvenio() As Integer
        Get
            Return _idConvenio
        End Get
        Set(ByVal value As Integer)
            _idConvenio = value
        End Set
    End Property

    Private _nombreArchivo As String
    Public Property NombreArchivo() As String
        Get
            Return _nombreArchivo
        End Get
        Set(ByVal value As String)
            _nombreArchivo = value
        End Set
    End Property


End Class

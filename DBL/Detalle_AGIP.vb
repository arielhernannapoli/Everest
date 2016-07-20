Imports System.Net
Imports System.Xml.XPath

Public Class Detalle_AGIP
    Inherits Entidad

#Region "Propiedades"
    Dim mId_Detalle As Integer
    Dim mId_Padron As Integer
    Dim mCUIT As String
    Dim mRazonSocial As String
    Dim mCodigoAGIP As String
    Dim mClase As String
    Dim mTipo As String
    Dim mCaracteristica As String
    Dim mSup As Integer
    Dim mZona As Integer
    Dim mDireccion As String
    Dim mAltura As Integer
    Dim mLatitud As Decimal
    Dim mLongitud As Decimal
    Dim mProvincia As String
    Dim mLocalidad As String

    Public Property Id_Detalle() As Integer
        Get
            Return mId_Detalle
        End Get
        Set(ByVal Value As Integer)
            mId_Detalle = Value
        End Set
    End Property

    Public Property Id_Padron() As Integer
        Get
            Return mId_Padron
        End Get
        Set(ByVal Value As Integer)
            mId_Padron = Value
        End Set
    End Property

    Public Property CUIT() As String
        Get
            Return mCUIT
        End Get
        Set(ByVal Value As String)
            mCUIT = Value
        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return mRazonSocial
        End Get
        Set(ByVal Value As String)
            mRazonSocial = Value
        End Set
    End Property

    Public Property CodigoAGIP() As String
        Get
            Return mCodigoAGIP
        End Get
        Set(ByVal Value As String)
            mCodigoAGIP = Value
        End Set
    End Property

    Public Property Clase() As String
        Get
            Return mClase
        End Get
        Set(ByVal Value As String)
            mClase = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return mTipo
        End Get
        Set(ByVal Value As String)
            mTipo = Value
        End Set
    End Property

    Public Property Caracteristica() As String
        Get
            Return mCaracteristica
        End Get
        Set(ByVal Value As String)
            mCaracteristica = Value
        End Set
    End Property

    Public Property Sup() As Integer
        Get
            Return mSup
        End Get
        Set(ByVal Value As Integer)
            mSup = Value
        End Set
    End Property

    Public Property Zona() As Integer
        Get
            Return mZona
        End Get
        Set(ByVal Value As Integer)
            mZona = Value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return mDireccion
        End Get
        Set(ByVal Value As String)
            mDireccion = Value
        End Set
    End Property

    Public Property Altura() As Integer
        Get
            Return mAltura
        End Get
        Set(ByVal Value As Integer)
            mAltura = Value
        End Set
    End Property

    Public ReadOnly Property DireccionCompleta() As String
        Get
            Return mDireccion & " " & mAltura
        End Get
    End Property

    Public Property Latitud() As Decimal
        Get
            Return mLatitud
        End Get
        Set(ByVal Value As Decimal)
            mLatitud = Value
        End Set
    End Property

    Public Property Longitud() As Decimal
        Get
            Return mLongitud
        End Get
        Set(ByVal Value As Decimal)
            mLongitud = Value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return mProvincia
        End Get
        Set(ByVal Value As String)
            mProvincia = Value
        End Set
    End Property

    Public Property Localidad() As String
        Get
            Return mLocalidad
        End Get
        Set(ByVal Value As String)
            mLocalidad = Value
        End Set
    End Property
#End Region

    Sub New()
        MyBase.New("Detalles_AGIP")
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        Me.Id_Detalle = IIf(IsDBNull(dr("Id_Detalle")), 0, dr("Id_Detalle"))
        Me.Id_Padron = IIf(IsDBNull(dr("Id_Padron")), 0, dr("Id_Padron"))
        Me.CUIT = IIf(IsDBNull(dr("CUIT")), "", dr("CUIT"))
        Me.RazonSocial = IIf(IsDBNull(dr("RazonSocial")), "", dr("RazonSocial"))
        Me.CodigoAGIP = IIf(IsDBNull(dr("CodigoAGIP")), "", dr("CodigoAGIP"))
        Me.Clase = IIf(IsDBNull(dr("Clase")), "", dr("Clase"))
        Me.Tipo = IIf(IsDBNull(dr("Tipo")), "", dr("Tipo"))
        Me.Caracteristica = IIf(IsDBNull(dr("Caracteristica")), "", dr("Caracteristica"))
        Me.Sup = IIf(IsDBNull(dr("Sup")), 0, dr("Sup"))
        Me.Zona = IIf(IsDBNull(dr("Zona")), 0, dr("Zona"))
        Me.Direccion = IIf(IsDBNull(dr("Direccion")), "", dr("Direccion"))
        Me.Altura = IIf(IsDBNull(dr("Altura")), 0, dr("Altura"))
        Me.Latitud = IIf(IsDBNull(dr("Latitud")), 0, dr("Latitud"))
        Me.Longitud = IIf(IsDBNull(dr("Longitud")), 0, dr("Longitud"))
    End Sub

    Public Sub GuardarCoordenadas()
        Dim dtCoordenadas As DataTable
        dtCoordenadas = Me.ObtenerCoordenadas(Me.CodigoAGIP)
        If dtCoordenadas.Rows.Count = 0 Then
            Me.ObtenerCoordenadasGoogle(Me)
            If Me.Latitud <> 0 And Me.Longitud <> 0 Then
                Me.AgregarCoordenadas(Me.CodigoAGIP, Me.Latitud, Me.Longitud)
            End If
        End If
    End Sub

    Public Overloads Function Agregar(ByVal p_id_Padron As Integer, ByVal p_CUIT As String, _
    ByVal p_razon_social As String, ByVal p_codigo_AGIP As String, ByVal p_clase As String, _
    ByVal p_tipo As String, ByVal p_caracteristica As String, ByVal p_sup As Integer, _
    ByVal p_zona As Integer, ByVal p_direccion As String, ByVal p_altura As Double) As Object
        Return MyBase.Agregar(p_id_Padron, p_CUIT, p_razon_social, p_codigo_AGIP, p_clase, p_tipo, p_caracteristica, p_sup, p_zona, p_direccion, p_altura)
    End Function

    Public Function BuscarPorCodigoAGIP(ByVal p_cod_AGIP As String) As DataTable
        Return Me.TraerDataSet("SPK_DETALLES_AGIP.SP_SELECT", p_cod_AGIP).Tables(0)
    End Function

    Public Function ObtenerPorCUIT(ByVal p_id_padron As Integer, ByVal p_cuit As String) As DataTable
        Return Me.TraerDataSet("SPK_DETALLES_AGIP.SP_SELECT_CUIT", p_id_padron, p_cuit).Tables(0)
    End Function

    Public Function ObtenerCoordenadas(ByVal p_cod_AGIP As String) As DataTable
        Return Me.TraerDataSet("SPK_COORDENADAS_AGIP.SP_SELECT", p_cod_AGIP).Tables(0)
    End Function

    Private Function AgregarCoordenadas(ByVal p_id_detalle As Long, ByVal p_latitud As Decimal, ByVal p_longitud As Decimal) As Object
        Return Me.Ejecutar("SPK_COORDENADAS_AGIP.SP_INSERT", p_id_detalle, p_latitud, p_longitud)
    End Function

    Public Sub ObtenerCoordenadasGoogle(ByVal p_detalleAGIP As Detalle_AGIP)
        If p_detalleAGIP.Direccion.Contains("PTE") Then
            p_detalleAGIP.Direccion.Replace("PTE", "PRES")
        End If
        If p_detalleAGIP.Direccion.Contains("AV.") Then
            p_detalleAGIP.Direccion.Replace(" AV.", String.Empty)
        End If
        If p_detalleAGIP.Direccion.Contains("AV") Then
            p_detalleAGIP.Direccion.Replace(" AV", String.Empty)
        End If
        If p_detalleAGIP.Direccion.Contains("SBTE") Then
            p_detalleAGIP.Direccion.Remove(0, 7)
        End If
        Dim url As String
        If p_detalleAGIP.Localidad = "Capital Federal" Then
            url = "http://maps.googleapis.com/maps/api/geocode/xml?address=" & p_detalleAGIP.DireccionCompleta & ", Ciudad Autónoma de Buenos Aires&sensor=false"
        Else
            url = "http://maps.googleapis.com/maps/api/geocode/xml?address=" & p_detalleAGIP.Direccion & ", " & p_detalleAGIP.Localidad & "&sensor=false"
        End If

        Dim response As WebResponse
        Try
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            response = request.GetResponse()
            If Not response Is Nothing Then
                Dim document As New XPathDocument(response.GetResponseStream())
                Dim navigator As XPathNavigator = document.CreateNavigator()
                Dim estadoIterator As XPathNodeIterator = navigator.Select("/GeocodeResponse/status")
                While estadoIterator.MoveNext()
                    If estadoIterator.Current.Value <> "OK" Then
                        Return
                    End If
                End While
                Dim resultIterator As XPathNodeIterator = navigator.Select("/GeocodeResponse/result")
                While resultIterator.MoveNext()
                    Dim geometryIterator As XPathNodeIterator = resultIterator.Current.Select("geometry")
                    While geometryIterator.MoveNext()
                        Dim locationTypeIterator As XPathNodeIterator = geometryIterator.Current.Select("location_type")
                        While locationTypeIterator.MoveNext()
                            ' locationTypeIterator.Current.Value = "GEOMETRIC_CENTER" Or 
                            If locationTypeIterator.Current.Value = "APPROXIMATE" Then
                                p_detalleAGIP.Latitud = 0
                                p_detalleAGIP.Longitud = 0
                                Return
                            End If
                        End While
                        Dim locationIterator As XPathNodeIterator = geometryIterator.Current.Select("location")
                        While locationIterator.MoveNext()
                            Dim latIterator As XPathNodeIterator = locationIterator.Current.Select("lat")
                            Dim lngIterator As XPathNodeIterator = locationIterator.Current.Select("lng")
                            While latIterator.MoveNext()
                                Me.Latitud = Convert.ToDecimal(latIterator.Current.Value.ToString().Replace(".", ","))
                            End While
                            While lngIterator.MoveNext()
                                Me.Longitud = Convert.ToDecimal(lngIterator.Current.Value.ToString().Replace(".", ","))
                            End While
                        End While
                    End While
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class

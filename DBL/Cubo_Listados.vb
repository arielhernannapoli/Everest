Imports Framework
Public Class Cubo_Listados
    Inherits Entidad

    Dim oSoportes As Soportes
    Dim mId_Campania As Long
    Dim mId_Sistema As Long
    Dim mId_Ejercicio As Long
    Dim mId_Alternativa As Long
    Dim mTipo_Rating As String

    Property Id_Campania()
        Get
            Id_Campania = mId_Campania
        End Get
        Set(ByVal Value)
            mId_Campania = Value
        End Set
    End Property

    Property Id_Sistema()
        Get
            Id_Sistema = mId_Sistema
        End Get
        Set(ByVal Value)
            mId_Sistema = Value
        End Set
    End Property

    Property Id_Ejercicio()
        Get
            Id_Ejercicio = mId_Ejercicio
        End Get
        Set(ByVal Value)
            mId_Ejercicio = Value
        End Set
    End Property

    Property Id_Alternativa()
        Get
            Id_Alternativa = mId_Alternativa
        End Get
        Set(ByVal Value)
            mId_Alternativa = Value
        End Set
    End Property

    Property Tipo_Rating()
        Get
            Tipo_Rating = mTipo_Rating

        End Get
        Set(ByVal Value)
            mTipo_Rating = Value
        End Set
    End Property

    Public Sub New()
        MyBase.New("Cubo_Listados")
    End Sub

    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        ' Nada
    End Sub

    Public Function Cubo_Campania() As DataTable
        Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_CAMPANIA", Id_Campania).Tables(0)
    End Function

    Public Function Cubo_Sistema() As DataTable
        Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_SISTEMA", Id_Campania, Id_Sistema).Tables(0)
    End Function

    'Public Function Cubo_Ejercicio() As DataTable
    '    Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_EJERCICIO", Id_Campania, Id_Sistema, Id_Ejercicio, Tipo_Rating).Tables(0)
    'End Function

    Public Function Cubo_Alternativa() As DataTable
        Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_ALTERNATIVA", Id_Campania, Id_Alternativa).Tables(0)
    End Function

    Public Function Cubo_InversionExt() As DataTable
        Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_INVERSION_EXT", Me.Id_Campania, Me.Id_Alternativa).Tables(0)
    End Function

    Public Function Cubo_Inversion() As DataTable
        'AG 04/11/2010 --------------------------------------------------------------------------------------------------------------------------------
        Return ObtenerMaestrosMMS(Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_INVERSION", Me.Id_Campania, Me.Id_Alternativa).Tables(0))
        'Original ---------------------
        'Return Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_INVERSION", Me.Id_Campania, Me.Id_Alternativa).Tables(0)
        '---------------------------------------------------------------------------------------------------------------------------------------
    End Function

    Private Function ObtenerMaestrosMMS(ByVal DtBase As DataTable) As DataTable

        'AG 04/11/2010 Obtengo los maestros del mms para armar el dttable 
        Dim Rows() As DataRow
        Dim i As Integer
        Dim Length As Integer

        For Each r As DataRow In DtBase.Rows
            Rows = Activo.DTSoportesCache.Select("ID_MEDIO=" & r("ID_MEDIO") & " and " & "cod_tipo_soporte=" & r("ID_TIPO_SOPORTE") & " and " & "id_soporte=" & r("id_soporte"))
            For i = 0 To Rows.Length - 1
                r("RN_TIPO_SOPORTE") = Rows(i).Item("DES_TIPO_SOPORTE").ToString
                r("PN_SOPORTE") = Rows(i).Item("DESCRIPCION").ToString
                r("RN_PLAZA") = Rows(i).Item("DES_COBERTURA").ToString
            Next
        Next

        'Elimino las Columnas ID utilizadas para filtrar datos de mms y asi limpiar el dt
        DtBase.Columns.Remove("ID_MEDIO")
        DtBase.Columns.Remove("ID_TIPO_SOPORTE")
        DtBase.Columns.Remove("ID_PLAZA")
        DtBase.Columns.Remove("ID_SOPORTE")

        DtBase.AcceptChanges()
        Return DtBase

    End Function

#Region "DATOS MMS"

    ''*****************************************************************
    ''                    ACCESO A DATOS MMS 
    ''*****************************************************************
    '' Modified by daniel caime

    Public Function Cubo_Ejercicio() As DataTable
        Dim dt As DataTable
        oSoportes = New Soportes
        dt = Me.TraerDataSet("SPK_CUBO_LISTADOS.CUBO_EJERCICIO", Id_Campania, Id_Sistema, Id_Ejercicio, Tipo_Rating).Tables(0)
        For Each row As DataRow In dt.Rows
            oSoportes.Id_soporte = row.Item("id_soporte")
            oSoportes.Id_medio = row.Item("id_medio")
            row.Item("PN_SOPORTE") = oSoportes.ObtenerDescripcionXid()
        Next
        oSoportes = Nothing
        Return dt
    End Function
#End Region
End Class

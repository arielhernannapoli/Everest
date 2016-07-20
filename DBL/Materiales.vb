Imports MSL
Imports Framework

Public Class Materiales
    Inherits Entidad

    Dim oDatosMaestros As Maestros

#Region "Propiedades"
    Dim mId_material As String
    Dim mId_cliente As Int16
    Dim mId_producto As Int16
    Dim mDescripcion As String
    Dim mId_origen As Decimal
    Dim mDescripcion_origen As String
    Dim mDuracion As Int16
    Dim mDuracionMMS As String

    Private mid_medio As Integer

    Public Property id_medio() As Integer
        Get
            Return mid_medio
        End Get
        Set(ByVal value As Integer)
            mid_medio = value
        End Set
    End Property


    Public Property Id_material() As String
        Get
            Return mId_material
        End Get
        Set(ByVal Value As String)
            mId_material = Value
        End Set
    End Property

    Public Property Id_cliente() As Int16
        Get
            Return mId_cliente
        End Get
        Set(ByVal Value As Int16)
            mId_cliente = Value
        End Set
    End Property

    Public Property Id_producto() As Int16
        Get
            Return mId_producto
        End Get
        Set(ByVal Value As Int16)
            mId_producto = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property Id_origen() As Decimal
        Get
            Return mId_origen
        End Get
        Set(ByVal Value As Decimal)
            mId_origen = Value
        End Set
    End Property

    Public Property Descripcion_origen() As String
        Get
            Return mDescripcion_origen
        End Get
        Set(ByVal Value As String)
            mDescripcion_origen = Value
        End Set
    End Property

    Public Property Duracion() As Int16
        Get
            Return mDuracion
        End Get
        Set(ByVal Value As Int16)
            mDuracion = Value
        End Set
    End Property

    Public Property DuracionMMS() As String
        Get
            Return mDuracionMMS
        End Get
        Set(ByVal Value As String)
            mDuracionMMS = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Materiales")
    End Sub

    Public Overloads Function Agregar() As String
        'Aguzzardi -----------------------------------------------------------------------------------------------------------------
        Dim OMaestros As New Maestros
        Id_material = OMaestros.InsertarMateriales(Constantes.COD_PAIS_ARGENTINA, Id_cliente, id_medio, Id_producto, Id_material, Duracion, Descripcion)
        Return Id_material

        'MyBase.Agregar(Id_material, Id_cliente, Id_producto, Descripcion, Duracion)
        '------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Overloads Function Modificar() As String
        'Aguzzardi -----------------------------------------------------------------------------------------------------------------
        Dim OMaestros As New Maestros
        Id_material = OMaestros.ActualizarMaterial(Constantes.COD_PAIS_ARGENTINA, Id_cliente, id_medio, Id_producto, Id_material, Duracion, Descripcion)
        Return Id_material
        'MyBase.Modificar(Id_material, Id_cliente, Id_producto, Descripcion, Duracion)
        '------------------------------------------------------------------------------------------------------------------------------
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_material)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos()
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_material)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_material = IIf(IsDBNull(Dr("Id_material")), "", Dr("Id_material"))
        Me.Id_cliente = IIf(IsDBNull(Dr("Id_cliente")), 0, Dr("Id_cliente"))
        Me.Id_producto = IIf(IsDBNull(Dr("Id_producto")), 0, Dr("Id_producto"))
        Me.Descripcion = IIf(IsDBNull(Dr("Descripcion")), "", Dr("Descripcion"))
        'Me.Id_origen = IIf(IsDBNull(Dr("Id_origen")), 0, Dr("Id_origen"))
        'Me.Descripcion_origen = IIf(IsDBNull(Dr("Descripcion_origen")), "", Dr("Descripcion_origen"))
        Me.Duracion = IIf(IsDBNull(Dr("Duracion")), 0, Dr("Duracion"))
    End Sub

    Public Overloads Function EjecutarSQL(ByVal SQL As String) As DataSet
        Return MyBase.EjecutarSQL(SQL)
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

#Region "Funciones Propias"

    'Public Function TraerMateriales() As DataTable
    '    Return MyBase.TraerDataSet("spk_acceso_vistas.sp_materiales", Me.Id_cliente, Me.Id_producto).Tables(0)
    'End Function

    Public Function ExisteMaterial() As Boolean
        Return Convert.ToBoolean(MyBase.Ejecutar("spk_materiales.sp_select_id", Me.Id_material))
    End Function

    Private Function FormatDtMaterial(ByVal dtMateriales As DataTable) As DataTable
        Dim _idMedio As Integer
        Dim _dtReturn As DataTable = dtMateriales.Clone


        'AG TEMAS +++++++++++++++++++++++
        'If Not Activo.IsMaterialEjercicio Then
        '_idMedio = 1
        'Else
        _idMedio = Me.id_medio
        'End If
        '++++++++++++++++++++++++++++++

        Dim _descMedio As String = String.Empty
        Select Case _idMedio
            Case 1, 6
                Dim _rowsSelect As DataRow
                For Each _rowsSelect In dtMateriales.Select("Id_Medio = 1 or Id_medio = 6")
                    _dtReturn.ImportRow(_rowsSelect)
                Next
                If (_idMedio = 1) Then
                    _descMedio = " - TV"
                Else
                    _descMedio = " - RD"
                End If
                Exit Select
            Case 3
                Dim _rowsSelect As DataRow
                For Each _rowsSelect In dtMateriales.Select("Id_Medio = 3")
                    _dtReturn.ImportRow(_rowsSelect)
                Next
                _descMedio = " - VP"
                Exit Select
            Case 4
                Dim _rowsSelect As DataRow
                For Each _rowsSelect In dtMateriales.Select("Id_Medio = 4")
                    _dtReturn.ImportRow(_rowsSelect)
                Next
                _descMedio = " - PR"
                Exit Select
            Case 5
                Dim _rowsSelect As DataRow
                For Each _rowsSelect In dtMateriales.Select("Id_Medio = 5")
                    _dtReturn.ImportRow(_rowsSelect)
                Next
                _descMedio = " - RV"
                Exit Select
            Case 7 'AG Produccion +++++++++++++
                Dim _rowsSelect As DataRow
                For Each _rowsSelect In dtMateriales.Select("Id_Medio = 7")
                    _dtReturn.ImportRow(_rowsSelect)
                Next
                _descMedio = " - PRO"
                Exit Select
        End Select

        For index As Integer = 0 To _dtReturn.Rows.Count - 1
            Dim _desMaterial As String = _dtReturn.Rows.Item(index).Item("Descripcion")
            If _dtReturn.Rows.Item(index).Item("Id_Medio") = 1 Then
                _dtReturn.Rows.Item(index).Item("Descripcion") = (_desMaterial & " - TV")
            ElseIf _dtReturn.Rows.Item(index).Item("Id_Medio") = 6 Then
                _dtReturn.Rows.Item(index).Item("Descripcion") = (_desMaterial & " - RD")
            Else
                Select Case _idMedio
                    Case 3
                        _dtReturn.Rows.Item(index).Item("Descripcion") = (_desMaterial & _descMedio)
                        Exit Select
                    Case 5
                        _dtReturn.Rows.Item(index).Item("Descripcion") = (_desMaterial & _descMedio)
                        Exit Select
                    Case 4
                        _dtReturn.Rows.Item(index).Item("Descripcion") = (_desMaterial & _descMedio)
                        Exit Select
                End Select
            End If
        Next
        _dtReturn.AcceptChanges()
        Return _dtReturn
    End Function


#End Region

#Region "DATOS MMS"
    Public Function obtenerDescripcion(ByVal id_cliente As Integer, ByVal id_producto As Integer, ByVal id_material As Integer) As String
        oDatosMaestros = New Maestros
        Return oDatosMaestros.MaterialDescripcion(Constantes.COD_PAIS_ARGENTINA, id_cliente, id_material)
    End Function
    Public Function TraerMateriales() As DataTable
        Dim dt As DataTable
        oDatosMaestros = New Maestros
        dt = oDatosMaestros.MaterialesTraerMedio(Constantes.COD_PAIS_ARGENTINA, Id_cliente, Id_producto, id_medio)
        Return Me.FormatDtMaterial(dt)
    End Function

    Public Function TraerMaterial() As String

        Dim DtMateriales As DataTable
        Dim s As String
        oDatosMaestros = New Maestros
        DtMateriales = oDatosMaestros.TraerMaterial(Constantes.COD_PAIS_ARGENTINA, Id_cliente, CInt(Id_material))
        'MyBase.TraerUno("Spk_Acceso_vistas.sp_select_material", Me.Id_cliente, Me.Id_producto, Me.Id_material)
        If DtMateriales.Rows.Count > 0 Then
            mDuracionMMS = DtMateriales.Rows(0).Item("Duracion").ToString
        Else
            mDuracionMMS = ""
        End If
        Return mDuracionMMS
    End Function

    Public Function ObtenerMaterial(ByVal id_cliente As Integer, ByVal id_producto As Integer, ByVal id_medio As Integer, ByVal id_material As Integer) As String
        Dim DtMaterial As DataTable
        Dim Descripcion As String = ""
        Dim Rows() As DataRow

        oDatosMaestros = New Maestros
        DtMaterial = oDatosMaestros.MaterialesTraerMedio(Constantes.COD_PAIS_ARGENTINA, id_cliente, id_producto, id_medio)

        If DtMaterial.Rows.Count > 0 Then
            Rows = DtMaterial.Select("ID_MATERIAL=" & id_material)
            If Rows.Length > 0 Then
                Descripcion = Rows(0).Item("descripcion").ToString
            End If
        Else
            Descripcion = ""
        End If

        Return Descripcion
    End Function

    Public Function ExisteCodigoAfsca(ByVal codigoAFSCA As String, codigoMaterial As Integer) As Boolean
        Dim Existe As Boolean = False
        oDatosMaestros = New Maestros
        Existe = oDatosMaestros.ExisteCodigoAfsca(Constantes.COD_PAIS_ARGENTINA, codigoAFSCA, codigoMaterial)
        Return Existe
    End Function
    Public Function AgregarCodigoAfsca(ByVal codigoAFSCA As String, ByVal CodigoMaterial As Integer) As String
        Dim Descripcion As String = ""
        oDatosMaestros = New Maestros
        Descripcion = oDatosMaestros.AgregarCodigoAfsca(Constantes.COD_PAIS_ARGENTINA, codigoAFSCA, CodigoMaterial)
        Return Descripcion
    End Function
    Public Function SetNacionalExtranjeroFlag(ByVal esNacional As Boolean, ByVal CodigoMaterial As Integer) As String
        Dim Descripcion As String = ""
        oDatosMaestros = New Maestros
        Descripcion = oDatosMaestros.SetNacionalExtranjeroFlag(esNacional, CodigoMaterial)
        Return Descripcion
    End Function
    Public Function ExisteCodigoAfscaByMaterial(ByVal CodigoMaterial As Integer) As Boolean
        Dim Existe As Boolean = False
        oDatosMaestros = New Maestros
        Existe = oDatosMaestros.ExisteCodigoAfscaByMaterial(Constantes.COD_PAIS_ARGENTINA, CodigoMaterial)
        Return Existe
    End Function
    Public Function ActualizarCodigoAfsca(ByVal codigoAFSCA As String, ByVal CodigoMaterial As Integer) As String
        Dim Descripcion As String = ""
        oDatosMaestros = New Maestros
        Descripcion = oDatosMaestros.ActualizarCodigoAfsca(Constantes.COD_PAIS_ARGENTINA, codigoAFSCA, CodigoMaterial)
        Return Descripcion
    End Function

#End Region
End Class

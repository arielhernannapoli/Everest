Imports MSL
Imports Framework
Public Class Temas
    Inherits Entidad

    Dim oTemas As Maestros
#Region "Propiedades"
    Dim mId_campania As Int32
    Dim mId_tema As String
    Dim mId_producto As Int32
    Dim mId_material As String
    Dim mDuracion As Int32
    Dim mId_medio As Int32
    Private mId_cliente As Integer
    Dim mId_sistema As Integer

    Public Property id_cliente() As Integer
        Get
            Return mId_cliente = Activo.IDCliente
        End Get
        Set(ByVal value As Integer)
            mId_cliente = value
        End Set
    End Property


    Public Property Id_campania() As Int32
        Get
            Return mId_campania
        End Get
        Set(ByVal Value As Int32)
            mId_campania = Value
        End Set
    End Property

    Public Property Id_tema() As String
        Get
            Return mId_tema
        End Get
        Set(ByVal Value As String)
            mId_tema = Value
        End Set
    End Property

    Public Property Id_producto() As Int32
        Get
            Return mId_producto
        End Get
        Set(ByVal Value As Int32)
            mId_producto = Value
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

    Public Property Duracion() As Int32
        Get
            Return mDuracion
        End Get
        Set(ByVal Value As Int32)
            mDuracion = Value
        End Set
    End Property

    Public Property Id_medio() As Int32
        Get
            Return mId_medio
        End Get
        Set(ByVal Value As Int32)
            mId_medio = Value
        End Set
    End Property

    Public Property Id_sistema() As Int32
        Get
            Return mId_sistema
        End Get
        Set(ByVal Value As Int32)
            mId_sistema = Value
        End Set
    End Property
#End Region

#Region "Funciones Comunes"
    Sub New()
        MyBase.New("Temas")
    End Sub

    Public Overloads Function Agregar() As Object
        MyBase.Agregar(Id_campania, Id_tema, Id_producto, Id_material, Duracion)
    End Function

    Public Overloads Function Modificar() As Object
        MyBase.Modificar(Id_campania, Id_tema, Id_producto, Id_material, Duracion)
    End Function

    Public Overloads Function Borrar() As Integer
        MyBase.Borrar(Id_tema, Id_campania)
    End Function

    Public Overloads Function TraerTodos() As DataTable
        Return MyBase.TraerTodos(Me.Id_campania)
    End Function

    Public Overloads Sub BuscarPorID()
        MyBase.TraerUno("Spk_" & MyBase.Tabla & ".sp_select", Id_tema, Id_campania)
    End Sub

    Public Overloads Function TraerDataSet(ByVal Store As String, ByVal ParamArray Parametros() As Object) As DataSet
        Return MyBase.TraerDataSet(Store, Parametros)
    End Function

    Public Overloads Function TraerDataReader(ByVal Store As String, ByVal ParamArray Parametros() As Object) As OracleDataReader
        Return MyBase.TraerDataReader(Store, Parametros)
    End Function

    Protected Overrides Sub ArmarObjeto(ByVal Dr As IDataReader)
        Me.Id_campania = IIf(IsDBNull(Dr("Id_campania")), 0, Dr("Id_campania"))
        Me.Id_tema = IIf(IsDBNull(Dr("Id_tema")), "", Dr("Id_tema"))
        Me.Id_producto = IIf(IsDBNull(Dr("Id_producto")), 0, Dr("Id_producto"))
        Me.Id_material = IIf(IsDBNull(Dr("Id_material")), "", Dr("Id_material"))
        Me.Duracion = IIf(IsDBNull(Dr("Duracion")), 0, Dr("Duracion"))
        'Me.Id_medio = IIf(IsDBNull(Dr("Id_medio")), 0, Dr("Id_medio"))
    End Sub

    Public Overloads Sub ActualizarDataSet(ByVal Ds As DataSet, ByVal Tabla As String)
        MyBase.ActualizarDataSet(Ds, Tabla)
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
    'Public Function ObtenerTemasPorCampaña() As DataTable
    '    Return Me.TraerDataSet("spk_temas.sp_select_all", Me.Id_campania).Tables(0)
    'End Function

    Public Function ObtenerTemasPorCampaña_DS() As DataSet
        Return Me.TraerDataSet("spk_temas.sp_select_all", Me.Id_campania)
    End Function

    Public Sub BorrarTodos()
        Me.Ejecutar("spk_temas.sp_delete_all", Me.Id_campania)
    End Sub

    Public Function ObtenerTemasCampaña() As DataTable
        Return TraerDataSet("spk_temas.sp_select_todos", Me.Id_campania).Tables(0)
    End Function

    'Public Function ObtenerTemasExistentes(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As DataTable
    '    Return Me.TraerDataSet("spk_temas.sp_existe", pId_Campania, pId_Sistema, pId_Ejercicio).Tables(0)
    'End Function
#End Region

    ''*****************************************************************
    ''                    ACCESO A DATOS MMS
    ''*****************************************************************
    '' Modified by daniel caime

#Region "******************    DATOS MMS  ************************"
    ''traer datos de temas
    Public Function ObtenerTemasPorCampaña(Optional ByVal filtroSoporte As Boolean = False) As DataTable
        Dim dtbase As DataTable
        Dim dt As DataTable
        Dim dtTemas As DataTable
        oTemas = New Maestros
        Dim oProducto As Productos = New Productos
        dtbase = TraerDataSet("spk_temas.sp_select_all", Me.Id_campania).Tables(0)
        dtTemas = dtbase.Clone()
        Dim s As String
        Dim descMaterial As String
        Dim drAux, desAux As DataRow()
        Dim desProducto As String
        Dim medioMaterial As String

        For Each lRow As DataRow In dtbase.Rows

            drAux = Activo.DTProductosCache.Select("ID_PRODUCTO = " & lRow.Item("id_producto") & " and ID_CLIENTE = " & Activo.IDCliente)

            If drAux.Length = 1 Then
                desProducto = drAux(0)("DESCRIPCION").ToString()
            Else
                desProducto = oProducto.traerDescripcion(lRow.Item("id_producto"))
            End If

            lRow.Item("Producto") = desProducto

            desAux = Activo.DTMaterialesCache.Select("ID_MATERIAL = '" & lRow.Item("id_material") & "' AND ID_CLIENTE = " & Activo.IDCliente)

            If desAux.Length = 1 Then
                lRow.Item("Material") = desAux(0)("DESCRIPCION").ToString()
                medioMaterial = desAux(0)("ID_MEDIO").ToString()
            Else
                dt = oTemas.materialXidMaterial(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, lRow.Item("id_material"))
                If dt.Rows.Count = 0 Then
                    lRow.Item("Material") = "Sin Material"
                    medioMaterial = Activo.IDMedio   'AG 03/11/2015 BUG Arreglado
                Else
                    lRow.Item("Material") = dt.Rows(0).Item("descripcion")
                    medioMaterial = dt.Rows(0).Item("ID_MEDIO")
                End If
            End If
            


            lRow.Item("tema") = lRow.Item("id_tema") & " - " & lRow.Item("producto") & " - " & lRow.Item("material") & " - " & lRow.Item("duracion")
            ''volver a setear la descripcion del tema - OK

            If medioMaterial = Activo.IDMedio Then
                dtTemas.ImportRow(lRow)
            End If
        Next

        If Not filtroSoporte Then
            Return dtbase
        Else
            Return dtTemas
        End If

    End Function

    Public Function ObtenerTemasExistentes(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As DataTable
        Dim dtbase As DataTable
        Dim dt As DataTable
        oTemas = New Maestros
        Dim oProducto As Productos = New Productos
        Dim drAux, desAux As DataRow()
        Dim desProducto, desMaterial As String

        dtbase = Me.TraerDataSet("spk_temas.sp_existe", pId_Campania, pId_Sistema, pId_Ejercicio).Tables(0)

        For Each lRow As DataRow In dtbase.Rows
            drAux = Activo.DTProductosCache.Select("ID_PRODUCTO = " & lRow.Item("id_producto") & " and ID_CLIENTE = " & Activo.IDCliente)

            If drAux.Length = 1 Then
                desProducto = drAux(0)("DESCRIPCION").ToString()
            Else
                desProducto = oProducto.traerDescripcion(lRow.Item("id_producto"))
            End If
            lRow.Item("Producto") = desProducto

            desAux = Activo.DTMaterialesCache.Select("ID_MATERIAL = " & lRow.Item("id_material") & " AND ID_CLIENTE = " & Activo.IDCliente)

            If desAux.Length = 1 Then
                desMaterial = desAux(0)("DESCRIPCION").ToString()
            Else
                dt = oTemas.materialXidMaterial(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, lRow.Item("id_material"))
                If dt.Rows.Count = 0 Then
                    desMaterial = "Sin Material"
                Else
                    desMaterial = dt.Rows(0).Item("descripcion")
                End If
            End If
            lRow.Item("Material") = desMaterial

            lRow.Item("tema") = lRow.Item("id_tema") & " - " & lRow.Item("producto") & " - " & lRow.Item("material") & " - " & lRow.Item("duracion")
        Next

        Return dtbase

    End Function

    'JJP 20101001 - OLD CODE
    'Public Function ObtenerTemasExistentes(ByVal pId_Campania As Integer, ByVal pId_Sistema As Integer, ByVal pId_Ejercicio As Integer) As DataTable
    '    Dim dtbase As DataTable
    '    Dim dt As DataTable
    '    oTemas = New Maestros
    '    Dim oProducto As Productos = New Productos

    '    dtbase = Me.TraerDataSet("spk_temas.sp_existe", pId_Campania, pId_Sistema, pId_Ejercicio).Tables(0)

    '    For Each lRow As DataRow In dtbase.Rows
    '        lRow.Item("Producto") = oProducto.traerDescripcion(lRow.Item("id_producto"))
    '        dt = oTemas.materialXidMaterial(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, lRow.Item("id_material"))
    '        lRow.Item("Material") = dt.Rows(0).Item("descripcion")
    '        lRow.Item("tema") = lRow.Item("id_tema") & " - " & lRow.Item("producto") & " - " & lRow.Item("material") & " - " & lRow.Item("duracion")
    '    Next

    '    Return dtbase

    'End Function

    Public Function ObtenerTemasCampañaDistribuidor(ByVal idCampania As Integer) As DataTable
        Dim dtbase As DataTable
        Dim dtTemas As DataTable
        Dim dt As DataTable
        Dim drAux, desAux As DataRow()
        Dim medioMaterial As String
        oTemas = New Maestros
        dtbase = TraerDataSet("spk_temas.SP_TEMAS_DISTRIBUIDOR", idCampania).Tables(0)
        dtTemas = dtbase.Clone()

        For Each lRow As DataRow In dtbase.Rows
            desAux = Activo.DTMaterialesCache.Select("ID_MATERIAL = '" & lRow.Item("id_material") & "' AND ID_CLIENTE = " & Activo.IDCliente)

            If desAux.Length = 1 Then                
                medioMaterial = desAux(0)("ID_MEDIO").ToString()
            Else
                dt = oTemas.materialXidMaterial(Constantes.COD_PAIS_ARGENTINA, Activo.IDCliente, lRow.Item("id_material"))
                If dt.Rows.Count > 0 Then
                    medioMaterial = dt.Rows(0).Item("ID_MEDIO")
                Else
                    medioMaterial = -1
                End If
            End If

            If medioMaterial = Activo.IDMedio Then
                dtTemas.ImportRow(lRow)
            End If
        Next

        Return dtTemas.DefaultView.ToTable(False, "TEMA", "PORCENTAJE", "DURACION")
    End Function

#End Region

End Class


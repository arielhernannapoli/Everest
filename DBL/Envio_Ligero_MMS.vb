' NUEVO DESARROLLO DE ENVIO A COMPRAS LIGERO (AN 27-08-2015)

Imports System.Collections.Generic

Public Class Envio_Ligero_MMS
    Inherits Entidad

#Region " Constantes "
    Const CONST_PKG_ENVIO_LIGERO_MMS As String = "SPK_ENVIO_LIGERO_MMS"
    Const CONST_SP_ENVIO_CABECERA_MMS As String = "SP_ENVIO_CABECERA_MMS"
    Const CONST_SP_TOTAL_SOPORTES_PA_TV As String = "SP_TOTAL_SOPORTES_PA_TV"
    Const CONST_SP_GET_AVISOS_DIFERENCIAS As String = "SP_GET_AVISOS_DIFERENCIAS"
    Const CONST_SP_GET_RELACION_PROVEEDORES As String = "SP_GET_RELACION_PROVEEDORES"
#End Region

#Region " Propiedades "
    'Propiedades
    Private _dtParametros As DataTable
    Public Property DtParametros() As DataTable
        Get
            Return _dtParametros
        End Get
        Set(ByVal value As DataTable)
            _dtParametros = value
        End Set
    End Property


    Private _codCompaniaMms As Integer
    Public Property CodCompaniaMMS() As Integer
        Get
            Return _codCompaniaMms
        End Get
        Set(ByVal value As Integer)
            _codCompaniaMms = value
        End Set
    End Property


    Private _codCliente As Integer
    Public Property CodCliente() As Integer
        Get
            Return _codCliente
        End Get
        Set(ByVal value As Integer)
            _codCliente = value
        End Set
    End Property


    Private _codUsuario As Integer
    Public Property CodUsuario() As Integer
        Get
            Return _codUsuario
        End Get
        Set(ByVal value As Integer)
            _codUsuario = value
        End Set
    End Property


    Private _codCampaniaMMS As Integer
    Public Property CodCampaniaMMS() As Integer
        Get
            Return _codCampaniaMMS
        End Get
        Set(ByVal value As Integer)
            _codCampaniaMMS = value
        End Set
    End Property


    Private _codSubcampaniaMMS As Integer
    Public Property CodSubcampaniaMMS() As Integer
        Get
            Return _codSubcampaniaMMS
        End Get
        Set(ByVal value As Integer)
            _codSubcampaniaMMS = value
        End Set
    End Property


    Private _mesPresupuestos As String
    Public Property MesPresupuestos() As String
        Get
            Return _mesPresupuestos
        End Get
        Set(ByVal value As String)
            _mesPresupuestos = value
        End Set
    End Property


    Private _anioPresupuestos As String
    Public Property AnioPresupuestos() As String
        Get
            Return _anioPresupuestos
        End Get
        Set(ByVal value As String)
            _anioPresupuestos = value
        End Set
    End Property


    Private _codigoPresupuestos As String
    Public Property CodigoPresupuestos() As String
        Get
            Return _codigoPresupuestos
        End Get
        Set(ByVal value As String)
            _codigoPresupuestos = value
        End Set
    End Property


#End Region

#Region " Constructores "
    ' Constructor vacio
    Sub New()
        MyBase.New("Envio_Ligero_MMS")
    End Sub

    'Este constructor se usa para cargar por defecto los valores necesarios para el procesamiento.
    Sub New(ByVal _dtParametros As DataTable, ByVal _codCompaniaMMS As Integer, ByVal _codClienteMMS As Integer, ByVal _codUsuarioMMS As Integer, ByVal _codCampaniaMMS As Integer, ByVal _codSubcampaniaMMS As Integer, ByVal _mesPresupuestos As String, ByVal _anioPresupuestos As String, ByVal _codigoPresupuestos As String)
        MyBase.New("Envio_Ligero_MMS")
        Me.DtParametros = _dtParametros
        Me.CodCompaniaMMS = _codCompaniaMMS
        Me.CodCliente = _codClienteMMS
        Me.CodUsuario = _codUsuarioMMS
        Me.CodCampaniaMMS = _codCampaniaMMS
        Me.CodSubcampaniaMMS = _codSubcampaniaMMS
        Me.MesPresupuestos = _mesPresupuestos
        Me.AnioPresupuestos = _anioPresupuestos
        Me.CodigoPresupuestos = _codigoPresupuestos
    End Sub
#End Region

#Region " Metodos "
    Protected Overrides Sub ArmarObjeto(ByVal dr As System.Data.IDataReader)
        ' no se usa
    End Sub

    Function Envio_Cabecera_MMS_TV() As Integer        
        Dim contador As Integer = 0

        ' Orden de parametros para procedure oracle:
        ' p_COD_CAMPANIA_EVE
        ' p_COD_SISTEMA_EVE
        ' p_COD_EJERCICIO_EVE
        ' p_COD_MEDIO_EVE
        ' p_COD_PRODUCTO_EVE
        ' p_COD_SOPORTE_EVE
        ' p_TEMA_EVE
        ' p_F_DESDE_EVE
        ' p_F_HASTA_EVE
        ' p_MES_PRESUPUESTO
        ' p_ANIO_PRESUPUESTO
        ' p_COD_COMPANIA_MMS 
        ' p_COD_SUBCAMPANA_MMS
        ' p_COD_CAMPANA_MMS
        ' p_COD_PRESUPUESTO_MMS
        ' p_COD_CLIENTE_MMS
        ' p_COD_USUARIO_MMS

        Dim DistintoDtParametros As New DataTable
        DistintoDtParametros = DtParametros.Clone

        DistintoDtParametros = DtParametros.DefaultView.ToTable(True, "CAMPANIA", "SISTEMA", "EJERCICIO", "MEDIO", "PRODUCTO", "FECHADESDE", "FECHAHASTA", "TEMA", "SOPORTE", "MES", "ANIO", "MESPRESUPUESTO", "PRESUPUESTO")

        For Each parametro As DataRow In DistintoDtParametros.Rows
            Dim retorno As Object = Me.TraerValor(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_ENVIO_CABECERA_MMS), parametro("CAMPANIA"), parametro("SISTEMA"), parametro("EJERCICIO"), parametro("MEDIO"), parametro("PRODUCTO"), parametro("SOPORTE"), parametro("TEMA"), CDate(parametro("FECHADESDE")), CDate(parametro("FECHAHASTA")), parametro("MESPRESUPUESTO"), parametro("ANIO"), Me.CodCompaniaMMS, Me.CodSubcampaniaMMS, Me.CodCampaniaMMS, parametro("PRESUPUESTO"), Me.CodCliente, Me.CodUsuario)
            If retorno Is Nothing Then
                contador = contador + 0
            Else
                contador = contador + Convert.ToInt32(retorno)
            End If
        Next


        Return contador
    End Function

    Function Envio_Cabecera_MMS_Internet() As DataTable
        Dim contratos As New DataTable

        ' Orden de parametros para procedure oracle:
        ' p_COD_CAMPANIA_EVE
        ' p_COD_SISTEMA_EVE
        ' p_COD_EJERCICIO_EVE
        ' p_COD_MEDIO_EVE
        ' p_COD_PRODUCTO_EVE
        ' p_COD_SOPORTE_EVE
        ' p_TEMA_EVE
        ' p_F_DESDE_EVE
        ' p_F_HASTA_EVE
        ' p_MES_PRESUPUESTO
        ' p_ANIO_PRESUPUESTO
        ' p_COD_COMPANIA_MMS 
        ' p_COD_SUBCAMPANA_MMS
        ' p_COD_CAMPANA_MMS
        ' p_COD_PRESUPUESTO_MMS
        ' p_COD_CLIENTE_MMS
        ' p_COD_USUARIO_MMS

        Dim DistintoDtParametros As New DataTable
        DistintoDtParametros = DtParametros.Clone
        DistintoDtParametros = DtParametros.DefaultView.ToTable(True, "CAMPANIA", "SISTEMA", "EJERCICIO", "MEDIO", "PRODUCTO", "FECHADESDE", "FECHAHASTA", "TEMA", "SOPORTE", "MES", "ANIO", "MESPRESUPUESTO", "PRESUPUESTO")

        For Each parametro As DataRow In DistintoDtParametros.Rows
            Dim retorno As DataSet = Me.TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_ENVIO_CABECERA_MMS), parametro("CAMPANIA"), parametro("SISTEMA"), parametro("EJERCICIO"), parametro("MEDIO"), parametro("PRODUCTO"), parametro("SOPORTE"), parametro("TEMA"), parametro("FECHADESDE"), parametro("FECHAHASTA"), MesPresupuestos, AnioPresupuestos, Me.CodCompaniaMMS, Me.CodSubcampaniaMMS, Me.CodCampaniaMMS, CodigoPresupuestos, Me.CodCliente, Me.CodUsuario)
            If Not retorno Is Nothing And retorno.Tables.Count > 0 Then
                If contratos.Rows.Count = 0 Then
                    contratos = retorno.Tables(0).Copy()
                Else
                    For Each row As DataRow In retorno.Tables(0).Rows
                        contratos.ImportRow(row)
                    Next
                End If
            End If
        Next
        Return contratos
    End Function

    Function Obtener_Total_Soportes_PA_TV(ByVal cod_campania As Integer, ByVal cod_sistema As Integer, ByVal cod_ejercicio As Integer, ByVal cod_producto As Integer, ByVal cod_soporte As Integer, ByVal tema As String, ByVal fechadesde As String, ByVal fechahasta As String, ByVal mes As Integer, ByVal anio As Integer, ByVal cod_compania As Integer, ByVal cod_subcampania_mms As Integer, ByVal cod_campania_mms As Integer, ByVal cod_presupuesto As Integer) As DataTable
        ' Orden de parametros para procedure oracle:
        ' p_COD_CAMPANIA_EVE
        ' p_COD_SISTEMA_EVE
        ' p_COD_EJERCICIO_EVE
        ' p_COD_MEDIO_EVE
        ' p_COD_PRODUCTO_EVE
        ' p_COD_SOPORTE_EVE
        ' p_TEMA_EVE
        ' p_F_DESDE_EVE
        ' p_F_HASTA_EVE
        ' p_MES_PRESUPUESTO
        ' p_ANIO_PRESUPUESTO-
        ' p_COD_COMPANIA_MMS 
        ' p_COD_SUBCAMPANA_MMS
        ' p_COD_CAMPANA_MMS
        ' p_COD_PRESUPUESTO_MMS

        Dim retorno As DataSet = Me.TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_TOTAL_SOPORTES_PA_TV), cod_campania, cod_sistema, cod_ejercicio, cod_producto, cod_soporte, tema, fechadesde, fechahasta, mes, anio, cod_compania, cod_subcampania_mms, cod_campania_mms, cod_presupuesto)

        If Not retorno Is Nothing Then
            Return retorno.Tables(0)
        End If
    End Function

    'AN 22/02/2016 NUEVA FUNCION QUE OBTIENE LOS AVISOS CON DIFERENCIA EN IMPORTES COMPRA VENTA PARA TV
    Function Obtener_Avisos_Con_Diferencias(ByVal dtFiltros As DataTable) As DataTable
        Dim avisos As DataTable = Nothing
        For Each parametro As DataRow In dtFiltros.Rows
            Dim data As DataSet = TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_GET_AVISOS_DIFERENCIAS), parametro("CAMPANIA"), parametro("SISTEMA"), parametro("EJERCICIO"), parametro("PRODUCTO"), parametro("SOPORTE"), parametro("TEMA"), Convert.ToDateTime(parametro("FECHADESDE")), Convert.ToDateTime(parametro("FECHAHASTA")), parametro("MESPRESUPUESTO"), parametro("ANIO"))
            If avisos Is Nothing Then
                avisos = data.Tables(0).Clone()
            End If
            For Each aviso As DataRow In data.Tables(0).Rows
                avisos.Rows.Add(aviso.ItemArray)
            Next
        Next
        Return avisos
    End Function

    'AN 08/03/2016 NUEVA FUNCION QUE OBTIENE LOS PROVEEDORES PARA ENVIO DOBLE DE INTERNET
    Function Obtener_Relacion_Proveedores() As List(Of String)
        Dim data As DataSet = TraerDataSet(String.Format("{0}.{1}", CONST_PKG_ENVIO_LIGERO_MMS, CONST_SP_GET_RELACION_PROVEEDORES))
        If data.Tables.Count > 0 Then
            Return data.Tables(0).Rows.Cast(Of DataRow)().Select(Function(dr) dr(0).ToString()).ToList()
        End If
        Return New List(Of String)
    End Function

#End Region

    ' TFS
End Class

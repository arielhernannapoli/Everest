Public Class frmFiltrarPadronAGIP
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
#End Region

    Dim mDetalleAGIP As Detalle_AGIP
    Dim mCancelado As Boolean
    Dim dtDetalleAGIP As DataTable


#Region "Propiedades"

    Public Property DetalleAGIP() As Detalle_AGIP
        Get
            If mDetalleAGIP Is Nothing Then
                mDetalleAGIP = New Detalle_AGIP
            End If
            Return mDetalleAGIP
        End Get
        Set(ByVal value As Detalle_AGIP)
            mDetalleAGIP = value
        End Set
    End Property

    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal Value As Boolean)
            mCancelado = Value
        End Set
    End Property
#End Region

    Private Sub frmFiltarPadronAGIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim padronAGIP As New Padron_AGIP
        Dim dtPadronAGIP As DataTable

        Me.marqueeCarga.Enabled = False
        dtPadronAGIP = padronAGIP.ObtenerUltimo()
        dtDetalleAGIP = Me.DetalleAGIP.ObtenerPorCUIT(Convert.ToInt32(dtPadronAGIP.Rows(0).Item(0)), Me.DetalleAGIP.CUIT)
        CargarGrid(dtDetalleAGIP)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cancelado = True
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim dr As DataRow
        If grdBuscar.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In grdBuscar.Selected.Rows()
            dr = dtDetalleAGIP.Select("ID_DETALLE = " & fila.Cells("ID_DETALLE").Value)(0)
        Next
        Me.DetalleAGIP.CodigoAGIP = dr.Item(11).ToString()
        Me.DetalleAGIP.Direccion = dr.Item(9).ToString()
        Me.DetalleAGIP.Altura = dr.Item(10).ToString()
        HabilitarControles(False, "Obteniendo coordenadas...")
        BackgroundWorker1.RunWorkerAsync()
        Me.Close()
    End Sub

    Private Sub CargarGrid(ByVal dt As DataTable)
        grdBuscar.DataSource = dt
        dt.Columns.Add("Tipo y Caracteristica", GetType(String), "[Tipo] + ' ' + [Caracteristica]")
        dt.Columns.Add("Direccion Completa", GetType(String), "[Direccion] + ' N° ' + [Altura]")
        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False

        grdBuscar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        grdBuscar.DisplayLayout.Bands(0).ColHeadersVisible = False
        grdBuscar.DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
        grdBuscar.DisplayLayout.Bands(0).Columns(0).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(1).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(2).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(3).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(5).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(6).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(7).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(8).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(9).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(10).Hidden = True
        grdBuscar.DisplayLayout.Bands(0).Columns(11).Hidden = True
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Dim Filtro As String

        Dim Texto As String = txtBuscar.Text
        Texto = Texto.Replace("'", "''")
        Filtro = "DIRECCION like '%" & Texto & "%'"

        'filtra y asigna el data table al source de la grilla
        Me.grdBuscar.DataSource = Me.FiltrarDT(dtDetalleAGIP, Filtro, "DIRECCION ASC")
    End Sub

    Private Function FiltrarDT(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Orden As String) As DataTable
        'devuelve un data table filtrado y ordenado por los parametros que se pasan
        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()
        Filas = Dt.Select(Filtro, Orden)

        For Each Dr As DataRow In Filas
            DtNuevo.ImportRow(Dr)
        Next
        Return DtNuevo
    End Function

    Private Sub HabilitarControles(ByVal habilitado As Boolean, ByVal accion As String)
        marqueeCarga.Enabled = Not habilitado
        marqueeCarga.Text = accion
        marqueeCarga.Properties.ShowTitle = Not habilitado
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.DetalleAGIP.Localidad = "Capital Federal"
        Me.DetalleAGIP.GuardarCoordenadas()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HabilitarControles(True, String.Empty)
    End Sub
End Class
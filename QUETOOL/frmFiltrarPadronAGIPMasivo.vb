Imports Framework.Mensajes
Imports System.Collections.Generic

Public Class frmFiltrarPadronAGIPMasivo
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
    Dim mCodigoAGIP As String
    Dim mCancelado As Boolean
    Dim dtDetalleAGIP As DataTable
    Dim lstDetalleAGIP As New List(Of Detalle_AGIP)
    Dim mCodigosAGIPAnteriores As String


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

    Public Property CodigoAGIP() As String
        Get
            Return mCodigoAGIP
        End Get
        Set(ByVal Value As String)
            mCodigoAGIP = Value
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

    Public Property CodigosAGIPAnteriores() As String
        Get
            Return mCodigosAGIPAnteriores
        End Get
        Set(ByVal Value As String)
            mCodigosAGIPAnteriores = Value
        End Set
    End Property
#End Region

    Private Sub frmFiltarPadronAGIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim padronAGIP As New Padron_AGIP
        Dim dtPadronAGIP As DataTable
        Me.txtCodigosAGIP.Text = Me.CodigosAGIPAnteriores.Replace(" ", vbNewLine)
        Me.cmdAceptar.Focus()
        Me.marqueeCarga.Enabled = False
        dtPadronAGIP = padronAGIP.ObtenerUltimo()
        dtDetalleAGIP = Me.DetalleAGIP.ObtenerPorCUIT(Convert.ToInt32(dtPadronAGIP.Rows(0).Item(0)), Me.DetalleAGIP.CUIT)
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Cancelado = True
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim validar As String
        If txtCodigosAGIP.Text <> String.Empty Then
            If dtDetalleAGIP.Rows.Count > 0 Then
                validar = ValidarCodigos()
            Else
                Me.CodigoAGIP = txtCodigosAGIP.Text
            End If
            If validar = String.Empty Then
                Me.Close()
            Else
                Mensaje("Códigos AGIP no validos para el proveedor. Codigo: " & validar, TipoMensaje.Informacion)
            End If
        End If
    End Sub

    Private Function ValidarCodigos() As String
        Dim codigos() As String
        Dim codigoErroneo As String = String.Empty
        codigos = Me.txtCodigosAGIP.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        If codigos.Length > 0 Then
            For i As Integer = 0 To codigos.Length - 1
                Try
                    Dim dr As DataRow
                    Dim detalle As New Detalle_AGIP
                    If dtDetalleAGIP.Select("CODIGOAGIP = '" & codigos(i).Trim() & "'").Length > 0 Then
                        dr = dtDetalleAGIP.Select("CODIGOAGIP = '" & codigos(i).Trim() & "'")(0)
                        Me.CodigoAGIP += dr.Item(11).ToString() & " "
                        Me.DetalleAGIP.CodigoAGIP = dr.Item(11).ToString()
                        Me.DetalleAGIP.Direccion = dr.Item(9).ToString()
                        Me.DetalleAGIP.Altura = dr.Item(10).ToString()
                        detalle.CodigoAGIP = dr.Item(11).ToString()
                        detalle.Direccion = Me.DetalleAGIP.Direccion
                        detalle.Altura = Me.DetalleAGIP.Altura
                        lstDetalleAGIP.Add(detalle)
                    Else
                        codigoErroneo = codigos(i)
                        Return codigoErroneo
                    End If
                Catch ex As Exception
                    codigoErroneo = codigos(i)
                    Return codigoErroneo
                End Try
            Next
        End If
        HabilitarControles(False, "Obteniendo coordenadas...")
        BackgroundWorker1.RunWorkerAsync()
        Return codigoErroneo
    End Function

    Private Sub HabilitarControles(ByVal habilitado As Boolean, ByVal accion As String)
        marqueeCarga.Enabled = Not habilitado
        marqueeCarga.Text = accion
        marqueeCarga.Properties.ShowTitle = Not habilitado
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For Each detalle As Detalle_AGIP In lstDetalleAGIP
            detalle.Localidad = "Capital Federal"
            detalle.GuardarCoordenadas()
        Next
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HabilitarControles(True, String.Empty)
    End Sub
End Class
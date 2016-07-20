Imports Framework.Mensajes

Public Class frmSeleccionarTConvRentabilidad

#Region "DECLARACION De Variables"

    Dim mTRentabilidad As Integer
    Dim mTRentabilidadAnterior As Integer = -1
    Dim mTRentabilidadNueva As Integer
    Dim MensajeSeleccionFCProveedor As String = " Seguro desea realizar el cambio de " & vbCrLf & " NC PROVEEDOR a FC PROVEEDOR?  "
    Dim MensajeSeleccionNCProveedor As String = " Seguro desea realizar el cambio de " & vbCrLf & " FC PROVEEDOR a NC PROVEEDOR?  "

#End Region

#Region "DECLARACION de Propiedades"

    Public Property TRentabilidad() As Integer
        Get
            Return mTRentabilidad
        End Get
        Set(ByVal Value As Integer)
            mTRentabilidad = Value
        End Set
    End Property

    Public Property TRentabilidadAnterior() As Integer
        Get
            Return mTRentabilidadAnterior
        End Get
        Set(ByVal Value As Integer)
            mTRentabilidadAnterior = Value
        End Set
    End Property

#End Region

#Region "DECLARACION De Enums"

    Public Enum TipoRentabilidad As Integer 'AG TC
        RentabilidadNula = -1
        RentabilidadNC = 0 ' Por defector
        RentabilidadFProveedor = 1
    End Enum

#End Region

#Region "DECLARACION De Eventos"

    Private Sub frmSeleccionarTConvRentabilidad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If RBnc.Checked = True And RBfpro.Checked = False Then
            TRentabilidad = TipoRentabilidad.RentabilidadNC
        ElseIf Me.RBfpro.Checked = True And RBnc.Checked = False Then
            TRentabilidad = TipoRentabilidad.RentabilidadFProveedor
        End If
        frmMantenimientoConvenio.Instancia.TRentabilidad = TRentabilidad
    End Sub

    Private Sub frmSeleccionarTConvRentabilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.mTRentabilidadAnterior = TipoRentabilidad.RentabilidadNula Then
            ConfigurarControles()
        ElseIf Me.mTRentabilidadAnterior = TipoRentabilidad.RentabilidadNC Then
            ConfigurarControles()
        ElseIf Me.mTRentabilidadAnterior = TipoRentabilidad.RentabilidadFProveedor Then
            Me.RBnc.Checked = False
            Me.RBfpro.Checked = True
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If mTRentabilidadAnterior <> TRentabilidad Then
            If RBnc.Checked = True And RBfpro.Checked = False Then
                If Mensaje(MensajeSeleccionNCProveedor, TipoMensaje.SiNo) = DialogResult.Yes Then
                    TRentabilidad = TipoRentabilidad.RentabilidadNC
                End If
            ElseIf Me.RBfpro.Checked = True And RBnc.Checked = False Then
                If Mensaje(MensajeSeleccionFCProveedor, TipoMensaje.SiNo) = DialogResult.Yes Then
                    TRentabilidad = TipoRentabilidad.RentabilidadFProveedor
                End If
            End If
        Else
            If RBnc.Checked = True And RBfpro.Checked = False Then
                TRentabilidad = TipoRentabilidad.RentabilidadNC
            ElseIf Me.RBfpro.Checked = True And RBnc.Checked = False Then
                TRentabilidad = TipoRentabilidad.RentabilidadFProveedor
            End If
        End If

        Me.Close()
    End Sub

    Private Sub RBnc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBnc.Click
        TRentabilidad = TipoRentabilidad.RentabilidadNC
    End Sub

    Private Sub RBfpro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBfpro.Click
        TRentabilidad = TipoRentabilidad.RentabilidadFProveedor
    End Sub

#End Region

#Region "DECLARACION De Funciones"

    Private Sub ConfigurarControles()
        Me.RBnc.Checked = True
        Me.RBfpro.Checked = False
    End Sub

#End Region
   
End Class
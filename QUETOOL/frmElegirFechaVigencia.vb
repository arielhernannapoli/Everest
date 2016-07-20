Public Class frmElegirFechaVigencia
    Inherits System.Windows.Forms.Form


    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean

    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Cancelar = False
        Me.Hide()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True

        Me.Close()
    End Sub
    Private Sub frmElegirFechaVigencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaDesde.DateTime = Now.Date
        dtpFechaHasta.DateTime = Now.Date
        If CargandoPrimeraVez Then
            cmdCancelar.Visible = False

            cmdAceptar.Left = cmdCancelar.Left
            cmdAceptar.Top = cmdCancelar.Top
        End If
    End Sub
End Class
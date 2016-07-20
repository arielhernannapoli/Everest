

Public Class frmreporteRegionalCotizadorDolar

    Public ValorDolar As Double

    Private Sub txtvalordolar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalordolar.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        If Me.txtvalordolar.Text <> "" Then
            If Not IsNumeric(Me.txtvalordolar.Text) Then
                MsgBox("Debe Ingresar un Importe Numerico ", MsgBoxStyle.Information, "Reporte Regional")
                Me.txtvalordolar.Text = ""
                Me.txtvalordolar.Focus()
            Else
                ValorDolar = Math.Round(Double.Parse(Me.txtvalordolar.Text.ToString), 2)
                Me.Close()
            End If
        Else
            MsgBox("Debe Ingresar un Importe Numerico ", MsgBoxStyle.Information, "Reporte Regional")
        End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click

        ValorDolar = 0

        'If Me.txtvalordolar.Text = "" Then
        '    ValorDolar = 0
        'Else
        '    If Not IsNumeric(Me.txtvalordolar.Text) Then
        '        MsgBox("Debe Ingresar un Importe Numerico ", MsgBoxStyle.Information, "Reporte Regional")
        '        Me.txtvalordolar.Text = ""
        '        Me.txtvalordolar.Focus()
        '        Exit Sub
        '    End If
        'End If

        Me.Close()
    End Sub
End Class
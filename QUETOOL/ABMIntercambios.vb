Public Class ABMIntercambios

    Dim FInicio As Date
    Dim FFin As Date
    Dim Descripcion As String
    Dim importe As Double
    Dim OpreacionInsertada As Boolean

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim OEnvioCompras As New Envio_Compras

        If Validar() = False Then
            Exit Sub
        Else
            If Me.txtDescripcion.Text = "" Then
                Mensajes.Mensaje("Debe ingresar la descripcion del nuevo Intercambio")
                Exit Sub
            End If

            If Me.txtDescripcion.Text.Length > 30 Then
                Mensajes.Mensaje("La descripcion debe contener menos de 30 Caracteres")
                Exit Sub
            End If

            If Me.txtImporte.Text <> "" Then
                If Not IsNumeric(Me.txtImporte.Text) Then
                    MsgBox("Debe Ingresar un Importe Numerico, para campo Importe ", MsgBoxStyle.Information, "Intercambio")
                    Me.txtImporte.Focus()
                    Exit Sub
                Else
                    importe = Math.Round(Double.Parse(Me.txtImporte.Text.ToString), 3)
                End If
            Else
                importe = 0
            End If

            Descripcion = txtDescripcion.Text.Trim

            FInicio = Me.dtpFInicio.Value
            FFin = Me.dtpFFin.Value

            OEnvioCompras.InsertarIntercambio(CInt(Activo.CodPaisMms), CInt(Activo.CodCampaniaActualMms), CInt(Activo.IDCliente), Descripcion, importe, FInicio, FFin)

            MsgBox("Se creo satisfactoriamente el intercambio " + vbCrLf + Me.txtDescripcion.Text.ToUpper + ".       ", MsgBoxStyle.Information, "Intercambio")

            OpreacionInsertada = True

        End If
    End Sub

    Private Function Validar() As Boolean

        'si la fecha de inicio es mayor a la fecha de fin
        If Me.dtpFInicio.Value > Me.dtpFFin.Value Then
            Mensajes.Mensaje("La Fecha de Inicio No Puede ser Mayor a la Fecha de Fin")
            Me.dtpFInicio.Select()
            Return False
        End If

        If Me.dtpFFin.Value < Me.dtpFInicio.Value Then
            Mensajes.Mensaje("La Fecha de Fin No Puede ser Menor a la Fecha de Inicio")
            Me.dtpFInicio.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        If OpreacionInsertada = True Then
            frmBuscarIntercambio.Instancia.BuscarNuevo = True
        Else
            frmBuscarIntercambio.Instancia.BuscarNuevo = False
        End If

        Me.Close()
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        End If
    End Sub

End Class
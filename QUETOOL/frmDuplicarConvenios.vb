Public Class frmDuplicarConvenios

    Dim FDesde As Date
    Dim FHasta As Date
    Dim ErrorDatos As Integer

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click
        BuscarClienteOrigen()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim TipoError As Integer
        Dim OConvenio As New Convenios
        Dim DtConvenios As New DataTable
        Dim DtConveniosExistentes As New DataTable

        Select Case ValidarDatos()
            Case 1
                MsgBox("Debe ingresar la Fecha Desde del Convenio ", MsgBoxStyle.Information, "Everest")
                Exit Sub
            Case 2
                MsgBox("Debe ingresar la Fecha Hasta del Convenio ", MsgBoxStyle.Information, "Everest")
                Exit Sub
            Case 3
                MsgBox("Debe Selecccionar el Codigo del Cliente Origen", MsgBoxStyle.Information, "Everest")
                Exit Sub
            Case 4
                MsgBox("Debe Selecccionar el Codigo del Cliente Destino", MsgBoxStyle.Information, "Everest")
                Me.txtCodigo.Text = ""
                Me.txtDescripcion.Text = ""
                Exit Sub
            Case 5
                MsgBox("El Cliente Origen debe ser Distinto al Cliente Destino", MsgBoxStyle.Information, "Everest")
                Me.txtCodigoDestino.Text = ""
                Me.txtDescripcionDestino.Text = ""
                Exit Sub
        End Select
        ' Valido las Fechas ingresadas --------------------------------------------------------------------------------------
        TipoError = ValidarFechasIngresadas()

        If TipoError = 1 Then
            MsgBox("La Fecha Desde Ingresada debe, ser menor a la Fecha Hasta ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        ElseIf TipoError = 2 Then
            MsgBox("La Fecha Hasta Ingresada debe, ser mayor a la Fecha Desde ", MsgBoxStyle.Information, "Everest")
            Exit Sub
        End If
        '-----------------------------------------------------------------------------------------------------------------------------

        If MsgBox("Confirma duplicar los convenios, con los parametros ingresados? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            With OConvenio
                .Id_cliente = CInt(Me.txtCodigo.Text)
                .F_inicio = Me.dtpFechaInicioD.Value
                .F_fin = Me.dtpFechaFinD.Value
                DtConvenios = .ValidarDuplicacionConvenios()

                If DtConvenios.Rows.Count > 0 Then
                    For Each r As DataRow In DtConvenios.Rows
                        .Id_medio = CInt(r("COD_MEDIO"))
                        .Id_soporte = CInt(r("COD_SOPORTE"))
                        .Id_cliente = CInt(Me.txtCodigoDestino.Text)
                        .Id_producto = CInt(r("COD_PRODUCTO"))
                        .F_inicio = CDate(r("FEC_INICIO"))
                        .F_fin = CDate(r("FEC_FIN"))
                        .Detalle = r("DETALLE").ToString
                        .Participacion = r("PARTICIPACION").ToString
                        .Programa = r("PROGRAMA").ToString
                        If IsDBNull(r("DESC_VENTA_1")) Then
                            .Dcto1 = 0
                        Else
                            .Dcto1 = CSng(r("DESC_VENTA_1"))
                        End If
                        If IsDBNull(r("DESC_VENTA_2")) Then
                            .Dcto2 = 0
                        Else
                            .Dcto2 = CSng(r("DESC_VENTA_2"))
                        End If
                        If IsDBNull(r("DESC_VENTA_3")) Then
                            .Dcto3 = 0
                        Else
                            .Dcto3 = CSng(r("DESC_VENTA_3"))
                        End If
                        If IsDBNull(r("DESC_VENTA_4")) Then
                            .Dcto4 = 0
                        Else
                            .Dcto4 = CSng(r("DESC_VENTA_4"))
                        End If
                        If IsDBNull(r("DESC_VENTA_5")) Then
                            .Dcto5 = 0
                        Else
                            .Dcto5 = CSng(r("DESC_VENTA_5"))
                        End If
                        If IsDBNull(r("DESC_COMPRA_1")) Then
                            .DctoCompra1 = 0
                        Else
                            .DctoCompra1 = CSng(r("DESC_COMPRA_1"))
                        End If
                        If IsDBNull(r("DESC_COMPRA_2")) Then
                            .DctoCompra2 = 0
                        Else
                            .DctoCompra2 = CSng(r("DESC_COMPRA_2"))
                        End If
                        If IsDBNull(r("DESC_COMPRA_3")) Then
                            .DctoCompra3 = 0
                        Else
                            .DctoCompra3 = CSng(r("DESC_COMPRA_3"))
                        End If
                        If IsDBNull(r("DESC_COMPRA_4")) Then
                            .DctoCompra4 = 0
                        Else
                            .DctoCompra4 = CSng(r("DESC_COMPRA_4"))
                        End If
                        If IsDBNull(r("DESC_COMPRA_5")) Then
                            .DctoCompra5 = 0
                        Else
                            .DctoCompra5 = CSng(r("DESC_COMPRA_5"))
                        End If
                        If IsDBNull(r("DESC_EXTRA_1")) Then
                            .DctoExtra1 = 0
                        Else
                            .DctoExtra1 = CSng(r("DESC_EXTRA_1"))
                        End If
                        If IsDBNull(r("DESC_EXTRA_2")) Then
                            .DctoExtra2 = 0
                        Else
                            .DctoExtra2 = CSng(r("DESC_EXTRA_2"))
                        End If
                        If IsDBNull(r("IMP_NETO_VENTA")) Then
                            .Neto = 0
                        Else
                            .Neto = CDbl(r("IMP_NETO_VENTA"))
                        End If
                        If IsDBNull(r("IMP_NETO_COMPRA")) Then
                            .NetoCompra = 0
                        Else
                            .NetoCompra = CDbl(r("IMP_NETO_COMPRA"))
                        End If
                        .Obs_Compra = r("OBS_COMPRA").ToString
                        .Obs_Venta = r("OBS_VENTA").ToString
                        .Obs_Extra = r("OBS_EXTRA").ToString
                        .Semana = r("SEMANA").ToString
                        If IsDBNull(r("HH_DESDE")) Then
                            .Hh_desde = 0
                        Else
                            .Hh_desde = CShort(r("HH_DESDE"))
                        End If
                        If IsDBNull(r("HH_HASTA")) Then
                            .Hh_hasta = 0
                        Else
                            .Hh_hasta = CShort(r("HH_HASTA"))
                        End If
                        If IsDBNull(r("MM_DESDE")) Then
                            .Mm_desde = 0
                        Else
                            .Mm_desde = CShort(r("MM_DESDE"))
                        End If
                        If IsDBNull(r("MM_HASTA")) Then
                            .Mm_hasta = 0
                        Else
                            .Mm_hasta = CShort(r("MM_HASTA"))
                        End If
                        If IsDBNull(r("FECHA_MODIF")) Then
                            .F_modi = CDate("01/01/1900")
                        Else
                            .F_modi = CDate(r("FECHA_MODIF"))
                        End If
                        .U_modi = r("USER_MODIF").ToString
                        .Tipo_convenio = r("TIPO_CONVENIO").ToString
                        .Obs_Finanzas = r("OBS_FINANZAS").ToString
                        .Agregar()
                    Next
                    MsgBox("El Proceso de Duplicacion de Convenios, para el Cliente:  " & Me.txtDescripcionDestino.Text & "  Se Realizo con Exito Con " & DtConvenios.Rows.Count.ToString & "  Convenios Duplicados ", MsgBoxStyle.Information, "Everest")
                Else
                    MsgBox("No se encontraron Convenios, para Duplicar con esos Parametros ", MsgBoxStyle.Information, "Everest")
                End If
            End With
        Else
            Exit Sub
        End If



    End Sub

    Private Function ValidarFechasIngresadas() As Integer

        Dim TipoError As Integer

        If CDate(dtpFechaInicioD.Value) > CDate(dtpFechaFinD.Value) Then
            'dtpFechaInicioD.Value = FDesde
            TipoError = 1
        End If

        If CDate(dtpFechaFinD.Value) < CDate(dtpFechaInicioD.Value) Then
            'dtpFechaFinD.Value = FHasta
            TipoError = 2
        End If

        Return TipoError

    End Function

    Private Function ValidarDatos() As Integer

        If dtpFechaInicioD.Value = Nothing Then
            ErrorDatos = 1 'Error Vacio Fecha desde
            Return ErrorDatos
            Exit Function
        End If

        If dtpFechaFinD.Value = Nothing Then
            ErrorDatos = 2 'Error Vacio Fecha Hasta
            Return ErrorDatos
            Exit Function
        End If

        If Me.txtCodigo.Text = "" Then
            ErrorDatos = 3 'Error Vacio Codigo Cliente Origen
            Return ErrorDatos
            Exit Function
        End If

        If Me.txtCodigoDestino.Text = "" Then
            ErrorDatos = 4 'Error Vacio Codigo Cliente Destino
            Return ErrorDatos
            Exit Function
        End If

        If CInt(Me.txtCodigoDestino.Text) = CInt(Me.txtCodigo.Text) Then
            ErrorDatos = 5 'Error Mismo Codigos Clientes Seleccionados
            Return ErrorDatos
            Exit Function
        End If

        Return 0 'Todos los datos completos
    End Function

    Private Sub BuscarClienteOrigen()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtDescripcion, txtCodigo, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub

    Private Sub frmDuplicarConvenios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpFechaInicioD.Value = Nothing
        dtpFechaFinD.Value = Nothing
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        BuscarClienteDestino()
    End Sub


    Private Sub BuscarClienteDestino()
        Dim F As New frmBuscar
        F.CargarFormulario(SeccionActiva.Cliente, Me.txtDescripcionDestino, Me.txtCodigoDestino, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub
End Class
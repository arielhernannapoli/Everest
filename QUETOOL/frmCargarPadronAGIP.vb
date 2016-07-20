Imports System.IO
Imports Framework.Mensajes
Imports ClosedXML.Excel
Imports System.Collections.Generic

Public Class frmCargarPadronAGIP
    Private Path As String
    Private Guardo As Boolean
    Private Cancelo As Boolean

    Private Sub frmCargarPadronAGIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.marqueeCarga.Enabled = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim padron As New Padron_AGIP
        padron.Fecha = dtpFecha.Value
        padron.Descripcion = txtDescripcion.Text
        padron.Detalle_AGIP = ImportarExcel()
        AgregarExcepciones(padron)
        padron.Id_Padron = padron.ValidarPadron(padron.Fecha)
        If padron.Id_Padron < 0 Then
            padron.Id_Padron = padron.Agregar(padron.Fecha, padron.Descripcion, padron.Detalle_AGIP)
            Guardo = padron.Id_Padron > 0
        Else
            If Mensaje("El padron ya existe. ¿Desea remplazarlo?", TipoMensaje.SiNo) = Windows.Forms.DialogResult.Yes Then
                padron.Borrar(padron.Id_Padron)
                padron.Id_Padron = padron.Agregar(padron.Fecha, padron.Descripcion, padron.Detalle_AGIP)
                Guardo = padron.Id_Padron > 0
            Else
                Cancelo = True
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HabilitarControles(True, String.Empty)
        If Not Cancelo Then
            If Guardo Then
                Mensaje("Se guardo correctamente.", TipoMensaje.Informacion)
            Else
                Mensaje("Ocurrio un error al guardar.", TipoMensaje.Informacion)
            End If
        End If
    End Sub

    Private Sub btnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivo.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "XLSX Files (*.xlsx)|*.xlsx"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Me.Path = openFileDialog1.FileName
                txtArchivo.Text = Me.Path
            Catch Ex As Exception
                Mensaje("No se encuentra el archivo.", TipoMensaje.Informacion)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidarControles() Then
            HabilitarControles(False, "Cargando Padron...")
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub HabilitarControles(ByVal habilitado As Boolean, ByVal accion As String)
        marqueeCarga.Enabled = Not habilitado
        marqueeCarga.Text = accion
        marqueeCarga.Properties.ShowTitle = Not habilitado
    End Sub

    Private Function ValidarControles() As Boolean
        If dtpFecha.Value.ToString() = String.Empty Then
            Mensaje("Ingrese una fecha.", TipoMensaje.Informacion)
            Return False
        End If
        If txtDescripcion.Text = String.Empty Then
            Mensaje("Ingrese una descripción.", TipoMensaje.Informacion)
            Return False
        End If
        If txtArchivo.Text = String.Empty Then
            Mensaje("Ingrese una archivo.", TipoMensaje.Informacion)
            Return False
        End If
        Return True
    End Function

    Private Function ImportarExcel() As List(Of Detalle_AGIP)
        Dim workbook As New XLWorkbook(Me.Path)
        Dim worksheet As IXLWorksheet = workbook.Worksheets.First()
        Dim rango As IXLRange = worksheet.RangeUsed()
        Dim cantColumnas As Integer = rango.ColumnCount()
        Dim detallesAGIP As New List(Of Detalle_AGIP)
        Try
            For Each fila As IXLRangeRow In rango.RowsUsed()
                Dim i As Integer = 0
                Dim detalle As New Detalle_AGIP
                For Each celda As IXLCell In fila.Cells()
                    If Not fila.RangeAddress.FirstAddress.RowNumber = 1 Then
                        Select Case i
                            Case 0
                                ' no hace nada es el orden
                            Case 1
                                Dim cuit As String
                                cuit = celda.Value.ToString().Substring(0, 2) & "-" & celda.Value.ToString().Substring(2, 8) & "-" & celda.Value.ToString().Substring(10, 1)
                                detalle.CUIT = cuit
                            Case 2
                                detalle.RazonSocial = celda.Value.ToString()
                            Case 3
                                detalle.CodigoAGIP = Convert.ToInt64(celda.Value)
                            Case 4
                                detalle.Clase = celda.Value.ToString()
                            Case 5
                                detalle.Tipo = celda.Value.ToString()
                            Case 6
                                detalle.Caracteristica = celda.Value.ToString()
                            Case 7
                                detalle.Sup = Convert.ToInt32(celda.Value)
                            Case 8
                                detalle.Zona = Convert.ToInt32(celda.Value)
                            Case 9
                                detalle.Direccion = celda.Value.ToString()
                            Case 10
                                If celda.Value.ToString() = String.Empty Then
                                    detalle.Altura = 0
                                Else
                                    detalle.Altura = Convert.ToInt32(celda.Value)
                                End If

                            Case Else
                        End Select
                    End If
                    i += 1
                Next
                If Not fila.RangeAddress.FirstAddress.RowNumber = 1 Then
                    detallesAGIP.Add(detalle)
                End If
            Next
        Catch ex As Exception
        End Try
        Return detallesAGIP
    End Function

    Private Sub AgregarExcepciones(ByVal padron As Padron_AGIP)
        'LC 05/08/2014 Excepciones AGIP en BD
        Dim dtExcepciones As New DataTable
        dtExcepciones = padron.ObtenerExcepciones()
        For Each excepcion As DataRow In dtExcepciones.Rows
            Dim detalle As New Detalle_AGIP()
            detalle.CUIT = IIf(IsDBNull(excepcion("CUIT")), "", excepcion("CUIT"))
            detalle.RazonSocial = IIf(IsDBNull(excepcion("RazonSocial")), "", excepcion("RazonSocial"))
            detalle.CodigoAGIP = IIf(IsDBNull(excepcion("CodigoAGIP")), "", excepcion("CodigoAGIP"))
            detalle.Clase = IIf(IsDBNull(excepcion("Clase")), "", excepcion("Clase"))
            detalle.Tipo = IIf(IsDBNull(excepcion("Tipo")), "", excepcion("Tipo"))
            detalle.Caracteristica = IIf(IsDBNull(excepcion("Caracteristica")), "", excepcion("Caracteristica"))
            detalle.Sup = IIf(IsDBNull(excepcion("Sup")), 0, excepcion("Sup"))
            detalle.Zona = IIf(IsDBNull(excepcion("Zona")), 0, excepcion("Zona"))
            detalle.Direccion = IIf(IsDBNull(excepcion("Direccion")), "", excepcion("Direccion"))
            detalle.Altura = IIf(IsDBNull(excepcion("Altura")), 0, excepcion("Altura"))
            padron.Detalle_AGIP.Add(detalle)
        Next
    End Sub

End Class
Imports DevExpress.XtraPivotGrid
Imports System.IO
Imports System.Globalization

' CLASE BASE PARA LOS CUBOS DE DATOS (AN 15-10-2015)
Namespace Cubos
    Public MustInherit Class Cubo
        Inherits DevExpress.XtraPivotGrid.PivotGridControl
        Implements ICubo

        Protected path As String = String.Concat(IO.Path.GetDirectoryName(Application.ExecutablePath), "\pivot_", Activo.IDUsuario, ".xml")
        Protected datos As DataSet
        Protected rating As String
        Protected cantidad As Integer = 1
        Protected fechaInicio As DateTime

        Public Sub SaveLayout(Optional ByVal layout As String = "") Implements ICubo.SaveLayout
            If Not String.IsNullOrEmpty(layout) Then
                path = String.Concat(IO.Path.GetDirectoryName(Application.ExecutablePath), "\", layout, "_", Activo.IDUsuario, ".xml")
            End If
            Me.SaveLayoutToXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        End Sub

        Public Sub LoadPivot(ByVal datos As DataSet, ByVal rating As String, ByVal fechaInicio As DateTime, Optional ByVal layout As String = "") Implements ICubo.LoadPivot
            If Not String.IsNullOrEmpty(layout) Then
                path = String.Concat(IO.Path.GetDirectoryName(Application.ExecutablePath), "\", layout, "_", Activo.IDUsuario, ".xml")
            End If
            Me.datos = datos
            Me.rating = rating
            Me.fechaInicio = fechaInicio
            Call Me.FillPivot()
            Call Me.InitializePivot()
        End Sub

        Protected Sub InitializePivot()
            If IO.File.Exists(path) Then
                Me.RestoreLayoutFromXml(path, DevExpress.Utils.OptionsLayoutBase.FullLayout)
            Else
                Call Me.SetFields()
            End If
        End Sub

        Protected MustOverride Sub SetFields()

        Protected Sub FillPivot()
            Dim c As New Cubo_Listados
            Dim s As New Sistemas
            Dim dt As DataTable

            s.Id_campania = Activo.IDCampaña
            s.Id_sistema = Activo.IDSistema
            s.BuscarPorID()

            c.Id_Campania = Activo.IDCampaña
            c.Id_Sistema = Activo.IDSistema
            c.Id_Ejercicio = Activo.IDEjercicio
            c.Tipo_Rating = s.Tipo_rating

            ' RECUPERA LOS DATOS GUARDADOS DE LA BASE DE DATOS (OBSOLETO)
            'dt = c.Cubo_Ejercicio()

            ' ARMA LOS DATOS EN MEMORIA AUN SIN GUARDAR EN LA BASE DE DATOS
            dt = ObtenerDatos()

            Me.ForceInitialize()
            Me.DataSource = dt
            Me.RetrieveFields()
            Me.Enabled = True

        End Sub

        Protected Function ObtenerDatos() As DataTable
            Dim dtDatos As New DataTable
            Dim drFila As DataRow
            Dim spot, spotDetalle As DataRow
            Dim dateFormatInfo As DateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo
            Dim calendar As Calendar = dateFormatInfo.Calendar()
            Dim fechaSpot As DateTime

            ' CREO ESTRUCTURA DE TABLA
            dtDatos.Columns.Add("RN_TEMA", GetType(String))
            dtDatos.Columns.Add("RN_SEMANA", GetType(String))
            dtDatos.Columns.Add("RN_LAB FES", GetType(String))
            dtDatos.Columns.Add("RN_SEM CAL", GetType(String))
            dtDatos.Columns.Add("RN_DIA SEMANA", GetType(String))
            dtDatos.Columns.Add("RN_MES", GetType(String))
            dtDatos.Columns.Add("PN_SOPORTE", GetType(String))
            dtDatos.Columns.Add("PN_PROVEEDOR", GetType(String))
            dtDatos.Columns.Add("PN_PROGRAMA", GetType(String))
            dtDatos.Columns.Add("PN_FRANJA", GetType(String))
            dtDatos.Columns.Add("DS_DURACION", GetType(Integer))
            dtDatos.Columns.Add("DS_DURACION_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_CANTIDAD", GetType(Integer))
            dtDatos.Columns.Add("DS_CANTIDAD_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_RAT TARGET 1", GetType(Double))
            dtDatos.Columns.Add("DS_RAT TARGET 1_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_RAT TARGET 2", GetType(Double))
            dtDatos.Columns.Add("DS_RAT TARGET 2_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_NETO", GetType(Double))
            dtDatos.Columns.Add("DS_NETO_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_BRUTO ORI", GetType(Double))
            dtDatos.Columns.Add("DS_BRUTO ORI_PORC", GetType(Double))
            dtDatos.Columns.Add("DS_BRUTO ACTUAL", GetType(Double))
            dtDatos.Columns.Add("DS_BRUTO ACTUAL_PORC", GetType(Double))
            dtDatos.Columns.Add("ID_SOPORTE", GetType(Integer))
            dtDatos.Columns.Add("ID_MEDIO", GetType(Integer))

            If Not datos.Tables(0).Columns.Contains("BRUTO_ORI") Then
                datos.Tables(0).Columns.Add("BRUTO_ORI", GetType(Double))
            End If

            For Each fila As DataRow In datos.Tables(0).Rows
                If Not IsNumeric(fila("BRUTO_ORI")) Then
                    fila("BRUTO_ORI") = 0
                End If
            Next

            ' CREO E INSERTO NUEVA FILA EN LA TABLA
            For Each fila As DataRow In datos.Tables(1).Rows
                spotDetalle = fila
                spot = spotDetalle.GetParentRow("Relacion")
                fechaSpot = DateTime.Parse(spotDetalle("F_SPOT").ToString())
                drFila = dtDatos.NewRow()
                drFila("RN_TEMA") = spotDetalle("ID_TEMA")
                drFila("RN_SEMANA") = String.Concat(fechaSpot.Year, " ", Math.Truncate(Math.Abs(DateDiff(DateInterval.Day, fechaSpot, fechaInicio)) / 7) + 1)
                drFila("RN_LAB FES") = IIf(IIf(Integer.Parse(fechaSpot.DayOfWeek).Equals(0), 7, Integer.Parse(fechaSpot.DayOfWeek)) < 6, "1 - Laboral", "2 - Festivo")
                drFila("RN_SEM CAL") = String.Concat("SEM ", ObtenerSemanaCalendario(fechaSpot))
                drFila("RN_DIA SEMANA") = String.Concat(IIf(Integer.Parse(fechaSpot.DayOfWeek).Equals(0), 7, Integer.Parse(fechaSpot.DayOfWeek)), " - ", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTimeFormatInfo.CurrentInfo.DayNames(Integer.Parse(fechaSpot.DayOfWeek))))
                drFila("RN_MES") = String.Concat(fechaSpot.Month, " - ", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTimeFormatInfo.CurrentInfo.MonthNames(fechaSpot.Month - 1)))
                drFila("PN_SOPORTE") = ObtenerSoporte(spot)
                drFila("PN_PROVEEDOR") = ObtenerProveedor(spot)
                drFila("PN_PROGRAMA") = spot("PROGRAMA")
                drFila("PN_FRANJA") = ObtenerFranja(spot)
                drFila("DS_DURACION") = spotDetalle("DURACION")
                drFila("DS_DURACION_PORC") = spotDetalle("DURACION")
                drFila("DS_CANTIDAD") = cantidad
                drFila("DS_CANTIDAD_PORC") = cantidad
                drFila("DS_RAT TARGET 1") = IIf((rating.Equals("P") Or rating.Equals("F")), spot("RAT_PROG_TARGET_1"), spot("RAT_TANDA_TARGET_1"))
                drFila("DS_RAT TARGET 1_PORC") = IIf((rating.Equals("P") Or rating.Equals("F")), spot("RAT_PROG_TARGET_1"), spot("RAT_TANDA_TARGET_1"))
                drFila("DS_RAT TARGET 2") = IIf((rating.Equals("P") Or rating.Equals("F")), spot("RAT_PROG_TARGET_2"), spot("RAT_TANDA_TARGET_2"))
                drFila("DS_RAT TARGET 2_PORC") = IIf((rating.Equals("P") Or rating.Equals("F")), spot("RAT_PROG_TARGET_2"), spot("RAT_TANDA_TARGET_2"))
                drFila("DS_NETO") = Double.Parse(spot("NETO").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("DS_NETO_PORC") = Double.Parse(spot("NETO").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("DS_BRUTO ORI") = Double.Parse(spot("BRUTO_ORI").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("DS_BRUTO ORI_PORC") = Double.Parse(spot("BRUTO_ORI").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("DS_BRUTO ACTUAL") = Double.Parse(spot("BRUTO").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("DS_BRUTO ACTUAL_PORC") = Double.Parse(spot("BRUTO").ToString()) * Double.Parse(spotDetalle("DURACION").ToString())
                drFila("ID_SOPORTE") = spot("ID_SOPORTE")
                drFila("ID_MEDIO") = Activo.IDMedio
                dtDatos.Rows.Add(drFila)
            Next

            Return dtDatos
        End Function

        Protected Function ObtenerSemanaCalendario(ByVal fechaSpot As DateTime) As String
            Dim dateFormatInfo As DateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo
            Dim calendar As Calendar = dateFormatInfo.Calendar()
            Return calendar.GetWeekOfYear(fechaSpot, CalendarWeekRule.FirstDay, DayOfWeek.Sunday).ToString()
        End Function

        Protected Function ObtenerSoporte(ByVal spot As DataRow) As String
            Dim oSpot As New Spots

            'trae los soportes
            oSpot.Id_campania = Activo.IDCampaña
            oSpot.Id_sistema = Activo.IDSistema
            oSpot.Id_ejercicio = Activo.IDEjercicio
            oSpot.Id_Medio = Activo.IDMedio

            Dim Soportes As DataTable = oSpot.ObtenerSoportesGuardados

            For Each soporte As DataRow In Soportes.Rows
                If soporte("ID_SOPORTE").Equals(spot("ID_SOPORTE")) Then
                    Return soporte("DESCRIPCION").ToString().Split("|")(0)
                End If
            Next
            Return String.Empty
        End Function

        Protected Function ObtenerProveedor(ByVal spot As DataRow) As String
            Dim oSpot As New Spots

            'trae los soportes
            oSpot.Id_campania = Activo.IDCampaña
            oSpot.Id_sistema = Activo.IDSistema
            oSpot.Id_ejercicio = Activo.IDEjercicio
            oSpot.Id_Medio = Activo.IDMedio

            Dim Soportes As DataTable = oSpot.ObtenerSoportesGuardados

            For Each soporte As DataRow In Soportes.Rows
                If soporte("ID_SOPORTE").Equals(spot("ID_SOPORTE")) Then
                    Return soporte("DESCRIPCION").ToString().Split("|")(1)
                End If
            Next
            Return String.Empty
        End Function

        Protected Function ObtenerFranja(ByVal spot As DataRow) As String
            'USO LA HORA DE INICIO PARA VER DENTRO DE QUE FRANJA CAE (AN 23-11-2015)
            For Each franja As DataRow In datos.Tables("FRANJAS").Rows
                If Integer.Parse(spot("H_INICIO").ToString()) >= Integer.Parse(franja("H_DESDE").ToString()) _
                        And Integer.Parse(spot("H_INICIO").ToString()) <= Integer.Parse(franja("H_HASTA").ToString()) Then
                    If Integer.Parse(spot("M_INICIO").ToString()) >= Integer.Parse(franja("M_DESDE").ToString()) _
                        And Integer.Parse(spot("M_INICIO").ToString()) <= Integer.Parse(franja("M_HASTA").ToString()) Then
                        Return franja("DESCRIPCION").ToString()
                    End If
                End If
            Next
            Return "Resto de franja"
        End Function

        Private Sub Cubo_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles Me.CustomCellDisplayText
            If String.IsNullOrEmpty(e.DisplayText) Or e.Value Is Nothing Then
                If Not e.DataField Is Nothing Then
                    Dim formatString As String = e.DataField.CellFormat.FormatString
                    e.DisplayText = (0).ToString(formatString)
                End If
            End If
        End Sub
    End Class
End Namespace
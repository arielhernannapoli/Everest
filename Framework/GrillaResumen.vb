Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.Collections.Generic

Public Class GrillaResumen
    Dim GrillAdmin As New GrillAdmin

    Dim ResumenFranja As DataTable
    Dim ResumenSoporte As DataTable
    Dim ResumenTema As DataTable
    Dim ResumenSemana As DataTable
    Dim TotalSegundos As Integer
    Dim cNeto As Double, cGrps As Single, cSegundos As Integer, cCantAvisos As Integer, cCpr As Double

    Public Sub LimpiarDataTable()
        'If ResumenFranja Is Not nu Then
        '    ResumenFranja.Clear()
        '    Me.EstructuraFranja(ResumenFranja)
        'End If

        'ResumenSoporte.Clear()
        'ResumenTema.Clear()
        'ResumenSemana.Clear()
    End Sub


    Public Sub DuracionFranja(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal HoraInicio As String, ByVal HoraFin As Integer, ByVal Temas As DataTable)
        '*** actualiza la duracion promedio para la franja
        If HoraInicio = "" Then
            Exit Sub
        End If

        If CompraAnterior Is Nothing Then
            CompraAnterior = ""
        End If

        'calcula la duracion promedio para sacar el cuadro de resumen por franja
        Dim Franja As DataRow

        ' If Me.ResumenFranja Is Nothing Then
        '  Me.EstructuraFranja(Franjas)
        'End If
        '  If Me.ResumenFranja Is Nothing Then
        'Exit Sub
        ' End If

        For Each Franja In Me.ResumenFranja.Rows

            If HoraInicio >= Franja("h_desde") And HoraFin <= Franja("h_hasta") Then
                'suma las duraciones de los temas que se borraron comprados
                For Each S As String In CompraAnterior
                    Franja("CantidadTemas") -= 1
                    Franja("SumaDuracion") -= GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")
                Next

                'suma las duraciones de los temas comprados
                For Each S As String In CompraActual
                    Franja("CantidadTemas") += 1
                    Franja("SumaDuracion") += GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")
                Next
            End If

        Next
    End Sub

    Public Function Franja(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Franjas As DataTable, ByVal Temas As DataTable) As DataTable
        Dim Dr As DataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        'si no esta cargada, arma la estructura del Data Table del resumen
        'a la estructura comun de todos los cuadros se agregan columnas propias de
        'la franja, como la hora de inicio y fin y tambien se agregan los '
        'totales para sacar la duracion promedio
        If Me.ResumenFranja Is Nothing Then
            Me.EstructuraFranja(Franjas)
        End If

        'copia la suma de la duracion y la cantidad de temas al DT de Resumen (es el que se conecta a la grilla)
        'For i As Integer = 0 To Franjas.Rows.Count - 1
        '    ResumenFranja.Rows(i)("SumaDuracion") = Franjas.Rows(i)("SumaDuracion")
        '    ResumenFranja.Rows(i)("CantidadTemas") = Franjas.Rows(i)("CantidadTemas")
        'Next

        'toma todas las letras compradas en la celda y resta las tarifas y rating del DT de Resumen
        For Each Dr In ResumenFranja.Rows
            If Fila("H_inicio").ToString.Substring(0, 2) >= Dr("h_desde") And Fila("H_inicio").ToString.Substring(0, 2) <= Dr("h_hasta") Then

                For Each s As String In CompraAnterior
                    Dr("Tarifa Neta") -= Valores.CastDBNull(Fila("neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s & "'", "duracion")
                    Dr("Grps") -= Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))

                    Dr("Grps") = Math.Round(Dr("Grps"), 2)
                Next

            End If
        Next

        'toma todas las letras compradas en la celda y suma las tarifas y rating del DT de Resumen
        For Each Dr In ResumenFranja.Rows
            If Fila("H_inicio").ToString.Substring(0, 2) >= Dr("h_desde") And Fila("H_inicio").ToString.Substring(0, 2) <= Dr("h_hasta") Then

                For Each s As String In CompraActual
                    Dr("Tarifa Neta") += Valores.CastDBNull(Fila("Neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s & "'", "duracion")
                    Dr("Grps") += Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))
                Next

                Dr("CPR") = Dr("Tarifa Neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas"))
                Dr("CPR") = Valores.CastNulo(Dr("CPR"))
            End If

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa Neta")
        Next

        'calcula los porcentajes del cuadro de resumen
        Me.CalcularPorcentajes(ResumenFranja, SumaGRPs, SumaTarifaNeta)

        Return ResumenFranja
    End Function

    Private Sub EstructuraFranja(ByVal Franjas As DataTable)
        ResumenFranja = ObtenerEstructura(TipoCuadroResumen.Franja)

        'agrega mas columnas a la franjas para calcular despues 
        'si la compra entra en la franja o no y para sacar la duracion promedio
        ResumenFranja.Columns.Add("h_desde", GetType(Byte))
        ResumenFranja.Columns.Add("h_hasta", GetType(Byte))
        ResumenFranja.Columns.Add("SumaDuracion", GetType(Integer))
        ResumenFranja.Columns.Add("CantidadTemas", GetType(Integer))

        'inicializa los valores en el DT de Resumen
        For Each Dr As DataRow In Franjas.Rows
            Dim NuevaFila As DataRow = ResumenFranja.NewRow

            NuevaFila("h_desde") = Dr("h_desde")
            NuevaFila("h_hasta") = Dr("h_hasta")

            NuevaFila("Franja") = Dr("descripcion") & " - " & Dr("h_desde") & " a " & Dr("h_hasta")
            NuevaFila("Tarifa Neta") = 0
            NuevaFila("Grps") = 0
            NuevaFila("CPR") = 0
            NuevaFila("SumaDuracion") = 0
            NuevaFila("CantidadTemas") = 0

            ResumenFranja.Rows.Add(NuevaFila)
        Next
    End Sub

    Public Sub DuracionSoporte(ByVal IDSoporte As Integer, ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal SoportesDuracion As ArrayList, ByVal Temas As DataTable)
        If CompraAnterior Is Nothing Then
            CompraAnterior = ""
        End If

        '*** actualiza la duracion promedio para los soportes
        For Each Dr As DataRow In Me.ResumenSoporte.Rows
            If Dr("id_soporte") = IDSoporte Then

                If Not CompraAnterior Is Nothing Then
                    'suma las duraciones de los temas que se borraron comprados
                    For Each S As String In CompraAnterior
                        Dr("CantidadTemas") -= 1
                        Dr("SumaDuracion") -= GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")
                    Next
                End If

                'suma las duraciones de los temas comprados
                For Each S As String In CompraActual
                    Dr("CantidadTemas") += 1
                    Dr("SumaDuracion") += GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")
                Next

            End If
        Next
    End Sub

    Public Function Soporte(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Soportes As ArrayList, ByVal Temas As DataTable) As DataTable
        Dim Dr As DataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        'si no esta cargada, arma la estructura del Data Table del resumen
        'a la estructura comun de todos los cuadros se agregan columnas propias de
        'la franja, como la hora de inicio y fin y tambien se agregan los '
        'totales para sacar la duracion promedio
        If Me.ResumenSoporte Is Nothing Then
            Me.EstructuraSoporte(Soportes)
        End If

        If CompraAnterior Is Nothing Then
            CompraAnterior = ""
        End If

        'toma todas las letras compradas en la celda y resta las tarifas y rating del DT de Resumen
        For Each Dr In Me.ResumenSoporte.Rows
            If Fila("id_soporte") = Dr("id_soporte") Then
                'cambio por bruto
                For Each s As String In CompraAnterior
                    Dr("Tarifa Neta") -= Valores.CastDBNull(Fila("neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("bruto") -= Valores.CastDBNull(Fila("bruto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")

                    Dr("Grps") -= Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))

                    Dr("Grps") = Math.Round(Dr("Grps"), 2)
                Next

            End If
        Next
        'cambio por bruto
        'toma todas las letras compradas en la celda y suma las tarifas y rating del DT de Resumen
        For Each Dr In Me.ResumenSoporte.Rows
            If Fila("id_soporte") = Dr("id_soporte") Then

                For Each s As String In CompraActual
                    Dr("Tarifa Neta") += Valores.CastDBNull(Fila("Neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("bruto") += Valores.CastDBNull(Fila("bruto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")

                    Dr("Grps") += Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))
                Next

                Dr("CPR") = Dr("Tarifa Neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas"))
                Dr("CPR") = Valores.CastNulo(Dr("CPR"))
            End If

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa Neta")

            Dim T As Decimal = Me.ResumenSoporte.Compute("sum(sumaduracion)", "")
            If T <> 0 Then
                Dr("PorcentajeDuracion") = Valores.CastNulo(Math.Round(Dr("SumaDuracion") * 100 / T, 2))
            Else
                Dr("PorcentajeDuracion") = 0
            End If

        Next

        'calcula los porcentajes del cuadro de resumen
        Me.CalcularPorcentajes(ResumenSoporte, SumaGRPs, SumaTarifaNeta)

        Return Me.ResumenSoporte
    End Function

    Public Sub EstructuraSoporte(ByVal Soportes As DataTable)
        Dim SoportesArray As New ArrayList
        Dim IT As ItemLista

        'pasa el DT a un Array List
        For Each dr As DataRow In Soportes.Rows
            IT = New ItemLista

            IT.ID = dr("id_soporte")
            IT.Descripcion = dr("descripcion")

            SoportesArray.Add(IT)
        Next

        'llama al metodo que arma la estructura con el array
        Me.EstructuraSoporte(SoportesArray)
    End Sub

    Public Sub EstructuraSoporte(ByVal Soportes As ArrayList)
        ResumenSoporte = ObtenerEstructura(TipoCuadroResumen.Soporte)

        'agrega mas columnas a la franjas para calcular despues 
        'si la compra entra en el soporte o no y para sacar la duracion promedio
        ResumenSoporte.Columns.Add("id_soporte", GetType(Integer))
        ResumenSoporte.Columns.Add("Bruto", GetType(Decimal))
        ResumenSoporte.Columns.Add("SumaDuracion", GetType(Integer))
        ResumenSoporte.Columns.Add("PorcentajeDuracion", GetType(Decimal))
        ResumenSoporte.Columns.Add("CantidadTemas", GetType(Integer))

        'inicializa los valores en el DT de Resumen
        For Each IT As ItemLista In Soportes
            Dim NuevaFila As DataRow = ResumenSoporte.NewRow

            NuevaFila("id_soporte") = IT.ID

            NuevaFila("Soporte") = IT.Descripcion
            NuevaFila("Tarifa Neta") = 0
            NuevaFila("Grps") = 0
            NuevaFila("CPR") = 0
            NuevaFila("SumaDuracion") = 0
            NuevaFila("CantidadTemas") = 0
            NuevaFila("PorcentajeDuracion") = 0
            NuevaFila("Bruto") = 0

            ResumenSoporte.Rows.Add(NuevaFila)
        Next
    End Sub

    Public Function Tema(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Temas As DataTable) As DataTable
        Dim Dr As DataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        'si no esta cargada, arma la estructura del Data Table del resumen
        'a la estructura comun de todos los cuadros se agregan columnas propias de
        'la Tema, como la hora de inicio y fin y tambien se agregan los '
        'totales para sacar la duracion promedio
        If Me.ResumenTema Is Nothing Then
            Me.EstructuraTema(Temas)
        End If

        'toma todas las letras compradas en la celda y resta las tarifas y rating del DT de Resumen
        For Each Dr In ResumenTema.Rows
            For Each s As String In CompraAnterior
                If Dr("id_tema") = s.ToUpper Then
                    Dr("Tarifa Neta") -= Valores.CastDBNull(Fila("neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("Grps") -= Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))
                    Dr("Temas") -= 1

                    Dr("Grps") = Math.Round(Dr("Grps"), 2)
                End If
            Next
        Next

        'toma todas las letras compradas en la celda y suma las tarifas y rating del DT de Resumen
        For Each Dr In ResumenTema.Rows
            For Each s As String In CompraActual
                If Dr("id_tema") = s.ToUpper Then
                    Dr("Tarifa Neta") += Valores.CastDBNull(Fila("Neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("Grps") += Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))
                    Dr("Temas") += 1
                End If
            Next

            Dr("CPR") = Dr("Tarifa Neta") / Dr("Grps") / Dr("duracion")
            Dr("CPR") = Valores.CastNulo(Dr("CPR"))

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa Neta")
        Next

        'calcula los porcentajes del cuadro de resumen
        Me.CalcularPorcentajes(ResumenTema, SumaGRPs, SumaTarifaNeta)

        Return ResumenTema
    End Function

    Private Sub EstructuraTema(ByVal Temas As DataTable)
        ResumenTema = ObtenerEstructura(TipoCuadroResumen.Tema)

        ResumenTema.Columns.Add("Temas", GetType(Integer))
        ResumenTema.Columns.Add("id_tema", GetType(String))
        ResumenTema.Columns.Add("Duracion", GetType(Integer))

        'inicializa los valores en el DT de Resumen
        For Each Dr As DataRow In Temas.Rows
            Dim NuevaFila As DataRow = ResumenTema.NewRow

            NuevaFila("Tema") = "Tema: " & Dr("id_tema")

            NuevaFila("Duracion") = Dr("Duracion")
            NuevaFila("id_tema") = Dr("id_tema")

            NuevaFila("Tarifa Neta") = 0
            NuevaFila("Grps") = 0
            NuevaFila("CPR") = 0
            NuevaFila("Temas") = 0

            ResumenTema.Rows.Add(NuevaFila)
        Next
    End Sub

    Public Sub DuracionSemana(ByVal Fecha As Date, ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Semanas As ArrayList, ByVal Temas As DataTable)
        If CompraAnterior Is Nothing Then
            CompraAnterior = ""
        End If

        For Each Dr As DataRow In Me.ResumenSemana.Rows
            If Fecha >= Dr("f_inicio") And Fecha <= Dr("f_fin") Then
                'suma las duraciones de los temas que se borraron comprados
                For Each C As String In CompraAnterior
                    Dr("CantidadTemas") -= 1
                    Dr("SumaDuracion") -= GrillAdmin.ObtenerDato(Temas, "id_tema='" & C.ToUpper & "'", "duracion")
                Next

                'suma las duraciones de los temas comprados
                For Each C As String In CompraActual
                    Dr("CantidadTemas") += 1
                    Dr("SumaDuracion") += GrillAdmin.ObtenerDato(Temas, "id_tema='" & C.ToUpper & "'", "duracion")
                Next
            End If
        Next
    End Sub

    Public Function Semana(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Columna As String, ByVal Semanas As ArrayList, ByVal Temas As DataTable) As DataTable
        Dim Dr As DataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        'si no esta cargada, arma la estructura del Data Table del resumen
        'a la estructura comun de todos los cuadros se agregan columnas propias de
        'la Semana, como la hora de inicio y fin y tambien se agregan los '
        'totales para sacar la duracion promedio
        If Me.ResumenSemana Is Nothing Then
            Me.EstructuraSemana(Semanas)
        End If

        'toma todas las letras compradas en la celda y resta las tarifas y rating del DT de Resumen
        For Each Dr In ResumenSemana.Rows
            If Columna >= Dr("f_inicio") And Columna <= Dr("f_fin") Then
                For Each s As String In CompraAnterior
                    Dr("Tarifa Neta") -= Valores.CastDBNull(Fila("neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("Grps") -= Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))

                    Dr("Grps") = Math.Round(Dr("Grps"), 2)
                Next
            End If
        Next

        'toma todas las letras compradas en la celda y suma las tarifas y rating del DT de Resumen
        For Each Dr In ResumenSemana.Rows
            If Columna >= Dr("f_inicio") And Columna <= Dr("f_fin") Then
                For Each s As String In CompraActual
                    Dr("Tarifa Neta") += Valores.CastDBNull(Fila("Neto")) * GrillAdmin.ObtenerDato(Temas, "id_tema='" & s.ToUpper & "'", "duracion")
                    Dr("Grps") += Valores.CastDBNull(Fila(GrillAdmin.ColumnaRatingTarget1))
                Next

                Dr("CPR") = Dr("Tarifa Neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas"))
                Dr("CPR") = Valores.CastNulo(Dr("CPR"))
            End If

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa Neta")
        Next

        'calcula los porcentajes del cuadro de resumen
        Me.CalcularPorcentajes(ResumenSemana, SumaGRPs, SumaTarifaNeta)

        Return ResumenSemana
    End Function

    Private Sub EstructuraSemana(ByVal Semanas As ArrayList)
        ResumenSemana = ObtenerEstructura(TipoCuadroResumen.Semana)

        'agrega mas columnas a la Semanas para calcular despues 
        'si la compra entra en la Semana o no y para sacar la duracion promedio
        ResumenSemana.Columns.Add("f_inicio", GetType(Date))
        ResumenSemana.Columns.Add("f_fin", GetType(Date))
        ResumenSemana.Columns.Add("SumaDuracion", GetType(Integer))
        ResumenSemana.Columns.Add("CantidadTemas", GetType(Integer))

        'inicializa los valores en el DT de Resumen
        For Each S As Semana In Semanas
            Dim NuevaFila As DataRow = ResumenSemana.NewRow

            NuevaFila("f_inicio") = S.FechaInicio
            NuevaFila("f_fin") = S.FechaFin
            NuevaFila("Semana") = S.Descripcion

            NuevaFila("Tarifa Neta") = 0
            NuevaFila("Grps") = 0
            NuevaFila("CPR") = 0
            NuevaFila("CantidadTemas") = 0
            NuevaFila("SumaDuracion") = 0

            ResumenSemana.Rows.Add(NuevaFila)
        Next
    End Sub

    Private Function ObtenerEstructura(ByVal TipoCuadro As TipoCuadroResumen) As DataTable
        Dim Dt As New DataTable

        Dt.Columns.Add(TipoCuadro.ToString, GetType(String))
        Dt.Columns.Add("Grps", GetType(Single))
        Dt.Columns.Add("% Grps", GetType(Single))
        Dt.Columns.Add("Tarifa Neta", GetType(Single))
        Dt.Columns.Add("% Tarifa Neta", GetType(Single))
        Dt.Columns.Add("CPR", GetType(Single))

        Return Dt
    End Function

    Private Function SumarCeldas(ByVal Grilla As UltraGrid, ByVal IndiceFila As Integer, ByVal SumarCol As String, ByVal CompararCol As String, ByVal IgualA As String, Optional ByRef NuevaFila As DataRow = Nothing) As Single
        Dim F As UltraGridRow

        For Each F In Grilla.Rows
            If F.Cells(CompararCol).Text = IgualA Then
                'el nombre de la grilla resumen tiene que 
                If Not NuevaFila Is Nothing Then
                    NuevaFila("soporte") = F.Cells("soporte").Text
                End If

                SumarCeldas += Valores.CastDBNull(F.Cells(SumarCol).Value)
            End If
        Next
    End Function

    Private Sub CalcularPorcentajes(ByVal Resumen As DataTable, ByVal SumaGRPs As Single, ByVal SumaTarifaNeta As Single)
        Dim Dr As DataRow
        Dim TarifaNeta As Single

        For Each Dr In Resumen.Rows
            Dr("% Grps") = 0
            Dr("% Tarifa Neta") = 0

            TarifaNeta = Valores.CastDBNull(Dr("tarifa neta"))

            Dr("% Grps") = Valores.CastNulo(Valores.CastDBNull(Dr("Grps")) / SumaGRPs * 100)
            Dr("% Tarifa Neta") = Valores.CastNulo(TarifaNeta / SumaTarifaNeta * 100)
        Next
    End Sub

    Public Function GrillaPorSoporte(ByVal Grilla As UltraGrid, ByVal Soportes As DataTable, ByVal Temas As DataTable) As DataTable
        'SE PASA UN DATA TABLE CUANDO SE CARGA LA GRILLA DESDE LA BASE
        Dim P, Dr As DataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        Me.TotalSegundos = 0

        For Each Dr In Me.ResumenSoporte.Rows
            SumarCeldasSoporte(Grilla.Rows, Dr("id_soporte"), Dr("Grps"), Dr("Tarifa Neta"), Dr("soporte"), Dr("bruto"))

            Dr("CPR") = Valores.CastNulo(Dr("Tarifa neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas")))

            Me.TotalSegundos += Dr("SumaDuracion")

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa neta")
        Next

        'agregado nuevo, 13/3/06, para que calcule el porcentaje de Duracion
        For Each Dr In Me.ResumenSoporte.Rows
            Dr("PorcentajeDuracion") = Valores.CastNulo(Math.Round(Dr("SumaDuracion") * 100 / TotalSegundos, 2))
        Next

        CalcularPorcentajes(Me.ResumenSoporte, SumaGRPs, SumaTarifaNeta)

        Return Me.ResumenSoporte
    End Function

    Private Sub SumarCeldasSoporte(ByVal Filas As RowsCollection, ByVal IgualA As String, ByRef SumaGrps As Single, ByRef SumaNeto As Single, ByRef TituloSoporte As String, ByRef Bruto As Object)
        'funcion recursiva para solucionar el los problemas con filas agrupadas
        Dim F As UltraGridRow

        For Each F In Filas
            If F.Cells Is Nothing Then
                SumarCeldasSoporte(F.ChildBands(0).Rows, IgualA, SumaGrps, SumaNeto, TituloSoporte, Bruto)
            Else
                If F.Cells("id_soporte").Text = IgualA Then
                    TituloSoporte = F.Cells("soporte").Text

                    SumaGrps += Valores.CastDBNull(F.Cells("Total GRP Target 1").Value)
                    SumaNeto += Valores.CastDBNull(F.Cells("total neto").Value)

                    'agregado 13/03/06, para que muestre tambien el bruto
                    Bruto += Valores.CastDBNull(F.Cells("total bruto").Value)

                End If
            End If
        Next
    End Sub

    Public Function GrillaPorSoporte(ByVal Grilla As UltraGrid, ByVal Soportes As ArrayList, ByVal Temas As DataTable) As DataTable
        'SE PASA UN ARRAY LIST CUANDO SE CARGA POR 1RA VEZ LA GRILLA
        'TRANSFORMA EL ARRAY EN UN DATA TABLE Y LLAMA AL OTRO METODO SOBRECARGADO
        Dim DtSoportes As New DataTable

        With DtSoportes.Columns
            .Add("id_soporte", GetType(Integer))
            .Add("descripcion", GetType(String))
        End With

        Dim I As ItemLista
        Dim Dr As DataRow

        'pasa los datos del Array al Data Table
        For Each I In Soportes
            Dr = DtSoportes.NewRow

            Dr("id_soporte") = I.ID
            Dr("descripcion") = I.Descripcion

            DtSoportes.Rows.Add(Dr)
        Next

        Return GrillaPorSoporte(Grilla, DtSoportes, Temas)
    End Function

    Private Function LetraTema(ByVal Fila As UltraGridRow) As String
        Return Fila.Cells("tema").Text.Substring(5, 1)
    End Function

    Private Function LetraTema(ByVal Fila As UltraDataRow) As String
        Return Fila.Item("tema").ToString.Substring(5, 1)
    End Function

    Public Function GrillaPorTema(ByVal Grilla As UltraDataSource, ByVal Temas As DataTable) As DataTable
        'SE PASA UN DATA TABLE CUANDO SE CARGA LA GRILLA DESDE LA BASE
        'Dim Resumen As DataTable
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single
        Dim Dr As DataRow
        Dim Ur As UltraDataRow
        Dim Hijo As UltraDataRow
        Dim ContBanda As Integer = 0

        Me.EstructuraTema(Temas)

        'AG Original ==============================================================================
        'For Each Dr In Me.ResumenTema.Rows
        '    ContBanda = 0

        '    For Each Ur In Grilla.Rows
        '        Try
        '            Dim i As Integer = 0

        '            Do While Ur.GetChildRows(i).Count = 0
        '                i += 1
        '            Loop

        '            For Each Hijo In Ur.GetChildRows(i)
        '                If Dr("id_tema") = UCase(Hijo.Tag) Then
        '                    Dr("Grps") += Valores.CastDBNull(Hijo("Total GRP Target 1"))
        '                    Dr("Tarifa Neta") += Valores.CastDBNull(Hijo("Total Neto"))
        '                    Dr("Temas") += Valores.CastDBNull(Hijo("Total Spots"))
        '                End If
        '            Next

        '            Dr("CPR") = Valores.CastNulo(Dr("Tarifa Neta") / Dr("Grps") / Dr("duracion"))
        '        Catch ex As ArgumentOutOfRangeException
        '        End Try
        '    Next

        '    SumaGRPs += Dr("Grps")
        '    SumaTarifaNeta += Dr("Tarifa neta")
        'Next
        '=============================================================================================

        'AG Velocidad ==================================
        ContBanda = 0
        Dim DrTema() As DataRow
        For Each Ur In Grilla.Rows
            Try
                Dim i As Integer = 0
                Do While Ur.GetChildRows(i).Count = 0
                    i += 1
                Loop
                For Each Hijo In Ur.GetChildRows(i)
                    DrTema = ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")
                    If DrTema.Length > 0 Then
                        ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("Grps") += Valores.CastDBNull(Hijo("Total GRP Target 1"))
                        ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("Tarifa Neta") += Valores.CastDBNull(Hijo("Total Neto"))
                        ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("Temas") += Valores.CastDBNull(Hijo("Total Spots"))
                        ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("CPR") = Valores.CastDBNull(ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("Tarifa Neta") / ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("Grps") / ResumenTema.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("duracion"))
                    End If
                Next
            Catch ex As ArgumentOutOfRangeException
            End Try
        Next
        For Each Dr In Me.ResumenTema.Rows
            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa neta")
        Next
        '=================================================================================



        CalcularPorcentajes(Me.ResumenTema, SumaGRPs, SumaTarifaNeta)

        Return Me.ResumenTema
    End Function

    Public Function GrillaPorSemana(ByVal UDS As UltraDataSource, ByVal Temas As DataTable, Optional ByVal FechaFinSistema As Date = #1/1/1900#) As DataTable
        'SE PASA UN DATA TABLE CUANDO SE CARGA LA GRILLA DESDE LA BASE
        Dim SumaGRPs As Single, SumaTarifaNeta As Single
        Dim Ur As UltraDataRow, Uc As UltraDataColumn

        If FechaFinSistema = #1/1/1900# Then
            Me.EstructuraSemana(Me.ObtenerSemanasCalendario(UDS))
        Else
            Me.EstructuraSemana(Me.ObtenerSemanas7Dias(UDS, FechaFinSistema))
        End If

        For Each Dr As DataRow In Me.ResumenSemana.Rows

            Dim cantidadAvisos As New Dictionary(Of String, Integer)

            For Each Ur In UDS.Rows

                Dr("Grps") += TotalGRPs(Ur, Dr("f_inicio"), Dr("f_fin"))

                Dr("Tarifa Neta") += TotalTarifaNeta(Ur, Dr, Temas)
                'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
                TotalSemanaDuracion(Ur, Dr("f_inicio"), Dr("f_fin"), cantidadAvisos)

            Next
            'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
            For Each par As KeyValuePair(Of String, Integer) In cantidadAvisos

                'az si es minuscula que tome mayuscula .ToUpper  05/05/2015 
                Dim tema() As DataRow = Temas.Select("ID_TEMA = '" & par.Key.ToUpper & "'")

                Dim duracionTema As Integer = 0

                If tema.Length > 0 Then
                    duracionTema = tema(0).Item("DURACION")
                End If

                Dr("CantidadTemas") += par.Value
                Dr("SumaDuracion") += par.Value * duracionTema

            Next

            Dim pruebadatos As String = Valores.CastNulo(Dr("Tarifa neta") / Dr("Grps") / Dr("SumaDuracion"))

            Dr("CPR") += Valores.CastNulo(Dr("Tarifa neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas")))

            '===============================================
            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa Neta")
        Next

        CalcularPorcentajes(Me.ResumenSemana, SumaGRPs, SumaTarifaNeta)

        Return Me.ResumenSemana
    End Function

    Private Function TotalTarifaNeta(ByVal Fila As UltraDataRow, ByVal Semana As DataRow, ByVal Temas As DataTable) As Single
        Dim Uc As UltraDataColumn, Ur As UltraDataRow, Filas As UltraDataRowsCollection
        Dim Dr As DataRow

        If Not Temas.Columns.Contains("CantidadTemas") Then
            Temas.Columns.Add("CantidadTemas", GetType(Integer))
        End If

        For Each Dr In Temas.Rows
            Dr("CantidadTemas") = 0
        Next

        Try
            'busca el indice de la banda que tiene las filas hijas (por la mala logica de al grilla)
            Dim i As Integer = 0

            Filas = Fila.GetChildRows(i)

            Do While Filas.Count = 0
                i += 1
                Filas = Fila.GetChildRows(i)
            Loop
        Catch ex As ArgumentOutOfRangeException
            Return 0
        End Try

        'cuenta la cantidad de temas
        For Each Ur In Filas
            For Each Uc In Filas.Band.Columns

                If EsColumnaCalendarioSemana(Uc, Semana("f_inicio"), Semana("f_fin")) Then

                    Try
                        Temas.CaseSensitive = True
                        Dr = Temas.Select("id_tema='" & LetraTema(Ur).ToUpper & "'")(0)

                        If IsDBNull(Dr("CantidadTemas")) Then
                            Dr("CantidadTemas") = 0
                        End If

                        Dr("CantidadTemas") += Val(Valores.CastDBNull(Ur.Item(Uc.Key)))
                        'Semana("CantidadTemas") = Dr("CantidadTemas")

                    Catch ind As IndexOutOfRangeException
                    End Try

                End If
            Next
        Next

        'Total Tarifa Neta: Sumatoria Netos ('neto = cantidad avisos * duracion * neto) de los diferentes temas
        For Each Dr In Temas.Rows
            If IsDBNull(Dr("CantidadTemas")) Then
                Dr("CantidadTemas") = 0
            End If

            TotalTarifaNeta += Dr("CantidadTemas") * Dr("duracion") * Valores.CastDBNull(Fila.Item("Neto"))
            'Semana("SumaDuracion") += Dr("duracion")
        Next
    End Function

    'LC 06/08/2014 Desgloses hoja de planificacion TV y calculo automatico
    Private Sub TotalSemanaDuracion(ByVal Fila As UltraDataRow, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByRef cantidadAvisos As Dictionary(Of String, Integer))
        For Each Uc As UltraDataColumn In Fila.Band.Columns
            If EsColumnaCalendarioSemana(Uc, FechaDesde, FechaHasta) Then
                If Fila.Item(Uc.Key).ToString <> String.Empty Then
                    For Each tema As Char In Fila.Item(Uc.Key).ToString
                        If Not cantidadAvisos.ContainsKey(tema) Then
                            cantidadAvisos.Add(tema, 1)
                        Else
                            cantidadAvisos.Item(tema) += 1
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    Private Function TotalGRPs(ByVal Fila As UltraDataRow, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Single
        Dim Uc As UltraDataColumn
        Dim CantidadTemas As Integer

        For Each Uc In Fila.Band.Columns

            If EsColumnaCalendarioSemana(Uc, FechaDesde, FechaHasta) Then
                CantidadTemas += Fila.Item(Uc.Key).ToString.Length
            End If

        Next

        Return CantidadTemas * Fila.Item(GrillAdmin.ColumnaRatingTarget1)
    End Function

    Private Function EsColumnaCalendarioSemana(ByVal Uc As UltraDataColumn, ByVal Semana As Semana) As Boolean
        If GrillAdmin.EsColumnaCalendario(Uc) Then
            If Uc.Key >= Semana.FechaInicio And Uc.Key <= Semana.FechaFin Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Function EsColumnaCalendarioSemana(ByVal Uc As UltraDataColumn, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Boolean
        If GrillAdmin.EsColumnaCalendario(Uc) Then
            If Uc.Key >= FechaDesde And Uc.Key <= FechaHasta Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Function EsColumnaCalendarioSemana(ByVal Uc As UltraGridColumn, ByVal Semana As Semana) As Boolean
        If GrillAdmin.EsColumnaCalendario(Uc) Then
            If Uc.Key >= Semana.FechaInicio And Uc.Key <= Semana.FechaFin Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function ObtenerSemanas7Dias(ByVal UDS As UltraDataSource, ByVal FechaFinSistema As Date) As ArrayList
        'SEMANA DE 7 DIAS
        Dim Semanas As New ArrayList
        Dim i As Integer
        Dim Uc As UltraDataColumn
        Dim S As Semana

        For i = 0 To UDS.Band.Columns.Count - 1
            Uc = UDS.Band.Columns(i)

            If GrillAdmin.EsColumnaCalendario(Uc) Then
                S = New Semana

                S.FechaInicio = Uc.Key

                i += 6

                Try
                    Uc = UDS.Band.Columns(i)

                    If Not GrillAdmin.EsColumnaCalendario(Uc) Then
                        S.FechaFin = FechaFinSistema
                    Else
                        S.FechaFin = Uc.Key
                    End If
                Catch ex As ArgumentOutOfRangeException
                    i -= 6

                    Do While GrillAdmin.EsColumnaCalendario(UDS.Band.Columns(i))
                        i += 1
                    Loop

                    S.FechaFin = UDS.Band.Columns(i - 1).Key

                    Semanas.Add(S)

                    Exit For
                End Try

                Semanas.Add(S)
            End If
        Next

        Return Semanas
    End Function

    Public Function ObtenerSemanasCalendario(ByVal Grilla As UltraDataSource) As ArrayList
        'SEMANA CALENDARIO
        Dim Semanas As New ArrayList
        Dim i As Integer
        Dim Uc As UltraDataColumn
        Dim S As Semana

        For i = 0 To Grilla.Band.Columns.Count - 1
            Uc = Grilla.Band.Columns(i)

            If GrillAdmin.EsColumnaCalendario(Uc) Then

                'recorre todas las columnas del calendario
                Do While GrillAdmin.EsColumnaCalendario(Uc)
                    S = New Semana

                    S.FechaInicio = Uc.Key

                    'busca el dia domingo
                    Do While Me.DiaSemana(Uc.Key) <> DiasSemana.Domingo
                        S.FechaFin = Uc.Key

                        i += 1
                        Uc = Grilla.Band.Columns(i)

                        If Not GrillAdmin.EsColumnaCalendario(Uc) Then
                            Exit Do
                        End If
                    Loop

                    If GrillAdmin.EsColumnaCalendario(Uc) Then
                        S.FechaFin = Uc.Key
                    End If

                    Semanas.Add(S)

                    i += 1
                    Uc = Grilla.Band.Columns(i)
                Loop

            End If
        Next

        Return Semanas
    End Function

    Public Sub ObtenerDuracionPromedioSemana(ByVal Grilla As UltraDataSource, ByVal Temas As DataTable)
        Dim Ur As UltraDataRow
        Dim Uc As UltraDataColumn
        Dim Tema As DataRow
        Dim Dr As DataRow

        'recorre las filas de la grilla
        For Each Ur In Grilla.Rows

            If Not Ur("Total Spots") Is DBNull.Value Then

                'recorre las columnas
                For Each Uc In Ur.Band.Columns

                    'si es una columna del calenadrio
                    If GrillAdmin.EsColumnaCalendario(Uc) Then

                        'recorre los temas
                        For Each Tema In Temas.Rows
                            Dr = Me.ResumenSemana.Select("f_inicio <= '" & Uc.Key & "' and f_fin >= '" & Uc.Key & "'")(0)

                            If Not Ur(Uc.Key) Is DBNull.Value Then
                                'suma la cantidad de temas que hay
                                Dr("CantidadTemas") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur(Uc.Key))

                                'suma las duraciones de todos los temas
                                Dr("SumaDuracion") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur(Uc.Key)) * Tema("duracion")
                            End If
                        Next

                    End If
                Next
            End If

        Next
    End Sub

    Public Sub ObtenerDuracionPromedio(ByVal UDS As UltraDataSource, ByVal Franjas As DataTable, ByVal Soportes As Object, ByVal Temas As DataTable, Optional ByVal EsSemanaCalendario As Boolean = False, Optional ByVal EsActualizacionSoporte As Boolean = False)
        Dim Ur As UltraDataRow
        Dim Uc As UltraDataColumn
        Dim Tema, Soporte, Semana, Franja As DataRow
        Me.EstructuraSoporte(Soportes)

        If Not EsActualizacionSoporte Then
            Me.EstructuraFranja(Franjas)
            If EsSemanaCalendario Then
                Me.EstructuraSemana(Me.ObtenerSemanasCalendario(UDS))
            Else
                Me.EstructuraSemana(Me.ObtenerSemanas7Dias(UDS, Activo.FechaFinSistema))
            End If
        End If
        Try
            'recorre las filas de la grilla
            For Each Ur In UDS.Rows

                If Not Ur("Total Spots") Is DBNull.Value Then
                    'recorre las columnas
                    For Each Uc In Ur.Band.Columns

                        'si es una columna del calenadrio
                        If GrillAdmin.EsColumnaCalendario(Uc) Then

                            'recorre los temas
                            For Each Tema In Temas.Rows
                                Dim Cantidad As Integer = GrillAdmin.ContarLetras(Tema("id_tema"), Valores.CastDBNullObject(Ur(Uc.Key)))
                                Dim Duracion As Integer = Cantidad * Tema("duracion")

                                'If Uc.Key = "01/01/2006" Then
                                '    Stop
                                'End If

                                If Cantidad > 0 Then
                                    '*** SOPORTE
                                    Soporte = Me.ResumenSoporte.Select("id_soporte=" & Ur("id_soporte"))(0)

                                    'suma la cantidad de temas que hay
                                    Soporte("CantidadTemas") += Cantidad

                                    'suma las duraciones de todos los temas
                                    Soporte("SumaDuracion") += Duracion
                                    '***

                                    '*** FRANJA
                                    Try
                                        Franja = Me.ResumenFranja.Select("h_desde <=" & Ur("h_inicio").ToString.Substring(0, 2) & " and h_hasta >= " & Ur("h_inicio").ToString.Substring(0, 2))(0)

                                        If Not Ur(Uc.Key) Is DBNull.Value Then
                                            'suma la cantidad de temas que hay
                                            Franja("CantidadTemas") += Cantidad

                                            'suma las duraciones de todos los temas
                                            Franja("SumaDuracion") += Duracion
                                        End If
                                    Catch ex As IndexOutOfRangeException
                                    Catch ex As Exception
                                        Mensajes.Mensaje("GrillaResumen.ObtenerDuracionPromedioFranja: " & ex.Message, TipoMensaje.DeError)
                                    End Try
                                    '***

                                    '*** SEMANA
                                    Semana = Me.ResumenSemana.Select("f_inicio <= '" & Uc.Key & "' and f_fin >= '" & Uc.Key & "'")(0)

                                    If Not Ur(Uc.Key) Is DBNull.Value Then
                                        'suma la cantidad de temas que hay
                                        Semana("CantidadTemas") += Cantidad

                                        'suma las duraciones de todos los temas
                                        Semana("SumaDuracion") += Duracion
                                    End If
                                    '***
                                End If

                            Next

                        End If
                    Next
                End If

            Next
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub ObtenerDuracionPromedioSoporte(ByVal Grilla As UltraGrid, ByVal Temas As DataTable)
        Dim Ur As UltraGridRow
        Dim Uc As UltraGridColumn
        Dim Tema As DataRow
        Dim Dr As DataRow

        'guarda el promedio de duracion por soporte

        'recorre las filas de la grilla
        For Each Ur In Grilla.Rows

            If Not Ur.Cells("Total Spots").Value Is DBNull.Value Then
                'recorre las columnas
                For Each Uc In Ur.Band.Columns

                    'si es una columna del calenadrio
                    If GrillAdmin.EsColumnaCalendario(Uc) Then

                        'recorre los temas
                        For Each Tema In Temas.Rows
                            Dr = Me.ResumenSoporte.Select("id_soporte=" & Ur.Cells("id_soporte").Value)(0)

                            'suma la cantidad de temas que hay
                            Dr("CantidadTemas") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur.Cells(Uc.Key).Text)

                            'suma las duraciones de todos los temas
                            Dr("SumaDuracion") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur.Cells(Uc.Key).Text) * Tema("duracion")
                        Next

                    End If
                Next
            End If

        Next
    End Sub

    Public Sub ObtenerDuracionPromedioFranja(ByVal UDS As UltraDataSource, ByVal Temas As DataTable)
        Dim Ur As UltraDataRow
        Dim Uc As UltraDataColumn
        Dim Tema, Dr As DataRow

        'recorre las filas de la grilla
        For Each Ur In UDS.Rows

            If Not Ur("Total Spots") Is DBNull.Value Then

                'recorre las columnas
                For Each Uc In Ur.Band.Columns

                    'si es uan columna del calenadrio
                    If GrillAdmin.EsColumnaCalendario(Uc) Then

                        'recorre los temas
                        For Each Tema In Temas.Rows
                            Try
                                Dr = Me.ResumenFranja.Select("h_desde <=" & Ur("h_inicio").ToString.Substring(0, 2) & " and h_hasta >= " & Ur("h_inicio").ToString.Substring(0, 2))(0)

                                If Not Ur(Uc.Key) Is DBNull.Value Then
                                    'suma la cantidad de temas que hay
                                    Dr("CantidadTemas") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur(Uc.Key))

                                    'suma las duraciones de todos los temas
                                    Dr("SumaDuracion") += GrillAdmin.ContarLetras(Tema("id_tema"), Ur(Uc.Key)) * Tema("duracion")
                                End If
                            Catch ex As IndexOutOfRangeException
                            Catch ex As Exception
                                Mensajes.Mensaje("GrillaResumen.ObtenerDuracionPromedioFranja: " & ex.Message, TipoMensaje.DeError)
                            End Try
                        Next

                    End If
                Next

            End If

        Next
    End Sub

    Public Function GrillaPorFranja(ByVal Grilla As UltraDataSource, ByVal Franjas As DataTable, ByVal Temas As DataTable) As DataTable
        Dim Dr As DataRow
        Dim P As DataRow
        Dim Ur As UltraDataRow
        Dim SumaGRPs As Single
        Dim SumaTarifaNeta As Single

        For Each Dr In Me.ResumenFranja.Rows
            For Each Ur In Grilla.Rows
                If Ur("H_inicio").ToString.Substring(0, 2) >= Dr("h_desde") And Ur("H_inicio").ToString.Substring(0, 2) <= Dr("h_hasta") Then
                    Dr("Grps") += Valores.CastDBNull(Ur("Total GRP Target 1"))
                    Dr("Tarifa Neta") += Valores.CastDBNull(Ur("Total Neto"))
                End If
            Next

            Dr("CPR") = Valores.CastNulo(Dr("Tarifa neta") / Dr("Grps") / (Dr("SumaDuracion") / Dr("CantidadTemas")))

            SumaGRPs += Dr("Grps")
            SumaTarifaNeta += Dr("Tarifa neta")
        Next

        CalcularPorcentajes(Me.ResumenFranja, SumaGRPs, SumaTarifaNeta)

        Return Me.ResumenFranja
    End Function
    Public Sub CalcularCrpGlobal(ByVal Grilla As UltraGrid, ByVal lblCPR As Label)

        cNeto = 0
        cCantAvisos = 0
        cGrps = 0
        cSegundos = 0
        cCpr = 0
        ''Total Neto
        'Neto = Grilla.Rows.SummaryValues(1).

        ''Total Avisos
        'CantAvisos = Grilla.Rows.SummaryValues(2).Value

        ''Grps Target 1
        'Grps = Grilla.Rows.SummaryValues(3).Value

        'Segundos = ObtenerTotalSegundos(Grilla)

        For Each r As UltraGridRow In Grilla.Rows
            If r.Cells("Total Neto").Value Is DBNull.Value Then
                cNeto += 0
            Else
                cNeto += r.Cells("Total Neto").Value
            End If
            If r.Cells("Total spots").Value Is DBNull.Value Then
                cCantAvisos += 0
            Else
                cCantAvisos += r.Cells("Total Spots").Value
            End If
            If r.Cells("Total GRP Target 1").Value Is DBNull.Value Then
                cGrps += 0
            Else
                cGrps += r.Cells("Total GRP Target 1").Value
            End If
        Next
        cSegundos = ObtenerTotalSegundosTotales(Grilla)



        cCpr = Valores.CastNulo((cNeto * cCantAvisos) / (cGrps * cSegundos))

        lblCPR.Tag = CStr(cCpr)



    End Sub


    Public Sub CalcularTotalesResumen(ByVal Grilla As UltraGrid, ByVal lblGRPs As Label, ByVal lblAvisos As Label, ByVal lblSegundos As Label, ByVal lblBruto As Label, ByVal lblNeto As Label, ByVal lblCPR As Label, ByVal lblDurPromedio As Label, ByVal UDS As UltraDataSource, ByVal DtTemas As DataTable, Optional ByVal ControlarFiltro As Boolean = False)
        Dim Formato As String = "#,##0.00"

        'Total Bruto
        lblBruto.Text = Grilla.Rows.SummaryValues(0).Value

        'Total Neto
        lblNeto.Text = Grilla.Rows.SummaryValues(1).Value

        'Total Avisos
        lblAvisos.Text = Grilla.Rows.SummaryValues(2).Value

        'Grps Target 1
        lblGRPs.Text = Grilla.Rows.SummaryValues(3).Value

        'Segundos
        'If Not ControlarFiltro Then
        ' lblSegundos.Text = Me.TotalSegundos
        ' Else
        lblSegundos.Text = ObtenerTotalSegundos(Grilla)
        ' End If


        'CPR
        lblCPR.Text = lblNeto.Text / lblGRPs.Text / (lblSegundos.Text / lblAvisos.Text)
        'Activo.CalculoCpr.CPR = lblGRPs
        lblGRPs.Text = Valores.Redondear(lblGRPs.Text, Formato)
        lblBruto.Text = Valores.Redondear(lblBruto.Text, Formato)
        lblNeto.Text = Valores.Redondear(lblNeto.Text, Formato)
        lblCPR.Text = Valores.CastNulo(lblCPR.Text)
        lblCPR.Text = Valores.Redondear(lblCPR.Text, Formato)

        CalcularCrpGlobal(Grilla, lblCPR)


        'AG CPR 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If lblAvisos.Text <> "0" Then
            Dim DtResultadoCPRDurPromedio As DataTable = ObtenerGrpsPromedioPauta(UDS, DtTemas)
            If DtResultadoCPRDurPromedio.Rows.Count > 0 Then
                lblCPR.Text = Valores.Redondear(DtResultadoCPRDurPromedio.Rows(0)("CPRPromFinalPauta").ToString, Formato)
                lblDurPromedio.Text = Valores.Redondear(DtResultadoCPRDurPromedio.Rows(0)("DurPromFinalPauta").ToString, Formato)
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        ' Dim G As New CalculoGRP

    End Sub

    Public Function ObtenerGrpsPromedioPauta(ByVal UDS As UltraDataSource, ByVal DtTemas As DataTable) As DataTable 'AG CPR 22/01/2013

        Dim FilaNueva As DataRow
        Dim Dr As DataRow
        Dim Ur As UltraDataRow
        Dim Hijo As UltraDataRow

        Dim DtTemasGrps As DataTable = ObtenerEstructuraDtGRPS_CPR_Promedio(1)

        For Each Dr In DtTemas.Rows
            FilaNueva = DtTemasGrps.NewRow
            FilaNueva("id_tema") = Dr("id_tema")
            FilaNueva("Duracion") = Dr("Duracion")
            FilaNueva("TotalGrps") = 0
            FilaNueva("SumaTotalInversion") = 0
            FilaNueva("CantTemas") = 0
            FilaNueva("CalculoPonderado1") = 0
            FilaNueva("CalculoPonderado2") = 0
            DtTemasGrps.Rows.Add(FilaNueva)
        Next

        'AG Original ======================================
        'For Each Dr In DtTemasGrps.Rows
        '    For Each Ur In UDS.Rows
        '        Try
        '            Dim i As Integer = 0
        '            Do While Ur.GetChildRows(i).Count = 0
        '                i += 1
        '            Loop
        '            For Each Hijo In Ur.GetChildRows(i)
        '                If Dr("id_tema") = UCase(Hijo.Tag) Then
        '                    Dr("TotalGrps") += Valores.CastDBNull(Hijo("Total GRP Target 1"))
        '                    Dr("SumaTotalInversion") += Valores.CastDBNull(Hijo("Total Neto"))
        '                    Dr("CantTemas") += Valores.CastDBNull(Hijo("Total Spots"))
        '                End If
        '            Next
        '        Catch ex As ArgumentOutOfRangeException
        '        End Try
        '    Next
        'Next
        '===================================================

        'AG Velocidad ==========================================
        Dim DrTema() As DataRow
        For Each Ur In UDS.Rows
            Try
                Dim i As Integer = 0
                Do While Ur.GetChildRows(i).Count = 0
                    i += 1
                Loop
                For Each Hijo In Ur.GetChildRows(i)
                    DrTema = DtTemasGrps.Select("id_tema ='" & UCase(Hijo.Tag) & "'")
                    If DrTema.Length > 0 Then
                        DtTemasGrps.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("TotalGrps") += Valores.CastDBNull(Hijo("Total GRP Target 1"))
                        DtTemasGrps.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("SumaTotalInversion") += Valores.CastDBNull(Hijo("Total Neto"))
                        DtTemasGrps.Select("id_tema ='" & UCase(Hijo.Tag) & "'")(0)("CantTemas") += Valores.CastDBNull(Hijo("Total Spots"))
                    End If
                Next
            Catch ex As ArgumentOutOfRangeException
            End Try
        Next
        '=======================================================


        'AG 15/02/2013 +++++++++++++++++++++++++
        'Sumo el Total de todos los GRPs de cada Tema +++
        Dim TotalGrpsPauta As Single = DtTemasGrps.Compute("sum(TotalGrps)", "")
        Dim TotalInversionPauta As Single = DtTemasGrps.Compute("sum(SumaTotalInversion)", "")
        Dim Drs As DataRow

        For Each Drs In DtTemasGrps.Rows
            If Drs("CantTemas") > 0 Then
                If Drs("TotalGrps") > 0 Then
                    Drs("CalculoPonderado1") = Drs("TotalGrps") / TotalGrpsPauta
                    Drs("CalculoPonderado2") = Drs("CalculoPonderado1") * Drs("Duracion")
                Else
                    Drs("CalculoPonderado1") = 0
                    Drs("CalculoPonderado2") = 0
                End If
            End If
        Next

        Dim DtDatosFinalPautas As DataTable = ObtenerEstructuraDtGRPS_CPR_Promedio(2)
        Dim DurPromedioFinal, CprPromedioFinal As Single
        'AG 22/01/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'Realizo el calculo final del CPR y Duracion
        DurPromedioFinal = DtTemasGrps.Compute("sum(CalculoPonderado2)", "")

        If DurPromedioFinal > 0 Then
            CprPromedioFinal = TotalInversionPauta / TotalGrpsPauta / DurPromedioFinal
        Else
            CprPromedioFinal = 0
        End If

        FilaNueva = DtDatosFinalPautas.NewRow
        FilaNueva("DurPromFinalPauta") = DurPromedioFinal
        FilaNueva("CPRPromFinalPauta") = CprPromedioFinal
        DtDatosFinalPautas.Rows.Add(FilaNueva)
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Return DtDatosFinalPautas

    End Function

    Private Function ObtenerEstructuraDtGRPS_CPR_Promedio(ByVal TipoDt As Integer) As DataTable

        Dim Dt As New DataTable

        If TipoDt = 1 Then
            Dt.Columns.Add("id_tema", GetType(String))
            Dt.Columns.Add("Duracion", GetType(String))
            Dt.Columns.Add("TotalGrps", GetType(Single))
            Dt.Columns.Add("SumaTotalInversion", GetType(Single))
            Dt.Columns.Add("CantTemas", GetType(Integer))
            Dt.Columns.Add("CalculoPonderado1", GetType(Single))
            Dt.Columns.Add("CalculoPonderado2", GetType(Single))
        ElseIf TipoDt = 2 Then
            Dt.Columns.Add("DurPromFinalPauta", GetType(Single))
            Dt.Columns.Add("CPRPromFinalPauta", GetType(Single))
        End If

        Return Dt
    End Function


    Private Function ObtenerTotalSegundos(ByVal grilla As UltraGrid) As Integer
        Dim s As Integer
        Try
            For Each r As UltraGridRow In grilla.Rows
                If Not r Is Nothing Then
                    If Not r.IsFilteredOut Then
                        For Each b As UltraGridChildBand In r.ChildBands
                            If Not b Is Nothing Then
                                For Each br As UltraGridRow In b.Rows
                                    If Not br Is Nothing Then
                                        s += (br.Cells("dur").Value * IIf(br.Cells("Total Spots").Value Is DBNull.Value, 0, br.Cells("Total Spots").Value))
                                    End If
                                Next
                            End If
                        Next
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        Return s
    End Function
    Private Function ObtenerTotalSegundosTotales(ByVal grilla As UltraGrid) As Integer
        Dim s As Integer
        Try
            For Each r As UltraGridRow In grilla.Rows
                If Not r Is Nothing Then
                    For Each b As UltraGridChildBand In r.ChildBands
                        If Not b Is Nothing Then
                            For Each br As UltraGridRow In b.Rows
                                If Not br Is Nothing Then
                                    s += (br.Cells("dur").Value * IIf(br.Cells("Total Spots").Value Is DBNull.Value, 0, br.Cells("Total Spots").Value))
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Catch ex As Exception

        End Try
        Return s
    End Function
    Public Sub ActualizarCPR(ByVal Fila As UltraDataRow)
        'actualiza el CPR del programa
        Fila("CPR") = Fila("Neto") / Fila(GrillAdmin.ColumnaRatingTarget1)
        Fila("CPR") = Valores.CastNulo(Fila("CPR"))
    End Sub

    Public Sub ActualizarTotalesResumen(ByVal CompraAnterior As String, ByVal CompraActual As String, ByVal Fila As UltraDataRow, ByVal Temas As DataTable, ByVal lblGRPs As Label, ByVal lblAvisos As Label, ByVal lblSegundos As Label, ByVal lblBruto As Label, ByVal lblNeto As Label, ByVal lblCPR As Label, ByVal lblDurPromedio As Label, ByVal UDS As UltraDataSource)
        Dim Duracion As Integer
        Dim Formato As String = "#,##0.00"

        For Each S As String In CompraAnterior
            lblGRPs.Text -= Fila(GrillAdmin.ColumnaRatingTarget1)
            cGrps -= Fila(GrillAdmin.ColumnaRatingTarget1)
            lblAvisos.Text -= 1
            cCantAvisos -= 1

            Duracion = GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")

            lblSegundos.Text -= Duracion
            cSegundos -= Duracion
            lblBruto.Text -= Fila("Bruto") * Duracion
            lblNeto.Text -= Valores.CastDBNull(Fila("Neto")) * Duracion
            cNeto -= Valores.CastDBNull(Fila("Neto")) * Duracion
            'lblCPR.Text = lblNeto.Text / lblGRPs.Text / (lblSegundos.Text / lblAvisos.Text)
            'cCpr = (cNeto * cCantAvisos) / (cGrps * cSegundos)
            If lblGRPs.Text <> 0 And lblAvisos.Text <> 0 And lblSegundos.Text <> 0 Then
                lblCPR.Text = lblNeto.Text / lblGRPs.Text / (lblSegundos.Text / lblAvisos.Text)
            Else
                lblCPR.Text = 0
            End If

            If cGrps * cSegundos = 0 Then
                cCpr = 0
            Else
                cCpr = (cNeto * cCantAvisos) / (cGrps * cSegundos)
            End If
        Next

        For Each S As String In CompraActual
            lblGRPs.Text += Fila(GrillAdmin.ColumnaRatingTarget1)
            cGrps += Fila(GrillAdmin.ColumnaRatingTarget1)
            lblAvisos.Text += 1
            cCantAvisos += 1

            Duracion = GrillAdmin.ObtenerDato(Temas, "id_tema='" & S.ToUpper & "'", "duracion")

            lblSegundos.Text += Duracion
            cSegundos += Duracion
            lblBruto.Text += Fila("Bruto") * Duracion
            lblNeto.Text += Valores.CastDBNull(Fila("Neto")) * Duracion
            cNeto += Valores.CastDBNull(Fila("Neto")) * Duracion
            'lblCPR.Text = lblNeto.Text / lblGRPs.Text / (lblSegundos.Text / lblAvisos.Text)
            If lblGRPs.Text <> 0 And lblAvisos.Text <> 0 And lblSegundos.Text <> 0 Then
                lblCPR.Text = lblNeto.Text / lblGRPs.Text / (lblSegundos.Text / lblAvisos.Text)
            Else
                lblCPR.Text = 0
            End If

            If cGrps * cSegundos = 0 Then
                cCpr = 0
            Else
                cCpr = (cNeto * cCantAvisos) / (cGrps * cSegundos)
            End If
        Next
        '  Me.CalcularCrpGlobal(grilla, lblCPR)
        lblGRPs.Text = Valores.Redondear(lblGRPs.Text, Formato)
        lblBruto.Text = Valores.Redondear(lblBruto.Text, Formato)
        lblNeto.Text = Valores.Redondear(lblNeto.Text, Formato)
        lblCPR.Text = Valores.CastNulo(lblCPR.Text)
        lblCPR.Text = Valores.Redondear(lblCPR.Text, Formato)
        lblCPR.Tag = Valores.Redondear(cCpr, Formato)

        lblDurPromedio.Text = Valores.CastNulo(lblDurPromedio.Text)

        'AG CPR 18/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If lblAvisos.Text <> "0" Then
            Dim DtResultadoCPRDurPromedio As DataTable = ObtenerGrpsPromedioPauta(UDS, Temas)
            If DtResultadoCPRDurPromedio.Rows.Count > 0 Then
                lblCPR.Text = Valores.Redondear(DtResultadoCPRDurPromedio.Rows(0)("CPRPromFinalPauta").ToString, Formato)
                lblDurPromedio.Text = Valores.Redondear(DtResultadoCPRDurPromedio.Rows(0)("DurPromFinalPauta").ToString, Formato)
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        'AG 05/05/2016 =====================
        If lblAvisos.Text < 0 Then
            lblAvisos.Text = 0
        End If

        If lblGRPs.Text <= 0 Then
            lblGRPs.Text = 0
        End If

        If lblBruto.Text < 0 Then
            lblBruto.Text = 0
        End If

        If lblNeto.Text < 0 Then
            lblNeto.Text = 0
        End If

        If lblCPR.Text < 0 Then
            lblCPR.Text = 0
        End If

        If lblSegundos.Text < 0 Then
            lblSegundos.Text = 0
        End If

        If lblDurPromedio.Text < 0 Then
            lblDurPromedio.Text = 0
        End If
        '=========================================

    End Sub

    Private Function DiaSemana(ByVal Fecha As Date) As DiasSemana
        Return Weekday(Fecha)
    End Function
End Class

Public Class Semana
    Dim mFechaInicio As Date
    Dim mFechaFin As Date
    Dim mCantidadSpots As Integer
    Dim mTotalDuracion As Single

    Public ReadOnly Property Descripcion() As String
        Get
            Return "Semana " & FechaInicio.Day & "/" & FechaInicio.Month & " - " & _
            FechaFin.Day & "/" & FechaFin.Month
        End Get
    End Property

    Public Property FechaInicio() As Date
        Get
            Return mFechaInicio
        End Get
        Set(ByVal Value As Date)
            mFechaInicio = Value
        End Set
    End Property

    Public Property FechaFin() As Date
        Get
            Return mFechaFin
        End Get
        Set(ByVal Value As Date)
            mFechaFin = Value
        End Set
    End Property

    Public Property CantidadSpots() As Integer
        Get
            Return mCantidadSpots
        End Get
        Set(ByVal Value As Integer)
            mCantidadSpots = Value
        End Set
    End Property

    Public Property TotalDuracion() As Single
        Get
            Return mTotalDuracion
        End Get
        Set(ByVal Value As Single)
            mTotalDuracion = Value
        End Set
    End Property

    Public ReadOnly Property DuracionPromedio() As Single
        Get
            Return TotalDuracion / CantidadSpots
        End Get
    End Property
End Class

Public Class SoporteDuracion
    Dim mIDSoporte As Integer
    Dim mSoporte As String
    Dim mTotalDuracion As Integer
    Dim mCantidadTemas As Integer

    Public Property IDSoporte() As Integer
        Get
            Return mIDSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDSoporte = Value
        End Set
    End Property

    Public Property Soporte() As String
        Get
            Return mSoporte
        End Get
        Set(ByVal Value As String)
            mSoporte = Value
        End Set
    End Property

    Public Property TotalDuracion() As Integer
        Get
            Return mTotalDuracion
        End Get
        Set(ByVal Value As Integer)
            mTotalDuracion = Value
        End Set
    End Property

    Public Property CantidadTemas() As Integer
        Get
            Return mCantidadTemas
        End Get
        Set(ByVal Value As Integer)
            mCantidadTemas = Value
        End Set
    End Property

    Public ReadOnly Property DuracionPromedio() As Single
        Get
            Return TotalDuracion / CantidadTemas
        End Get
    End Property
End Class

Public Class CantidadDuracion
    Public Cantidad As Integer
    Public SumaDuracion As Integer

    Public ReadOnly Property Promedio() As Single
        Get
            Return SumaDuracion / Cantidad
        End Get
    End Property
End Class

Public Enum TipoCuadroResumen
    Soporte
    Franja
    Tema
    Semana
End Enum

Public Enum DiasSemana
    Domingo = 1
    Lunes = 2
    Martes = 3
    Miercoles = 4
    Jueves = 5
    Viernes = 6
    Sabado = 7
End Enum
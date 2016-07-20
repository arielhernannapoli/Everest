Imports Infragistics.Shared
Imports System.Drawing
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource


Public Class GrillAdmin
    Dim DtCompras As New DataTable
    Shared mComprasNumeros As DataTable
    Shared mColumnaRatingTarget1 As String
    Shared mColumnaRatingTarget2 As String
    Shared EstaModificando As Boolean
    Shared ColumnasAgrupadas As Byte = 1
    Const MedioRadio As Integer = 6

    Public Sub New()
    End Sub

    Public Sub New(ByVal ColumnaRatingTarget1 As String, ByVal ColumnaRatingTarget2 As String)
        Me.ColumnaRatingTarget1 = ColumnaRatingTarget1
        Me.ColumnaRatingTarget2 = ColumnaRatingTarget2
    End Sub
    Public Shared Property ComprasNumeros() As DataTable
        Get
            Return mComprasNumeros
        End Get
        Set(ByVal Value As DataTable)
            mComprasNumeros = Value
        End Set
    End Property
    Public Shared Property ColumnaRatingTarget1() As String
        Get
            Return mColumnaRatingTarget1
        End Get
        Set(ByVal Value As String)
            mColumnaRatingTarget1 = Value
        End Set
    End Property

    Public Shared Property ColumnaRatingTarget2() As String
        Get
            Return mColumnaRatingTarget2
        End Get
        Set(ByVal Value As String)
            mColumnaRatingTarget2 = Value
        End Set
    End Property

    Public Shared Property pColumnasAgrupadas() As Byte
        Get
            Return ColumnasAgrupadas
        End Get
        Set(ByVal Value As Byte)
            ColumnasAgrupadas = Value
        End Set
    End Property

    Public Function AgregarFila(ByVal Ds As UltraDataSource, ByVal Grilla As UltraGrid, ByVal IndiceFila As Integer, ByVal Spots As DataTable, ByVal AgregarHijos As Boolean, Optional ByVal EsBonificado As Boolean = False) As UltraDataRow
        Dim Origen As UltraGridRow = Grilla.Rows(IndiceFila)
        Dim Destino As UltraDataRow = Ds.Rows.Insert(IndiceFila + 1)
        Dim C As UltraGridColumn
        Dim Dr As DataRow
        Dim UltimoReg() As DataRow, i As Long
        UltimoReg = Spots.Select("ID_SPOT >=0", "id_spot desc")

        Dr = Spots.NewRow

        'Esteban. 15/03/06. EN LA COLUMNA "ID" SE GUARDA EL INDICE DE FILA
        'PARA MANTENER UN INDICE UNICO
        Destino.Item("id") = Destino.Index

        For Each C In Origen.Band.Columns
            Try
                Select Case C.Key.ToLower
                    Case "id_spot"
                        'pasa el dato al ultra source
                        Destino("id_spot") = UltimoReg(0)("id_spot") + i + 1 'Ds.Rows.Count + 1

                        Dr("id_spot") = UltimoReg(0)("id_spot") + i + 1 'Ds.Rows.Count + 1

                        'pasa los ids de campañas, sistema y ejercicio
                        Dr("id_campania") = Activo.IDCampaña
                        Dr("id_sistema") = Activo.IDSistema
                        Dr("id_ejercicio") = Activo.IDEjercicio
                    Case "h_inicio"
                        Dr("h_inicio") = Origen.Cells(C.Key).Text.Substring(0, 2)
                        Dr("m_inicio") = Origen.Cells(C.Key).Text.Substring(3, 2)

                        Destino(C.Key.ToLower) = Origen.Cells(C.Key).Text
                    Case "h_fin"
                        Dr("h_fin") = Origen.Cells(C.Key).Text.Substring(0, 2)
                        Dr("m_fin") = Origen.Cells(C.Key).Text.Substring(3, 2)

                        Destino(C.Key.ToLower) = Origen.Cells(C.Key).Text
                    Case "total spots", "total grp target 1", "total bruto", "total neto", "total grp target 2"

                        If AgregarHijos Then
                            Destino(C.Key.ToLower) = Origen.Cells(C.Key).Value
                        End If
                    Case Else

                        If AgregarHijos AndAlso EsColumnaCalendario(C) Then
                            'pasa el dato al ultra source
                            Destino(C.Key) = Origen.Cells(C.Key).Value
                        End If
                        If Not EsColumnaCalendario(C) Then
                            'pasa el dato al ultra source
                            Destino(C.Key) = Origen.Cells(C.Key).Value
                        End If

                        'hay columnas de la Grilla que el Data Table Spots no tiene (como los Totales)
                        Dr(C.Key) = Origen.Cells(C.Key).Value

                        If EsBonificado Then
                            If Me.EsColumnaDescuento(C) Then
                                If C.Key.ToLower = "dcto1" Then
                                    Destino(C.Key) = 100
                                    Dr(C.Key) = 100
                                Else
                                    Destino(C.Key) = 0
                                    Dr(C.Key) = 0
                                End If
                            Else
                                If C.Key.ToLower = "neto" Then
                                    Destino(C.Key) = 0
                                    Dr(C.Key) = 0
                                End If
                            End If

                            If C.Key.ToLower = "id_convenio" Then
                                Destino(C.Key) = 0
                                Dr(C.Key) = 0
                            End If

                        End If

                        Grilla.Rows(Grilla.Rows.Count - 1).Cells(C.Key).Appearance.ForeColor = Origen.Cells(C.Key).Appearance.ForeColor
                End Select

            Catch ex As ArgumentException
                ' i += 1
            Catch ex As Exception
                MsgBox(ex.StackTrace)
                Mensajes.Mensaje("GrillAdmin.AgregarFila: Columna: " & C.Key & " " & ex.Message)
            Finally
                i += 1
            End Try


        Next
        Dr("u_alta") = Activo.Login
        Dr("f_alta") = Date.Today

        Spots.Rows.Add(Dr)

        Return Destino
    End Function

    Private Sub ActualizarSpotBase(ByVal Spots As DataTable, ByVal CantidadFilas As Integer, ByVal FilaPadre As Integer)
        Dim dr As DataRow
        Dim dc As DataColumn

        dr = Spots.NewRow

        For Each dc In Spots.Columns

            If LCase(dc.ColumnName) = "id_spot" Then
                dr("ID_Spot") = CantidadFilas + 1
            Else
                dr(dc) = Spots.Rows(FilaPadre).Item(dc)
            End If

        Next

        Spots.Rows.Add(dr)
    End Sub

    Private Sub CopiarDatos(ByVal Origen As UltraDataRow, ByVal Destino As UltraDataRow, ByVal ParamArray Datos() As String)
        Dim S As String

        For Each S In Datos
            Destino(S) = Origen(S)
        Next
    End Sub

    Public Sub AgregarHijo(ByVal Ds As UltraDataSource, ByVal SpotDetalle As DataTable, ByVal IndiceFila As Integer, ByVal KeyColumna As String, ByVal Letras As String, ByVal Columnas As ArrayList, ByVal Temas As DataTable, ByVal IDSpot As Integer)
        Letras = Letras.ToUpper
        Dim FilaHija As UltraDataRow
        Dim FilaPadre As UltraDataRow = Ds.Rows(IndiceFila)
        Dim Existe, TemaEncontrado As Boolean
        Dim IndiceHijo As Integer

        FilaPadre.Item(KeyColumna) = Letras

        Dim NombreBanda As String = "Banda" & FilaPadre.Item("id") '***
        Dim Letra As String
        Dim i As Integer

        'si no existe, crea la banda de filas hijas
        CrearBanda(Ds, NombreBanda, Columnas)

        'recorre todas las letras que se pasaron
        For i = 0 To Letras.Length - 1
            Letra = Letras.Substring(i, 1).ToUpper 'despeja una letra por vez

            Dim IndiceFilaHija As Integer

            'trae el indice de la fila del tema que se esta buscnado
            IndiceFilaHija = BuscarTagEnFila(Letra, FilaPadre.GetChildRows(NombreBanda))

            'si hay una fila con ese tema, modifica los totales, sino, agrega la fila
            If IndiceFilaHija > -1 Then
                Dim Filas As UltraDataRowsCollection = Ds.Rows(IndiceFila).GetChildRows(NombreBanda)

                'actualiza la cantidad de temas que se compraron
                Filas(IndiceFilaHija).Item(KeyColumna) = ContarLetras(Letra, Letras)
            Else
                'Inserta fila hija (ordenado segun tema) en caso de Radio sino lo agrega
                If Activo.IDMedio = MedioRadio Then
                    IndiceHijo = FilaPadre.GetChildRows(NombreBanda).Count
                    For Each FPIndice As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                        TemaEncontrado = False
                        For Each TemaIndice As DataRow In Temas.Rows
                            If FPIndice.Tag = TemaIndice("Id_Tema") Then
                                Exit For
                            End If
                            If Letra = TemaIndice("Id_Tema") Then
                                IndiceHijo = FPIndice.Index
                                TemaEncontrado = True
                                Exit For
                            End If
                        Next
                        If TemaEncontrado Then
                            Exit For
                        End If
                    Next

                    FilaHija = Ds.Rows(IndiceFila).GetChildRows(NombreBanda).Insert(IndiceHijo)
                Else
                    FilaHija = Ds.Rows(IndiceFila).GetChildRows(NombreBanda).Add
                End If

                'agrega la letra en el tag para saber cuando se agrega una fila con ese tema
                FilaHija.Tag = Letra

                FilaHija.Item(KeyColumna) = 1

                'carga el Nombre del Material y la duracion
                Dim Material As String = ObtenerDato(Temas, "id_tema = '" & Letra & "'", "material")

                If Material Is Nothing Then
                    Material = "Sin Material"
                End If
                If Material.ToLower = "no disponible" Then
                    Material = "Sin Material"
                End If

                FilaHija.Item("Tema") = "Tema " & Letra & ": " & Material 'IIf(Material.ToLower = "no disponible", "Sin Material", Material)
                FilaHija.Item("Dur") = ObtenerDato(Temas, "id_tema = '" & Letra & "'", "duracion")
            End If
        Next

        'actualiza la cantidad de temas comprados y borra las filas de temas que no tienen compras
        ActualizarFilasTemas(FilaPadre, SpotDetalle, Temas, NombreBanda, IDSpot)
    End Sub

    Public Sub AgregarHijo(ByVal Ds As UltraDataSource, ByVal SpotDetalle As DataTable, ByVal Columnas As ArrayList, ByVal Temas As DataTable)
        Dim FilaHija As UltraDataRow
        Dim FilaPadre As UltraDataRow
        Dim NombreBanda As String
        Dim Letra As String
        Dim IDSpot As Integer
        Dim ExisteTema As Boolean
        Dim Existe, TemaEncontrado As Boolean
        Dim IndiceHijo As Integer

        For Each FilaPadre In Ds.Rows
            IDSpot = FilaPadre.Item("id_spot")
            NombreBanda = "Banda" & FilaPadre.Item("id")  '***
            'si no existe, crea la banda de filas hijas
            CrearBanda(Ds, NombreBanda, Columnas)
            For Each Tema As DataRow In Temas.Rows
                ExisteTema = False
                Letra = Tema("Id_Tema")
                For Each F As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                    If F.Tag = Letra Then
                        ExisteTema = True
                        Exit For
                    End If
                Next
                If Not ExisteTema Then
                    IndiceHijo = FilaPadre.GetChildRows(NombreBanda).Count
                    For Each FPIndice As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                        TemaEncontrado = False
                        For Each TemaIndice As DataRow In Temas.Rows
                            If FPIndice.Tag = TemaIndice("Id_Tema") Then
                                Exit For
                            End If
                            If Letra = TemaIndice("Id_Tema") Then
                                IndiceHijo = FPIndice.Index
                                TemaEncontrado = True
                                Exit For
                            End If
                        Next
                        If TemaEncontrado Then
                            Exit For
                        End If
                    Next

                    FilaHija = FilaPadre.GetChildRows(NombreBanda).Insert(IndiceHijo)
                    'FilaHija = FilaPadre.GetChildRows(NombreBanda).Add()
                    'agrega la letra en el tag para saber cuando se agrega una fila con ese tema

                    FilaHija.Tag = Letra

                    'carga el Nombre del Material y la duracion
                    Dim Material As String = Tema("material")

                    If Material Is Nothing Then
                        Material = "Sin Material"
                    End If
                    If Material.ToLower = "no disponible" Then
                        Material = "Sin Material"
                    End If

                    FilaHija.Item("Tema") = "Tema " & Letra & ": " & Material
                    FilaHija.Item("Dur") = Tema("duracion")
                End If
            Next
            'ActualizarFilasTemas(FilaPadre, SpotDetalle, Temas, NombreBanda, IDSpot)
        Next
    End Sub

    Public Sub AgregarHijo(ByVal Ds As UltraDataSource, ByVal FilaPadre As UltraDataRow, ByVal Columnas As ArrayList, ByVal Temas As DataTable)
        Dim FilaHija As UltraDataRow
        Dim NombreBanda As String
        Dim Letra As String
        Dim Existe, TemaEncontrado As Boolean
        Dim IndiceHijo As Integer

        NombreBanda = "Banda" & FilaPadre.Item("id")

        'si no existe, crea la banda de filas hijas
        CrearBanda(Ds, NombreBanda, Columnas)
        For Each Tema As DataRow In Temas.Rows
            IndiceHijo = FilaPadre.GetChildRows(NombreBanda).Count
            Letra = Tema("Id_Tema")
            Existe = False
            For Each FP As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                If Letra = FP.Tag Then
                    Existe = True
                    Exit For
                End If
            Next
            If Not Existe Then
                For Each FPIndice As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                    TemaEncontrado = False
                    For Each TemaIndice As DataRow In Temas.Rows
                        If FPIndice.Tag = TemaIndice("Id_Tema") Then
                            Exit For
                        End If
                        If Letra = TemaIndice("Id_Tema") Then
                            IndiceHijo = FPIndice.Index
                            TemaEncontrado = True
                            Exit For
                        End If
                    Next
                    If TemaEncontrado Then
                        Exit For
                    End If
                Next

                FilaHija = FilaPadre.GetChildRows(NombreBanda).Insert(IndiceHijo)
                'agrega la letra en el tag para saber cuando se agrega una fila con ese tema

                FilaHija.Tag = Letra

                'carga el Nombre del Material y la duracion
                Dim Material As String = Tema("material")

                If Material Is Nothing Then
                    Material = "Sin Material"
                End If
                If Material.ToLower = "no disponible" Then
                    Material = "Sin Material"
                End If

                FilaHija.Item("Tema") = "Tema " & Letra & ": " & Material
                FilaHija.Item("Dur") = Tema("duracion")
            End If
        Next
    End Sub

    Private Sub CrearBanda(ByRef Ds As UltraDataSource, ByVal NombreBanda As String, ByVal Columnas As ArrayList)
        Dim Banda As UltraDataBand
        Dim T As CampoTipo, i As Int32
        'si no existe la banda, crea una banda con las columnas
        If Not Ds.Band.ChildBands.Exists(NombreBanda) Then
            Banda = Ds.Band.ChildBands.Add(NombreBanda)


            'agrega las columnas de los hijos
            For Each T In Columnas
                Banda.Columns.Add(T.Campo, T.Tipo)
            Next

            'For i = 0 To Columnas.Count
            ' Banda.Columns.Add(Columnas(i).campo, Columnas(i).campo)
            'Next



        End If
    End Sub
    Private Sub CrearBanda(ByVal NombreBanda As String, ByRef Ds As UltraDataSource, ByVal Columnas As ArrayList)
        Dim Banda As UltraDataBand
        Dim T As CampoTipo, i As Int32
        'si no existe la banda, crea una banda con las columnas
        If Not Ds.Band.ChildBands.Exists(NombreBanda) Then
            Banda = Ds.Band.ChildBands.Add(NombreBanda)

            For i = 0 To Columnas.Count - 1
                Banda.Columns.Insert(i, Columnas(i).campo, Columnas(i).tipo)
            Next
        End If
    End Sub

    Public Sub ActualizarFilasTemas(ByVal FilaPadre As UltraDataRow, ByVal SpotDetalle As DataTable, ByVal Temas As DataTable, ByVal NombreBanda As String, ByVal IDSpot As Integer)
        '*** borra las filas de los temas que no se compraron
        Dim Ur As UltraDataRow
        Dim Uc As UltraDataColumn
        Dim F As New FilaTema
        Dim FilasBorrar As New ArrayList

        'guarda los OBJETOS FILA de las filas que hay que borrar
        'porque no se puede borrar sobre la misma coleccion que se esta recorriendo
        For Each Ur In FilaPadre.GetChildRows(NombreBanda)

            F = New FilaTema

            'recorre columnas
            For Each Uc In FilaPadre.Band.Columns

                'si la columna es del calendario
                If EsColumnaCalendario(Uc) Then
                    'pasa la fila para llenar una coleccion
                    F.Fila = Ur

                    'suma la cantidad de temas que hay en la fila
                    F.CantidadTemas += ContarLetras(CStr(Ur.Tag).ToUpper, FilaPadre.Item(Uc.Key).ToString.ToUpper)

                    'agrega y saca registros del data table SPOT DETALLE
                    Dim TextoCelda As String = IIf(IsDBNull(FilaPadre(Uc.Key)), "", FilaPadre(Uc.Key).ToString.ToUpper)

                    ActualizarSpotDetalle(SpotDetalle, Temas, F, Uc.Key, TextoCelda, IDSpot)

                    'si no tiene temas comprados, vacia la celda
                    If ContarLetras(CStr(Ur.Tag).ToUpper, FilaPadre.Item(Uc.Key).ToString.ToUpper) = 0 Then
                        Ur.Item(Uc.Key) = ""
                    End If
                End If

            Next

            FilasBorrar.Add(F)
        Next

        'recorre las filas, si no tiene temas, borra la fila y si tiene, actualiza los totales
        For Each F In FilasBorrar
            'si la fila no tiene temas, la borra
            If F.CantidadTemas = 0 Then
                If Activo.IDMedio <> MedioRadio Then
                    FilaPadre.GetChildRows(NombreBanda).Remove(F.Fila)
                Else
                    CalcularTotales(FilaPadre, F.Fila, F.CantidadTemas)
                End If
            Else
                CalcularTotales(FilaPadre, F.Fila, F.CantidadTemas)
            End If
        Next

        CalcularTotalesPrograma(FilaPadre)
    End Sub

    Private Sub ActualizarSpotDetalle(ByVal SpotDetalle As DataTable, ByVal Temas As DataTable, ByVal Fila As FilaTema, ByVal Fecha As Date, ByVal Letras As String, ByVal IDSpot As Integer)
        'agrega registros al data table sport detalle
        Letras = Letras.ToUpper
        Dim i As Integer
        Dim Estados As New ArrayList
        ' Dim AuxEstado As DataTable = SpotDetalle.Copy

        Dim Estado As ItemLista
        Dim Dr As DataRow
        Dim IndiceFilaPadre As Integer = Fila.Fila.ParentRow.Index
        Dim Letra As String ', LetrasAnteriores As String
        Dim Cantidadspots As Integer
        'Dim IdDetalle As New ArrayList
        Dim SpotEstado As String
        Dim Orden As Long
        Dim UltimoReg As Long
        Dim Original As String = ""
        Dim ArrResultado As ArrayList
        Dim FilaDetalle As DataRow()

        'borra todas las filas del detalle para el TEMA PASADO DE PARAMETRO
        Dim Filas() As DataRow

        If IDSpot <> 0 Then
            IndiceFilaPadre = IDSpot
        End If

        'CType(C.ColumnName, Date).ToString("dd/MM/yyyy") & " 12:00:00 a.m.'"
        Filas = SpotDetalle.Select("id_spot=" & IndiceFilaPadre & " and f_spot='" & Fecha & "'", "id_spot_detalle desc")
        FilaDetalle = SpotDetalle.Select("id_spot>=0", "id_spot_detalle desc")
        'Cantidadspots = Filas.Length
        If Filas Is Nothing Then
            Exit Sub
        End If

        If FilaDetalle.Length = 0 Then
            UltimoReg = 1
        Else
            UltimoReg = FilaDetalle(0)("id_spot_detalle") + 1 'Filas(0)("Id_Spot_detalle") + 1
        End If
        'UltimoReg = Filas(0)("Id_Spot_detalle")
        For Each Dr In Filas
            Original &= Dr("ID_Tema")
        Next
        If Algoritmos.SonIguales(Original, Letras) Then
            Exit Sub
        End If
        ArrResultado = Algoritmos.ArmarArray(Original, Letras)
        'comienza el autonumerico desde 1
        Try

            SpotDetalle.Columns("id_spot_detalle").AutoIncrement = True
            SpotDetalle.Columns("id_spot_detalle").AutoIncrementSeed = UltimoReg
        Catch ex As Exception
            Mensajes.Mensaje("GrillAdmin.ActualizarSpotDetalle: " & ex.Message)
        End Try
        'Dim Indice As Integer
        'carga las filas para el tema pasado
        Try
            For Each E As CantidadSpots In ArrResultado
                If E.Cantidad <> 0 Then
                    '        UltimoReg += 1
                    If E.Cantidad > 0 Then
                        For i = 1 To E.Cantidad
                            Dr = SpotDetalle.NewRow
                            Dr("id_spot") = IndiceFilaPadre
                            'Dr("id_spot_detalle") = UltimoReg + i
                            Dr("f_spot") = Fecha
                            Dr("id_tema") = E.Letra
                            Dr("duracion") = ObtenerDato(Temas, "id_tema ='" & E.Letra & "'", "duracion")
                            Dr("id_spot_estado") = "P"
                            Dr("id_Orden_Sigeme") = 0
                            Dr("f_alta") = Now.Date
                            Dr("u_alta") = Activo.Login


                            SpotDetalle.Rows.Add(Dr)
                        Next
                    Else
                        'For Each r As DataRow In SpotDetalle.Select("id_spot=" & IndiceFilaPadre & " and id_Spot='" & E.Letra & "'")
                        For i = 1 To (E.Cantidad * -1)
                            Dim filtro As String = "id_spot=" & IndiceFilaPadre & " and id_Tema='" & E.Letra & "' and f_spot='" & Fecha & "'"
                            Dim r As DataRow() = SpotDetalle.Select(filtro)
                            r(r.Length - 1)("f_modi") = Now.Date
                            r(r.Length - 1)("u_modi") = Activo.Login
                            ' SpotDetalle.AcceptChanges()
                            r(r.Length - 1).Delete()
                        Next
                        'Next
                    End If
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CalcularTotales(ByVal FilaPadre As UltraDataRow, ByVal Fila As UltraDataRow, ByVal CantidadTemas As Integer, Optional ByVal Cargando As Boolean = False)
        Dim Duracion As Integer

        Duracion = Val(Fila.Item("Dur"))

        'TOTAL SPOTS
        If Not Cargando Then
            Fila.Item("Total Spots") = CantidadTemas

            'TOTAL GRPS
            Fila.Item("Total GRP Target 1") = CantidadTemas * FilaPadre.Item(ColumnaRatingTarget1)
            Fila.Item("Total GRP Target 2") = CantidadTemas * FilaPadre.Item(ColumnaRatingTarget2)

            'TOTAL BRUTO
            Fila.Item("Total Bruto") = CantidadTemas * Duracion * FilaPadre.Item("bruto")

            'TOTAL NETO
            Fila.Item("Total Neto") = CantidadTemas * Duracion * Valores.CastDBNull(FilaPadre.Item("Neto"))
        Else
            Fila.Item("Total Spots") = Valores.CastDBNull(Fila.Item("Total Spots")) + CantidadTemas

            'TOTAL GRPS
            Fila.Item("Total GRP Target 1") = Fila.Item("Total Spots") * FilaPadre.Item(ColumnaRatingTarget1)
            Fila.Item("Total GRP Target 2") = Fila.Item("Total Spots") * FilaPadre.Item(ColumnaRatingTarget2)

            'TOTAL BRUTO
            Fila.Item("Total Bruto") = Fila.Item("Total Spots") * Duracion * FilaPadre.Item("bruto")

            'TOTAL NETO
            Fila.Item("Total Neto") = Fila.Item("Total Spots") * Duracion * Valores.CastDBNull(FilaPadre.Item("Neto"))
        End If
    End Sub

    Private Sub CalcularTotalesPrograma(ByVal FilaPadre As UltraDataRow)
        Dim F As UltraDataRow
        Dim Spots As Integer
        Dim GRPTarget1 As Single
        Dim GRPTarget2 As Single
        Dim Bruto As Single
        Dim Neto As Single

        FilaPadre("Total Spots") = 0
        FilaPadre("Total GRP Target 1") = 0
        FilaPadre("Total GRP Target 2") = 0
        FilaPadre("Total Bruto") = 0
        FilaPadre("Total Neto") = 0

        Dim Filas As UltraDataRowsCollection = FilaPadre.GetChildRows("Banda" & FilaPadre.Item("id"))

        For Each F In Filas
            Spots += IIf(IsDBNull(F("Total Spots")), 0, F("Total Spots"))
            GRPTarget1 += IIf(IsDBNull(F("Total GRP Target 1")), 0, F("Total GRP Target 1"))
            GRPTarget2 += IIf(IsDBNull(F("Total GRP Target 2")), 0, F("Total GRP Target 2"))
            Bruto += IIf(IsDBNull(F("Total Bruto")), 0, F("Total Bruto"))
            Neto += IIf(IsDBNull(F("Total Neto")), 0, F("Total Neto"))
        Next

        FilaPadre("Total Spots") = Spots
        FilaPadre("Total GRP Target 1") = GRPTarget1
        FilaPadre("Total GRP Target 2") = GRPTarget2
        FilaPadre("Total Bruto") = Bruto
        FilaPadre("Total Neto") = Neto
    End Sub

    Public Sub ModificarColumna(ByVal Spot As DataTable, ByVal Celda As UltraGridCell, ByVal idconvenio As Integer)
        Dim Dr As DataRow
        Dim Columna As ColumnasManuales
        Dim ColumnasModificadas As ArrayList
        Dim EstaColumnaModificada As Boolean
        Columna = ObtenerColumnaModificable(Celda.Column.Key)

        Try
            Dr = Spot.Select("id_spot=" & Celda.Row.Cells("id_spot").Value)(0)
        Catch ex As Exception
            Mensajes.Mensaje(ex.Message, TipoMensaje.DeError)
        End Try

        If IsDBNull(Dr("tipo_planificacion")) Then
            Dr("tipo_planificacion") = 0
        End If

        'Controla si ya se modifico la columna, si es asi, no sigue sumando
        ColumnasModificadas = Algoritmos.ObtenerConstantesSuma(Dr("tipo_planificacion"))

        For Each C As Integer In ColumnasModificadas
            If C = Columna Then
                EstaColumnaModificada = True
                Exit For
            End If
        Next

        If Not EstaColumnaModificada Then
            Dr("tipo_planificacion") += Columna
        End If
        '***

        'solo se anula el convenio cuando se modifican las columnas de
        'bruto, descuentos o neto
        'If Columna = ColumnasManuales.Bruto Or _
        '    Columna = ColumnasManuales.Descuento1 Or _
        '    Columna = ColumnasManuales.Descuento2 Or _
        '    Columna = ColumnasManuales.Descuento3 Or _
        '    Columna = ColumnasManuales.Descuento4 Or _
        '    Columna = ColumnasManuales.Descuento5 Then


        '    Dr("id_convenio") = -1
        '    Celda.Row.Cells("id_convenio").Value = -1
        'End If

        'AG ++++++++++++++++++++++++++++++++++++++
        If Columna = ColumnasManuales.Bruto Then
            'AG 01/07/2011 +++++++++++++++++++++++++++++
            If idconvenio > 0 Then
                Dr("id_convenio") = idconvenio
                Celda.Row.Cells("id_convenio").Value = idconvenio
            End If
            '++++++++++++++++++++++++++++++++++++++++
        End If
        If Columna = ColumnasManuales.Descuento1 Or _
            Columna = ColumnasManuales.Descuento2 Or _
            Columna = ColumnasManuales.Descuento3 Or _
            Columna = ColumnasManuales.Descuento4 Or _
            Columna = ColumnasManuales.Descuento5 Then
            Dr("id_convenio") = idconvenio
            Celda.Row.Cells("id_convenio").Value = idconvenio
        End If


        ' Spot.AcceptChanges()
    End Sub

    Public Function ObtenerDato(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Columna As String) As Object
        Try
            If Not Dt Is Nothing Then
                Dt.CaseSensitive = True

                Return Dt.Select(Filtro)(0).Item(Columna)
            End If
        Catch e As IndexOutOfRangeException
            Exit Function
        Catch ex As Exception
            Throw New Exception("La Columna '" & Columna & "' No Existe en el Data Table" & vbCrLf & ex.Message)
        End Try
    End Function

    Public Function ContarLetras(ByVal Letra As Char, ByVal Letras As String) As Integer
        ContarLetras = 0
        'Letra = Letra.ToUpper(Letras)
        Letras = Letras.ToUpper
        Do While Letras.IndexOf(Letra) > -1
            ContarLetras += 1
            Letras = Letras.Remove(Letras.IndexOf(Letra), 1)
        Loop
    End Function

    Private Function BuscarTagEnFila(ByVal Valor As String, ByVal Filas As UltraDataRowsCollection) As Integer
        Dim Fila As UltraDataRow

        For Each Fila In Filas
            If Fila.Tag = Valor Then
                Return Fila.Index
            End If
        Next

        Return -1
    End Function

    Public Function ObtenerUltraDataSource(ByVal Spot As DataTable, ByVal SpotDetalle As DataTable, ByVal Temas As DataTable, Optional ByVal DtSpotDetalle As DataTable = Nothing) As UltraDataSource
        '***
        'ARMA UN OBJETO ULTRA DATA SOURCE (QUE ES EL QUE SE CONECTA CON LA GRILLA) A PARTIR DE 
        'LOS DATA TABLES:   1.- SPOTS: TRAIDO DE LA BASE, CON ALGUNOS CAMBIOS A MANO EN EL frmEjercicio
        '                   2.- SPOTS DETALLE: TAMBIEN VIENE DE UNA CONSULTA EN LA BASE Y SE LE AGREGAN COLUMNAS
        '                   3.- TEMAS: USADO TAL CUAL COMO VIENE DE LA BASE, PARA SABER QUE TEMAS SE PUEDIERON HABER COMPRADO
        '***
        CrearDtCompras()
        Dim UltraSource As UltraDataSource
        Dim FilasCompradas As Integer
        Dim FiltroCompra As String
        Dim Ur As UltraDataRow
        Dim F As DataRow
        Dim FilasDetalle() As DataRow
        Dim Tema As DataRow
        Dim Original As String
        Dim Nuevo As String
        Dim id As Integer
        Dim Resultado As String
        UltraSource = ObtenerUltraDataSource(Spot, "BandaSpot")
        Dim nuevaBanda As UltraDataBand

        Dim C As DataColumn
        Dim Columnas As New ArrayList
        Dim T As CampoTipo

        Dim Existe, TemaEncontrado As Boolean
        Dim IndiceHijo As Integer

        'carga las columnas para las filas hijas
        For Each C In SpotDetalle.Columns

            Select Case C.ColumnName.ToLower
                'estas columnas no se cargan en el hijo (pero se usan para cargar datos
                Case "id_spot", "id_Spot_detalle", "id_tema", "duracion", "f_spot"
                Case Else
                    T = New CampoTipo

                    T.Campo = C.ColumnName
                    T.Tipo = C.DataType

                    Columnas.Add(T)
            End Select
        Next
        ' nuevaBanda = Me.CrearBandaModelo(Columnas, UltraSource)
        '  Me.AgregarBanda(nuevaBanda, UltraSource, SpotDetalle)
        'Recorre las filas padre y busca si tiene filas hijas, si tiene, las carga.
        'Agrega UNA FILA POR TEMA (suma la cantidad de temas encontrados para cada columna del calendario y en el,
        'padre concatena las letras del tema comprado)
        For Each Ur In UltraSource.Rows

            'busca si el programa tiene temas comprados
            FilasDetalle = SpotDetalle.Select("id_spot=" & Ur.Item("id_spot"))

            '15/03/06: GUARDA EL INDICE DE LA FILA EN UNA COLUMNA, PARA MANTENER UN VALOR ÚNICO POR PROGRAMA
            'PORQUE CUANDO SE BORRAN FILAS, EL INDICE CAMBIA, PERO EL VALOR DE ESTA COLUMNA "ID" NO !.
            'AHÍ ES CUANDO SE MANTIENE UN INDICE ÚNICO
            Ur.Item("id") = Ur.Index

            'si tiene spots detalle...
            If FilasDetalle.Length > 0 Then

                'crea una banda hija (que se llena con filas)
                CrearBanda(UltraSource, "Banda" & Ur.Item("id"), Columnas)
                ' CrearBanda(String.Concat("Banda", Ur.Item("id")), UltraSource, Columnas)
                'nuevaBanda.Key = String.Concat("Banda", Ur.Item("id"))

                'recorre las columnas del spot detalle, para cargarle las compras
                For Each C In SpotDetalle.Columns
                    Original = ""
                    Resultado = ""
                    'si la columna es una columna del calendario...
                    If EsColumnaCalendario(C) Then

                        'recorre los temas de la campaña...
                        For Each Tema In Temas.Rows

                            'busca las filas del tema actual, para el id_spot del padre, para la columna actual
                            Dim Filtro As String

                            Filtro = "id_spot=" & Ur.Item("id_spot")
                            Filtro &= " and id_tema='" & Tema("id_tema")
                            Filtro &= "' and f_spot='" & CType(C.ColumnName, Date).ToString("dd/MM/yyyy") & " 12:00:00 a.m.'"

                            'SpotDetalle.CaseSensitive = True
                            FilasDetalle = SpotDetalle.Select(Filtro)
                            If IsNumeric(Tema("ID_tema")) Then
                                FilasCompradas = DtSpotDetalle.Select(Filtro & " and ID_SPOT_ESTADO in ('C','S')").Length
                            Else
                                FilasCompradas = 0
                            End If
                            '***

                            'si hay temas comprados, el tema actual, el id_spot del padre y la columna actual...
                            If FilasDetalle.Length > 0 Then
                                Dim UltraRow As UltraDataRow

                                'si ya existe una fila para ese tema, devuelve el indice de la fila
                                Dim IndiceFila As Integer = BuscarTagEnFila(Tema("id_tema"), Ur.GetChildRows("Banda" & Ur.Item("id")))

                                'si no se hay una fila para el tema buscado
                                If IndiceFila = -1 Then
                                    'Inserta fila hija (ordenado segun tema) en caso de Radio sino lo agrega
                                    If Activo.IDMedio = MedioRadio Then
                                        IndiceHijo = Ur.GetChildRows("Banda" & Ur.Item("id")).Count
                                        For Each FPIndice As UltraDataRow In Ur.GetChildRows("Banda" & Ur.Item("id"))
                                            TemaEncontrado = False
                                            For Each TemaIndice As DataRow In Temas.Rows
                                                If FPIndice.Tag = TemaIndice("Id_Tema") Then
                                                    Exit For
                                                End If
                                                If Tema("id_tema") = TemaIndice("Id_Tema") Then
                                                    IndiceHijo = FPIndice.Index
                                                    TemaEncontrado = True
                                                    Exit For
                                                End If
                                            Next
                                            If TemaEncontrado Then
                                                Exit For
                                            End If
                                        Next

                                        UltraRow = Ur.GetChildRows("Banda" & Ur.Item("id")).Insert(IndiceHijo)
                                    Else
                                        UltraRow = Ur.GetChildRows("Banda" & Ur.Item("id")).Add()
                                    End If
                                Else
                                    'ya existe una fila para ese tema
                                    UltraRow = Ur.GetChildRows("Banda" & Ur.Item("id")).Item(IndiceFila)
                                End If

                                'agrega en el TAG el ID_Tema
                                UltraRow.Tag = Tema("id_tema")
                                'agregar el Tema y el nombre del material
                                UltraRow.Item("Tema") = "Tema " & Tema("id_tema") & ": " & IIf(Tema("material").ToLower = "no disponible", "Sin Material", Tema("material"))
                                'agrega la duracion del tema
                                UltraRow.Item("dur") = Tema("duracion")
                                'agrega la cantidad de veces que se compro el tema
                                UltraRow.Item(C.ColumnName) = FilasDetalle.Length

                                'CONCATENA EN LA FILA PADRE tantas letras como compras se hayan hecho del tema
                                Original = Tema("id_tema").ToString.PadRight(FilasDetalle.Length, Tema("id_tema"))

                                If Not DtSpotDetalle Is Nothing Then
                                    Nuevo = ControlarCompras(Ur.Item("id_spot"), FilasDetalle, Original.ToUpper, DtSpotDetalle, UltraRow.Index, C.ColumnName)
                                    If Nuevo <> "" And Not Nuevo Is Nothing Then
                                        ' Ur(C.ColumnName) = Original
                                        'Els'e
                                        Resultado &= Nuevo
                                    Else
                                        Resultado &= Original
                                    End If
                                Else
                                    Resultado &= Original
                                End If
                                Ur(C.ColumnName) = Resultado

                                'calcula los totales
                                CalcularTotales(Ur, UltraRow, FilasDetalle.Length, True)
                                CalcularTotalesPrograma(Ur)
                            End If
                            Dim dr As DataRow
                            If Char.IsNumber(CChar(Tema("id_tema"))) AndAlso FilasCompradas > 0 Then
                                Dim filtercompras As String = "fila=" & Ur.Index & " and columna=" & "'" & C.ColumnName & "'"
                                If Me.DtCompras.Select(filtercompras).Length > 0 Then
                                    For Each DrCompras As DataRow In Me.DtCompras.Select(FiltroCompra)
                                        DrCompras("tema" & LCase(Tema("id_tema"))) = FilasCompradas
                                    Next
                                Else
                                    dr = (DtCompras.NewRow)
                                    dr("fila") = Ur.Index
                                    dr("columna") = C.ColumnName
                                    dr("tema" & LCase(Tema("id_tema"))) = FilasCompradas
                                    Me.DtCompras.Rows.Add(dr)
                                End If
                            End If

                        Next

                    End If
                Next
            End If
        Next
        mComprasNumeros = DtCompras
        Return UltraSource
    End Function
    Private Function ControlarCompras(ByVal IDSpot As Integer, ByVal FilasTemas() As DataRow, ByVal Cadena As String, ByVal Spotsdetalle As DataTable, ByVal Fila As Integer, ByVal Columna As String) As String
        Dim FilaResultado() As DataRow
        Dim CantidadComprados As Integer
        Dim Numeros As Integer
        Dim Filtro As String
        Dim Tema As Char
        Dim Resultado As String = ""

        For Each r As DataRow In FilasTemas
            Filtro = "Id_Spot=" & IDSpot & " and id_Spot_Detalle=" & r("ID_SPOT_DETALLE") & " and id_tema=" & "'" & r("ID_TEMA") & "'"
            FilaResultado = Spotsdetalle.Select(Filtro)
            If FilaResultado(0)("ID_SPOT_ESTADO") = "C" Or FilaResultado(0)("ID_SPOT_ESTADO") = "S" Then
                Tema = r("ID_TEMA")
                CantidadComprados += 1
            End If
        Next

        If CantidadComprados = 0 Then
            Return ""
        End If

        Resultado = Cadena.Substring(0, CantidadComprados).ToLower & Cadena.Substring(CantidadComprados, Cadena.Length - CantidadComprados)


        Return Resultado
    End Function
    Public Function ObtenerUltraDataSource(ByVal Dt As DataTable, ByVal NombreBanda As String, Optional ByVal CargarF_ALTA As Boolean = False) As UltraDataSource
        '***
        'DEVUELVE UN ULTRA DATA SOURCE A PARTIR DE UN DATA TABLE:
        'SE USA PARA CONECTAR A LA GRILLA UN ULTRA DATA SOURCE CUANDO SE TIENE
        'UN DATA TABLE QUE VIENE DE UNA CONSULTA (EL ULTRA DATA SOURCE PERMITE AGREGAR FILAS
        'MAS FACILMENTE
        'TAMBIEN CARGAR LA FECHA DE ALTA DEL SPOT (SI SE PASA EL PARAMETRO cargarF_ALTA
        '***
        Dim UltraSource As New UltraDataSource
        Dim UltraRow As UltraDataRow
        Dim C As DataColumn
        Dim Dr As DataRow

        Dim Columnas As New ArrayList
        Dim S As String

        With UltraSource
            .Band.Key = NombreBanda

            'carga las columnas
            For Each C In Dt.Columns
                .Band.Columns.Add(C.ColumnName, C.DataType)
                Columnas.Add(C.ColumnName)
            Next

            'carga las filas de datos
            ' .Rows.SetCount(Dt.Rows.Count)
            For Each Dr In Dt.Rows
                UltraRow = .Rows.Add()

                'pasa los datos de cada columna del Data Table al UltraDataRow
                For Each S In Columnas
                    UltraRow(S) = Dr(S)
                Next


            Next
        End With

        Return UltraSource
    End Function
    Public Function ObtenerSpotsComprados(ByVal Celda As UltraGridCell) As String
        Dim auxLetras As String = ""
        Dim auxNumeros As String = ""
        If Not Me.EsColumnaCalendario(Celda.Column) Then
            Return ""
        End If
        Dim filtro As String = "fila=" & Celda.Row.Index & " and columna=" & "'" & Celda.Column.Key & "'"
        Try
            Dim CantidadCompra As Integer
            For Each c As Char In Celda.Text

                If c.IsLower(c) Then
                    auxLetras &= c
                ElseIf c.IsNumber(c) Then
                    CantidadCompra = Valores.CastDBNull(Me.ObtenerDato(Me.mComprasNumeros, filtro, "tema" & c))
                    If CantidadCompra > 0 Then
                        If CantidadCompra > auxNumeros.Length Then
                            auxNumeros &= c
                        End If
                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return auxLetras & auxNumeros
    End Function
    Public Function ObtenerSpotsComprados(ByVal Celda As UltraGridCell, ByVal Tema As Char) As String
        Dim auxLetras As String = ""
        Dim auxNumeros As String = ""
        If Not Me.EsColumnaCalendario(Celda.Column) Then
            Return ""
        End If
        Dim filtro As String = "fila=" & Celda.Row.Index & " and columna=" & "'" & Celda.Column.Key & "'"
        Try
            Dim CantidadCompra As Integer
            For Each c As Char In Celda.Text

                If c.IsLower(c) Then
                    If c = Tema Then
                        auxLetras &= c
                    End If
                ElseIf c.IsNumber(c) Then
                    CantidadCompra = Valores.CastDBNull(Me.ObtenerDato(Me.mComprasNumeros, filtro, "tema" & c))
                    If CantidadCompra > 0 AndAlso c = Tema Then
                        If CantidadCompra > auxNumeros.Length Then
                            auxNumeros &= c
                        End If
                    End If

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return auxLetras & auxNumeros
    End Function
    Private Sub CrearDtCompras()

        With DtCompras.Columns
            .Add("fila", GetType(Integer))
            .Add("columna", GetType(String))
            .Add("tema0", GetType(Integer))
            .Add("tema1", GetType(Integer))
            .Add("tema2", GetType(Integer))
            .Add("tema3", GetType(Integer))
            .Add("tema4", GetType(Integer))
            .Add("tema5", GetType(Integer))
            .Add("tema6", GetType(Integer))
            .Add("tema7", GetType(Integer))
            .Add("tema8", GetType(Integer))
            .Add("tema9", GetType(Integer))
        End With

    End Sub

    Public Sub CargarDtCompras(ByVal Texto As String, ByVal DtCompras As DataTable, ByVal Fila As Integer, ByVal Columna As String)
        Dim r As DataRow
        For Each c As Char In Texto
            If c.IsNumber(c) Then
                r = DtCompras.NewRow
                r("fila") = Fila
                r("columna") = Columna
                r("Texto") = Texto
            End If
            DtCompras.Rows.Add(r)
        Next
        Me.mComprasNumeros = DtCompras

    End Sub
    Public Function TieneCompras(ByVal Grilla As UltraGrid, ByVal Fila As UltraGridRow, ByVal columna As UltraGridColumn) As Boolean
        Dim Aux As String = ""
        For Each c As Char In Fila.Cells(columna).Text
            If c.IsLower(c) Then
                Aux &= c
            End If
        Next
        Return Aux
    End Function
    Public Sub ActualizarDataTableColumnasManuales(ByVal Spots As DataTable, ByVal Fila As UltraDataRow)
        Try
            Dim Dr As DataRow = Spots.Select("id_spot=" & Fila("id_spot"))(0)

            'Activo.Control = True

            Dr("rat_prog_target_1") = Fila("rat_prog_target_1")
            Dr("rat_prog_target_2") = Fila("rat_prog_target_2")

            Dr("rat_tanda_target_1") = Fila("rat_tanda_target_1")
            Dr("rat_tanda_target_2") = Fila("rat_tanda_target_2")

            Dr("Neto") = Fila("Neto")
            Dr("Bruto") = Fila("Bruto")

            Dr("DCTO1") = Fila("DCTO1")
            Dr("DCTO2") = Fila("DCTO2")
            Dr("DCTO3") = Fila("DCTO3")
            Dr("DCTO4") = Fila("DCTO4")
            Dr("DCTO5") = Fila("DCTO5")

            Dr("f_modi") = Now.Date
            Dr("u_modi") = Activo.Login

        Catch ex As IndexOutOfRangeException
            Throw New Exception("GrillAdmin.ActualizarDataTableColumnasManuales: El IDSpot No Existe")
        Catch ex As Exception
            MsgBox(ex.Message & "Actualizar Data Table ")
        End Try
    End Sub

    Public Sub ActualizarNeto(ByVal Fila As UltraDataRow, Optional ByVal Col As String = "", Optional ByVal NuevoValor As Object = Nothing, Optional ByVal IDConvenio As Integer = 0, Optional ByVal AplicandoConvenio As Boolean = False)
        Dim Neto As Single
        Dim i As Byte

        If EstaModificando Then
            Exit Sub
        End If

        Col = Col.ToLower

        If Not NuevoValor Is Nothing And Not Col = "" Then
            Fila.Item(Col) = Valores.CastDBNull(NuevoValor)
        End If


        Fila.Item("id_convenio") = IDConvenio

        'si se cambia el neto, se igual el bruto al neto

        If Col = "neto" Then ' TIPO NETO

            'If AplicandoConvenio Then
            '    Fila.Item("bruto") = Valores.CastDBNull(NuevoValor)
            'End If
            Fila.Item("Bruto") = Valores.CastDBNull(NuevoValor)
            'Fila.Item("brutoactual") = Valores.CastDBNull(NuevoValor)
            Fila.Item("dcto1") = 0
            Fila.Item("dcto2") = 0
            Fila.Item("dcto3") = 0
            Fila.Item("dcto4") = 0
            Fila.Item("dcto5") = 0

            EstaModificando = True

            ActualizarTotalesProgramaTemas(Fila)

            EstaModificando = False

            Exit Sub
        End If

        'TIPO DESCUENTO

        'calculo del neto
        'AG 01/08/2011 +++++++++++
        If AplicandoConvenio = True Then
            If NuevoValor <> Nothing Then
                If Fila.Item("bruto") <> NuevoValor Then
                    Fila.Item("bruto") = NuevoValor
                End If
            End If
        End If

        If Col = "bruto" Then

        End If
        '++++++++++++++++++++++
        Neto = Fila.Item("bruto")
        For i = 1 To 5
            Neto = Neto - (Neto * (Fila.Item("dcto" & i) / 100))
        Next

        Fila.Item("neto") = Neto
        'actual
        'Fila.Item("bruto") = Neto

        ActualizarTotalesProgramaTemas(Fila)

        EstaModificando = False
    End Sub

    Private Sub ActualizarTotalesProgramaTemas(ByVal FilaPadre As UltraDataRow)
        'actualiza solo los totales que se tiene que cambiar cuando se Cambia el NETO o el Bruto
        'que son Total Bruto y Total Neto
        Dim TotalBruto As Single
        Dim TotalNeto As Single
        Dim RatingProgTarget1 As Single
        Dim RatingProgTarget2 As Single
        Dim RatingTanTarget1 As Single
        Dim RatingTanTarget2 As Single

        Dim FilaHijo As UltraDataRow

        'busca el ID de la Banda que tiene los hijos en la FilaPadre
        Dim i As Integer = 0

        Try
            Do While FilaPadre.GetChildRows(i).Count = 0
                i += 1
            Loop
        Catch ex As ArgumentOutOfRangeException
            'si no encuentra filas hijas, sale
            Exit Sub
        End Try

        'recorre los hijos (temas comprados)
        For Each FilaHijo In FilaPadre.GetChildRows(i)
            FilaHijo.Item("Total Bruto") = IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaHijo.Item("dur") * FilaPadre.Item("bruto")
            FilaHijo.Item("Total Neto") = IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaHijo.Item("dur") * FilaPadre.Item("neto")
            FilaHijo.Item("Total GRP Target 1") = IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaPadre.Item(Me.ColumnaRatingTarget1)

            TotalBruto += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaHijo.Item("dur") * FilaPadre.Item("bruto")
            TotalNeto += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaHijo.Item("dur") * FilaPadre.Item("neto")

            RatingProgTarget1 += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaPadre.Item(ColumnaRatingTarget1)
            RatingProgTarget2 += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaPadre.Item(ColumnaRatingTarget2)
            RatingTanTarget1 += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaPadre.Item("rat_tanda_target_1")
            RatingTanTarget2 += IIf(FilaHijo.Item("Total Spots") Is DBNull.Value, 0, FilaHijo.Item("Total Spots")) * FilaPadre.Item("rat_tanda_target_2")
        Next

        FilaPadre.Item("Total Bruto") = TotalBruto
        FilaPadre.Item("Total Neto") = TotalNeto

        FilaPadre.Item("Total GRP Target 1") = RatingProgTarget1
        FilaPadre.Item("Total GRP Target 2") = RatingProgTarget2
        'FilaPadre.Item("Total GRP Tanda Target 1") = RatingTanTarget1
        'FilaPadre.Item("Total GRP Tanda Target 2") = RatingTanTarget2
    End Sub

    Public Sub ActualizarDataTable(ByVal Origen As UltraDataSource, ByVal Destino As DataTable, ByVal ParamArray Columnas() As String)
        Dim S As String
        Dim Ur As UltraDataRow
        Dim i As Integer
        Dim Dr As DataRow

        If Destino.Rows.Count = 0 Then
            Exit Sub
        End If

        'recorre todas las filas del Ultra Data Source
        For Each Ur In Origen.Rows

            Dr = Destino.Select("id_spot=" & Ur.Item("id_spot"))(0)

            For Each S In Columnas

                Try
                    'pasa los datos del Ultra Data Source al Data Table
                    If Dr(S) <> Ur(S) Then
                        Dr(S) = Ur(S)
                    End If
                Catch ex As ArgumentException
                    Mensajes.Mensaje("GrillAdmin.ActualizarDataTable" & vbCrLf & "El Key '" & S & "' No Existe.", TipoMensaje.DeError)
                Catch ex As IndexOutOfRangeException
                Catch ex As DeletedRowInaccessibleException

                End Try

            Next

        Next
    End Sub

    Public Sub BorrarFilaDataTable(ByVal Fila As Integer, ByVal Spot As DataTable)
        Spot.Rows(Fila).Delete()
    End Sub

    Public Function ObtenerColumnaModificable(ByVal Col As ColumnasManuales) As String
        Select Case Col
            Case ColumnasManuales.Programa
                Return "programa"
            Case ColumnasManuales.Bruto
                Return "brutoactual"
            Case ColumnasManuales.Descuento1
                Return "dcto1"
            Case ColumnasManuales.Descuento2
                Return "dcto2"
            Case ColumnasManuales.Descuento3
                Return "dcto3"
            Case ColumnasManuales.Descuento4
                Return "dcto4"
            Case ColumnasManuales.Descuento5
                Return "dcto5"
            Case ColumnasManuales.Rat_Prog_Target_1
                Return "rat_prog_target_1"
            Case ColumnasManuales.Rat_Prog_Target_2
                Return "rat_prog_target_2"
            Case ColumnasManuales.Rat_Tanda_Target_1
                Return "rat_tanda_target_1"
            Case ColumnasManuales.Rat_Tanda_Target_2
                Return "rat_tanda_target_2"
            Case ColumnasManuales.Neto
                Return "neto"
        End Select
    End Function

    Public Function ObtenerColumnaModificable(ByVal Nombre As String) As Integer
        Select Case Nombre.ToLower
            Case "programa"
                Return ColumnasManuales.Programa
            Case "bruto"
                Return ColumnasManuales.Bruto
            Case "dcto1"
                Return ColumnasManuales.Descuento1
            Case "dcto2"
                Return ColumnasManuales.Descuento2
            Case "dcto3"
                Return ColumnasManuales.Descuento3
            Case "dcto4"
                Return ColumnasManuales.Descuento4
            Case "dcto5"
                Return ColumnasManuales.Descuento5
            Case "rat_prog_target_1"
                Return ColumnasManuales.Rat_Prog_Target_1
            Case "rat_prog_target_2"
                Return ColumnasManuales.Rat_Prog_Target_2
            Case "rat_tanda_target_1"
                Return ColumnasManuales.Rat_Tanda_Target_1
            Case "rat_tanda_target_2"
                Return ColumnasManuales.Rat_Tanda_Target_2
            Case Else
                Return 0
        End Select
    End Function
    Public Function EsColumnaDescuento(ByVal Columna As UltraGridColumn) As Boolean
        Return EsColumnaDescuento(Columna.Key)
    End Function
    Public Function EsColumnaDescuento(ByVal Grilla As UltraGrid, ByVal Indice As Integer) As Boolean
        Return EsColumnaDescuento(Grilla.DisplayLayout.Bands(0).Columns(Indice).Key)
    End Function
    Public Function EsColumnaDescuento(ByVal Grilla As UltraGrid, ByVal Colkey As String) As Boolean
        Return EsColumnaDescuento(Grilla.DisplayLayout.Bands(0).Columns(Colkey))
    End Function
    Public Function EsColumnaDescuento(ByVal colkey As String) As Boolean
        If colkey.ToLower.IndexOf("dcto") > -1 Then
            Return True
        End If
        Return False
    End Function
    Public Function EsColumnaRating(ByVal Columna As UltraGridColumn) As Boolean
        Return EsColumnaRating(Columna.Key)
    End Function
    Public Function EsColumnaRating(ByVal Grilla As UltraGrid, ByVal Indice As Integer) As Boolean
        Return EsColumnaRating(Grilla.DisplayLayout.Bands(0).Columns(Indice).Key)
    End Function
    Public Function EsColumnaRating(ByVal Grilla As UltraGrid, ByVal Colkey As String) As Boolean
        Return EsColumnaRating(Grilla.DisplayLayout.Bands(0).Columns(Colkey))
    End Function
    Public Function EsColumnaRating(ByVal Colkey As String) As Boolean
        If Colkey.ToLower.IndexOf("rat") > -1 Or Colkey.IndexOf("shr") > -1 Or Colkey.IndexOf("aff") > -1 Or Colkey.IndexOf("fid") > -1 Then
            Return True
        End If
        Return False
    End Function
    Public Function EsColumnaCalendario(ByVal Columna As DataColumn) As Boolean
        Return EsColumnaCalendario(Columna.ColumnName)
    End Function

    Public Function EsColumnaCalendario(ByVal Columna As UltraDataColumn) As Boolean
        Return EsColumnaCalendario(Columna.Key)
    End Function

    Public Function EsColumnaCalendario(ByVal Columna As UltraGridColumn) As Boolean
        Return EsColumnaCalendario(Columna.Key)
    End Function
    Public Function EsColumnaCalendario(ByVal grilla As UltraGrid, ByVal Indice As Integer) As Boolean
        Return EsColumnaCalendario(grilla.DisplayLayout.Bands(0).Columns(Indice).Key)
    End Function
    Public Function EsColumnaCalendario(ByVal Celda As UltraGridCell) As Boolean
        Return EsColumnaCalendario(Celda.Column.Key)
    End Function

    Public Function EsColumnaCalendario(ByVal NombreColumna As String) As Boolean
        'si tiene una barra es una columna del calendario
        '(la barra es porque los nombres de las columnas del calendario son una Fecha '24/11/2005')
        If NombreColumna.IndexOf("/") > -1 Then
            Return True
        End If

        Return False
    End Function

    Public Function EstaAgrupando(ByVal Grilla As UltraGrid) As TresEstados
        Dim C As UltraGridColumn
        Dim Agrupadas As Integer

        For Each C In Grilla.DisplayLayout.Bands(0).Columns
            If C.IsGroupByColumn Then
                Agrupadas = Agrupadas + 1
            End If
        Next

        If Agrupadas > ColumnasAgrupadas Then
            ColumnasAgrupadas = Agrupadas
            Return TresEstados.Verdadero
        End If

        If Agrupadas < ColumnasAgrupadas Then
            ColumnasAgrupadas = Agrupadas
            Return TresEstados.Falso
        End If

        If Agrupadas = ColumnasAgrupadas Then
            Return TresEstados.Igual
        End If
    End Function

    Public Function ColumnasVisibles(ByVal Banda As UltraGridBand) As Integer
        Dim C As UltraGridColumn

        For Each C In Banda.Columns
            If Not C.Hidden Then
                ColumnasVisibles += 1
            End If
        Next
    End Function

    Public Sub ModificarColumnasHijas(ByVal Grilla As UltraGrid)
        Dim i As Integer
        Dim FilaHijo As UltraGridRow
        Dim MostrarColumna As Boolean

        For i = 1 To Grilla.DisplayLayout.Bands.Count - 1

            With Grilla.DisplayLayout.Bands(i)

                If ColumnasVisibles(Grilla.DisplayLayout.Bands(0)) <> ColumnasVisibles(Grilla.DisplayLayout.Bands(i)) Then
                    If ColumnasVisibles(Grilla.DisplayLayout.Bands(0)) > ColumnasVisibles(Grilla.DisplayLayout.Bands(i)) Then
                        MostrarColumna = True
                    End If

                    If ColumnasVisibles(Grilla.DisplayLayout.Bands(0)) < ColumnasVisibles(Grilla.DisplayLayout.Bands(i)) Then
                        MostrarColumna = False
                    End If

                    If MostrarColumna Then
                        'muestra columna
                        If .Columns(0).Hidden = True Then
                            .Columns(0).Hidden = False
                        ElseIf .Columns(1).Hidden = True Then
                            .Columns(1).Hidden = False
                        ElseIf .Columns(2).Hidden = True Then
                            .Columns(2).Hidden = False
                        End If
                    Else
                        'oculta columna
                        If .Columns(0).Hidden = False Then
                            .Columns(0).Hidden = True
                        ElseIf .Columns(1).Hidden = False Then
                            .Columns(1).Hidden = True
                        ElseIf .Columns(2).Hidden = False Then
                            .Columns(2).Hidden = True
                        End If
                    End If
                End If

            End With

        Next
    End Sub

    Public Sub ModificarColumnasHijas(ByVal Grilla As UltraGrid, ByVal QuitarColumna As Boolean)
        Dim i As Integer
        Dim FilaHijo As UltraGridRow

        For i = 1 To Grilla.DisplayLayout.Bands.Count - 1

            With Grilla.DisplayLayout.Bands(i)

                If QuitarColumna Then
                    'oculta columna
                    If .Columns(0).Hidden = False Then
                        .Columns(0).Hidden = True
                    ElseIf .Columns(1).Hidden = False Then
                        .Columns(1).Hidden = True
                    ElseIf .Columns(2).Hidden = False Then
                        .Columns(2).Hidden = True
                    End If
                Else
                    'muestra columna
                    If .Columns(0).Hidden = True Then
                        .Columns(0).Hidden = False
                    ElseIf .Columns(1).Hidden = True Then
                        .Columns(1).Hidden = False
                    ElseIf .Columns(2).Hidden = True Then
                        .Columns(2).Hidden = False
                    End If
                End If

            End With

        Next
    End Sub

    Public Sub ActualizarColumnasHijas(ByVal Grilla As UltraGrid)
        Dim HayGrupos As TresEstados = EstaAgrupando(Grilla)

        If HayGrupos = TresEstados.Verdadero Then
            ModificarColumnasHijas(Grilla, True)
        End If

        If HayGrupos = TresEstados.Falso Then
            ModificarColumnasHijas(Grilla, False)
        End If
    End Sub

    Public Sub AgregarFila(ByVal Ds As UltraDataSource, ByVal Spots As DataTable, ByVal Tarifas As DataTable, ByVal IndiceFila As Integer, Optional ByVal TarifasTV As Object = Nothing)
        Dim Dr As DataRow
        Dim Aux As New ArrayList
        Dim C As DataColumn
        Dim R As UltraDataRow
        Dim Fila As Integer
        Dim Filas As New ArrayList
        Dim Dt As New DataTable, i As Integer, j As Integer
        Dim Cant As Integer = Tarifas.Rows.Count - 1
        Dim Indice() As DataRow
        Indice = Spots.Select("ID_Spot >=0", "ID_Spot Desc")

        For i = 0 To Cant
            Try
                Dr = Tarifas.Rows(i)

                If BuscarIdTarifa(Dr("id_tarifa_tv"), Ds) = False Then
                    R = Ds.Rows.Add

                    'Esteban. 15/03/06. EN LA COLUMNA "ID" SE GUARDA EL INDICE DE FILA
                    'PARA MANTENER UN INDICE UNICO
                    R.Item("id") = R.Index

                    For Each C In Tarifas.Columns
                        If C.ColumnName.ToLower = "id_spot" Then
                            If Indice.Length = 0 Then
                                Fila = j + 1
                            Else
                                Fila = Indice(0)("id_spot") + j + 1
                            End If

                            R(C.ColumnName) = Fila
                            If Filas.IndexOf(Fila) < 0 Then
                                Filas.Add(Fila)
                            Else
                                Fila += 1
                                Filas.Add(Fila)
                            End If

                        Else
                            'If Me.EsColumnaCalendario(C) Then
                            R(C.ColumnName) = Dr(C)
                            ' Else
                            ' R(C.ColumnName) = Dr(C)
                            ' End If

                        End If
                    Next
                Else
                    Aux.Add(Dr)
                    ' Fila = Fila - 1
                End If
            Catch e As Exception
                MsgBox("Agregar FILA " & e.Message)

            End Try
            j = j + 1
        Next

        For Each Dr In Aux
            Tarifas.Rows.Remove(Dr)
        Next

        ActualizarSpotBase(Spots, Tarifas, Filas, TarifasTV)
    End Sub

    Public Function EsDiaPrograma(ByVal Celda As UltraGridCell) As Boolean
        Dim TieneLetra As Boolean
        Dim Dias As String
        Dim i As Integer

        If Celda.Row.Cells.Exists("dias") Then
            Dias = Celda.Row.Cells("dias").Text
        Else
            Dias = Celda.Row.ParentRow.Cells("dias").Text
        End If

        For i = 0 To Dias.Length - 1
            Dim L As String = Dias.Substring(i, 1).ToLower

            If Celda.Column.Header.Caption.Substring(0, 1).ToLower = L Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Shared Sub ActualizarSpotBase(ByVal Spots As DataTable, ByVal NuevasTarifas As DataTable, ByVal Filas As ArrayList, Optional ByVal Tarifas As Object = Nothing)
        Dim Dr As DataRow
        Dim DrT As DataRow, j As Integer
        Dim c As DataColumn
        Dim AvisosEspeciales As New ArrayList
        'Dim indice As DataRow = Spots.Select("id_spot>=0", "id_spot desc")(0)


        For Each Dr In NuevasTarifas.Rows
            Try
                Dr = Spots.NewRow
                Dr("ID_Spot") = CLng(Filas(j)) 'indice("id_spot") + j '
                Dr("ID_Campania") = Activo.IDCampaña
                Dr("ID_Sistema") = Activo.IDSistema
                Dr("ID_Ejercicio") = Activo.IDEjercicio
                Dr("ID_Soporte") = NuevasTarifas.Rows(j)("ID_Soporte")
                Dr("ID_Tarifa_Tv") = NuevasTarifas.Rows(j)("ID_TARIFA_TV")
                Dr("ID_Programa") = NuevasTarifas.Rows(j)("ID_Programa")
                Dr("Programa") = NuevasTarifas.Rows(j)("Programa")
                Dr("Bruto") = NuevasTarifas.Rows(j)("Bruto")
                Dr("Neto") = NuevasTarifas.Rows(j)("Bruto")
                Dr("Tipo_Planificacion") = 0

                Dr("desc_campania") = Activo.Campaña
                Dr("desc_sistema") = Activo.Sistema
                Dr("desc_ejercicio") = Activo.Ejercicio
                ' HORA SPOT 1
                Tarifas.id_tarifa_tv = NuevasTarifas.Rows(j)("ID_TARIFA_TV")


                '------------AGREGADO ESPECIALES---------
                If Tarifas.EsEspecial > 0 Then
                    AvisosEspeciales.Add(Dr("ID_Spot"))
                End If
                '----------------------------------------

                Dr("id_Convenio") = 0
                Dr("h_inicio") = Trim(NuevasTarifas.Rows(j)("h_inicio")).Substring(0, 2)
                Dr("h_fin") = Trim(NuevasTarifas.Rows(j)("h_fin")).Substring(0, 2)
                Dr("m_inicio") = Trim(NuevasTarifas.Rows(j)("h_inicio")).Substring(3, 2)
                Dr("m_fin") = Trim(NuevasTarifas.Rows(j)("h_fin")).Substring(3, 2)

                Dr("DCTO1") = 0
                Dr("DCTO2") = 0
                Dr("DCTO3") = 0
                Dr("DCTO4") = 0
                Dr("DCTO5") = 0

                Dr("RAT_PROG_TARGET_1") = NuevasTarifas.Rows(j)("RAT_PROG_TARGET_1")
                Dr("SHR_PROG_TARGET_1") = NuevasTarifas.Rows(j)("SHR_PROG_TARGET_1")
                Dr("AFF_PROG_TARGET_1") = NuevasTarifas.Rows(j)("AFF_PROG_TARGET_1")
                Dr("RCH_PROG_TARGET_1") = NuevasTarifas.Rows(j)("RCH_PROG_TARGET_1")
                Dr("RAT_M_PROG_TARGET_1") = NuevasTarifas.Rows(j)("RAT_M_PROG_TARGET_1")
                Dr("FID_PROG_TARGET_1") = NuevasTarifas.Rows(j)("FID_PROG_TARGET_1")

                Dr("RAT_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("RAT_TANDA_TARGET_1")
                Dr("SHR_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("SHR_TANDA_TARGET_1")
                Dr("AFF_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("AFF_TANDA_TARGET_1")
                Dr("RCH_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("RCH_TANDA_TARGET_1")
                Dr("RAT_M_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("RAT_M_TANDA_TARGET_1")
                Dr("FID_TANDA_TARGET_1") = NuevasTarifas.Rows(j)("FID_TANDA_TARGET_1")

                If NuevasTarifas.Rows(j)("RAT_PROG_TARGET_2") Is DBNull.Value Then
                    Dr("RAT_PROG_TARGET_2") = 0
                    Dr("SHR_PROG_TARGET_2") = 0
                    Dr("AFF_PROG_TARGET_2") = 0
                    Dr("RCH_PROG_TARGET_2") = 0
                    Dr("FID_PROG_TARGET_2") = 0

                    Dr("RAT_TANDA_TARGET_2") = 0
                    Dr("SHR_TANDA_TARGET_2") = 0
                    Dr("AFF_TANDA_TARGET_2") = 0
                    Dr("RCH_TANDA_TARGET_2") = 0
                    Dr("RAT_M_TANDA_TARGET_2") = 0
                    Dr("FID_TANDA_TARGET_2") = 0
                Else
                    Dr("RAT_PROG_TARGET_2") = NuevasTarifas.Rows(j)("RAT_PROG_TARGET_1")
                    Dr("SHR_PROG_TARGET_2") = NuevasTarifas.Rows(j)("SHR_PROG_TARGET_2")
                    Dr("AFF_PROG_TARGET_2") = NuevasTarifas.Rows(j)("AFF_PROG_TARGET_2")
                    Dr("RCH_PROG_TARGET_2") = NuevasTarifas.Rows(j)("RCH_PROG_TARGET_2")
                    Dr("RAT_M_PROG_TARGET_2") = NuevasTarifas.Rows(j)("RAT_M_PROG_TARGET_2")
                    Dr("FID_PROG_TARGET_2") = NuevasTarifas.Rows(j)("FID_PROG_TARGET_2")

                    Dr("RAT_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("RAT_TANDA_TARGET_2")
                    Dr("SHR_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("SHR_TANDA_TARGET_2")
                    Dr("AFF_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("AFF_TANDA_TARGET_2")
                    Dr("RCH_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("RCH_TANDA_TARGET_2")
                    Dr("RAT_M_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("RAT_M_TANDA_TARGET_2")
                    Dr("FID_TANDA_TARGET_2") = NuevasTarifas.Rows(j)("FID_TANDA_TARGET_2")
                End If

                Dr("u_alta") = Activo.Login
                Dr("f_alta") = Date.Today

                Spots.Rows.Add(Dr)
                j += 1
            Catch a As Exception
                MsgBox(a.Message)
            End Try
        Next
        Activo.Especiales = AvisosEspeciales
    End Sub

    Public Sub BuscarRepetidos(ByVal Dt As DataTable, ByVal Detalle As DataTable)
        Dim r As DataRow(), i As Long
        Dim MayorId As DataRow = Dt.Select("id_spot>=0", "id_spot desc")(0)
        Dim ID As Long = MayorId("id_spot") + 1
        Dim ViejoID As Long, NuevoId As Long


        For Each f As DataRow In Dt.Rows

            r = Dt.Select("ID_spot= " & f("id_spot"))
            If r.Length > 1 Then
                For Each fr As DataRow In r
                    i += 1
                    ViejoID = fr("id_spot")
                    NuevoId = ID + i
                    fr("id_spot") = NuevoId
                    For Each Det As DataRow In Detalle.Select("id_spot=" & ViejoID)
                        Det("id_spot") = NuevoId
                    Next
                    Detalle.AcceptChanges()
                Next
                Dt.AcceptChanges()
            End If
        Next


    End Sub
    Private Function BuscarIdTarifa(ByVal IdTarifa As Integer, ByVal Ds As UltraDataSource) As Boolean
        Dim R As UltraDataRow

        For Each R In Ds.Rows
            If R("id_tarifa_tv") = IdTarifa Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function AnexarSoportesMMS(ByVal DtBaseDatos As DataTable, ByVal IdMedio As Integer, Optional ByVal NombreColumna As String = "", Optional ByVal SopoAlternativa As String = "", Optional ByVal SoporteEnvio As Integer = 0) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer
        Dim DtSoporteFiltro As New DataTable

        If NombreColumna <> "" Then
            DtBaseDatos.Columns.Add(NombreColumna, GetType(String))
            DtBaseDatos.AcceptChanges()
        End If

        If IdMedio > -1 Then
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & IdMedio)
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
        Else
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r(NombreColumna) = Rows(i).Item("DESCRIPCION").ToString
                Next
            Next
        End If

        If SopoAlternativa = "Alternativa" Then
            DtBaseDatos.Columns.Add("id_plaza", GetType(Integer))
            DtBaseDatos.Columns.Add("id_cadena", GetType(String))
            DtBaseDatos.AcceptChanges()
            For Each r As DataRow In DtBaseDatos.Rows
                Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                For i = 0 To Rows.Length - 1
                    r("id_plaza") = Rows(i).Item("COD_COBERTURA").ToString
                    r("id_cadena") = Rows(i).Item("ID_CADENA").ToString
                Next
            Next
        End If


        If SopoAlternativa <> "Alternativa" Then
            If DtBaseDatos.Rows.Count > 0 Then
                IdMedio = DtBaseDatos.Rows(0)("id_medio").ToString()
                If IdMedio = 3 Or IdMedio = 7 Or IdMedio = 2 Then 'AG Produccion +++++++++++++++++++++++++++++++ 
                    If SoporteEnvio = 1 Then 'Esto se coloca para los soportes de Envio a compra exterior
                        DtSoporteFiltro = DtBaseDatos.DefaultView.ToTable(True, "id_soporte", "soporte")
                    Else
                        DtSoporteFiltro = DtBaseDatos.DefaultView.ToTable(True, "id_soporte", "descripcion")
                    End If
                Else
                    DtSoporteFiltro = DtBaseDatos.DefaultView.ToTable(True, "id_soporte", "descripcion")
                End If
            End If
        Else
            DtSoporteFiltro = DtBaseDatos
        End If


        Return DtSoporteFiltro

    End Function

    Public Function CargarDTMMS(ByVal DtDatos As DataTable, ByVal CacheIndex As Integer, ByVal ParamArray Parametros() As Object) As DataTable

        Dim Rows() As DataRow
        Dim i As Integer

        Select Case CacheIndex
            Case Activo.CachesMMS.CacheSoportes
                For Each r As DataRow In DtDatos.Rows
                    Rows = Activo.DTSoportesCache.Select("ID_SOPORTE=" & r("id_soporte") & " and " & "ID_MEDIO=" & r("id_medio"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheClientes
                For Each r As DataRow In DtDatos.Rows
                    Rows = Activo.DTClientesCache.Select("ID_CLIENTE=" & r("id_cliente"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheMedios
            Case Activo.CachesMMS.CacheProductos
                For Each r As DataRow In DtDatos.Rows
                    Rows = Activo.DTProductosCache.Select("ID_PRODUCTO=" & r("id_producto") & " and " & "ID_CLIENTE=" & r("id_cliente"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheMateriales
            Case Activo.CachesMMS.CacheTipoSoportes
                For Each r As DataRow In DtDatos.Rows
                    ''modified by dcaime
                    Rows = Activo.DTTipoSoporteCache.Select("ID_TIPO_SOPORTE=" & IIf(IsDBNull(r("TIPO_SOPORTE")), -1, r("TIPO_SOPORTE")) & " and " & "ID_MEDIO=" & r("id_medio"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CachePlazas
                For Each r As DataRow In DtDatos.Rows
                    Rows = Activo.DTPlazaCache.Select("ID_PLAZA=" & r("id_plaza"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
            Case Activo.CachesMMS.CacheProveedor
                For Each r As DataRow In DtDatos.Rows
                    Rows = Activo.DTProveedorCache.Select("ID_PROVEEDOR=" & r("id_provedor"))
                    For i = 0 To Rows.Length - 1
                        r(Parametros(0)) = Rows(i).Item("DESCRIPCION").ToString
                    Next
                Next
        End Select
        DtDatos.AcceptChanges()
        Return DtDatos

    End Function

    Public Function EliminarColumnasDTMMS(ByVal DtDatos As DataTable, ByVal CacheIndex As Integer, ByVal ParamArray Parametros() As Object) As DataTable

        Dim i As Integer

        Select Case CacheIndex
            Case Activo.CachesMMS.CacheSoportes
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheClientes
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheMedios
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheProductos
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheMateriales
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheTipoSoportes
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CachePlazas
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
            Case Activo.CachesMMS.CacheProveedor
                For i = 0 To Parametros.Length - 1
                    DtDatos.Columns.Remove(Parametros(i).ToString)
                Next
        End Select
        DtDatos.AcceptChanges()
        Return DtDatos
    End Function

    Public Sub AgregarHijoAuspisio(ByVal Ds As UltraDataSource, ByVal SpotDetalle As DataTable, ByVal IndiceFila As Integer, ByVal KeyColumna As String, ByVal Letras As String, ByVal Columnas As ArrayList, ByVal Temas As DataTable, ByVal IDSpot As Integer)
        Letras = Letras.ToUpper
        Dim FilaHija As UltraDataRow
        Dim FilaPadre As UltraDataRow = Ds.Rows(IndiceFila)
        Dim Existe, TemaEncontrado As Boolean
        Dim IndiceHijo As Integer

        FilaPadre.Item(KeyColumna) = Letras

        Dim NombreBanda As String = "Banda" & FilaPadre.Item("id") '***
        Dim Letra As String
        Dim i As Integer

        'si no existe, crea la banda de filas hijas
        CrearBanda(Ds, NombreBanda, Columnas)

        'recorre todas las letras que se pasaron
        For i = 0 To Letras.Length - 1
            Letra = Letras.Substring(i, 1).ToUpper 'despeja una letra por vez

            Dim IndiceFilaHija As Integer

            'trae el indice de la fila del tema que se esta buscnado
            IndiceFilaHija = BuscarTagEnFila(Letra, FilaPadre.GetChildRows(NombreBanda))

            'si hay una fila con ese tema, modifica los totales, sino, agrega la fila
            If IndiceFilaHija > -1 Then
                Dim Filas As UltraDataRowsCollection = Ds.Rows(IndiceFila).GetChildRows(NombreBanda)

                'actualiza la cantidad de temas que se compraron
                Filas(IndiceFilaHija).Item(KeyColumna) = ContarLetras(Letra, Letras)
            Else
                'Inserta fila hija (ordenado segun tema) en caso de Radio sino lo agrega
                If Activo.IDMedio = MedioRadio Then
                    IndiceHijo = FilaPadre.GetChildRows(NombreBanda).Count
                    For Each FPIndice As UltraDataRow In FilaPadre.GetChildRows(NombreBanda)
                        TemaEncontrado = False
                        For Each TemaIndice As DataRow In Temas.Rows
                            If FPIndice.Tag = TemaIndice("Id_Tema") Then
                                Exit For
                            End If
                            If Letra = TemaIndice("Id_Tema") Then
                                IndiceHijo = FPIndice.Index
                                TemaEncontrado = True
                                Exit For
                            End If
                        Next
                        If TemaEncontrado Then
                            Exit For
                        End If
                    Next

                    FilaHija = Ds.Rows(IndiceFila).GetChildRows(NombreBanda).Insert(IndiceHijo)
                Else
                    FilaHija = Ds.Rows(IndiceFila).GetChildRows(NombreBanda).Add
                End If

                'agrega la letra en el tag para saber cuando se agrega una fila con ese tema
                FilaHija.Tag = Letra

                FilaHija.Item(KeyColumna) = 1

                'carga el Nombre del Material y la duracion
                Dim Material As String = ObtenerDato(Temas, "id_tema = '" & Letra & "'", "material")

                If Material Is Nothing Then
                    Material = "Sin Material"
                End If
                If Material.ToLower = "no disponible" Then
                    Material = "Sin Material"
                End If

                FilaHija.Item("Tema") = "Tema " & Letra & ": " & Material 'IIf(Material.ToLower = "no disponible", "Sin Material", Material)
                FilaHija.Item("Dur") = ObtenerDato(Temas, "id_tema = '" & Letra & "'", "duracion")
            End If
        Next

        'actualiza la cantidad de temas comprados y borra las filas de temas que no tienen compras
        ActualizarFilasTemas(FilaPadre, SpotDetalle, Temas, NombreBanda, IDSpot)
    End Sub
End Class

Public Class FilaTema
    Dim mFila As UltraDataRow
    Dim mCantidadTemas As Integer

    Public Property Fila() As UltraDataRow
        Get
            Return mFila
        End Get
        Set(ByVal Value As UltraDataRow)
            mFila = Value
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

    Public ReadOnly Property Tema() As String
        Get
            Return Fila.Tag
        End Get
    End Property
End Class

Public Class CampoTipo
    Dim mCampo As String
    Dim mTipo As Type

    Sub New()
    End Sub

    Sub New(ByVal Campo As String, ByVal Tipo As Type)
        Me.Campo = Campo
        Me.Tipo = Tipo
    End Sub

    Public Property Campo() As String
        Get
            Return mCampo
        End Get
        Set(ByVal Value As String)
            mCampo = Value
        End Set
    End Property

    Public Property Tipo() As Type
        Get
            Return mTipo
        End Get
        Set(ByVal Value As Type)
            mTipo = Value
        End Set
    End Property
End Class

Public Enum ColumnasManuales
    Programa = 1
    Bruto = 2
    Descuento1 = 4
    Descuento2 = 8
    Descuento3 = 16
    Descuento4 = 32
    Descuento5 = 64
    Rat_Prog_Target_1 = 128
    Rat_Prog_Target_2 = 256
    Rat_Tanda_Target_1 = 512
    Rat_Tanda_Target_2 = 1024
    Neto = 2048
End Enum
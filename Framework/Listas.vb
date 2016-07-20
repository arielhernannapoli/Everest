Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win

Public Class NodoLista
    Public CampoID As Integer
    Public CampoDescripcion As String
    Public Imagen As Integer

    Sub New(ByVal CampoID As Integer, ByVal CampoDescripcion As String, ByVal Imagen As Integer)
        Me.CampoID = CampoID
        Me.CampoDescripcion = CampoDescripcion
        Me.Imagen = Imagen
    End Sub
End Class

Public Class Listas

    Public Shared Sub CargarCombo(ByVal Combo As UltraCombo, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False, Optional ByVal DescripcionFilaCero As String = "")
        Combo.BeginUpdate()

        If AgregarFilaVacia Then
            Dim Dr As DataRow

            Dr = Dt.NewRow

            Dr.Item(CampoID) = -1
            Dr.Item(CampoDescripcion) = DescripcionFilaCero

            Dt.Rows.InsertAt(Dr, 0)
        End If
        Combo.DisplayMember = CampoDescripcion
        Combo.ValueMember = CampoID
        Combo.DataSource = Dt



        Combo.EndUpdate()
    End Sub
    Public Shared Sub CargarCombo(ByVal Combo As ComboBox, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False)
        Dim IL As ItemLista

        Combo.BeginUpdate()

        Combo.DisplayMember = "Descripcion"
        Combo.ValueMember = "ID"
        Combo.Items.Clear()

        If AgregarFilaVacia Then
            IL = New ItemLista

            IL.ID = -1
            IL.Descripcion = "--- NINGUNO ---"

            Combo.Items.Add(IL)
        End If

        For Each Dr As DataRow In Dt.Rows
            IL = New ItemLista

            IL.ID = Dr(CampoID)
            IL.Descripcion = Dr(CampoDescripcion)

            Combo.Items.Add(IL)
        Next

        Combo.EndUpdate()
    End Sub
    Public Shared Sub CargarCombo(ByRef pCombo As UltraComboEditor, ByVal pobjTable As DataTable, ByVal pstrDisplayText As String, Optional ByVal pblnEsSeleccioneOpcion As Boolean = True, Optional ByVal SinOpcion As String = "")
        Dim objItem As ValueListItem
        Dim objRow As DataRow
        pCombo.Items.Clear()
        pCombo.Text = ""
        If pblnEsSeleccioneOpcion = True Then
            objItem = New ValueListItem
            objItem.DisplayText = SinOpcion
            objItem.DataValue = Nothing
            pCombo.Items.Add(objItem)
        End If

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow(pstrDisplayText)
            pCombo.Items.Add(objItem)
        Next

        If pCombo.Items.Count <> 0 Then
            pCombo.SelectedIndex = 0
        End If
    End Sub
    Public Shared Sub CargarCombo(ByVal Combo As UltraComboEditor, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal AgregarFilaVacia As Boolean = False, Optional ByVal DescripcionFilaCero As String = "")
        '  Combo.BeginUpdate()

        If AgregarFilaVacia Then
            Dim Dr As DataRow

            Dr = Dt.NewRow

            Dr.Item(CampoID) = -1
            Dr.Item(CampoDescripcion) = DescripcionFilaCero

            Dt.Rows.InsertAt(Dr, 0)
        End If
        Combo.DataSource = Dt


        Combo.DisplayMember = CampoDescripcion
        Combo.ValueMember = CampoID

        ' Combo.EndUpdate()
    End Sub
    Public Shared Sub SeleccionarItem(ByVal pCombo As UltraComboEditor, ByVal pColumnName As String, ByVal pValue As String)
        For ItemCount As Integer = 0 To pCombo.Items.Count - 1
            If Not pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue Is Nothing AndAlso pCombo.Items(ItemCount).ValueList.ValueListItems(ItemCount).DataValue(pColumnName) = pValue Then
                pCombo.SelectedIndex = ItemCount
                Return
            End If
        Next
        pCombo.SelectedIndex = 0
    End Sub
    Public Shared Sub OcultarColumnas(ByVal Combo As UltraCombo, ByVal Columna As Integer)
        Combo.DisplayLayout.Bands(0).Columns(Columna).Hidden = True
    End Sub

    Public Shared Sub OcultarColumnas(ByVal Combo As UltraCombo, ByVal ParamArray Columnas() As String)
        Dim i As Integer

        For i = 0 To Columnas.Length - 1
            Combo.DisplayLayout.Bands(0).Columns(Columnas(i)).Hidden = True
        Next

        Combo.DisplayLayout.Bands(0).Columns(Combo.DisplayMember).Width = Combo.Width
    End Sub

    Public Shared Sub OcultarColumnas(ByVal Grilla As UltraGrid, ByVal ParamArray Columnas() As String)
        Dim i As Integer

        For i = 0 To Columnas.Length - 1
            Try
                Grilla.DisplayLayout.Bands(0).Columns(Columnas(i)).Hidden = True
            Catch ex As ArgumentException
                Mensajes.Mensaje("Listas.OcultarColumnas: La Columna '" & Columnas(i) & "' No Existe en la Grilla", TipoMensaje.DeError)
            End Try
        Next
    End Sub

    Public Shared Sub OcultarHeader(ByVal Combo As UltraCombo)
        Combo.DisplayLayout.Bands(0).ColHeadersVisible = False
    End Sub

    Public Shared Sub CargarTree(ByVal Tree As TreeView, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String, Optional ByVal MostrarID As Boolean = False, Optional ByVal IndiceImagen As Integer = -1)
        Dim Dr As DataRow
        Dim Nodo As TreeNode

        Tree.BeginUpdate()
        Tree.Nodes.Clear()

        For Each Dr In Dt.Rows
            Nodo = New TreeNode

            Nodo.Text = Dr(CampoDescripcion) & IIf(MostrarID, " - " & Dr(CampoID), "")
            Nodo.Tag = Dr(CampoID)
            Nodo.ImageIndex = IndiceImagen

            Tree.Nodes.Add(Nodo)
        Next

        Tree.EndUpdate()
    End Sub

    Public Shared Sub CargarTree(ByVal Tree As TreeView, ByVal Dt As DataTable, ByVal ParamArray Nodos() As NodoLista)
        Dim i As Integer

        Dim N As TreeNode
        Dim Dr As DataRow
        Dim AuxDt As DataTable
        Dim Aux As New Hashtable


        For i = 0 To UBound(Nodos)

            For Each Dr In Dt.Rows

            Next

        Next
    End Sub

    Private Shared Sub CargarNodos(ByVal Padre As TreeNode, ByVal Dt As DataTable, ByVal Nodo As NodoLista)
        Dim Dr As DataRow
        Dim N As TreeNode

        For Each Dr In Dt.Rows

            If Not IsDBNull(Dr(Nodo.CampoID)) Then
                N = New TreeNode

                N.Text = IIf(IsDBNull(Dr(Nodo.CampoDescripcion)), "", Dr(Nodo.CampoDescripcion))
                N.Tag = IIf(IsDBNull(Dr(Nodo.CampoID)), "", Dr(Nodo.CampoID))
                N.ImageIndex = Nodo.Imagen
                N.SelectedImageIndex = Nodo.Imagen

                Padre.Nodes.Add(N)
            End If
        Next
    End Sub

    Public Shared Sub CargarTree(ByVal Tree As TreeView, ByVal Dt As DataTable, ByVal CampoID1 As String, ByVal Descripcion1 As String, ByVal CampoID2 As String, ByVal Descripcion2 As String, ByVal CampoID3 As String, ByVal Descripcion3 As String, Optional ByVal MostrarID As Boolean = False, Optional ByVal Imagen1 As Integer = -1, Optional ByVal Imagen2 As Integer = -1, Optional ByVal Imagen3 As Integer = -1)
        'cagar un tree view con 2 niveles, padre hijo, haciendo un corte de control por el CampoIDPadre
        Dim Dr As DataRow
        Dim Nodo As TreeNode
        Dim Nodo2 As TreeNode
        Dim Nodo3 As TreeNode

        Dim Aux1 As New Hashtable
        Dim Aux2 As New Hashtable

        Dim Dt2 As DataTable
        Dim Dt3 As DataTable

        Dim Dr2 As DataRow
        Dim Dr3 As DataRow

        Tree.BeginUpdate()
        Tree.Nodes.Clear()

        For Each Dr In Dt.Rows

            If Not Aux1.Contains(Dr(CampoID1)) Then
                Aux1.Add(Dr(CampoID1), Dr(CampoID1))

                Nodo = New TreeNode

                'agrega el padre
                Nodo.Text = Dr(Descripcion1) & IIf(MostrarID, " - " & Dr(CampoID1), "")
                Nodo.Tag = Dr(CampoID1)
                Nodo.ImageIndex = Imagen1
                Nodo.SelectedImageIndex = Imagen1

                'agrega los hijos
                Dt2 = FiltrarDT(Dt, CampoID1 & " = " & Dr(CampoID1))

                For Each Dr2 In Dt2.Rows

                    If Not Aux2.Contains(Dr2(CampoID2)) Then
                        Aux2.Add(Dr2(CampoID2), Dr2(CampoID2))

                        If Not IsDBNull(Dr2(CampoID2)) Then
                            Nodo2 = New TreeNode

                            Nodo2.Text = IIf(IsDBNull(Dr2(Descripcion2)), "", Dr2(Descripcion2))
                            Nodo2.Tag = IIf(IsDBNull(Dr2(CampoID2)), "", Dr2(CampoID2))
                            Nodo2.ImageIndex = Imagen2
                            Nodo2.SelectedImageIndex = Imagen2

                            'agrega los hijos
                            Dt3 = FiltrarDT(Dt, CampoID2 & " = " & Dr2(CampoID2))

                            For Each Dr3 In Dt3.Rows
                                If Not IsDBNull(Dr3(CampoID3)) Then
                                    Nodo3 = New TreeNode

                                    Nodo3.Text = IIf(IsDBNull(Dr3(Descripcion3)), "", Dr3(Descripcion3))
                                    Nodo3.Tag = IIf(IsDBNull(Dr3(CampoID3)), "", Dr3(CampoID3))
                                    Nodo3.ImageIndex = Imagen3
                                    Nodo3.SelectedImageIndex = Imagen3

                                    Nodo2.Nodes.Add(Nodo3)
                                End If
                            Next

                            Nodo.Nodes.Add(Nodo2)
                        End If
                    End If

                Next

                'agrega el padre al tree
                Tree.Nodes.Add(Nodo)
            End If

        Next

        Tree.EndUpdate()

    End Sub
    Public Shared Sub CargarTree(ByVal SinRelacion As Boolean, ByVal Tree As TreeView, ByVal Dt As DataTable, ByVal CampoID1 As String, ByVal Descripcion1 As String, ByVal CampoID2 As String, ByVal Descripcion2 As String, ByVal CampoID3 As String, ByVal Descripcion3 As String, Optional ByVal MostrarID As Boolean = False, Optional ByVal Imagen1 As Integer = -1, Optional ByVal Imagen2 As Integer = -1, Optional ByVal Imagen3 As Integer = -1)
        'cagar un tree view con 2 niveles, padre hijo, haciendo un corte de control por el CampoIDPadre
        Dim Dr As DataRow
        Dim Nodo As TreeNode
        Dim Nodo2 As TreeNode
        Dim Nodo3 As TreeNode

        Dim Aux1 As New Hashtable
        Dim Aux2 As New Hashtable

        Dim Dt2 As DataTable
        Dim Dt3 As DataTable

        Dim Dr2 As DataRow
        Dim Dr3 As DataRow

        Tree.BeginUpdate()
        Tree.Nodes.Clear()

        For Each Dr In Dt.Rows

            If Not Aux1.Contains(Dr(CampoID1)) Then
                Aux1.Add(Dr(CampoID1), Dr(CampoID1))

                Nodo = New TreeNode

                'agrega el padre
                Nodo.Text = Dr(Descripcion1) & IIf(MostrarID, " - " & Dr(CampoID1), "")
                Nodo.Tag = Dr(CampoID1)
                Nodo.ImageIndex = Imagen1
                Nodo.SelectedImageIndex = Imagen1

                'agrega los hijos
                Dt2 = FiltrarDT(Dt, CampoID1 & " = " & Dr(CampoID1))

                For Each Dr2 In Dt2.Rows

                    If Not Aux2.Contains(Dr2(CampoID2) & Dr2(CampoID1)) Then
                        Aux2.Add(Dr2(CampoID2) & Dr2(CampoID1), Dr2(CampoID2))

                        If Not IsDBNull(Dr2(CampoID2)) Then
                            Nodo2 = New TreeNode

                            Nodo2.Text = IIf(IsDBNull(Dr2(Descripcion2)), "", Dr2(Descripcion2))
                            Nodo2.Tag = IIf(IsDBNull(Dr2(CampoID2)), "", Dr2(CampoID2))
                            Nodo2.ImageIndex = Imagen2
                            Nodo2.SelectedImageIndex = Imagen2

                            'agrega los hijos
                            Dt3 = FiltrarDT(Dt2, CampoID2 & " = " & Dr2(CampoID2))

                            For Each Dr3 In Dt3.Rows
                                If Not IsDBNull(Dr3(CampoID3)) Then
                                    Nodo3 = New TreeNode

                                    Nodo3.Text = IIf(IsDBNull(Dr3(Descripcion3)), "", Dr3(Descripcion3))
                                    Nodo3.Tag = IIf(IsDBNull(Dr3(CampoID3)), "", Dr3(CampoID3))
                                    Nodo3.ImageIndex = Imagen3
                                    Nodo3.SelectedImageIndex = Imagen3

                                    Nodo2.Nodes.Add(Nodo3)
                                End If
                            Next

                            Nodo.Nodes.Add(Nodo2)
                        End If
                    End If

                Next

                'agrega el padre al tree
                Tree.Nodes.Add(Nodo)
            End If

        Next

        Tree.EndUpdate()
    End Sub
    Public Shared Sub CargarTree(ByVal Tree As TreeView, ByVal Dt As DataTable, ByVal CampoIDPadre As String, ByVal CampoPadre As String, ByVal CampoIDHijo As String, ByVal CampoHijo As String, Optional ByVal MostrarID As Boolean = False, Optional ByVal ImagenPadre As Integer = -1, Optional ByVal ImagenHijo As Integer = -1)
        'cagar un tree view con 2 niveles, padre hijo, haciendo un corte de control por el CampoIDPadre
        Dim Dr As DataRow
        Dim Nodo As TreeNode
        Dim NodoHijo As TreeNode

        Dim Aux As New Hashtable
        Dim DtHijo As DataTable
        Dim DrHijo As DataRow

        Tree.BeginUpdate()
        Tree.Nodes.Clear()

        For Each Dr In Dt.Rows

            If Not Aux.Contains(Dr(CampoIDPadre)) Then
                Aux.Add(Dr(CampoIDPadre), Dr(CampoIDPadre))

                Nodo = New TreeNode

                'agrega el padre
                Nodo.Text = Dr(CampoPadre) & IIf(MostrarID, " - " & Dr(CampoIDPadre), "")
                Nodo.Tag = Dr(CampoIDPadre)
                Nodo.ImageIndex = ImagenPadre
                Nodo.SelectedImageIndex = ImagenPadre

                'agrega los hijos
                DtHijo = FiltrarDT(Dt, CampoIDPadre & " = " & Dr(CampoIDPadre))

                For Each DrHijo In DtHijo.Rows
                    If Not IsDBNull(DrHijo(CampoIDHijo)) Then
                        NodoHijo = New TreeNode

                        NodoHijo.Text = IIf(IsDBNull(DrHijo(CampoHijo)), "", DrHijo(CampoHijo))
                        NodoHijo.Tag = IIf(IsDBNull(DrHijo(CampoIDHijo)), "", DrHijo(CampoIDHijo))
                        NodoHijo.ImageIndex = ImagenHijo
                        NodoHijo.SelectedImageIndex = ImagenHijo

                        Nodo.Nodes.Add(NodoHijo)
                    End If
                Next

                'agrega el padre al tree
                Tree.Nodes.Add(Nodo)
            End If

        Next

        Tree.EndUpdate()
    End Sub

    Public Shared Sub CargarList(ByVal Lista As ListBox, ByVal Dt As DataTable, ByVal CampoID As String, ByVal CampoDescripcion As String)
        Dim Dr As DataRow
        Dim Item As ItemLista

        Lista.BeginUpdate()

        Lista.Items.Clear()

        Lista.ValueMember = "ID"
        Lista.DisplayMember = "Descripcion"

        Try
            For Each Dr In Dt.Rows
                Item = New ItemLista

                Item.ID = IIf(IsDBNull(Dr(CampoID)), 0, Dr(CampoID))
                Item.Descripcion = IIf(IsDBNull(Dr(CampoDescripcion)), "", Dr(CampoDescripcion))

                Lista.Items.Add(Item)
            Next
        Catch ex As Exception
            Mensajes.Mensaje("No se Puede Cargar la Lista. El Campo No Existe en el DataTable", TipoMensaje.DeError)
        End Try

        Lista.EndUpdate()
    End Sub
    Public Shared Function FiltrarDT(ByVal Dt As DataTable, ByVal Filtro As String, Optional ByVal Orden As String = "asc", Optional ByVal SensibleMayusculas As Boolean = False) As DataTable
        'devuelve un data table filtrado y ordenado por los parametros que se pasan
        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()

        Dt.CaseSensitive = SensibleMayusculas
        Filas = Dt.Select(Filtro)

        For Each Dr As DataRow In Filas
            DtNuevo.ImportRow(Dr)
        Next

        Return DtNuevo
    End Function
    Public Shared Function OrdenarDT(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Orden As String) As DataTable
        'devuelve un data table filtrado y ordenado por los parametros que se pasan
        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()

        Filas = Dt.Select(Filtro, Orden)

        For Each Dr As DataRow In Filas
            DtNuevo.ImportRow(Dr)
        Next

        Return DtNuevo
    End Function

    Public Shared Function BorrarFilaDT(ByVal Dt As DataTable, ByVal Filtro As String) As Boolean
        Dim Dr As DataRow

        Try
            If Dt Is Nothing Then
                Return False
            End If
            Dr = Dt.Select(Filtro)(0)
        Catch ex As Exception
            Return False
        End Try

        If Dr Is Nothing Then
            Return False
        End If

        Dt.Rows.Remove(Dr)

        Return True
    End Function

    Public Shared Function BorrarItemList(ByVal Lista As ListBox, ByVal ValorID As Object) As Boolean
        Dim i As Integer

        For i = 0 To Lista.Items.Count - 1
            If DirectCast(Lista.Items(i), ItemLista).ID = ValorID Then
                Lista.Items.RemoveAt(i)
                Return True
            End If
        Next

        Return False
    End Function

    Public Shared Sub AplicarFormato(ByVal Grid As UltraGrid)
        'Aplica un formato Standard a los ultra grid
        With Grid.DisplayLayout.Override
            .AllowDelete = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupBy = Infragistics.Win.DefaultableBoolean.False
            .AllowGroupMoving = Infragistics.Win.UltraWinGrid.AllowGroupMoving.NotAllowed
            .AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
            .AllowUpdate = Infragistics.Win.DefaultableBoolean.False
            .SelectTypeCol = SelectType.None
            .AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
            .AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
            .CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        End With

        Grid.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns
    End Sub

    Public Shared Sub CambiarTituloColumna(ByVal Grid As UltraGrid, ByVal ColKey As String, ByVal Titulo As String)
        'cambia el titulo de una columna
        Grid.DisplayLayout.Bands(0).Columns(ColKey).Header.Caption = Titulo
    End Sub

    Public Shared Sub CambiarTituloColumna(ByVal Grid As UltraGrid, ByVal Indice As Int32, ByVal Titulo As String)
        Grid.DisplayLayout.Bands(0).Columns(Indice).Header.Caption = Titulo
    End Sub

    Public Function BuscarNodo(ByVal BuscarEn As TreeNodeCollection, ByVal NodoBuscado As TreeNode) As Integer
        Dim N As TreeNode

        For Each N In BuscarEn
            If N.Text = NodoBuscado.Text And N.Tag = NodoBuscado.Tag Then
                Return N.Index
            End If
        Next

        Return -1
    End Function

    Public Shared Sub OcultarHeader(ByVal Grid As UltraGrid, Optional ByVal Hijos As Boolean = True)
        Dim B As UltraGridBand

        For Each B In Grid.DisplayLayout.Bands()
            If Hijos Then
                If B.Index > 0 Then
                    B.ColHeadersVisible = False
                End If
            Else
                If B.Index = 0 Then
                    B.ColHeadersVisible = False
                End If

            End If
        Next
    End Sub

    Public Shared Function GetNombreSinBarras(ByVal p As String) As String
        Dim i As Integer
        i = InStr(p, "\")
        If i = 0 Then
            GetNombreSinBarras = Trim(p)
        Else
            GetNombreSinBarras = Trim(Mid(p, 1, i - 1))
        End If
    End Function

    Public Shared Function SumarHoras(ByVal pH As String, ByVal pS As String, ByVal pFormato As String) As String
        ' toma la hora como hhmm y le suma los segundos y devuelve la hora en hhmm
        Dim fecha As Date
        Dim segundos As Long
        Dim res As String

        ' llevo la hora a hhmmss
        If InStr(pH, ":") > 0 Then ' es h:mm:ss o hh:mm:ss o h:mm o hh:mm
            pH = Replace(pH, ":", "")
        End If

        If pH.Length >= 5 Then ' es hmmss o hhmmss
            pH = pH.PadRight(6, "0")
        Else 'es hmm o hhmm
            pH = pH.PadLeft(4, "0")
            pH = pH.PadRight(6, "0")
        End If

        If Mid(pH, 1, 2) >= 24 Then
            fecha = CDate(Trim(Str(Mid(pH, 1, 2) - 24)) & ":" & Mid(pH, 3, 2) & ":" & Mid(pH, 5, 2))
        Else
            fecha = CDate(Mid(pH, 1, 2) & ":" & Mid(pH, 3, 2) & ":" & Mid(pH, 5, 2))
        End If

        segundos = ConvMin2Seg(pS, pFormato)
        fecha = DateAdd(DateInterval.Second, segundos, fecha)
        res = Trim(Str(fecha.Hour)).PadLeft(2, "0") & Trim(Str(fecha.Minute)).PadLeft(2, "0") & Trim(Str(fecha.Second)).PadLeft(2, "0")
        If CDate(fecha.Hour & ":" & fecha.Minute) < CDate("06:00") Then
            res = Trim(Str(Val(Mid(res, 1, 2)) + 24)).PadLeft(2, "0") & Mid(res, 3, 2).PadLeft(2, "0") & Mid(res, 5, 2).PadLeft(2, "0")
        End If
        SumarHoras = res
    End Function

    Public Shared Function ConvMin2Seg(ByVal pmmmmss As String, ByVal pFormato As String) As Integer
        ' Convierte de hora minutos y segundos a segundos
        Dim ret As Integer
        Dim i As Integer
        Dim aux As Date
        Dim auxh As Integer

        ' llevo todo a mmss
        Select Case pFormato
            Case "mm:ss"
                pmmmmss = Replace(pmmmmss, ":", "")
            Case "mmss"
            Case "mmmm"
                pmmmmss = pmmmmss.PadRight(pmmmmss.Length + 2, "0")
            Case "hh:mm:ss"
                aux = CDate(pmmmmss)
                auxh = aux.Hour * 60
                pmmmmss = auxh & aux.Minute & aux.Second
            Case "hhmmss"
                pmmmmss = Mid(pmmmmss, 1, 2) & ":" & Mid(pmmmmss, 3, 2) & ":" & Mid(pmmmmss, 5, 2)
                aux = CDate(pmmmmss)
                auxh = aux.Hour * 60
                pmmmmss = auxh & aux.Minute & aux.Second
        End Select

        If pmmmmss.Length <= 2 Then ' ss o s
            ret = pmmmmss
        Else
            ret = Mid(pmmmmss, 1, pmmmmss.Length - 2) * 60 + Mid(pmmmmss, pmmmmss.Length - 1, 2)
            'ElseIf Len(pmmmmss) = 3 Then ' mss
            '    ret = Mid(pmmmmss, 1, 1) * 60 + Mid(pmmmmss, 2, 2)
            'ElseIf Len(pmmmmss) = 4 Then ' mmss
            '    ret = Mid(pmmmmss, 1, 2) * 60 + Mid(pmmmmss, 3, 2)
            'ElseIf Len(pmmmmss) = 5 Then ' mmmss
            '    ret = Mid(pmmmmss, 1, 3) * 60 + Mid(pmmmmss, 4, 2)
            'ElseIf Len(pmmmmss) = 6 Then ' hhmmss
            '    ret = Mid(pmmmmss, 1, 4) * 60 + Mid(pmmmmss, 5, 2)
        End If
        ConvMin2Seg = ret
    End Function

    Public Shared Function GetSemana(ByVal inDate As DateTime) As Integer
        Const JAN As Integer = 1
        Const DEC As Integer = 12
        Const LASTDAYOFDEC As Integer = 31
        Const FIRSTDAYOFJAN As Integer = 1
        Const THURSDAY As Integer = 4
        Dim ThursdayFlag As Boolean = False

        ' Get the day number since the beginning of the year
        Dim DayOfYear As Integer = inDate.DayOfYear

        ' Get the numeric weekday of the first day of the
        ' year (using sunday as FirstDay)
        Dim d As DateTime

        d = FIRSTDAYOFJAN & "/" & JAN & "/" & inDate.Year
        Dim StartWeekDayOfYear As Integer = d.DayOfWeek
        d = LASTDAYOFDEC & "/" & DEC & "/" & inDate.Year
        Dim EndWeekDayOfYear As Integer = d.DayOfWeek

        ' Compensate for the fact that we are using monday
        ' as the first day of the week
        If StartWeekDayOfYear = 0 Then
            StartWeekDayOfYear = 7
        End If
        If EndWeekDayOfYear = 0 Then
            EndWeekDayOfYear = 7
        End If

        ' Calculate the number of days in the first and last week
        Dim DaysInFirstWeek As Integer = 8 - StartWeekDayOfYear
        Dim DaysInLastWeek As Integer = 8 - EndWeekDayOfYear

        ' If the year either starts or ends on a thursday it will have a 53rd week
        If StartWeekDayOfYear = THURSDAY OrElse EndWeekDayOfYear = THURSDAY Then
            ThursdayFlag = True
        End If

        ' We begin by calculating the number of FULL weeks between the start of the year and
        ' our date. The number is rounded up, so the smallest possible value is 0.
        Dim FullWeeks As Integer = _
            CType(Math.Ceiling((DayOfYear - DaysInFirstWeek) / 7), Integer)

        Dim WeekNumber As Integer = FullWeeks

        ' If the first week of the year has at least four days, then the actual week number for our date
        ' can be incremented by one.
        If DaysInFirstWeek >= THURSDAY Then
            WeekNumber = WeekNumber + 1
        End If

        ' If week number is larger than week 52 (and the year doesn't either start or end on a thursday)
        ' then the correct week number is 1.
        If WeekNumber > 52 AndAlso Not ThursdayFlag Then
            WeekNumber = 1
        End If

        'If week number is still 0, it means that we are trying to evaluate the week number for a
        'week that belongs in the previous year (since that week has 3 days or less in our date's year).
        'We therefore make a recursive call using the last day of the previous year.
        If WeekNumber = 0 Then
            WeekNumber = GetSemana( _
                New DateTime(inDate.Year - 1, DEC, LASTDAYOFDEC))
        End If
        Return WeekNumber
    End Function
End Class

Public Class ItemLista
    Dim mID As Object
    Dim mDescripcion As String

    Public Property ID() As Object
        Get
            Return mID
        End Get
        Set(ByVal Value As Object)
            mID = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property
End Class


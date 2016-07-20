Imports System.IO
Public Class Cubo
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnColapsar As System.Windows.Forms.Button
    Friend WithEvents DCube1 As AxDynamiCubeLib.AxDCube
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Cubo))
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnColapsar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.DCube1 = New AxDynamiCubeLib.AxDCube
        Me.cmdActualizar = New System.Windows.Forms.Button
        CType(Me.DCube1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Location = New System.Drawing.Point(8, 400)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(64, 24)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Imprimir"
        '
        'btnColapsar
        '
        Me.btnColapsar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnColapsar.Location = New System.Drawing.Point(80, 400)
        Me.btnColapsar.Name = "btnColapsar"
        Me.btnColapsar.Size = New System.Drawing.Size(68, 24)
        Me.btnColapsar.TabIndex = 2
        Me.btnColapsar.Text = "Colapsar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(272, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exporta a Excel"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(376, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Exporta a Html"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(160, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ocultar Totales"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(632, 400)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 24)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'DCube1
        '
        Me.DCube1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DCube1.Enabled = True
        Me.DCube1.Location = New System.Drawing.Point(8, 8)
        Me.DCube1.Name = "DCube1"
        Me.DCube1.OcxState = CType(resources.GetObject("DCube1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DCube1.Size = New System.Drawing.Size(696, 384)
        Me.DCube1.TabIndex = 8
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.Location = New System.Drawing.Point(472, 400)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(88, 24)
        Me.cmdActualizar.TabIndex = 9
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.Visible = False
        '
        'Cubo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 429)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.DCube1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnColapsar)
        Me.Controls.Add(Me.btnPreview)
        Me.Name = "Cubo"
        Me.Text = "Cubo"
        CType(Me.DCube1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ' ----------------------------------------------------------------------------------------
    '         DS - Decision Support
    ' ----------------------------------------------------------------------------------------
    ' Para usar este Form debe pasar un recordset con los campos con la siguiente nomenclatura:
    ' Primero los campos Row (RN_), Column (CN_), Page (PN_), Data (DS_)
    ' Para los campos datas las opcines son:
    ' DS_ Para realizar sumatoria SUM
    ' DP_ Para realizar promedio AVG
    ' DC_ Para contar la cantidad de elemento COUNT
    ' DA_ Para buscar el Minimo MIN
    ' DZ_ Para buscar el Máximo MAX
    ' ----------------------------------------------------------------------------------------
    Dim Ruta As String = "C:\Archivos de Programa\MPG\Quetool\Perfiles\"
    Dim dtCub As New DataTable
    Dim rowArray(100) As Object
    'Dim aColWidth() As Object

    Dim mvarTitulo As String
    Dim mvarNombre As String
    Dim mvarModo As DC.eDCModo
    Dim PATH_PERFILES As String
    Dim HOME_FILE As String
    Dim cHelpFile As String
    Dim b As Boolean = False
    Dim c As Boolean = False
    Dim Grilladmin As New Grilladmin
    Shared mInstancia As Cubo
    Dim Cargo As Boolean = False
    Dim mSpot As DataTable
    Dim mDetalle As DataTable
    Dim mFranja As DataTable
    Dim mSoporte As DataTable
    '  Public Delegate Sub fActualizarDatos()
    ' Public ActualizarDatos As fActualizarDatos


    Public Event Actualizar(ByRef DtSpot As DataTable, ByRef DtDetalle As DataTable, ByRef dtFranja As DataTable, ByRef dtSoporte As DataTable)
    Public Event Cerrando()




    Public Shared Property Instancia() As Cubo
        Get
            If mInstancia Is Nothing Then
                mInstancia = New Cubo
            End If

            Return mInstancia
        End Get
        Set(ByVal Value As Cubo)
            mInstancia = Value
        End Set
    End Property
    'Dim m_HtmlHelp As cHtmlHelp 'Clase para mostrar la ayuda HTML

    Public Property Titulo()
        Get
            Titulo = mvarTitulo
        End Get
        Set(ByVal Value)
            mvarTitulo = Value
        End Set

    End Property
    Public Property Nombre()
        Get
            Nombre = mvarNombre
        End Get
        Set(ByVal Value)
            mvarNombre = Value
        End Set
    End Property
    Public Property Modo()
        Get
            Modo = mvarModo
        End Get
        Set(ByVal Value)
            mvarModo = Value
        End Set
    End Property
    Public Property DataTableCub()
        Get
            DataTableCub = dtCub
        End Get
        Set(ByVal Value)
            dtCub = Value
        End Set
    End Property


    Function GetCurrDataField(ByVal Cub As DynamiCubeLib.DCube) As Integer
        ' Trae el numero de columna seleccionado de la seccion DATA
        Dim i, j As Integer
        Dim iFlds As Integer

        iFlds = 0
        For i = 0 To (Cub.DataFields.Count - 1)
            If Cub.DataFields.Item(i).Visible Then iFlds = iFlds + 1
        Next

        i = Cub.SelStartCol Mod iFlds
        For j = 0 To Cub.DataFields.Count - 1
            If Cub.DataFields.Item(j).Visible And i = 0 Then
                GetCurrDataField = j
                Exit Function
            End If
            i = i - 1
        Next
    End Function
    Private Function GetCurrColField(ByVal DC As DynamiCubeLib.DCube)
        Dim i As Integer

        For i = 0 To DC.Fields.Count - 1
            If DC.Fields.Item(i).Orientation = DynamiCubeLib.OrientationConstants.DCRow Then
                If DC.Fields.Item(i).Position = 0 Then
                    GetCurrColField = i
                End If
            End If
        Next i
    End Function
    'Private Function bCanCheck() As Boolean
    '    ' Evalua si queda mas de 1 boton para desmarcar, si queda solo uno, no te deja desmarcarlo
    '    Dim i, j As Integer

    '    j = 0
    '    For i = 0 To abLeft.Bands("BandaDinamica").Tools.Count - 1
    '        If abLeft.Bands("BandaDinamica").Tools(i).Checked Then
    '            j = j + 1
    '        End If
    '    Next i
    '    bCanCheck = (j > 1)

    'End Function

    'Private Sub abLeft_ComboSelChange(ByVal Tool As ActiveBar2LibraryCtl.Tool)
    '    ' Funcionalidad de la barra de abajo. Combo de formato de columna
    '    Dim i As Integer

    '    If Tool.Name = "cboFormato" Then
    '        ' por las dudas si pongo otro cbo
    '        i = GetCurrDataField(DCube1)
    '        DCube1.DataFields(i).NumberFormat = Tool.Text
    '    End If
    'End Sub

    'Private Sub abLeft_TextChange(ByVal Tool As ActiveBar2LibraryCtl.Tool)
    '    ' Funcionalidad de la barra de abajo. Si se pone a mano el formato en la barra de abajo
    '    If Tool.Name = "cboFormato" Then
    '        DCube1.DataFields(GetCurrDataField(DCube1)).NumberFormat = Tool.Text
    '    End If
    'End Sub

    'Private Sub ableft_ToolClick(ByVal Tool As ActiveBar2LibraryCtl.Tool)
    '    ' Funcionalidad de los botones de la Barra
    '    Dim looper As Integer
    '    Dim i As Integer
    '    Dim aAux() As Object

    '    Select Case Tool.Category
    '        Case "Banda"
    '            ' Funcionalidad de la barra dinámica de la izquierda
    '            Select Case Tool.Name
    '                Case "Home"
    '                    VolverHome()

    '                Case "Marcador"
    '                    ShowDataMarkerForm()

    '                Case "Colapsador"
    '                    If Tool.Checked Then
    '                        Tool.Checked = False
    '                        Colapsar(True)
    '                    Else
    '                        Tool.Checked = True
    '                        Colapsar(False)
    '                    End If

    '                Case "SeriesC"
    '                    aAux = GetMatrizDatos(DCube1, True)
    '                    frmTeeChart.aDatos = aAux
    '                    frmTeeChart.Show()

    '                Case "SeriesF"
    '                    aAux = GetMatrizDatos(DCube1, False)
    '                    frmTeeChart.aDatos = aAux
    '                    frmTeeChart.Show()

    '                Case "Ascendente"
    '                    DCube1.Fields.Item(GetCurrColField(DCube1)).RankOn = GetCurrDataField(DCube1)
    '                    DCube1.Fields.Item(GetCurrColField(DCube1)).RankStyle = 2
    '                    DoEvents()
    '                    Colapsar(False)

    '                Case "Descendente"
    '                    DCube1.Fields.Item(GetCurrColField(DCube1)).RankOn = GetCurrDataField(DCube1)
    '                    DCube1.Fields.Item(GetCurrColField(DCube1)).RankStyle = 1
    '                    DoEvents()
    '                    Colapsar(False)

    '                Case "Buscar"
    '                    Dim frmDC_Buscar As New frmDC_Buscar

    '                    frmDC_Buscar.Cubo = DCube1
    '                    frmDC_Buscar.Show(1)

    '                    Unload(frmDC_Buscar)
    '                    frmDC_Buscar = Nothing

    '                Case "PrintPreview"
    '                    DCube1.PrintPreview()

    '                Case "Word"
    '                    Exportar2Txt()

    '                Case "Excel"
    '                    Screen.MousePointer = vbHourglass
    '                    ExportToExcel(DCube1)
    '                    MsgBox("Finalizó la exportación", vbInformation, App.Title)
    '                    Screen.MousePointer = vbDefault
    '                Case "ExcelFormato"
    '                    Screen.MousePointer = vbHourglass
    '                    ExportToExcelFormato(DCube1)
    '                    MsgBox("Finalizó la exportación", vbInformation, App.Title)
    '                    Screen.MousePointer = vbDefault
    '                Case "HTML"
    '                    Exportar2HTML()

    '                Case "TablaDin"
    '                    If dtCub.State = adStateOpen Then
    '                        PasarRecordsetAPivotTable(dtCub, "Título", DCube1, True, True)
    '                    End If

    '                Case "Tabla"
    '                    If dtCub.State = adStateOpen Then
    '                        Exportar2ExcelPlano()
    '                    End If

    '                Case "CargaInfo"
    '                    Cargar_Info()

    '                Case "GuardaInfo"
    '                    Salvar_Info()

    '                Case "Perfiles"
    '                    Dim frm As New frmDC_GrillaPerfiles

    '                    frm.Nombre = mvarNombre
    '                    frm.dcCubo = DCube1
    '                    frm.aColWidth = aColWidth
    '                    frm.PATH_PERFILES = PATH_PERFILES
    '                    frm.Show(1)
    '                    If frm.pDataPath <> "" Then
    '                        DCube1.Load(frm.pDataPath)
    '                        aColWidth = frm.aColWidth
    '                        SetUpBottomFromFile()
    '                        DoEvents()
    '                    End If
    '                    Unload(frm)
    '                    frm = Nothing

    '                Case "Salir"
    '                    Unload(Me)
    '                    Exit Sub
    '                Case "btnVer"
    '                    If DCube1.Visible Then
    '                        DCube1.Visible = False
    '                        Graf.Visible = True
    '                        TC.Chart = Graf
    '                        abLeft.Bands("Banda").ChildBands("Babyband").Tools("btnVer").ToolTipText = "Ver los datos"
    '                        CargarDatosAlGrafico()
    '                    Else
    '                        DCube1.Visible = True
    '                        Graf.Visible = False
    '                        abLeft.Bands("Banda").ChildBands("Babyband").Tools("btnVer").ToolTipText = "Ver el gráfico"
    '                    End If
    '            End Select

    '        Case "BandaDinamica"
    '            ' Funcionalidad de la barra dinámica de abajo
    '            If Tool.Checked Then
    '                If bCanCheck() Then
    '                    Tool.Checked = False
    '                    DCube1.DataFields(Tool.Name).Visible = False
    '                    Tool.SetPicture(0, ImageList1.ListImages(2).Picture, &HF)
    '                Else
    '                    MsgBox("No puede ocultar todas las columnas", vbInformation, App.Title)
    '                End If
    '            Else
    '                Tool.Checked = True
    '                DCube1.DataFields(Tool.Name).Visible = True
    '                Tool.SetPicture(0, ImageList1.ListImages(1).Picture, &HF)
    '            End If
    '        Case "BandaFormato"
    '            ' Funcionalidad de la barra de formato de abajo
    '            Select Case Tool.Name
    '                Case "btnNormal"
    '                    i = GetCurrDataField(DCube1)
    '                    DCube1.DataFields(i).DisplayAs = DCDTNormal
    '                    'DCube1.DataFields(i).NumberFormat = gFormatoPorcentaje
    '                    DCube1.Refresh()
    '                Case "btnXRow"
    '                    i = GetCurrDataField(DCube1)
    '                    DCube1.DataFields(i).DisplayAs = 1
    '                    DCube1.DataFields(i).NumberFormat = "% #0.00"
    '                    DCube1.Refresh()
    '                Case "btnXCol"
    '                    i = GetCurrDataField(DCube1)
    '                    DCube1.DataFields(i).DisplayAs = 2
    '                    DCube1.DataFields(i).NumberFormat = "% #0.00"
    '                    DCube1.Refresh()
    '                Case "btnCamposCalculados"
    '                    frmDC_CamposCalculados.pDC = DCube1
    '                    frmDC_CamposCalculados.Show(vbModal)
    '                    ActualizaCubo()

    '                Case "btnTotal"
    '                    If Tool.Checked Then
    '                        Tool.Checked = False
    '                        Tool.SetPicture(0, ImageList1.ListImages(2).Picture, &HF)
    '                        For i = 0 To DCube1.Fields.Count - 1
    '                            If DCube1.Fields(i).Orientation <> DCData Then
    '                                DCube1.Fields(i).GroupFooterType = DCFNone
    '                            End If
    '                        Next i
    '                    Else
    '                        Tool.Checked = True
    '                        Tool.SetPicture(0, ImageList1.ListImages(1).Picture, &HF)
    '                        For i = 0 To DCube1.Fields.Count - 1
    '                            If DCube1.Fields(i).Orientation <> DCData Then
    '                                DCube1.Fields(i).GroupFooterType = DCFSum
    '                            End If
    '                        Next i
    '                    End If
    '            End Select
    '    End Select

    '    ActualizaColumnas()
    'End Sub

    Private Sub ActualizaCubo()
        'ReDim Preserve aColWidth(DCube1.Fields.Count) ' preparo el vector del ancho de las columnas.
        'SetUpBottomFromFile()
    End Sub
    Private Sub Form_Activate()
        ' Si dio error la carga de datos, el cubo no esta visible, como no puedo cerrarlo en el load lo cierro
        ' aca
        If (Not DCube1.Visible) Then
            Me.Close()
        End If
    End Sub
    Private Sub Borrar()

    End Sub
    Private Function SetUpCube() As Boolean
        Dim field As DynamiCubeLib.Field
        Dim i As Integer
        Dim j As Integer

        DCube1.HeaderCaption = mvarTitulo
        DCube1.AutoDataRefresh = False
        DCube1.DCConnectType = DynamiCubeLib.DCConnectTypes.DCCT_UNBOUND  ' setea el tipo de conexion a una base de datos
        If Not dtCub Is Nothing Then
            For i = 0 To dtCub.Columns.Count - 1  ' Recorro los campos del recordset
                If DC.DC_Position(dtCub.Columns(i).Caption) <> DynamiCubeLib.OrientationConstants.DCHidden Then  ' Si no esta oculto, lo agrego en la posicion que corresponde al nombre
                    field = DCube1.Fields.Add(dtCub.Columns.Item(i).Caption, DC.DC_Name(dtCub.Columns(i).Caption), DC.DC_Position(dtCub.Columns(i).Caption))
                    If DC.DC_Function(dtCub.Columns(i).Caption) <> 255 Then  ' me fijo si es un campo calculado
                        field.AggregateFunc = DC.DC_Function(dtCub.Columns(i).Caption)
                    End If
                End If
            Next i
            DCube1.RefreshData()
            DCube1.AutoDataRefresh = True

            'ReDim Preserve aColWidth(DCube1.Fields.Count) ' preparo el vector del ancho de las columnas.

            ' busca si existe un perfil predeterminado del cubo para la consulta actual (mvarnombre).
            If GetSetting(Me.Text, "Perfiles", mvarNombre, "") <> "" Then
                If File.Exists(PATH_PERFILES + "\" + GetSetting(Me.Text, "Perfiles", mvarNombre, "")) Then
                    DCube1.Load(PATH_PERFILES + "\" + GetSetting(Me.Text, "Perfiles", mvarNombre, ""))
                    'CargarPerfil(PATH_PERFILES + "\" + GetSetting(App.Title, "Perfiles", mvarNombre, ""), aColWidth)
                    ActualizaColumnas()
                Else
                    'For Each field In DCube1.Fields
                    '    aColWidth(j) = field.Width ' cargo el ancho inicial de las columnas.
                    'Next field
                End If
            Else
                'For Each field In DCube1.Fields
                '    aColWidth(j) = field.Width ' cargo el ancho inicial de las columnas.
                'Next field
            End If
            SetUpCube = True
        Else
            MsgBox("Error en la carga de los parámetros.", MsgBoxStyle.Information, Me.Text)
            SetUpCube = False
        End If
    End Function

    Private Sub FetchRow(ByVal colpos)
        ' Creo la fila del cubo.
        Dim i As DynamiCubeLib.Field
        Dim j As Integer
        Dim maxj As Integer
        Dim ultimaO As Integer
        Dim f As Integer
        j = 0
        maxj = 0
        ultimaO = DynamiCubeLib.OrientationConstants.DCRow
        ' Agrego todos los valores de los campos que pertenecen a las row y que no sean ocultos.
        For Each i In DCube1.Fields
            If DCube1.Fields.Item(f).Orientation <> DynamiCubeLib.OrientationConstants.DCHidden Then
                If i.Orientation = DynamiCubeLib.OrientationConstants.DCRow Then
                    rowArray(maxj + i.Position) = dtCub.Rows(colpos).Item(i.Name)
                    j = j + 1
                End If
            End If
        Next i

        maxj = maxj + j
        ' Agrego todos los valores de los campos que pertenecen a las Column y que no sean ocultos.
        j = 0
        For Each i In DCube1.Fields
            If i.Orientation <> DynamiCubeLib.OrientationConstants.DCHidden Then
                If i.Orientation = DynamiCubeLib.OrientationConstants.DCColumn Then
                    rowArray(maxj + i.Position) = dtCub.Rows(colpos).Item(i.Name)
                    j = j + 1
                End If
            End If
        Next i

        maxj = maxj + j
        ' Agrego todos los valores de los campos que pertenecen al Page y que no sean ocultos.
        j = 0
        For Each i In DCube1.Fields
            If i.Orientation <> DynamiCubeLib.OrientationConstants.DCHidden Then
                If i.Orientation = DynamiCubeLib.OrientationConstants.DCPage Then
                    rowArray(maxj + i.Position) = dtCub.Rows(colpos).Item(i.Name)
                    j = j + 1
                End If
            End If
        Next i
        maxj = maxj + j
        ' Agrego todos los valores de los campos que sean Data y que no sean ocultos.
        j = 0
        For Each i In DCube1.Fields
            If (i.Orientation <> DynamiCubeLib.OrientationConstants.DCHidden) And (Not i.Calculated) Then  ' pregunto si no es calculado ni oculto
                If i.Orientation = DynamiCubeLib.OrientationConstants.DCData Then
                    rowArray(maxj + i.Position) = Decimal.Round(dtCub.Rows(colpos).Item(i.Name), 2)
                    ' le cargo como formato inicial el 99,999.99
                    'i.NumberFormat = "#,##0.00"
                    j = j + 1
                End If
            End If
        Next i

    End Sub
    'Private Sub Form_Resize()
    '    On Error Resume Next

    '    abLeft.Move(0, 0, ScaleWidth, ScaleHeight - 20)
    '    Graf.Move(abLeft.Bands("Banda").Width, TC.Height, ScaleWidth - abLeft.Bands("Banda").Width, ScaleHeight - (abLeft.Bands("BandaFormato").Height + TC.Height + 90))
    '    DCube1.Move(abLeft.Bands("Banda").Width, 0, ScaleWidth - abLeft.Bands("Banda").Width, ScaleHeight - (abLeft.Bands("BandaFormato").Height + 90))
    'End Sub
    'Private Sub SetUpBottomFromFile()
    '    ' Creo los botones de la barra dinamica con los campos de la seccion de datos.
    '    Dim i As Integer
    '    Dim Tool As ActiveBar2LibraryCtl.Tool

    '    'borro los botones que hay en la barra
    '    abLeft.Bands("BandaDinamica").Tools.RemoveAll()

    '    For i = 0 To DCube1.Fields.Count - 1
    '        If DCube1.Fields(i).Orientation = DCData Then
    '            'Comun a todos los botones
    '            Tool = abLeft.Bands("BandaDinamica").Tools.Add(GetUniqueToolID, DCube1.Fields(i).Name)
    '            Tool.ControlType = ddTTButton
    '            Tool.Style = ddSIconText
    '            'Tool.Caption = DC_Name(DCube1.Fields(i).Name)
    '            Tool.Caption = DCube1.Fields(i).Caption
    '            Tool.ImageHeight = 250
    '            Tool.ImageWidth = 250
    '            Tool.Category = "BandaDinamica"
    '            Tool.Checked = DCube1.Fields(i).Visible
    '            If DCube1.Fields(i).Visible Then
    '                Tool.SetPicture(0, ImageList1.ListImages(1).Picture, &HF)
    '            Else
    '                Tool.SetPicture(0, ImageList1.ListImages(2).Picture, &HF)
    '            End If
    '        End If
    '    Next i

    '    abLeft.RecalcLayout()
    '    abLeft.Bands("BandaFormato").Tools("btnTotal").Checked = True

    'End Sub
    'Public Sub ShowDataMarkerForm()
    '    On Error GoTo eh_ShowDataMarkerForm

    '    Load(frmDC_DataMarker)

    '    ' retrieves selected value from DynamiCube
    '    Dim dSelVal As Double
    '    With Me.DCube1
    '        dSelVal = .DataValue(.SelStartRow, .SelStartCol)
    '    End With

    '    frmDC_DataMarker.ShowDataMarker(0, dSelVal)

    '    Unload(frmDC_DataMarker)
    '    Me.DCube1.Refresh()

    'End Sub
    Private Sub miSaveToCub_Click()
        ' This procedure is used to save the DynamiCube file to
        ' the DynamiCube format that can subsequently be loaded
        ' using the .Load method or the .DataPath property.
        ' (DataPath is for asynch / Internet use)
        Dim sfilename As String
        Dim bReturn As Boolean
        Dim CD As New SaveFileDialog

        ' Setup Common Dialog
        CD.FileName = Application.StartupPath + "\DynamiCube File.cub"
        CD.Title = "Save microCube - Data Dynamics"
        CD.DefaultExt = "*.cub"
        CD.Filter = "microCube (*.cub)|*.cub"
        CD.ShowDialog()

        sfilename = CD.FileName

        If "" = Trim(sfilename) Then
            MsgBox("Debe especificar un nombre para el archivo.")

        End If

        Cursor.Current = Cursors.WaitCursor
        ' Tell DCube to save
        bReturn = Me.DCube1.Save(sfilename, 3)

        ' Check for unexpected error
        If Not bReturn Then
            MsgBox("Error inesperado al guardar archivo", MsgBoxStyle.Critical)
        End If
        Cursor.Current = Cursors.Default
    End Sub
    'Private Sub Cargar_Info()
    '    ' This procedure is used to load the DynamiCube file
    '    ' from disk.  The Files can be saved with the .Save method.
    '    ' You can use the .Load method or the .DataPath property.
    '    ' DataPath is for asynch / Internet use, Load is for local file.
    '    Dim sfilename As String
    '    Dim bReturn As Boolean
    '    Dim CD As OpenFileDialog


    '    ' Setup Common Dialog
    '    CD.InitialDirectory = App.Path
    '    CD.Title = "Abrir Cubo"
    '    CD.DefaultExt = "*.cub"
    '    CD.Filter = "Cubo (*.cub)|*.cub"
    '    CD.ShowDialog()
    '    sfilename = CD.FileName

    '    ' Validate filename
    '    If "" = Trim(sfilename) Then
    '        MsgBox("Debe especificar un archivo de cubo para cargar.")
    '    End If


    '    dtCub.Open(Mid(sfilename, 1, Len(sfilename) - 4) + ".rs", , adOpenKeyset, adLockOptimistic, adCmdFile)

    '    ShowDCForm(True, sfilename)
    '    ReDim Preserve aColWidth(DCube1.Fields.Count)
    '    SetUpBottomFromFile()
    'End Sub
    'Private Sub Salvar_Info()
    '    ' This procedure is used to save the DynamiCube file to
    '    ' the DynamiCube format that can subsequently be loaded
    '    ' using the .Load method or the .DataPath property.
    '    ' (DataPath is for asynch / Internet use)
    '    Dim sfilename As String
    '    Dim bReturn As Boolean
    '    Dim CD As SaveFileDialog

    '    ' Setup Common Dialog
    '    CD.FileName = App.Path + "\DynamiCube File.cub"
    '    CD.Title = "Save microCube - Data Dynamics"
    '    CD.DefaultExt = "*.cub"
    '    CD.Filter = "microCube (*.cub)|*.cub"
    '    CD.ShowDialog()
    '    sfilename = CD.FileName

    '    If "" = Trim(sfilename) Then
    '        MsgBox("You must specify a file name to save a microCube.")
    '    End If

    '    ' Tell DCube to save
    '    bReturn = Me.DCube1.Save(sfilename, 3)

    '    ' Check for unexpected error
    '    If Not bReturn Then
    '        MsgBox("Unexpected Error Saving microCube !", vbCritical)
    '    End If
    '    dtCub.save(Mid(sfilename, 1, Len(sfilename) - 4) + ".rs")

    'End Sub
    'Private Sub Exportar2Txt()
    '    ' Exporta la informacion mostrada en el cubo a un archivo del tipo texto.
    '    Dim sfilename As String
    '    Dim bReturn As Boolean
    '    Dim CD As New SaveFileDialog

    '    ' Setup Common Dialog
    '    CD.FileName = App.Path
    '    CD.Title = "Save Text"
    '    CD.FileName = "texto"
    '    CD.DefaultExt = "*.txt"
    '    CD.Filter = "Texto (*.txt)|*.txt"
    '    CD.ShowDialog()
    '    sfilename = CD.FileName

    '    If "" = Trim(sfilename) Then
    '        MsgBox("You must specify a file name to save a texto.")
    '    End If

    '    Cursor.Current = Cursors.WaitCursor
    '    ' Tell DCube to save
    '    ExportToText(DCube1, sfilename)
    '    Cursor.Current = Cursors.Default
    'End Sub

    'Public Sub ShowDCForm(Optional ByVal bIsDataFromMicroCube = False, Optional ByVal sMicroCubePath As String = "")
    '    ' Carga los datos del archivo que vienen en sMicroCubePath

    '    Me.DCube1.DataPath = sMicroCubePath
    '    Me.DCube1.Refresh()
    '    Me.DCube1.CurrentCell = "0, 0"
    '    ' Para forzar a que haga los cambios
    '    Application.DoEvents()
    '    Me.Show()

    'End Sub
    'Private Sub SetUpableft()
    '    ' Setea los botones de la barra de abajo.

    '    Dim i As Integer
    '    Dim Tool As ActiveBar2LibraryCtl.Tool

    '    For i = 0 To dtCub.Fields.Count - 1
    '        If DC_Position(dtCub.Fields(i).Name) = DCData Then
    '            'Comun a todos los botones
    '            Tool = abLeft.Bands("BandaDinamica").Tools.Add(GetUniqueToolID, dtCub.Fields(i).Name)
    '            Tool.ControlType = ddTTButton
    '            Tool.Style = ddSIconText
    '            Tool.Caption = DC_Name(dtCub.Fields(i).Name)
    '            Tool.ImageHeight = 250
    '            Tool.ImageWidth = 250
    '            Tool.Category = "BandaDinamica"
    '            Tool.Checked = True
    '            Tool.SetPicture(0, ImageList1.ListImages(1).Picture, &HF)
    '        End If
    '    Next i

    '    abLeft.Bands("BandaFormato").Tools("btnTotal").Checked = True
    'End Sub
    'Function GetUniqueToolID()
    '    ' Obtiene el proximo id libre en la banda que se le pasa por parametro
    '    GetUniqueToolID = abLeft.Tools.Count + abLeft.Bands("BandaDinamica").Tools.Count + 1
    'End Function

    Private Sub Form_Unload(ByVal Cancel As Integer)
        'elimino los archivos temporales y los vectores de colores

        ReDim DC.gaRanges(1)
        DC.giRanges = 0
        'If File.Exists(HOME_FILE + ".cub") Then
        '    File.Delete(HOME_FILE + ".cub")
        'End If
        'If File.Exists(HOME_FILE + ".cfg") Then
        '    File.Delete(HOME_FILE + ".cfg")
        'End If
        mvarModo = DC.eDCModo.Datos  ' lo pongo asi para que quede por default para la proxima llamada

    End Sub

    Private Sub ActualizaColumnas()
        Dim j As Integer
        Dim field As DynamiCubeLib.Field
        j = 0
        'For Each field In DCube1.Fields
        '    field.Width = aColWidth(j)
        '    j = j + 1
        'Next field
    End Sub

    'Private Sub VolverHome()
    '    ' Levanta la configuracion inicial del cubo guardada en el archivo home_file al hacer el load del form
    '    DCube1.Load(HOME_FILE + ".cub")
    '    CargarHome()
    '    SetUpBottomFromFile()
    'End Sub

    'Private Sub CargarHome()
    '    ' Levanta desde un archivo de configuraciones los colores y los tamanios de las columnas del cubo.
    '    ' El archivo tiene extension cfg y lleva el mismo nombre del archivo .cub que genera el cubo con el
    '    ' comando save
    '    Dim arc As TextReader
    '    Dim linea As String
    '    Dim i As Integer


    '    arc = File.OpenText(HOME_FILE + ".cfg")
    '    linea = arc.ReadLine
    '    If linea = "[ColWidth]" Then ' son tags dentro del archivo cfg
    '        linea = arc.ReadLine
    '        i = 0
    '        Do
    '            aColWidth(i) = Val(linea)
    '            linea = arc.ReadLine
    '            i = i + 1
    '        Loop Until linea Is Nothing And (linea <> "[Color]") ' son tags dentro del archivo cfg

    '        i = 0
    '        If Not linea Is Nothing Then
    '            ReDim gaRanges(1)
    '            linea = arc.ReadLine
    '            Do
    '                ReDim Preserve gaRanges(i + 1)
    '                gaRanges(i).dStart = linea
    '                linea = arc.ReadLine
    '                gaRanges(i).dEnd = linea
    '                linea = arc.ReadLine
    '                gaRanges(i).lColor = linea
    '                If Not arc.AtEndOfStream Then
    '                    linea = arc.ReadLine
    '                End If
    '                i = i + 1
    '            Loop Until linea Is Nothing
    '            giRanges = i
    '        Else
    '            giRanges = 0
    '            ReDim gaRanges(1)
    '        End If
    '    Else
    '        MsgBox("El archivo de configuraciones del cubo esta corrupto, no se puede abrir", vbExclamation, "Atención")
    '    End If

    'End Sub

    'Private Sub GuardarHome()
    '    ' guarda el archivo de configuracion del cubo en el estado actual.
    '    Dim fso As New File
    '    Dim s As TextWriter
    '    Dim i As Integer

    '    s = fso.CreateText(HOME_FILE + ".cfg")
    '    s.WriteLine("[ColWidth]")
    '    For i = 0 To UBound(aColWidth) - 1
    '        s.WriteLine(aColWidth(i))
    '    Next i
    '    If giRanges <> 0 Then
    '        s.WriteLine("[Color]")
    '        For i = 0 To UBound(gaRanges)
    '            s.WriteLine(gaRanges(i).dStart)
    '            s.WriteLine(gaRanges(i).dEnd)
    '            s.WriteLine(gaRanges(i).lColor)
    '        Next i
    '    End If
    '    s.Close()

    'End Sub

    'Public Sub Exportar2ExcelPlano()
    '    Dim rs As New DataTable
    '    Dim sqlString As String
    '    Dim consultaExcel As String
    '    Dim pFile As String
    '    Dim oDB As New clsAdoTools
    '    Dim fso As New File

    '    If UCase(Left(dtCub.source, 6)) <> "SELECT" Then ' Viene de un SP (sin string del SQL)
    '        sqlString = DataFilter(DCube1)
    '        consultaExcel = "Consulta"
    '        Randomize() ' Inicializa el generador de números aleatorios.
    '        pFile = App.Path + "\temp\flb" + Trim(Str(Int((10000 * Rnd()) + 1))) + ".xls"
    '        GuardarRsAsExcel(dtCub, consultaExcel, pFile)
    '        'abro el excel
    '        If oDB.Conectar(pFile, , , , , dbExcel, "Excel 8.0") < 0 Then
    '            oDB = Nothing
    '            Exit Sub
    '        End If

    '        'lo paso a un rs
    '        If sqlString = "" Then
    '            rs = oDB.ConsultarSQL("SELECT * FROM " + consultaExcel)
    '        Else
    '            rs = oDB.ConsultarSQL("SELECT * FROM " + consultaExcel + " where " + sqlString)
    '        End If

    '        'lo desconecto
    '        rs.ActiveConnection = Nothing
    '        oDB.Desconectar()

    '        PasarRecordsetAExcel(rs, "", True, True)
    '        rs = Nothing
    '        oDB = Nothing
    '        fso.DeleteFile(pFile)
    '    Else ' Viene con un string de SQL
    '        If dtCub.State = adStateOpen Then
    '            ' Saco si tiene cargado un filtro el cubo
    '            sqlString = DataFilter(DCube1)
    '            If sqlString = "" Then
    '                rs = EjecutarConsulta(dtCub.Source)
    '            Else
    '                rs = EjecutarConsulta("SELECT * FROM (" + dtCub.Source + ") where " + sqlString)
    '            End If
    '            'lo desconecto
    '            rs.ActiveConnection = Nothing

    '            PasarRecordsetAExcel(dtCub, "", True, True)
    '        Else
    '            MsgBox("Esta opción no esta habilitada para el tipo de consulta", vbInformation, App.Title)
    '        End If

    '        rs = Nothing
    '    End If
    'End Sub
    Private Sub DCube1_Error(ByVal sender As System.Object, ByVal e As AxDynamiCubeLib.IDCubeEvents_ErrorEvent)
        e.cancelDisplay.Value = True
    End Sub
    Public Sub Cargar()
        Dim i As Integer
        'ReDim aColWidth(500)
        Dim m As New System.Windows.Forms.Message
        m.Msg = 123

        'DCube1.Fields.DeleteAll()


        'For i = 0 To 500 ' Inicializo las columnas
        '    aColWidth(i) = 1000
        'Next i

        If Not Directory.Exists(Application.StartupPath + "\perfiles") Then
            Directory.CreateDirectory(Application.StartupPath + "\perfiles")
        End If
        If Not Directory.Exists(Application.StartupPath + "\temp") Then
            Directory.CreateDirectory(Application.StartupPath + "\temp")
        End If

        PATH_PERFILES = Application.StartupPath + "\perfiles"
        Randomize()   ' Inicializa el generador de números aleatorios.
        ' crea un archivo temporal para guardar el Home
        HOME_FILE = Application.StartupPath + "\temp\flb" + Trim(Str(Int((10000 * Rnd()) + 1)))

        Me.Text = mvarTitulo
        ' Cargo el cubo
        If Not dtCub Is Nothing Then
            If SetUpCube() Then
                ' Seteo los botones de la barra de abajo
                'SetUpableft()
                DCube1.Visible = True

                Select Case Me.Nombre
                    Case "CuboInversionExt"
                        DCube1.Fields.Item("RN_PLAZA").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_PLAZA").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("RN_TIPO_SOPORTE").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_TIPO_SOPORTE").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("RN_SOPORTE").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_SOPORTE").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("DS_SOI").DisplayAs = DynamiCubeLib.DisplayTypes.DCDTPercentCol
                        DCube1.Fields.Item("DS_SOI").NumberFormat = "##0.00 %"

                        'Dim x As DynamiCubeLib.Field

                        'x = DCube1.Fields.Add("sumDS_SOI", "santiago", DynamiCubeLib.OrientationConstants.DCData)
                        'x.Calculated = True
                        'x.AggregateFunc = DynamiCubeLib.AggregateFunctions.DCSum
                        'x.GroupFooterType("santiago") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        'x.Visible = True
                        'x.Position = DCube1.DataFields.Count
                        DCube1.RefreshData()
                    Case "CuboInversion"
                        DCube1.Fields.Item("DS_SOI").DisplayAs = DynamiCubeLib.DisplayTypes.DCDTPercentCol
                        DCube1.Fields.Item("DS_SOI").NumberFormat = "##0.00 %"

                End Select
                DCube1.RecalcData()
                'GuardarHome()
                'DCube1.Save(HOME_FILE + ".cub", 1)
            Else
                DCube1.Visible = False
            End If
        End If

        'If mvarModo = Graficos Then
        '    DCube1.Visible = False
        'End If
        Me.Cargo = True
    End Sub
    Private Sub Cubo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Cargo Then
            Exit Sub
        End If

        Dim i As Integer
        'ReDim aColWidth(500)
        Dim m As New System.Windows.Forms.Message
        m.Msg = 123



        'For i = 0 To 500 ' Inicializo las columnas
        '    aColWidth(i) = 1000
        'Next i

        If Not Directory.Exists(Application.StartupPath + "\perfiles") Then
            Directory.CreateDirectory(Application.StartupPath + "\perfiles")
        End If
        If Not Directory.Exists(Application.StartupPath + "\temp") Then
            Directory.CreateDirectory(Application.StartupPath + "\temp")
        End If

        PATH_PERFILES = Application.StartupPath + "\perfiles"
        Randomize()   ' Inicializa el generador de números aleatorios.
        ' crea un archivo temporal para guardar el Home
        HOME_FILE = Application.StartupPath + "\temp\flb" + Trim(Str(Int((10000 * Rnd()) + 1)))

        Me.Text = mvarTitulo
        ' Cargo el cubo
        If Not dtCub Is Nothing Then
            If SetUpCube() Then
                ' Seteo los botones de la barra de abajo
                'SetUpableft()
                DCube1.Visible = True

                Select Case Me.Nombre
                    Case "CuboInversionExt"
                        DCube1.Fields.Item("RN_PLAZA").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_PLAZA").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("RN_TIPO_SOPORTE").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_TIPO_SOPORTE").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("RN_SOPORTE").GroupFooterType("sumDS_CPR") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        DCube1.Fields.Item("RN_SOPORTE").GroupFooterExpression("sumDS_CPR") = "(groupsum(sumDS_INVERSION)/groupsum(sumDS_GRP))/groupavg(sumDP_DURACION_AVG)"

                        DCube1.Fields.Item("DS_SOI").DisplayAs = DynamiCubeLib.DisplayTypes.DCDTPercentCol
                        DCube1.Fields.Item("DS_SOI").NumberFormat = "##0.00 %"

                        'Dim x As DynamiCubeLib.Field

                        'x = DCube1.Fields.Add("sumDS_SOI", "santiago", DynamiCubeLib.OrientationConstants.DCData)
                        'x.Calculated = True
                        'x.AggregateFunc = DynamiCubeLib.AggregateFunctions.DCSum
                        'x.GroupFooterType("santiago") = DynamiCubeLib.GroupFooterTypes.DCFCalculated
                        'x.Visible = True
                        'x.Position = DCube1.DataFields.Count
                        DCube1.RefreshData()
                    Case "CuboInversion"
                        DCube1.Fields.Item("DS_SOI").DisplayAs = DynamiCubeLib.DisplayTypes.DCDTPercentCol
                        DCube1.Fields.Item("DS_SOI").NumberFormat = "##0.00 %"

                End Select
                DCube1.RecalcData()
                'GuardarHome()
                'DCube1.Save(HOME_FILE + ".cub", 1)
            Else
                DCube1.Visible = False
            End If
        End If

        'If mvarModo = Graficos Then
        '    DCube1.Visible = False
        'End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        DCube1.PrintPreview()
    End Sub

    Private Sub btnColapsar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColapsar.Click
        ' Segun el parámetro colapsa la informacion o despliega la informacion del cubo.
        Dim looper As Integer

        If b Then
            For looper = 0 To DCube1.Fields.Count - 1
                DCube1.Fields.Item(looper).ShowDetail(True)
            Next looper
            b = False
        Else
            For looper = 0 To DCube1.Fields.Count - 1
                DCube1.Fields.Item(looper).ShowDetail(False)
            Next looper
            b = True
        End If

    End Sub

    Private Sub DCube1_FetchData(ByVal sender As Object, ByVal e As System.EventArgs) Handles DCube1.FetchData
        ' Carga el Cubo desde el rs
        Dim sStatus As String
        Dim rs As Object
        Dim cn As Object
        Dim cnt As Long
        Dim X As Long
        Dim row As DataRow


        If Not dtCub Is Nothing Then
            X = 0

            For Each row In dtCub.Rows
                Application.DoEvents()
                FetchRow(X) ' creo la fila.
                DCube1.AddRowEx(rowArray) 'agrego la fila al cubo
                X = X + 1

            Next
        Else

            ' populate false data in the cube by
            ' adding a generic row to prevent an error
            For X = 0 To DCube1.Fields.Count - 1

                ' place zero's in data fields, "NONE" in dimension fields
                If DCube1.Fields.Item(X).Orientation = DynamiCubeLib.OrientationConstants.DCData Then
                    rowArray(X) = 0
                Else
                    rowArray(X) = "NONE"
                End If
            Next X

            ' add the false row to the cube
            DCube1.AddRowEx(rowArray)

            ' inform the user of what happened
            MsgBox("No existe información para mostrar.", vbInformation, Me.Text)

        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OpenDLG As New SaveFileDialog
        Dim ArchDestino As String
        OpenDLG.InitialDirectory = "c:\"
        OpenDLG.Filter = "Archivos de Excel (*.xls)|*.xls"
        OpenDLG.FilterIndex = 1
        OpenDLG.RestoreDirectory = True

        If OpenDLG.ShowDialog() = DialogResult.OK Then
            ArchDestino = OpenDLG.FileName
            DCube1.ExportToExcel(ArchDestino)
            MsgBox("La exportación fue exitosa", MsgBoxStyle.Information, Me.Text)
        Else
            MsgBox("Debe especificar un nombre de archivo para la exportación", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim OpenDLG As New SaveFileDialog
        Dim ArchDestino As String
        OpenDLG.InitialDirectory = "c:\"
        OpenDLG.Filter = "Archivos HTML (*.html)|*.html"
        OpenDLG.FilterIndex = 1
        OpenDLG.RestoreDirectory = True

        If OpenDLG.ShowDialog() = DialogResult.OK Then
            ArchDestino = OpenDLG.FileName
            DCube1.ExportToHTML(ArchDestino)

        Else
            MsgBox("Debe especificar un nombre de archivo para la exportación", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub


    Private Sub DCube1_Pivot(ByVal sender As Object, ByVal e As System.EventArgs) Handles DCube1.Pivot
        ActualizaColumnas()
    End Sub

    Private Sub DCube1_MouseUpEvent(ByVal sender As Object, ByVal e As AxDynamiCubeLib.IDCubeEvents_MouseUpEvent) Handles DCube1.MouseUpEvent
        ' Si cambia de lugar cualquier header de las cols, page o rows. Mantiene los tamaños de las columnas.
        Dim field As DynamiCubeLib.Field
        Dim j As Integer
        j = 0
        'For Each field In DCube1.Fields
        '    aColWidth(j) = IIf(field.Width = 0, 300, field.Width)
        '    j = j + 1
        'Next field
        ActualizaColumnas()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim index As Integer
        If c Then
            For index = 0 To DCube1.Fields.Count() - 1
                DCube1.Fields.Item(index).GroupFooterVisible = True
            Next index
            c = False
            Button3.Text = "Ocultar Totales"
        Else
            For index = 0 To DCube1.Fields.Count() - 1
                DCube1.Fields.Item(index).GroupFooterVisible = False
            Next index
            c = True
            Button3.Text = "Mostrar Totales"
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Me.GuardarEstado()
        Call cmdActualizar_Click()
        Me.AbrirEstado()
    End Sub

    Private Sub cmdActualizar_Click()
        Dim dtspot, dtdetalle, dtfranjas, dtsoportes As DataTable
        RaiseEvent Actualizar(dtspot, dtdetalle, dtfranjas, dtsoportes)
        Me.AbrirCubo(dtspot, dtdetalle, dtfranjas, dtsoportes)
    End Sub
#Region "Cubo"

    Public Sub AbrirCubo()

        Call cmdActualizar_Click()
    End Sub

    Public Sub AbrirCubo(ByVal DtSpot As DataTable, ByVal DtDetalle As DataTable, ByVal dtFranja As DataTable, ByVal dtSoporte As DataTable)
        Nombre = "CuboEjercicio"
        Titulo = Activo.Ejercicio
        Modo = 0
        DataTableCub = CargarCubo(DtSpot, DtDetalle, dtFranja, dtSoporte)
        Me.cmdActualizar.Visible = True
        Cargar()
        Me.Show()
    End Sub
    Private Sub GuardarEstado()
        Me.DCube1.Save(Ruta & "cub", DynamiCubeLib.SaveOptions.SOLayout)
    End Sub
    Private Sub AbrirEstado()
        Me.DCube1.Load(Ruta & "cub")
    End Sub
    Private Function CargarCubo(ByVal DtSpot As DataTable, ByVal DtDetalle As DataTable, ByVal dtFranja As DataTable, ByVal dtSoporte As DataTable) As DataTable
        Dim ResumenCubo As DataTable = Me.CrearEstructuraCubo

        Dim c As DataRow, Grps As Single = GrpsTotales(DtSpot, DtDetalle)
        For Each sr As DataRow In DtSpot.Rows
            For Each dr As DataRow In DtDetalle.Select("ID_SPOT=" & sr("ID_Spot"))
                c = ResumenCubo.NewRow
                c("rn_tema") = dr("id_tema")
                c("rn_soporte") = Grilladmin.ObtenerDato(dtSoporte, "id_soporte = " & sr("id_soporte"), "descripcion")
                c("rn_franja") = Algoritmos.ObtenerFranja(sr("h_inicio"), sr("m_inicio"), dtFranja)
                c("rn_dia") = CDate(dr("f_spot")).DayOfWeek.ToString
                c("rn_semana") = CDate(dr("f_spot")).Year & " " & Algoritmos.CalcSemana(False, dr("f_spot"), Activo.FechaInicioSistema)
                c("rn_sem cal") = Algoritmos.CalcSemana(True, dr("f_spot"), Activo.FechaInicioSistema)
                c("ds_avisos") = 1
                c("ds_neto") = dr("duracion") * sr("neto")
                c("ds_bruto") = sr("bruto") * dr("duracion")
                c("ds_grp") = sr(Grilladmin.ColumnaRatingTarget1)
                c("ds_%grp") = Math.Round((sr(Grilladmin.ColumnaRatingTarget1) / Grps * 100), 2)
                'c("ds_cpr") = Algoritmos.ObtenerCPR(sr("neto"), 1, sr(Grilladmin.ColumnaRatingTarget1), dr("duracion"))
                ResumenCubo.Rows.Add(c)
            Next
        Next
        Return ResumenCubo
    End Function

    Private Function GrpsTotales(ByVal Spots As DataTable, ByVal detalle As DataTable) As Single

        Dim Rat As Single
        Dim CantDetalles As Integer
        For Each r As DataRow In Spots.Rows
            Rat += r(Grilladmin.ColumnaRatingTarget1) * detalle.Select("ID_Spot =" & r("ID_Spot")).Length
        Next
        Return Rat
    End Function
    Private Function Obtenerneto(ByVal neto As Single, ByVal ParamArray Desc() As Integer) As Single
        Dim NetoOriginal As Single = neto
        Dim NetoNuevo As Single, de As Single
        For Each d As Integer In Desc
            de = (neto * d) / 100
            neto = neto - de
            NetoNuevo += de
        Next

        Return NetoOriginal - NetoNuevo

    End Function




    Private Function CrearEstructuraCubo() As DataTable
        Dim dt As New DataTable

        With dt.Columns
            .Add("RN_TEMA", GetType(String))
            .Add("RN_SOPORTE", GetType(String))
            .Add("RN_FRANJA", GetType(String))
            .Add("RN_SEMANA", GetType(String))
            .Add("RN_DIA", GetType(String))
            .Add("RN_SEM CAL", GetType(String))
            .Add("DS_AVISOS", GetType(Integer))
            .Add("DS_NETO", GetType(Single))
            .Add("DS_BRUTO", GetType(Single))
            .Add("DS_GRP", GetType(Single))
            .Add("DS_%GRP", GetType(Single))
            ' .Add("DS_CPR", GetType(Single))
        End With
        Return dt
    End Function


#End Region

    Private Sub Cubo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        RaiseEvent Cerrando()
    End Sub
End Class

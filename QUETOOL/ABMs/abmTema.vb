Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win

Public Class abmTema
    Inherits System.Windows.Forms.UserControl
    Implements IABM

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLetra As QUETOOL.txtTexto
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDuracion As QUETOOL.txtTexto
    Friend WithEvents iugTemas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cboMaterial As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cbomedio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboProducto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDuracion = New QUETOOL.txtTexto
        Me.txtLetra = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbomedio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboProducto = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cboMaterial = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.iugTemas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbomedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iugTemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.ConDecimal = False
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(572, 43)
        Me.txtDuracion.Maximo = 0
        Me.txtDuracion.MaxLength = 3
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(44, 21)
        Me.txtDuracion.SoloLetra = False
        Me.txtDuracion.SoloNumero = True
        Me.txtDuracion.TabIndex = 3
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLetra
        '
        Me.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLetra.ConDecimal = False
        Me.txtLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetra.Location = New System.Drawing.Point(395, 43)
        Me.txtLetra.Maximo = 0
        Me.txtLetra.MaxLength = 1
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(44, 21)
        Me.txtLetra.SoloLetra = False
        Me.txtLetra.SoloNumero = False
        Me.txtLetra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(504, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Duración"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Letra"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(297, 76)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(28, 23)
        Me.cmdAgregar.TabIndex = 4
        Me.cmdAgregar.Text = "6"
        '
        'cmdModificar
        '
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(329, 76)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(28, 23)
        Me.cmdModificar.TabIndex = 5
        Me.cmdModificar.Text = "5"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbomedio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboProducto)
        Me.GroupBox1.Controls.Add(Me.cboMaterial)
        Me.GroupBox1.Controls.Add(Me.cmdBorrar)
        Me.GroupBox1.Controls.Add(Me.iugTemas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdModificar)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.txtLetra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDuracion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 300)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tema"
        '
        'cbomedio
        '
        Me.cbomedio.AutoSize = True
        Me.cbomedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cbomedio.FlatMode = True
        Me.cbomedio.Location = New System.Drawing.Point(57, 15)
        Me.cbomedio.Name = "cbomedio"
        Me.cbomedio.Size = New System.Drawing.Size(219, 19)
        Me.cbomedio.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Medio"
        '
        'cboProducto
        '
        Me.cboProducto.AutoSize = True
        Me.cboProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProducto.FlatMode = True
        Me.cboProducto.Location = New System.Drawing.Point(393, 18)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(222, 19)
        Me.cboProducto.TabIndex = 13
        '
        'cboMaterial
        '
        Me.cboMaterial.AutoSize = True
        Me.cboMaterial.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMaterial.FlatMode = True
        Me.cboMaterial.Location = New System.Drawing.Point(59, 43)
        Me.cboMaterial.Name = "cboMaterial"
        Me.cboMaterial.Size = New System.Drawing.Size(217, 19)
        Me.cboMaterial.TabIndex = 12
        '
        'cmdBorrar
        '
        Me.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBorrar.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(196, 76)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(28, 23)
        Me.cmdBorrar.TabIndex = 11
        Me.cmdBorrar.Text = "r"
        Me.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'iugTemas
        '
        Me.iugTemas.Cursor = System.Windows.Forms.Cursors.Default
        Appearance21.BackColor = System.Drawing.Color.White
        Me.iugTemas.DisplayLayout.Appearance = Appearance21
        Me.iugTemas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.iugTemas.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Me.iugTemas.DisplayLayout.Override.CellPadding = 3
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugTemas.DisplayLayout.Override.HeaderAppearance = Appearance23
        Appearance24.BorderColor = System.Drawing.Color.LightGray
        Appearance24.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugTemas.DisplayLayout.Override.RowAppearance = Appearance24
        Me.iugTemas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance25.BorderColor = System.Drawing.Color.Black
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.iugTemas.DisplayLayout.Override.SelectedRowAppearance = Appearance25
        Me.iugTemas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugTemas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.iugTemas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugTemas.Location = New System.Drawing.Point(12, 108)
        Me.iugTemas.Name = "iugTemas"
        Me.iugTemas.Size = New System.Drawing.Size(628, 180)
        Me.iugTemas.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "EL TIP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(534, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Recordá que al momento de crear un tema, débes tener seleccionado el sistema, par" & _
            "a el cual lo estas creando. "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Los materiales en MMS tienen medio."
        '
        'abmTema
        '
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "abmTema"
        Me.Size = New System.Drawing.Size(653, 362)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbomedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iugTemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades y declaraciones"

    Dim mDatos As DataTable
    Dim Temas As New Temas

    Dim mModificar As Boolean
    Dim mDebeGuardar As Boolean

    Dim LetraOriginal As String
    Dim IndiceFilaModificada As Integer
    Dim DebeActualizarSpots As Boolean

    Public Property DebeGuardar() As Boolean Implements Framework.IABM.DebeGuardar
        Get
            Return mDebeGuardar
        End Get
        Set(ByVal Value As Boolean)
            mDebeGuardar = Value
        End Set
    End Property

    Public Property Modificar() As Boolean Implements Framework.IABM.Modificar
        Get
            Return mModificar
        End Get
        Set(ByVal Value As Boolean)
            mModificar = Value
        End Set
    End Property

    Public ReadOnly Property Alto() As Integer Implements Framework.IABM.Alto
        Get
            Return Me.Height
        End Get
    End Property

    Public ReadOnly Property Ancho() As Integer Implements Framework.IABM.Ancho
        Get
            Return Me.Width
        End Get
    End Property

    Public Property Datos() As DataTable
        Get
            If mDatos Is Nothing Then
                mDatos = New DataTable
            End If

            Return mDatos
        End Get
        Set(ByVal Value As DataTable)
            mDatos = Value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overloads Sub Cargar() Implements Framework.IABM.Cargar
        'carga los productos del cliente
        Dim P As New Productos
        Dim dt As DataTable

        P.Id_cliente = Activo.IDCliente

        'AG TEMAS  +++++++++++++++++++++++++++++++++++++++++++++++
        Dim Medio As New Soportes
        Listas.CargarCombo(cbomedio, CargarMediosUnicos(Medio.ObtenerMediosActivos), "descripcion", False)

        dt = P.TraerProductos
        dt = dt.Select("", "DESCRIPCION2 ASC").CopyToDataTable()

        CargarComboProducto(dt, "descripcion2", True, "-- NINGUNO --")
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'Listas.CargarCombo(cboProducto, P.TraerProductos, "descripcion", False)

        Listas.AplicarFormato(Me.iugTemas)

        'trae los temas de la campaña
        Temas.Id_campania = Activo.IDCampaña
        'Temas.Id_sistema = Activo.IDSistema

        Datos = Temas.ObtenerTemasPorCampaña

        For Each Dr As DataRow In Datos.Rows
            If Dr("Material").ToString.ToLower.Equals("no disponible") Then
                Dr("Material") = "Sin Material"
            End If
        Next

        'AG TEMAS prueba +++++++++++++++++++++++++++++++++++++++++
        Dim Medios() As String = {"1", "6"}
        Dim j As Integer
        Dim id_material As Integer
        Dim dtresultado As New DataTable
        Dim Filas() As DataRow

        If Datos.Rows.Count > 0 Then
            For j = 0 To Medios.Length - 1
                For Each Dr As DataRow In Datos.Rows
                    Dim M As New Materiales
                    M.Id_cliente = Activo.IDCliente
                    M.id_medio = CInt(Medios(j))
                    M.Id_producto = CInt(Dr("id_producto"))

                    'AG Demora mucho asi ++++++++++++++++++++++++++++++++++
                    'dtresultado = M.TraerMateriales()
                    'Filas = dtresultado.Select("id_medio=" & CInt(Medios(j)) & " and id_material=" & CInt(Dr("id_material")) & " and id_producto=" & CInt(Dr("id_producto")))
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++

                    'AG Busco en el Cache ya cargado con todos los materiales ++++++++++++++++++++
                    Filas = Activo.DTMaterialesCache.Select("id_medio=" & CInt(Medios(j)) & " and id_material=" & CInt(Dr("id_material")) & " and id_producto=" & CInt(Dr("id_producto")) & " and id_cliente=" & CInt(Activo.IDCliente))
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If Filas.Length > 0 Then
                        If Filas(0)("id_medio") = 1 Then
                            Dr("material") = Filas(0)("descripcion") + " - TV"
                        ElseIf Filas(0)("id_medio") = 6 Then
                            Dr("material") = Filas(0)("descripcion") + " - RD"
                        End If
                    End If
                Next
            Next
        End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++

        'pasa el datatable
        Me.iugTemas.DataSource = Datos

        Me.FormatearGrilla()

        Me.txtLetra.Text = ""
        Me.txtDuracion.Text = ""

        Me.cboProducto.Enabled = True
        Me.DebeGuardar = False
        Me.DebeActualizarSpots = False
        Me.txtLetra.Enabled = True

        Call CargarMateriales(0)

    End Sub

    Private Sub FormatearGrilla()
        'AG TEMAS  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Listas.OcultarColumnas(Me.iugTemas, "id_campania", "id_producto", "id_material", "tema")
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Listas.CambiarTituloColumna(Me.iugTemas, "id_tema", "Letra")
        Listas.CambiarTituloColumna(Me.iugTemas, "duracion", "Duración")
        Listas.CambiarTituloColumna(Me.iugTemas, "producto", "Producto")
        Listas.CambiarTituloColumna(Me.iugTemas, "material", "Material")

        'Listas.CambiarTituloColumna(Me.iugTemas, "medio", "Medio") 'AG TEMAS

        'ajusta el ancho de las columnas al de los datos
        With Me.iugTemas
            .DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
            .DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(2).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(3).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(4).PerformAutoResize()
            '.DisplayLayout.Bands(0).Columns(5).PerformAutoResize()
            '.DisplayLayout.Bands(0).Columns(6).PerformAutoResize()
        End With

    End Sub

    Public Function CargarObjeto() As Boolean Implements Framework.IABM.CargarObjeto
        With Temas
            .Id_producto = Me.cboProducto.Value
            .Id_material = Me.cboMaterial.Value
            .Id_tema = Me.txtLetra.Text
            .Duracion = Me.txtDuracion.Text
            'AG TEMAS ++++++++++++++++++
            .Id_medio = Me.cbomedio.Value
            '+++++++++++++++++++++++++
        End With

        Return True
    End Function

    Public Sub Guardar() Implements Framework.IABM.Guardar
        Me.Cursor = Cursors.WaitCursor

        Dim S As New Spots_detalle
        Dim TieneSpots As Boolean

        Try
            For Each Dr As DataRow In Datos.Rows
                'si hay cambios en la fila
                If Dr.HasVersion(DataRowVersion.Proposed) Then
                    'busca si el tema tiene spots asociados
                    TieneSpots = S.TieneSpotsAsociados(Activo.IDCampaña, Dr("id_tema"))
                    'si se cambio la DURACION y tiene spots asociados
                    If Not Dr("duracion", DataRowVersion.Current) Is _
                    Dr("duracion", DataRowVersion.Proposed) And _
                    TieneSpots Then
                        'actualiza la duracion de los temas
                        S.ActualizarDuracion(Activo.IDCampaña, Dr("id_tema"), Dr("duracion", DataRowVersion.Proposed))
                    End If
                    Dr.EndEdit()
                End If
            Next

            Temas.ActualizarDataSet(Datos.DataSet, Datos.TableName)

        Catch ex As Oracle.DataAccess.Client.OracleException
            Mensajes.Mensaje("Se Ha Intentado Borrar un Tema que Tiene Registros Relacionados.")
        Catch ex As Excepciones.ClaveDuplicadaExcepcion
            Mensajes.Mensaje("Ha intentado guardar un tema que ya existe")
        End Try

        Me.DebeGuardar = False

        Me.Cursor = Cursors.Default
    End Sub

    Private Function ActualizarSpots() As Boolean

        Dim F As New frmActualizar(Activo.IDCampaña)
        F.ShowDialog()

        Return F.TerminoOK
    End Function

    Private Sub ArmarObjeto(ByVal Dr As DataRow)
        Temas.Id_tema = Dr("id_tema")
        Temas.Id_material = IIf(IsDBNull(Dr("id_material")), "", Dr("id_material"))
        Temas.Duracion = Dr("duracion")
        Temas.Id_producto = Dr("id_producto")
        Temas.Id_campania = Activo.IDCampaña
    End Sub

    Public Sub LimpiarControles() Implements Framework.IABM.LimpiarControles
        Me.DebeGuardar = True
    End Sub

    Private Sub CargarMateriales(Optional ByVal IdMedio As Integer = 0)
        'carga el combo de materiales
        'cboMaterial.Items.Clear()
        Dim M As New Materiales

        M.Id_cliente = Activo.IDCliente
        Activo.IsMaterialEjercicio = False

        If IdMedio = 0 Then
            M.id_medio = cbomedio.Value("id_medio")
        Else
            M.id_medio = IdMedio
        End If

        'M.id_medio = cbomedio.Value("id_medio")

        M.Id_producto = cboProducto.Value("id_producto")
        Listas.CargarCombo(cboMaterial, M.TraerMateriales, "descripcion", True, "Sin Material")
        Call cboMaterial_AfterCloseUp(Nothing, Nothing)
    End Sub

    Private Sub CargarComboProducto(ByVal pobjTable As DataTable, ByVal pstrDisplayText As String, Optional ByVal pblnEsSeleccioneOpcion As Boolean = True, Optional ByVal SinOpcion As String = "")

        Dim objItem As ValueListItem
        Dim objRow As DataRow
        Dim oRow As DataRow
        cboProducto.Items.Clear()
        cboProducto.Text = ""

        If pblnEsSeleccioneOpcion = True Then
            Dim Dt As New DataTable
            Dt = pobjTable.Clone
            Dim Row As DataRow
            Row = Dt.NewRow
            Row.Item("id_producto") = -1
            Row.Item("descripcion") = SinOpcion
            Row.Item("descripcion2") = SinOpcion
            Dt.Rows.Add(Row)

            For Each oRow In Dt.Rows
                objItem = New ValueListItem
                objItem.DataValue = oRow
                objItem.DisplayText = oRow(pstrDisplayText)
                cboProducto.Items.Add(objItem)
            Next
        End If

        For Each objRow In pobjTable.Rows
            objItem = New ValueListItem
            objItem.DataValue = objRow
            objItem.DisplayText = objRow(pstrDisplayText)
            cboProducto.Items.Add(objItem)
        Next

        cboProducto.EndUpdate()

        If cboProducto.Items.Count <> 0 Then
            cboProducto.SelectedIndex = 0
        End If
    End Sub


    Private Function ObtenerMedio(ByVal IdMedio As Integer) As String

        Dim Medio As String

        Select Case IdMedio

            Case 0
                Medio = "SERVICIOS"
            Case 1
                Medio = "TELEVISION"
            Case 2
                Medio = "INTERNET"
            Case 3
                Medio = "EXTERIOR"
            Case 4
                Medio = "PRENSA"
            Case 5
                Medio = "REVISTAS"
            Case 6
                Medio = "RADIO"
            Case 7
                Medio = "PRODUCCION"
        End Select
        Return Medio

    End Function

    Private Function CargarMediosUnicos(ByVal Dt As DataTable) As DataTable

        Dim DtMedio As New DataTable
        DtMedio = Dt.Clone
        Dim Row As DataRow

        For Each Dr As DataRow In Dt.Rows
            If Dr("id_medio") = "1" Or Dr("id_medio") = "6" Then
                Row = DtMedio.NewRow
                Row.Item("id_medio") = Dr("id_medio")
                Row.Item("descripcion") = Dr("descripcion")
                DtMedio.Rows.Add(Row)
            End If
        Next

        Return DtMedio
    End Function

#End Region

#Region "Eventos de los Controles del Formulario"

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim idMaterial As String
        If cboProducto.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar un Producto")
            cboProducto.Select()
            Exit Sub
        End If

        If txtLetra.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar una Letra")
            txtLetra.Select()
            Exit Sub
        End If

        If txtLetra.Text = "ñ" Or txtLetra.Text = "Ñ" Then
            Mensajes.Mensaje("Las Letras ñ y Ñ No Están Permitidas")
            txtLetra.Select()
            Exit Sub
        End If

        Dim CaracteresInvalidos As String = "-+*ª!""·$%&/()=?¿^¨Ç_\|@#~€¬,.[]{};:"

        For Each s As String In CaracteresInvalidos
            If txtLetra.Text = s Then
                Mensajes.Mensaje("El Caracter en Letra No es Válido")
                txtLetra.Select()
                txtLetra.SelectAll()
                Exit Sub
            End If
        Next

        If txtDuracion.Text = "0" Then
            Mensajes.Mensaje("La Duración No Puede Ser '0' (Cero)")
            txtDuracion.Select()
            Exit Sub
        End If

        If txtDuracion.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar una Duración")
            txtDuracion.Select()
            Exit Sub
        End If

        txtLetra.Enabled = True

        'AGREGA UNA NUEVA FILA
        If Me.iugTemas.Rows.Count < 26 Then
            If Asc(txtLetra.Text) >= 48 And Asc(txtLetra.Text) <= 57 Then
                Mensajes.Mensaje("Debe Agotar Todas las Letras Antes de Poder usar Números")
                Exit Sub
            End If
        End If

        If cboMaterial.Text.Trim = "" Or cboMaterial.Text.ToLower = "sin material" Then
            idMaterial = "-1"
        Else
            idMaterial = cboMaterial.Value("id_material")
        End If

        'AG 15/02/2013 ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If cboProducto.Value("id_producto") = -1 Then
            Mensajes.Mensaje("Debe seleccionar un Producto, para la creacion del Tema.  ")
            cboProducto.SelectedIndex = 0
            cboProducto.Select()
            Exit Sub
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        If Not Me.Modificar Then
            'no deja ingresar el mismo producto y material
            Dim Dt As DataTable

            'valida que no existan 2 letras iguales
            Dt = Listas.FiltrarDT(Datos, "id_tema = '" & txtLetra.Text & "'", , True)

            If Dt.Rows.Count > 0 Then
                Mensajes.Mensaje("Ya Ingresó la Letra '" & txtLetra.Text & "'")
                Exit Sub
            End If

            If IsDBNull(cboMaterial.Value) Then
                cboMaterial.Value = 0
            End If

            Dim Dr As DataRow

            Dr = Datos.NewRow

            Dr("id_campania") = Activo.IDCampaña
            Dr("id_tema") = txtLetra.Text
            Dr("id_producto") = cboProducto.Value("id_producto")
            Dr("id_material") = idMaterial
            Dr("duracion") = Me.txtDuracion.Text
            Dr("producto") = cboProducto.Text
            Dr("material") = IIf(cboMaterial.Text = "", "Sin Material", cboMaterial.Text)
            'AG TEMAS +++++++++++++++++++++++
            'Dr("medio") = Me.cbomedio.Text
            'Dr("Id_medio") = Me.cbomedio.Value("id_medio")
            '++++++++++++++++++++++++++++++
            Datos.Rows.Add(Dr)
        Else
            'MODIFICAR
            Dim Fila As DataRow

            'controla que el tema no tenga spots asocios
            Dim S As New Spots_detalle
            Dim TieneSpots As Boolean

            If LetraOriginal = "" Then
                LetraOriginal = txtLetra.Text
            End If

            'busca si el tema tiene spots asociados
            TieneSpots = S.TieneSpotsAsociados(Activo.IDCampaña, Me.LetraOriginal)

            'si se cambio la letra y tiene spots asociados
            If Me.txtLetra.Text <> Me.LetraOriginal AndAlso TieneSpots Then
                'pregunta si desea continuar con el cambio de letra
                Dim Res As DialogResult
                Res = Mensajes.Mensaje("El Tema Tiene Spots Asociados. ¿Desea Continuar?", TipoMensaje.SiNo)

                If Res = DialogResult.Yes Then
                    '*** FALTA PROCESO PARA ACTUALIZAR LA LETRA
                    MsgBox("Falta Proceso para actualizar la letra...")
                Else
                    Exit Sub
                End If
            End If

            Try
                Fila = Datos.Select("id_tema = '" & LetraOriginal & "'")(0)

                Fila.BeginEdit()

                Fila.Item("id_tema") = txtLetra.Text
                If Fila.Item("Material") <> cboMaterial.Text Then
                    DebeActualizarSpots = True
                End If
                Fila.Item("duracion") = txtDuracion.Text

                Fila.Item("id_producto") = cboProducto.Value("id_producto")
                Fila.Item("producto") = cboProducto.Text

                If cboMaterial.Text.ToLower = "sin material" Then
                    Fila.Item("id_material") = -1
                ElseIf cboMaterial.Text.ToLower.Trim = "" Then
                    Fila.Item("id_material") = -1
                Else
                    Fila.Item("id_material") = cboMaterial.Value("id_material")
                    'AG TEMAS +++++++++++++++++++++++++++++++++++++++++
                    'Fila.Item("id_material") = IIf(cboMaterial.Text.ToLower.Trim = "", "-1", cboMaterial.Value("id_material"))
                    '++++++++++++++++++++++++++++++++++++++++++++++++++
                End If

                Fila.Item("material") = cboMaterial.Text

                If Fila("Material").ToString.ToLower.Equals("no disponible") Or _
                Fila("Material").ToString.ToLower.Equals("") Then
                    Fila("Material") = "Sin Material"
                End If

                'AG TEMAS +++++++++++++++++++++
                'Fila.Item("id_medio") = Me.cbomedio.Value("id_medio")
                'Fila.Item("medio") = Me.cbomedio.Text
                '++++++++++++++++++++++++++++

                'desoculta la fila de la grilla
                Me.iugTemas.Rows(Me.IndiceFilaModificada).Hidden = False

            Catch ex As IndexOutOfRangeException
                Me.Modificar = False
            Catch es As Exception
                Me.Modificar = False
                MsgBox(es.Message)
            End Try

            'muestra un mensaje si se cambia la duracion del tema
            If Fila.HasVersion(DataRowVersion.Proposed) Then

                'si se cambio la DURACION y tiene spots asociados
                If Not Fila("duracion", DataRowVersion.Current) = _
                Fila("duracion", DataRowVersion.Proposed) And _
                TieneSpots Then

                    Dim dt As DataTable
                    Dim dtEjercicios As DataTable
                    Dim c As New Campaña
                    Dim ej As New Ejercicios
                    Dim salir As Boolean
                    c.ID_Campania = Activo.IDCampaña
                    dt = c.ObtenerSistemas().Tables(0)

                    salir = False
                    For Each r As DataRow In dt.Rows
                        ej.Id_campania = Activo.IDCampaña
                        ej.Id_sistema = r("id_sistema")
                        dtEjercicios = ej.ObtenerEjerciciosSistema
                        For Each row As DataRow In dtEjercicios.Rows
                            If row("id_ejercicio_est") = 3 Then
                                salir = True
                                Exit For
                            End If
                        Next
                        If salir Then
                            Exit For
                        End If
                    Next

                    If salir Then
                        Mensajes.Mensaje("Existen Spots Enviados a Compras. Comuniquese con el Comprador. Se Procedera a Actualizar los Spots")
                    Else
                        Mensajes.Mensaje("Se ha Cambiado la Duracion un Tema. Se Procedera a Actualizar los Spots")
                    End If


                End If

            End If
            '** 

            cboProducto.Enabled = True
            Me.Modificar = False
        End If

        Me.iugTemas.DataSource = Datos

        Me.FormatearGrilla()

        Me.DebeGuardar = True

        Me.LetraOriginal = ""
        cboMaterial.Text = ""
        txtDuracion.Text = ""
        txtLetra.Text = ""

        cboProducto.SelectedIndex = 0
        CargarMateriales(-1)
        cboProducto.Select()

    End Sub

    Private Sub cmdQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.iugTemas.ActiveRow Is Nothing OrElse Me.iugTemas.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        'cboProducto.Value = Val(iugTemas.ActiveRow.Cells("id_producto").Text)
        Listas.SeleccionarItem(cboProducto, "id_producto", iugTemas.ActiveRow.Cells("id_producto").Text)
        'Listas.Combo_Position(cboProducto, "id_producto", Me.iugTemas.ActiveRow.Cells("id_producto").Text)

        'cuando se elige una fila para modificar, se vuelven a cargar los materiales

        'AG TEMAS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Dim IdMedio As Integer

        If iugTemas.ActiveRow.Cells("material").Text <> "Sin Material" Then
            Dim PrefijoMedios() As String
            PrefijoMedios = iugTemas.ActiveRow.Cells("material").Text.Split("-")
            If PrefijoMedios(1).Trim = "TV" Then
                IdMedio = 1
                Listas.SeleccionarItem(cbomedio, "id_medio", CStr(IdMedio))
                CargarMateriales(IdMedio)
            ElseIf PrefijoMedios(1).Trim = "RD" Then
                IdMedio = 6
                Listas.SeleccionarItem(cbomedio, "id_medio", CStr(IdMedio))
                CargarMateriales(IdMedio)
            End If
        Else
            'cboProducto.SelectedIndex = 0
            CargarMateriales(-1)
            'IdMedio = CInt(iugTemas.ActiveRow.Cells("id_medio").Text)
        End If

        'Listas.SeleccionarItem(cbomedio, "id_medio", CStr(IdMedio))
        'CargarMateriales(IdMedio)

        'Listas.SeleccionarItem(cbomedio, "id_medio", iugTemas.ActiveRow.Cells("id_medio").Text)
        'CargarMateriales(CInt(iugTemas.ActiveRow.Cells("id_medio").Text))
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Listas.SeleccionarItem(cboMaterial, "id_material", iugTemas.ActiveRow.Cells("id_material").Text)

        txtDuracion.Text = Me.iugTemas.ActiveRow.Cells("duracion").Text
        txtLetra.Text = Me.iugTemas.ActiveRow.Cells("id_tema").Text

        'oculta la columna a modificar
        Me.iugTemas.ActiveRow.Hidden = True

        'guarda el indice y la letra del tema que se esta modificando
        Me.IndiceFilaModificada = Me.iugTemas.ActiveRow.Index
        Me.LetraOriginal = txtLetra.Text

        Me.DebeGuardar = True
        Me.Modificar = True

        txtLetra.Enabled = False

        'selecciona la ultima fila de la grilla
        If Me.iugTemas.Rows.Count > 0 Then
            Me.iugTemas.Rows(Me.iugTemas.Rows.Count - 1).Selected = True
        End If
    End Sub

    Public Sub Cancelar() Implements Framework.IABM.Cancelar
    End Sub

    Private Sub txtLetra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLetra.TextChanged
        txtLetra.Text = txtLetra.Text.ToUpper
    End Sub

    Private Sub txtLetra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLetra.KeyDown
        Me.LetraOriginal = txtLetra.Text
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.iugTemas.ActiveRow Is Nothing OrElse Me.iugTemas.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        If Mensajes.Mensaje("A Continuacion se Eliminaran Todos los Spots de Este Tema. ¿Desea Continuar?", TipoMensaje.SiNo) = DialogResult.No Then
            Exit Sub
        End If

        'busca la fila en el Data Table
        Dim Dr As DataRow
        Dim Filtro As String

        Filtro = "id_tema = '" & Me.iugTemas.ActiveRow.Cells("id_tema").Text & "'"
        Dr = Datos.Select(Filtro, "")(0)

        'controla que el tema no este adentro de alguna alternativa
        Dim Alter As New Alternativas_temas

        If Alter.TieneAlternativa(Activo.IDCampaña, Dr("id_tema")) Then
            Mensajes.Mensaje("No Se Puede Borrar el Tema Porque Está Utilizado en una Alternativa")
            Exit Sub
        End If

        'se usa DELETE para marcar la fila como borrada
        Dr.Delete()

        Me.DebeGuardar = True
        Me.iugTemas.DataSource = Datos

        'vuelve a activar la carga de temas
        cboProducto.Enabled = True

        Me.Modificar = False

        txtLetra.Text = ""
        txtLetra.Enabled = True
        txtDuracion.Text = ""

        'AG TEMAS +++++++++++++++++++++
        'cboProducto.SelectedIndex = 0
        'CargarMateriales(-1)
        '++++++++++++++++++++++++++++

        If Me.iugTemas.Rows.Count > 0 Then
            Me.iugTemas.Rows(Me.iugTemas.Rows.Count - 1).Selected = True
        End If
    End Sub

    Private Sub cboMaterial_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMaterial.AfterCloseUp
        If cboMaterial.Items.Count = 0 OrElse cboMaterial.SelectedItem Is Nothing Then
            Exit Sub
        End If

        If cboMaterial.Text = "" Then
            txtDuracion.Text = ""
            Exit Sub
        End If

        If cboMaterial.Text.ToLower = "sin material" Then
            txtDuracion.Text = 0
        Else
            txtDuracion.Text = IIf(IsDBNull(cboMaterial.SelectedItem.DataValue("duracion")), 0, cboMaterial.SelectedItem.DataValue("duracion"))
        End If

    End Sub

    Private Sub cboProducto_AfterCloseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProducto.AfterCloseUp
        CargarMateriales(0)
    End Sub

#End Region


    Private Sub abmTema_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cbomedio_AfterCloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedio.AfterCloseUp
        'AG TEMAS +++++++++++++++++++++++++++
        cboProducto.SelectedIndex = 0
        Me.cboMaterial.SelectedIndex = 0
        '++++++++++++++++++++++++++++++++++
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class


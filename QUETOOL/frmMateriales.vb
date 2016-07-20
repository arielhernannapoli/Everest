Public Class frmMateriales
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
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents cboProducto As QUETOOL.cboCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As QUETOOL.txtTexto
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents lblCodigoAFSCA As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAFSCA As QUETOOL.txtTexto
    Friend WithEvents cboMedio As QUETOOL.cboCombo
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents rdbExtranjero As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNacional As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMateriales))
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbExtranjero = New System.Windows.Forms.RadioButton
        Me.rdbNacional = New System.Windows.Forms.RadioButton
        Me.cboMedio = New QUETOOL.cboCombo
        Me.lblMedio = New System.Windows.Forms.Label
        Me.lblCodigoAFSCA = New System.Windows.Forms.Label
        Me.txtCodigoAFSCA = New QUETOOL.txtTexto
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDuracion = New QUETOOL.txtTexto
        Me.cboProducto = New QUETOOL.cboCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.cmdNuevo = New System.Windows.Forms.Button
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(300, 214)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(384, 214)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbExtranjero)
        Me.GroupBox2.Controls.Add(Me.rdbNacional)
        Me.GroupBox2.Controls.Add(Me.cboMedio)
        Me.GroupBox2.Controls.Add(Me.lblMedio)
        Me.GroupBox2.Controls.Add(Me.lblCodigoAFSCA)
        Me.GroupBox2.Controls.Add(Me.txtCodigoAFSCA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDuracion)
        Me.GroupBox2.Controls.Add(Me.cboProducto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.lblDescripcion)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 187)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'rdbExtranjero
        '
        Me.rdbExtranjero.AutoSize = True
        Me.rdbExtranjero.Location = New System.Drawing.Point(112, 164)
        Me.rdbExtranjero.Name = "rdbExtranjero"
        Me.rdbExtranjero.Size = New System.Drawing.Size(72, 17)
        Me.rdbExtranjero.TabIndex = 17
        Me.rdbExtranjero.Text = "Extranjero"
        Me.rdbExtranjero.UseVisualStyleBackColor = True
        '
        'rdbNacional
        '
        Me.rdbNacional.AutoSize = True
        Me.rdbNacional.Checked = True
        Me.rdbNacional.Location = New System.Drawing.Point(15, 164)
        Me.rdbNacional.Name = "rdbNacional"
        Me.rdbNacional.Size = New System.Drawing.Size(67, 17)
        Me.rdbNacional.TabIndex = 16
        Me.rdbNacional.TabStop = True
        Me.rdbNacional.Text = "Nacional"
        Me.rdbNacional.UseVisualStyleBackColor = True
        '
        'cboMedio
        '
        Me.cboMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboMedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMedio.DisplayMember = ""
        Me.cboMedio.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboMedio.FlatMode = True
        Me.cboMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.Location = New System.Drawing.Point(72, 14)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(364, 21)
        Me.cboMedio.TabIndex = 14
        Me.cboMedio.ValueMember = ""
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Location = New System.Drawing.Point(12, 18)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(36, 13)
        Me.lblMedio.TabIndex = 15
        Me.lblMedio.Text = "Medio"
        '
        'lblCodigoAFSCA
        '
        Me.lblCodigoAFSCA.AutoSize = True
        Me.lblCodigoAFSCA.Location = New System.Drawing.Point(12, 131)
        Me.lblCodigoAFSCA.Name = "lblCodigoAFSCA"
        Me.lblCodigoAFSCA.Size = New System.Drawing.Size(77, 13)
        Me.lblCodigoAFSCA.TabIndex = 13
        Me.lblCodigoAFSCA.Text = "Codigo AFSCA"
        '
        'txtCodigoAFSCA
        '
        Me.txtCodigoAFSCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoAFSCA.ConDecimal = False
        Me.txtCodigoAFSCA.Enabled = False
        Me.txtCodigoAFSCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAFSCA.Location = New System.Drawing.Point(95, 127)
        Me.txtCodigoAFSCA.Maximo = 0
        Me.txtCodigoAFSCA.MaxLength = 50
        Me.txtCodigoAFSCA.Name = "txtCodigoAFSCA"
        Me.txtCodigoAFSCA.Size = New System.Drawing.Size(341, 21)
        Me.txtCodigoAFSCA.SoloLetra = False
        Me.txtCodigoAFSCA.SoloNumero = False
        Me.txtCodigoAFSCA.TabIndex = 12
        Me.txtCodigoAFSCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Duración"
        '
        'txtDuracion
        '
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.ConDecimal = False
        Me.txtDuracion.Enabled = False
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(72, 100)
        Me.txtDuracion.Maximo = 0
        Me.txtDuracion.MaxLength = 3
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(364, 21)
        Me.txtDuracion.SoloLetra = False
        Me.txtDuracion.SoloNumero = True
        Me.txtDuracion.TabIndex = 3
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboProducto
        '
        Me.cboProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboProducto.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboProducto.DisplayMember = ""
        Me.cboProducto.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboProducto.FlatMode = True
        Me.cboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.Location = New System.Drawing.Point(72, 44)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(364, 21)
        Me.cboProducto.TabIndex = 0
        Me.cboProducto.ValueMember = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Producto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(184, 72)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(252, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(72, 72)
        Me.txtCodigo.Maximo = -1
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(84, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = False
        Me.txtCodigo.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Enabled = False
        Me.lblDescripcion.Image = CType(resources.GetObject("lblDescripcion.Image"), System.Drawing.Image)
        Me.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(160, 72)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(21, 21)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdNuevo
        '
        Me.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNuevo.Location = New System.Drawing.Point(8, 214)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(75, 23)
        Me.cmdNuevo.TabIndex = 9
        Me.cmdNuevo.Text = "Nuevo"
        '
        'cmdModificar
        '
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Location = New System.Drawing.Point(92, 214)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 10
        Me.cmdModificar.Text = "Modificar"
        '
        'frmMateriales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materiales"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Material As New Materiales
    Dim Modo As String

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_SePresionoBarra() Handles txtCodigo.SePresionoBarra
        BuscarMateriales()
    End Sub

    Private Sub BuscarMateriales()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Materiales, txtDescripcion, txtCodigo, "id_material", "descripcion", "Código", "Material", cboProducto.Value, Activo.IDMedio, Activo.IDCliente)

        F.ShowDialog()

        If txtCodigo.Text <> "" Then
            Material.Id_cliente = Activo.IDCliente
            Material.Id_producto = cboProducto.Value
            Material.Id_material = txtCodigo.Text
            If Material.TraerMaterial() Then
                txtDuracion.Text = Material.Duracion
            End If
        End If
    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click
        BuscarMateriales()
    End Sub

    Private Sub frmMateriales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim P As New Productos

        'Activo.IDCliente = 2
        P.Id_cliente = Activo.IDCliente

        rdbNacional.Enabled = txtCodigoAFSCA.Text.Length > 0
        rdbExtranjero.Enabled = txtCodigoAFSCA.Text.Length > 0
        If txtCodigoAFSCA.Text.Length = 0 Then
            rdbExtranjero.Checked = False
            rdbNacional.Checked = False
        End If

        Listas.CargarCombo(cboProducto, P.TraerProductos, "id_producto", "descripcion")
        Listas.OcultarColumnas(cboProducto, "id_cliente", "id_producto")
        Listas.OcultarHeader(cboProducto)
        Modo = "CONS"

        CargarMedios()

    End Sub

    Private Sub CargarMedios()
        Dim Medio As New Soportes
        Listas.CargarCombo(Me.cboMedio, Medio.ObtenerMediosActivos, "Id_Medio", "descripcion")

        Listas.OcultarColumnas(cboMedio, "Id_Medio")
        Listas.OcultarHeader(cboMedio)
        cboMedio.SelectedRow = cboMedio.Rows(0)
    End Sub

    Private Sub cboProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProducto.TextChanged
        txtCodigo.Enabled = True
        lblDescripcion.Enabled = True
        lblCodigoAFSCA.Enabled = True '(Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio)
        txtCodigoAFSCA.Enabled = True '(Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio)
        rdbExtranjero.Enabled = txtCodigoAFSCA.Text.Length > 0
        rdbNacional.Enabled = txtCodigoAFSCA.Text.Length > 0

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtDuracion.Text = 0
        txtCodigoAFSCA.Text = ""
    End Sub

    Private Sub cboMedio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMedio.TextChanged
        lblCodigoAFSCA.Visible = (cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio)
        txtCodigoAFSCA.Visible = (cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio)
        rdbExtranjero.Visible = (cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio)
        rdbNacional.Visible = (cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio)
    End Sub

    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = True
        txtDuracion.Enabled = True
        lblDescripcion.Enabled = False
        lblCodigoAFSCA.Enabled = True
        txtCodigoAFSCA.Enabled = True '(Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio)
        rdbExtranjero.Enabled = txtCodigoAFSCA.Text.Length > 0
        rdbNacional.Enabled = txtCodigoAFSCA.Text.Length > 0

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtDuracion.Text = 0
        txtCodigoAFSCA.Text = ""
        Modo = "ALTA"
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = True
        txtDuracion.Enabled = True
        lblDescripcion.Enabled = False
        lblCodigoAFSCA.Enabled = False '(Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio)
        txtCodigoAFSCA.Enabled = True '(Activo.IDMedio = Medios.Tv Or Activo.IDMedio = Medios.Radio)
        rdbExtranjero.Enabled = txtCodigoAFSCA.Text.Length > 0
        rdbNacional.Enabled = txtCodigoAFSCA.Text.Length > 0
        Modo = "MODI"
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim Msg As String = ""

        If Me.txtCodigo.Text.Trim = "" Then
            Msg = "Debe ingresar el Código."
        End If
        If Me.txtDescripcion.Text.Trim = "" Then
            Msg = "Debe ingresar una Descripción."
        End If
        If Me.txtDuracion.Text.Trim = "" Then
            Msg = "Debe ingresar la Duración."
        End If
        If Me.cboProducto.Text.Trim = "" Then
            Msg = "Debe ingresar el Producto."
        End If

        If cboMedio.Value = Medios.Tv Or Activo.IDMedio = Medios.Radio Then
            If Me.txtCodigoAFSCA.Text.Trim.Length > 0 Then
                If Not rdbExtranjero.Checked And Not rdbNacional.Checked Then
                    Msg = "Debe seleccionar un origen para el aviso"
                End If
            End If
        End If

        If Msg <> "" Then
            MessageBox.Show(Msg)
            Exit Sub
        End If

        Material.id_medio = cboMedio.Value
        Material.Id_cliente = Activo.IDCliente
        Material.Id_producto = cboProducto.Value
        Material.Id_material = txtCodigo.Text
        Material.Descripcion = txtDescripcion.Text
        Material.Duracion = txtDuracion.Text
        If Modo = "ALTA" Then
            If Not Material.ExisteMaterial Then
                Material.Agregar()
                If cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio Then
                    If txtCodigoAFSCA.Text.Trim.Length > 0 Then
                        If Material.ExisteCodigoAfsca(txtCodigoAFSCA.Text, Material.Id_material) Then
                            MessageBox.Show("El código AFSCA ingresado ya existe.")
                        Else
                            Material.AgregarCodigoAfsca(txtCodigoAFSCA.Text, Material.Id_material)
                            Material.SetNacionalExtranjeroFlag(rdbNacional.Checked, Material.Id_material)
                        End If
                    End If

                End If
            Else
                MessageBox.Show("El código de material ingresado ya existe.")
                Exit Sub
            End If
        Else
            Material.Modificar()
            If cboMedio.Value = Medios.Tv Or cboMedio.Value = Medios.Radio Then
                If txtCodigoAFSCA.Text.Trim.Length > 0 Then
                    If Material.ExisteCodigoAfsca(txtCodigoAFSCA.Text, Material.Id_material) Then
                        MessageBox.Show("El código AFSCA ingresado ya existe.")
                    Else
                        If Material.ExisteCodigoAfscaByMaterial(txtCodigo.Text) Then
                            Material.ActualizarCodigoAfsca(txtCodigoAFSCA.Text, txtCodigo.Text)
                        Else
                            Material.AgregarCodigoAfsca(txtCodigoAFSCA.Text, txtCodigo.Text)
                        End If
                        Material.SetNacionalExtranjeroFlag(rdbNacional.Checked, txtCodigo.Text)
                    End If
                End If
            End If
        End If

        Modo = "CONS"
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtDuracion.Text = 0
        txtCodigo.Enabled = True
        txtDescripcion.Enabled = False
        lblDescripcion.Enabled = True
        txtDuracion.Enabled = False
        txtCodigoAFSCA.Enabled = False
        rdbExtranjero.Enabled = False
        rdbNacional.Enabled = False
        Me.Close()
    End Sub

    Private Sub txtCodigoAFSCA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoAFSCA.TextChanged
        rdbNacional.Enabled = txtCodigoAFSCA.Text.Length > 0
        rdbExtranjero.Enabled = txtCodigoAFSCA.Text.Length > 0
        If txtCodigoAFSCA.Text.Length = 0 Then
            rdbExtranjero.Checked = False
            rdbNacional.Checked = False
        End If

    End Sub
End Class

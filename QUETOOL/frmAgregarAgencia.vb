Imports MPG.DBL
Imports Oracle.DataAccess.Client

Public Class frmAgregarAgencia
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
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtAgencia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtAgencia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 92)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(64, 20)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(164, 20)
        Me.txtAgencia.TabIndex = 1
        Me.txtAgencia.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(64, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(164, 20)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAgencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 76)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Agencia"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(92, 92)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(252, 92)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(116, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar por Código"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(172, 92)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(268, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Text = "ComboBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cargar Combo"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraGrid1.Location = New System.Drawing.Point(8, 152)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(532, 316)
        Me.UltraGrid1.TabIndex = 11
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'TreeView1
        '
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(560, 384)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(180, 84)
        Me.TreeView1.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(552, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Guardar Manual"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(548, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Cargar un Registro"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Guardar con Modelo"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(548, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Borrar un Registro"
        '
        'frmAgregarAgencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 493)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "frmAgregarAgencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarAgencia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Agencia As New Agencia

    Dim Cn As New OracleConnection("User Id=quetool;Password=ketul;Data Source=quetool;enlist=false")
    Dim Ds As New DataSet
    Dim Da As New OracleDataAdapter

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Ds.Tables(0).Rows(Ds.Tables(0).Rows.Count - 1).Delete()

        Me.UltraGrid1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim T As New Temas

        T.ActualizarDataSet(Ds, "temas")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Cmd As New OracleCommand("spk_temas.sp_insert", Cn)

        Cmd.CommandType = CommandType.StoredProcedure

        Dim P As New OracleParameter("id_campania", OracleDbType.Int16)
        'P.SourceColumn = "id_campania"
        'P.SourceVersion = DataRowVersion.Original

        Cmd.Parameters.Add(P)

        P = New OracleParameter("id_tema", OracleDbType.Varchar2)
        'P.SourceColumn = "id_tema"
        'P.SourceVersion = DataRowVersion.Original
        Cmd.Parameters.Add(P)

        P = New OracleParameter("id_producto", OracleDbType.Int16)
        'P.SourceColumn = "id_producto"
        'P.SourceVersion = DataRowVersion.Original
        Cmd.Parameters.Add(P)

        P = New OracleParameter("id_material", OracleDbType.Varchar2)
        'P.SourceColumn = "id_material"
        'P.SourceVersion = DataRowVersion.Original
        Cmd.Parameters.Add(P)

        P = New OracleParameter("duracion", OracleDbType.Int16)
        'P.SourceColumn = "duracion"
        'P.SourceVersion = DataRowVersion.Original
        Cmd.Parameters.Add(P)

        Da.InsertCommand = Cmd

        Try
            Da.Update(Ds, "temas")
        Catch ex As OracleException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Dr As DataRow = Ds.Tables(0).NewRow

        Dr("id_campania") = 960
        Dr("id_tema") = "F"
        Dr("id_producto") = 2
        Dr("id_material") = Nothing

        Ds.Tables(0).Rows.Add(Dr)

        Me.UltraGrid1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub frmAgregarAgencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cmd As New OracleCommand("select * from temas where id_campania = 960", Cn)

        Da.SelectCommand = Cmd

        Da.Fill(Ds, "temas")

        Me.UltraGrid1.DataSource = Ds.Tables(0)

        '******************************************
        'Dim S As New Sistemas

        'S.Id_campania = 1

        'Me.UltraGrid1.DataSource = S.ObtenerSistemasEjercicio
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Agencia.Agencia = Val(txtAgencia.Text)
        Agencia.Nombre = txtNombre.Text

        'aca la vista finalmente captura la excepcion y muestra un mensaje
        Try
            Agencia.Agregar()

            MsgBox("Agencia Agregada")

        Catch ex As PropiedadVaciaExcepcion
            Mensajes.Mensaje(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Agencia.Agencia = txtAgencia.Text

        Agencia.BuscarPorID()

        If Agencia.Nombre = "" Then
            MsgBox("La Agencia No Existe")
        End If

        txtNombre.Text = Agencia.Nombre
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Agencia.Agencia = txtAgencia.Text
        Agencia.Nombre = txtNombre.Text

        Agencia.Modificar()

        MsgBox("Agencia Modificada")
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Agencia.Agencia = txtAgencia.Text

        Agencia.Borrar()

        MsgBox("Agencia Agregada")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ComboBox1.DataSource = Agencia.TraerTodos

        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.ValueMember = "Agencia"
    End Sub

    Private Sub PruebaSistemaEjercicio()
        Dim C As New Campaña

        Dim Dt As DataTable

        Dt = C.EjecutarSQL("select s.id_sistema, s.descripcion sistema, e.id_ejercicio, e.descripcion ejercicio from Sistemas s, ejercicios e where s.id_sistema = e.id_sistema and s.id_campania=1").Tables(0)

        Me.UltraGrid1.DataSource = Dt

        Listas.CargarTree(Me.TreeView1, Dt, "id_sistema", "sistema", "id_ejercicio", "ejercicio")
    End Sub

    Private Sub UltraGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid1.DoubleClick

    End Sub
End Class

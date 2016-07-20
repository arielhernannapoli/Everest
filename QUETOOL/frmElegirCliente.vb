Imports MSL
Imports Framework
Imports HM.MMS.AR.Client.Reportes
'LC 25/08/2014 Proveedores de Danone
Imports System.Text
Imports System.Collections.Generic

Public Class frmElegirCliente
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents txtCodigo As QUETOOL.txtTexto
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaHasta As QUETOOL.dtpFecha
    Friend WithEvents dtpFechaDesde As QUETOOL.dtpFecha
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents fraFecha As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElegirCliente))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.txtCodigo = New QUETOOL.txtTexto
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFechaHasta = New QUETOOL.dtpFecha
        Me.dtpFechaDesde = New QUETOOL.dtpFecha
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.fraFecha = New System.Windows.Forms.GroupBox
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.cmdCancelar = New System.Windows.Forms.Button
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.fraFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(88, 48)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(244, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ConDecimal = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(88, 20)
        Me.txtCodigo.Maximo = 0
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(220, 21)
        Me.txtCodigo.SoloLetra = False
        Me.txtCodigo.SoloNumero = True
        Me.txtCodigo.TabIndex = 0
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(268, 184)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 3
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdSalir
        '
        Me.cmdSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSalir.Location = New System.Drawing.Point(24, 184)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Image = CType(resources.GetObject("lblDescripcion.Image"), System.Drawing.Image)
        Me.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(311, 20)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(21, 21)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fecha Hasta"
        '
        'dtpFechaHasta
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFechaHasta.Appearance = Appearance1
        Me.dtpFechaHasta.FlatMode = True
        Me.dtpFechaHasta.Location = New System.Drawing.Point(88, 48)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(244, 21)
        Me.dtpFechaHasta.TabIndex = 1
        '
        'dtpFechaDesde
        '
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.dtpFechaDesde.Appearance = Appearance2
        Me.dtpFechaDesde.FlatMode = True
        Me.dtpFechaDesde.Location = New System.Drawing.Point(88, 20)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(244, 21)
        Me.dtpFechaDesde.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fecha Desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'fraFecha
        '
        Me.fraFecha.Controls.Add(Me.dtpFechaDesde)
        Me.fraFecha.Controls.Add(Me.Label4)
        Me.fraFecha.Controls.Add(Me.Label5)
        Me.fraFecha.Controls.Add(Me.dtpFechaHasta)
        Me.fraFecha.Location = New System.Drawing.Point(12, 96)
        Me.fraFecha.Name = "fraFecha"
        Me.fraFecha.Size = New System.Drawing.Size(344, 80)
        Me.fraFecha.TabIndex = 2
        Me.fraFecha.TabStop = False
        Me.fraFecha.Text = "Filtrar Campañas"
        '
        'chkFecha
        '
        Me.chkFecha.Checked = True
        Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFecha.Location = New System.Drawing.Point(23, 96)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(112, 16)
        Me.chkFecha.TabIndex = 1
        Me.chkFecha.Text = "Validar por Fecha"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(188, 184)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        '
        'frmElegirCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdSalir
        Me.ClientSize = New System.Drawing.Size(366, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.fraFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmElegirCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir Cliente"
        CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.fraFecha.ResumeLayout(False)
        Me.fraFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean

    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If txtCodigo.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar el Cliente")
            txtCodigo.Select()
            Exit Sub
        End If

        If IsDBNull(dtpFechaDesde.Value) Then
            Exit Sub
        End If

        If IsDBNull(dtpFechaHasta.Value) Then
            Exit Sub
        End If

        'si inicio es mayor a fin, hace fin = a inicio
        If dtpFechaDesde.Value > dtpFechaHasta.Value Then
            Mensajes.Mensaje("La Fecha Desde Debe ser Menor a la Fecha Hasta")
            dtpFechaDesde.Select()
            Exit Sub
        End If

        'si fin es menor a inicio, hace fin = inicio
        If dtpFechaHasta.Value < dtpFechaDesde.Value Then
            Mensajes.Mensaje("La Fecha Hasta Debe ser Mayor a la Fecha Desde")
            dtpFechaHasta.Select()
            Exit Sub
        End If

        Activo.IDCliente = txtCodigo.Text
        Activo.Cliente = txtDescripcion.Text


        'AG Velocidad Cache ====================================================================================
        'LC 25/08/2014 Proveedores de Danone
        'Dim OSop As New MPG.DBL.Soportes
        'Activo.DTSoportesCache = OSop.ObtenerSoportesMMSVistaMaterializada(MSL.Constantes.COD_PAIS_ARGENTINA)
        '======================================================================================================

        'Carga de DT Cache Maestros Productos ---------------------------------------------------------- 
        Dim OMsl As New Maestros

        Activo.DTProductosCache = OMsl.ProductosTraerTodos(Constantes.COD_PAIS_ARGENTINA, CInt(Activo.IDCliente))
        '-------------------------------------------------------------------------------------------------------------

        If Me.chkFecha.Checked Then
            Activo.FechaDesdeCampaña = dtpFechaDesde.Value
            Activo.FechaHastaCampaña = dtpFechaHasta.Value
        Else
            Activo.FechaDesdeCampaña = #1/1/1900#
            Activo.FechaHastaCampaña = #1/1/3200#
        End If

        Cancelar = False

        Me.Close()
    End Sub

    Private Sub BuscarCliente()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtDescripcion, txtCodigo, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click
        BuscarCliente()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Application.Exit()
    End Sub

    Private Sub txtCodigo_SePresionoBarra() Handles txtCodigo.SePresionoBarra
        BuscarCliente()
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        If txtCodigo.Text <> "" Then
            Dim C As New Clientes
            Dim U As New Usuario

            C.Id_cliente = txtCodigo.Text
            'hay que poner el usuario que entrega MMS en el activo
            'observacion D_C
            Try
                C.BuscarPorId()

                U.IDPerfil_Datos = 1 'Activo.IDPerfil_Datos
                txtDescripcion.Text = C.Descripcion 'U.ObtenerDescripcion(txtCodigo.Text)

                If txtDescripcion.Text = "" Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodigo.Text = ""
                    txtCodigo.Select()
                    Exit Sub
                End If

            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                Exit Sub
            End Try

            'txtDescripcion.Text = C.Descripcion
        End If
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If Me.chkFecha.Checked Then
            Me.fraFecha.Enabled = True
        Else
            Me.fraFecha.Enabled = False
        End If
    End Sub

    Private Sub chkFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkFecha.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub frmElegirCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaDesde.Value = Date.Today.AddMonths(-6)
        Me.dtpFechaHasta.Value = Date.Today

        'Carga de DT Cache Maestros Clientes ---------------------------------------------------------------
        Dim OMsl As New Maestros

        If Activo.DTProveedorCache Is Nothing Then
            Activo.DTProveedorCache = OMsl.ProveedorTraerTodos(MSL.Constantes.COD_PAIS_ARGENTINA)
        End If

        If Activo.DTClientesCache Is Nothing Then
            Activo.DTClientesCache = OMsl.ClientesTraerTodos(MSL.Constantes.COD_PAIS_ARGENTINA)
        End If

        '-----------------------------------------------------------------------------------------------------------------

        If CargandoPrimeraVez Then
            cmdCancelar.Visible = False

            'cmdAceptar.Left = cmdCancelar.Left
            'cmdAceptar.Top = cmdCancelar.Top
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True

        Me.Close()
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class

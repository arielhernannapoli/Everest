Public Class frmFranjas
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents iugFranjas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As QUETOOL.txtTexto
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents txtHoraHasta As QUETOOL.txtTexto
    Friend WithEvents txtHoraDesde As QUETOOL.txtTexto
    Friend WithEvents txtDescripcionFranja As QUETOOL.txtTexto
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFranja As QUETOOL.txtTexto
    Friend WithEvents txtMinDesde As QUETOOL.txtTexto
    Friend WithEvents txtMinHasta As QUETOOL.txtTexto
    Friend WithEvents cmdAgregarFranja As System.Windows.Forms.Button
    Friend WithEvents cmdModificarFranja As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFranjas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtMinHasta = New QUETOOL.txtTexto
        Me.txtMinDesde = New QUETOOL.txtTexto
        Me.txtHoraHasta = New QUETOOL.txtTexto
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHoraDesde = New QUETOOL.txtTexto
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcionFranja = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.iugFranjas = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdModificar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.txtDescripcion = New QUETOOL.txtTexto
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdModificarFranja = New System.Windows.Forms.Button
        Me.cmdAgregarFranja = New System.Windows.Forms.Button
        Me.txtCodigoFranja = New QUETOOL.txtTexto
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.cmdBorrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.iugFranjas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMinHasta)
        Me.GroupBox1.Controls.Add(Me.txtMinDesde)
        Me.GroupBox1.Controls.Add(Me.txtHoraHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtHoraDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionFranja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de franjas"
        '
        'txtMinHasta
        '
        Me.txtMinHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinHasta.ConDecimal = True
        Me.txtMinHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinHasta.Location = New System.Drawing.Point(316, 48)
        Me.txtMinHasta.Maximo = 0
        Me.txtMinHasta.MaxLength = 2
        Me.txtMinHasta.Name = "txtMinHasta"
        Me.txtMinHasta.Size = New System.Drawing.Size(48, 21)
        Me.txtMinHasta.SoloLetra = False
        Me.txtMinHasta.SoloNumero = True
        Me.txtMinHasta.TabIndex = 4
        Me.txtMinHasta.Text = ""
        '
        'txtMinDesde
        '
        Me.txtMinDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinDesde.ConDecimal = True
        Me.txtMinDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinDesde.Location = New System.Drawing.Point(140, 48)
        Me.txtMinDesde.Maximo = 0
        Me.txtMinDesde.MaxLength = 2
        Me.txtMinDesde.Name = "txtMinDesde"
        Me.txtMinDesde.Size = New System.Drawing.Size(48, 21)
        Me.txtMinDesde.SoloLetra = False
        Me.txtMinDesde.SoloNumero = True
        Me.txtMinDesde.TabIndex = 2
        Me.txtMinDesde.Text = ""
        '
        'txtHoraHasta
        '
        Me.txtHoraHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraHasta.ConDecimal = True
        Me.txtHoraHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraHasta.Location = New System.Drawing.Point(264, 48)
        Me.txtHoraHasta.Maximo = 0
        Me.txtHoraHasta.MaxLength = 2
        Me.txtHoraHasta.Name = "txtHoraHasta"
        Me.txtHoraHasta.Size = New System.Drawing.Size(48, 21)
        Me.txtHoraHasta.SoloLetra = False
        Me.txtHoraHasta.SoloNumero = True
        Me.txtHoraHasta.TabIndex = 3
        Me.txtHoraHasta.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Hora Hasta"
        '
        'txtHoraDesde
        '
        Me.txtHoraDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraDesde.ConDecimal = True
        Me.txtHoraDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraDesde.Location = New System.Drawing.Point(88, 48)
        Me.txtHoraDesde.Maximo = 0
        Me.txtHoraDesde.MaxLength = 2
        Me.txtHoraDesde.Name = "txtHoraDesde"
        Me.txtHoraDesde.Size = New System.Drawing.Size(48, 21)
        Me.txtHoraDesde.SoloLetra = False
        Me.txtHoraDesde.SoloNumero = True
        Me.txtHoraDesde.TabIndex = 1
        Me.txtHoraDesde.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Hora desde"
        '
        'txtDescripcionFranja
        '
        Me.txtDescripcionFranja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionFranja.ConDecimal = False
        Me.txtDescripcionFranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionFranja.Location = New System.Drawing.Point(88, 20)
        Me.txtDescripcionFranja.Maximo = 0
        Me.txtDescripcionFranja.MaxLength = 40
        Me.txtDescripcionFranja.Name = "txtDescripcionFranja"
        Me.txtDescripcionFranja.Size = New System.Drawing.Size(276, 21)
        Me.txtDescripcionFranja.SoloLetra = False
        Me.txtDescripcionFranja.SoloNumero = False
        Me.txtDescripcionFranja.TabIndex = 0
        Me.txtDescripcionFranja.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Descripción"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(224, 320)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(304, 320)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'iugFranjas
        '
        Me.iugFranjas.Cursor = System.Windows.Forms.Cursors.Default
        Appearance1.BackColor = System.Drawing.Color.White
        Me.iugFranjas.DisplayLayout.Appearance = Appearance1
        Me.iugFranjas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.iugFranjas.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.iugFranjas.DisplayLayout.Override.CellPadding = 3
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Me.iugFranjas.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BorderColor = System.Drawing.Color.LightGray
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.iugFranjas.DisplayLayout.Override.RowAppearance = Appearance4
        Me.iugFranjas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Appearance5.BackColor = System.Drawing.Color.LightSteelBlue
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.iugFranjas.DisplayLayout.Override.SelectedRowAppearance = Appearance5
        Me.iugFranjas.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.iugFranjas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.iugFranjas.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.iugFranjas.Location = New System.Drawing.Point(8, 204)
        Me.iugFranjas.Name = "iugFranjas"
        Me.iugFranjas.Size = New System.Drawing.Size(372, 112)
        Me.iugFranjas.TabIndex = 5
        '
        'cmdModificar
        '
        Me.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificar.Location = New System.Drawing.Point(172, 176)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(72, 23)
        Me.cmdModificar.TabIndex = 3
        Me.cmdModificar.Text = "Modificar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Location = New System.Drawing.Point(96, 176)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(72, 23)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ConDecimal = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(104, 16)
        Me.txtDescripcion.Maximo = 0
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(236, 21)
        Me.txtDescripcion.SoloLetra = False
        Me.txtDescripcion.SoloNumero = False
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Descripción"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdModificarFranja)
        Me.GroupBox2.Controls.Add(Me.cmdAgregarFranja)
        Me.GroupBox2.Controls.Add(Me.txtCodigoFranja)
        Me.GroupBox2.Controls.Add(Me.lblDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 78)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'cmdModificarFranja
        '
        Me.cmdModificarFranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModificarFranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModificarFranja.Location = New System.Drawing.Point(188, 44)
        Me.cmdModificarFranja.Name = "cmdModificarFranja"
        Me.cmdModificarFranja.Size = New System.Drawing.Size(72, 23)
        Me.cmdModificarFranja.TabIndex = 38
        Me.cmdModificarFranja.Text = "Modificar"
        '
        'cmdAgregarFranja
        '
        Me.cmdAgregarFranja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarFranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarFranja.Location = New System.Drawing.Point(104, 44)
        Me.cmdAgregarFranja.Name = "cmdAgregarFranja"
        Me.cmdAgregarFranja.Size = New System.Drawing.Size(72, 23)
        Me.cmdAgregarFranja.TabIndex = 37
        Me.cmdAgregarFranja.Text = "Agregar"
        '
        'txtCodigoFranja
        '
        Me.txtCodigoFranja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoFranja.ConDecimal = True
        Me.txtCodigoFranja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoFranja.Location = New System.Drawing.Point(72, 16)
        Me.txtCodigoFranja.Maximo = 0
        Me.txtCodigoFranja.MaxLength = 4
        Me.txtCodigoFranja.Name = "txtCodigoFranja"
        Me.txtCodigoFranja.Size = New System.Drawing.Size(24, 21)
        Me.txtCodigoFranja.SoloLetra = False
        Me.txtCodigoFranja.SoloNumero = False
        Me.txtCodigoFranja.TabIndex = 36
        Me.txtCodigoFranja.Text = ""
        Me.txtCodigoFranja.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescripcion.Image = CType(resources.GetObject("lblDescripcion.Image"), System.Drawing.Image)
        Me.lblDescripcion.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescripcion.Location = New System.Drawing.Point(344, 16)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(21, 21)
        Me.lblDescripcion.TabIndex = 35
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdBorrar
        '
        Me.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(248, 176)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(72, 23)
        Me.cmdBorrar.TabIndex = 4
        Me.cmdBorrar.Text = "Borrar"
        '
        'frmFranjas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.iugFranjas)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFranjas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Franjas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.iugFranjas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Franjas As DataTable
    Dim Modificar As Boolean = False
    Dim IndiceFilaModificada As Integer

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        If txtDescripcion.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Descripción")
            txtDescripcion.Select()
            Exit Sub
        End If

        If Me.txtDescripcionFranja.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Descripción de la Franja")
            txtDescripcionFranja.Select()
            Exit Sub
        End If

        If Me.txtHoraDesde.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Hora Desde")
            txtHoraDesde.Select()
            Exit Sub
        End If

        If Me.txtHoraHasta.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Hora Hasta")
            txtHoraHasta.Select()
            Exit Sub
        End If

        If Val(txtHoraDesde.Text & txtMinDesde.Text) > 3000 Or Val(txtHoraDesde.Text & txtMinDesde.Text) < 600 Then
            Mensajes.Mensaje(txtHoraDesde.Text & ":" & txtMinDesde.Text & " No es una hora válida, el rango de horas va de 0600 a 3000")
            txtHoraDesde.Select()
            Exit Sub
        End If

        If Val(txtHoraHasta.Text & txtMinHasta.Text) > 3000 Or Val(txtHoraHasta.Text & txtMinHasta.Text) < 600 Then
            Mensajes.Mensaje(txtHoraHasta.Text & ":" & txtMinHasta.Text & " No es una hora válida, el rango de horas va de 0600 a 3000")
            txtHoraHasta.Select()
            Exit Sub
        End If

        Dim Dr As DataRow

        If Not Modificar Then
            'NUEVO
            Dr = Franjas.NewRow

            If Franjas.Rows.Count > 0 Then
                Dr("id_franja_item") = Franjas.Rows(Franjas.Rows.Count - 1)("id_franja_item") + 1
            Else
                Dr("id_franja_item") = 1
            End If

            Dr("id_franja") = Me.txtCodigoFranja.Text
            Dr("descripcion") = Me.txtDescripcionFranja.Text

            Dr("h_desde") = Me.txtHoraDesde.Text
            Dr("m_desde") = Me.txtMinDesde.Text

            Dr("h_hasta") = Me.txtHoraHasta.Text
            Dr("m_hasta") = Me.txtMinHasta.Text

            Dr("HoraDesde") = Me.txtHoraDesde.Text & Me.txtMinDesde.Text
            Dr("HoraHasta") = Me.txtHoraHasta.Text & Me.txtMinHasta.Text

            Franjas.Rows.Add(Dr)
        Else
            'MODIFICAR
            Dr = Franjas.Select("id_franja_item =" & Me.txtDescripcionFranja.Tag)(0)

            Dr("descripcion") = Me.txtDescripcionFranja.Text

            Dr("h_desde") = Me.txtHoraDesde.Text
            Dr("m_desde") = Me.txtMinDesde.Text

            Dr("h_hasta") = Me.txtHoraHasta.Text
            Dr("m_hasta") = Me.txtMinHasta.Text

            Dr("HoraDesde") = Me.txtHoraDesde.Text & Me.txtMinDesde.Text
            Dr("HoraHasta") = Me.txtHoraHasta.Text & Me.txtMinHasta.Text

            Me.iugFranjas.Rows(Me.IndiceFilaModificada).Hidden = False

            Me.Modificar = False
        End If

        Me.txtDescripcionFranja.Text = ""
        Me.txtHoraDesde.Text = ""
        Me.txtMinDesde.Text = ""
        Me.txtHoraHasta.Text = ""
        Me.txtMinHasta.Text = ""

        Me.CargarGrillla()
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        If Me.iugFranjas.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim Dr As DataRow

        Me.txtDescripcionFranja.Tag = Me.iugFranjas.ActiveRow.Cells("id_franja_item").Value

        Dr = Franjas.Select("id_franja_item =" & Me.iugFranjas.ActiveRow.Cells("id_franja_item").Value)(0)

        Me.txtDescripcionFranja.Tag = Dr("id_franja_item")
        Me.txtDescripcionFranja.Text = Dr("descripcion")
        Me.txtHoraDesde.Text = Format(Dr("h_desde"), "00")
        Me.txtMinDesde.Text = Format(Dr("m_desde"), "00")
        Me.txtHoraHasta.Text = Format(Dr("h_hasta"), "00")
        Me.txtMinHasta.Text = Format(Dr("m_hasta"), "00")

        Me.IndiceFilaModificada = Me.iugFranjas.ActiveRow.Index

        Me.iugFranjas.Selected.Rows(0).Hidden = True

        Modificar = True
    End Sub

    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If Me.iugFranjas.Selected.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim Dr As DataRow

        Dr = Franjas.Select("id_franja_item =" & Me.iugFranjas.Selected.Rows(0).Cells("id_franja_item").Text)(0)

        Dr.Delete()

        Me.CargarGrillla()
    End Sub

    Private Sub lblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescripcion.Click
        Me.BuscarFranja()
    End Sub

    Private Sub BuscarFranja()
        Dim B As New frmBuscar

        B.CargarFormulario(SeccionActiva.Franja, Me.txtDescripcion, Me.txtCodigoFranja _
         , "id_franja", "descripcion", "Código", "Franja")

        B.ShowDialog()

        If txtDescripcion.Text = "" Then
            Exit Sub
        End If

        Dim F As New Franjas_Detalle

        Me.Franjas = F.BuscarFranjasDetalle(txtCodigoFranja.Text)

        Me.ModificarDataTable()

        Me.iugFranjas.DataSource = Me.Franjas

        Me.txtDescripcionFranja.Select()
    End Sub

    Private Sub frmFranjas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim F As New Franjas_Detalle

        F.ObtenerEsquema(Franjas)

        Me.ModificarDataTable()

        Me.CargarGrillla()
    End Sub

    Private Sub ModificarDataTable()
        Me.Franjas.Columns.Add("HoraDesde", GetType(String))
        Me.Franjas.Columns.Add("HoraHasta", GetType(String))

        For Each Dr As DataRow In Me.Franjas.Rows
            Dr("HoraDesde") = Format(Dr("h_desde"), "00") & Format(Dr("m_desde"), "00")
            Dr("HoraHasta") = Format(Dr("h_hasta"), "00") & Format(Dr("m_hasta"), "00")

            Dr.AcceptChanges()
        Next
    End Sub

    Private Sub CargarGrillla()
        Me.iugFranjas.DataSource = Franjas

        Listas.OcultarColumnas(Me.iugFranjas, "id_franja", "id_franja_item", "h_desde", "m_desde", "h_hasta", "m_hasta")

        Listas.CambiarTituloColumna(Me.iugFranjas, "descripcion", "Descripción")
        Listas.CambiarTituloColumna(Me.iugFranjas, "HoraDesde", "Hora Desde")
        Listas.CambiarTituloColumna(Me.iugFranjas, "HoraHasta", "Hora Hasta")

        Dim Gf As New GrillaFormato

        Gf.HabilitarEdicionColumna(Me.iugFranjas, Infragistics.Win.UltraWinGrid.Activation.NoEdit)
        Me.iugFranjas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

        'ajusta el ancho de las columnas al de los datos
        With Me.iugFranjas
            .DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns

            .DisplayLayout.Bands(0).Columns(0).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(1).PerformAutoResize()
            .DisplayLayout.Bands(0).Columns(2).PerformAutoResize()
        End With
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click


        If Me.iugFranjas.Rows.Count = 0 Then
            MsgBox("Falta Completar el detalle de la franja: " & Me.txtDescripcion.Text, MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim F As New Franjas_Detalle
        Dim Ds As DataSet



        If Me.Franjas.DataSet Is Nothing Then
            Ds = New DataSet

            Ds.Tables.Add(Me.Franjas)
        End If

        F.ActualizarDataSet(Me.Franjas.DataSet, Me.Franjas.TableName)

        Me.Cursor = Cursors.Default

        Me.Close()

        frmPrincipal.Instancia.ActualizarFranjasEnSistema()
    End Sub

    Private Sub txtHoraDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraDesde.TextChanged
        If txtHoraDesde.Text.Length = 2 Then
            txtMinDesde.Select()
        End If
    End Sub

    Private Sub txtHoraHasta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHoraHasta.TextChanged
        If txtHoraHasta.Text.Length = 2 Then
            txtMinHasta.Select()
        End If
    End Sub

    Private Sub txtMinDesde_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinDesde.TextChanged
        If txtMinDesde.Text.Length = 2 Then
            txtHoraHasta.Select()
        End If
    End Sub

    Private Sub cmdAgregarFranja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarFranja.Click
        Me.GuardarFranjaEncabezado(False)
    End Sub

    Private Sub cmdModificarFranja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificarFranja.Click
        Me.GuardarFranjaEncabezado(True)
    End Sub

    Private Sub GuardarFranjaEncabezado(ByVal Modificar As Boolean)
        If txtDescripcion.Text = "" Then
            Mensajes.Mensaje("Debe Ingresar la Descripción", TipoMensaje.Informacion)
            txtDescripcion.Select()
            Exit Sub
        End If

        Dim F As New Franjas

        F.Id_franja = Val(txtCodigoFranja.Text)
        F.Descripcion = txtDescripcion.Text
        F.Id_cliente = Activo.IDCliente

        If Not Modificar Then
            'NUEVA

            'agrega la franja y guarda el nuevo ID en el text del codigo
            txtCodigoFranja.Text = F.Agregar()
        Else
            'MODIFICA
            F.Modificar()
        End If

        Mensajes.Mensaje("La Franja Fue Guardada", TipoMensaje.Informacion)

        Me.txtDescripcionFranja.Select()
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltrarSoporteInternet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdBuscar = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdQuitarTodos = New System.Windows.Forms.Button
        Me.cmdAgregarTodos = New System.Windows.Forms.Button
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdQuitar = New System.Windows.Forms.Button
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.lstSoportesSeleccionados = New System.Windows.Forms.ListBox
        Me.cboTipoSoporte = New QUETOOL.cboCombo
        Me.Label21 = New System.Windows.Forms.Label
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdBuscar
        '
        Me.grdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdBuscar.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdBuscar.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.grdBuscar.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdBuscar.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdBuscar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdBuscar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdBuscar.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdBuscar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdBuscar.FlatMode = True
        Me.grdBuscar.Location = New System.Drawing.Point(15, 90)
        Me.grdBuscar.Name = "grdBuscar"
        Me.grdBuscar.Size = New System.Drawing.Size(300, 275)
        Me.grdBuscar.TabIndex = 24
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(15, 62)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(300, 20)
        Me.txtBuscar.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Soportes Seleccionados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Soportes"
        '
        'cmdQuitarTodos
        '
        Me.cmdQuitarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitarTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitarTodos.Location = New System.Drawing.Point(323, 255)
        Me.cmdQuitarTodos.Name = "cmdQuitarTodos"
        Me.cmdQuitarTodos.Size = New System.Drawing.Size(37, 38)
        Me.cmdQuitarTodos.TabIndex = 18
        Me.cmdQuitarTodos.Text = "7"
        '
        'cmdAgregarTodos
        '
        Me.cmdAgregarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregarTodos.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregarTodos.Location = New System.Drawing.Point(323, 167)
        Me.cmdAgregarTodos.Name = "cmdAgregarTodos"
        Me.cmdAgregarTodos.Size = New System.Drawing.Size(37, 38)
        Me.cmdAgregarTodos.TabIndex = 15
        Me.cmdAgregarTodos.Text = "8"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(455, 383)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 19
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(546, 383)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 20
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(13, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 2)
        Me.Label1.TabIndex = 16
        '
        'cmdQuitar
        '
        Me.cmdQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuitar.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdQuitar.Location = New System.Drawing.Point(323, 211)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(37, 38)
        Me.cmdQuitar.TabIndex = 17
        Me.cmdQuitar.Text = "3"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAgregar.Font = New System.Drawing.Font("Webdings", 15.75!)
        Me.cmdAgregar.Location = New System.Drawing.Point(323, 123)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(37, 38)
        Me.cmdAgregar.TabIndex = 14
        Me.cmdAgregar.Text = "4"
        '
        'lstSoportesSeleccionados
        '
        Me.lstSoportesSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSoportesSeleccionados.Location = New System.Drawing.Point(368, 25)
        Me.lstSoportesSeleccionados.Name = "lstSoportesSeleccionados"
        Me.lstSoportesSeleccionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSoportesSeleccionados.Size = New System.Drawing.Size(270, 340)
        Me.lstSoportesSeleccionados.TabIndex = 13
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboTipoSoporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTipoSoporte.DisplayMember = ""
        Me.cboTipoSoporte.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboTipoSoporte.Enabled = False
        Me.cboTipoSoporte.FlatMode = True
        Me.cboTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoSoporte.Location = New System.Drawing.Point(90, 12)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(225, 21)
        Me.cboTipoSoporte.TabIndex = 37
        Me.cboTipoSoporte.Tag = "Tipo de Soporte del Sistema"
        Me.cboTipoSoporte.ValueMember = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Tipo Soporte"
        '
        'frmFiltrarSoporteInternet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 416)
        Me.Controls.Add(Me.cboTipoSoporte)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.grdBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdQuitarTodos)
        Me.Controls.Add(Me.cmdAgregarTodos)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdQuitar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.lstSoportesSeleccionados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFiltrarSoporteInternet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elegir Soporte"
        CType(Me.grdBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdBuscar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdQuitarTodos As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarTodos As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lstSoportesSeleccionados As System.Windows.Forms.ListBox
    Friend WithEvents cboTipoSoporte As QUETOOL.cboCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class


Imports Microsoft.Office.Interop
Imports System.Collections.Generic
Public Class frmConsultaConvenio
    Inherits System.Windows.Forms.Form
    Dim ID_Medio As Integer
    Dim Medio As String
    Friend WithEvents CBoxExConvenios As System.Windows.Forms.CheckBox
    Dim idTipo As Integer
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents txtCliente As QUETOOL.txtTexto
    Friend WithEvents lblDesCliente As System.Windows.Forms.Label
    Friend WithEvents txtCodSoporte As QUETOOL.txtTexto
    Friend WithEvents txtCodCliente As QUETOOL.txtTexto
    Friend WithEvents lblDesSoporte As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboVigente As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTipoMedio As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoSoporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCodProducto As QUETOOL.txtTexto
    Friend WithEvents lblDescProducto As System.Windows.Forms.Label
    Friend WithEvents TxtProducto As QUETOOL.txtTexto
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaConvenio))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.txtCliente = New QUETOOL.txtTexto
        Me.lblDesCliente = New System.Windows.Forms.Label
        Me.lblDesSoporte = New System.Windows.Forms.Label
        Me.txtCodSoporte = New QUETOOL.txtTexto
        Me.txtCodCliente = New QUETOOL.txtTexto
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboVigente = New System.Windows.Forms.ComboBox
        Me.cboTipoSoporte = New System.Windows.Forms.ComboBox
        Me.cboTipoMedio = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCodProducto = New QUETOOL.txtTexto
        Me.lblDescProducto = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtProducto = New QUETOOL.txtTexto
        Me.CBoxExConvenios = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Soporte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cliente"
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(128, 104)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(208, 20)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 0
        Me.TxtSoporte.TabStop = False
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.ConDecimal = False
        Me.txtCliente.Location = New System.Drawing.Point(128, 8)
        Me.txtCliente.Maximo = 0
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(208, 20)
        Me.txtCliente.SoloLetra = False
        Me.txtCliente.SoloNumero = False
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.TabStop = False
        '
        'lblDesCliente
        '
        Me.lblDesCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesCliente.Image = CType(resources.GetObject("lblDesCliente.Image"), System.Drawing.Image)
        Me.lblDesCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesCliente.Location = New System.Drawing.Point(344, 8)
        Me.lblDesCliente.Name = "lblDesCliente"
        Me.lblDesCliente.Size = New System.Drawing.Size(21, 21)
        Me.lblDesCliente.TabIndex = 1
        Me.lblDesCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDesSoporte
        '
        Me.lblDesSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesSoporte.Image = CType(resources.GetObject("lblDesSoporte.Image"), System.Drawing.Image)
        Me.lblDesSoporte.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesSoporte.Location = New System.Drawing.Point(344, 104)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 7
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodSoporte
        '
        Me.txtCodSoporte.AcceptsReturn = True
        Me.txtCodSoporte.AcceptsTab = True
        Me.txtCodSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSoporte.ConDecimal = False
        Me.txtCodSoporte.Location = New System.Drawing.Point(80, 104)
        Me.txtCodSoporte.Maximo = 0
        Me.txtCodSoporte.Name = "txtCodSoporte"
        Me.txtCodSoporte.Size = New System.Drawing.Size(40, 20)
        Me.txtCodSoporte.SoloLetra = False
        Me.txtCodSoporte.SoloNumero = True
        Me.txtCodSoporte.TabIndex = 6
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.AcceptsTab = True
        Me.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCliente.ConDecimal = False
        Me.txtCodCliente.Location = New System.Drawing.Point(80, 8)
        Me.txtCodCliente.Maximo = 0
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.SoloLetra = False
        Me.txtCodCliente.SoloNumero = True
        Me.txtCodCliente.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 81
        Me.Label25.Text = "Medio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Vigente"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(200, 176)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(288, 176)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(-128, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(564, 2)
        Me.Label4.TabIndex = 85
        '
        'cboVigente
        '
        Me.cboVigente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVigente.ItemHeight = 13
        Me.cboVigente.Items.AddRange(New Object() {"Si", "No", "Todos"})
        Me.cboVigente.Location = New System.Drawing.Point(80, 128)
        Me.cboVigente.Name = "cboVigente"
        Me.cboVigente.Size = New System.Drawing.Size(72, 21)
        Me.cboVigente.TabIndex = 8
        '
        'cboTipoSoporte
        '
        Me.cboTipoSoporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoSoporte.Location = New System.Drawing.Point(80, 80)
        Me.cboTipoSoporte.Name = "cboTipoSoporte"
        Me.cboTipoSoporte.Size = New System.Drawing.Size(256, 21)
        Me.cboTipoSoporte.TabIndex = 5
        '
        'cboTipoMedio
        '
        Me.cboTipoMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMedio.Location = New System.Drawing.Point(80, 56)
        Me.cboTipoMedio.Name = "cboTipoMedio"
        Me.cboTipoMedio.Size = New System.Drawing.Size(256, 21)
        Me.cboTipoMedio.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Tipo Soporte"
        '
        'TxtCodProducto
        '
        Me.TxtCodProducto.AcceptsReturn = True
        Me.TxtCodProducto.AcceptsTab = True
        Me.TxtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodProducto.ConDecimal = False
        Me.TxtCodProducto.Location = New System.Drawing.Point(80, 32)
        Me.TxtCodProducto.Maximo = 0
        Me.TxtCodProducto.Name = "TxtCodProducto"
        Me.TxtCodProducto.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodProducto.SoloLetra = False
        Me.TxtCodProducto.SoloNumero = True
        Me.TxtCodProducto.TabIndex = 2
        '
        'lblDescProducto
        '
        Me.lblDescProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescProducto.Image = CType(resources.GetObject("lblDescProducto.Image"), System.Drawing.Image)
        Me.lblDescProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescProducto.Location = New System.Drawing.Point(344, 32)
        Me.lblDescProducto.Name = "lblDescProducto"
        Me.lblDescProducto.Size = New System.Drawing.Size(21, 21)
        Me.lblDescProducto.TabIndex = 3
        Me.lblDescProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Producto"
        '
        'TxtProducto
        '
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.ConDecimal = False
        Me.TxtProducto.Location = New System.Drawing.Point(128, 32)
        Me.TxtProducto.Maximo = 0
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.ReadOnly = True
        Me.TxtProducto.Size = New System.Drawing.Size(208, 20)
        Me.TxtProducto.SoloLetra = False
        Me.TxtProducto.SoloNumero = False
        Me.TxtProducto.TabIndex = 0
        Me.TxtProducto.TabStop = False
        '
        'CBoxExConvenios
        '
        Me.CBoxExConvenios.AutoSize = True
        Me.CBoxExConvenios.Location = New System.Drawing.Point(217, 135)
        Me.CBoxExConvenios.Name = "CBoxExConvenios"
        Me.CBoxExConvenios.Size = New System.Drawing.Size(118, 17)
        Me.CBoxExConvenios.TabIndex = 93
        Me.CBoxExConvenios.Text = "Exportar Convenios"
        Me.CBoxExConvenios.UseVisualStyleBackColor = True
        Me.CBoxExConvenios.Visible = False
        '
        'frmConsultaConvenio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(370, 207)
        Me.Controls.Add(Me.CBoxExConvenios)
        Me.Controls.Add(Me.TxtCodProducto)
        Me.Controls.Add(Me.lblDescProducto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.cboTipoMedio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboTipoSoporte)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboVigente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtCodSoporte)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.lblDesSoporte)
        Me.Controls.Add(Me.lblDesCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSoporte)
        Me.Controls.Add(Me.txtCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaConvenio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Convenios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Declaro los Objetos del Excel"


    Dim WithEvents EventoExcel As Excel.Application
    Dim OLibroExcel As Excel.Workbook ' Creamos un objeto WorkBook 
    Dim OHojaExcel As Excel.Worksheet 'Creamos un objeto WorkSheet
    Dim DtTipoSoportes As DataTable

#End Region

#Region "Metodos"
    Private Sub BuscarMedio()
        Dim M As New Soportes
        Listas.CargarCombo(Me.cboTipoMedio, M.ObtenerMedios, "ID_MEDIO", "DESCRIPCION", True)
    End Sub
    Private Sub BuscarTipoSoporte()
        Dim t As New Tipos_soporte
        t.Id_medio = ID_Medio
        Listas.CargarCombo(Me.cboTipoSoporte, t.TraerTipoSoporteMedio, "ID_TIPO_SOPORTE", "DESCRIPCION", True)
    End Sub
    Private Sub BuscarCliente()
        Dim F As New frmBuscar

        F.CargarFormulario(SeccionActiva.Cliente, txtCliente, txtCodCliente, "id_cliente", "descripcion", "Código", "Cliente")

        F.ShowDialog()
    End Sub
    Private Sub BuscarSoprote()
        Dim F As New frmBuscar
        If Not cboTipoSoporte.SelectedItem Is Nothing Then
            F.CargarFormulario(SeccionActiva.SoportesConvenios, TxtSoporte, txtCodSoporte, "id_soporte", "descripcion", "Código", "Soporte", ID_Medio, CType(cboTipoSoporte.SelectedItem, ItemLista).ID)
        Else
            F.CargarFormulario(SeccionActiva.SoportesConvenios, TxtSoporte, txtCodSoporte, "id_soporte", "descripcion", "Código", "Soporte", ID_Medio)
        End If

        F.ShowDialog()
    End Sub
    Private Sub BuscarProducto()

        'AG 04/11/2010 Nuevo ---------------------------------------------------------
        If txtCodCliente.Text.Trim = "" Then
        Else
            Dim F As New frmBuscar
            F.CargarFormulario(SeccionActiva.Producto, TxtProducto, TxtCodProducto, "id_producto", "descripcion", "Código", "Producto", txtCodCliente.Text.Trim)
            F.ShowDialog()
        End If

        'AG 04/11/2010 Original -------------------------
        'Dim F As New frmBuscar
        'F.CargarFormulario(SeccionActiva.Producto, TxtProducto, TxtCodProducto, "id_producto", "descripcion", "Código", "Producto", txtCodCliente.Text.Trim)
        'F.ShowDialog()
        '-------------------------------------------------------
    End Sub
    Function ResolverTipoListado() As TipoListado
        Dim Ret As New TipoListado
        Dim Vigente As Boolean = IIf(cboVigente.Text = "Si", True, False)

        If Me.txtCodCliente.Text.Trim <> "" Then 'Si Selecciona un CLIENTE
            If Me.cboTipoMedio.SelectedIndex = 0 Then 'Si NO Sielecion Tipo MEDIO
                If cboTipoSoporte.SelectedIndex = -1 Then 'Si no SEleccion TIPO SOPORTE
                    If txtCodSoporte.Text.Trim = "" Then ' Si NO seleciona Soporte
                        If Vigente Then ' IMPROME SOLO CLIENTE
                            Ret = TipoListado.ClienteVig
                        Else
                            Ret = TipoListado.ClienteNoVig
                        End If
                    Else ' Si lececiono SOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioTipoSoporteVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoSoporteNoVig
                        End If
                    End If
                Else ' SI SELECCION TIPO SOPROTE
                    If txtCodSoporte.Text.Trim = "" Then ' Si NO seleciona Soporte
                        If Vigente Then ' IMPROME SOLO CLIENTE
                            Ret = TipoListado.ClienteMedioTipoVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoVig
                        End If
                    Else ' Si lececiono SOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioTipoSoporteVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoSoporteNoVig
                        End If
                    End If
                End If
            Else 'SI SELECION TIPO DE MEDIO
                If cboTipoSoporte.SelectedIndex = -1 Then ' SI NO SELECION TIPO SOPORTE
                    If txtCodSoporte.Text.Trim = "" Then ' SI NO SELECION SOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioVig
                        Else
                            Ret = TipoListado.ClienteMedioNoVig
                        End If
                    Else ' SI LECCIONA SOPOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioTipoSoporteVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoSoporteNoVig
                        End If
                    End If
                Else ' SI SELECION TIPO SOPORTE
                    If txtCodSoporte.Text.Trim = "" Then ' SI NO SELECION SOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioTipoVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoNoVig
                        End If
                    Else ' SI LECCIONA SOPOPORTE
                        If Vigente Then
                            Ret = TipoListado.ClienteMedioTipoSoporteVig
                        Else
                            Ret = TipoListado.ClienteMedioTipoSoporteNoVig
                        End If
                    End If
                End If

            End If
        Else ' SI NO SELECION CLIENTE
            If Me.cboTipoMedio.Text.Trim <> "" Then ' SI SELECION TIPO MEDIO
                If cboTipoSoporte.SelectedIndex = -1 Then 'SI NO SELECION TIPO SOPROTE
                    If txtCodSoporte.Text.Trim = "" Then ' SI NO SELECION SOPORTE
                        If Vigente Then
                            Ret = TipoListado.MedioVig
                        Else
                            Ret = TipoListado.MedioNoVig
                        End If
                    Else ' SI SELECIONO SOPORTE
                        If Vigente Then
                            Ret = TipoListado.MedioTipoSoporteVig
                        Else
                            Ret = TipoListado.MedioTipoSoporteNoVig
                        End If
                    End If
                Else ' SI SELECIONA TIPO MEDIO
                    If txtCodSoporte.Text.Trim = "" Then ' SI NO SELECION SOPORTE
                        If Vigente Then
                            Ret = TipoListado.MedioTipoVig
                        Else
                            Ret = TipoListado.MedioTipoNoVig
                        End If
                    Else ' SI SELECIONO SOPORTE
                        If Vigente Then
                            Ret = TipoListado.MedioTipoSoporteVig
                        Else
                            Ret = TipoListado.MedioTipoSoporteVig
                        End If
                    End If

                End If

            End If
        End If

        Return Ret
    End Function
#End Region

#Region "Eventos"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim c As New Convenios
        Dim f As New frmFormulaOne
        Dim Vigencia As Integer
        Dim TipoMedio As Integer
        Dim Producto As Integer = -1
        Dim Convenios As DataTable
        Dim MostrarReporte As Boolean

        'AG 04/11/2010 Nuevo ----------------------------------------------------------------
        If txtCodCliente.Text = "" Then
            c.Id_cliente = -2
        Else
            c.Id_cliente = IIf(txtCodCliente.Text = "", -1, Val(txtCodCliente.Text))
        End If
        '---------------------------------------------------------------------------------------------

        c.Id_medio = ID_Medio
        c.Id_soporte = IIf(Me.txtCodSoporte.Text = "", -1, Val(Me.txtCodSoporte.Text))
        Select Case cboVigente.Text
            Case "No"
                Vigencia = 0
            Case "Si"
                Vigencia = 1
            Case "Todos"
                Vigencia = 2
        End Select
        If Me.idTipo = 0 Then
            TipoMedio = -1
        Else
            'AG 07/09/2011 +++++++++++++++++
            If Me.idTipo <> -1 Then
                Me.idTipo = CType(cboTipoSoporte.SelectedItem, ItemLista).ID
            End If
            '+++++++++++++++++
            TipoMedio = Me.idTipo
        End If
        If TxtCodProducto.Text.Trim <> String.Empty Then
            Producto = TxtCodProducto.Text.Trim
        End If
        'AG 30/04/2013 Codigo Anterior ================================================
        'Convenios = c.ObtenerConvenios(Vigencia, TipoMedio, Producto')
        '=============================================================================

        Convenios = c.ObtenerConveniosListar(Vigencia, TipoMedio, Producto)

        If Convenios Is Nothing OrElse Convenios.Rows.Count = 0 Then
            MsgBox("No se Encontraron Convenios para los Criterios de Busqueda Establecidos", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim ConveniosCliente As DataTable = Convenios.Clone
        If txtCodCliente.Text.Trim = String.Empty Then
            Dim IdClienteConvenio As Integer
            Dim ClienteConvenio As String
            Dim U As New Usuario

            For Each drConvenios As DataRow In Convenios.Rows
                IdClienteConvenio = drConvenios("Id_Cliente")
                If IdClienteConvenio <> 3 Then
                    U.IDPerfil_Datos = Activo.IDPerfil_Datos
                    ClienteConvenio = U.ObtenerDescripcion(IdClienteConvenio)
                    If ClienteConvenio <> String.Empty Then
                        ConveniosCliente.ImportRow(drConvenios)
                    End If
                Else
                    ConveniosCliente.ImportRow(drConvenios)
                End If
            Next

            If ConveniosCliente Is Nothing OrElse ConveniosCliente.Rows.Count = 0 Then
                MsgBox("No se Encontraron Convenios para los Criterios de Busqueda Establecidos", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        'JJP Soportes en convenios
        Dim idSoporteconvenio, idMedio, idTipoSoporte As Integer
        Dim drAux As DataRow()

        Me.Cursor = Cursors.WaitCursor
        If txtCodCliente.Text.Trim = String.Empty Then
            ConveniosCliente.Columns.Add("DES_SOPORTE", GetType(String))
            For Each drConvenios As DataRow In ConveniosCliente.Rows
                'JJP Soportes en convenios
                idSoporteconvenio = drConvenios("COD_SOPORTE")
                idMedio = drConvenios("ID_MEDIO")

                'Búsqueda del soporte en cache
                drAux = Activo.DTSoportesCache.Select("id_medio = " & idMedio & " and id_soporte = " & idSoporteconvenio)

                If Not drAux Is Nothing AndAlso drAux.Count = 1 Then
                    drConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                ElseIf Not drAux Is Nothing AndAlso drAux.Count > 1 Then
                    drConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                Else 'No encontró el soporte o hay múltiples coincidencias
                    drConvenios("DES_SOPORTE") = "Soporte " & idSoporteconvenio & " no cargado en MMS"
                End If
            Next
            MostrarReporte = f.ReporteConvenios(Activo.CodCapacidad, ConveniosCliente, ResolverTipoListado, Vigencia, IIf(Activo.IDPerfil_Datos = 1, True, False))
        Else
            Convenios.Columns.Add("DES_SOPORTE", GetType(String))
            For Each drConvenios As DataRow In Convenios.Rows
                'JJP Soportes en convenios
                idSoporteconvenio = drConvenios("COD_SOPORTE")
                idMedio = drConvenios("ID_MEDIO")

                'Búsqueda del soporte en cache 
                drAux = Activo.DTSoportesCache.Select("id_medio = " & idMedio & " and id_soporte = " & idSoporteconvenio)

                If Not drAux Is Nothing AndAlso drAux.Count = 1 Then
                    drConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                ElseIf Not drAux Is Nothing AndAlso drAux.Count > 1 Then
                    drConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                Else 'No encontró el soporte o hay múltiples coincidencias
                    drConvenios("DES_SOPORTE") = "Soporte " & idSoporteconvenio & " no cargado en MMS"
                End If
            Next

            MostrarReporte = f.ReporteConvenios(Activo.CodCapacidad, Convenios, ResolverTipoListado, Vigencia, IIf(Activo.IDPerfil_Datos = 1, True, False))
        End If
        Me.Cursor = Cursors.Default
        If MostrarReporte Then
            f.Show()
        Else
            f.Show()
            'Mensajes.Mensaje("El usuario No tiene Permisos para Ver Convenios", TipoMensaje.Informacion)
            'Exit Sub
        End If

        'AG 05/11/2010 ----------------------------------------------------------------------------
        If Me.CBoxExConvenios.Checked = True Then
            Dim scd As New SaveFileDialog
            Dim NombreExcel As String
            Dim ExcelPrimerFila() As String
            Dim FilaColumnas() As String
            Dim Columnas As String
            Dim i As Integer
            Dim TamañoColumna As Integer

            'Ejecuto Consulta con registro de Convenios ------------------------------------------------------------------------------------------------------------------------------------------------------------
            Dim DtExConvenios As New DataTable
            DtExConvenios = c.ObtenerConveniosExportar(Vigencia, TipoMedio, Producto)

            DtExConvenios.Columns.Add("DES_SOPORTE", GetType(String))

            For Each DrExConvenios As DataRow In DtExConvenios.Rows
                'Búsqueda del soporte en cache
                drAux = Activo.DTSoportesCache.Select("id_medio = " & DrExConvenios("ID_MEDIO") & " and id_soporte = " & DrExConvenios("COD_SOPORTE"))

                If Not drAux Is Nothing AndAlso drAux.Count = 1 Then
                    DrExConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                ElseIf Not drAux Is Nothing AndAlso drAux.Count > 1 Then
                    DrExConvenios("DES_SOPORTE") = drAux(0)("DESCRIPCION").ToString
                End If
            Next


            If DtExConvenios.Rows.Count > 0 Then
                scd.Title = "Pantalla de Exportador de Convenios "
                scd.Filter = "Microsoft Excel (*.xls)|*.xls"
                scd.ShowDialog()
                If scd.FileName.Trim = "" Then
                    Mensajes.Mensaje("La Exportacion de los Convenios, no se Realizo debido a que no ingreso el nombre del Archivo. Debe Volver a Generarlo", TipoMensaje.Informacion)
                    Exit Sub
                End If
                NombreExcel = scd.FileName
                GenerarEstructuraExcel()

                Dim OColor As New Color
                Dim ORango As Excel.Range

                'Armor y Cargo Los nombres de las columnas ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                'Columnas = "A1:A1-Cod.Convenio Interno|B1:B1-Cod.Convenio|C1:C1-Tipo Convenio|D1:D1-Cod.Medio|E1:E1-Tipo Soporte|F1:F1-Cod.Soporte|G1:G1-Cod.Cliente|H1:H1-Cliente|I1:I1-Detalle|J1:J1-Participacion|K1:K1-Programa|L1:L1-Semana|M1:M1-Fecha Inicio|N1:N1-Fecha Fin|O1:O1-Desc.Venta 1|P1:P1-Desc.Venta 2|Q1:Q1-Desc.Venta 3|R1:R1-Desc.Venta 4|S1:S1-Desc.Venta 5|T1:T1-Desc.Compra 1|U1:U1-Desc.Compra 2|V1:V1-Desc.Compra 3|W1:W1-Desc.Compra 4|X1:X1-Desc.Compra 5|Y1:Y1-Desc.Extra 1|Z1:Z1-Desc.Extra 2|AA1:AA1-Importe Venta|AB1:AB1-Importe Compra|AC1:AC1-Cod.Producto|AD1:AD1-Producto|AE1:AE1-Soporte"
                'Columnas = "A1:A1-Cod.Convenio Interno|B1:B1-Cod.Convenio|C1:C1-Tipo Convenio|D1:D1-Cod.Medio|E1:E1-Tipo Soporte|F1:F1-Desc.Soporte|G1:G1-Cod.Cliente|H1:H1-Cliente|I1:I1-Detalle|J1:J1-Participacion|K1:K1-Programa|L1:L1-Semana|M1:M1-Fecha Inicio|N1:N1-Fecha Fin|O1:O1-Desc.Venta 1|P1:P1-Desc.Venta 2|Q1:Q1-Desc.Venta 3|R1:R1-Desc.Venta 4|S1:S1-Desc.Venta 5|T1:T1-Desc.Compra 1|U1:U1-Desc.Compra 2|V1:V1-Desc.Compra 3|W1:W1-Desc.Compra 4|X1:X1-Desc.Compra 5|Y1:Y1-Desc.Extra 1|Z1:Z1-Desc.Extra 2|AA1:AA1-Importe Venta|AB1:AB1-Importe Compra|AC1:AC1-Cod.Producto|AD1:AD1-Producto"

                'JJP Se agrega las observaciones del convenio
                Columnas = "A1:A1-Cod.Convenio Interno|B1:B1-Cod.Convenio|C1:C1-Tipo Convenio|D1:D1-Cod.Medio|E1:E1-Tipo Soporte|F1:F1-Cod.Soporte|G1:G1-Cod.Cliente|H1:H1-Cliente|I1:I1-Detalle|J1:J1-Participacion|K1:K1-Programa|L1:L1-Semana|M1:M1-Fecha Inicio|N1:N1-Fecha Fin|O1:O1-Desc.Venta 1|P1:P1-Desc.Venta 2|Q1:Q1-Desc.Venta 3|R1:R1-Desc.Venta 4|S1:S1-Desc.Venta 5|T1:T1-Desc.Compra 1|U1:U1-Desc.Compra 2|V1:V1-Desc.Compra 3|W1:W1-Desc.Compra 4|X1:X1-Desc.Compra 5|Y1:Y1-Desc.Extra 1|Z1:Z1-Desc.Extra 2|AA1:AA1-Importe Venta|AB1:AB1-Importe Compra|AC1:AC1-Cod.Producto|AD1:AD1-Producto|AE1:AE1-Observacion|AF1:AF1-Obs.Confidencial|AG1:AG1-Soporte"



                ExcelPrimerFila = Columnas.ToString().Split("|")
                For i = 0 To ExcelPrimerFila.Length - 1
                    FilaColumnas = ExcelPrimerFila(i).Split("-")
                    With OHojaExcel
                        TamañoColumna = FilaColumnas(1).Length
                        .Range(FilaColumnas(0).ToString).Merge()
                        .Range(FilaColumnas(0).ToString).Value = FilaColumnas(1).ToString
                        .Range(FilaColumnas(0).ToString).Font.Size = 8
                        .Range(FilaColumnas(0).ToString).Font.Name = "Arial"
                        .Range(FilaColumnas(0)).Interior.Color = ColorTranslator.ToOle(Color.DarkBlue)
                        .Range(FilaColumnas(0).ToString).Borders.Color = ColorTranslator.ToOle(Color.DarkBlue)
                        .Range(FilaColumnas(0).ToString).Font.Color = ColorTranslator.ToOle(Color.White)
                        .Range(FilaColumnas(0).ToString).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
                        .Range(FilaColumnas(0)).BorderAround(Excel.XlLineStyle.xlDash, Excel.XlBorderWeight.xlHairline, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)
                        ORango = .Range(FilaColumnas(0).ToString)
                        ORango.ColumnWidth = TamañoColumna

                        Select Case i
                            Case 4 'Tipo Soporte
                                ORango.ColumnWidth = TamañoColumna + 10
                            Case 7 'Cliente
                                ORango.ColumnWidth = TamañoColumna + 15
                            Case 8 'Detalle
                                ORango.ColumnWidth = TamañoColumna + 40
                            Case 9 'Participacion
                                ORango.ColumnWidth = TamañoColumna + 30
                            Case 10 'Programa 
                                ORango.ColumnWidth = TamañoColumna + 13
                            Case 11 'Semana
                                ORango.ColumnWidth = TamañoColumna + 8
                            Case 29 'Producto
                                ORango.ColumnWidth = TamañoColumna + 18
                            Case 30 'Desc. Soporte
                                ORango.ColumnWidth = TamañoColumna + 20
                            Case 31 'Obs. Confidencial
                                ORango.ColumnWidth = TamañoColumna + 15
                        End Select
                    End With
                Next i
                '--------------------------------------------------------------------------------------------------------------------------------------------------------
                'Recorro el Datatable con los Registro y Voy cargando la Planilla Excel ----------------------------------------------------------------
                Dim FilaExcel As Integer = 2
                Dim Fila As DataRow
                Dim Column As DataColumn
                Dim Columna As String
                Dim CeldasDatos As New ArrayList
                Dim ExcelCeldasDatos() As String
                Dim o, u, k As Integer
                Dim FormatoNumerico As String = "$ ###.000"

                'JJP Se agrega las observaciones del convenio, una columna más
                Columna = "A%:A%|B%:B%|C%:C%|D%:D%|E%:E%|F%:F%|G%:G%|H%:H%|I%:I%|J%:J%|K%:K%|L%:L%|M%:M%|N%:N%|O%:O%|P%:P%|Q%:Q%|R%:R%|S%:S%|T%:T%|U%:U%|V%:V%|W%:W%|X%:X%|Y%:Y%|Z%:Z%|AA%:AA%|AB%:AB%|AC%:AC%|AD%:AD%|AE%:AE%|AF%:AF%|AG%:AG%"

                'Columna = "A%:A%|B%:B%|C%:C%|D%:D%|E%:E%|F%:F%|G%:G%|H%:H%|I%:I%|J%:J%|K%:K%|L%:L%|M%:M%|N%:N%|O%:O%|P%:P%|Q%:Q%|R%:R%|S%:S%|T%:T%|U%:U%|V%:V%|W%:W%|X%:X%|Y%:Y%|Z%:Z%|AA%:AA%|AB%:AB%|AC%:AC%|AD%:AD%|AE%:AE%"
                ExcelCeldasDatos = Columna.ToString().Split("|")

                For i = 0 To DtExConvenios.Rows.Count - 1
                    Fila = DtExConvenios.Rows.Item(i)
                    'Configuro las pocisiones de las celdas ---------------------------------------------------------------------------
                    For o = 0 To 33 - 1
                        CeldasDatos.Add(ExcelCeldasDatos(o).Replace("%", FilaExcel))
                    Next
                    'Recorro las Columnas del DataTable y Cargo las Celdas -----------------------------------------------------
                    For k = 0 To DtExConvenios.Columns.Count - 1
                        Column = DtExConvenios.Columns.Item(k)
                        With OHojaExcel
                            .Range(CeldasDatos(k).ToString).Merge()
                            .Range(CeldasDatos(k).ToString).Value = Fila((Column))
                            .Range(CeldasDatos(k).ToString).Font.Bold = True
                            .Range(CeldasDatos(k).ToString).Font.Size = 8
                            .Range(CeldasDatos(k).ToString).Font.Name = "Arial"
                            .Range(CeldasDatos(k).ToString).Borders.Color = ColorTranslator.ToOle(Color.DarkBlue)
                            .Range(CeldasDatos(k).ToString).Font.Color = ColorTranslator.ToOle(Color.DarkBlue)
                            Select Case FilaExcel
                                Case 27, 28
                                    .Range(CeldasDatos(k).ToString).Cells.NumberFormat = FormatoNumerico
                            End Select
                            ORango = .Range(CeldasDatos(k).ToString)
                        End With
                        '-------------------------------------------------------------------------------------------------------------------------
                    Next k
                    FilaExcel += 1
                    CeldasDatos.Clear()
                Next
                'Guardo el Archivo Generado --------------------------------------
                EventoExcel.ActiveWorkbook.SaveAs(NombreExcel)
                '-------------------------------------------------------------------------
                EventoExcel.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(EventoExcel)

                If Not EventoExcel Is Nothing Then
                    EventoExcel = Nothing
                    OLibroExcel = Nothing
                    OHojaExcel = Nothing
                End If
                Me.CBoxExConvenios.Checked = False
            Else
                Mensajes.Mensaje("No se encontraron convenios para exportar", TipoMensaje.Informacion)
                Exit Sub
            End If
        End If
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



    End Sub
    Private Sub txtCodCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCliente.Validated
        If txtCodCliente.Text <> "" Then

            Dim U As New Usuario

            Try

                U.IDPerfil_Datos = Activo.IDPerfil_Datos
                If txtCodCliente.Text.Trim = 3 Then
                    U.IDPerfil_Datos = 1
                End If
                txtCliente.Text = U.ObtenerDescripcion(txtCodCliente.Text)

                If txtCliente.Text = "" Then
                    Mensajes.Mensaje("El Cliente No Existe o No Tiene Autorización para Administrarlo")
                    txtCodCliente.Text = ""
                    txtCodCliente.Select()
                    Exit Sub
                End If

            Catch ex As ClienteInexistenteExcepcion
                Mensajes.Mensaje(ex.Message)
                txtCodCliente.Text = ""
                txtCodCliente.Select()
                Exit Sub
            End Try
        Else
            txtCliente.Text = String.Empty
            TxtCodProducto.Text = String.Empty
            TxtProducto.Text = String.Empty
        End If
    End Sub
    Private Sub TxtCodProducto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProducto.Validated
        If TxtCodProducto.Text.Trim <> "" Then
            Dim P As New Productos
            Dim producto As New DataTable
            Dim IdProducto As Integer = TxtCodProducto.Text.Trim
            Try

                P.Id_cliente = txtCodCliente.Text.Trim
                producto = P.TraerProductos

                If producto Is Nothing OrElse producto.Rows.Count = 0 OrElse producto.Select("Id_Producto = " & IdProducto).Length = 0 Then
                    Mensajes.Mensaje("El Producto No Existe  o No Pertenece al Cliente Selccionado")
                    TxtCodProducto.Text = ""
                    TxtCodProducto.Select()
                    Exit Sub
                Else
                    TxtProducto.Text = producto.Select("Id_Producto = " & IdProducto)(0)("Descripcion")
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Producto No Existe o No Pertenece al Cliente Selccionado")
                TxtCodProducto.Text = ""
                TxtCodProducto.Select()
                Exit Sub
            End Try
        Else
            TxtProducto.Text = String.Empty
        End If
    End Sub
    Private Sub frmConsultaConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

 
        'AG 05/11/2010 control para vizualizar el check de exportacion de convenios ---------------
        'COdigo anterior 
        'If Activo.CodCapacidad = CapacidadesUsuario.Compras And Activo.IDPerfil_Datos = 1 Then
        'Me.CBoxExConvenios.Visible = True
        'End If


        'AG 29/04/2013 ==========================================================================
        If Activo.PerfilConvenios <> Activo.PerfilConvenio.SinPermisos Then
            Me.CBoxExConvenios.Visible = True
        End If
        '---------------------------------------------------------------------------------------------------------------

        BuscarMedio()

        cboTipoMedio.SelectedIndex = 0
        cboTipoMedio.Refresh()
        cboVigente.SelectedIndex = 0
    End Sub

    Private Sub lblDesCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDesCliente.Click
        BuscarCliente()
    End Sub

    Private Sub txtCodSoporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSoporte.Validated
        If idTipo = -1 Then
            txtCodSoporte.Text = ""
            Exit Sub
        End If
        If txtCodSoporte.Text <> "" Then
            Dim S As New Soportes

            Try

                S.Id_medio = ID_Medio
                S.Id_soporte = txtCodSoporte.Text
                S.Id_tipo_soporte = CType(cboTipoSoporte.SelectedItem, ItemLista).ID
                TxtSoporte.Text = S.ObtenerSoportesMediosConvenio.Rows(0)("Descripcion")


                If TxtSoporte.Text = "" Then
                    Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                    txtCodSoporte.Text = ""
                    txtCodSoporte.Select()
                    Exit Sub
                End If

            Catch ex As Exception
                Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                txtCodSoporte.Text = ""
                txtCodSoporte.Select()
                Exit Sub
            End Try
        Else
            TxtSoporte.Text = String.Empty
        End If
    End Sub
    Private Sub cboMedio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoSoporte.SelectedIndexChanged
        If cboTipoSoporte.SelectedItem Is Nothing Then
            Exit Sub
        End If
        idTipo = DirectCast(cboTipoSoporte.SelectedItem, ItemLista).ID
        txtCodSoporte.Clear()
        TxtSoporte.Clear()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
    Private Sub lblDesSoporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDesSoporte.Click
        If idTipo = -1 Then
            txtCodSoporte.Text = ""
            Exit Sub
        End If
        Me.BuscarSoprote()
    End Sub
    Private Sub lblDescProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDescProducto.Click
        If txtCodCliente.Text.Trim = String.Empty Then
            TxtCodProducto.Text = String.Empty
            TxtProducto.Text = String.Empty
            'AG 04/11/2010
            'Exit Sub
        End If
        Me.BuscarProducto()
    End Sub
    Private Sub cboMedio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoSoporte.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            txtCodSoporte.Select()
        End If
    End Sub

    Private Sub cboVigente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVigente.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            cmdAceptar.Select()
        End If
    End Sub

    Private Sub cboTipoMedio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoMedio.SelectedIndexChanged
        If cboTipoMedio.SelectedItem Is Nothing Then
            Exit Sub
        End If

        ID_Medio = DirectCast(cboTipoMedio.SelectedItem, ItemLista).ID

        Medio = DirectCast(cboTipoMedio.SelectedItem, ItemLista).Descripcion
        Me.BuscarTipoSoporte()
        txtCodSoporte.Clear()
        TxtSoporte.Clear()
    End Sub
#End Region


    Private Sub txtCodSoporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodSoporte.TextChanged

    End Sub

    Private Sub cboTipoMedio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoMedio.KeyPress

    End Sub

    Private Sub cboTipoMedio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoMedio.KeyDown
        If e.KeyCode = Keys.Return Then
            cboTipoSoporte.Select()
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub GenerarEstructuraExcel()

        'Inicio las instancias creadas
        EventoExcel = New Excel.Application()
        EventoExcel.Visible = False

        ' Creamos una instancia del Workbooks de excel
        ' Creamos una instancia de la primera hoja de trabajo de excel
        OLibroExcel = EventoExcel.Workbooks.Add()
        OHojaExcel = OLibroExcel.Worksheets(1)
        'OHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVeryHidden

        OHojaExcel.Activate()

    End Sub

End Class

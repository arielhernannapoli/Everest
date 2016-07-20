Imports System.Text
Imports Framework.Mensajes

Public Class frmAgregarOrden
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
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents lblPrograma As System.Windows.Forms.Label
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents txtHora As QUETOOL.txtTexto
    Friend WithEvents dtpFecha As QUETOOL.dtpFecha
    Friend WithEvents txtDuracion As QUETOOL.txtTexto
    Friend WithEvents txtPrograma As QUETOOL.txtTexto
    Friend WithEvents txtNeto As QUETOOL.txtTexto
    Friend WithEvents lblDesSoporte As System.Windows.Forms.Label
    Friend WithEvents TxtSoporte As QUETOOL.txtTexto
    Friend WithEvents TxtCodSoporte As QUETOOL.txtTexto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtBruto As QUETOOL.txtTexto
    Friend WithEvents lblBruto As System.Windows.Forms.Label
    Friend WithEvents lblDctoVenta1 As System.Windows.Forms.Label
    Friend WithEvents lblDctoVenta2 As System.Windows.Forms.Label
    Friend WithEvents lblDctoVenta3 As System.Windows.Forms.Label
    Friend WithEvents lblDctoVenta4 As System.Windows.Forms.Label
    Friend WithEvents lblDctoVenta5 As System.Windows.Forms.Label
    Friend WithEvents TxtDctoVenta5 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta4 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta3 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta2 As QUETOOL.txtTexto
    Friend WithEvents TxtDctoVenta1 As QUETOOL.txtTexto
    Friend WithEvents lblBrutoTotal As System.Windows.Forms.Label
    Friend WithEvents lblNetoTotal As System.Windows.Forms.Label
    Friend WithEvents TxtBrutoTotal As QUETOOL.txtTexto
    Friend WithEvents TxtNetoTotal As QUETOOL.txtTexto
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAgregarOrden))
        Me.lblSoporte = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblHora = New System.Windows.Forms.Label
        Me.lblDuracion = New System.Windows.Forms.Label
        Me.lblPrograma = New System.Windows.Forms.Label
        Me.lblNeto = New System.Windows.Forms.Label
        Me.txtDuracion = New QUETOOL.txtTexto
        Me.txtPrograma = New QUETOOL.txtTexto
        Me.txtNeto = New QUETOOL.txtTexto
        Me.txtHora = New QUETOOL.txtTexto
        Me.dtpFecha = New QUETOOL.dtpFecha
        Me.lblDesSoporte = New System.Windows.Forms.Label
        Me.TxtSoporte = New QUETOOL.txtTexto
        Me.TxtCodSoporte = New QUETOOL.txtTexto
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdAceptar = New System.Windows.Forms.Button
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.TxtBruto = New QUETOOL.txtTexto
        Me.lblBruto = New System.Windows.Forms.Label
        Me.lblDctoVenta1 = New System.Windows.Forms.Label
        Me.lblDctoVenta2 = New System.Windows.Forms.Label
        Me.lblDctoVenta3 = New System.Windows.Forms.Label
        Me.lblDctoVenta4 = New System.Windows.Forms.Label
        Me.lblDctoVenta5 = New System.Windows.Forms.Label
        Me.TxtDctoVenta5 = New QUETOOL.txtTexto
        Me.TxtDctoVenta4 = New QUETOOL.txtTexto
        Me.TxtDctoVenta3 = New QUETOOL.txtTexto
        Me.TxtDctoVenta2 = New QUETOOL.txtTexto
        Me.TxtDctoVenta1 = New QUETOOL.txtTexto
        Me.TxtBrutoTotal = New QUETOOL.txtTexto
        Me.lblBrutoTotal = New System.Windows.Forms.Label
        Me.TxtNetoTotal = New QUETOOL.txtTexto
        Me.lblNetoTotal = New System.Windows.Forms.Label
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Location = New System.Drawing.Point(8, 10)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(50, 16)
        Me.lblSoporte.TabIndex = 16
        Me.lblSoporte.Text = "Soporte :"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(8, 106)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 16)
        Me.lblFecha.TabIndex = 20
        Me.lblFecha.Text = "Fecha :"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(8, 58)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(35, 16)
        Me.lblHora.TabIndex = 18
        Me.lblHora.Text = "Hora :"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(8, 82)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(56, 16)
        Me.lblDuracion.TabIndex = 19
        Me.lblDuracion.Text = "Duración :"
        '
        'lblPrograma
        '
        Me.lblPrograma.AutoSize = True
        Me.lblPrograma.Location = New System.Drawing.Point(8, 34)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(60, 16)
        Me.lblPrograma.TabIndex = 17
        Me.lblPrograma.Text = "Programa :"
        '
        'lblNeto
        '
        Me.lblNeto.AutoSize = True
        Me.lblNeto.Location = New System.Drawing.Point(8, 279)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(34, 16)
        Me.lblNeto.TabIndex = 27
        Me.lblNeto.Text = "Neto :"
        '
        'txtDuracion
        '
        Me.txtDuracion.AcceptsReturn = True
        Me.txtDuracion.AcceptsTab = True
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.ConDecimal = False
        Me.txtDuracion.Location = New System.Drawing.Point(64, 80)
        Me.txtDuracion.Maximo = 0
        Me.txtDuracion.MaxLength = 3
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(48, 20)
        Me.txtDuracion.SoloLetra = False
        Me.txtDuracion.SoloNumero = True
        Me.txtDuracion.TabIndex = 5
        Me.txtDuracion.Text = ""
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrograma
        '
        Me.txtPrograma.AcceptsReturn = True
        Me.txtPrograma.AcceptsTab = True
        Me.txtPrograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrograma.ConDecimal = False
        Me.txtPrograma.Location = New System.Drawing.Point(64, 32)
        Me.txtPrograma.Maximo = 0
        Me.txtPrograma.MaxLength = 30
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.Size = New System.Drawing.Size(252, 20)
        Me.txtPrograma.SoloLetra = False
        Me.txtPrograma.SoloNumero = False
        Me.txtPrograma.TabIndex = 3
        Me.txtPrograma.Text = ""
        '
        'txtNeto
        '
        Me.txtNeto.AcceptsReturn = True
        Me.txtNeto.AcceptsTab = True
        Me.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNeto.ConDecimal = True
        Me.txtNeto.Location = New System.Drawing.Point(64, 277)
        Me.txtNeto.Maximo = 0
        Me.txtNeto.MaxLength = 9
        Me.txtNeto.Name = "txtNeto"
        Me.txtNeto.ReadOnly = True
        Me.txtNeto.Size = New System.Drawing.Size(84, 20)
        Me.txtNeto.SoloLetra = False
        Me.txtNeto.SoloNumero = False
        Me.txtNeto.TabIndex = 13
        Me.txtNeto.Text = ""
        Me.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHora
        '
        Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHora.ConDecimal = False
        Me.txtHora.Location = New System.Drawing.Point(64, 56)
        Me.txtHora.Maximo = 0
        Me.txtHora.MaxLength = 5
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(48, 20)
        Me.txtHora.SoloLetra = False
        Me.txtHora.SoloNumero = False
        Me.txtHora.TabIndex = 4
        Me.txtHora.Text = ""
        '
        'dtpFecha
        '
        Appearance1.FontData.SizeInPoints = 9.0!
        Me.dtpFecha.Appearance = Appearance1
        Me.dtpFecha.FlatMode = True
        Me.dtpFecha.Location = New System.Drawing.Point(64, 104)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 21)
        Me.dtpFecha.TabIndex = 6
        '
        'lblDesSoporte
        '
        Me.lblDesSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesSoporte.Image = CType(resources.GetObject("lblDesSoporte.Image"), System.Drawing.Image)
        Me.lblDesSoporte.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblDesSoporte.Location = New System.Drawing.Point(320, 8)
        Me.lblDesSoporte.Name = "lblDesSoporte"
        Me.lblDesSoporte.Size = New System.Drawing.Size(21, 21)
        Me.lblDesSoporte.TabIndex = 2
        Me.lblDesSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSoporte
        '
        Me.TxtSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSoporte.ConDecimal = False
        Me.TxtSoporte.Location = New System.Drawing.Point(108, 8)
        Me.TxtSoporte.Maximo = 0
        Me.TxtSoporte.Name = "TxtSoporte"
        Me.TxtSoporte.ReadOnly = True
        Me.TxtSoporte.Size = New System.Drawing.Size(208, 20)
        Me.TxtSoporte.SoloLetra = False
        Me.TxtSoporte.SoloNumero = False
        Me.TxtSoporte.TabIndex = 1
        Me.TxtSoporte.TabStop = False
        Me.TxtSoporte.Text = ""
        '
        'TxtCodSoporte
        '
        Me.TxtCodSoporte.AcceptsReturn = True
        Me.TxtCodSoporte.AcceptsTab = True
        Me.TxtCodSoporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSoporte.ConDecimal = False
        Me.TxtCodSoporte.Location = New System.Drawing.Point(64, 8)
        Me.TxtCodSoporte.Maximo = 0
        Me.TxtCodSoporte.MaxLength = 5
        Me.TxtCodSoporte.Name = "TxtCodSoporte"
        Me.TxtCodSoporte.Size = New System.Drawing.Size(40, 20)
        Me.TxtCodSoporte.SoloLetra = False
        Me.TxtCodSoporte.SoloNumero = True
        Me.TxtCodSoporte.TabIndex = 0
        Me.TxtCodSoporte.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(0, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 3)
        Me.Label1.TabIndex = 28
        '
        'cmdAceptar
        '
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Location = New System.Drawing.Point(188, 312)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.TabIndex = 14
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Location = New System.Drawing.Point(266, 312)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.TabIndex = 15
        Me.cmdCancelar.Text = "Salir"
        '
        'TxtBruto
        '
        Me.TxtBruto.AcceptsReturn = True
        Me.TxtBruto.AcceptsTab = True
        Me.TxtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBruto.ConDecimal = True
        Me.TxtBruto.Location = New System.Drawing.Point(64, 129)
        Me.TxtBruto.Maximo = 0
        Me.TxtBruto.MaxLength = 9
        Me.TxtBruto.Name = "TxtBruto"
        Me.TxtBruto.Size = New System.Drawing.Size(84, 20)
        Me.TxtBruto.SoloLetra = False
        Me.TxtBruto.SoloNumero = False
        Me.TxtBruto.TabIndex = 7
        Me.TxtBruto.Text = ""
        Me.TxtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBruto
        '
        Me.lblBruto.AutoSize = True
        Me.lblBruto.Location = New System.Drawing.Point(8, 131)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(37, 16)
        Me.lblBruto.TabIndex = 21
        Me.lblBruto.Text = "Bruto :"
        '
        'lblDctoVenta1
        '
        Me.lblDctoVenta1.AutoSize = True
        Me.lblDctoVenta1.Location = New System.Drawing.Point(8, 156)
        Me.lblDctoVenta1.Name = "lblDctoVenta1"
        Me.lblDctoVenta1.Size = New System.Drawing.Size(43, 16)
        Me.lblDctoVenta1.TabIndex = 22
        Me.lblDctoVenta1.Text = "Dcto 1 :"
        '
        'lblDctoVenta2
        '
        Me.lblDctoVenta2.AutoSize = True
        Me.lblDctoVenta2.Location = New System.Drawing.Point(8, 181)
        Me.lblDctoVenta2.Name = "lblDctoVenta2"
        Me.lblDctoVenta2.Size = New System.Drawing.Size(43, 16)
        Me.lblDctoVenta2.TabIndex = 23
        Me.lblDctoVenta2.Text = "Dcto 2 :"
        '
        'lblDctoVenta3
        '
        Me.lblDctoVenta3.AutoSize = True
        Me.lblDctoVenta3.Location = New System.Drawing.Point(8, 206)
        Me.lblDctoVenta3.Name = "lblDctoVenta3"
        Me.lblDctoVenta3.Size = New System.Drawing.Size(43, 16)
        Me.lblDctoVenta3.TabIndex = 24
        Me.lblDctoVenta3.Text = "Dcto 3 :"
        '
        'lblDctoVenta4
        '
        Me.lblDctoVenta4.AutoSize = True
        Me.lblDctoVenta4.Location = New System.Drawing.Point(8, 231)
        Me.lblDctoVenta4.Name = "lblDctoVenta4"
        Me.lblDctoVenta4.Size = New System.Drawing.Size(43, 16)
        Me.lblDctoVenta4.TabIndex = 25
        Me.lblDctoVenta4.Text = "Dcto 4 :"
        '
        'lblDctoVenta5
        '
        Me.lblDctoVenta5.AutoSize = True
        Me.lblDctoVenta5.Location = New System.Drawing.Point(8, 255)
        Me.lblDctoVenta5.Name = "lblDctoVenta5"
        Me.lblDctoVenta5.Size = New System.Drawing.Size(43, 16)
        Me.lblDctoVenta5.TabIndex = 26
        Me.lblDctoVenta5.Text = "Dcto 5 :"
        '
        'TxtDctoVenta5
        '
        Me.TxtDctoVenta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta5.ConDecimal = False
        Me.TxtDctoVenta5.Location = New System.Drawing.Point(64, 253)
        Me.TxtDctoVenta5.Maximo = 0
        Me.TxtDctoVenta5.MaxLength = 6
        Me.TxtDctoVenta5.Name = "TxtDctoVenta5"
        Me.TxtDctoVenta5.ReadOnly = True
        Me.TxtDctoVenta5.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta5.SoloLetra = False
        Me.TxtDctoVenta5.SoloNumero = False
        Me.TxtDctoVenta5.TabIndex = 12
        Me.TxtDctoVenta5.Text = ""
        Me.TxtDctoVenta5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta4
        '
        Me.TxtDctoVenta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta4.ConDecimal = False
        Me.TxtDctoVenta4.Location = New System.Drawing.Point(64, 229)
        Me.TxtDctoVenta4.Maximo = 0
        Me.TxtDctoVenta4.MaxLength = 6
        Me.TxtDctoVenta4.Name = "TxtDctoVenta4"
        Me.TxtDctoVenta4.ReadOnly = True
        Me.TxtDctoVenta4.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta4.SoloLetra = False
        Me.TxtDctoVenta4.SoloNumero = False
        Me.TxtDctoVenta4.TabIndex = 11
        Me.TxtDctoVenta4.Text = ""
        Me.TxtDctoVenta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta3
        '
        Me.TxtDctoVenta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta3.ConDecimal = False
        Me.TxtDctoVenta3.Location = New System.Drawing.Point(64, 204)
        Me.TxtDctoVenta3.Maximo = 0
        Me.TxtDctoVenta3.MaxLength = 6
        Me.TxtDctoVenta3.Name = "TxtDctoVenta3"
        Me.TxtDctoVenta3.ReadOnly = True
        Me.TxtDctoVenta3.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta3.SoloLetra = False
        Me.TxtDctoVenta3.SoloNumero = False
        Me.TxtDctoVenta3.TabIndex = 10
        Me.TxtDctoVenta3.Text = ""
        Me.TxtDctoVenta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta2
        '
        Me.TxtDctoVenta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta2.ConDecimal = False
        Me.TxtDctoVenta2.Location = New System.Drawing.Point(64, 179)
        Me.TxtDctoVenta2.Maximo = 0
        Me.TxtDctoVenta2.MaxLength = 6
        Me.TxtDctoVenta2.Name = "TxtDctoVenta2"
        Me.TxtDctoVenta2.ReadOnly = True
        Me.TxtDctoVenta2.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta2.SoloLetra = False
        Me.TxtDctoVenta2.SoloNumero = False
        Me.TxtDctoVenta2.TabIndex = 9
        Me.TxtDctoVenta2.Text = ""
        Me.TxtDctoVenta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDctoVenta1
        '
        Me.TxtDctoVenta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDctoVenta1.ConDecimal = False
        Me.TxtDctoVenta1.Location = New System.Drawing.Point(64, 154)
        Me.TxtDctoVenta1.Maximo = 0
        Me.TxtDctoVenta1.MaxLength = 6
        Me.TxtDctoVenta1.Name = "TxtDctoVenta1"
        Me.TxtDctoVenta1.ReadOnly = True
        Me.TxtDctoVenta1.Size = New System.Drawing.Size(56, 20)
        Me.TxtDctoVenta1.SoloLetra = False
        Me.TxtDctoVenta1.SoloNumero = False
        Me.TxtDctoVenta1.TabIndex = 8
        Me.TxtDctoVenta1.Text = ""
        Me.TxtDctoVenta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBrutoTotal
        '
        Me.TxtBrutoTotal.AcceptsReturn = True
        Me.TxtBrutoTotal.AcceptsTab = True
        Me.TxtBrutoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBrutoTotal.ConDecimal = True
        Me.TxtBrutoTotal.Location = New System.Drawing.Point(232, 129)
        Me.TxtBrutoTotal.Maximo = 0
        Me.TxtBrutoTotal.MaxLength = 9
        Me.TxtBrutoTotal.Name = "TxtBrutoTotal"
        Me.TxtBrutoTotal.ReadOnly = True
        Me.TxtBrutoTotal.Size = New System.Drawing.Size(84, 20)
        Me.TxtBrutoTotal.SoloLetra = False
        Me.TxtBrutoTotal.SoloNumero = False
        Me.TxtBrutoTotal.TabIndex = 29
        Me.TxtBrutoTotal.TabStop = False
        Me.TxtBrutoTotal.Text = ""
        Me.TxtBrutoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBrutoTotal
        '
        Me.lblBrutoTotal.AutoSize = True
        Me.lblBrutoTotal.Location = New System.Drawing.Point(167, 131)
        Me.lblBrutoTotal.Name = "lblBrutoTotal"
        Me.lblBrutoTotal.Size = New System.Drawing.Size(66, 16)
        Me.lblBrutoTotal.TabIndex = 31
        Me.lblBrutoTotal.Text = "Bruto Total :"
        '
        'TxtNetoTotal
        '
        Me.TxtNetoTotal.AcceptsReturn = True
        Me.TxtNetoTotal.AcceptsTab = True
        Me.TxtNetoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNetoTotal.ConDecimal = True
        Me.TxtNetoTotal.Location = New System.Drawing.Point(232, 277)
        Me.TxtNetoTotal.Maximo = 0
        Me.TxtNetoTotal.MaxLength = 9
        Me.TxtNetoTotal.Name = "TxtNetoTotal"
        Me.TxtNetoTotal.ReadOnly = True
        Me.TxtNetoTotal.Size = New System.Drawing.Size(84, 20)
        Me.TxtNetoTotal.SoloLetra = False
        Me.TxtNetoTotal.SoloNumero = False
        Me.TxtNetoTotal.TabIndex = 30
        Me.TxtNetoTotal.TabStop = False
        Me.TxtNetoTotal.Text = ""
        Me.TxtNetoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNetoTotal
        '
        Me.lblNetoTotal.AutoSize = True
        Me.lblNetoTotal.Location = New System.Drawing.Point(167, 279)
        Me.lblNetoTotal.Name = "lblNetoTotal"
        Me.lblNetoTotal.Size = New System.Drawing.Size(63, 16)
        Me.lblNetoTotal.TabIndex = 32
        Me.lblNetoTotal.Text = "Neto Total :"
        '
        'frmAgregarOrden
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(346, 339)
        Me.Controls.Add(Me.TxtBrutoTotal)
        Me.Controls.Add(Me.TxtNetoTotal)
        Me.Controls.Add(Me.lblBrutoTotal)
        Me.Controls.Add(Me.lblNetoTotal)
        Me.Controls.Add(Me.TxtDctoVenta5)
        Me.Controls.Add(Me.TxtDctoVenta4)
        Me.Controls.Add(Me.TxtDctoVenta3)
        Me.Controls.Add(Me.TxtDctoVenta2)
        Me.Controls.Add(Me.TxtDctoVenta1)
        Me.Controls.Add(Me.lblDctoVenta5)
        Me.Controls.Add(Me.lblDctoVenta4)
        Me.Controls.Add(Me.lblDctoVenta3)
        Me.Controls.Add(Me.lblDctoVenta2)
        Me.Controls.Add(Me.lblDctoVenta1)
        Me.Controls.Add(Me.TxtBruto)
        Me.Controls.Add(Me.lblBruto)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtPrograma)
        Me.Controls.Add(Me.lblDesSoporte)
        Me.Controls.Add(Me.TxtSoporte)
        Me.Controls.Add(Me.TxtCodSoporte)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtNeto)
        Me.Controls.Add(Me.lblNeto)
        Me.Controls.Add(Me.lblPrograma)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblSoporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Orden"
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas"
    Private mId_Medio, mCod_Soporte As Integer
    Private mAceptar As Boolean = False
    Private mClosePage As Boolean = False
    Private mOrden, mNeto As Double
    Private mSoporte, mHora, mDuracion, mPrograma As String
    Private mFecha As DateTime
#End Region

#Region "Propiedades Publicas"
    Public WriteOnly Property Id_Medio() As Integer
        Set(ByVal Value As Integer)
            mId_Medio = Value
        End Set
    End Property

    Public Property Orden() As Double
        Get
            Return mOrden
        End Get
        Set(ByVal Value As Double)
            mOrden = Value
        End Set
    End Property

    Public ReadOnly Property Soporte() As String
        Get
            Return mSoporte
        End Get
    End Property

    Public ReadOnly Property Fecha() As DateTime
        Get
            Return mFecha
        End Get
    End Property

    Public ReadOnly Property Hora() As String
        Get
            Return mHora
        End Get
    End Property

    Public ReadOnly Property Duracion() As String
        Get
            Return mDuracion
        End Get
    End Property

    Public ReadOnly Property Programa() As String
        Get
            Return mPrograma
        End Get
    End Property

    Public ReadOnly Property Cod_Soporte() As Integer
        Get
            Return mCod_Soporte
        End Get
    End Property

    Public ReadOnly Property Neto() As Double
        Get
            Return mNeto
        End Get
    End Property

    Public ReadOnly Property Aceptar() As Boolean
        Get
            Return mAceptar
        End Get
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAgregarOrden_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call AplicarFormatoImporte(TxtBruto)
        Call AplicarFormatoImporte(txtNeto)
        Call AplicarFormatoImporte(TxtBrutoTotal)
        Call AplicarFormatoImporte(txtNetoTotal)
        Call AplicarFormatoPorcentaje(TxtDctoVenta1)
        Call AplicarFormatoPorcentaje(TxtDctoVenta2)
        Call AplicarFormatoPorcentaje(TxtDctoVenta3)
        Call AplicarFormatoPorcentaje(TxtDctoVenta4)
        Call AplicarFormatoPorcentaje(TxtDctoVenta5)
    End Sub

    Private Sub frmAgregarOrden_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mClosePage = True
    End Sub

    Private Sub txtHora_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHora.LostFocus
        Call AplicarFormatoHora(txtHora, True)
    End Sub

    Private Sub txtDuracion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuracion.LostFocus
        Call CalcularTotales()
    End Sub

    Private Sub txtBruto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBruto.LostFocus
        Call AplicarFormatoImporte(TxtBruto)
        Call DescuentosSoloLectura(TxtBruto, 0)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub txtNeto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNeto.LostFocus
        Call AplicarFormatoImporte(txtNeto)
    End Sub

    Private Sub TxtDctoVenta1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta1.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta1)
        Call DescuentosSoloLectura(TxtDctoVenta1, 1)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub TxtDctoVenta2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta2.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta2)
        Call DescuentosSoloLectura(TxtDctoVenta2, 2)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub TxtDctoVenta3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta3.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta3)
        Call DescuentosSoloLectura(TxtDctoVenta3, 3)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub TxtDctoVenta4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta4.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta4)
        Call DescuentosSoloLectura(TxtDctoVenta4, 4)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub TxtDctoVenta5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDctoVenta5.LostFocus
        Call AplicarFormatoPorcentaje(TxtDctoVenta5)
        Call DescuentosSoloLectura(TxtDctoVenta5, 5)
        Call CalcularNeto()
        Call CalcularTotales()
    End Sub

    Private Sub TxtCodSoporte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodSoporte.LostFocus
        Call TxtCodSoporte_LostFocus()
    End Sub

    Private Sub lblDesSoporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDesSoporte.Click
        Dim CodigoMedio As String = mId_Medio
        If CodigoMedio <> String.Empty Then
            Dim Busqueda As New frmBuscar
            Busqueda.CargarFormulario(SeccionActiva.SoportesConvenios, TxtSoporte, TxtCodSoporte, "id_soporte", "descripcion", "Código", "Soporte", CodigoMedio)
            Busqueda.ShowDialog()
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Call NuevaOrden()
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub NuevaOrden()
        If ValidarNuevaOrden() Then
            mSoporte = TxtSoporte.Text.Trim
            mFecha = dtpFecha.Value
            mHora = txtHora.Text.Trim
            mDuracion = txtDuracion.Text.Trim
            mPrograma = txtPrograma.Text.Trim
            mCod_Soporte = TxtCodSoporte.Text.Trim
            mNeto = ObtenerDoble(TxtNetoTotal.Text.Trim)

            mAceptar = True
            Me.Close()
        End If
    End Sub

    Private Sub AplicarFormatoHora(ByVal pTexto As QUETOOL.txtTexto, ByVal pInicio As Boolean)
        If mClosePage Then Return
        Dim Hora As String = pTexto.Text.Trim
        If Hora <> String.Empty Then
            If Not AplicarFormatoHora(Hora, pInicio) Then
                pTexto.Text = String.Empty
                pTexto.Focus()
                Exit Sub
            End If
        Else
            pTexto.Text = String.Empty
        End If
    End Sub

    Private Sub AplicarFormatoImporte(ByVal pTexto As QUETOOL.txtTexto)
        If mClosePage Then Return
        Dim Importe As String = pTexto.Text.Replace("$", "").Trim
        If Importe <> String.Empty Then
            If Not AplicarFormatoImporte(pTexto, Importe) Then
                pTexto.Text = "$ 0.00"
                pTexto.Focus()
            End If
        Else
            pTexto.Text = "$ 0.00"
        End If
    End Sub

    Private Sub AplicarFormatoPorcentaje(ByVal pTexto As QUETOOL.txtTexto)
        If mClosePage Then Return
        Dim Descuento As String = pTexto.Text.Trim
        If Descuento <> String.Empty Then
            If Not AplicarFormatoPorcentaje(pTexto, Descuento) Then
                pTexto.Text = "0.00"
                pTexto.Focus()
            End If
        Else
            pTexto.Text = "0.00"
        End If
    End Sub

    Private Sub TxtCodSoporte_LostFocus()
        Dim CodigoSoporte As String = TxtCodSoporte.Text.Trim
        Dim CodigoMedio As String = mId_Medio
        If CodigoSoporte <> String.Empty AndAlso CodigoMedio <> String.Empty Then
            Dim Sop As New Soportes
            Try
                Sop.Id_medio = CodigoMedio
                Sop.Id_soporte = CodigoSoporte
                Sop.Id_tipo_soporte = 0
                Dim dtSoporte As DataTable = Sop.ObtenerSoportesMediosConvenio

                If dtSoporte Is Nothing OrElse dtSoporte.Rows.Count <= 0 Then
                    Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                    TxtCodSoporte.Text = String.Empty
                    TxtCodSoporte.Select()
                    Exit Sub
                End If
                TxtSoporte.Text = dtSoporte.Rows(0)("Descripcion")
            Catch ex As Exception
                Mensajes.Mensaje("El Soporte No Existe o No Pertenece al Medio Selccionado")
                TxtSoporte.Text = String.Empty
                TxtCodSoporte.Text = ""
                TxtCodSoporte.Select()
                Exit Sub
            End Try
        Else
            TxtSoporte.Text = String.Empty
        End If
    End Sub

    Private Sub CalcularNeto()
        Dim Neto As Double

        Neto = ObtenerDoble(TxtBruto.Text.Trim)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta1.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta2.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta3.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta4.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta5.Text.Trim)) / 100)

        txtNeto.Text = ObtenerNeto(Math.Round(Neto, 2))
        Call AplicarFormatoImporte(txtNeto)
    End Sub

    Private Sub CalcularNetoTotal()
        Dim Neto As Double

        Neto = ObtenerDoble(TxtBrutoTotal.Text.Trim)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta1.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta2.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta3.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta4.Text.Trim)) / 100)
        Neto = Neto - ((Neto * ObtenerDoble(TxtDctoVenta5.Text.Trim)) / 100)

        TxtNetoTotal.Text = ObtenerNeto(Math.Round(Neto, 2))
        Call AplicarFormatoImporte(TxtNetoTotal)
    End Sub

    Private Sub CalcularTotales()
        Dim Duracion, Bruto As Double

        Duracion = ObtenerDoble(txtDuracion.Text.Trim)
        Bruto = ObtenerDoble(TxtBruto.Text.Trim)

        If Duracion > 0 AndAlso Bruto > 0 Then
            TxtBrutoTotal.Text = ObtenerNeto(Duracion * Bruto)
            Call AplicarFormatoImporte(TxtBrutoTotal)
            Call CalcularNetoTotal()
        Else
            TxtBrutoTotal.Text = "$ 0.00"
            TxtNetoTotal.Text = "$ 0.00"
        End If
    End Sub

    Private Sub DescuentosSoloLectura(ByVal pTexto As QUETOOL.txtTexto, ByVal pNivel As Integer)
        Select Case pNivel
            Case 0
                If ObtenerDoble(pTexto.Text.Trim) > 0 Then
                    TxtDctoVenta1.ReadOnly = False
                Else
                    AplicarSoloLectura(TxtDctoVenta1)
                    AplicarSoloLectura(TxtDctoVenta2)
                    AplicarSoloLectura(TxtDctoVenta3)
                    AplicarSoloLectura(TxtDctoVenta4)
                    AplicarSoloLectura(TxtDctoVenta5)
                End If
            Case 1
                If ObtenerDoble(pTexto.Text.Trim) > 0 Then
                    TxtDctoVenta2.ReadOnly = False
                Else
                    AplicarSoloLectura(TxtDctoVenta2)
                    AplicarSoloLectura(TxtDctoVenta3)
                    AplicarSoloLectura(TxtDctoVenta4)
                    AplicarSoloLectura(TxtDctoVenta5)
                End If
            Case 2
                If ObtenerDoble(pTexto.Text.Trim) > 0 Then
                    TxtDctoVenta3.ReadOnly = False
                Else
                    AplicarSoloLectura(TxtDctoVenta3)
                    AplicarSoloLectura(TxtDctoVenta4)
                    AplicarSoloLectura(TxtDctoVenta5)
                End If
            Case 3
                If ObtenerDoble(pTexto.Text.Trim) > 0 Then
                    TxtDctoVenta4.ReadOnly = False
                Else
                    AplicarSoloLectura(TxtDctoVenta4)
                    AplicarSoloLectura(TxtDctoVenta5)
                End If
            Case 4
                If ObtenerDoble(pTexto.Text.Trim) > 0 Then
                    TxtDctoVenta5.ReadOnly = False
                Else
                    AplicarSoloLectura(TxtDctoVenta5)
                End If
        End Select
    End Sub

    Private Sub AplicarSoloLectura(ByVal pTexto As QUETOOL.txtTexto)
        pTexto.Text = "0.00"
        pTexto.ReadOnly = True
    End Sub

    Private Function ObtenerNeto(ByVal pNeto As Double) As String
        Dim Neto As String
        Dim SeparadorDecimal As String

        SeparadorDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        'SeparadorDecimal = ","
        Neto = pNeto.ToString.Replace(SeparadorDecimal, ".")

        Return Neto
    End Function

    Private Function ObtenerDoble(ByVal pNeto As String) As Double
        Dim Neto As Double
        Dim SeparadorDecimal As String

        SeparadorDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        'SeparadorDecimal = ","
        pNeto = pNeto.Replace("$", "")
        pNeto = pNeto.Replace(".", SeparadorDecimal)
        If pNeto = String.Empty Then
            Neto = 0
        Else
            Neto = Convert.ToDouble(pNeto)
        End If

        Return Neto
    End Function

    Private Function AplicarFormatoHora(ByVal pHora As String, ByVal pInicio As Boolean) As Boolean
        Dim Message As New StringBuilder
        Dim HoraFinal As New StringBuilder
        Dim ParteHora As String() = pHora.Split(":")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789:"

        Message.Append("El Formato de la Hora es incorrecta.")
        Message.Append(vbCrLf)

        'Valida que no existan caracteres no permitidos
        If Not ValidarCaracteres(pHora, CaracteresPermitidos) OrElse ParteHora.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda de la hora
        Parte = String.Empty
        For Index As Integer = 0 To ParteHora(0).Length - 1
            If ParteHora(0).Substring(Index, 1) <> 0 Then
                Parte = ParteHora(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteHora(0) = Parte
        Else
            ParteHora(0) = 0
        End If

        If ParteHora.Length = 1 Then 'No se ingresó ":"
            If ParteHora(0) = 0 Then 'Si escribio solo ceros
                If pInicio Then
                    txtHora.Text = String.Empty
                Else
                    txtHora.Text = String.Empty
                End If
                Return True
            End If
            Select Case ParteHora(0).Length
                Case 1
                    If ParteHora(0) < 6 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append("0")
                    HoraFinal.Append(ParteHora(0))
                    HoraFinal.Append(":")
                    If pInicio Then
                        HoraFinal.Append("00")
                    Else
                        HoraFinal.Append("59")
                    End If
                Case 2
                    If ParteHora(0) > 29 AndAlso ParteHora(0).Substring(1, 1) > 5 Then
                        Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0) <= 29 Then
                        If ParteHora(0) < 10 Then
                            HoraFinal.Append("0")
                        End If
                        HoraFinal.Append(ParteHora(0))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0) <= 29 Then
                        If pInicio Then
                            HoraFinal.Append("00")
                        Else
                            HoraFinal.Append("59")
                        End If
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 1))
                        HoraFinal.Append("0")
                    End If
                Case 3
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        If ParteHora(0).Substring(1, 2) > 59 Then
                            Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    Else
                        If ParteHora(0).Substring(2, 1) > 5 Then
                            Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                            Mensaje(Message.ToString, TipoMensaje.DeError)
                            Return False
                        End If
                    End If
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    Else
                        HoraFinal.Append("0")
                        HoraFinal.Append(ParteHora(0).Substring(0, 1))
                    End If
                    HoraFinal.Append(":")
                    If ParteHora(0).Substring(0, 2) <= 29 Then
                        HoraFinal.Append(ParteHora(0).Substring(2, 1))
                        HoraFinal.Append("0")
                    Else
                        HoraFinal.Append(ParteHora(0).Substring(1, 2))
                    End If
                Case 4
                    If ParteHora(0).Substring(0, 2) > 29 Then
                        Message.Append("La hora debe ser mayor a 6 y menor a 29")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    If ParteHora(0).Substring(2, 2) > 59 Then
                        Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                        Mensaje(Message.ToString, TipoMensaje.DeError)
                        Return False
                    End If
                    HoraFinal.Append(ParteHora(0).Substring(0, 2))
                    HoraFinal.Append(":")
                    HoraFinal.Append(ParteHora(0).Substring(2, 2))
                Case 5
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
            End Select
        Else
            'Valida si hay solo ceros en los minutos
            Parte = String.Empty
            For Index As Integer = 0 To ParteHora(1).Length - 1
                If ParteHora(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteHora(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteHora(1) = 0
            End If
            If ParteHora(0) = 0 AndAlso ParteHora(1) = 0 Then
                If pInicio Then
                    txtHora.Text = String.Empty
                Else
                    txtHora.Text = String.Empty
                End If
                Return True
            End If
            If ParteHora(0) < 6 OrElse ParteHora(0) > 29 Then
                Message.Append("La hora debe ser mayor a 6 y menor a 29")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
            If ParteHora(1) <> String.Empty Then
                If ParteHora(1) < 0 OrElse (ParteHora(1).Length = 1 AndAlso ParteHora(1) > 5) OrElse ParteHora(1) > 59 Then
                    Message.Append("Los minutos deben ser mayor a 0 y menor a 59")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
                If ParteHora(0) = 29 AndAlso ParteHora(1) > 59 Then
                    Message.Append("La hora debe ser mayor a 6:00 y menor a 29:59")
                    Mensaje(Message.ToString, TipoMensaje.DeError)
                    Return False
                End If
            End If
            If ParteHora(0).Length = 1 Then
                HoraFinal.Append("0")
            End If
            HoraFinal.Append(ParteHora(0))
            HoraFinal.Append(":")
            If ParteHora(1) <> String.Empty Then
                HoraFinal.Append(ParteHora(1))
                If ParteHora(1).Length = 1 Then
                    HoraFinal.Append("0")
                End If
            Else
                If pInicio Then
                    HoraFinal.Append("00")
                Else
                    HoraFinal.Append("59")
                End If
            End If
        End If
        If pInicio Then
            txtHora.Text = HoraFinal.ToString
        Else
            txtHora.Text = HoraFinal.ToString
        End If
        Return True
    End Function

    Private Function AplicarFormatoImporte(ByVal pTexto As QUETOOL.txtTexto, ByVal pImporte As String) As Boolean
        Dim Message As New StringBuilder
        Dim ImporteFinal As New StringBuilder
        Dim ParteImporte As String() = pImporte.Split(".")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789."

        Message.Append("El Importe es incorrecto.")
        Message.Append(vbCrLf)

        If Not ValidarCaracteres(pImporte, CaracteresPermitidos) OrElse ParteImporte.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda del importe
        Parte = String.Empty
        For Index As Integer = 0 To ParteImporte(0).Length - 1
            If ParteImporte(0).Substring(Index, 1) <> 0 Then
                Parte = ParteImporte(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteImporte(0) = Parte
        Else
            ParteImporte(0) = 0
        End If

        If ParteImporte.Length = 2 Then 'Se ingresó "." (decimal)
            Parte = String.Empty
            For Index As Integer = 0 To ParteImporte(1).Length - 1
                If ParteImporte(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteImporte(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteImporte(1) = 0
            End If
            If ParteImporte(1).Length > 2 Then
                Message.Append("Los centavos deben ser menor a 99")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
        End If
        If ParteImporte(0).Length > 9 Then
            Message.Append("El importe debe ser menor a 999999999")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        ImporteFinal.Append("$ ")
        ImporteFinal.Append(ParteImporte(0))
        ImporteFinal.Append(".")
        If ParteImporte.Length = 2 Then
            ImporteFinal.Append(ParteImporte(1))
            If ParteImporte(1).Length = 1 Then
                ImporteFinal.Append("0")
            End If
        Else
            ImporteFinal.Append("00")
        End If

        pTexto.Text = ImporteFinal.ToString
        Return True
    End Function

    Private Function AplicarFormatoPorcentaje(ByVal pTexto As QUETOOL.txtTexto, ByVal pDescuento As String) As Boolean
        Dim Message As New StringBuilder
        Dim DescuentoFinal As New StringBuilder
        Dim ParteDescuento As String() = pDescuento.Split(".")
        Dim Parte As String
        Dim CaracteresPermitidos As String = "0123456789."

        Message.Append("El Descuento es incorrecto.")
        Message.Append(vbCrLf)

        If Not ValidarCaracteres(pDescuento, CaracteresPermitidos) OrElse ParteDescuento.Length > 2 Then
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        'Elimina los ceros a la izquierda del importe
        Parte = String.Empty
        For Index As Integer = 0 To ParteDescuento(0).Length - 1
            If ParteDescuento(0).Substring(Index, 1) <> 0 Then
                Parte = ParteDescuento(0).Substring(Index)
                Exit For
            End If
        Next
        If Parte <> String.Empty Then
            ParteDescuento(0) = Parte
        Else
            ParteDescuento(0) = 0
        End If

        If ParteDescuento.Length = 2 Then 'Se ingresó "." (decimal)
            Parte = String.Empty
            For Index As Integer = 0 To ParteDescuento(1).Length - 1
                If ParteDescuento(1).Substring(Index, 1) <> 0 Then
                    Parte = ParteDescuento(1).Substring(Index)
                    Exit For
                End If
            Next
            If Parte = String.Empty Then
                ParteDescuento(1) = 0
            End If
            If ParteDescuento(1).Length > 2 Then
                Message.Append("Los decimales del porcentaje deben ser menor a 99")
                Mensaje(Message.ToString, TipoMensaje.DeError)
                Return False
            End If
        End If
        If ParteDescuento(0) > 100 OrElse (ParteDescuento(0) = 100 AndAlso ParteDescuento.Length = 2 AndAlso ParteDescuento(1) > 0) Then
            Message.Append("El porcentaje debe ser menor o igual a 100")
            Mensaje(Message.ToString, TipoMensaje.DeError)
            Return False
        End If

        DescuentoFinal.Append(ParteDescuento(0))
        DescuentoFinal.Append(".")
        If ParteDescuento.Length = 2 Then
            DescuentoFinal.Append(ParteDescuento(1))
            If ParteDescuento(1).Length = 1 Then
                DescuentoFinal.Append("0")
            End If
        Else
            DescuentoFinal.Append("00")
        End If

        pTexto.Text = DescuentoFinal.ToString
        Return True
    End Function

    Private Function ValidarCaracteres(ByVal pValor As String, ByVal pCaracteresPermitidos As String) As Boolean
        Dim Existe As Boolean
        For Index As Integer = 0 To pValor.Length - 1
            Existe = False
            For IndexCaracter As Integer = 0 To pCaracteresPermitidos.Length - 1
                If pValor.Substring(Index, 1) = pCaracteresPermitidos.Substring(IndexCaracter, 1) Then
                    Existe = True
                    Exit For
                End If
            Next
            If Not Existe Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ValidarNuevaOrden() As Boolean
        If TxtCodSoporte.Text.Trim = String.Empty OrElse TxtSoporte.Text.Trim = String.Empty Then
            Mensaje("Debe seleccionar un Soporte.", TipoMensaje.Informacion)
            TxtCodSoporte.Focus()
            Return False
        End If
        If txtPrograma.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar un nombre de Programa.", TipoMensaje.Informacion)
            txtPrograma.Focus()
            Return False
        End If
        If txtHora.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar una Hora.", TipoMensaje.Informacion)
            txtHora.Focus()
            Return False
        End If
        If txtDuracion.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar una Duración.", TipoMensaje.Informacion)
            txtDuracion.Focus()
            Return False
        End If
        If Convert.ToInt32(txtDuracion.Text.Trim) <= 0 Then
            Mensaje("La Duración debe ser mayor a cero.", TipoMensaje.Informacion)
            txtDuracion.Focus()
            Return False
        End If
        If dtpFecha.Value Is Nothing Then
            Mensaje("Debe ingresar una Fecha.", TipoMensaje.Informacion)
            dtpFecha.Focus()
            Return False
        End If
        If TxtNetoTotal.Text.Trim = String.Empty Then
            Mensaje("Debe ingresar un importe.", TipoMensaje.Informacion)
            txtNeto.Focus()
            Return False
        End If
        If Convert.ToDouble(TxtNetoTotal.Text.Trim.Replace("$", "")) < 0 Then
            Mensaje("El importe debe ser mayor o igual a cero.", TipoMensaje.Informacion)
            txtNeto.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Metodos Publicos"
    Public Sub PopularDatos(ByVal pCod_Soporte As Integer, ByVal pPrograma As String, ByVal pHora As String, ByVal pDuracion As String, ByVal pFecha As DateTime, ByVal pNeto As Double)
        TxtCodSoporte.Text = pCod_Soporte
        Call TxtCodSoporte_LostFocus()
        txtPrograma.Text = pPrograma
        txtHora.Text = pHora
        txtDuracion.Text = pDuracion
        dtpFecha.Value = pFecha
        TxtBruto.Text = ObtenerNeto(Math.Round(pNeto / pDuracion, 2))
        Call AplicarFormatoImporte(TxtBruto)
        Call DescuentosSoloLectura(TxtBruto, 0)
        Call CalcularNeto()
        TxtBrutoTotal.Text = ObtenerNeto(pNeto)
        Call AplicarFormatoImporte(TxtBrutoTotal)
        TxtNetoTotal.Text = ObtenerNeto(pNeto)
        Call AplicarFormatoImporte(TxtNetoTotal)
    End Sub
#End Region

End Class

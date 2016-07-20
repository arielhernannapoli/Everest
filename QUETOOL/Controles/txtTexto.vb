Public Class txtTexto
    Inherits System.Windows.Forms.TextBox

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

        'lee los colores guardados
        If Not ColoresCargados Then

            Dim MapColor As New MapeoColores

            MapColor.LeerColores()

            ColorConFoco = MapColor.ColorConFoco
            LetraConFoco = MapColor.LetraConFoco

            ColoresCargados = True
        End If
    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

        ColoresCargados = False
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'txtTexto
        '
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Size = New System.Drawing.Size(256, 20)

    End Sub

#End Region

    'estas 2 variables son iguales para todas las intantacias
    Public Shared ColorConFoco As Color
    Public Shared LetraConFoco As Color
    Shared ColoresCargados As Boolean

    Dim mSoloNumero As Boolean
    Dim mSoloLetra As Boolean
    Dim mConDecimal As Boolean
    Dim mMaximo As Integer

    'esta depende del objeto
    Dim ColorSinFoco As Color
    Dim LetraSinFoco As Color

    'este evento se dispara cuando se presiona Enter + Control, y es para el caso
    'que el text se use para buscar una Opcion, tipo LookUp
    Public Event SePresionoBarra()

    Private Sub CajaTextoMejorada_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        'cada vez que toma el foco, guarda los colores que tiene (de fonfo y letra)
        'y pone los colores de seleccionado
        ColorSinFoco = Me.BackColor
        LetraSinFoco = Me.ForeColor

        Me.BackColor = ColorConFoco
        Me.ForeColor = LetraConFoco

        BarraEstado.MostrarInfo(Me.Tag)
    End Sub

    Private Sub CajaTextoMejorada_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'cambia los colores a los que tenia antes
        Me.BackColor = ColorSinFoco
        Me.ForeColor = LetraSinFoco
    End Sub

    Private Sub CajaTextoMejorada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'si se presiona la Barra, dispara el evento SePresionoBarra
        If e.KeyCode = Keys.Space Then
            RaiseEvent SePresionoBarra()
        End If
    End Sub

    Private Sub txtTexto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Not Me.Multiline And e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If

        If SoloLetra = True And Not e.KeyChar.IsLetter(e.KeyChar) Then
            'si no es back space, entonces anula la pulsacion de la tecla
            If e.KeyChar <> Chr(8) Then
                e.Handled = True
            End If
        End If

        If ConDecimal = True And Not e.KeyChar.IsDigit(e.KeyChar) Then

            If (e.KeyChar <> "." And e.KeyChar <> ",") Then
                If e.KeyChar <> Chr(8) Then
                    e.Handled = True
                End If
            Else
                If Me.Text.IndexOf(".") > -1 Or Me.Text.IndexOf(",") > -1 Then
                    e.Handled = True
                End If
            End If

        End If

        If SoloNumero = True And Not e.KeyChar.IsDigit(e.KeyChar) Then
            'si no es back space, entonces anula la pulsacion de la tecla
            If e.KeyChar <> Chr(8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Property SoloNumero() As Boolean
        Get
            Return mSoloNumero
        End Get
        Set(ByVal Value As Boolean)
            mSoloNumero = Value
        End Set
    End Property
    Public Property SoloLetra() As Boolean
        Get
            Return mSoloLetra
        End Get
        Set(ByVal Value As Boolean)
            mSoloLetra = Value
        End Set
    End Property

    Public Property ConDecimal() As Boolean
        Get
            Return mConDecimal
        End Get
        Set(ByVal Value As Boolean)
            mConDecimal = Value
        End Set
    End Property

    Public Property Maximo() As Integer
        Get
            Return mMaximo
        End Get
        Set(ByVal Value As Integer)
            mMaximo = Value
        End Set
    End Property

    Private Sub txtTexto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If Me.Text = "" Then
            Exit Sub
        End If

        If Maximo > 0 Then
            If Me.Text >= Maximo Then
                Me.Text = Maximo
            End If
        End If
    End Sub
End Class

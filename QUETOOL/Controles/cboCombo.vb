Public Class cboCombo
    Inherits Infragistics.Win.UltraWinGrid.UltraCombo

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
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'cboCombo
        '
        Me.Name = "cboCombo"
        Me.Size = New System.Drawing.Size(164, 92)

    End Sub

#End Region

    'estas 2 variables son iguales para todas las intantacias
    Public Shared ColorConFoco As Color
    Public Shared LetraConFoco As Color
    Shared ColoresCargados As Boolean

    'esta depende del objeto
    Dim ColorSinFoco As Color
    Dim LetraSinFoco As Color

    'este evento se dispara cuando se presiona Enter + Control, y es para el caso
    'que el text se use para buscar una Opcion, tipo LookUp
    Public Event SePresionoBarra()

    Private Sub cboCombo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        'cada vez que toma el foco, guarda los colores que tiene (de fonfo y letra)
        'y pone los colores de seleccionado
        ColorSinFoco = Me.BackColor
        LetraSinFoco = Me.ForeColor

        Me.Appearance.BackColor = ColorConFoco
        Me.Appearance.ForeColor = LetraConFoco

        BarraEstado.MostrarInfo(Me.Tag)
    End Sub

    Private Sub cboCombo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'cambia los colores a los que tenia antes
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.ForeColor = LetraSinFoco
    End Sub

    Private Sub cboCombo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'si se presiona la Barra, dispara el evento SePresionoBarra
        If e.KeyCode = Keys.Space Then
            RaiseEvent SePresionoBarra()
        End If

        'If e.KeyCode = Keys.Delete Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub cboCombo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
            e.Handled = True
        End If
    End Sub
End Class

Public Class frmAviso
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
    Friend WithEvents lstTemas As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lstTemas = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstTemas
        '
        Me.lstTemas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTemas.Location = New System.Drawing.Point(0, 0)
        Me.lstTemas.Name = "lstTemas"
        Me.lstTemas.Size = New System.Drawing.Size(264, 132)
        Me.lstTemas.TabIndex = 0
        '
        'frmAviso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(258, 130)
        Me.Controls.Add(Me.lstTemas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Tema"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Grilladmin As New Grilladmin
    Private mTema As String
    Private mSalir As Boolean
    Property Salir() As Boolean
        Get
            Return mSalir
        End Get
        Set(ByVal Value As Boolean)
            mSalir = Value
        End Set
    End Property
    Public Property Tema() As String
        Get
            Return mTema
        End Get
        Set(ByVal Value As String)
            mTema = Value
        End Set
    End Property

    Private Sub frmAviso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function CargarTemas(ByVal TemasSelecionados As String)
        mTema = ""
        mSalir = False
        Dim Cadena As String = "", Item As ItemLista
        Dim Temas As New Temas, Tema As DataTable
        Temas.Id_campania = Activo.IDCampaña
        Tema = Temas.ObtenerTemasPorCampaña


        For Each c As Char In TemasSelecionados
            If Cadena.IndexOf(c) < 0 Then
                Cadena &= UCase(c)
            End If
        Next
        For Each c As Char In Cadena
            Item = New ItemLista
            Item.Descripcion = Grilladmin.ObtenerDato(Tema, "id_tema='" & c & "'", "Tema")
            Item.ID = c
            lstTemas.Items.Add(Item)
        Next
        lstTemas.DisplayMember = "Descripcion"
        lstTemas.ValueMember = "ID"

    End Function

    Private Sub lstTemas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTemas.SelectedIndexChanged

    End Sub

    Private Sub lstTemas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstTemas.DoubleClick
        If lstTemas.SelectedItems.Count <= 0 Then
            Exit Sub
        End If
        mTema = DirectCast(lstTemas.SelectedItem, ItemLista).ID

        Me.Close()
    End Sub

    Private Sub frmAviso_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.mTema = "" Then
            mSalir = True
        End If
    End Sub
End Class

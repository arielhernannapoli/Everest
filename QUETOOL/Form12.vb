Imports MPG.DBL
Imports Oracle.DataAccess.Client

Public Class Form1
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 85)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim A As New Agencia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A.Agencia = 1

        A.BuscarPorID()

        MsgBox(A.Nombre)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Aa()
        Dim Cn As New OracleConnection

        Cn.ConnectionString = "User Id=quetool;Password=ketul;Data Source=quetool;"

        Dim Cmd As New OracleCommand

        Cmd.Connection = Cn
        Cmd.CommandText = "spk_agencias.sp_select_all"
        Cmd.CommandType = CommandType.StoredProcedure

        'Cmd.Connection = Cn
        'Cmd.CommandText = "select * from agencias"
        'Cmd.CommandType = CommandType.Text

        Cmd.Parameters.Add("CursorSalida", OracleDbType.RefCursor, ParameterDirection.Output)

        Cn.Open()

        Dim Dr As OracleDataReader

        Try
            Dr = Cmd.ExecuteReader
        Catch ex As OracleException
            MsgBox(ex.Message)
        End Try

        Dr.Read()

        MsgBox(Dr("Agencia"))
    End Sub

    Private Sub B()
        Dim Cn As New OracleConnection

        Cn.ConnectionString = "User Id=quetool;Password=ketul;Data Source=quetool;"

        Dim Cmd As New OracleCommand

        Cmd.Connection = Cn
        Cmd.CommandText = "spk_agencias.sp_select"
        Cmd.CommandType = CommandType.StoredProcedure

        'Cmd.Connection = Cn
        'Cmd.CommandText = "select * from agencias"
        'Cmd.CommandType = CommandType.Text

        Cmd.Parameters.Add("P_Agencia", OracleDbType.Int64, 1, ParameterDirection.Input)
        Cmd.Parameters.Add("CursorSalida", OracleDbType.RefCursor, ParameterDirection.Output)

        Cn.Open()

        Dim Dr As OracleDataReader

        Try
            Dr = Cmd.ExecuteReader
        Catch ex As OracleException
            MsgBox(ex.Message)
        End Try

        Dr.Read()

        MsgBox(Dr("Agencia"))
    End Sub
End Class

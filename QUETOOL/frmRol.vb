Imports MSL
Public Class frmRol

    Public Enum Rol
        Control = 1
        Planificacion = 2
    End Enum

    Dim mRol As Rol

    Public Property pRol() As Rol
        Get
            Return mRol
        End Get
        Set(ByVal value As Rol)
            mRol = value
        End Set
    End Property

    Private Sub frmRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdControl.Click
        mRol = Rol.Control
        Me.Close()
    End Sub

    Private Sub cmdPlanif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlanif.Click
        mRol = Rol.Planificacion
        Me.Close()
    End Sub


End Class
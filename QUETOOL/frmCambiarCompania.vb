Imports MSL

Public Class frmCambiarCompania
    Inherits System.Windows.Forms.Form
    'es para que el form que llama, sepa si se apreto cancelar
    Public Cancelar As Boolean
    'es para saber si esta cargando por 1ra vez o se esta cambiando de cliente
    Public CargandoPrimeraVez As Boolean
    Shared vIdCompania As Short
    Shared vIdDelegacion As Integer

    Public Shared Property IdCompania() As Short
        Get
            Return vIdCompania
        End Get
        Set(ByVal Value As Short)
            vIdCompania = Value
        End Set
    End Property

    Public Shared Property IdDelegacion() As Integer
        Get
            Return vIdDelegacion
        End Get
        Set(ByVal Value As Integer)
            vIdDelegacion = Value
        End Set
    End Property

    Dim mUsuario As String
    Dim mContrasenia As String
    Public Property User() As String
        Get
            Return mUsuario
        End Get
        Set(ByVal Value As String)
            mUsuario = Value
        End Set
    End Property

    Public Property Contrasenia() As String
        Get
            Return mContrasenia
        End Get
        Set(ByVal Value As String)
            mContrasenia = Value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Me.IdCompania = Convert.ToInt16(CboCompania.SelectedRow.Cells.All.GetValue(0).Text)
        Me.IdDelegacion = Convert.ToInt32(CboDelegacion.SelectedRow.Cells.All.GetValue(0).Text)
        HabilitarControles(False, "Asignando compañía...")
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim OMsl As New Maestros
        OMsl.CambiarCompania(IdCompania, IdDelegacion)

        'AG Velocidad Cache ===========================================================
        Activo.DTClientesCache = OMsl.ClientesTraerTodos(MSL.Constantes.COD_PAIS_ARGENTINA)
        '===============================================================================

        'lblCompania.Text = OMsl.ObtenerDescripcionCompaniaActual

        'Dim Archivo As String = "C:\Archivos de Programa\MPG\Quetool\Perfiles\"
        'Ariel-->
        Dim XML As New AMS.Profile.Xml(FuncionesRuta.RutaAppDataUsuarioPerfiles & "usuario.xml")
        '-->Ariel
        XML.SetValue("login", "usuario", User)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HabilitarControles(True, "")
        Dim U As New Usuario
        U.Login = User
        U.ValidarUsuario(User, Contrasenia)
        Cancelar = False
        Me.Hide()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Cancelar = True

        Me.Close()
    End Sub

    Private Sub frmCambiarCompania_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCompania()
        Me.marqueeCarga.Enabled = False
        If CargandoPrimeraVez Then
            cmdCancelar.Visible = False

            cmdAceptar.Left = cmdCancelar.Left
            cmdAceptar.Top = cmdCancelar.Top
        End If
    End Sub

    Private Sub HabilitarControles(ByVal habilitado As Boolean, ByVal accion As String)

        marqueeCarga.Enabled = Not habilitado
        marqueeCarga.Text = accion
        marqueeCarga.Properties.ShowTitle = Not habilitado

        CboDelegacion.Enabled = habilitado
        CboDelegacion.Enabled = habilitado
        cmdAceptar.Enabled = habilitado
        cmdCancelar.Enabled = habilitado

    End Sub

    Private Sub CargarCompania()
        Dim comp As New Compania
        Listas.CargarCombo(Me.CboCompania, comp.ObtenerCompanias, "COD_COMPANIA", "DESCRIPCION")

        Listas.OcultarColumnas(CboCompania, "COD_COMPANIA")
        Listas.OcultarHeader(CboCompania)
        CboCompania.SelectedRow = CboCompania.Rows(0)
    End Sub

    Private Sub CargarDelegaciones(ByVal id_compania As Short)
        Dim comp As New Compania
        Listas.CargarCombo(Me.CboDelegacion, comp.ObtenerDelegacionByCodCompania(id_compania), "COD_DELEGACION", "DESCRIPCION")

        Listas.OcultarColumnas(CboDelegacion, "COD_DELEGACION")
        Listas.OcultarHeader(CboDelegacion)
        CboDelegacion.SelectedRow = CboDelegacion.Rows(0)
    End Sub

    Private Sub CboCompania_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCompania.ValueChanged
        If (CboCompania.SelectedRow IsNot Nothing) Then
            Call CargarDelegaciones(Convert.ToInt16(CboCompania.SelectedRow.Cells.All.GetValue(0).Text))
        End If
    End Sub
End Class
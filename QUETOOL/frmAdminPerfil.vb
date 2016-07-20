Imports MPG.DBL
Imports System.Text
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Framework.Mensajes
Imports Infragistics.Win.Printing
Imports MSL
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Shared
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frmAdminPerfil

#Region "Variables"

    Dim ObjUsuario As Usuario
    Dim GrillaFormato As New GrillaFormato
    Private vlistPerfiles As ValueList
    Dim mTBusqueda As Integer
    Dim mTPerfil As Integer
    Dim ControlRefresco As Boolean = False
    Dim DtUsuPerfiles As New DataTable

#End Region

#Region "Propiedades"

    Public Property TBusqueda() As Integer
        Get
            Return mTBusqueda
        End Get
        Set(ByVal Value As Integer)
            mTBusqueda = Value
        End Set
    End Property

    Public Property TPerfil() As Integer
        Get
            Return mTPerfil
        End Get
        Set(ByVal Value As Integer)
            mTPerfil = Value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmAdminPerfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatosCabecera()
        HabilitarControles()
        Me.rdConPermiso.Checked = True
        Me.rdSinPermiso.Checked = False
    End Sub

    Private Sub iugUsuario_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles iugUsuario.CellChange

        Dim IndiceResultadoValidacion As Integer
        Dim IndiceResultadoBusqueda As Integer

        Select Case e.Cell.Column.Key
            Case "ID_PERMISO"
                Me.txtFoco.Focus()
                If mTBusqueda = TipoBusqueda.UsuarioSinAsignacio Then
                    Me.iugUsuario.ActiveRow.Cells("ESTADO").Value = TipoEstadoOperacion.Alta
                ElseIf mTBusqueda = TipoBusqueda.UsuarioConAsignacio Then
                    Me.iugUsuario.ActiveRow.Cells("ESTADO").Value = TipoEstadoOperacion.Modificar
                End If
        End Select
    End Sub

    Private Sub iugUsuario_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugUsuario.InitializeLayout

        OcultarColumnas()
        CambiarFormatoColumnasDropDownList(e)
        Me.iugUsuario.DisplayLayout.Override.RowSelectors = DefaultableBoolean.True
        Me.iugUsuario.DisplayLayout.Override.CellClickAction = CellClickAction.Edit

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        EjecutarOperacionDB()
        RefrescarGrillaAsignados()
    End Sub

    Private Sub btobuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btobuscar.Click
        If mTBusqueda = TipoBusqueda.UsuarioConAsignacio Then

            Dim DtUsuConPerfiles As New DataTable
            ObjUsuario = New Usuario

            DtUsuConPerfiles = ObjUsuario.ObtenerUsuariosConPermisos
            DtUsuPerfiles = DtUsuConPerfiles

            If Not DtUsuConPerfiles Is Nothing Then
                If DtUsuConPerfiles.Rows.Count > 0 Then
                    mTBusqueda = TipoBusqueda.UsuarioConAsignacio
                    Me.iugUsuario.DataSource = DtUsuConPerfiles
                    txtregistrosCantidad.Text = DtUsuConPerfiles.Rows.Count.ToString
                    CambiarNombreColumnas()
                    OcultarColumnas()
                    AliniarDatosCeldas()
                    AliniaTitulosColumnas()
                    HabilitarColumnasCargaInicial()
                    GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
                Else
                    Me.iugUsuario.DataSource = DtUsuConPerfiles
                    txtregistrosCantidad.Text = "0"
                    CambiarNombreColumnas()
                    OcultarColumnas()
                    AliniarDatosCeldas()
                    AliniaTitulosColumnas()
                    HabilitarColumnasCargaInicial()
                    GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
                    MsgBox("No se encontraron Usuarios Cargados.!", MsgBoxStyle.Information)
                End If
            End If

        ElseIf mTBusqueda = TipoBusqueda.UsuarioSinAsignacio Then

            ObjUsuario = New Usuario
            Dim DtUsuSinPerfiles As New DataTable

            DtUsuSinPerfiles = ObjUsuario.ObtenerUsuariosSinPermisos()
            DtUsuPerfiles = DtUsuSinPerfiles

            If Not DtUsuSinPerfiles Is Nothing Then
                If DtUsuSinPerfiles.Rows.Count > 0 Then
                    mTBusqueda = TipoBusqueda.UsuarioSinAsignacio
                    Me.iugUsuario.DataSource = DtUsuSinPerfiles
                    txtregistrosCantidad.Text = DtUsuSinPerfiles.Rows.Count.ToString
                    CambiarNombreColumnas()
                    OcultarColumnas()
                    AliniarDatosCeldas()
                    AliniaTitulosColumnas()
                    HabilitarColumnasCargaInicial()
                    GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
                Else
                    mTBusqueda = TipoBusqueda.UsuarioSinAsignacio
                    Me.iugUsuario.DataSource = DtUsuSinPerfiles
                    txtregistrosCantidad.Text = "0"
                    CambiarNombreColumnas()
                    OcultarColumnas()
                    AliniarDatosCeldas()
                    AliniaTitulosColumnas()
                    HabilitarColumnasCargaInicial()
                    GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
                    MsgBox("No se existen Usuarios nuevos.!", MsgBoxStyle.Information)
                End If
            End If

        End If

        txtFiltroapellido.Text = ""
    End Sub

    Private Sub rdSinPermiso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdSinPermiso.CheckedChanged
        mTBusqueda = TipoBusqueda.UsuarioSinAsignacio
        txtFiltroapellido.Text = ""
        If Me.iugUsuario.Rows.Count > 0 Then
            If ControlRefresco = False Then
                DtUsuPerfiles = BlanqueoGrilla()
                ControlRefresco = False
            End If
        End If
    End Sub

    Private Sub rdConPermiso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdConPermiso.CheckedChanged
        mTBusqueda = TipoBusqueda.UsuarioConAsignacio
        txtFiltroapellido.Text = ""
        If Me.iugUsuario.Rows.Count > 0 Then
            If ControlRefresco = False Then
                DtUsuPerfiles = BlanqueoGrilla()
                ControlRefresco = False
            End If
        End If
    End Sub

    Private Sub txtFiltroapellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroapellido.TextChanged
        Dim Filtro As String

        Dim Texto As String = txtFiltroapellido.Text.ToUpper
        Texto = Texto.Replace("'", "''")
        Filtro = "NOMBRE like '%" & Texto & "%'"

        If DtUsuPerfiles.Rows.Count > 0 Then
            Me.iugUsuario.DataSource = Me.FiltrarDT(DtUsuPerfiles, Filtro, "NOMBRE ASC")
            CambiarNombreColumnas()
            OcultarColumnas()
            AliniarDatosCeldas()
            AliniaTitulosColumnas()
            HabilitarColumnasCargaInicial()
            GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub RefrescarGrillaAsignados()

        Dim DtUsuConPerfiles As New DataTable
        ObjUsuario = New Usuario

        DtUsuConPerfiles = ObjUsuario.ObtenerUsuariosConPermisos

        If Not DtUsuConPerfiles Is Nothing Then
            If DtUsuConPerfiles.Rows.Count > 0 Then
                mTBusqueda = TipoBusqueda.UsuarioConAsignacio
                DtUsuPerfiles = DtUsuConPerfiles
                txtregistrosCantidad.Text = DtUsuPerfiles.Rows.Count.ToString
                Me.iugUsuario.DataSource = DtUsuConPerfiles
                CambiarNombreColumnas()
                OcultarColumnas()
                AliniarDatosCeldas()
                AliniaTitulosColumnas()
                HabilitarColumnasCargaInicial()
                GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)
                ControlRefresco = True
                Me.rdConPermiso.Checked = True
                Me.rdSinPermiso.Checked = False
                ControlRefresco = False
                MsgBox("Los Perfiles seleccionados han sido actualizados. ", MsgBoxStyle.Information)
            Else
                BlanqueoGrilla()
                txtregistrosCantidad.Text = "0"
            End If
        End If

    End Sub

    Private Function BlanqueoGrilla() As DataTable

        Dim DtGrillaBanqueo As New DataTable
        ObjUsuario = New Usuario

        DtGrillaBanqueo = ObjUsuario.BlanqueoGrilla
        Me.iugUsuario.DataSource = DtGrillaBanqueo
        CambiarNombreColumnas()
        OcultarColumnas()
        AliniarDatosCeldas()
        AliniaTitulosColumnas()
        HabilitarColumnasCargaInicial()
        GrillaFormato.AutoAjustarColumnas(Me.iugUsuario)

        Return DtGrillaBanqueo
    End Function


    Private Sub CargarDatosCabecera()

        Me.txtnomadmin.Text = Activo.Nombre.ToUpper
        Me.txtapeadmin.Text = Activo.Apellido1.ToUpper
        Me.dtpFecha.Value = Date.Now

    End Sub

    Private Sub HabilitarControles()

        Me.txtnomadmin.ReadOnly = True
        Me.txtapeadmin.ReadOnly = True
        Me.dtpFecha.ReadOnly = True

        Me.txtnomadmin.BackColor = Color.GhostWhite
        Me.txtapeadmin.BackColor = Color.GhostWhite
        Me.dtpFecha.Value = Color.GhostWhite

    End Sub

    Private Sub OcultarColumnas()
        Listas.OcultarColumnas(Me.iugUsuario, "ESTADO")
        Listas.OcultarColumnas(Me.iugUsuario, "COD_USUARIO")
    End Sub

    Private Sub CambiarNombreColumnas()

        Listas.CambiarTituloColumna(Me.iugUsuario, "LOGIN", "Usuario")
        Listas.CambiarTituloColumna(Me.iugUsuario, "NOMBRE", "Nombre Apellido")
        Listas.CambiarTituloColumna(Me.iugUsuario, "ID_PERMISO", "Rol Usuario")

    End Sub

    Private Sub CambiarFormatoColumnasDropDownList(ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)

        AplicarFormatoDropDownList(e.Layout.Bands(0).Columns("ID_PERMISO"))

    End Sub

    Private Sub AplicarFormatoDropDownList(ByRef pColumna As UltraGridColumn)

        Dim Lista As ValueList

        Select Case pColumna.Key
            Case "ID_PERMISO"
                Lista = ObtenerPerfiles()
        End Select

        With pColumna
            .ValueList = Lista
            .Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
            .ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Width = 140
        End With

    End Sub

    Private Function ObtenerPerfiles() As ValueList

        Dim DtPerfiles As New DataTable
        ObjUsuario = New Usuario
        vlistPerfiles = New ValueList


        If mTBusqueda = TipoBusqueda.UsuarioConAsignacio Then
            DtPerfiles = ObjUsuario.PerfilesExistente
        ElseIf mTBusqueda = TipoBusqueda.UsuarioSinAsignacio Then
            DtPerfiles = ObjUsuario.PerfilesNuevos
            vlistPerfiles.ValueListItems.Add(0, "--")
        End If


        If Not DtPerfiles Is Nothing Then
            For Each RowPerfil As DataRow In DtPerfiles.Rows
                vlistPerfiles.ValueListItems.Add(RowPerfil("ID_PERFIL"), RowPerfil("DESCRIPCION"))
            Next
        End If

        Return vlistPerfiles

    End Function

    Private Sub AliniarDatosCeldas()

        With iugUsuario.DisplayLayout.Bands(0)
            .Columns("LOGIN").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("NOMBRE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
            .Columns("ID_PERMISO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Left
        End With

    End Sub

    Private Sub AliniaTitulosColumnas()

        With iugUsuario.DisplayLayout.Bands(0)
            .Columns("LOGIN").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("NOMBRE").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ID_PERMISO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        End With

    End Sub

    Private Sub InhabilitarFila(ByVal RowGrilla As UltraGridRow)

        GrillaFormato.HabilitarCelda(RowGrilla.Cells("LOGIN"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("NOMBRE"), Activation.NoEdit)
        GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_PERMISO"), Activation.AllowEdit)

    End Sub

    Private Sub HabilitarColumnasCargaInicial()

        If Not Me.iugUsuario.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.iugUsuario.Rows
                GrillaFormato.HabilitarCelda(RowGrilla.Cells("LOGIN"), Activation.NoEdit)
                GrillaFormato.HabilitarCelda(RowGrilla.Cells("NOMBRE"), Activation.NoEdit)
                GrillaFormato.HabilitarCelda(RowGrilla.Cells("ID_PERMISO"), Activation.AllowEdit)
                InhabilitarFila(RowGrilla)
            Next
        End If
    End Sub

    Private Function EjecutarOperacionDB() As Integer

        ObjUsuario = New Usuario

        If Not Me.iugUsuario.Rows Is Nothing Then
            For Each RowGrilla As UltraGridRow In Me.iugUsuario.Rows
                If RowGrilla.Cells("ESTADO").Value = TipoEstadoOperacion.Modificar Then
                    If mTBusqueda = TipoBusqueda.UsuarioConAsignacio Then
                        If RowGrilla.Cells("ID_PERMISO").Value = TipoPerfil.Vaciar_Blanquear Then
                            ObjUsuario.Borrar_PermisosUsuario(Activo.IDUsuarioMMS, RowGrilla.Cells("COD_USUARIO").Value)
                        ElseIf RowGrilla.Cells("ID_PERMISO").Value = TipoPerfil.Control_Convenios_todo Then
                            ObjUsuario.Alta_Update_PermisosUsuario(Activo.IDUsuarioMMS, RowGrilla.Cells("COD_USUARIO").Value, RowGrilla.Cells("ID_PERMISO").Value)
                        ElseIf RowGrilla.Cells("ID_PERMISO").Value = TipoPerfil.Control_Convenios Then
                            ObjUsuario.Alta_Update_PermisosUsuario(Activo.IDUsuarioMMS, RowGrilla.Cells("COD_USUARIO").Value, RowGrilla.Cells("ID_PERMISO").Value)
                        ElseIf RowGrilla.Cells("ID_PERMISO").Value = TipoPerfil.Convenios_Solo Or RowGrilla.Cells("ID_PERMISO").Value = TipoPerfil.Normal Then
                            ObjUsuario.Alta_Update_PermisosUsuario(Activo.IDUsuarioMMS, RowGrilla.Cells("COD_USUARIO").Value, RowGrilla.Cells("ID_PERMISO").Value)
                        End If
                    End If
                ElseIf RowGrilla.Cells("ESTADO").Value = TipoEstadoOperacion.Alta Then
                    If mTBusqueda = TipoBusqueda.UsuarioSinAsignacio Then
                        ObjUsuario.Alta_Update_PermisosUsuario(Activo.IDUsuarioMMS, RowGrilla.Cells("COD_USUARIO").Value, RowGrilla.Cells("ID_PERMISO").Value)
                    End If
                End If
            Next
            txtFiltroapellido.Text = ""
        End If
    End Function

    Private Function FiltrarDT(ByVal Dt As DataTable, ByVal Filtro As String, ByVal Orden As String) As DataTable

        Dim Filas As DataRow()
        Dim DtNuevo As DataTable

        DtNuevo = Dt.Clone()
        Filas = Dt.Select(Filtro, Orden)

        For Each Dr As DataRow In Filas
            DtNuevo.ImportRow(Dr)
        Next

        Return DtNuevo

    End Function

#End Region

    Public Enum TipoPerfil
        Vaciar_Blanquear = -1
        Normal = 0
        Control_Convenios_todo = 1
        Control_Convenios = 2
        Convenios_Solo = 3
    End Enum

    Public Enum TipoBusqueda
        UsuarioConAsignacio = 0
        UsuarioSinAsignacio = 1
    End Enum

    Public Enum TipoEstadoOperacion
        Mostrar = 0
        Alta = 1
        Modificar = 2
        Eliminar = 3
    End Enum


End Class
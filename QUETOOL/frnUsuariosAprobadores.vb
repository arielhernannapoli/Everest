Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win.Printing

Public Class frnUsuariosAprobadores

    Dim _DtUsuarios As New DataTable
    Dim GrillaFormato As New GrillaFormato
    Dim DtFinal As DataTable

    Public Property DtUsuarios() As DataTable
        Get
            Return _DtUsuarios
        End Get
        Set(ByVal value As DataTable)
            _DtUsuarios = value
        End Set
    End Property

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        CargarDtSeleccion()

        If DtFinal.Rows.Count > 0 Then
            With frmMantenimientoConvenio.Instancia
                .txtUsuariosAutorizados.Text = ""
                .txtUsuariosAutorizados.Text = ArmarTextoUsuarios(DtFinal)
                .dtUsuarioSeleccionado = DtFinal
                Me.Close()
            End With
        Else
            MsgBox("Debe seleccionar el o los usuarios autorizadores", MsgBoxStyle.Information, "Everest")
        End If

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click

        With frmMantenimientoConvenio.Instancia
            .txtUsuariosAutorizados.Text = ""
            .dtUsuarioSeleccionado = Nothing
            Me.Close()
        End With

    End Sub

    Private Sub frnUsuariosAprobadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.uigUsuarios.DataSource = _DtUsuarios
        FormatoGrillas()

    End Sub

    Private Sub FormatoGrillas()

        Listas.CambiarTituloColumna(Me.uigUsuarios, "USUARIO", "Usuario")
        Listas.CambiarTituloColumna(Me.uigUsuarios, "Seleccion", "Seleccion")
        Listas.OcultarColumnas(Me.uigUsuarios, "COD_USUARIO")

        GrillaFormato.HabilitarEdicionColumna(Me.uigUsuarios, Activation.NoEdit, "USUARIO")
   

        With Me.uigUsuarios.DisplayLayout.Bands(0)
            .Columns("USUARIO").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Seleccion").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("USUARIO").Width = 250
            .Columns("Seleccion").Width = 70
        End With

    End Sub

    Private Function CargarDtSeleccion() As DataTable

        Dim DrFilaFinal As DataRow
        DtFinal = New DataTable

        DtFinal = _DtUsuarios.Clone

        If Not Me.uigUsuarios.Rows Is Nothing Then
            For Each RowUsuario As UltraGridRow In uigUsuarios.Rows
                If RowUsuario.Cells("Seleccion").Value = True Then
                    DrFilaFinal = DtFinal.NewRow()
                    DrFilaFinal("COD_USUARIO") = RowUsuario.Cells("COD_USUARIO").Value
                    DrFilaFinal("usuario") = RowUsuario.Cells("USUARIO").Value
                    DtFinal.Rows.Add(DrFilaFinal)
                    DtFinal.AcceptChanges()
                End If
            Next
        End If

        Return DtFinal

    End Function

    Private Function ArmarTextoUsuarios(ByVal Dt As DataTable) As String

        Dim Texto As String
        Dim CantTotalLetas As Integer
        Dim TextoFinal As String


        If Dt.Rows.Count > 0 Then
            For Each RowUusario As DataRow In Dt.Rows
                Texto += RowUusario("USUARIO").ToString() + ";" + vbCrLf
            Next
        End If

        CantTotalLetas = Texto.Length
        TextoFinal = Texto.Substring(0, CantTotalLetas - 4)

        Return TextoFinal


    End Function



End Class
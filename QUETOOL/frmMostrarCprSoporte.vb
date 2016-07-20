Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Shared


Public Class frmMostrarCprSoporte

#Region "Declaracion Variables"

    Dim _ListaSoportes As DataTable
    Dim DtTDGrilla As New DataTable
    Dim GF As GrillaFormato
    Dim mCancelar As Boolean
    Public Shared SeleccionSoporte As New ArrayList
    Private mEsPrimeraSeleccion As Boolean
    Dim DtSoporteDistint As New DataTable

#End Region

#Region "Propiedades"

    Public Property EsPrimeraSeleccion() As Boolean
        Get
            Return mEsPrimeraSeleccion
        End Get
        Set(ByVal value As Boolean)
            mEsPrimeraSeleccion = value
        End Set
    End Property

    Public Property ListaSoportes() As DataTable
        Get
            Return _ListaSoportes
        End Get
        Set(ByVal Value As DataTable)
            _ListaSoportes = Value
        End Set
    End Property
    

    Public Property Cancelar() As Boolean
        Get
            Return mCancelar
        End Get
        Set(ByVal value As Boolean)
            mCancelar = value
        End Set
    End Property


#End Region

#Region "Eventos"

    Private Sub frmMostrarCprSoporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        GF = New GrillaFormato
        DtSoporteDistint = _ListaSoportes.DefaultView.ToTable(True, "Id_soporte", "Descripcion", "CPR")
        Me.iugCPRSoporte.DataSource = DtSoporteDistint
        GF.AutoAjustarColumnas(Me.iugCPRSoporte)
        FormatoGrillaSoporteCpr()

    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click

        Dim DrDatos As DataRow
        Dim Idsoporte As Integer
        Dim i As Integer

        For Each DrDatos In DtSoporteDistint.Rows
            IdSoporte = DrDatos("id_soporte")
            For i = 0 To iugCPRSoporte.Rows.Count - 1
                If iugCPRSoporte.Rows(i).Cells("id_soporte").Value = Idsoporte Then
                    DrDatos("CPR") = IIf(IsDBNull(iugCPRSoporte.Rows(i).Cells("CPR").Value), 0, iugCPRSoporte.Rows(i).Cells("CPR").Value)
                End If
            Next
        Next

        If frmCpEjercicio.Instancia.DtSoportesCpr Is Nothing Then
            frmCpEjercicio.Instancia.DtSoportesCpr = Me.DtSoporteDistint.Copy
        Else
            frmCpEjercicio.Instancia.DtSoportesCpr = Me.DtSoporteDistint.Copy
        End If
        Me.Close()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"


    Private Sub FormatoGrillaSoporteCpr()

        GF = New GrillaFormato
        '-------- Cambio Aliniacion ------------
        GF.CambiarAlineacionColumna(Me.iugCPRSoporte, "Descripcion", HAlign.Left)
        GF.CambiarAlineacionColumna(Me.iugCPRSoporte, "CPR", HAlign.Left)
        '-------- Oculto Columnas ------------
        Listas.CambiarTituloColumna(iugCPRSoporte, "Descripcion", "Soporte")
        Listas.CambiarTituloColumna(iugCPRSoporte, "CPR", "CPR´s")
        'AG CP +++++++++++++++++++++++++++++++++++++++++++++++++
        If Activo.IDCliente = 64 Then ' Cliente Loreal
            GF.CambiarFormatoColumna(iugCPRSoporte, "CPR", Formato.Numero)
        ElseIf Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then 'Cliente Claro
            GF.CambiarFormatoColumna(iugCPRSoporte, "CPR", Formato.Decimales)
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Listas.OcultarColumnas(Me.iugCPRSoporte, "Id_soporte")
        GF.HabilitarEdicionColumna(iugCPRSoporte, Activation.AllowEdit, "CPR")
        GF.HabilitarEdicionColumna(Me.iugCPRSoporte, Activation.NoEdit, "Descripcion")
        GF.AutoAjustarColumnas(iugCPRSoporte)

    End Sub

    Private Function ArmarEstructuraGrillaCPR() As DataTable

        'Esta bien
        Dim DtCprSoporte As New DataTable

        With DtCprSoporte
            .Columns.Add("IdSoporte", GetType(Integer))
            .Columns.Add("Descripcion", GetType(String))
            'AG CP 01/09/2011 ++++++++++++++++++++++
            If Activo.IDCliente = 64 Then 'Cliente Loreal
                .Columns.Add("CPR", GetType(String))
            ElseIf Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then 'Cliente Claro
                .Columns.Add("CPR", GetType(String))
            End If
            '+++++++++++++++++++++++++++++++++++
            .AcceptChanges()
        End With

        Return DtCprSoporte

    End Function

#End Region

    Private Sub iugCPRSoporte_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles iugCPRSoporte.CellDataError
        If Me.iugCPRSoporte.ActiveCell Is Nothing Then
            Exit Sub
        End If

        With iugCPRSoporte.ActiveCell.Column
            Select Case .Key
                Case "CPR"
                    'AG CP 01/09/2011 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    If Activo.IDCliente = 64 Then ' Cliente Loreal
                        If Not .DataType Is GetType(String) Then
                            Mensajes.Mensaje("Este campo solo admite numeros sin decimales", TipoMensaje.Informacion)
                            e.RestoreOriginalValue = True
                        End If
                    ElseIf Activo.IDCliente = 319 Or Activo.IDCliente = 2 Or Activo.IDCliente = 0 Or Activo.IDCliente = 2339 Or Activo.IDCliente = 2452 Or Activo.IDCliente = 2453 Then 'Cliente Claro
                        If Not .DataType Is GetType(String) Then
                            Mensajes.Mensaje("Este campo solo admite numeros con 2 decimales", TipoMensaje.Informacion)
                            e.RestoreOriginalValue = True
                        End If
                    End If
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            End Select
        End With
        e.RaiseErrorEvent = False
    End Sub

    
    Private Sub iugTarifasSeleccionadas_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles iugCPRSoporte.InitializeLayout
        Me.iugCPRSoporte.DisplayLayout.Override.CellClickAction = CellClickAction.Edit
    End Sub

    Private Sub iugCPRSoporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles iugCPRSoporte.KeyDown

        Dim EnEdicion As Boolean = iugCPRSoporte.ActiveCell.IsInEditMode

        If Not iugCPRSoporte.ActiveRow Is Nothing AndAlso Me.iugCPRSoporte.ActiveRow.Selected Then
            If e.KeyCode = Keys.Delete Then
                If Not iugCPRSoporte.ActiveCell Is Nothing Then
                    If Not iugCPRSoporte.ActiveCell.IsInEditMode Then
                        iugCPRSoporte.ActiveCell.Value = ""
                    End If
                End If
            End If
        End If

        Select Case e.KeyValue

            Case Keys.Delete
                iugCPRSoporte.ActiveCell.Value = 0

            Case Keys.Enter, Keys.F2
                e.Handled = True

                If EnEdicion Then
                    iugCPRSoporte.PerformAction(ExitEditMode, False, False)
                Else
                    iugCPRSoporte.PerformAction(EnterEditMode, False, False)
                End If
                iugCPRSoporte.UpdateData()

        End Select

    End Sub
End Class



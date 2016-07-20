Public Class Grilla
    Shared mCeldasCopiadas As ArrayList

    Public Shared Property CeldasCopiadas() As ArrayList
        Get
            If mCeldasCopiadas Is Nothing Then
                mCeldasCopiadas = New ArrayList
            End If

            Return mCeldasCopiadas
        End Get
        Set(ByVal Value As ArrayList)
            mCeldasCopiadas = Value
        End Set
    End Property

    'AG 22/10/2013 =================================================
    Public Sub CargarInternet(ByVal Medio As Medios)

        frmPrincipal.Instancia.Cursor = Cursors.WaitCursor
        Dim fs As New frmFiltrarSoporteInternet
        ' Dim Fp As New frmProgresoCargaGrilla
        Dim Ejer As EjercicioActivo


      

        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio

        Activo.EjerciciosCargados.Add(Ejer)

        Dim S As Object
        Dim Ej As New frmEjerciciosInternet ' frmEjercicioInternet 'frmEjerciciosInternet  'AG 22/10/2013 DIGITAL

        If Medio = Medios.Internet Then
            S = New Spots_int
        End If

        If Activo.FechaInicioSistema.Year < 1900 Then
            Dim si As New Sistemas
            si.Id_campania = Activo.IDCampaña
            si.Id_sistema = Activo.IDSistema
            si.BuscarPorID()
            Activo.FechaFinSistema = si.F_fin
            Activo.FechaInicioSistema = si.F_inicio
            Activo.IDPlaza = si.ID_Plaza
            Activo.IDTipoSoporte = si.Id_tipo_soporte
        End If

        'AG Obtengo el Cache de Servicio Agencia Internet =====
        Dim OSerAgenciaInternet As New Servico_Agencia
        OSerAgenciaInternet.Id_Compania = CInt(Activo.IDCompaniaMMS)
        OSerAgenciaInternet.Id_Cliente = Activo.IDCliente
        OSerAgenciaInternet.FDesde = Activo.FechaInicioSistema.Date.ToString("dd/MM/yyyy")
        OSerAgenciaInternet.FHasta = Activo.FechaFinSistema.Date.ToString("dd/MM/yyyy")

        Activo.DTServicioAgenciaInterneteCache = OSerAgenciaInternet.ObtenerServiciosAgenciaInternet()

        '======================================================

        If S.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio) > 0 Then
            With Ej
                .Id_Campania = Activo.IDCampaña
                .Id_Sistema = Activo.IDSistema
                .Id_Ejercicio = Activo.IDEjercicio
                .FechaInicio = Activo.FechaInicioSistema
                .FechaFin = Activo.FechaFinSistema
                .IdTipoSoporte = Activo.IDTipoSoporte
                .IdCliente = Activo.IDCliente
                .Cliente = Activo.Cliente
                .Campania = Activo.Campaña
                .Sistema = Activo.Sistema
                .Ejercicio = Activo.Ejercicio
                .EsCargaNueva = False
            End With
            'Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo)
            '   frmProgresoCargaGrilla.Instancia.Reset()
            '   Fp.Close()
            Ej.Show()
            frmPrincipal.Instancia.Cursor = Cursors.Default
            Exit Sub
        End If

        fs.Id_medio = Medio
        fs.Id_tipo_soporte = Activo.IDTipoSoporte
        fs.id_plaza = Activo.IDPlaza

        fs.ShowDialog()

        If fs.Cancelado Then
            frmPrincipal.Instancia.Cursor = Cursors.Default
            Exit Sub
        End If
        ' Fp.Show()

        With Ej
            .Id_Campania = Activo.IDCampaña
            .Id_Sistema = Activo.IDSistema
            .Id_Ejercicio = Activo.IDEjercicio
            .FechaInicio = Activo.FechaInicioSistema
            .FechaFin = Activo.FechaFinSistema
            .IdTipoSoporte = Activo.IDTipoSoporte
            .IdCliente = Activo.IDCliente
            .Cliente = Activo.Cliente
            .Campania = Activo.Campaña
            .Sistema = Activo.Sistema
            .Ejercicio = Activo.Ejercicio
            .ListaSoportes = fs.ListaSoportes
            .EsCargaNueva = True
            .Show()
        End With
        frmPrincipal.Instancia.Cursor = Cursors.Default
    End Sub


    Public Sub Cargar(ByVal Medio As Medios)
        frmPrincipal.Instancia.Cursor = Cursors.WaitCursor
        Dim fs As New frmFiltrarSoporte
        ' Dim Fp As New frmProgresoCargaGrilla
        Dim Ejer As EjercicioActivo

        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio

        Activo.EjerciciosCargados.Add(Ejer)

        Dim S As Object

        Dim Ej As New frmEjercicioMedios

        If Medio = Medios.Revista Or Medio = Medios.Prensa Then
            S = New Spots_pr
        Else
            S = New Spots_vp
        End If
        'S.Id_campania = Activo.IDCampaña
        'S.Id_sistema = Activo.IDSistema
        'S.Id_ejercicio = Activo.IDEjercicio

        If Activo.FechaInicioSistema.Year < 1900 Then
            Dim si As New Sistemas
            si.Id_campania = Activo.IDCampaña
            si.Id_sistema = Activo.IDSistema
            si.BuscarPorID()
            Activo.FechaFinSistema = si.F_fin
            Activo.FechaInicioSistema = si.F_inicio
            Activo.IDPlaza = si.ID_Plaza
            Activo.IDTipoSoporte = si.Id_tipo_soporte
        End If


        If S.ObtenerCantidadSpots(Activo.IDCampaña, Activo.IDSistema, Activo.IDEjercicio) > 0 Then
            '   Fp.Show()
            With Ej
                .Id_Campania = Activo.IDCampaña
                .Id_Sistema = Activo.IDSistema
                .Id_Ejercicio = Activo.IDEjercicio
                .FechaInicio = Activo.FechaInicioSistema
                .FechaFin = Activo.FechaFinSistema
                .IdPlaza = Activo.IDPlaza
                .IdTipoSoporte = Activo.IDTipoSoporte
                .IdMedio = Medio
                .IdCliente = Activo.IDCliente
                .Cliente = Activo.Cliente
                .Campania = Activo.Campaña
                .Sistema = Activo.Sistema
                .Ejercicio = Activo.Ejercicio
            End With
            'Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo)
            '   frmProgresoCargaGrilla.Instancia.Reset()
            '   Fp.Close()
            Ej.Show()
            frmPrincipal.Instancia.Cursor = Cursors.Default
            Exit Sub
        End If

        fs.Id_medio = Medio
        fs.Id_tipo_soporte = Activo.IDTipoSoporte
        fs.id_plaza = Activo.IDPlaza

        fs.ShowDialog()

        If fs.Cancelado Then
            frmPrincipal.Instancia.Cursor = Cursors.Default
            Exit Sub
        End If
        ' Fp.Show()

        With Ej
            .Id_Campania = Activo.IDCampaña
            .Id_Sistema = Activo.IDSistema
            .Id_Ejercicio = Activo.IDEjercicio
            .FechaInicio = Activo.FechaInicioSistema
            .FechaFin = Activo.FechaFinSistema
            .IdMedio = Medio
            .IdPlaza = Activo.IDPlaza
            .IdTipoSoporte = Activo.IDTipoSoporte
            .IdCliente = Activo.IDCliente
            .Cliente = Activo.Cliente
            .Campania = Activo.Campaña
            .Sistema = Activo.Sistema
            .Ejercicio = Activo.Ejercicio
            .ListaSoportes = fs.ListaSoportes
            .Show()
        End With
        frmPrincipal.Instancia.Cursor = Cursors.Default
    End Sub

    Public Sub Cargar(ByVal TvRadio As Boolean, ByVal Tipo As TipoAudiencia, Optional ByVal TipoEjercicio As Integer = Activo.TipoEjercicio.Estandar)
        'AG CP +++++++++++++++++++++++++++++++++++++

        frmPrincipal.Instancia.Cursor = Cursors.WaitCursor
        If Tipo < 0 Then
            MsgBox("Error en el Tipo de Soporte: " & Tipo)
            Exit Sub
        End If
        Dim Fp As New frmProgresoCargaGrilla
        Dim Ejer As EjercicioActivo

        Ejer.IDCampaña = Activo.IDCampaña
        Ejer.IDSistema = Activo.IDSistema
        Ejer.IDEjercicio = Activo.IDEjercicio

        Activo.EjerciciosCargados.Add(Ejer)

        Dim S As New Spots
        Dim Ej As New frmEjercicio

        'AG CP +++++++++++++++++++++
        Dim EjCP As New frmCpEjercicio
        '++++++++++++++++++++++++++

        S.Id_campania = Activo.IDCampaña
        S.Id_sistema = Activo.IDSistema
        S.Id_ejercicio = Activo.IDEjercicio


        If S.ObtenerSpots.Rows.Count > 0 Then
            Fp.Show()

            'AG CP '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            If TipoEjercicio = Activo.TipoEjercicio.Estandar Then  'Estandar = 0
                Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo)
                frmProgresoCargaGrilla.Instancia.Reset()
                Fp.Close()
                Ej.Show()
            Else
                EjCP.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo)
                frmProgresoCargaGrilla.Instancia.Reset()
                Fp.Close()
                EjCP.Show()
            End If
            Exit Sub
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            'Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo)
            'frmProgresoCargaGrilla.Instancia.Reset()
            'Fp.Close()
            'Ej.Show()
            'frmPrincipal.Instancia.Cursor = Cursors.Default
            'Exit Sub
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        End If

        Dim F As Object
        Dim ListaTemas As ArrayList
        Select Case Activo.IDMedio
            Case 6
                F = New frmFiltrarSoporteTema
                F.PrimeraCarga = True
                ListaTemas = F.ListaTemas
            Case Else
                F = New frmFiltrarSoporte
        End Select

        F.Id_medio = Activo.IDMedio
        F.Id_tipo_soporte = Activo.IDTipoSoporte
        F.id_plaza = Activo.IDPlaza

        F.ShowDialog()

        If F.Cancelado Then
            frmPrincipal.Instancia.Cursor = Cursors.Default
            Exit Sub
        End If
        Fp.Show()


        'AG CP +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        If TipoEjercicio = Activo.TipoEjercicio.Estandar Then  'Estandar = 0
            If Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo, F.ListaSoportes, ListaTemas) Then
                frmProgresoCargaGrilla.Instancia.Reset()
                Fp.Close()
                Ej.Show()
            End If
        Else
            If EjCP.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo, F.ListaSoportes, ListaTemas) Then
                frmProgresoCargaGrilla.Instancia.Reset()
                Fp.Close()
                EjCP.Show()
            End If
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'AG Codigo Anterior +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'If Ej.CargarGrilla(0, Activo.IDMedio, Activo.FechaInicioSistema, Activo.FechaFinSistema, Activo.IDSistema, Tipo, F.ListaSoportes, ListaTemas) Then
        '    frmProgresoCargaGrilla.Instancia.Reset()
        '    Fp.Close()
        '    Ej.Show()
        'End If
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        frmPrincipal.Instancia.Cursor = Cursors.Default

    End Sub
    Public Function ComprobarEjercicioActivo(ByVal Ejer As EjercicioActivo) As Boolean
        ' Ejer = New EjercicioActivo
        'For Each Ejer In Activo.EjerciciosCargados
        'If Ejer.IDCampaña = Activo.IDCampaña And Ejer.IDSistema = Activo.IDSistema And Ejer.IDEjercicio = Activo.IDEjercicio Then
        'Return True
        'End If
        'Next
        If Not Activo.EjerciciosCargados Is Nothing Then
            If Activo.EjerciciosCargados.Count > 0 Then
                Return True
            End If
        End If

        Return False
    End Function


End Class

Public Class CeldaCopiada
    Dim mIndiceFila As Integer
    Dim mIndiceColumna As Integer
    Dim mTexto As String

    Public Property IndiceFila() As Integer
        Get
            Return mIndiceFila
        End Get
        Set(ByVal Value As Integer)
            mIndiceFila = Value
        End Set
    End Property

    Public Property IndiceColumna() As Integer
        Get
            Return mIndiceColumna
        End Get
        Set(ByVal Value As Integer)
            mIndiceColumna = Value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return mTexto
        End Get
        Set(ByVal Value As String)
            mTexto = Value
        End Set
    End Property
End Class
Public Class MotorP

#Region "VARIABLES"
    Dim WithEvents m As New MotorSimulador.cMotor
    Private mSistema As String
    Private mPlaza As Long
    Private mTarget As Integer
    Private mPauta As Long
    Private mMensajeError As String
    Private mTasaRepeticion As Double
    Private mNoContactados As Double
    Private mCoberturaNeta As Double
    Private mTotalGrps As Double
    Private mFrecuenciaMaxima As Integer
    Private mAvisos As Long
    Private mTotalTema As DataTable
    Private mTotalSemanaC As DataTable
    Private mTotalSemanaP As DataTable
    Private mTotalSoporte As DataTable
    Private mEstado As Integer
    Private mProgreso As ProgressBar
    Dim auxCol() As String = {"CN", "PBR"}
#End Region

#Region "PROPIEDADES"
    Public ReadOnly Property TotalSoporte() As DataTable
        Get
            Return mTotalSoporte
        End Get
    End Property
    Public ReadOnly Property TotalTema() As DataTable
        Get
            Return mTotalTema
        End Get
    End Property
    Public ReadOnly Property Totalsemanac() As DataTable
        Get
            Return mTotalsemanac
        End Get
    End Property
    Public ReadOnly Property Totalsemanap() As DataTable
        Get
            Return mTotalSemanaP
        End Get
    End Property


    Public Property FrecuenciaMaxima() As Integer
        Get
            Return mFrecuenciaMaxima
        End Get
        Set(ByVal Value As Integer)
            mFrecuenciaMaxima = Value
        End Set
    End Property
    Public ReadOnly Property TasaRepeticion() As Double
        Get
            Return mTasaRepeticion
        End Get
    End Property
    Public ReadOnly Property NoContactados() As Double
        Get
            Return mNoContactados
        End Get
    End Property
    Public ReadOnly Property CoberturaNeta() As Double
        Get
            Return mCoberturaNeta
        End Get
    End Property
    Public ReadOnly Property TotalGrps() As Double
        Get
            Return mTotalGrps
        End Get
    End Property
    Public WriteOnly Property Sistema() As String
        Set(ByVal Value As String)
            mSistema = Value
        End Set
    End Property
    Public WriteOnly Property Plaza() As Long
        Set(ByVal Value As Long)
            mPlaza = Value
        End Set
    End Property
    Public WriteOnly Property Target() As Integer
        Set(ByVal Value As Integer)
            mTarget = Value
        End Set
    End Property
    Public WriteOnly Property Pauta() As Long
        Set(ByVal Value As Long)
            mPauta = Value
        End Set
    End Property
    Public ReadOnly Property MensajeError() As String
        Get
            Return mMensajeError
        End Get
    End Property
    Public ReadOnly Property Avisos() As Long
        Get
            Return mAvisos
        End Get
    End Property
    Public ReadOnly Property Estado() As Integer
        Get
            Return mEstado
        End Get
    End Property
    Public Property Progreso() As ProgressBar
        Get
            Return mProgreso
        End Get
        Set(ByVal Value As ProgressBar)
            mProgreso = Value
        End Set
    End Property
#End Region

#Region "METODOS"
    Public Sub Conectar()
        Try
            m.Conectar()
            Dim id As Long = m.AbrirSesion(mSistema, mPlaza, mTarget, mPauta)
            Select Case id
                Case 0
                    mMensajeError = ""
                Case -1
                    mMensajeError = ("Sistema inválido")
                Case -2
                    mMensajeError = ("Plaza inválido")
                Case -3
                    mMensajeError = ("Pauta inválido")
                Case -4
                    mMensajeError = ("Target inválido")
                Case -5
                    mMensajeError = ("Target inexistente en targets")
                Case -6
                    mMensajeError = ("Pauta inexistente en pautas_mp")
                Case -7
                    mMensajeError = ("Error: al copiar pautas->pautas_mp")
                Case -10
                    mMensajeError = ("Error: Faltan Mediciones para Sistema/Plaza/Pauta")
                Case -11
                    mMensajeError = ("Error: Faltan Mediciones para Sistema/Plaza/Pauta en Dia Medio")
                Case -12
                    mMensajeError = ("Error: Sistema / Target Incompatible")
                Case -13
                    mMensajeError = ("Error: el target está vacio.")
            End Select

        Catch ex As Exception
            mMensajeError = ex.Message
        End Try
    End Sub
    Public Sub Desconectar()
        m.CerrarSesion()
    End Sub
    Private Function Absoluto(ByVal Valor As Object) As Object
        If Valor.GetType Is GetType(String) Then
            Return Valor
        End If
        If Valor < 0 Then
            Return Valor * -1
        Else
            Return Valor
        End If

    End Function
#End Region

#Region "LISTADOS"

    Public Function ObtenerPBRxAvisos() As DataTable
        Dim Arr 'As Object
        Dim Dt As DataTable = Me.ArmarDtPBR
        Dim DtOrdenado As DataTable
        Dim i As Integer, j As Integer
        Dim R As DataRow
        Try
            If m.TablaPBRAvisos(Arr, mTotalGrps) Then
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1
                        R(j) = Arr(j, i)
                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            mAvisos = Dt.Rows.Count

            DtOrdenado = Listas.OrdenarDT(Dt, "idsesion > -1", "FECHA asc, HORA asc, MINUTO asc, CANAL asc")
            Me.ObtenerTotales(DtOrdenado)
        Catch ex As Exception
            Throw New Exception("MotorP - Pbr x Avisos" & vbCrLf & ex.Message)
        End Try
        Return DtOrdenado
    End Function
    Public Function ObtenerFecuencias() As DataTable
        Dim Arr 'As Object
        Dim Dt As DataTable = Me.ArmarDTFrecuencia
        Dim i As Integer, j As Integer
        Dim R As DataRow
        Try
            If m.TablaFrecuencias(Arr, mCoberturaNeta, mNoContactados, mTasaRepeticion) Then
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1
                        R(j) = Absoluto(Arr(j, i))
                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            'mCoberturaNeta -= 0.02
        Catch ex As Exception
            Throw New Exception("MotorP - Frecuencias" & vbCrLf & ex.Message)
        End Try

        Return Dt
    End Function
    Public Function ObtenerAperturaCadena() As DataTable
        Dim Arr 'As Object
        Dim CN As Double, Pbr As Double

        Dim Dt As DataTable
        Dim DtOrdenado As DataTable
        Dim i As Integer, j As Integer, k As Integer, UltimaCol As Integer
        Dim R As DataRow
        Try
            If m.AperturaCanal(Arr) Then
                Dt = Me.ArmarDtGeneral("Canal", GetType(String), Arr.GetLength(0) - 3)
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1
                        If Arr(j, i).GetType Is GetType(String) Then
                            If Arr(j, i) = "" Then
                                R(j) = 0
                            Else
                                R(j) = Arr(j, i)
                            End If
                        Else
                            R(j) = CDbl(Arr(j, i))
                        End If

                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            UltimaCol = Arr.GetLength(0) - 3

            For i = 1 To 2

                For Each dr As DataRow In Dt.Rows
                    k += 1
                    dr(UltimaCol + i + 1) = Arr(UltimaCol + i, k)
                Next
                k = 0
            Next

            DtOrdenado = Listas.OrdenarDT(Dt, "CANAL<>-1", "CANAL ASC")
        Catch ex As Exception
            Throw New Exception("MotorP - Cadena" & vbCrLf & ex.Message)
        End Try

        Return DtOrdenado
    End Function
    Public Function ObtenerAperturaTemas() As DataTable
        Dim Arr 'As Object
        Dim CN As Double, Pbr As Double
        Dim Dt As DataTable
        ' Dim Dt As DataTable = Me.ArmarDtGeneral("Tema", GetType(String))
        Dim i As Integer, j As Integer, k As Integer, UltimaCol As Integer
        Dim R As DataRow, val As Double, DtOrdenado As DataTable
        Try
            If m.AperturaTema(Arr) Then
                Dt = Me.ArmarDtGeneral("Tema", GetType(String), Arr.GetLength(0) - 3)
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1
                        If Arr(j, i).GetType Is GetType(String) Then
                            If Arr(j, i) = "" Then
                                R(j) = 0
                            Else
                                R(j) = Arr(j, i)
                            End If
                        Else
                            R(j) = CDbl(Arr(j, i))
                        End If
                        ' Absoluto(val)

                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            UltimaCol = Arr.GetLength(0) - 3

            For i = 1 To 2

                For Each dr As DataRow In Dt.Rows
                    k += 1
                    dr(UltimaCol + i + 1) = Arr(UltimaCol + i, k)

                Next
                k = 0
            Next
            DtOrdenado = Listas.OrdenarDT(Dt, "1<>-2", "TEMA ASC")
        Catch ex As Exception
            Throw New Exception("MotorP - Pbr x Temas" & vbCrLf & ex.Message)
        End Try

        Return DtOrdenado
    End Function
    Public Function ObtenerAperturaSemanaC() As DataTable
        Dim Arr 'As Object
        Dim CN As Double, Pbr As Double
        Dim Dt As DataTable, dtOrdenado As DataTable
        ' Dim Dt As DataTable = Me.ArmarDtGeneral("SemanaC", GetType(String))
        Dim i As Integer, j As Integer, k As Integer, UltimaCol As Integer
        Dim R As DataRow
        Try

            If m.AperturaSemanaC(Arr) Then
                Dt = Me.ArmarDtGeneral("SemanaC", GetType(String), Arr.GetLength(0) - 3)
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1

                        If Arr(j, i).GetType Is GetType(String) Then
                            If Arr(j, i) = "" Then
                                R(j) = 0
                            Else
                                R(j) = Arr(j, i)
                            End If
                        Else
                            R(j) = CDbl(Arr(j, i))
                        End If

                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            UltimaCol = Arr.GetLength(0) - 3
            For i = 1 To 2

                For Each dr As DataRow In Dt.Rows
                    k += 1
                    dr(UltimaCol + i + 1) = Arr(UltimaCol + i, k)

                Next
                k = 0
            Next
            dtOrdenado = Listas.OrdenarDT(Dt, "1<>-2", "SEMANAC ASC")
        Catch ex As Exception
            Throw New Exception("MotorP - Semana Calendario" & vbCrLf & ex.Message)
        End Try

        Return dtOrdenado
    End Function
    Public Function ObtenerAperturaSemanaP() As DataTable
        Dim Arr 'As Object
        Dim CN As Double, Pbr As Double
        Dim Dt As DataTable, dtOrdenado As DataTable
        ' Dim Dt As DataTable = Me.ArmarDtGeneral("SemanaP", GetType(String))
        Dim i As Integer, j As Integer, k As Integer, UltimaCol As Integer
        Dim R As DataRow
        Try
            If m.AperturaSemanaP(Arr) Then
                Dt = Me.ArmarDtGeneral("SemanaP", GetType(String), Arr.GetLength(0) - 3)
                For i = 1 To Arr.GetLength(1) - 1
                    R = Dt.NewRow()
                    For j = 0 To Arr.GetLength(0) - 1


                        If Arr(j, i).GetType Is GetType(String) Then
                            If Arr(j, i) = "" Then
                                R(j) = 0
                            Else
                                R(j) = Arr(j, i)
                            End If
                        Else
                            R(j) = CDbl(Arr(j, i))
                        End If

                    Next
                    Dt.Rows.Add(R)
                Next
            End If
            UltimaCol = Arr.GetLength(0) - 3

            For i = 1 To 2

                For Each dr As DataRow In Dt.Rows
                    k += 1
                    dr(UltimaCol + i + 1) = Arr(UltimaCol + i, k)

                Next
                k = 0
            Next
            dtOrdenado = Listas.OrdenarDT(Dt, "1 <> -2", "SEMANAP ASC")
        Catch ex As Exception
            Throw New Exception("MotorP - Semana Pauta" & vbCrLf & ex.Message)
        End Try

        Return dtOrdenado
    End Function
    Private Sub ObtenerTotales(ByVal Dt As DataTable)
        Try
            Dim g As New DataSetHelper
            Me.mTotalSemanaC = g.SelectGroupByInto("TotalSemanaC", Dt, "SEMANAC, COUNT(SEMANAC) CANT", , "SEMANAC", False)
            Me.mTotalSemanaP = g.SelectGroupByInto("TotalSemanap", Dt, "SEMANAP, COUNT(SEMANAP) CANT", , "SEMANAP", False)
            Me.mTotalSoporte = g.SelectGroupByInto("TotalSoporte", Dt, "CANAL, COUNT(CANAL) CANT", , "CANAL", False)
            Me.mTotalTema = g.SelectGroupByInto("TotalTema", Dt, "TEMA, COUNT(TEMA) CANT", , "TEMA", False)
        Catch ex As Exception
            Throw New Exception("MotorP - Agrupamiento" & vbCrLf & ex.Message)
        End Try
    End Sub

#End Region

#Region "DATA TABLES"
    Private Function ArmarDtGeneral(ByVal Titulo As String, ByVal Tipo As Type, ByVal Columnas As Long) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add(Titulo, Tipo)

        For i As Integer = 0 To Columnas
            With dt.Columns
                .Add(i, GetType(Double))
            End With
        Next

        dt.Columns.Add("CN", GetType(Double))
        dt.Columns.Add("PBR", GetType(Double))
        Return dt
    End Function
    Private Function ArmarDTFrecuencia() As DataTable
        Dim dt As New DataTable
        With dt.Columns
            .Add("IDSESION", GetType(Long))
            .Add("QTYCONTACTOS", GetType(Integer))
            .Add("QTYIND", GetType(Double))
            .Add("POBLACION", GetType(Double))
            .Add("PORCENTAJE", GetType(Double))
        End With
        Return dt
    End Function
    Private Function ArmarDtPBR() As DataTable
        Dim dt As New DataTable
        With dt.Columns
            .Add("IDSESION", GetType(Long))
            .Add("AVISO", GetType(Long))
            .Add("FECHA", GetType(Date))
            .Add("HORA", GetType(Integer))
            .Add("MINUTO", GetType(Integer))
            .Add("CANAL", GetType(Integer))
            .Add("TEMA", GetType(String))
            .Add("SEMANAC", GetType(String))
            .Add("SEMANAP", GetType(Integer))
            .Add("POBLACION", GetType(Double))
            .Add("QTYIND", GetType(Double))
            .Add("SUMW", GetType(Double))
            .Add("PBR", GetType(Double))
        End With
        Return dt
    End Function
    Private Function ArmarDtTotal() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("DESC", GetType(String))
        dt.Columns.Add("AVISOS", GetType(Integer))
        Return dt
    End Function
#End Region

 
    Private Sub m_Progreso(ByRef codigo As Integer, ByRef texto As String) Handles m.Progreso
        Progreso.Increment(1)
    End Sub
End Class

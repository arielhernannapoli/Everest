Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource

Public Class GrillaConvenio
    Dim GrillAdmin As New GrillAdmin
    Dim GrillaResumen As New GrillaResumen

    Public Sub AplicarConvenioGlobal(ByVal Grilla As UltraDataSource, ByVal Spots As DataTable, ByVal Convenio As TipoConvenio, ByVal Condicion As CondicionConvenio, ByVal Dias As String)
        Dim Ur As UltraDataRow
        Dim Cdesde As Integer
        Dim Chasta As Integer
        Dim Gdesde As Integer
        Dim Ghasta As Integer

        For Each Ur In Grilla.Rows
            ' convierto todo a minutos asi se pueden hacer las comparaciones.
            If Condicion.IDSoporte = Ur.Item("id_soporte") Then
                If Condicion.HoraDesde <> "" Then
                    Cdesde = Condicion.HoraDesde.Substring(0, 2) * 60 + Condicion.HoraDesde.Substring(3, 2)
                    Chasta = Condicion.HoraHasta.Substring(0, 2) * 60 + Condicion.HoraHasta.Substring(3, 2)
                    'LC 26/03/2014 Se obtine correctamente los minutos del programa de TV
                    Gdesde = Val(Mid(Ur.Item("H_Inicio"), 1, 2)) * 60 + Val(Mid(Ur.Item("H_Inicio"), 4, 2))
                    Ghasta = Val(Mid(Ur.Item("H_Fin"), 1, 2)) * 60 + Val(Mid(Ur.Item("H_Fin"), 4, 2))
                    ' spot en el que estoy parado debe aplicar de alguna manera
                    ' [---(...)---]
                    ' (---[---)---]
                    ' [---(---]---)
                    ' (---[---]---)
                    If (Cdesde <= Gdesde And Ghasta <= Chasta) Or _
                       (Gdesde <= Cdesde And Gdesde <= Chasta And Cdesde <= Ghasta) Or _
                       (Cdesde <= Gdesde And Chasta <= Ghasta And Gdesde <= Chasta) Or _
                       (Gdesde <= Cdesde And Chasta <= Ghasta) Then
                        'Valida que los dias del convenio comprendan a los dias del programa
                        If ValidaDiasConvenio(Dias, Ur) Then
                            ModificarGriSpot(Ur, Spots, Convenio, Condicion)
                            'If Convenio.Neto > 0 Then
                            '    GrillAdmin.ActualizarNeto(Ur, "neto", Convenio.Neto, Convenio.IDConvenio, True)
                            '    GrillaResumen.ActualizarCPR(Ur)
                            'Else
                            '    GrillAdmin.ActualizarNeto(Ur, , , Convenio.IDConvenio, True)
                            '    GrillaResumen.ActualizarCPR(Ur)
                            'End If

                            'AG Codigo Anterior ++++++++++++++++++++++++++++++
                            'If Convenio.TipoConvenio = eTipoConvenio.TarifaPlana Then
                            '    GrillAdmin.ActualizarNeto(Ur, "neto", Convenio.Neto, Convenio.IDConvenio, True)
                            '    GrillaResumen.ActualizarCPR(Ur)
                            'Else
                            '    GrillAdmin.ActualizarNeto(Ur, , , Convenio.IDConvenio, True)
                            '    GrillaResumen.ActualizarCPR(Ur)
                            'End If

                            'AG CCPR +++++++++++++++++++++++++++++++++++++++++
                            If Convenio.TipoConvenio = eTipoConvenio.TarifaPlana Then
                                GrillAdmin.ActualizarNeto(Ur, "neto", Convenio.Neto, Convenio.IDConvenio, True)
                                GrillaResumen.ActualizarCPR(Ur)
                            ElseIf Convenio.TipoConvenio = eTipoConvenio.Descuento Then 'AG CCPR
                                GrillAdmin.ActualizarNeto(Ur, , , Convenio.IDConvenio, True)
                                GrillaResumen.ActualizarCPR(Ur)
                            ElseIf Convenio.TipoConvenio = eTipoConvenio.CPR Then 'AG CCPR
                                Dim GrillAdminCp As New GrillAdminCp 'AG CCPR
                                GrillAdminCp.ActualizarNeto(Ur, "cpr", Convenio.CPR)
                            End If
                            '++++++++++++++++++++++++++++++++++++++++++++++++

                        End If
                    End If
                Else
                    'Valida que los dias del convenio comprendan a los dias del programa
                    If ValidaDiasConvenio(Dias, Ur) Then
                        ModificarGriSpot(Ur, Spots, Convenio, Condicion)
                        If Convenio.Neto > 0 Then
                            GrillAdmin.ActualizarNeto(Ur, "neto", Convenio.Neto, Convenio.IDConvenio, True)
                            GrillaResumen.ActualizarCPR(Ur)
                        Else
                            GrillAdmin.ActualizarNeto(Ur, , , Convenio.IDConvenio, True)
                            GrillaResumen.ActualizarCPR(Ur)
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub AplicarConvenioPuntual(ByVal Fila As UltraDataRow, ByVal Spots As DataTable, ByVal Convenio As TipoConvenio, ByVal Condicion As CondicionConvenio, ByVal Dias As String)
        Dim Cdesde As Integer
        Dim Chasta As Integer
        Dim Gdesde As Integer
        Dim Ghasta As Integer

        ' convierto todo a minutos asi se pueden hacer las comparaciones.
        If Condicion.IDSoporte = Fila.Item("id_soporte") Then
            If Condicion.HoraDesde <> "" Then
                Cdesde = Condicion.HoraDesde.Substring(0, 2) * 60 + Condicion.HoraDesde.Substring(3, 2)
                Chasta = Condicion.HoraHasta.Substring(0, 2) * 60 + Condicion.HoraHasta.Substring(3, 2)

                Gdesde = Val(Mid(Fila.Item("H_Inicio"), 1, 2)) * 60 + Val(Mid(Fila.Item("H_Inicio"), 4, 2))
                Ghasta = Val(Mid(Fila.Item("H_Fin"), 1, 2)) * 60 + Val(Mid(Fila.Item("H_Fin"), 4, 2))

                ' spot en el que estoy parado debe aplicar de alguna manera
                ' [---(...)---]
                ' (---[---)---]
                ' [---(---]---)
                ' (---[---]---)
                If (Cdesde <= Gdesde And Ghasta <= Chasta) Or _
                   (Gdesde <= Cdesde And Gdesde <= Chasta And Cdesde <= Ghasta) Or _
                   (Cdesde <= Gdesde And Chasta <= Ghasta And Gdesde <= Chasta) Or _
                   (Gdesde <= Cdesde And Chasta <= Ghasta) Then
                    'Valida que los dias del convenio comprendan a los dias del programa
                    If ValidaDiasConvenio(Dias, Fila) Then
                        ModificarGriSpot(Fila, Spots, Convenio, Condicion)
                    End If
                End If
            Else
                'Valida que los dias del convenio comprendan a los dias del programa
                If ValidaDiasConvenio(Dias, Fila) Then
                    ModificarGriSpot(Fila, Spots, Convenio, Condicion)
                End If
            End If
        End If

        If Activo.TEjecicioActivo = 0 Then 'AG CCPR
            GrillaResumen.ActualizarCPR(Fila)
        End If


    End Sub

    Private Function ValidaDiasConvenio(ByVal Dias As String, ByVal Ur As UltraDataRow) As Boolean
        Dim Contiene As Boolean = True
        Dim DiasRow As String = ObtenerDiasRow(Ur)
        If Dias.Length > 0 Then
            For Index As Integer = 0 To DiasRow.Length - 1
                If DiasRow.Substring(Index, 1) = "S" Then
                    If DiasRow.Substring(Index, 1) <> Dias.Substring(Index, 1) Then
                        Contiene = False
                    End If
                End If
            Next
        End If
        Return Contiene
    End Function

    Private Function ObtenerDiasRow(ByVal Ur As UltraDataRow) As String
        Dim DiasResultado As String
        Dim Dias As String = IIf(Ur.Item("Dias") Is DBNull.Value, "", Ur.Item("Dias"))
        If Dias.Length > 0 Then
            If Dias.IndexOf("L") >= 0 Then
                DiasResultado = "S"
            Else
                DiasResultado = "N"
            End If
            If Dias.IndexOf("M") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
            If Dias.IndexOf("X") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
            If Dias.IndexOf("J") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
            If Dias.IndexOf("V") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
            If Dias.IndexOf("S") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
            If Dias.IndexOf("D") >= 0 Then
                DiasResultado += "S"
            Else
                DiasResultado += "N"
            End If
        End If
        Return DiasResultado
    End Function

    Public Sub ModificarGriSpot(ByVal Ur As UltraDataRow, ByVal Spots As DataTable, ByVal Convenio As TipoConvenio, ByVal Condicion As CondicionConvenio)
        ' modifico la grilla
        If Convenio.TipoConvenio = eTipoConvenio.Descuento Then
            Ur.Item("dcto1") = Convenio.Descuento1
            Ur.Item("dcto2") = Convenio.Descuento2
            Ur.Item("dcto3") = Convenio.Descuento3
            Ur.Item("dcto4") = Convenio.Descuento4
            Ur.Item("dcto5") = Convenio.Descuento5
            GrillAdmin.ActualizarNeto(Ur, , Convenio.Neto, Convenio.IDConvenio, True)
            If Convenio.Neto > 0 Then
                Ur.Item("bruto") = Convenio.Neto
            End If
        ElseIf Convenio.TipoConvenio = eTipoConvenio.TarifaPlana Then 'AG CCPR
            Ur.Item("Neto") = Convenio.Neto
            'actual
            Ur.Item("bruto") = Convenio.Neto
            GrillAdmin.ActualizarNeto(Ur, "neto", Convenio.Neto, Convenio.IDConvenio, True)
        ElseIf Convenio.TipoConvenio = eTipoConvenio.CPR Then 'AG CCPR
            Ur.Item("CPR") = Convenio.CPR
        End If
        Dim Dr As DataRow

        Try
            Dr = Spots.Select("id_Spot = " & Ur.Item("id_spot"))(0)
        Catch ex As IndexOutOfRangeException
            Mensajes.Mensaje("El IDSpot No Existe en el DataTable: " & ex.Message, TipoMensaje.DeError)
            Exit Sub
        End Try

        Dr("id_convenio") = Convenio.IDConvenio

        If Convenio.TipoConvenio = eTipoConvenio.Descuento Then
            Dr("dcto1") = Convenio.Descuento1
            Dr("dcto2") = Convenio.Descuento2
            Dr("dcto3") = Convenio.Descuento3
            Dr("dcto4") = Convenio.Descuento4
            Dr("dcto5") = Convenio.Descuento5
            Dr("neto") = Ur("neto")
            Dr("bruto") = Ur.Item("bruto") 'AG 01/07
        ElseIf Convenio.TipoConvenio = eTipoConvenio.TarifaPlana Then 'AG CCPR
            Dr("Neto") = Convenio.Neto
            'actual
            Dr("bruto") = Ur.Item("bruto") 'Convenio.Neto
            Dr("dcto1") = Convenio.Descuento1
            Dr("dcto2") = Convenio.Descuento2
            Dr("dcto3") = Convenio.Descuento3
            Dr("dcto4") = Convenio.Descuento4
            Dr("dcto5") = Convenio.Descuento5
        ElseIf Convenio.TipoConvenio = eTipoConvenio.CPR Then 'AG CCPR
            'Agregar aqui el valor de descuento calculado
            Dim GrillAdminCp As New GrillAdminCp

            GrillAdminCp.ActualizarNeto(Ur, "cpr", Convenio.CPR)
            Dr("dcto1") = Ur.Item("dcto1")
            Dr("neto") = Ur("neto")
        End If

    End Sub
End Class

Public Class TipoConvenio
    Dim mIDConvenio As Integer
    Dim mTipoConvenio As eTipoConvenio
    Dim mIndiceFila As Integer 'indice en el ultra source
    Dim mDescripcion As String
    Dim mNeto As Single
    Dim mDescuento1 As Single
    Dim mDescuento2 As Single
    Dim mDescuento3 As Single
    Dim mDescuento4 As Single
    Dim mDescuento5 As Single
    Dim mCPR As Double 'AG CCPR

    Public Property CPR() As Double 'AG CCPR
        Get
            Return mCPR
        End Get
        Set(ByVal Value As Double)
            mCPR = Value
        End Set
    End Property

    Public Property IDConvenio() As Integer
        Get
            Return mIDConvenio
        End Get
        Set(ByVal Value As Integer)
            mIDConvenio = Value
        End Set
    End Property

    Public Property TipoConvenio() As eTipoConvenio
        Get
            Return mTipoConvenio
        End Get
        Set(ByVal Value As eTipoConvenio)
            mTipoConvenio = Value
        End Set
    End Property

    Public Property IndiceFila() As Integer
        Get
            Return mIndiceFila
        End Get
        Set(ByVal Value As Integer)
            mIndiceFila = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return mDescripcion
        End Get
        Set(ByVal Value As String)
            mDescripcion = Value
        End Set
    End Property

    Public Property Neto() As Single
        Get
            Return mNeto
        End Get
        Set(ByVal Value As Single)
            mNeto = Value
        End Set
    End Property

    Public Property Descuento1() As Single
        Get
            Return mDescuento1
        End Get
        Set(ByVal Value As Single)
            mDescuento1 = Value
        End Set
    End Property

    Public Property Descuento2() As Single
        Get
            Return mDescuento2
        End Get
        Set(ByVal Value As Single)
            mDescuento2 = Value
        End Set
    End Property

    Public Property Descuento3() As Single
        Get
            Return mDescuento3
        End Get
        Set(ByVal Value As Single)
            mDescuento3 = Value
        End Set
    End Property

    Public Property Descuento4() As Single
        Get
            Return mDescuento4
        End Get
        Set(ByVal Value As Single)
            mDescuento4 = Value
        End Set
    End Property

    Public Property Descuento5() As Single
        Get
            Return mDescuento5
        End Get
        Set(ByVal Value As Single)
            mDescuento5 = Value
        End Set
    End Property
End Class

Public Class CondicionConvenio
    Dim mIDSoporte As Integer
    Dim mHoraDesde As String
    Dim mHoraHasta As String

    Public Property IDSoporte() As Integer
        Get
            Return mIDSoporte
        End Get
        Set(ByVal Value As Integer)
            mIDSoporte = Value
        End Set
    End Property

    Public Property HoraDesde() As String
        Get
            Return mHoraDesde
        End Get
        Set(ByVal Value As String)
            mHoraDesde = Value
        End Set
    End Property

    Public Property HoraHasta() As String
        Get
            Return mHoraHasta
        End Get
        Set(ByVal Value As String)
            mHoraHasta = Value
        End Set
    End Property

End Class

Public Enum eTipoConvenio
    TarifaPlana
    Descuento
    CPR 'AG CCPR
End Enum
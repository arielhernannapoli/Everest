Imports MSL

Public Class frmProgressBar
    Inherits System.Windows.Forms.Form

#Region "Propiedades"

    Dim Envio As New Envio_Compras
    Dim _result As DataTable
    Dim _valuePb As Integer
    Dim _countTotal As Integer = 0
    Dim dtResult As DataTable


    Private dtValue As DataTable

    Public Property DtEnvio() As DataTable
        Get
            Return dtValue
        End Get
        Set(ByVal value As DataTable)
            dtValue = value
        End Set
    End Property


    Private idCampaniaMms As Integer
    Public Property CampaniaMMS() As Integer
        Get
            Return idCampaniaMms
        End Get
        Set(ByVal value As Integer)
            idCampaniaMms = value
        End Set
    End Property


    Private idSubCampaniaMms As Integer
    Public Property SubCampaniaMms() As Integer
        Get
            Return idSubCampaniaMms
        End Get
        Set(ByVal value As Integer)
            idSubCampaniaMms = value
        End Set
    End Property


    Private codPais As Integer
    Public Property CodigoPais() As Integer
        Get
            Return codPais
        End Get
        Set(ByVal value As Integer)
            codPais = value
        End Set
    End Property


    Private IdUsario As Integer
    Public Property CodUsuario() As Integer
        Get
            Return IdUsario
        End Get
        Set(ByVal value As Integer)
            IdUsario = value
        End Set
    End Property


    Private CodCampaniaActual As Integer
    Public Property CampaniaActual() As Integer
        Get
            Return CodCampaniaActual
        End Get
        Set(ByVal value As Integer)
            CodCampaniaActual = value
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Agregar Comentarios.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertOrdenesTV() As DataTable

        Dim _count As Integer = 0
        Dim _tempDtValue As DataTable = dtValue.Clone()

        For Each row As DataRow In dtValue.Rows
            If _count = 1000 Then
                Exit For
            Else
                _tempDtValue.ImportRow(row)
                dtValue.Rows(_count).Delete()
                _count = _count + 1
                _countTotal = _count
                Me.pgbEnvioCompras.PerformStep()
                Me.pgbEnvioCompras.Value = _countTotal
            End If
        Next

        _countTotal = _count

        dtValue.AcceptChanges()
        _result = Envio.InsertaAvisosMMS(_tempDtValue, Me.CampaniaMMS, Me.SubCampaniaMms, Me.codPais, Me.IdUsario, Me.CampaniaActual, Activo.IDCliente)

        If dtResult Is Nothing Then
            dtResult = _result.Clone()
        End If

        If _result.Rows.Count <> 0 Then
            For Each row As DataRow In _result.Rows
                dtResult.ImportRow(row)
            Next
        End If

        If dtValue.Rows.Count <> 0 Then
            Me.InsertOrdenesTV()
        End If

        Return dtResult

    End Function

#End Region

#Region "Enventos del Formulario"

    Private Sub frmProgressBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.pgbEnvioCompras.Maximum = Me.dtValue.Rows.Count
        Me.pgbEnvioCompras.Visible = True
        Me.pgbEnvioCompras.Minimum = 1
        Me.pgbEnvioCompras.Step = 1

        Me.InsertOrdenesTV()

        If dtResult.Rows.Count > 0 Then
            Dim sMensaje As String = "Se insertaron " & dtResult.Rows.Count.ToString & " avisos con éxito!"
            MsgBox(sMensaje, MsgBoxStyle.Information, AcceptButton)
        End If

        Me.Close()
    End Sub

#End Region
End Class

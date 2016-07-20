Imports Infragistics.Win.UltraWinGrid

Public Class frmAvisosDiferencia

#Region " Constantes "
    Private Const COMPANIA_FORWARD As Integer = 41
#End Region

#Region " Metodos Privados "
    Dim GrillaFormato As New GrillaFormato
#End Region

#Region " Propiedades "
    Private _dtAvisosDiferencia As DataTable
    Public Property DtAvisosDiferencia() As DataTable
        Get
            Return _dtAvisosDiferencia
        End Get
        Set(ByVal value As DataTable)
            _dtAvisosDiferencia = value
        End Set
    End Property

    Private _idMedio As Integer
    Public Property IdMedio() As Integer
        Get
            Return _idMedio
        End Get
        Set(ByVal value As Integer)
            _idMedio = value
        End Set
    End Property

    Private _idCompania As Integer
    Public Property IdCompania() As Integer
        Get
            Return _idCompania
        End Get
        Set(ByVal value As Integer)
            _idCompania = value
        End Set
    End Property

    Private _continuar As Boolean
    Public Property Continuar() As Boolean
        Get
            Return _continuar
        End Get
        Set(ByVal value As Boolean)
            _continuar = value
        End Set
    End Property

#End Region

#Region " Metodos "
    Private Sub SetDataValues(ByRef dtAvisosMedio As DataTable)
        Dim soporte As String
        Dim producto As String
        Dim material As String
        Dim provincia As String
        If Me.IdMedio.Equals(Medios.Prensa) Or Me.IdMedio.Equals(Medios.Revista) Then
            dtAvisosMedio.Columns.Add("SOPORTE", GetType(String))
            dtAvisosMedio.Columns.Add("PRODUCTO", GetType(String))
            dtAvisosMedio.Columns.Add("MATERIAL", GetType(String))
        ElseIf Me.IdMedio.Equals(Medios.Produccion) Or Me.IdMedio.Equals(Medios.Exterior) Then
            dtAvisosMedio.Columns.Add("SOPORTE", GetType(String))
            dtAvisosMedio.Columns.Add("PRODUCTO", GetType(String))
            dtAvisosMedio.Columns.Add("PROVINCIA", GetType(String))
        ElseIf Me.IdMedio.Equals(Medios.Tv) Or Me.IdMedio.Equals(Medios.Radio) Then
            dtAvisosMedio.Columns.Add("SOPORTE", GetType(String))
        End If
        For Each fila As DataRow In dtAvisosMedio.Rows
            If Me.IdMedio.Equals(Medios.Prensa) Or Me.IdMedio.Equals(Medios.Revista) Then
                Dim filaSoporte As DataRow = Activo.DTSoportesCache.Select("id_soporte=" & fila("ID_SOPORTE").ToString() & " and id_medio=" & Me.IdMedio).FirstOrDefault()
                Dim filaProducto As DataRow = Activo.DTProductosCache.Select("id_producto=" & fila("ID_PRODUCTO").ToString()).FirstOrDefault()
                Dim filaMaterial As DataRow = Activo.DTMaterialesCache.Select("id_material=" & fila("ID_MATERIAL").ToString() & " and id_producto=" & fila("ID_PRODUCTO").ToString()).FirstOrDefault()
                If Not filaSoporte Is Nothing Then
                    soporte = filaSoporte("DES_SOPORTE").ToString()
                End If
                If Not filaProducto Is Nothing Then
                    producto = filaProducto("DESCRIPCION").ToString()
                End If
                If Not filaMaterial Is Nothing Then
                    material = filaMaterial("DESCRIPCION").ToString()
                End If
                fila("SOPORTE") = soporte
                fila("PRODUCTO") = producto
                fila("MATERIAL") = material
            ElseIf Me.IdMedio.Equals(Medios.Produccion) Or Me.IdMedio.Equals(Medios.Exterior) Then
                Dim filaSoporte As DataRow = Activo.DTSoportesCache.Select("id_soporte=" & fila("ID_SOPORTE").ToString() & " and id_medio=" & Me.IdMedio).FirstOrDefault()
                Dim filaProducto As DataRow = Activo.DTProductosCache.Select("id_producto=" & fila("ID_PRODUCTO").ToString()).FirstOrDefault()
                Dim filaProvincia As DataRow = Activo.DTProvinciaCache.Select("cod_pobl1=" & fila("COD_POBL1").ToString()).FirstOrDefault()
                If Not filaSoporte Is Nothing Then
                    soporte = filaSoporte("DES_SOPORTE").ToString()
                End If
                If Not filaProducto Is Nothing Then
                    producto = filaProducto("DESCRIPCION").ToString()
                End If
                If Not filaProvincia Is Nothing Then
                    provincia = filaProvincia("NOM_POBL1").ToString()
                End If
                fila("SOPORTE") = soporte
                fila("PRODUCTO") = producto
                fila("PROVINCIA") = provincia
            ElseIf Me.IdMedio.Equals(Medios.Tv) Or Me.IdMedio.Equals(Medios.Radio) Then
                Dim filaSoporte As DataRow = Activo.DTSoportesCache.Select("id_soporte=" & fila("CODIGOSOPORTE").ToString() & " and id_medio=" & Me.IdMedio).FirstOrDefault()
                If Not filaSoporte Is Nothing Then
                    soporte = filaSoporte("DES_SOPORTE").ToString()
                End If
                fila("SOPORTE") = soporte
            End If
        Next
    End Sub

    Private Sub SetGridFormat()
        If Me.IdMedio.Equals(Medios.Prensa) Or Me.IdMedio.Equals(Medios.Revista) Then
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("ID_SOPORTE").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("ID_PRODUCTO").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("ID_MATERIAL").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("SOPORTE").Header.VisiblePosition = 1
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("PRODUCTO").Header.VisiblePosition = 2
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("MATERIAL").Header.VisiblePosition = 3
        ElseIf Me.IdMedio.Equals(Medios.Produccion) Or Me.IdMedio.Equals(Medios.Exterior) Then
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("ID_SOPORTE").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("ID_PRODUCTO").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("COD_POBL1").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("COD_POBL2").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("SOPORTE").Header.VisiblePosition = 1
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("PRODUCTO").Header.VisiblePosition = 2
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("PROVINCIA").Header.VisiblePosition = 3
        ElseIf Me.IdMedio.Equals(Medios.Tv) Or Me.IdMedio.Equals(Medios.Radio) Then
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("CODIGOSOPORTE").Hidden = True
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("SOPORTE").Header.VisiblePosition = 1
            Me.iugAvisos.DisplayLayout.Bands(0).Columns("PROGRAMADESCRIPCION").Header.Caption = "PROGRAMA"
        End If

        Me.iugAvisos.DisplayLayout.Bands(0).Columns("IMPORTECOMPRANETO").CellAppearance.BackColor = Color.Bisque
        Me.iugAvisos.DisplayLayout.Bands(0).Columns("IMPORTEVENTANETO").CellAppearance.BackColor = Color.Bisque

        Me.iugAvisos.DisplayLayout.Bands(0).Columns("IMPORTECOMPRANETO").Header.Caption = "IMPORTE COMPRA"
        Me.iugAvisos.DisplayLayout.Bands(0).Columns("IMPORTEVENTANETO").Header.Caption = "IMPORTE VENTA"
        Me.iugAvisos.DisplayLayout.Bands(0).Columns("CODIGOCONVENIO").Header.Caption = "CONVENIO"

        Me.iugAvisos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns

        GrillaFormato.CambiarFormatoColumna(Me.iugAvisos, "IMPORTECOMPRANETO", Formato.Moneda)
        GrillaFormato.CambiarFormatoColumna(Me.iugAvisos, "IMPORTEVENTANETO", Formato.Moneda)

        With iugAvisos.DisplayLayout.Bands(0)
            .Columns("IMPORTECOMPRANETO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            .Columns("IMPORTEVENTANETO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        End With

        GrillaFormato.HabilitarEdicionColumna(Me.iugAvisos, Activation.NoEdit, "IMPORTECOMPRANETO", "IMPORTEVENTANETO")

    End Sub

    Private Sub SetFormOptions()
        If Me.IdCompania <> COMPANIA_FORWARD Then
            Me.btnOK.Visible = True
            Me.btnSalir.Visible = True
            Me.btnSalir.Text = "NO"
            Me.lblLeyenda.Visible = True
        Else
            Me.btnOK.Visible = False
            Me.btnSalir.Visible = True
            Me.btnSalir.Text = "SALIR"
            Me.lblLeyenda.Visible = False
        End If
    End Sub
#End Region

#Region " Eventos "
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Continuar = False
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Continuar = True
        Me.Close()
    End Sub

    Private Sub frmAvisosDiferencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetFormOptions()
        Dim dtAvisosMedio As DataTable
        Select Case IdMedio
            Case Medios.Revista, Medios.Prensa
                dtAvisosMedio = Me.DtAvisosDiferencia.DefaultView.ToTable(True, "ID_SOPORTE", "ID_PRODUCTO", "ID_MATERIAL", "IMPORTECOMPRANETO", "IMPORTEVENTANETO", "CODIGOCONVENIO")
            Case Medios.Exterior, Medios.Produccion
                dtAvisosMedio = Me.DtAvisosDiferencia.DefaultView.ToTable(True, "ID_SOPORTE", "ID_PRODUCTO", "COD_POBL1", "COD_POBL2", "IMPORTECOMPRANETO", "IMPORTEVENTANETO", "CODIGOCONVENIO")
            Case Medios.Tv, Medios.Radio
                dtAvisosMedio = Me.DtAvisosDiferencia.DefaultView.ToTable(True, "CODIGOSOPORTE", "PROGRAMADESCRIPCION", "IMPORTECOMPRANETO", "IMPORTEVENTANETO", "CODIGOCONVENIO")
            Case Else
                dtAvisosMedio = Me.DtAvisosDiferencia
        End Select
        Me.SetDataValues(dtAvisosMedio)
        Me.iugAvisos.DataSource = dtAvisosMedio
        Me.SetGridFormat()
    End Sub
#End Region

End Class
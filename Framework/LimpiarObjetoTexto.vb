Imports System.Windows.Forms

'Objetivo: Limpiar la propiedades de todos los objetos de un formulario, para usarlo
'cuando se guardan datos en una base de datos y se quiere dar el efecto que los datos
'se fueron

Public Class LimpiarObjetoTexto
    Dim mFormulario As ContainerControl

    Public Sub New(ByVal Formulario As ContainerControl)
        mFormulario = Formulario
    End Sub

    Public Sub LimpiarTextos()
        Dim C As New Object
        Dim C2 As New Object

        For Each C In mFormulario.Controls

            Select Case C.GetType.ToString

                Case "System.Windows.Forms.GroupBox"
                    'FRAME
                    For Each C2 In C.controls
                        Limpiar(C2)
                    Next

                Case Else
                    Limpiar(C)
            End Select

        Next
    End Sub

    Private Sub Limpiar(ByVal C As Object)
        Select Case C.GetType.ToString
            Case "QUETOOL.txtTexto"
                C.text = ""
            Case "QUETOOL.cboCombo"
                C.text = ""
            Case "QUETOOL.chkCheck"
                C.checked = False
            Case "QUETOOL.dtpFecha"
                'C.value = Date.Today
            Case "QUETOOL.porPorcentaje"
                C.value = 0

            Case "ControlesMejorados.CajaTextoMejorada"
                'TEXT BOX MEJORADO
                C.Text = ""

            Case "ControlesMejorados.ComboMejorado"
                'BOMBO BOX MEJORADO
                C.SelectedIndex = -1

            Case "System.Windows.Forms.TextBox"
                'TEXT BOX
                C.Text = ""

            Case "System.Windows.Forms.ComboBox"
                'COMBOS
                C.Text = ""

            Case "System.Windows.Forms.DateTimePicker"
                'DATE TIME PICKER
                C.value = Date.Today

            Case "System.Windows.Forms.ListView"
                'LIST VIEWS
            Case "System.Windows.Forms.CheckBox"
                C.checked = False
        End Select
    End Sub
End Class

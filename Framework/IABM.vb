Public Interface IABM
    Sub Guardar()
    Function CargarObjeto() As Boolean
    Overloads Sub Cargar()
    Sub LimpiarControles()
    ReadOnly Property Alto() As Integer
    ReadOnly Property Ancho() As Integer
    Property Modificar() As Boolean
    Property DebeGuardar() As Boolean
    Sub Cancelar()
End Interface

' INTERFACE PARA LOS CUBOS DE DATOS (AN 15-10-2015)
Public Interface ICubo
    Sub SaveLayout(Optional ByVal layout As String = "")
    Sub LoadPivot(ByVal datos As DataSet, ByVal rating As String, ByVal fechaInicio As DateTime, Optional ByVal layout As String = "")
End Interface

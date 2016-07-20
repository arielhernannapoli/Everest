Imports System.Drawing
Imports System.IO

Public Module Imagen

    Public Function GetImageFromByteArray(ByVal array As Byte()) As Image
        Using ms As New MemoryStream(array)
            Return Image.FromStream(ms)
        End Using
    End Function

    Public Function GetByteArrayFromImage(ByVal imagen As Image, ByVal formato As System.Drawing.Imaging.ImageFormat) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, formato)
            Return ms.ToArray()
        End Using
    End Function

End Module

Public Class MapData
    Public Property GUID As String
    Public Property Name As String
    Public Property Description As String
    Public Property Description2 As String
    Public Property Subline As String
    Public Property StateA As String
    Public Property StateB As String
    Public Property VariantName As Object
    Public Property MapGUID As String
    Public Property GameModes As Object
    Public Property MapType As String
    Public Property Thumbnail As Object
    Public Property Image As Object
    Public Property FlagImage As Object
    Public Property CelebrationVariants As Object
    Public Property Variations As List(Of Variation)
End Class

Public Class Variation
    Public Property GUID As String
    Public Property Name As String
End Class

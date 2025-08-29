Public Class Reward
    Public Property GUID As String
    Public Property Name As String
    Public Property Type As String
    Public Property Rarity As String
End Class

Public Class Achievement
        Public Property GUID As String
        Public Property Name As String
        Public Property AchievementName As String
        Public Property Description As String
        Public Property Reward As Reward
        Public Property GamerScore As Integer
End Class
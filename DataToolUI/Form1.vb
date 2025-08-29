Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Dim DataToolCMD As New DataToolCMD
    Dim Abilities As New JObject
    Dim Achievements As New List(Of Achievement)
    Dim Heroes As New JObject
    Dim Maps As New JObject
    Dim Subtitles As New JObject
    Dim SubtitlesReal As New JObject
    Dim Talents As New JObject
    Dim Unlocks As New JObject
    Dim Workshop As New JObject

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataToolPath_TextBox.Text = My.Settings.DataToolPath
        OverwatchPath_TextBox.Text = My.Settings.OverwatchPath
        ExportFolderPath_TextBox.Text = My.Settings.ExportFolderPath

        GetAbilitiesData()
        GetAchievementsData()
        GetHeroesData()
        GetMapsData()
        GetSubtitlesData()
        GetTalentsData()
        GetUnlocksData()
        GetWorkshopData()
    End Sub

    Private Sub GetAbilities_Button_Click(sender As Object, e As EventArgs) Handles GetAbilities_Button.Click
        Dim JsonText As String = DataToolCMD.Json("abilities")

        GetAbilitiesData()
    End Sub

    Private Sub GetAbilitiesData()
        If Not File.Exists("json/abilities.json") Then Return

        Abilities = JObject.Parse(File.ReadAllText("json/Abilities.json"))
        Abilities_ToolStripStatusLabel.Text = $"Abilities ({Abilities.Count})"
    End Sub

    Private Sub GetAchievements_Button_Click(sender As Object, e As EventArgs) Handles GetAchievements_Button.Click
        Dim JsonText As String = DataToolCMD.Json("achievements")

        GetAchievementsData()
    End Sub

    Private Sub GetAchievementsData()
        If Not File.Exists("json/achievements.json") Then Return

        Achievements = JsonConvert.DeserializeObject(Of List(Of Achievement))(File.ReadAllText("json/achievements.json"))
        Achievements_ToolStripStatusLabel.Text = $"Achievements ({Achievements.Count})"
    End Sub

    Private Sub GetHeroes_Button_Click(sender As Object, e As EventArgs) Handles GetHeroes_Button.Click
        Dim JsonText As String = DataToolCMD.Json("heroes")

        GetHeroesData()
    End Sub

    Private Sub GetHeroesData()
        If Not File.Exists("json/heroes.json") Then Return

        Heroes = JObject.Parse(File.ReadAllText("json/Heroes.json"))
        Heroes_ToolStripStatusLabel.Text = $"Heroes ({Heroes.Count})"
    End Sub

    Private Sub GetMaps_Button_Click(sender As Object, e As EventArgs) Handles GetMaps_Button.Click
        Dim JsonText As String = DataToolCMD.Json("maps")

        GetMapsData()
    End Sub

    Private Sub GetMapsData()
        If Not File.Exists("json/maps.json") Then Return

        Maps = JObject.Parse(File.ReadAllText("json/maps.json"))
        Maps_ToolStripStatusLabel.Text = $"Maps ({Maps.Count})"
    End Sub

    Private Sub GetSubtitles_Button_Click(sender As Object, e As EventArgs) Handles GetSubtitles_Button.Click
        Dim JsonText As String = DataToolCMD.Json("subtitles")

        GetSubtitlesData()
    End Sub

    Private Sub GetSubtitlesData()
        If Not File.Exists("json/subtitles.json") Then Return

        Subtitles = JObject.Parse(File.ReadAllText("json/subtitles.json"))
        Subtitles_ToolStripStatusLabel.Text = $"Subtitles ({Subtitles.Count})"
    End Sub

    Private Sub GetSubtitlesReal_Button_Click(sender As Object, e As EventArgs) Handles GetSubtitlesReal_Button.Click

    End Sub

    Private Sub GetTalents_Button_Click(sender As Object, e As EventArgs) Handles GetTalents_Button.Click
        Dim JsonText As String = DataToolCMD.Json("Talents")

        GetTalentsData()
    End Sub

    Private Sub GetTalentsData()
        If Not File.Exists("json/talents.json") Then Return

        Talents = JObject.Parse(File.ReadAllText("json/talents.json"))
        Talents_ToolStripStatusLabel.Text = $"Talents ({Talents.Count})"
    End Sub

    Private Sub GetUnlocks_Button_Click(sender As Object, e As EventArgs) Handles GetUnlocks_Button.Click
        Dim JsonText As String = DataToolCMD.Json("Unlocks")

        GetUnlocksData()
    End Sub

    Private Sub GetUnlocksData()
        If Not File.Exists("json/unlocks.json") Then Return

        Unlocks = JObject.Parse(File.ReadAllText("json/unlocks.json"))
        Unlocks_ToolStripStatusLabel.Text = $"Unlocks ({Unlocks.Count})"
    End Sub

    Private Sub GetWorkshop_Button_Click(sender As Object, e As EventArgs) Handles GetWorkshop_Button.Click
        Dim JsonText As String = DataToolCMD.Json("Workshop")

        GetWorkshopData()
    End Sub

    Private Sub GetWorkshopData()
        If Not File.Exists("json/workshop.json") Then Return

        Workshop = JObject.Parse(File.ReadAllText("json/workshop.json"))
        Workshop_ToolStripStatusLabel.Text = $"Workshop ({Workshop.Count})"
    End Sub

    Private Sub Error_Button_Click(sender As Object, e As EventArgs) Handles Error_Button.Click
        Dim Output As String = DataToolCMD.Run("list-maps --json")
        'RichTextBox1.Text = Output
    End Sub
End Class

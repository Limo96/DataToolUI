<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataToolPath_TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        OverwatchPath_TextBox = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        ExportFolderPath_TextBox = New TextBox()
        GetHeroes_Button = New Button()
        Label4 = New Label()
        GetUnlocks_Button = New Button()
        Label5 = New Label()
        GetMaps_Button = New Button()
        Label6 = New Label()
        GetAchievements_Button = New Button()
        Label7 = New Label()
        Error_Button = New Button()
        GetAbilities_Button = New Button()
        Label8 = New Label()
        GetSubtitles_Button = New Button()
        Label9 = New Label()
        GetSubtitlesReal_Button = New Button()
        Label10 = New Label()
        GetTalents_Button = New Button()
        Label11 = New Label()
        GetWorkshop_Button = New Button()
        Label12 = New Label()
        StatusStrip1 = New StatusStrip()
        Abilities_ToolStripStatusLabel = New ToolStripStatusLabel()
        Achievements_ToolStripStatusLabel = New ToolStripStatusLabel()
        Heroes_ToolStripStatusLabel = New ToolStripStatusLabel()
        Maps_ToolStripStatusLabel = New ToolStripStatusLabel()
        Subtitles_ToolStripStatusLabel = New ToolStripStatusLabel()
        Talents_ToolStripStatusLabel = New ToolStripStatusLabel()
        Unlocks_ToolStripStatusLabel = New ToolStripStatusLabel()
        Workshop_ToolStripStatusLabel = New ToolStripStatusLabel()
        PictureBox2 = New PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataToolPath_TextBox
        ' 
        DataToolPath_TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataToolPath_TextBox.Location = New Point(120, 12)
        DataToolPath_TextBox.Name = "DataToolPath_TextBox"
        DataToolPath_TextBox.Size = New Size(668, 23)
        DataToolPath_TextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 1
        Label1.Text = "DataTool path"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 2
        Label2.Text = "Overwatch path"
        ' 
        ' OverwatchPath_TextBox
        ' 
        OverwatchPath_TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        OverwatchPath_TextBox.Location = New Point(120, 41)
        OverwatchPath_TextBox.Name = "OverwatchPath_TextBox"
        OverwatchPath_TextBox.Size = New Size(668, 23)
        OverwatchPath_TextBox.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ControlDark
        PictureBox1.Location = New Point(12, 99)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(776, 1)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 2
        Label3.Text = "Export folder path"
        ' 
        ' ExportFolderPath_TextBox
        ' 
        ExportFolderPath_TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ExportFolderPath_TextBox.Location = New Point(120, 70)
        ExportFolderPath_TextBox.Name = "ExportFolderPath_TextBox"
        ExportFolderPath_TextBox.Size = New Size(668, 23)
        ExportFolderPath_TextBox.TabIndex = 3
        ' 
        ' GetHeroes_Button
        ' 
        GetHeroes_Button.Location = New Point(120, 164)
        GetHeroes_Button.Name = "GetHeroes_Button"
        GetHeroes_Button.Size = New Size(75, 23)
        GetHeroes_Button.TabIndex = 5
        GetHeroes_Button.Text = "Get data"
        GetHeroes_Button.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 9
        Label4.Text = "Heroes"
        ' 
        ' GetUnlocks_Button
        ' 
        GetUnlocks_Button.Location = New Point(120, 309)
        GetUnlocks_Button.Name = "GetUnlocks_Button"
        GetUnlocks_Button.Size = New Size(75, 23)
        GetUnlocks_Button.TabIndex = 5
        GetUnlocks_Button.Text = "Get data"
        GetUnlocks_Button.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 9
        Label5.Text = "Unlocks"
        ' 
        ' GetMaps_Button
        ' 
        GetMaps_Button.Location = New Point(120, 193)
        GetMaps_Button.Name = "GetMaps_Button"
        GetMaps_Button.Size = New Size(75, 23)
        GetMaps_Button.TabIndex = 5
        GetMaps_Button.Text = "Get data"
        GetMaps_Button.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 9
        Label6.Text = "Maps"
        ' 
        ' GetAchievements_Button
        ' 
        GetAchievements_Button.Location = New Point(120, 135)
        GetAchievements_Button.Name = "GetAchievements_Button"
        GetAchievements_Button.Size = New Size(75, 23)
        GetAchievements_Button.TabIndex = 5
        GetAchievements_Button.Text = "Get data"
        GetAchievements_Button.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 139)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 9
        Label7.Text = "Achievements"
        ' 
        ' Error_Button
        ' 
        Error_Button.Location = New Point(120, 367)
        Error_Button.Name = "Error_Button"
        Error_Button.Size = New Size(75, 23)
        Error_Button.TabIndex = 5
        Error_Button.Text = "Error"
        Error_Button.UseVisualStyleBackColor = True
        ' 
        ' GetAbilities_Button
        ' 
        GetAbilities_Button.Location = New Point(120, 106)
        GetAbilities_Button.Name = "GetAbilities_Button"
        GetAbilities_Button.Size = New Size(75, 23)
        GetAbilities_Button.TabIndex = 5
        GetAbilities_Button.Text = "Get data"
        GetAbilities_Button.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 9
        Label8.Text = "Abilities"
        ' 
        ' GetSubtitles_Button
        ' 
        GetSubtitles_Button.Location = New Point(120, 222)
        GetSubtitles_Button.Name = "GetSubtitles_Button"
        GetSubtitles_Button.Size = New Size(75, 23)
        GetSubtitles_Button.TabIndex = 5
        GetSubtitles_Button.Text = "Get data"
        GetSubtitles_Button.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 226)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 15)
        Label9.TabIndex = 9
        Label9.Text = "Subtitles"
        ' 
        ' GetSubtitlesReal_Button
        ' 
        GetSubtitlesReal_Button.Location = New Point(120, 251)
        GetSubtitlesReal_Button.Name = "GetSubtitlesReal_Button"
        GetSubtitlesReal_Button.Size = New Size(75, 23)
        GetSubtitlesReal_Button.TabIndex = 5
        GetSubtitlesReal_Button.Text = "Get data"
        GetSubtitlesReal_Button.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 255)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 15)
        Label10.TabIndex = 9
        Label10.Text = "Subtitles real"
        ' 
        ' GetTalents_Button
        ' 
        GetTalents_Button.Location = New Point(120, 280)
        GetTalents_Button.Name = "GetTalents_Button"
        GetTalents_Button.Size = New Size(75, 23)
        GetTalents_Button.TabIndex = 5
        GetTalents_Button.Text = "Get data"
        GetTalents_Button.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 284)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 9
        Label11.Text = "Talents"
        ' 
        ' GetWorkshop_Button
        ' 
        GetWorkshop_Button.Location = New Point(120, 338)
        GetWorkshop_Button.Name = "GetWorkshop_Button"
        GetWorkshop_Button.Size = New Size(75, 23)
        GetWorkshop_Button.TabIndex = 5
        GetWorkshop_Button.Text = "Get data"
        GetWorkshop_Button.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(12, 342)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 15)
        Label12.TabIndex = 9
        Label12.Text = "Workshop"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(134), CByte(27), CByte(45))
        StatusStrip1.Items.AddRange(New ToolStripItem() {Abilities_ToolStripStatusLabel, Achievements_ToolStripStatusLabel, Heroes_ToolStripStatusLabel, Maps_ToolStripStatusLabel, Subtitles_ToolStripStatusLabel, Talents_ToolStripStatusLabel, Unlocks_ToolStripStatusLabel, Workshop_ToolStripStatusLabel})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 10
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Abilities_ToolStripStatusLabel
        ' 
        Abilities_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Abilities_ToolStripStatusLabel.Name = "Abilities_ToolStripStatusLabel"
        Abilities_ToolStripStatusLabel.Size = New Size(66, 17)
        Abilities_ToolStripStatusLabel.Text = "Abilities (0)"
        ' 
        ' Achievements_ToolStripStatusLabel
        ' 
        Achievements_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Achievements_ToolStripStatusLabel.Name = "Achievements_ToolStripStatusLabel"
        Achievements_ToolStripStatusLabel.Size = New Size(99, 17)
        Achievements_ToolStripStatusLabel.Text = "Achievements (0)"
        ' 
        ' Heroes_ToolStripStatusLabel
        ' 
        Heroes_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Heroes_ToolStripStatusLabel.Name = "Heroes_ToolStripStatusLabel"
        Heroes_ToolStripStatusLabel.Size = New Size(61, 17)
        Heroes_ToolStripStatusLabel.Text = "Heroes (0)"
        ' 
        ' Maps_ToolStripStatusLabel
        ' 
        Maps_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Maps_ToolStripStatusLabel.Name = "Maps_ToolStripStatusLabel"
        Maps_ToolStripStatusLabel.Size = New Size(53, 17)
        Maps_ToolStripStatusLabel.Text = "Maps (0)"
        ' 
        ' Subtitles_ToolStripStatusLabel
        ' 
        Subtitles_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Subtitles_ToolStripStatusLabel.Name = "Subtitles_ToolStripStatusLabel"
        Subtitles_ToolStripStatusLabel.Size = New Size(69, 17)
        Subtitles_ToolStripStatusLabel.Text = "Subtitles (0)"
        ' 
        ' Talents_ToolStripStatusLabel
        ' 
        Talents_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Talents_ToolStripStatusLabel.Name = "Talents_ToolStripStatusLabel"
        Talents_ToolStripStatusLabel.Size = New Size(60, 17)
        Talents_ToolStripStatusLabel.Text = "Talents (0)"
        ' 
        ' Unlocks_ToolStripStatusLabel
        ' 
        Unlocks_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Unlocks_ToolStripStatusLabel.Name = "Unlocks_ToolStripStatusLabel"
        Unlocks_ToolStripStatusLabel.Size = New Size(66, 17)
        Unlocks_ToolStripStatusLabel.Text = "Unlocks (0)"
        ' 
        ' Workshop_ToolStripStatusLabel
        ' 
        Workshop_ToolStripStatusLabel.ForeColor = SystemColors.ScrollBar
        Workshop_ToolStripStatusLabel.Name = "Workshop_ToolStripStatusLabel"
        Workshop_ToolStripStatusLabel.Size = New Size(78, 17)
        Workshop_ToolStripStatusLabel.Text = "Workshop (0)"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox2.BackColor = SystemColors.ControlDark
        PictureBox2.Location = New Point(201, 106)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1, 319)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(208, 106)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(335, 106)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(462, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(PictureBox2)
        Controls.Add(StatusStrip1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Error_Button)
        Controls.Add(GetWorkshop_Button)
        Controls.Add(GetTalents_Button)
        Controls.Add(GetSubtitlesReal_Button)
        Controls.Add(GetSubtitles_Button)
        Controls.Add(GetAbilities_Button)
        Controls.Add(GetAchievements_Button)
        Controls.Add(GetMaps_Button)
        Controls.Add(GetUnlocks_Button)
        Controls.Add(GetHeroes_Button)
        Controls.Add(PictureBox1)
        Controls.Add(ExportFolderPath_TextBox)
        Controls.Add(Label3)
        Controls.Add(OverwatchPath_TextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataToolPath_TextBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "DataToolUI"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataToolPath_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OverwatchPath_TextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExportFolderPath_TextBox As TextBox
    Friend WithEvents GetHeroes_Button As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GetUnlocks_Button As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GetMaps_Button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GetAchievements_Button As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Error_Button As Button
    Friend WithEvents GetAbilities_Button As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GetSubtitles_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GetSubtitlesReal_Button As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GetTalents_Button As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GetWorkshop_Button As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Abilities_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Achievements_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Heroes_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Maps_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Subtitles_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Talents_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Unlocks_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Workshop_ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button

End Class

Imports System.IO
Imports System.Threading

Public Class DataToolCMD
    Dim proc As Process

    Public Function Run(Command As String) As String
        proc = New Process()
        proc.StartInfo.FileName = My.Settings.DataToolPath
        proc.StartInfo.Arguments = $"""{My.Settings.OverwatchPath}"" {Command}"
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8
        proc.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8

        proc.Start()

        ' Legge tutto l'output solo al termine del processo
        'Dim output As String = proc.StandardOutput.ReadToEnd()
        'Dim err As String = proc.StandardError.ReadToEnd()


        Dim output As String = ""
        Dim err As String = ""

        Dim tOut As New Thread(Sub() output = proc.StandardOutput.ReadToEnd())
        Dim tErr As New Thread(Sub() err = proc.StandardError.ReadToEnd())

        tOut.Start()
        tErr.Start()

        proc.WaitForExit()
        tOut.Join()
        tErr.Join()



        'proc.WaitForExit()

        If err <> "" Then Return err

        Return output
    End Function

    Friend Function Json(Type As String, Optional Save As Boolean = True) As String
        proc = New Process()
        proc.StartInfo.FileName = My.Settings.DataToolPath
        proc.StartInfo.Arguments = $"""{My.Settings.OverwatchPath}"" list-{Type} --json"
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8
        proc.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8

        proc.Start()

        Dim output As String = ""

        Dim tOut As New Thread(Sub() output = proc.StandardError.ReadToEnd())

        tOut.Start()

        proc.WaitForExit()

        tOut.Join()

        If Save Then
            If Not Directory.Exists("json") Then Directory.CreateDirectory("json")
            File.WriteAllText($"json/{Type}.json", output)
        End If

        Return output
    End Function
End Class

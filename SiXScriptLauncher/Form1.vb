Public Class Form1
    Public ScriptPath As String
    Public SikuliPath As String

    Private Sub six_script_open_Click(sender As Object, e As EventArgs) Handles six_script_open.Click
        OpenFolder.ShowDialog()
        If OpenFolder.SelectedPath = "" Then
            six_path.Text = "No folder selected"
        Else
            ScriptPath = OpenFolder.SelectedPath.ToString()
            six_path_script.Text = ScriptPath
            TextBox1.AppendText("Sikuli script path:" & Space(1) & ScriptPath)
        End If

    End Sub

    Private Sub six_path_open_Click(sender As Object, e As EventArgs) Handles six_path_open.Click
        OpenFolder.ShowDialog()
        If OpenFolder.SelectedPath = "" Then
            six_path.Text = "No folder selected"
        Else
            SikuliPath = OpenFolder.SelectedPath.ToString()
            six_path.Text = SikuliPath
            TextBox1.AppendText("Sikuli path:" & Space(1) & SikuliPath & "\sikulix.jar")
        End If

    End Sub

    Private Function Process_run() As Boolean
        Dim myProcess As New Process()
        Try
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.FileName = "javaw.exe"
            myProcess.StartInfo.Arguments = " -Xms64M -Xmx512M -Dfile.encoding=UTF-8 -Dsikuli.FromCommandLine -jar" & Space(1) & SikuliPath & "\sikulix.jar -r" & Space(1) & ScriptPath
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.EnableRaisingEvents = True
            myProcess.Start()
            Dim output As String
            Dim SR As IO.StreamReader = myProcess.StandardOutput
            Do While SR.EndOfStream = False
                output = output + SR.ReadLine()
            Loop
            TextBox1.Text = output
        Catch ex As Exception
            Console.WriteLine((ex.Message))
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process_run()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://www.github.com/"
        Process.Start(webAddress)
    End Sub
End Class

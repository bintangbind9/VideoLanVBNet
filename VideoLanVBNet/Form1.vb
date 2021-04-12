Public Class Form1
    Private Sub btOn_Click(sender As Object, e As EventArgs) Handles btOn.Click
        If btOn.Text = "ON" Then
            btOn.Text = "OFF"
            cam1.playlist.add(TextBox1.Text)
            cam1.playlist.play()
        Else
            btOn.Text = "ON"
            cam1.playlist.stop()
        End If
    End Sub

    Private Sub isiListFile()
        'Make a reference to a directory
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\gbr")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        ListBox1.Items.Clear()
        'List the names of all files in the specified directory
        For Each dra In diar1
            ListBox1.Items.Add(dra)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiListFile()
    End Sub

    Private Sub btCapture_Click(sender As Object, e As EventArgs) Handles btCapture.Click
        Clipboard.Clear()
        cam1.video.takeSnapshot()
        Dim tgljam As String = Now
        Dim sFile = Dir(Application.StartupPath & "\*.bmp")
        Dim fileBmp As String = ""
        Do Until sFile = ""
            fileBmp = sFile
            sFile = Dir()
        Loop

        Dim FileName As String = Application.StartupPath & "\" & fileBmp
        Dim NewFileName As String = Application.StartupPath & "\gbr\" & Format(Now, "yyyyMMddHHmmss") & ".bmp"

        My.Computer.FileSystem.CopyFile(FileName, NewFileName)
        My.Computer.FileSystem.DeleteFile(FileName)
        If Dir$(NewFileName) <> "" Then
            img1.BackgroundImage = Bitmap.FromFile(NewFileName)
        End If

        isiListFile()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        img2.BackgroundImage = Bitmap.FromFile(Application.StartupPath & "\gbr\" & ListBox1.SelectedItem.ToString)
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If btOn.Text = "OFF" Then
            cam1.playlist.stop()
        End If
    End Sub
End Class

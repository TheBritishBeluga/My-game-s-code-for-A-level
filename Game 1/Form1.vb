#Region "All"
Imports System.IO
Public Class Form1

#Region "Start Up"
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        arr()
        dict()
        locstart()
    End Sub
#End Region

#Region "Evaluation Code"
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Dim X As Integer
        Dim Y As Integer
        If e.KeyCode = Keys.Right Then
            X = PictureBox3.Left
            Y = PictureBox3.Top
            PictureBox4.Left = X
            PictureBox4.Top = Y
            X = PictureBox2.Left
            Y = PictureBox2.Top
            PictureBox3.Left = X
            PictureBox3.Top = Y
            X = PictureBox1.Left
            Y = PictureBox1.Top
            PictureBox2.Left = X
            PictureBox2.Top = Y
            PictureBox1.Left += 50

        ElseIf e.KeyCode = Keys.Up Then
            X = PictureBox3.Left
            Y = PictureBox3.Top
            PictureBox4.Left = X
            PictureBox4.Top = Y
            X = PictureBox2.Left
            Y = PictureBox2.Top
            PictureBox3.Left = X
            PictureBox3.Top = Y
            X = PictureBox1.Left
            Y = PictureBox1.Top
            PictureBox2.Left = X
            PictureBox2.Top = Y
            PictureBox1.Top -= 50

        ElseIf e.KeyCode = Keys.Left Then
            X = PictureBox3.Left
            Y = PictureBox3.Top
            PictureBox4.Left = X
            PictureBox4.Top = Y
            X = PictureBox2.Left
            Y = PictureBox2.Top
            PictureBox3.Left = X
            PictureBox3.Top = Y
            X = PictureBox1.Left
            Y = PictureBox1.Top
            PictureBox2.Left = X
            PictureBox2.Top = Y
            PictureBox1.Left -= 50

        ElseIf e.KeyCode = Keys.Down Then
            X = PictureBox3.Left
            Y = PictureBox3.Top
            PictureBox4.Left = X
            PictureBox4.Top = Y
            X = PictureBox2.Left
            Y = PictureBox2.Top
            PictureBox3.Left = X
            PictureBox3.Top = Y
            X = PictureBox1.Left
            Y = PictureBox1.Top
            PictureBox2.Left = X
            PictureBox2.Top = Y
            PictureBox1.Top += 50

        End If

    End Sub
    'miscellaneous snake game code for evaluation
#End Region

#Region "Resolution Settings"

    Dim Res As Integer = 0
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Size = New Size(800, 600)
        Secondsbox.Left = 800 - Locs
        Minetbox.Left = 800 - Locm
        Hourbox.Left = 800 - Loch
        Res = 0
    End Sub
    '800 x 600
    Private Sub X1080ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X1080ToolStripMenuItem.Click
        Me.Size = New Size(1024, 768)
        Secondsbox.Left = 1024 - Locs
        Minetbox.Left = 1024 - Locm
        Hourbox.Left = 1024 - Loch
        Res = 1
    End Sub
    '1024 x 768
    Private Sub X864ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X864ToolStripMenuItem.Click
        Me.Size = New Size(1151, 864)
        Secondsbox.Left = 1151 - Locs
        Minetbox.Left = 1151 - Locm
        Hourbox.Left = 1151 - Loch
        Res = 2
    End Sub
    '1151 x 864
    Private Sub X600ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X600ToolStripMenuItem.Click
        Me.Size = New Size(1280, 600)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 3
    End Sub
    '1280 x 600
    Private Sub X720ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X720ToolStripMenuItem.Click
        Me.Size = New Size(1280, 720)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 4
    End Sub
    '1280 x 720
    Private Sub X768ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X768ToolStripMenuItem.Click
        Me.Size = New Size(1280, 768)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 5
    End Sub
    '1280 x 768
    Private Sub X800ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X800ToolStripMenuItem.Click
        Me.Size = New Size(1280, 800)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 6
    End Sub
    '1280 x 800
    Private Sub X960ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X960ToolStripMenuItem.Click
        Me.Size = New Size(1280, 960)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 7
    End Sub
    '1280 x 960
    Private Sub X1024ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X1024ToolStripMenuItem.Click
        Me.Size = New Size(1280, 1024)
        Secondsbox.Left = 1280 - Locs
        Minetbox.Left = 1280 - Locm
        Hourbox.Left = 1280 - Loch
        Res = 8
    End Sub
    '1280 x 1024
#End Region

#Region "Timer stuff"
#Region "Timer"
    Private Sub Seconds_Tick(sender As Object, e As EventArgs) Handles Seconds.Tick
        Dim sto As String
        sto = Secondsbox.Text
        sto = CType(sto, Integer)
        sto += 1
        If sto >= 60 Then
            minet()
            sto = 0
        End If
        Secondsbox.Text = sto
    End Sub
    Sub minet()
        Dim sto As String
        sto = Minetbox.Text
        sto = CType(sto, Integer)
        sto += 1
        If sto >= 60 Then
            Hour()
            sto = 0
        End If
        Minetbox.Text = sto
    End Sub
    Sub Hour()
        Dim sto As String
        sto = Hourbox.Text
        sto = CType(sto, Integer)
        sto += 1
        Hourbox.Text = sto
    End Sub
    'Clock in seconds, minutes and hours.
#End Region

    Dim Locs As Integer = 38
    Dim Locm As Integer = 62
    Dim Loch As Integer = 86
    'distances of timer elements from the right edge of the form
    Dim SecLoc As Integer
    Dim MinLoc As Integer
    Dim HorLoc As Integer
    'Helps to keep track of the location of the timer
#End Region

#Region "Fullscreen"
    Dim WinSta As Integer = 0
    'Helps to keep track of the current state of the window
    Private Sub FullButton(sender As Object, e As EventArgs) Handles FullscreenToolStripMenuItem1.Click
        If WinSta = 0 Then
            Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            WinSta = 1
            SecLoc = Secondsbox.Left
            MinLoc = Minetbox.Left
            HorLoc = Hourbox.Left
            Secondsbox.Left = ScreenWidth - Locs
            Minetbox.Left = ScreenWidth - Locm
            Hourbox.Left = ScreenWidth - Loch
        ElseIf WinSta = 1 Then
            WindowState = FormWindowState.Normal
            FormBorderStyle = FormBorderStyle.FixedSingle
            WinSta = 0
            Secondsbox.Left = SecLoc
            Minetbox.Left = MinLoc
            Hourbox.Left = HorLoc
        End If
    End Sub
    'Allows the window to become fullscreen from the menu
    Private Sub FullF11(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 And WinSta = 0 Then
            Dim ScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            WinSta = 1
            SecLoc = Secondsbox.Left
            MinLoc = Minetbox.Left
            HorLoc = Hourbox.Left
            Secondsbox.Left = ScreenWidth - Locs
            Minetbox.Left = ScreenWidth - Locm
            Hourbox.Left = ScreenWidth - Loch
        ElseIf e.KeyCode = Keys.F11 And WinSta = 1 Then
            WindowState = FormWindowState.Normal
            FormBorderStyle = FormBorderStyle.FixedSingle
            WinSta = 0
            Secondsbox.Left = SecLoc
            Minetbox.Left = MinLoc
            Hourbox.Left = HorLoc
        End If
    End Sub
    'Allows F11 to be used to change the form to fullscreen
#End Region

#Region "Swapper"
    Dim swp As Integer = 0
    Private Sub SwapToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SwapToolStripMenuItem1.Click
        If swp = 0 Then
            PictureBox5.Image() = (Framework.My.Resources.Resources.LD1)
            swp = 1
        ElseIf swp = 1 Then
            PictureBox5.Image() = (Framework.My.Resources.Resources.Red)
            swp = 0
        End If
    End Sub
    'Swaps the image of a set picture box
#End Region

#Region "Create, Read, Write and Delete"
    Dim FileName As String = FileDire & "\tst.dll"
    Dim FileDire As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\test"
    'https://social.msdn.microsoft.com/Forums/vstudio/en-US/5b34abb4-1fc4-46e3-b3f7-7872bdfe0b7e/create-directory-in-my-documents?forum=vbgeneral
    'helped me to resolve issues of creating a file in "MyDocuments"
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        If File.Exists(FileName) Then
            MsgBox("File Already Exists", "1", "File Creator")
        Else
            Try
                My.Computer.FileSystem.CreateDirectory(FileDire)
            Catch UAex As UnauthorizedAccessException
                Exit Try
            End Try
            Try
                File.Create(FileName).Dispose()
                MsgBox("File Created", "1", "File Creator")
            Catch UAex As UnauthorizedAccessException
                MsgBox("Please run the program as Admin", "1", "File Creator")
                Exit Try
            End Try
            'Stops if there is an error regarding Access and requests it
        End If
    End Sub
    'Creates a file
    Private Sub ReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadToolStripMenuItem.Click
        If File.Exists(FileName) Then
            MsgBox(File.ReadAllText(FileName))
        Else
            MsgBox("File Doesn't Exist")
        End If
    End Sub
    'Reads a file
    Private Sub WriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WriteToolStripMenuItem.Click
        Dim prompt As String = "What is going ot br written to the file"
        Dim title As String = "File Write"

        If File.Exists(FileName) = True Then

            Dim objWriter As New StreamWriter(FileName)
            objWriter.Write(InputBox(prompt, title))
            objWriter.Close()
            MsgBox("Text written to file")

        Else
            MsgBox("File Doesn't Exist")
        End If
    End Sub
    'Writes a file
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If File.Exists(FileName) Then
            File.Delete(FileName)
            Directory.Delete(FileDire)
        Else
            MsgBox("File Doesn't Exist")
        End If
    End Sub
    'Deletes a file

#End Region

#Region "Exiter"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes the form
#End Region

#Region "Pause Menu"
    Private Sub FullEsc(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape And WinSta = 0 Then


        ElseIf e.KeyCode = Keys.Escape And WinSta = 1 Then


        End If
    End Sub
#End Region

#Region "Music"
    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        My.Computer.Audio.Stop()
    End Sub
    Private Sub BigIronToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BigIronToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.Bigiron, AudioPlayMode.BackgroundLoop)
    End Sub

#End Region

#Region "Array Stuff"
    Public locdic As New Dictionary(Of String, Control)
    Dim playerx As Integer = 1
    Dim playery As Integer = 1
    Dim playerloc As String
    Dim locarr(2, 2) As String

    Sub dict()
        locdic.Add("p00", p00)
        locdic.Add("p10", p10)
        locdic.Add("p20", p20)
        locdic.Add("p01", p01)
        locdic.Add("p11", p11)
        locdic.Add("p21", p21)
        locdic.Add("p02", p02)
        locdic.Add("p12", p12)
        locdic.Add("p22", p22)
    End Sub

    Sub arr()
        locarr(0, 0) = "p00"
        locarr(1, 0) = "p10"
        locarr(2, 0) = "p20"
        locarr(0, 1) = "p01"
        locarr(1, 1) = "p11"
        locarr(2, 1) = "p21"
        locarr(0, 2) = "p02"
        locarr(1, 2) = "p12"
        locarr(2, 2) = "p22"
    End Sub
    Sub locstart()
        playerloc = locarr(playerx, playery)
        locdic(playerloc).Text = "p"
    End Sub
    Private Sub p01_Click(sender As Object, e As EventArgs) Handles p01.Click
        locdic(playerloc).Text = "B"
        playerx -= 1
        playerloc = locarr(playerx, playery)
        locdic(playerloc).Text = "p"
    End Sub

#End Region




End Class
#End Region
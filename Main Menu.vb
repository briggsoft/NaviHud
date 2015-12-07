Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Size
Public Class Form1
    Dim proc As New System.Diagnostics.Process()
    Public Function IsProcessRunning(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To The Navigational Program", "NaviHud", MessageBoxButtons.OK)
        'place Splash Screen if you want here
        'place ip text
        Log.SelectedIndex = Log.Items.Count - 1
        Timer1.Enabled = True
        NumericUpDown1.Hide()
        Timer2.Enabled = True
        TextBox1.Text = WebBrowser1.Url.ToString()
        WebBrowser1.Hide()
        Button3.Hide()
        linkImageview.Location = New Point(652, 135)
        linkImageview.Size = New Point(330, 486)
        Panel1.Location = New Point(12, 135)
        Panel1.Size = New Point(298, 486)
        Log.Items.Add("NaviHud Turned on - " & Now)
       
        '============================================
        '        = App list =
        chromeRefresh.Enabled = True
        notepadRefresh.Enabled = True
        Aimrefresh.Enabled = True
        hl2Refresh.Enabled = True
        DupeRefresh.Enabled = True
        SteamRefresh.Enabled = True
        '============================================
        '              _TODO LIST_
        'FireFox/Gecko Engine for browser
        'Boot up at start in options [checkBox]
        'Options Add Proxy Textbox for Browser
        'Me.Button1.BackgroundImage = My.Resources.
        'Me.Button1.BackgroundImageLayout = ImageLayout.Center     
    End Sub
    Private Sub Form1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.ShowBalloonTip(300, "On Stand by", "Applications can still run", ToolTipIcon.Info)
        End If
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'This is the Terminate button
        'process kill everything 
        'Incase of emergency
        If MessageBox.Show("Are you sure you want to Terminate?", "Navi Hud Emergency Termination", MessageBoxButtons.OKCancel, _
             Nothing, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            MsgBox("terminating...")
            'deploy Process killer
            'deploy vbs and/or EPIC SNED
        Else
            MsgBox("Aborting...")
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TextBox1.Text = WebBrowser1.Url.ToString()
        Me.Text = WebBrowser1.DocumentTitle.ToString()
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        WebBrowser1.Navigate(TextBox1.Text)
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub toolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) _
        Handles TextBox1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            WebBrowser1.Navigate(TextBox1.Text)
        End If
    End Sub
    Private Sub ToolStripStatusLabel4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel4.TextChanged
        'Ip addres
        'navi this shit
    End Sub
    Private Sub ToolStripLabel1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Place Time here
        'ToolStripStatusLabel4
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = NumericUpDown1.Value
        Label1.Left = Label1.Left - 1
        If Label1.Left < 0 - Label1.Width Then
            Label1.Left = Me.Width
        End If
        'Navi information from web
        'label1 text changes to other news/updates
        'RSS feeds
        If Label1.Left = Me.Width Then
            Label1.Text = ("Text dupped")
        End If
    End Sub
    Private Sub Navigate(ByVal address As String)
        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") And _
            Not address.StartsWith("https://") Then
            address = "http://" & address
        End If
        Try
            WebBrowser1.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            Return
        End Try
    End Sub
    Private Sub webBrowser1_Navigated(ByVal sender As Object, _
ByVal e As WebBrowserNavigatedEventArgs)
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        'DELETE COMMENT SECTION HERE

        'Me.Button1.BackgroundImage = My.Resources.
        'Me.Button1.BackgroundImageLayout = ImageLayout.Center
    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        'DELETE COMMENT SECTION HERE

        'Me.Button1.BackgroundImage = My.Resources.
        'Me.Button1.BackgroundImageLayout = ImageLayout.Center
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        'DELETE COMMENT SECTION HERE

        'Me.Button1.BackgroundImage = My.Resources.
        'Me.Button1.BackgroundImageLayout = ImageLayout.Center
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'when hover over then blue box around icon
        Label1.Visible = False
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Label2.Text = TimeOfDay
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'when hover over then blue box around icon
        'Navi updates
        'this checks for navihud's verison if there no verison then prompt msg saying there are no new updates
        'if there is a new update it says new update avaliable and automaticly exits and updates
        MsgBox("update button is disabled")
    End Sub
    Private Sub MediaViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaViewerToolStripMenuItem.Click
        'mediaviewer
        'plays sounds and video
        'Receives pictures 

    End Sub
    Private Sub SoundboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundboardToolStripMenuItem.Click
        'soundboard
        soundboard.Show()
    End Sub
    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Restart()
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub UDPFlooderToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UDPFlooderToolStripMenuItem1.Click
        'UDP
        UDP_Flooder.Show()
        Log.Items.Add("UDP Flooder on - " & Now)
    End Sub
    Private Sub CodeEditorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeEditorToolStripMenuItem1.Click
        'code editor
        Code_editor.Show()
        Log.Items.Add("Code editor on - " & Now)
    End Sub
    Private Sub PlannerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlannerToolStripMenuItem1.Click
        'planner
        Planner.Show()
        Log.Items.Add("Planner on - " & Now)
    End Sub
    Private Sub NumberRollToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberRollToolStripMenuItem1.Click
        'NumberRoll
        NR.Show()
        Log.Items.Add("Number Roll on - " & Now)
    End Sub
    Private Sub SoundboardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundboardToolStripMenuItem1.Click
        'soundboard
        soundboard.Show()
        Log.Items.Add("SoundBoard on - " & Now)
    End Sub
    Private Sub SystemPropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemPropertiesToolStripMenuItem1.Click
        'SystemProperties
        System_Properties.Show()
        Log.Items.Add("System Properties on - " & Now)
    End Sub
    Private Sub AlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlarmToolStripMenuItem.Click
        Alarm.Show()
        Log.Items.Add("Alarm on - " & Now)
    End Sub
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        'Terminate
        MsgBox("terminate button disabled")
    End Sub
    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        'sned
        WebBrowser1.Navigate(TextBox1.Text)
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        'forwards
        WebBrowser1.GoForward()
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        'back
        WebBrowser1.GoBack()
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'refresh
        WebBrowser1.Refresh()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'stop

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Change to PictureBox
        Log.Items.Add("browser turned on - " & Now)
        TextBox1.Text = ("")
        WebBrowser1.Location = New Point(0, 25)
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Show()
        Button2.Hide()
        Log.Hide()
        desbottom.Hide()
    End Sub
    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Log.Items.Add("In Main Menu - " & Now)
        TextBox1.Text = ("Main Hud")
        Button2.Show()
        WebBrowser1.Hide()
        Log.Show()
        desbottom.Show()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Panel1.Hide()
    End Sub
    Private Sub PictureBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.DoubleClick
        Panel1.Show()
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        linkImageview.Hide()
    End Sub
    Private Sub PictureBox4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.DoubleClick
        linkImageview.Show()
    End Sub
    Private Sub notepadRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles notepadRefresh.Tick
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(Name) Then
            End If
        Next
        If IsProcessRunning("notepad") = True Then
            'Action
            Log.Items.Add("Notepad (42) - " & Now)
            notepadRefresh.Enabled = False
        End If
        If IsProcessRunning("notepad") = False Then
            'if Action is off
            notepadRefresh.Enabled = True
        End If
    End Sub
    Private Sub chromeRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chromeRefresh.Tick
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(Name) Then
            End If
        Next
        If IsProcessRunning("chrome") = True Then
            'Action
            Log.Items.Add("chrome (42) - " & Now)
            chromeRefresh.Enabled = False
        End If
        If IsProcessRunning("chrome") = False Then
            'if Action is off
            chromeRefresh.Enabled = True
        End If
    End Sub
    Private Sub SteamRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SteamRefresh.Tick
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(Name) Then
            End If
        Next
        If IsProcessRunning("Steam") = True Then
            'Action
            Log.Items.Add("steam (42) - " & Now)
            SteamRefresh.Enabled = False
        End If
        If IsProcessRunning("Steam") = False Then
            'if Action is off
            SteamRefresh.Enabled = True
        End If
    End Sub
    Private Sub Aimrefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aimrefresh.Tick
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(Name) Then
            End If
        Next
        If IsProcessRunning("aim") = True Then
            'Action
            Log.Items.Add("Aim (42) - " & Now)
            Aimrefresh.Enabled = False
        End If
        If IsProcessRunning("aim") = False Then
            'if Action is off
            Aimrefresh.Enabled = True
        End If
    End Sub
    Private Sub LoadingTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadingTestToolStripMenuItem.Click
        Loading.Show()
        Loading.Timer1.Enabled = True
        Log.Items.Add("Loading Screen - " & Now)

    End Sub
End Class

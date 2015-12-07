<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 22)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 22)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(23, 108)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(363, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(26, 108)
        Me.Panel4.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(29, 91)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(328, 33)
        Me.ProgressBar1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(389, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <> ProgressBar1.Maximum Then
            ProgressBar1.Value = (ProgressBar1.Value + 1)
        End If
        If ProgressBar1.Value = 100 Then
            Me.Visible = False
            ProgressBar1.Value = 0
            Timer1.Enabled = False
            If ProgressBar1.Value = 1 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 2 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 12 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 14 Then
                Timer1.Interval = 4000
            End If
            If ProgressBar1.Value = 15 Then
                Timer1.Interval = 1
            End If
            If ProgressBar1.Value = 17 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 21 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 23 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 25 Then
                Timer1.Interval = 4000
            End If
            If ProgressBar1.Value = 28 Then
                Timer1.Interval = 1
            End If
            If ProgressBar1.Value = 32 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 35 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 38 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 42 Then
                Timer1.Interval = 4000
            End If
            If ProgressBar1.Value = 46 Then
                Timer1.Interval = 1
            End If
            If ProgressBar1.Value = 50 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 54 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 57 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 60 Then
                Timer1.Interval = 4000
            End If
            If ProgressBar1.Value = 66 Then
                Timer1.Interval = 1
            End If
            If ProgressBar1.Value = 69 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 73 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 77 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 79 Then
                Timer1.Interval = 4000
            End If
            If ProgressBar1.Value = 84 Then
                Timer1.Interval = 1
            End If
            If ProgressBar1.Value = 89 Then
                Timer1.Interval = 800
            End If
            If ProgressBar1.Value = 93 Then
                Timer1.Interval = 75
            End If
            If ProgressBar1.Value = 95 Then
                Timer1.Interval = 600
            End If
            If ProgressBar1.Value = 99 Then
                Timer1.Interval = 4000
            End If
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class

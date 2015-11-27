<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.six_path_open = New System.Windows.Forms.Button()
        Me.OpenFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.six_path = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.six_path_label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.six_path_script_label = New System.Windows.Forms.Label()
        Me.six_script_open = New System.Windows.Forms.Button()
        Me.six_path_script = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'six_path_open
        '
        Me.six_path_open.Location = New System.Drawing.Point(9, 38)
        Me.six_path_open.Name = "six_path_open"
        Me.six_path_open.Size = New System.Drawing.Size(250, 23)
        Me.six_path_open.TabIndex = 0
        Me.six_path_open.Text = "Open SikuliX folder"
        Me.six_path_open.UseVisualStyleBackColor = True
        '
        'OpenFolder
        '
        Me.OpenFolder.Description = "Choose a SikuliX path..."
        Me.OpenFolder.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.OpenFolder.SelectedPath = "C:\Program Files"
        Me.OpenFolder.ShowNewFolderButton = False
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFile1"
        '
        'six_path
        '
        Me.six_path.Location = New System.Drawing.Point(51, 12)
        Me.six_path.Name = "six_path"
        Me.six_path.ReadOnly = True
        Me.six_path.Size = New System.Drawing.Size(208, 20)
        Me.six_path.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.six_path_label)
        Me.GroupBox1.Controls.Add(Me.six_path_open)
        Me.GroupBox1.Controls.Add(Me.six_path)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 71)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SikuliX"
        '
        'six_path_label
        '
        Me.six_path_label.BackColor = System.Drawing.Color.Transparent
        Me.six_path_label.Location = New System.Drawing.Point(6, 12)
        Me.six_path_label.Name = "six_path_label"
        Me.six_path_label.Size = New System.Drawing.Size(39, 20)
        Me.six_path_label.TabIndex = 2
        Me.six_path_label.Text = "Path:"
        Me.six_path_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.six_path_script_label)
        Me.GroupBox2.Controls.Add(Me.six_script_open)
        Me.GroupBox2.Controls.Add(Me.six_path_script)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 71)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Script"
        '
        'six_path_script_label
        '
        Me.six_path_script_label.BackColor = System.Drawing.Color.Transparent
        Me.six_path_script_label.Location = New System.Drawing.Point(6, 12)
        Me.six_path_script_label.Name = "six_path_script_label"
        Me.six_path_script_label.Size = New System.Drawing.Size(39, 20)
        Me.six_path_script_label.TabIndex = 2
        Me.six_path_script_label.Text = "Path:"
        Me.six_path_script_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'six_script_open
        '
        Me.six_script_open.Location = New System.Drawing.Point(9, 38)
        Me.six_script_open.Name = "six_script_open"
        Me.six_script_open.Size = New System.Drawing.Size(250, 23)
        Me.six_script_open.TabIndex = 0
        Me.six_script_open.Text = "Open Script folder"
        Me.six_script_open.UseVisualStyleBackColor = True
        '
        'six_path_script
        '
        Me.six_path_script.Location = New System.Drawing.Point(51, 12)
        Me.six_path_script.Name = "six_path_script"
        Me.six_path_script.ReadOnly = True
        Me.six_path_script.Size = New System.Drawing.Size(208, 20)
        Me.six_path_script.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Launch script"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.AliceBlue
        Me.TextBox1.Location = New System.Drawing.Point(9, 200)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(250, 79)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "v1.0 by aolko"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(223, 286)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(36, 13)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "github"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.MidnightBlue
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 308)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SiXScriptLauncher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents six_path_open As Button
    Friend WithEvents OpenFolder As FolderBrowserDialog
    Friend WithEvents OpenFile As OpenFileDialog
    Friend WithEvents six_path As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents six_path_label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents six_path_script_label As Label
    Friend WithEvents six_script_open As Button
    Friend WithEvents six_path_script As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.closewindow = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closewindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(936, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go !"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(45, 169)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(987, 655)
        Me.WebBrowser1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(748, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(61, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(242, 121)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 43)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Forword"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(453, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 43)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(647, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 44)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(857, 120)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 43)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Set Homepage"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Alpha version made by Gonçalo Matos "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(745, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Copyright O.S. 2013"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Browser.My.Resources.Resources.titlebar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.minimize)
        Me.Panel1.Controls.Add(Me.maximize)
        Me.Panel1.Controls.Add(Me.closewindow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1106, 25)
        Me.Panel1.TabIndex = 11
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.BackgroundImage = Global.Browser.My.Resources.Resources.minimize
        Me.minimize.Location = New System.Drawing.Point(1036, 3)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(17, 21)
        Me.minimize.TabIndex = 2
        Me.minimize.TabStop = False
        '
        'maximize
        '
        Me.maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.maximize.BackgroundImage = Global.Browser.My.Resources.Resources.maximize
        Me.maximize.Location = New System.Drawing.Point(1059, 3)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(16, 17)
        Me.maximize.TabIndex = 1
        Me.maximize.TabStop = False
        '
        'closewindow
        '
        Me.closewindow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closewindow.BackColor = System.Drawing.Color.Transparent
        Me.closewindow.BackgroundImage = Global.Browser.My.Resources.Resources.close
        Me.closewindow.Location = New System.Drawing.Point(1081, 3)
        Me.closewindow.Name = "closewindow"
        Me.closewindow.Size = New System.Drawing.Size(20, 17)
        Me.closewindow.TabIndex = 0
        Me.closewindow.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Browser.My.Resources.Resources.titlebar
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1096, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 830)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Browser.My.Resources.Resources.titlebar
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(-3, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 838)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Browser.My.Resources.Resources.titlebar
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 845)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1096, 10)
        Me.Panel4.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1106, 855)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Browser"
        Me.Panel1.ResumeLayout(False)
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closewindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents minimize As System.Windows.Forms.PictureBox
    Friend WithEvents maximize As System.Windows.Forms.PictureBox
    Friend WithEvents closewindow As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel

End Class

Public Class Form1
    Dim NewPoint As New System.Drawing.Point()
    Dim X, Y As Integer
    Private Sub Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dialog1.TextBox1.Text = My.Settings.Homepage
        WebBrowser1.Navigate(Dialog1.TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dialog1.TextBox1.Text = My.Settings.Homepage
        WebBrowser1.Navigate(Dialog1.TextBox1.Text)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dialog1.Show()
    End Sub

    Private Sub maximize_Click(sender As System.Object, e As System.EventArgs) Handles maximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub closewindow_Click(sender As System.Object, e As System.EventArgs) Handles closewindow.Click
        End
    End Sub

    Private Sub minimize_Click(sender As System.Object, e As System.EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
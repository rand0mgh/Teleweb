Public Class Form1

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        WebBrowser1.Navigate("http://frogfind.com")
    End Sub

    Private Sub GOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GOToolStripMenuItem.Click
        WebBrowser1.Navigate(ToolStripTextBox1.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Form2.Visible = True
    End Sub
End Class

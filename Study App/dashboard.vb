Public Class dashboard
    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        activePanel.Height = subjectbtn.Height
        activePanel.Top = homeBtn.Top
        homePanel.Visible = True
        coursePanel.Visible = False
    End Sub

    Private Sub subjectbtn_Click(sender As Object, e As EventArgs) Handles subjectbtn.Click
        activePanel.Height = subjectbtn.Height
        activePanel.Top = subjectbtn.Top
        homePanel.Visible = False
        coursePanel.Visible = True
    End Sub

    Private Sub assistantBtn_Click(sender As Object, e As EventArgs) Handles assistantBtn.Click
        activePanel.Height = assistantBtn.Height
        activePanel.Top = assistantBtn.Top
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        activePanel.Height = settingsBtn.Height
        activePanel.Top = settingsBtn.Top
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        activePanel.Height = logoutBtn.Height
        activePanel.Top = logoutBtn.Top
        animation.HideSync(Me)
        animation.ShowSync(login)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles bsBtn.Click

    End Sub
End Class
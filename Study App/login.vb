Public Class login
    Private Sub createLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles createLink.LinkClicked
        animation.HideSync(p2)
        animation.ShowSync(p3)
    End Sub

    Private Sub GunaPictureBox6_Click(sender As Object, e As EventArgs) Handles goBack.Click
        animation.HideSync(p3)
        animation.ShowSync(p2)
    End Sub

    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub GunaPictureBox4_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim selectLevel As New levelSelect()
        selectLevel.Show()
        Me.Hide()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim selectLevel As New levelSelect()
        selectLevel.Show()
        Me.Hide()
    End Sub
End Class
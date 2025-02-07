Public Class levelSelect
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Dim dashboard As New dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaPictureBox3.Click
        Dim dashboard As New dashboard()
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
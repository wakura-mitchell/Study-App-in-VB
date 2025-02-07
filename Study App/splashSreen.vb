Public Class splashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressBar.Width += 3

        If progressBar.Width >= 510 Then
            Timer1.Stop()
            Dim loginForm As New login
            loginForm.Show()
            Me.Hide()
        End If
    End Sub
End Class

Public Class contentToRead
    Public Property FileName() As String
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        OpenFileDialog1.Filter = "PDF |*.pdf"
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            If OpenFileDialog1.FileName <> FileName Then
                WebBrowser1.Navigate(FileName)
            End If
        End If
    End Sub
End Class
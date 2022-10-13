Public Class Form1
    Private rand As Random = New Random()
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim val As Integer = rand.Next()
        RichTextBox.Text = val.ToString()
    End Sub
End Class

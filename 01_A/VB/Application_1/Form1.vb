Public Class Form1

    Const boxHeight As Integer = 136
    Const boxWidth As Integer = 540
    Private box As Rectangle = New Rectangle(0, 0, boxWidth, boxHeight)
    Private ball1 As Ball = New Ball(20, 0, 60, 4, 4)
    Private ball2 As Ball = New Ball(0, 0, 80, 2, 2)
    Private ball3 As Ball = New Ball(0, 0, 20, 8, 8)
    Private ball4 As Ball = New Ball(0, 0, 40, 4, 4)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RichTextBox1.Text = "Some text"
    End Sub

    Private Sub Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Create bitmap for the rectangle
        Dim rectangle As Bitmap = New Bitmap(boxWidth, boxHeight)
        Dim grafx As Graphics = Graphics.FromImage(rectangle)
        ' Enable anti-aliasing to smooth picture
        grafx.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        ' Draw the rectangle
        grafx.FillRectangle(Brushes.White, box)
        grafx.DrawRectangle(Pens.Black, box)
        Me.PictureBox1.Image = rectangle
        ' Clear the image from the previous frame
        grafx.Dispose()
    End Sub

    Private Sub PaintFrame()
        ' Create bitmap for the rectangle
        Dim rectangle As Bitmap = New Bitmap(boxWidth, boxHeight)
        Dim grafx As Graphics = Graphics.FromImage(rectangle)
        ' Enable anti-aliasing to smooth picture
        grafx.SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias

        ' Draw the rectangle
        grafx.FillRectangle(Brushes.White, box)
        grafx.DrawRectangle(Pens.Black, box)

        ' Draw the balls
        grafx.FillEllipse(Brushes.Red, ball1.x, ball1.y, ball1.radius, ball1.radius)
        grafx.FillEllipse(Brushes.Blue, ball2.x, ball2.y, ball2.radius, ball2.radius)
        grafx.FillEllipse(Brushes.Green, ball3.x, ball3.y, ball3.radius, ball3.radius)
        grafx.FillEllipse(Brushes.BlueViolet, ball4.x, ball4.y, ball4.radius, ball4.radius)

        Me.PictureBox1.Image = rectangle
        ' Clear the image from the previous frame
        grafx.Dispose()
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ball1.MoveBall(box)
        ball2.MoveBall(box)
        ball3.MoveBall(box)
        ball4.MoveBall(box)
        PaintFrame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Timer1.Start()
    End Sub
End Class

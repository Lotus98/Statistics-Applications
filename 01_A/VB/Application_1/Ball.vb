Public Class Ball
    Public x As Integer
    Public y As Integer
    Public radius As Integer
    Public moveX As Integer
    Public moveY As Integer

    Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal radius As Integer, ByVal moveX As Integer, ByVal moveY As Integer)
        Me.x = x
        Me.y = y
        Me.radius = radius
        Me.moveX = moveX
        Me.moveY = moveY
    End Sub
    Public Sub MoveBall(ByVal box As Rectangle)
        x += moveX

        If x + radius >= box.Width OrElse x <= box.X Then
            moveX = -moveX
        End If

        y += moveY

        If y + radius >= box.Height OrElse y <= box.Y Then
            moveY = -moveY
        End If
    End Sub

End Class

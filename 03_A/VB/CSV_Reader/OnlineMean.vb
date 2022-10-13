Public Class OnlineMean
    Private currentAvg As Double = 0
    Private index As Integer = 0

    Public Function GetAvg() As Double
        Return currentAvg
    End Function

    Public Sub NewValue(ByVal val As Double)
        index += 1
        currentAvg += (val - currentAvg) / index
    End Sub
End Class

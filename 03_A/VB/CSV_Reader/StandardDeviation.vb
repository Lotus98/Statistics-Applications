Public Class StandardDeviation
    Private mean As CSV_Reader.OnlineMean
    Private stdDev As Double = 0

    Public Function computeStdDev(ByVal data As List(Of Double)) As Double
        Dim mean As New OnlineMean()

        For Each value In data
            mean.NewValue(value)
        Next

        Dim resMean As Double = mean.GetAvg()

        For Each value In data
            stdDev += Math.Pow(value - resMean, 2)
        Next

        stdDev = Math.Sqrt(stdDev / data.Count)
        Return stdDev
    End Function
End Class

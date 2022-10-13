Public Class DiscreteDistribution
    Private distDict As SortedDictionary(Of Object, Integer)
    Private n As Integer

    Public Sub New()
        distDict = New SortedDictionary(Of Object, Integer)()
        n = 0
    End Sub

    Public Sub AddValue(ByVal key As Object)
        If distDict.ContainsKey(key) Then
            distDict(key) += 1
        Else
            distDict.Add(key, 1)
        End If

        n += 1
    End Sub

    Public Function GetRelFreq(ByVal key As Object) As Double
        Dim relFreq = distDict(key) / n
        Return relFreq
    End Function

    Public Function GetPerc(ByVal key As Object) As Double
        Dim perc = distDict(key) / n * 100
        Return perc
    End Function

    Public ReadOnly Property Distribution As SortedDictionary(Of Object, Integer)
        Get
            Return distDict
        End Get
    End Property
End Class

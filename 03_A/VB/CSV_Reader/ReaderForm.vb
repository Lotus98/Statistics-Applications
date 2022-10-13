Imports System.IO
Imports System.Reflection

Public Class ReaderForm
    Public listOfUnits As List(Of ChildSmoker)
    Public separator As Char = ","c
    Public multivariate As Boolean = False

    Private Sub PathTextBox_DragDrop(sender As Object, e As DragEventArgs) Handles PathTextBox.DragDrop
        Dim files = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each file In files
            Me.PathTextBox.Text += file
        Next
    End Sub

    Private Sub PathTextBox_DragEnter(sender As Object, e As DragEventArgs) Handles PathTextBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub GetFileButton_Click(sender As Object, e As EventArgs) Handles GetFileButton.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.ShowDialog()
        Me.PathTextBox.Text = ofd.FileName
    End Sub

    Private Sub ReadFileButton_Click(sender As Object, e As EventArgs) Handles ReadFileButton.Click
        Me.ContentRTB.Clear()
        Dim path As String = Me.PathTextBox.Text

        ' Check if the file path has been loaded
        If Equals(path, String.Empty) Then
            Me.ContentRTB.Text = "[!] ERROR: Select a file first"
            Return
        End If

        Dim reader As StreamReader = New StreamReader(path)
        ' Skip header
        reader.ReadLine()
        ' Initialize list
        listOfUnits = New List(Of ChildSmoker)()

        While True
            Dim tmpUnit As New CSV_Reader.ChildSmoker()
            Dim line As String = reader.ReadLine()
            Dim values = line.Split(","c)

            ' Using Reflections to collect the values in a general way
            Dim unitType As Type = tmpUnit.GetType()
            Dim fieldInfos As FieldInfo() = unitType.GetFields()
            Dim i = 0

            For Each field In fieldInfos

                If Not String.IsNullOrWhiteSpace(values(i)) Then
                    Dim tmpValue = Convert.ChangeType(values(i), field.FieldType)
                    field.SetValue(tmpUnit, tmpValue)
                End If

                i += 1
            Next

            listOfUnits.Add(tmpUnit)
            If reader.EndOfStream Then Exit While
        End While

        reader.Dispose()
        Me.ContentRTB.Text = "[+] SUCCESS: File read correctly!"
    End Sub

    Private Sub CommaRButton_CheckedChanged(sender As Object, e As EventArgs) Handles CommaRButton.CheckedChanged
        separator = ","c
    End Sub

    Private Sub PipeRButton_CheckedChanged(sender As Object, e As EventArgs) Handles PipeRButton.CheckedChanged
        separator = "|"c
    End Sub

    Private Sub ColonRButton_CheckedChanged(sender As Object, e As EventArgs) Handles ColonRButton.CheckedChanged
        separator = ";"c
    End Sub

    Private Sub ReaderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DistComboBox.SelectedIndex = 0
    End Sub

    Private Sub DistComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DistComboBox.SelectedIndexChanged
        multivariate = Convert.ToBoolean(DistComboBox.SelectedIndex)
    End Sub

    Private Sub MeanButton_Click(sender As Object, e As EventArgs) Handles MeanButton.Click
        Me.ContentRTB.Clear()
        Dim ageMean As New OnlineMean()

        For Each unit As CSV_Reader.ChildSmoker In listOfUnits
            ageMean.NewValue(unit.age)
        Next

        Me.ContentRTB.Text = String.Format("Mean for the discrete variable age: {0:0.00}", ageMean.GetAvg())
    End Sub

    Private Sub StdDevButton_Click(sender As Object, e As EventArgs) Handles StdDevButton.Click
        Dim stdDev As New StandardDeviation()
        Dim data As List(Of Double) = New List(Of Double)()

        For Each unit As ChildSmoker In listOfUnits
            data.Add(unit.age)
        Next

        Me.ContentRTB.Clear()
        Me.ContentRTB.Text = String.Format("Standard deviation for the discrete variable age: {0:0.00}", stdDev.computeStdDev(data))
    End Sub

    Private Sub FreqDistButton_Click(sender As Object, e As EventArgs) Handles FreqDistButton.Click
        If multivariate Then
            Dim dist As CSV_Reader.DiscreteDistribution = New CSV_Reader.DiscreteDistribution()

            For Each unit As CSV_Reader.ChildSmoker In listOfUnits
                Dim tmpKey As Tuple(Of Integer, String) = New Tuple(Of Integer, String)(unit.age, unit.smoker)
                dist.AddValue(tmpKey)
            Next

            Me.ContentRTB.Clear()
            Me.ContentRTB.AppendText("Bivariate distribution for the variable age(X) and smoker(Y):" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf)

            ' Extract distinct values
            Dim distinctValFirstVar As Dictionary(Of Integer, Object) = New Dictionary(Of Integer, Object)()
            Dim distinctValSecondVar As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
            Dim distribution As SortedDictionary(Of Object, Integer) = dist.Distribution

            For Each kvp In distribution
                Dim key = CType(kvp.Key, Tuple(Of Integer, String))
                If Not distinctValFirstVar.ContainsKey(key.Item1) Then distinctValFirstVar.Add(key.Item1, Nothing)
                If Not distinctValSecondVar.ContainsKey(key.Item2) Then distinctValSecondVar.Add(key.Item2, Nothing)
            Next

            ' Set tabs according to number of Y's
            Dim cols = distinctValSecondVar.Count
            Me.ContentRTB.SelectionTabs = New Integer(cols + 1 - 1) {}
            Me.ContentRTB.SelectionTabs(0) = 55

            For i = 1 To cols
                Me.ContentRTB.SelectionTabs(i) = 75 * i
            Next

            ' Create table
            Me.ContentRTB.AppendText("X\Y" & Microsoft.VisualBasic.Constants.vbTab & "|")

            For Each Y In distinctValSecondVar
                Me.ContentRTB.AppendText(String.Format(Microsoft.VisualBasic.Constants.vbTab & "{0}", Y.Key))
            Next

            Me.ContentRTB.AppendText(Microsoft.VisualBasic.Constants.vbLf)
            Me.ContentRTB.AppendText(New String("-"c, 64))
            Me.ContentRTB.AppendText(Microsoft.VisualBasic.Constants.vbLf)

            For Each X In distinctValFirstVar
                Me.ContentRTB.AppendText(String.Format("{0}" & Microsoft.VisualBasic.Constants.vbTab & "|", X.Key))

                For Each Y In distinctValSecondVar
                    Dim key As Tuple(Of Integer, String) = New Tuple(Of Integer, String)(X.Key, Y.Key)
                    Dim count As Integer

                    If Not distribution.ContainsKey(key) Then
                        count = 0
                    Else
                        count = distribution(key)
                    End If

                    Me.ContentRTB.AppendText(String.Format(Microsoft.VisualBasic.Constants.vbTab & "{0}", count))
                Next

                Me.ContentRTB.AppendText(Microsoft.VisualBasic.Constants.vbLf)
            Next
        Else
            Dim dist As CSV_Reader.DiscreteDistribution = New CSV_Reader.DiscreteDistribution()

            For Each unit As CSV_Reader.ChildSmoker In listOfUnits
                dist.AddValue(unit.age)
            Next

            Me.ContentRTB.Clear()
            Me.ContentRTB.AppendText("Univariate distribution for the variable age:" & Microsoft.VisualBasic.Constants.vbLf)
            Me.ContentRTB.SelectionTabs = New Integer() {75, 150, 225}
            Me.ContentRTB.AppendText("Age" & Microsoft.VisualBasic.Constants.vbTab & "Count" & Microsoft.VisualBasic.Constants.vbTab & "Freq" & Microsoft.VisualBasic.Constants.vbTab & "Perc" & Microsoft.VisualBasic.Constants.vbLf)
            Dim distribution As SortedDictionary(Of Object, Integer) = dist.Distribution

            For Each pair In distribution
                Dim relFreq As Double = dist.GetRelFreq(pair.Key)
                Dim perc As Double = dist.GetPerc(pair.Key)
                Dim format = String.Format("{0}" & Microsoft.VisualBasic.Constants.vbTab & "{1}" & Microsoft.VisualBasic.Constants.vbTab & "{2:0.00}" & Microsoft.VisualBasic.Constants.vbTab & "{3:0.00}%" & Microsoft.VisualBasic.Constants.vbLf, CInt(pair.Key), pair.Value, relFreq, perc)
                Me.ContentRTB.AppendText(format)
            Next
        End If
    End Sub
End Class

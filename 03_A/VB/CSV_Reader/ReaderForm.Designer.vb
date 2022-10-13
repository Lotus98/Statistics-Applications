<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.GetFileButton = New System.Windows.Forms.Button()
        Me.ContentRTB = New System.Windows.Forms.RichTextBox()
        Me.ReadFileButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ColonRButton = New System.Windows.Forms.RadioButton()
        Me.PipeRButton = New System.Windows.Forms.RadioButton()
        Me.CommaRButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DistComboBox = New System.Windows.Forms.ComboBox()
        Me.MeanButton = New System.Windows.Forms.Button()
        Me.StdDevButton = New System.Windows.Forms.Button()
        Me.FreqDistButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PathTextBox
        '
        Me.PathTextBox.AllowDrop = True
        Me.PathTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PathTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PathTextBox.Location = New System.Drawing.Point(95, 27)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(232, 23)
        Me.PathTextBox.TabIndex = 0
        '
        'GetFileButton
        '
        Me.GetFileButton.BackColor = System.Drawing.SystemColors.Control
        Me.GetFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GetFileButton.Location = New System.Drawing.Point(341, 22)
        Me.GetFileButton.Name = "GetFileButton"
        Me.GetFileButton.Size = New System.Drawing.Size(34, 28)
        Me.GetFileButton.TabIndex = 1
        Me.GetFileButton.Text = "..."
        Me.GetFileButton.UseVisualStyleBackColor = False
        '
        'ContentRTB
        '
        Me.ContentRTB.Location = New System.Drawing.Point(426, 12)
        Me.ContentRTB.Name = "ContentRTB"
        Me.ContentRTB.Size = New System.Drawing.Size(549, 426)
        Me.ContentRTB.TabIndex = 2
        Me.ContentRTB.Text = ""
        Me.ContentRTB.WordWrap = False
        '
        'ReadFileButton
        '
        Me.ReadFileButton.BackColor = System.Drawing.SystemColors.Control
        Me.ReadFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReadFileButton.Location = New System.Drawing.Point(6, 22)
        Me.ReadFileButton.Name = "ReadFileButton"
        Me.ReadFileButton.Size = New System.Drawing.Size(83, 28)
        Me.ReadFileButton.TabIndex = 3
        Me.ReadFileButton.Text = "Read file"
        Me.ReadFileButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ReadFileButton)
        Me.GroupBox1.Controls.Add(Me.PathTextBox)
        Me.GroupBox1.Controls.Add(Me.GetFileButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 59)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drag/Drop or choose a CSV"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ColonRButton)
        Me.GroupBox2.Controls.Add(Me.PipeRButton)
        Me.GroupBox2.Controls.Add(Me.CommaRButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 59)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose separator"
        '
        'ColonRButton
        '
        Me.ColonRButton.AutoSize = True
        Me.ColonRButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ColonRButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ColonRButton.Location = New System.Drawing.Point(276, 25)
        Me.ColonRButton.Name = "ColonRButton"
        Me.ColonRButton.Size = New System.Drawing.Size(55, 19)
        Me.ColonRButton.TabIndex = 2
        Me.ColonRButton.TabStop = True
        Me.ColonRButton.Text = "colon"
        Me.ColonRButton.UseVisualStyleBackColor = False
        '
        'PipeRButton
        '
        Me.PipeRButton.AutoSize = True
        Me.PipeRButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PipeRButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PipeRButton.Location = New System.Drawing.Point(142, 25)
        Me.PipeRButton.Name = "PipeRButton"
        Me.PipeRButton.Size = New System.Drawing.Size(48, 19)
        Me.PipeRButton.TabIndex = 1
        Me.PipeRButton.TabStop = True
        Me.PipeRButton.Text = "pipe"
        Me.PipeRButton.UseVisualStyleBackColor = False
        '
        'CommaRButton
        '
        Me.CommaRButton.AutoSize = True
        Me.CommaRButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CommaRButton.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CommaRButton.Location = New System.Drawing.Point(6, 25)
        Me.CommaRButton.Name = "CommaRButton"
        Me.CommaRButton.Size = New System.Drawing.Size(66, 19)
        Me.CommaRButton.TabIndex = 0
        Me.CommaRButton.TabStop = True
        Me.CommaRButton.Text = "comma"
        Me.CommaRButton.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.MeanButton)
        Me.GroupBox3.Controls.Add(Me.StdDevButton)
        Me.GroupBox3.Controls.Add(Me.FreqDistButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 229)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Computation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DistComboBox)
        Me.GroupBox4.Location = New System.Drawing.Point(161, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 100)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Distribution mode"
        '
        'DistComboBox
        '
        Me.DistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DistComboBox.FormattingEnabled = True
        Me.DistComboBox.Items.AddRange(New Object() {"Univariate", "Bivariate"})
        Me.DistComboBox.Location = New System.Drawing.Point(45, 43)
        Me.DistComboBox.Name = "DistComboBox"
        Me.DistComboBox.Size = New System.Drawing.Size(121, 23)
        Me.DistComboBox.TabIndex = 8
        '
        'MeanButton
        '
        Me.MeanButton.BackColor = System.Drawing.SystemColors.Control
        Me.MeanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MeanButton.Location = New System.Drawing.Point(6, 48)
        Me.MeanButton.Name = "MeanButton"
        Me.MeanButton.Size = New System.Drawing.Size(130, 40)
        Me.MeanButton.TabIndex = 4
        Me.MeanButton.Text = "Calculate mean"
        Me.MeanButton.UseVisualStyleBackColor = False
        '
        'StdDevButton
        '
        Me.StdDevButton.BackColor = System.Drawing.SystemColors.Control
        Me.StdDevButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StdDevButton.Location = New System.Drawing.Point(6, 108)
        Me.StdDevButton.Name = "StdDevButton"
        Me.StdDevButton.Size = New System.Drawing.Size(130, 40)
        Me.StdDevButton.TabIndex = 5
        Me.StdDevButton.Text = "Calculate standard deviation"
        Me.StdDevButton.UseVisualStyleBackColor = False
        '
        'FreqDistButton
        '
        Me.FreqDistButton.BackColor = System.Drawing.SystemColors.Control
        Me.FreqDistButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FreqDistButton.Location = New System.Drawing.Point(6, 166)
        Me.FreqDistButton.Name = "FreqDistButton"
        Me.FreqDistButton.Size = New System.Drawing.Size(130, 40)
        Me.FreqDistButton.TabIndex = 6
        Me.FreqDistButton.Text = "Calculate frequency distribution"
        Me.FreqDistButton.UseVisualStyleBackColor = False
        '
        'ReaderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(987, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ContentRTB)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ReaderForm"
        Me.Text = "CSV Reader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PathTextBox As TextBox
    Friend WithEvents GetFileButton As Button
    Friend WithEvents ContentRTB As RichTextBox
    Friend WithEvents ReadFileButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CommaRButton As RadioButton
    Friend WithEvents ColonRButton As RadioButton
    Friend WithEvents PipeRButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MeanButton As Button
    Friend WithEvents StdDevButton As Button
    Friend WithEvents FreqDistButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DistComboBox As ComboBox
End Class

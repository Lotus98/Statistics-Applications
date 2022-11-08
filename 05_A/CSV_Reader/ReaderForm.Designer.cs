
namespace CSV_Reader {
    partial class ReaderForm {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.getFileButton = new System.Windows.Forms.Button();
            this.contentRTB = new System.Windows.Forms.RichTextBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colonRButton = new System.Windows.Forms.RadioButton();
            this.pipeRButton = new System.Windows.Forms.RadioButton();
            this.commaRButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.freqDistButton = new System.Windows.Forms.Button();
            this.stdDevButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.distComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.AllowDrop = true;
            this.pathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pathTextBox.Location = new System.Drawing.Point(95, 25);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(232, 20);
            this.pathTextBox.TabIndex = 0;
            // 
            // getFileButton
            // 
            this.getFileButton.BackColor = System.Drawing.SystemColors.Control;
            this.getFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getFileButton.Location = new System.Drawing.Point(333, 19);
            this.getFileButton.Name = "getFileButton";
            this.getFileButton.Size = new System.Drawing.Size(34, 28);
            this.getFileButton.TabIndex = 1;
            this.getFileButton.Text = "...";
            this.getFileButton.UseVisualStyleBackColor = false;
            this.getFileButton.Click += new System.EventHandler(this.getFileButton_Click);
            // 
            // contentRTB
            // 
            this.contentRTB.Location = new System.Drawing.Point(426, 12);
            this.contentRTB.Name = "contentRTB";
            this.contentRTB.Size = new System.Drawing.Size(549, 426);
            this.contentRTB.TabIndex = 2;
            this.contentRTB.Text = "";
            this.contentRTB.WordWrap = false;
            // 
            // readFileButton
            // 
            this.readFileButton.BackColor = System.Drawing.SystemColors.Control;
            this.readFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.readFileButton.Location = new System.Drawing.Point(6, 19);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(83, 28);
            this.readFileButton.TabIndex = 3;
            this.readFileButton.Text = "Read file";
            this.readFileButton.UseVisualStyleBackColor = false;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readFileButton);
            this.groupBox1.Controls.Add(this.pathTextBox);
            this.groupBox1.Controls.Add(this.getFileButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag/Drop or choose a CSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colonRButton);
            this.groupBox2.Controls.Add(this.pipeRButton);
            this.groupBox2.Controls.Add(this.commaRButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose separator";
            // 
            // colonRButton
            // 
            this.colonRButton.AutoSize = true;
            this.colonRButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.colonRButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.colonRButton.Location = new System.Drawing.Point(276, 25);
            this.colonRButton.Name = "colonRButton";
            this.colonRButton.Size = new System.Drawing.Size(51, 17);
            this.colonRButton.TabIndex = 2;
            this.colonRButton.TabStop = true;
            this.colonRButton.Text = "colon";
            this.colonRButton.UseVisualStyleBackColor = false;
            this.colonRButton.CheckedChanged += new System.EventHandler(this.colonRButton_CheckedChanged);
            // 
            // pipeRButton
            // 
            this.pipeRButton.AutoSize = true;
            this.pipeRButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pipeRButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pipeRButton.Location = new System.Drawing.Point(142, 25);
            this.pipeRButton.Name = "pipeRButton";
            this.pipeRButton.Size = new System.Drawing.Size(45, 17);
            this.pipeRButton.TabIndex = 1;
            this.pipeRButton.TabStop = true;
            this.pipeRButton.Text = "pipe";
            this.pipeRButton.UseVisualStyleBackColor = false;
            this.pipeRButton.CheckedChanged += new System.EventHandler(this.pipeRButton_CheckedChanged);
            // 
            // commaRButton
            // 
            this.commaRButton.AutoSize = true;
            this.commaRButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.commaRButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.commaRButton.Location = new System.Drawing.Point(6, 25);
            this.commaRButton.Name = "commaRButton";
            this.commaRButton.Size = new System.Drawing.Size(59, 17);
            this.commaRButton.TabIndex = 0;
            this.commaRButton.TabStop = true;
            this.commaRButton.Text = "comma";
            this.commaRButton.UseVisualStyleBackColor = false;
            this.commaRButton.CheckedChanged += new System.EventHandler(this.commaRButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.freqDistButton);
            this.groupBox3.Controls.Add(this.stdDevButton);
            this.groupBox3.Controls.Add(this.meanButton);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 229);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computation";
            // 
            // freqDistButton
            // 
            this.freqDistButton.BackColor = System.Drawing.SystemColors.Control;
            this.freqDistButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.freqDistButton.Location = new System.Drawing.Point(6, 166);
            this.freqDistButton.Name = "freqDistButton";
            this.freqDistButton.Size = new System.Drawing.Size(130, 40);
            this.freqDistButton.TabIndex = 6;
            this.freqDistButton.Text = "Calculate frequency distribution";
            this.freqDistButton.UseVisualStyleBackColor = false;
            this.freqDistButton.Click += new System.EventHandler(this.freqDistButton_Click);
            // 
            // stdDevButton
            // 
            this.stdDevButton.BackColor = System.Drawing.SystemColors.Control;
            this.stdDevButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stdDevButton.Location = new System.Drawing.Point(6, 108);
            this.stdDevButton.Name = "stdDevButton";
            this.stdDevButton.Size = new System.Drawing.Size(130, 40);
            this.stdDevButton.TabIndex = 5;
            this.stdDevButton.Text = "Calculate standard deviation";
            this.stdDevButton.UseVisualStyleBackColor = false;
            this.stdDevButton.Click += new System.EventHandler(this.stdDevButton_Click);
            // 
            // meanButton
            // 
            this.meanButton.BackColor = System.Drawing.SystemColors.Control;
            this.meanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.meanButton.Location = new System.Drawing.Point(6, 48);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(130, 40);
            this.meanButton.TabIndex = 4;
            this.meanButton.Text = "Calculate mean";
            this.meanButton.UseVisualStyleBackColor = false;
            this.meanButton.Click += new System.EventHandler(this.meanButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.distComboBox);
            this.groupBox4.Location = new System.Drawing.Point(161, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distribution mode";
            // 
            // distComboBox
            // 
            this.distComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distComboBox.FormattingEnabled = true;
            this.distComboBox.Items.AddRange(new object[] {
            "Univariate",
            "Bivariate"});
            this.distComboBox.Location = new System.Drawing.Point(45, 43);
            this.distComboBox.Name = "distComboBox";
            this.distComboBox.Size = new System.Drawing.Size(121, 21);
            this.distComboBox.TabIndex = 8;
            this.distComboBox.SelectedIndexChanged += new System.EventHandler(this.distComboBox_SelectedIndexChanged);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contentRTB);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ReaderForm";
            this.Text = "CSV Reader";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button getFileButton;
        private System.Windows.Forms.RichTextBox contentRTB;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton colonRButton;
        private System.Windows.Forms.RadioButton pipeRButton;
        private System.Windows.Forms.RadioButton commaRButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button freqDistButton;
        private System.Windows.Forms.Button stdDevButton;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox distComboBox;
    }
}


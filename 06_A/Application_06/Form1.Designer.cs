
namespace Application_06 {
    partial class Form1 {
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
            pictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            nUD = new NumericUpDown();
            groupBox2 = new GroupBox();
            label2 = new Label();
            mUD = new NumericUpDown();
            groupBox3 = new GroupBox();
            label3 = new Label();
            epsUD = new NumericUpDown();
            groupBox4 = new GroupBox();
            label4 = new Label();
            pUD = new NumericUpDown();
            groupBox5 = new GroupBox();
            label5 = new Label();
            jUD = new NumericUpDown();
            groupBox6 = new GroupBox();
            whichFreq = new ComboBox();
            computeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mUD).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epsUD).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pUD).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jUD).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ActiveCaptionText;
            pictureBox.Location = new Point(14, 111);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1388, 519);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nUD);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(175, 70);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert number of rounds (n)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "n:";
            // 
            // nUD
            // 
            nUD.Location = new Point(33, 22);
            nUD.Margin = new Padding(4, 3, 4, 3);
            nUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUD.Name = "nUD";
            nUD.Size = new Size(107, 23);
            nUD.TabIndex = 0;
            nUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mUD);
            groupBox2.Location = new Point(226, 14);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(174, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert number of paths (m)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "m:";
            // 
            // mUD
            // 
            mUD.Location = new Point(33, 22);
            mUD.Margin = new Padding(4, 3, 4, 3);
            mUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mUD.Name = "mUD";
            mUD.Size = new Size(107, 23);
            mUD.TabIndex = 0;
            mUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(epsUD);
            groupBox3.Location = new Point(431, 14);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(174, 70);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Insert epsilon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "epsilon:";
            // 
            // epsUD
            // 
            epsUD.DecimalPlaces = 2;
            epsUD.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            epsUD.Location = new Point(59, 22);
            epsUD.Margin = new Padding(4, 3, 4, 3);
            epsUD.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            epsUD.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            epsUD.Name = "epsUD";
            epsUD.Size = new Size(107, 23);
            epsUD.TabIndex = 0;
            epsUD.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(pUD);
            groupBox4.Location = new Point(647, 14);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(192, 70);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Insert probability of hit (0<p<1)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 24);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 1;
            label4.Text = "p:";
            // 
            // pUD
            // 
            pUD.DecimalPlaces = 2;
            pUD.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            pUD.Location = new Point(33, 22);
            pUD.Margin = new Padding(4, 3, 4, 3);
            pUD.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            pUD.Name = "pUD";
            pUD.Size = new Size(107, 23);
            pUD.TabIndex = 0;
            pUD.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(jUD);
            groupBox5.Location = new Point(14, 434);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(214, 70);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Insert intermediate step (0 < j < n)";
            groupBox5.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 27);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 1;
            label5.Text = "j:";
            // 
            // jUD
            // 
            jUD.Location = new Point(28, 22);
            jUD.Margin = new Padding(4, 3, 4, 3);
            jUD.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            jUD.Name = "jUD";
            jUD.Size = new Size(107, 23);
            jUD.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(whichFreq);
            groupBox6.Location = new Point(876, 14);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(214, 70);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Choose frequency";
            // 
            // whichFreq
            // 
            whichFreq.FormattingEnabled = true;
            whichFreq.Items.AddRange(new object[] { "Relative", "Absolute", "Normalized" });
            whichFreq.Location = new Point(18, 27);
            whichFreq.Name = "whichFreq";
            whichFreq.Size = new Size(121, 23);
            whichFreq.TabIndex = 0;
            whichFreq.Text = "-- Select --";
            whichFreq.SelectedIndexChanged += whichFreq_SelectedIndexChanged;
            // 
            // computeButton
            // 
            computeButton.Location = new Point(1158, 23);
            computeButton.Margin = new Padding(4, 3, 4, 3);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(160, 44);
            computeButton.TabIndex = 5;
            computeButton.Text = "Compute";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1416, 644);
            Controls.Add(groupBox6);
            Controls.Add(computeButton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Bernoulli Distribution convergence";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mUD).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epsUD).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pUD).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jUD).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown nUD;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown mUD;
        private GroupBox groupBox3;
        private Label label3;
        private NumericUpDown epsUD;
        private GroupBox groupBox4;
        private Label label4;
        private NumericUpDown pUD;
        private GroupBox groupBox5;
        private Label label5;
        private NumericUpDown jUD;
        private Button computeButton;
        private GroupBox groupBox6;
        private ComboBox whichFreq;
    }
}


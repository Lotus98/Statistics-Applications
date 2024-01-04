namespace Application12 {
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
            if (disposing && (components != null))
            {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.simulationPictureBox = new System.Windows.Forms.PictureBox();
            this.vertHisto = new System.Windows.Forms.PictureBox();
            this.horizHisto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertHisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of trials:";
            // 
            // simulationPictureBox
            // 
            this.simulationPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.simulationPictureBox.Location = new System.Drawing.Point(12, 69);
            this.simulationPictureBox.Name = "simulationPictureBox";
            this.simulationPictureBox.Size = new System.Drawing.Size(540, 540);
            this.simulationPictureBox.TabIndex = 1;
            this.simulationPictureBox.TabStop = false;
            // 
            // vertHisto
            // 
            this.vertHisto.Location = new System.Drawing.Point(572, 69);
            this.vertHisto.Name = "vertHisto";
            this.vertHisto.Size = new System.Drawing.Size(593, 265);
            this.vertHisto.TabIndex = 2;
            this.vertHisto.TabStop = false;
            // 
            // horizHisto
            // 
            this.horizHisto.Location = new System.Drawing.Point(572, 344);
            this.horizHisto.Name = "horizHisto";
            this.horizHisto.Size = new System.Drawing.Size(593, 265);
            this.horizHisto.TabIndex = 3;
            this.horizHisto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Application12Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horizHisto);
            this.Controls.Add(this.vertHisto);
            this.Controls.Add(this.simulationPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Application12Form1";
            this.Text = "Application 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertHisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizHisto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox simulationPictureBox;
        private System.Windows.Forms.PictureBox vertHisto;
        private System.Windows.Forms.PictureBox horizHisto;
        private System.Windows.Forms.Button button1;
    }
}


namespace Application10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            sample_size_in=new NumericUpDown();
            n_samples_in=new NumericUpDown();
            paramsGroupBox=new GroupBox();
            label2=new Label();
            label1=new Label();
            pictureBox1=new PictureBox();
            sample_button=new Button();
            outputGroupBox=new GroupBox();
            label6=new Label();
            label5=new Label();
            means_var_text=new TextBox();
            means_means_text=new TextBox();
            pop_var_text=new TextBox();
            pop_mean_text=new TextBox();
            label4=new Label();
            label3=new Label();
            mean_char_button=new Button();
            var_char_button=new Button();
            ((System.ComponentModel.ISupportInitialize)sample_size_in).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_samples_in).BeginInit();
            paramsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            outputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // sample_size_in
            // 
            sample_size_in.Location=new Point(156, 22);
            sample_size_in.Maximum=new decimal(new int[] { 1000, 0, 0, 0 });
            sample_size_in.Minimum=new decimal(new int[] { 100, 0, 0, 0 });
            sample_size_in.Name="sample_size_in";
            sample_size_in.Size=new Size(90, 23);
            sample_size_in.TabIndex=0;
            sample_size_in.Value=new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // n_samples_in
            // 
            n_samples_in.Location=new Point(156, 60);
            n_samples_in.Minimum=new decimal(new int[] { 10, 0, 0, 0 });
            n_samples_in.Name="n_samples_in";
            n_samples_in.Size=new Size(90, 23);
            n_samples_in.TabIndex=1;
            n_samples_in.Value=new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // paramsGroupBox
            // 
            paramsGroupBox.Controls.Add(label2);
            paramsGroupBox.Controls.Add(label1);
            paramsGroupBox.Controls.Add(n_samples_in);
            paramsGroupBox.Controls.Add(sample_size_in);
            paramsGroupBox.Location=new Point(12, 12);
            paramsGroupBox.Name="paramsGroupBox";
            paramsGroupBox.Size=new Size(252, 100);
            paramsGroupBox.TabIndex=2;
            paramsGroupBox.TabStop=false;
            paramsGroupBox.Text="Application Parameters";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(6, 62);
            label2.Name="label2";
            label2.Size=new Size(96, 15);
            label2.TabIndex=3;
            label2.Text="Samples size (N):";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(6, 24);
            label1.Name="label1";
            label1.Size=new Size(136, 15);
            label1.TabIndex=2;
            label1.Text="Number of samples (M):";
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(6, 118);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(1036, 469);
            pictureBox1.TabIndex=3;
            pictureBox1.TabStop=false;
            // 
            // sample_button
            // 
            sample_button.Location=new Point(286, 47);
            sample_button.Name="sample_button";
            sample_button.Size=new Size(75, 42);
            sample_button.TabIndex=4;
            sample_button.Text="Generate Samples";
            sample_button.UseVisualStyleBackColor=true;
            sample_button.Click+=sample_button_Click;
            // 
            // outputGroupBox
            // 
            outputGroupBox.Controls.Add(label6);
            outputGroupBox.Controls.Add(label5);
            outputGroupBox.Controls.Add(means_var_text);
            outputGroupBox.Controls.Add(means_means_text);
            outputGroupBox.Controls.Add(pop_var_text);
            outputGroupBox.Controls.Add(pop_mean_text);
            outputGroupBox.Controls.Add(label4);
            outputGroupBox.Controls.Add(label3);
            outputGroupBox.Location=new Point(385, 12);
            outputGroupBox.Name="outputGroupBox";
            outputGroupBox.Size=new Size(476, 100);
            outputGroupBox.TabIndex=5;
            outputGroupBox.TabStop=false;
            outputGroupBox.Text="Application output";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(254, 62);
            label6.Name="label6";
            label6.Size=new Size(106, 15);
            label6.TabIndex=7;
            label6.Text="Mean of Variances:";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(254, 24);
            label5.Name="label5";
            label5.Size=new Size(92, 15);
            label5.TabIndex=6;
            label5.Text="Mean of Means:";
            // 
            // means_var_text
            // 
            means_var_text.Location=new Point(366, 59);
            means_var_text.Name="means_var_text";
            means_var_text.Size=new Size(100, 23);
            means_var_text.TabIndex=5;
            // 
            // means_means_text
            // 
            means_means_text.Location=new Point(366, 21);
            means_means_text.Name="means_means_text";
            means_means_text.Size=new Size(100, 23);
            means_means_text.TabIndex=4;
            // 
            // pop_var_text
            // 
            pop_var_text.Location=new Point(127, 60);
            pop_var_text.Name="pop_var_text";
            pop_var_text.Size=new Size(100, 23);
            pop_var_text.TabIndex=3;
            // 
            // pop_mean_text
            // 
            pop_mean_text.Location=new Point(127, 21);
            pop_mean_text.Name="pop_mean_text";
            pop_mean_text.Size=new Size(100, 23);
            pop_mean_text.TabIndex=2;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(6, 62);
            label4.Name="label4";
            label4.Size=new Size(115, 15);
            label4.TabIndex=1;
            label4.Text="Population Variance:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(6, 24);
            label3.Name="label3";
            label3.Size=new Size(101, 15);
            label3.TabIndex=0;
            label3.Text="Population Mean:";
            // 
            // mean_char_button
            // 
            mean_char_button.Location=new Point(906, 20);
            mean_char_button.Name="mean_char_button";
            mean_char_button.Size=new Size(103, 43);
            mean_char_button.TabIndex=9;
            mean_char_button.Text="Show Means Distribution";
            mean_char_button.UseVisualStyleBackColor=true;
            mean_char_button.Click+=mean_char_button_Click;
            // 
            // var_char_button
            // 
            var_char_button.Location=new Point(906, 69);
            var_char_button.Name="var_char_button";
            var_char_button.Size=new Size(103, 43);
            var_char_button.TabIndex=10;
            var_char_button.Text="Show Variances Distribution";
            var_char_button.UseVisualStyleBackColor=true;
            var_char_button.Click+=var_char_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1054, 599);
            Controls.Add(var_char_button);
            Controls.Add(mean_char_button);
            Controls.Add(outputGroupBox);
            Controls.Add(sample_button);
            Controls.Add(pictureBox1);
            Controls.Add(paramsGroupBox);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sample_size_in).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_samples_in).EndInit();
            paramsGroupBox.ResumeLayout(false);
            paramsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            outputGroupBox.ResumeLayout(false);
            outputGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown sample_size_in;
        private NumericUpDown n_samples_in;
        private GroupBox paramsGroupBox;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button sample_button;
        private GroupBox outputGroupBox;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox means_var_text;
        private TextBox means_means_text;
        private TextBox pop_var_text;
        private TextBox pop_mean_text;
        private Button mean_char_button;
        private Button var_char_button;
    }
}
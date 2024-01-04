namespace Application13 {
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
            pictureBox = new PictureBox();
            xButton = new Button();
            x2Button = new Button();
            xyButton = new Button();
            xy2Button = new Button();
            x2y2Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 41);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1084, 617);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // xButton
            // 
            xButton.Location = new Point(12, 12);
            xButton.Name = "xButton";
            xButton.Size = new Size(75, 23);
            xButton.TabIndex = 1;
            xButton.Text = "X";
            xButton.UseVisualStyleBackColor = true;
            xButton.Click += xButton_Click;
            // 
            // x2Button
            // 
            x2Button.Location = new Point(93, 12);
            x2Button.Name = "x2Button";
            x2Button.Size = new Size(75, 23);
            x2Button.TabIndex = 2;
            x2Button.Text = "X²";
            x2Button.UseVisualStyleBackColor = true;
            x2Button.Click += x2Button_Click;
            // 
            // xyButton
            // 
            xyButton.Location = new Point(174, 12);
            xyButton.Name = "xyButton";
            xyButton.Size = new Size(75, 23);
            xyButton.TabIndex = 3;
            xyButton.Text = "X/Y";
            xyButton.UseVisualStyleBackColor = true;
            xyButton.Click += xyButton_Click;
            // 
            // xy2Button
            // 
            xy2Button.Location = new Point(255, 12);
            xy2Button.Name = "xy2Button";
            xy2Button.Size = new Size(75, 23);
            xy2Button.TabIndex = 4;
            xy2Button.Text = "X/Y²";
            xy2Button.UseVisualStyleBackColor = true;
            xy2Button.Click += xy2Button_Click;
            // 
            // x2y2Button
            // 
            x2y2Button.Location = new Point(336, 12);
            x2y2Button.Name = "x2y2Button";
            x2y2Button.Size = new Size(75, 23);
            x2y2Button.TabIndex = 5;
            x2y2Button.Text = "X²/Y²";
            x2y2Button.UseVisualStyleBackColor = true;
            x2y2Button.Click += x2y2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 670);
            Controls.Add(x2y2Button);
            Controls.Add(xy2Button);
            Controls.Add(xyButton);
            Controls.Add(x2Button);
            Controls.Add(xButton);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Application 13";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button xButton;
        private Button x2Button;
        private Button xyButton;
        private Button xy2Button;
        private Button x2y2Button;
    }
}

namespace DiffusionModelWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            fieldPictureBox = new PictureBox();
            topLabel_1 = new Label();
            topLabel_2 = new Label();
            leftLabel_1 = new Label();
            leftLabel_2 = new Label();
            downLabel_1 = new Label();
            downLabel_2 = new Label();
            rightLabel_1 = new Label();
            rightLabel_2 = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).BeginInit();
            SuspendLayout();
            // 
            // fieldPictureBox
            // 
            fieldPictureBox.Location = new Point(12, 12);
            fieldPictureBox.Name = "fieldPictureBox";
            fieldPictureBox.Size = new Size(787, 426);
            fieldPictureBox.TabIndex = 0;
            fieldPictureBox.TabStop = false;
            // 
            // topLabel_1
            // 
            topLabel_1.AutoSize = true;
            topLabel_1.Location = new Point(358, 17);
            topLabel_1.Name = "topLabel_1";
            topLabel_1.Size = new Size(22, 25);
            topLabel_1.TabIndex = 1;
            topLabel_1.Text = "0";
            // 
            // topLabel_2
            // 
            topLabel_2.AutoSize = true;
            topLabel_2.Location = new Point(427, 18);
            topLabel_2.Name = "topLabel_2";
            topLabel_2.Size = new Size(22, 25);
            topLabel_2.TabIndex = 2;
            topLabel_2.Text = "0";
            // 
            // leftLabel_1
            // 
            leftLabel_1.AutoSize = true;
            leftLabel_1.Location = new Point(20, 173);
            leftLabel_1.Name = "leftLabel_1";
            leftLabel_1.Size = new Size(22, 25);
            leftLabel_1.TabIndex = 3;
            leftLabel_1.Text = "0";
            // 
            // leftLabel_2
            // 
            leftLabel_2.AutoSize = true;
            leftLabel_2.Location = new Point(20, 217);
            leftLabel_2.Name = "leftLabel_2";
            leftLabel_2.Size = new Size(22, 25);
            leftLabel_2.TabIndex = 4;
            leftLabel_2.Text = "0";
            // 
            // downLabel_1
            // 
            downLabel_1.AutoSize = true;
            downLabel_1.Location = new Point(358, 400);
            downLabel_1.Name = "downLabel_1";
            downLabel_1.Size = new Size(22, 25);
            downLabel_1.TabIndex = 5;
            downLabel_1.Text = "0";
            // 
            // downLabel_2
            // 
            downLabel_2.AutoSize = true;
            downLabel_2.Location = new Point(427, 400);
            downLabel_2.Name = "downLabel_2";
            downLabel_2.Size = new Size(22, 25);
            downLabel_2.TabIndex = 6;
            downLabel_2.Text = "0";
            // 
            // rightLabel_1
            // 
            rightLabel_1.AutoSize = true;
            rightLabel_1.Location = new Point(741, 192);
            rightLabel_1.Name = "rightLabel_1";
            rightLabel_1.Size = new Size(22, 25);
            rightLabel_1.TabIndex = 7;
            rightLabel_1.Text = "0";
            // 
            // rightLabel_2
            // 
            rightLabel_2.AutoSize = true;
            rightLabel_2.Location = new Point(741, 231);
            rightLabel_2.Name = "rightLabel_2";
            rightLabel_2.Size = new Size(22, 25);
            rightLabel_2.TabIndex = 8;
            rightLabel_2.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightLabel_2);
            Controls.Add(rightLabel_1);
            Controls.Add(downLabel_2);
            Controls.Add(downLabel_1);
            Controls.Add(leftLabel_2);
            Controls.Add(leftLabel_1);
            Controls.Add(topLabel_2);
            Controls.Add(topLabel_1);
            Controls.Add(fieldPictureBox);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fieldPictureBox;
        private Label topLabel_1;
        private Label topLabel_2;
        private Label leftLabel_1;
        private Label leftLabel_2;
        private Label downLabel_1;
        private Label downLabel_2;
        private Label rightLabel_1;
        private Label rightLabel_2;
    }
}
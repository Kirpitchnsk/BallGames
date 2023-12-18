namespace BulliardBallsWinFormsApp
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
            leftLabel = new Label();
            topLabel = new Label();
            rightLabel = new Label();
            downLabel = new Label();
            fieldPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).BeginInit();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Location = new Point(12, 206);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(22, 25);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Location = new Point(351, 3);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(22, 25);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Location = new Point(731, 226);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(22, 25);
            rightLabel.TabIndex = 2;
            rightLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Location = new Point(381, 393);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(22, 25);
            downLabel.TabIndex = 3;
            downLabel.Text = "0";
            // 
            // fieldPictureBox
            // 
            fieldPictureBox.Location = new Point(-2, 3);
            fieldPictureBox.Name = "fieldPictureBox";
            fieldPictureBox.Size = new Size(805, 451);
            fieldPictureBox.TabIndex = 4;
            fieldPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downLabel);
            Controls.Add(rightLabel);
            Controls.Add(topLabel);
            Controls.Add(leftLabel);
            Controls.Add(fieldPictureBox);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label topLabel;
        private Label rightLabel;
        private Label downLabel;
        private PictureBox fieldPictureBox;
    }
}
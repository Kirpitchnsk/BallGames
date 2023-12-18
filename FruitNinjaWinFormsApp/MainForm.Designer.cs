namespace FruitNinjaWinFormsApp
{
    partial class Form1
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
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).BeginInit();
            SuspendLayout();
            // 
            // fieldPictureBox
            // 
            fieldPictureBox.Enabled = false;
            fieldPictureBox.Location = new Point(0, 0);
            fieldPictureBox.Name = "fieldPictureBox";
            fieldPictureBox.Size = new Size(802, 448);
            fieldPictureBox.TabIndex = 0;
            fieldPictureBox.TabStop = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(820, 41);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(22, 25);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 450);
            Controls.Add(scoreLabel);
            Controls.Add(fieldPictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fieldPictureBox;
        private Label scoreLabel;
    }
}
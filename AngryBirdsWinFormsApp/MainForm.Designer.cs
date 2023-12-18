namespace AngryBirdsWinFormsApp
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
            gameField = new PictureBox();
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gameField).BeginInit();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            scoreLabel.Location = new Point(0, 2);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(34, 38);
            scoreLabel.TabIndex = 1;
            // 
            // gameField
            // 
            gameField.Location = new Point(0, 2);
            gameField.Name = "gameField";
            gameField.Size = new Size(799, 429);
            gameField.TabStop = false;
            gameField.MouseDown += gameField_MouseDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(gameField);
            Name = "MainForm";
            Text = "Form1";
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)gameField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gameField;
        private Label scoreLabel;
    }
}
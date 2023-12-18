namespace BallsPart2WindowsForms
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
            createButton = new Button();
            clearButton = new Button();
            gameField = new PictureBox();
            countBallsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gameField).BeginInit();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(750, 214);
            createButton.Name = "createButton";
            createButton.Size = new Size(112, 34);
            createButton.TabIndex = 0;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(750, 214);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // gameField
            // 
            gameField.Location = new Point(27, 12);
            gameField.Name = "gameField";
            gameField.Size = new Size(701, 417);
            gameField.TabIndex = 2;
            gameField.TabStop = false;
            gameField.MouseDown += gameField_MouseDown;
            // 
            // countBallsLabel
            // 
            countBallsLabel.AutoSize = true;
            countBallsLabel.Location = new Point(750, 21);
            countBallsLabel.Name = "countBallsLabel";
            countBallsLabel.Size = new Size(0, 25);
            countBallsLabel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 450);
            Controls.Add(countBallsLabel);
            Controls.Add(gameField);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)gameField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createButton;
        private Button clearButton;
        private PictureBox gameField;
        private Label countBallsLabel;
    }
}
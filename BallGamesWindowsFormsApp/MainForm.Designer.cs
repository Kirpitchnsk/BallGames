namespace BallGamesWindowsFormsApp
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
            stopButton = new Button();
            fieldPictureBox = new PictureBox();
            createButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).BeginInit();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new Point(731, 236);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(135, 34);
            stopButton.TabIndex = 0;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // fieldPictureBox
            // 
            fieldPictureBox.Location = new Point(12, 12);
            fieldPictureBox.Name = "fieldPictureBox";
            fieldPictureBox.Size = new Size(700, 500);
            fieldPictureBox.TabIndex = 1;
            fieldPictureBox.TabStop = false;
            // 
            // createButton
            // 
            createButton.Location = new Point(731, 236);
            createButton.Name = "createButton";
            createButton.Size = new Size(131, 34);
            createButton.TabIndex = 2;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(717, 236);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(145, 46);
            clearButton.TabIndex = 3;
            clearButton.Text = "Очистить поле";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Controls.Add(fieldPictureBox);
            Controls.Add(stopButton);
            Name = "MainForm";
            Text = "Balls";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button stopButton;
        private PictureBox fieldPictureBox;
        private Button createButton;
        private Button clearButton;
    }
}
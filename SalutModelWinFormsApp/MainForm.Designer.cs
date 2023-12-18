namespace SalutModelWinFormsApp
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
            components = new System.ComponentModel.Container();
            fieldPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).BeginInit();
            SuspendLayout();
            // 
            // fieldPictureBox
            // 
            fieldPictureBox.Location = new Point(12, 12);
            fieldPictureBox.Name = "fieldPictureBox";
            fieldPictureBox.Size = new Size(785, 377);
            fieldPictureBox.TabIndex = 0;
            fieldPictureBox.TabStop = false;
            fieldPictureBox.MouseDown += fieldPictureBox_MouseDown;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fieldPictureBox);
            Name = "MainForm";
            Text = "Form1";
            MouseDown += MainForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)fieldPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fieldPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}
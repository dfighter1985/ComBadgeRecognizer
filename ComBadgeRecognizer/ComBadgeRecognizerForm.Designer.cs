namespace ComBadgeRecognizer
{
    partial class ComBadgeRecognizerForm
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
            browseButton = new Button();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            fileNameTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(12, 12);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(907, 412);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(515, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(404, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 4;
            // 
            // fileNameTB
            // 
            fileNameTB.Location = new Point(93, 12);
            fileNameTB.Name = "fileNameTB";
            fileNameTB.ReadOnly = true;
            fileNameTB.Size = new Size(416, 23);
            fileNameTB.TabIndex = 3;
            fileNameTB.Text = "Select an image with the Browse button";
            // 
            // ComBadgeRecognizerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 477);
            Controls.Add(progressBar1);
            Controls.Add(fileNameTB);
            Controls.Add(pictureBox1);
            Controls.Add(browseButton);
            Name = "ComBadgeRecognizerForm";
            Text = "ComBadge recognizer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TextBox fileNameTB;
    }
}

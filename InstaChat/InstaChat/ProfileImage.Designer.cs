namespace InstaChat
{
    partial class ProfileImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            profileImagePb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)profileImagePb).BeginInit();
            SuspendLayout();
            // 
            // profileImagePb
            // 
            profileImagePb.Location = new Point(-1, -1);
            profileImagePb.Name = "profileImagePb";
            profileImagePb.Size = new Size(339, 305);
            profileImagePb.TabIndex = 0;
            profileImagePb.TabStop = false;
            // 
            // ProfileImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(338, 304);
            Controls.Add(profileImagePb);
            Name = "ProfileImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileImage";
            Load += ProfileImage_Load;
            ((System.ComponentModel.ISupportInitialize)profileImagePb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox profileImagePb;
    }
}
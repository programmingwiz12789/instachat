namespace InstaChat
{
    partial class CreateNewPassword
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
            submitBtn = new Button();
            confirmPasswordLbl = new Label();
            newPasswordLbl = new Label();
            confirmPasswordTb = new TextBox();
            newPasswordTb = new TextBox();
            loginLbl = new Label();
            titleLbl = new Label();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(0, 192, 0);
            submitBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(175, 308);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(471, 51);
            submitBtn.TabIndex = 15;
            submitBtn.Text = "SUBMIT";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // confirmPasswordLbl
            // 
            confirmPasswordLbl.AutoSize = true;
            confirmPasswordLbl.FlatStyle = FlatStyle.Flat;
            confirmPasswordLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordLbl.Location = new Point(175, 258);
            confirmPasswordLbl.Name = "confirmPasswordLbl";
            confirmPasswordLbl.Size = new Size(173, 29);
            confirmPasswordLbl.TabIndex = 14;
            confirmPasswordLbl.Text = "Confirm password";
            // 
            // newPasswordLbl
            // 
            newPasswordLbl.AutoSize = true;
            newPasswordLbl.FlatStyle = FlatStyle.Flat;
            newPasswordLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordLbl.Location = new Point(204, 219);
            newPasswordLbl.Name = "newPasswordLbl";
            newPasswordLbl.Size = new Size(144, 29);
            newPasswordLbl.TabIndex = 13;
            newPasswordLbl.Text = "New password";
            // 
            // confirmPasswordTb
            // 
            confirmPasswordTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTb.Location = new Point(354, 260);
            confirmPasswordTb.Name = "confirmPasswordTb";
            confirmPasswordTb.PasswordChar = '*';
            confirmPasswordTb.Size = new Size(292, 28);
            confirmPasswordTb.TabIndex = 12;
            // 
            // newPasswordTb
            // 
            newPasswordTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTb.Location = new Point(354, 219);
            newPasswordTb.Name = "newPasswordTb";
            newPasswordTb.PasswordChar = '*';
            newPasswordTb.Size = new Size(292, 28);
            newPasswordTb.TabIndex = 11;
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.FlatStyle = FlatStyle.Flat;
            loginLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            loginLbl.ForeColor = Color.Black;
            loginLbl.Location = new Point(233, 135);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(357, 46);
            loginLbl.TabIndex = 10;
            loginLbl.Text = "Create new password";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(208, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 9;
            titleLbl.Text = "InstaChat";
            // 
            // CreateNewPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 385);
            Controls.Add(submitBtn);
            Controls.Add(confirmPasswordLbl);
            Controls.Add(newPasswordLbl);
            Controls.Add(confirmPasswordTb);
            Controls.Add(newPasswordTb);
            Controls.Add(loginLbl);
            Controls.Add(titleLbl);
            Name = "CreateNewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewPassword";
            Load += CreateNewPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button submitBtn;
        private Label confirmPasswordLbl;
        private Label newPasswordLbl;
        private TextBox confirmPasswordTb;
        private TextBox newPasswordTb;
        private Label loginLbl;
        private Label titleLbl;
    }
}
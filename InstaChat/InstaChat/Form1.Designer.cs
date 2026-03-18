namespace InstaChat
{
    partial class Login
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
            titleLbl = new Label();
            loginLbl = new Label();
            emailTb = new TextBox();
            passwordTb = new TextBox();
            emailLbl = new Label();
            passwordLbl = new Label();
            loginBtn = new Button();
            noAccountLbl = new Label();
            hereLbl = new Label();
            here2Lbl = new Label();
            forgotPasswordLbl = new Label();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(202, 8);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "InstaChat";
            // 
            // loginLbl
            // 
            loginLbl.AutoSize = true;
            loginLbl.FlatStyle = FlatStyle.Flat;
            loginLbl.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            loginLbl.ForeColor = Color.Black;
            loginLbl.Location = new Point(307, 118);
            loginLbl.Name = "loginLbl";
            loginLbl.Size = new Size(195, 83);
            loginLbl.TabIndex = 1;
            loginLbl.Text = "Login";
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.Location = new Point(316, 218);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(292, 28);
            emailTb.TabIndex = 2;
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(316, 259);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(292, 28);
            passwordTb.TabIndex = 3;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.FlatStyle = FlatStyle.Flat;
            emailLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLbl.Location = new Point(249, 217);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(61, 29);
            emailLbl.TabIndex = 4;
            emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.FlatStyle = FlatStyle.Flat;
            passwordLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.Location = new Point(209, 261);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(101, 29);
            passwordLbl.TabIndex = 5;
            passwordLbl.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(0, 192, 0);
            loginBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(168, 307);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(440, 51);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // noAccountLbl
            // 
            noAccountLbl.AutoSize = true;
            noAccountLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            noAccountLbl.Location = new Point(269, 361);
            noAccountLbl.Name = "noAccountLbl";
            noAccountLbl.Size = new Size(216, 22);
            noAccountLbl.TabIndex = 7;
            noAccountLbl.Text = "Don't have an account? Register";
            // 
            // hereLbl
            // 
            hereLbl.AutoSize = true;
            hereLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Underline, GraphicsUnit.Point);
            hereLbl.ForeColor = Color.Blue;
            hereLbl.Location = new Point(482, 361);
            hereLbl.Name = "hereLbl";
            hereLbl.Size = new Size(39, 22);
            hereLbl.TabIndex = 8;
            hereLbl.Text = "here";
            hereLbl.Click += hereLbl_Click;
            // 
            // here2Lbl
            // 
            here2Lbl.AutoSize = true;
            here2Lbl.Font = new Font("Arial Narrow", 9F, FontStyle.Underline, GraphicsUnit.Point);
            here2Lbl.ForeColor = Color.Blue;
            here2Lbl.Location = new Point(458, 383);
            here2Lbl.Name = "here2Lbl";
            here2Lbl.Size = new Size(39, 22);
            here2Lbl.TabIndex = 10;
            here2Lbl.Text = "here";
            here2Lbl.Click += here2Lbl_Click;
            // 
            // forgotPasswordLbl
            // 
            forgotPasswordLbl.AutoSize = true;
            forgotPasswordLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPasswordLbl.Location = new Point(293, 383);
            forgotPasswordLbl.Name = "forgotPasswordLbl";
            forgotPasswordLbl.Size = new Size(166, 22);
            forgotPasswordLbl.TabIndex = 9;
            forgotPasswordLbl.Text = "Forgot password? Reset";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 434);
            Controls.Add(here2Lbl);
            Controls.Add(forgotPasswordLbl);
            Controls.Add(hereLbl);
            Controls.Add(noAccountLbl);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(emailLbl);
            Controls.Add(passwordTb);
            Controls.Add(emailTb);
            Controls.Add(loginLbl);
            Controls.Add(titleLbl);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label loginLbl;
        private TextBox emailTb;
        private TextBox passwordTb;
        private Label emailLbl;
        private Label passwordLbl;
        private Button loginBtn;
        private Label noAccountLbl;
        private Label hereLbl;
        private Label here2Lbl;
        private Label forgotPasswordLbl;
    }
}
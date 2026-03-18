namespace InstaChat
{
    partial class Register
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
            hereLbl = new Label();
            haveAccountLbl = new Label();
            registerBtn = new Button();
            passwordLbl = new Label();
            usernameLbl = new Label();
            passwordTb = new TextBox();
            usernameTb = new TextBox();
            registerLbl = new Label();
            titleLbl = new Label();
            nameLbl = new Label();
            nameTb = new TextBox();
            emailLbl = new Label();
            emailTb = new TextBox();
            confirmPasswordLbl = new Label();
            confirmPasswordTb = new TextBox();
            SuspendLayout();
            // 
            // hereLbl
            // 
            hereLbl.AutoSize = true;
            hereLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Underline, GraphicsUnit.Point);
            hereLbl.ForeColor = Color.Blue;
            hereLbl.Location = new Point(469, 498);
            hereLbl.Name = "hereLbl";
            hereLbl.Size = new Size(39, 22);
            hereLbl.TabIndex = 18;
            hereLbl.Text = "here";
            hereLbl.Click += hereLbl_Click;
            // 
            // haveAccountLbl
            // 
            haveAccountLbl.AutoSize = true;
            haveAccountLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            haveAccountLbl.Location = new Point(259, 498);
            haveAccountLbl.Name = "haveAccountLbl";
            haveAccountLbl.Size = new Size(214, 22);
            haveAccountLbl.TabIndex = 17;
            haveAccountLbl.Text = "Already have an account? Login";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(0, 192, 0);
            registerBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(151, 444);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(471, 51);
            registerBtn.TabIndex = 16;
            registerBtn.Text = "REGISTER";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.FlatStyle = FlatStyle.Flat;
            passwordLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.Location = new Point(223, 360);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(101, 29);
            passwordLbl.TabIndex = 14;
            passwordLbl.Text = "Password";
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.FlatStyle = FlatStyle.Flat;
            usernameLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.Location = new Point(220, 282);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(104, 29);
            usernameLbl.TabIndex = 13;
            usernameLbl.Text = "Username";
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(330, 358);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(292, 28);
            passwordTb.TabIndex = 14;
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTb.Location = new Point(330, 280);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(292, 28);
            usernameTb.TabIndex = 12;
            // 
            // registerLbl
            // 
            registerLbl.AutoSize = true;
            registerLbl.FlatStyle = FlatStyle.Flat;
            registerLbl.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            registerLbl.ForeColor = Color.Black;
            registerLbl.Location = new Point(289, 140);
            registerLbl.Name = "registerLbl";
            registerLbl.Size = new Size(272, 83);
            registerLbl.TabIndex = 10;
            registerLbl.Text = "Register";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(216, 30);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 9;
            titleLbl.Text = "InstaChat";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.FlatStyle = FlatStyle.Flat;
            nameLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLbl.Location = new Point(259, 242);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(65, 29);
            nameLbl.TabIndex = 19;
            nameLbl.Text = "Name";
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameTb.Location = new Point(330, 240);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(292, 28);
            nameTb.TabIndex = 11;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.FlatStyle = FlatStyle.Flat;
            emailLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLbl.Location = new Point(263, 318);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(61, 29);
            emailLbl.TabIndex = 21;
            emailLbl.Text = "Email";
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.Location = new Point(330, 318);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(292, 28);
            emailTb.TabIndex = 13;
            // 
            // confirmPasswordLbl
            // 
            confirmPasswordLbl.AutoSize = true;
            confirmPasswordLbl.FlatStyle = FlatStyle.Flat;
            confirmPasswordLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordLbl.Location = new Point(151, 397);
            confirmPasswordLbl.Name = "confirmPasswordLbl";
            confirmPasswordLbl.Size = new Size(173, 29);
            confirmPasswordLbl.TabIndex = 22;
            confirmPasswordLbl.Text = "Confirm password";
            // 
            // confirmPasswordTb
            // 
            confirmPasswordTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTb.Location = new Point(330, 397);
            confirmPasswordTb.Name = "confirmPasswordTb";
            confirmPasswordTb.PasswordChar = '*';
            confirmPasswordTb.Size = new Size(292, 28);
            confirmPasswordTb.TabIndex = 15;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 553);
            Controls.Add(confirmPasswordLbl);
            Controls.Add(confirmPasswordTb);
            Controls.Add(emailLbl);
            Controls.Add(emailTb);
            Controls.Add(nameLbl);
            Controls.Add(nameTb);
            Controls.Add(hereLbl);
            Controls.Add(haveAccountLbl);
            Controls.Add(registerBtn);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(passwordTb);
            Controls.Add(usernameTb);
            Controls.Add(registerLbl);
            Controls.Add(titleLbl);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hereLbl;
        private Label haveAccountLbl;
        private Button registerBtn;
        private Label passwordLbl;
        private Label usernameLbl;
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Label registerLbl;
        private Label titleLbl;
        private Label nameLbl;
        private TextBox nameTb;
        private Label emailLbl;
        private TextBox emailTb;
        private Label confirmPasswordLbl;
        private TextBox confirmPasswordTb;
    }
}
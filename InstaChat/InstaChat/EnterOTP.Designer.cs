namespace InstaChat
{
    partial class EnterOTP
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
            digit4 = new TextBox();
            digit3 = new TextBox();
            digit2 = new TextBox();
            digit1 = new TextBox();
            linesLbl = new Button();
            verifyOTPBtn = new Button();
            enterOTPLbl = new Label();
            titleLbl = new Label();
            SuspendLayout();
            // 
            // digit4
            // 
            digit4.BackColor = Color.FromArgb(192, 255, 255);
            digit4.BorderStyle = BorderStyle.None;
            digit4.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit4.Location = new Point(518, 191);
            digit4.Multiline = true;
            digit4.Name = "digit4";
            digit4.Size = new Size(83, 83);
            digit4.TabIndex = 43;
            digit4.TextAlign = HorizontalAlignment.Center;
            digit4.TextChanged += digit4_TextChanged;
            digit4.KeyDown += digit_KeyDown;
            // 
            // digit3
            // 
            digit3.BackColor = Color.FromArgb(192, 255, 255);
            digit3.BorderStyle = BorderStyle.None;
            digit3.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit3.Location = new Point(426, 191);
            digit3.Multiline = true;
            digit3.Name = "digit3";
            digit3.Size = new Size(83, 83);
            digit3.TabIndex = 42;
            digit3.TextAlign = HorizontalAlignment.Center;
            digit3.TextChanged += digit3_TextChanged;
            digit3.KeyDown += digit_KeyDown;
            // 
            // digit2
            // 
            digit2.BackColor = Color.FromArgb(192, 255, 255);
            digit2.BorderStyle = BorderStyle.None;
            digit2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit2.Location = new Point(334, 191);
            digit2.Multiline = true;
            digit2.Name = "digit2";
            digit2.Size = new Size(83, 83);
            digit2.TabIndex = 41;
            digit2.TextAlign = HorizontalAlignment.Center;
            digit2.TextChanged += digit2_TextChanged;
            digit2.KeyDown += digit_KeyDown;
            // 
            // digit1
            // 
            digit1.BackColor = Color.FromArgb(192, 255, 255);
            digit1.BorderStyle = BorderStyle.None;
            digit1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit1.Location = new Point(242, 191);
            digit1.Multiline = true;
            digit1.Name = "digit1";
            digit1.Size = new Size(83, 83);
            digit1.TabIndex = 40;
            digit1.TextAlign = HorizontalAlignment.Center;
            digit1.TextChanged += digit1_TextChanged;
            digit1.KeyDown += digit_KeyDown;
            // 
            // linesLbl
            // 
            linesLbl.BackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatStyle = FlatStyle.Flat;
            linesLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linesLbl.Location = new Point(132, 252);
            linesLbl.Name = "linesLbl";
            linesLbl.Size = new Size(585, 34);
            linesLbl.TabIndex = 39;
            linesLbl.Text = "__________   __________   __________   __________";
            linesLbl.UseVisualStyleBackColor = false;
            // 
            // verifyOTPBtn
            // 
            verifyOTPBtn.BackColor = Color.FromArgb(0, 192, 0);
            verifyOTPBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            verifyOTPBtn.FlatStyle = FlatStyle.Flat;
            verifyOTPBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            verifyOTPBtn.ForeColor = Color.White;
            verifyOTPBtn.Location = new Point(217, 303);
            verifyOTPBtn.Name = "verifyOTPBtn";
            verifyOTPBtn.Size = new Size(399, 51);
            verifyOTPBtn.TabIndex = 38;
            verifyOTPBtn.Text = "VERIFY";
            verifyOTPBtn.UseVisualStyleBackColor = false;
            verifyOTPBtn.Click += verifyOTPBtn_Click;
            // 
            // enterOTPLbl
            // 
            enterOTPLbl.AutoSize = true;
            enterOTPLbl.FlatStyle = FlatStyle.Flat;
            enterOTPLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            enterOTPLbl.ForeColor = Color.Black;
            enterOTPLbl.Location = new Point(144, 119);
            enterOTPLbl.Name = "enterOTPLbl";
            enterOTPLbl.Size = new Size(527, 46);
            enterOTPLbl.TabIndex = 37;
            enterOTPLbl.Text = "Enter the OTP sent to your email";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(217, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 36;
            titleLbl.Text = "InstaChat";
            // 
            // EnterOTP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 392);
            Controls.Add(digit4);
            Controls.Add(digit3);
            Controls.Add(digit2);
            Controls.Add(digit1);
            Controls.Add(linesLbl);
            Controls.Add(verifyOTPBtn);
            Controls.Add(enterOTPLbl);
            Controls.Add(titleLbl);
            Name = "EnterOTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterOTP";
            Load += EnterOTP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox digit4;
        private TextBox digit3;
        private TextBox digit2;
        private TextBox digit1;
        private Button linesLbl;
        private Button verifyOTPBtn;
        private Label enterOTPLbl;
        private Label titleLbl;
    }
}
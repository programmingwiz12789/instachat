namespace InstaChat
{
    partial class EnterCode
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
            verifyCodeBtn = new Button();
            enterCodeLbl = new Label();
            titleLbl = new Label();
            linesLbl = new Button();
            digit1 = new TextBox();
            digit2 = new TextBox();
            digit3 = new TextBox();
            digit4 = new TextBox();
            SuspendLayout();
            // 
            // verifyCodeBtn
            // 
            verifyCodeBtn.BackColor = Color.FromArgb(0, 192, 0);
            verifyCodeBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            verifyCodeBtn.FlatStyle = FlatStyle.Flat;
            verifyCodeBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            verifyCodeBtn.ForeColor = Color.White;
            verifyCodeBtn.Location = new Point(214, 291);
            verifyCodeBtn.Name = "verifyCodeBtn";
            verifyCodeBtn.Size = new Size(399, 51);
            verifyCodeBtn.TabIndex = 30;
            verifyCodeBtn.Text = "VERIFY";
            verifyCodeBtn.UseVisualStyleBackColor = false;
            verifyCodeBtn.Click += verifyCodeBtn_Click;
            // 
            // enterCodeLbl
            // 
            enterCodeLbl.AutoSize = true;
            enterCodeLbl.FlatStyle = FlatStyle.Flat;
            enterCodeLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            enterCodeLbl.ForeColor = Color.Black;
            enterCodeLbl.Location = new Point(41, 107);
            enterCodeLbl.Name = "enterCodeLbl";
            enterCodeLbl.Size = new Size(709, 46);
            enterCodeLbl.TabIndex = 23;
            enterCodeLbl.Text = "Enter the verfication code sent to your email";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(214, -3);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 22;
            titleLbl.Text = "InstaChat";
            // 
            // linesLbl
            // 
            linesLbl.BackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            linesLbl.FlatStyle = FlatStyle.Flat;
            linesLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linesLbl.Location = new Point(129, 240);
            linesLbl.Name = "linesLbl";
            linesLbl.Size = new Size(585, 34);
            linesLbl.TabIndex = 31;
            linesLbl.Text = "__________   __________   __________   __________";
            linesLbl.UseVisualStyleBackColor = false;
            // 
            // digit1
            // 
            digit1.BackColor = Color.FromArgb(192, 255, 255);
            digit1.BorderStyle = BorderStyle.None;
            digit1.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit1.Location = new Point(239, 179);
            digit1.Multiline = true;
            digit1.Name = "digit1";
            digit1.Size = new Size(83, 83);
            digit1.TabIndex = 32;
            digit1.TextAlign = HorizontalAlignment.Center;
            digit1.TextChanged += digit1_TextChanged;
            digit1.KeyDown += digit_KeyDown;
            // 
            // digit2
            // 
            digit2.BackColor = Color.FromArgb(192, 255, 255);
            digit2.BorderStyle = BorderStyle.None;
            digit2.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit2.Location = new Point(331, 179);
            digit2.Multiline = true;
            digit2.Name = "digit2";
            digit2.Size = new Size(83, 83);
            digit2.TabIndex = 33;
            digit2.TextAlign = HorizontalAlignment.Center;
            digit2.TextChanged += digit2_TextChanged;
            digit2.KeyDown += digit_KeyDown;
            // 
            // digit3
            // 
            digit3.BackColor = Color.FromArgb(192, 255, 255);
            digit3.BorderStyle = BorderStyle.None;
            digit3.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit3.Location = new Point(423, 179);
            digit3.Multiline = true;
            digit3.Name = "digit3";
            digit3.Size = new Size(83, 83);
            digit3.TabIndex = 34;
            digit3.TextAlign = HorizontalAlignment.Center;
            digit3.TextChanged += digit3_TextChanged;
            digit3.KeyDown += digit_KeyDown;
            // 
            // digit4
            // 
            digit4.BackColor = Color.FromArgb(192, 255, 255);
            digit4.BorderStyle = BorderStyle.None;
            digit4.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            digit4.Location = new Point(515, 179);
            digit4.Multiline = true;
            digit4.Name = "digit4";
            digit4.Size = new Size(83, 83);
            digit4.TabIndex = 35;
            digit4.TextAlign = HorizontalAlignment.Center;
            digit4.TextChanged += digit4_TextChanged;
            digit4.KeyDown += digit_KeyDown;
            // 
            // EnterCode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 368);
            Controls.Add(digit4);
            Controls.Add(digit3);
            Controls.Add(digit2);
            Controls.Add(digit1);
            Controls.Add(linesLbl);
            Controls.Add(verifyCodeBtn);
            Controls.Add(enterCodeLbl);
            Controls.Add(titleLbl);
            Name = "EnterCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterCode";
            Load += EnterCode_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button verifyCodeBtn;
        private Label enterCodeLbl;
        private Label titleLbl;
        private Button linesLbl;
        private TextBox digit1;
        private TextBox digit2;
        private TextBox digit3;
        private TextBox digit4;
    }
}
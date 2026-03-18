namespace InstaChat
{
    partial class EnterEmail
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
            enterEmailTb = new TextBox();
            enterPhoneNumberLbl = new Label();
            titleLbl = new Label();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // enterEmailTb
            // 
            enterEmailTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            enterEmailTb.Location = new Point(196, 196);
            enterEmailTb.Name = "enterEmailTb";
            enterEmailTb.Size = new Size(399, 28);
            enterEmailTb.TabIndex = 11;
            // 
            // enterPhoneNumberLbl
            // 
            enterPhoneNumberLbl.AutoSize = true;
            enterPhoneNumberLbl.FlatStyle = FlatStyle.Flat;
            enterPhoneNumberLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            enterPhoneNumberLbl.ForeColor = Color.Black;
            enterPhoneNumberLbl.Location = new Point(262, 133);
            enterPhoneNumberLbl.Name = "enterPhoneNumberLbl";
            enterPhoneNumberLbl.Size = new Size(276, 46);
            enterPhoneNumberLbl.TabIndex = 10;
            enterPhoneNumberLbl.Text = "Enter your email";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.FlatStyle = FlatStyle.Flat;
            titleLbl.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(0, 192, 0);
            titleLbl.Location = new Point(196, 9);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(406, 110);
            titleLbl.TabIndex = 9;
            titleLbl.Text = "InstaChat";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(0, 192, 0);
            submitBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(196, 242);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(399, 51);
            submitBtn.TabIndex = 15;
            submitBtn.Text = "SUBMIT";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // EnterEmail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 334);
            Controls.Add(submitBtn);
            Controls.Add(enterEmailTb);
            Controls.Add(enterPhoneNumberLbl);
            Controls.Add(titleLbl);
            Name = "EnterEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterEmail";
            Load += EnterEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox enterEmailTb;
        private Label enterPhoneNumberLbl;
        private Label titleLbl;
        private Button submitBtn;
    }
}
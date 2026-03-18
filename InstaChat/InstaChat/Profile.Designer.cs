namespace InstaChat
{
    partial class Profile
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
            logoutBtn = new Button();
            profileTab = new Button();
            searchFriendsTab = new Button();
            contactsTab = new Button();
            chatsTab = new Button();
            nameLbl = new Label();
            nameTb = new TextBox();
            usernameLbl = new Label();
            usernameTb = new TextBox();
            birthdateLbl = new Label();
            birthdateDtp = new DateTimePicker();
            genderLbl = new Label();
            genderGb = new GroupBox();
            femaleRb = new RadioButton();
            maleRb = new RadioButton();
            statusMessageLbl = new Label();
            statusMessageTb = new TextBox();
            bioLbl = new Label();
            bioTb = new TextBox();
            editProfileBtn = new Button();
            saveProfileChangesBtn = new Button();
            emailLbl = new Label();
            emailTb = new TextBox();
            chooseImageBtn = new Button();
            chooseImageFd = new OpenFileDialog();
            imagePb = new PictureBox();
            genderGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePb).BeginInit();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Red;
            logoutBtn.FlatAppearance.BorderColor = Color.Red;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(-3, 385);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(100, 100);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // profileTab
            // 
            profileTab.BackColor = Color.FromArgb(0, 0, 192);
            profileTab.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            profileTab.FlatStyle = FlatStyle.Flat;
            profileTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            profileTab.ForeColor = Color.White;
            profileTab.Location = new Point(-3, 288);
            profileTab.Name = "profileTab";
            profileTab.Size = new Size(100, 100);
            profileTab.TabIndex = 9;
            profileTab.Text = "Profile";
            profileTab.UseVisualStyleBackColor = false;
            // 
            // searchFriendsTab
            // 
            searchFriendsTab.BackColor = Color.Blue;
            searchFriendsTab.FlatAppearance.BorderColor = Color.Blue;
            searchFriendsTab.FlatStyle = FlatStyle.Flat;
            searchFriendsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            searchFriendsTab.ForeColor = Color.White;
            searchFriendsTab.Location = new Point(-3, 191);
            searchFriendsTab.Name = "searchFriendsTab";
            searchFriendsTab.Size = new Size(100, 100);
            searchFriendsTab.TabIndex = 8;
            searchFriendsTab.Text = "Search friends";
            searchFriendsTab.UseVisualStyleBackColor = false;
            searchFriendsTab.Click += searchFriendsTab_Click;
            // 
            // contactsTab
            // 
            contactsTab.BackColor = Color.Blue;
            contactsTab.FlatAppearance.BorderColor = Color.Blue;
            contactsTab.FlatStyle = FlatStyle.Flat;
            contactsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            contactsTab.ForeColor = Color.White;
            contactsTab.Location = new Point(-3, 95);
            contactsTab.Name = "contactsTab";
            contactsTab.Size = new Size(100, 100);
            contactsTab.TabIndex = 7;
            contactsTab.Text = "Contacts";
            contactsTab.UseVisualStyleBackColor = false;
            contactsTab.Click += contactsTab_Click;
            // 
            // chatsTab
            // 
            chatsTab.BackColor = Color.Blue;
            chatsTab.FlatAppearance.BorderColor = Color.Blue;
            chatsTab.FlatStyle = FlatStyle.Flat;
            chatsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chatsTab.ForeColor = Color.White;
            chatsTab.Location = new Point(-3, -2);
            chatsTab.Name = "chatsTab";
            chatsTab.Size = new Size(100, 100);
            chatsTab.TabIndex = 6;
            chatsTab.Text = "Chats";
            chatsTab.UseVisualStyleBackColor = false;
            chatsTab.Click += chatsTab_Click;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.FlatStyle = FlatStyle.Flat;
            nameLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLbl.Location = new Point(178, 223);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(65, 29);
            nameLbl.TabIndex = 25;
            nameLbl.Text = "Name";
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTb.Location = new Point(249, 221);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(292, 35);
            nameTb.TabIndex = 24;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.FlatStyle = FlatStyle.Flat;
            usernameLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.Location = new Point(139, 263);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(104, 29);
            usernameLbl.TabIndex = 22;
            usernameLbl.Text = "Username";
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTb.Location = new Point(249, 261);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(292, 35);
            usernameTb.TabIndex = 20;
            // 
            // birthdateLbl
            // 
            birthdateLbl.AutoSize = true;
            birthdateLbl.FlatStyle = FlatStyle.Flat;
            birthdateLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdateLbl.Location = new Point(152, 343);
            birthdateLbl.Name = "birthdateLbl";
            birthdateLbl.Size = new Size(91, 29);
            birthdateLbl.TabIndex = 26;
            birthdateLbl.Text = "Birthdate";
            // 
            // birthdateDtp
            // 
            birthdateDtp.CalendarFont = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdateDtp.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdateDtp.Location = new Point(249, 343);
            birthdateDtp.Name = "birthdateDtp";
            birthdateDtp.Size = new Size(292, 35);
            birthdateDtp.TabIndex = 27;
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.FlatStyle = FlatStyle.Flat;
            genderLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderLbl.Location = new Point(635, 242);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(79, 29);
            genderLbl.TabIndex = 28;
            genderLbl.Text = "Gender";
            // 
            // genderGb
            // 
            genderGb.Controls.Add(femaleRb);
            genderGb.Controls.Add(maleRb);
            genderGb.FlatStyle = FlatStyle.Flat;
            genderGb.Location = new Point(720, 219);
            genderGb.Name = "genderGb";
            genderGb.Size = new Size(292, 63);
            genderGb.TabIndex = 29;
            genderGb.TabStop = false;
            // 
            // femaleRb
            // 
            femaleRb.AutoSize = true;
            femaleRb.FlatStyle = FlatStyle.Flat;
            femaleRb.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            femaleRb.Location = new Point(158, 23);
            femaleRb.Name = "femaleRb";
            femaleRb.Size = new Size(101, 33);
            femaleRb.TabIndex = 1;
            femaleRb.TabStop = true;
            femaleRb.Text = "Female";
            femaleRb.UseVisualStyleBackColor = true;
            // 
            // maleRb
            // 
            maleRb.AutoSize = true;
            maleRb.FlatStyle = FlatStyle.Flat;
            maleRb.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maleRb.Location = new Point(35, 23);
            maleRb.Name = "maleRb";
            maleRb.Size = new Size(79, 33);
            maleRb.TabIndex = 0;
            maleRb.TabStop = true;
            maleRb.Text = "Male";
            maleRb.UseVisualStyleBackColor = true;
            // 
            // statusMessageLbl
            // 
            statusMessageLbl.AutoSize = true;
            statusMessageLbl.FlatStyle = FlatStyle.Flat;
            statusMessageLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusMessageLbl.Location = new Point(561, 288);
            statusMessageLbl.Name = "statusMessageLbl";
            statusMessageLbl.Size = new Size(153, 29);
            statusMessageLbl.TabIndex = 30;
            statusMessageLbl.Text = "Status message";
            // 
            // statusMessageTb
            // 
            statusMessageTb.Location = new Point(720, 288);
            statusMessageTb.Name = "statusMessageTb";
            statusMessageTb.Size = new Size(292, 31);
            statusMessageTb.TabIndex = 31;
            // 
            // bioLbl
            // 
            bioLbl.AutoSize = true;
            bioLbl.FlatStyle = FlatStyle.Flat;
            bioLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bioLbl.Location = new Point(673, 331);
            bioLbl.Name = "bioLbl";
            bioLbl.Size = new Size(41, 29);
            bioLbl.TabIndex = 32;
            bioLbl.Text = "Bio";
            // 
            // bioTb
            // 
            bioTb.Location = new Point(720, 329);
            bioTb.Multiline = true;
            bioTb.Name = "bioTb";
            bioTb.Size = new Size(292, 124);
            bioTb.TabIndex = 33;
            // 
            // editProfileBtn
            // 
            editProfileBtn.BackColor = Color.Blue;
            editProfileBtn.FlatAppearance.BorderColor = Color.Blue;
            editProfileBtn.FlatStyle = FlatStyle.Flat;
            editProfileBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            editProfileBtn.ForeColor = Color.White;
            editProfileBtn.Location = new Point(249, 415);
            editProfileBtn.Name = "editProfileBtn";
            editProfileBtn.Size = new Size(138, 38);
            editProfileBtn.TabIndex = 34;
            editProfileBtn.Text = "Edit";
            editProfileBtn.UseVisualStyleBackColor = false;
            editProfileBtn.Click += editProfileBtn_Click;
            // 
            // saveProfileChangesBtn
            // 
            saveProfileChangesBtn.BackColor = Color.FromArgb(0, 192, 0);
            saveProfileChangesBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            saveProfileChangesBtn.FlatStyle = FlatStyle.Flat;
            saveProfileChangesBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            saveProfileChangesBtn.ForeColor = Color.White;
            saveProfileChangesBtn.Location = new Point(403, 415);
            saveProfileChangesBtn.Name = "saveProfileChangesBtn";
            saveProfileChangesBtn.Size = new Size(138, 38);
            saveProfileChangesBtn.TabIndex = 35;
            saveProfileChangesBtn.Text = "Save";
            saveProfileChangesBtn.UseVisualStyleBackColor = false;
            saveProfileChangesBtn.Click += saveProfileChangesBtn_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.FlatStyle = FlatStyle.Flat;
            emailLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLbl.Location = new Point(182, 302);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(61, 29);
            emailLbl.TabIndex = 37;
            emailLbl.Text = "Email";
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.Location = new Point(249, 302);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(292, 35);
            emailTb.TabIndex = 36;
            // 
            // chooseImageBtn
            // 
            chooseImageBtn.BackColor = Color.Blue;
            chooseImageBtn.FlatAppearance.BorderColor = Color.Blue;
            chooseImageBtn.FlatStyle = FlatStyle.Flat;
            chooseImageBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chooseImageBtn.ForeColor = Color.White;
            chooseImageBtn.Location = new Point(463, 175);
            chooseImageBtn.Name = "chooseImageBtn";
            chooseImageBtn.Size = new Size(147, 38);
            chooseImageBtn.TabIndex = 38;
            chooseImageBtn.Text = "Choose image";
            chooseImageBtn.UseVisualStyleBackColor = false;
            chooseImageBtn.Click += chooseImageBtn_Click;
            // 
            // chooseImageFd
            // 
            chooseImageFd.FileName = "openFileDialog1";
            // 
            // imagePb
            // 
            imagePb.BackColor = Color.Cyan;
            imagePb.Location = new Point(463, 12);
            imagePb.Name = "imagePb";
            imagePb.Size = new Size(147, 147);
            imagePb.TabIndex = 39;
            imagePb.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1039, 483);
            Controls.Add(imagePb);
            Controls.Add(chooseImageBtn);
            Controls.Add(emailLbl);
            Controls.Add(emailTb);
            Controls.Add(saveProfileChangesBtn);
            Controls.Add(editProfileBtn);
            Controls.Add(bioTb);
            Controls.Add(bioLbl);
            Controls.Add(statusMessageTb);
            Controls.Add(statusMessageLbl);
            Controls.Add(genderGb);
            Controls.Add(genderLbl);
            Controls.Add(birthdateDtp);
            Controls.Add(birthdateLbl);
            Controls.Add(nameLbl);
            Controls.Add(nameTb);
            Controls.Add(usernameLbl);
            Controls.Add(usernameTb);
            Controls.Add(logoutBtn);
            Controls.Add(profileTab);
            Controls.Add(searchFriendsTab);
            Controls.Add(contactsTab);
            Controls.Add(chatsTab);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            genderGb.ResumeLayout(false);
            genderGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutBtn;
        private Button profileTab;
        private Button searchFriendsTab;
        private Button contactsTab;
        private Button chatsTab;
        private Label nameLbl;
        private TextBox nameTb;
        private Label usernameLbl;
        private TextBox usernameTb;
        private Label birthdateLbl;
        private DateTimePicker birthdateDtp;
        private Label genderLbl;
        private GroupBox genderGb;
        private RadioButton maleRb;
        private RadioButton femaleRb;
        private Label statusMessageLbl;
        private TextBox statusMessageTb;
        private Label bioLbl;
        private TextBox bioTb;
        private Button editProfileBtn;
        private Button saveProfileChangesBtn;
        private Label emailLbl;
        private TextBox emailTb;
        private Button chooseImageBtn;
        private OpenFileDialog chooseImageFd;
        private PictureBox imagePb;
    }
}
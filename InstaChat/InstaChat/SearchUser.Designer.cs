namespace InstaChat
{
    partial class SearchUser
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
            instructionLbl = new Label();
            friendUsernameTb = new TextBox();
            searchFriendBtn = new Button();
            friendUsernameLbl = new Button();
            addFriendBtn = new Button();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Red;
            logoutBtn.FlatAppearance.BorderColor = Color.Red;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(-2, 385);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(100, 100);
            logoutBtn.TabIndex = 10;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // profileTab
            // 
            profileTab.BackColor = Color.Blue;
            profileTab.FlatAppearance.BorderColor = Color.Blue;
            profileTab.FlatStyle = FlatStyle.Flat;
            profileTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            profileTab.ForeColor = Color.White;
            profileTab.Location = new Point(-2, 288);
            profileTab.Name = "profileTab";
            profileTab.Size = new Size(100, 100);
            profileTab.TabIndex = 9;
            profileTab.Text = "Profile";
            profileTab.UseVisualStyleBackColor = false;
            profileTab.Click += profileTab_Click;
            // 
            // searchFriendsTab
            // 
            searchFriendsTab.BackColor = Color.FromArgb(0, 0, 192);
            searchFriendsTab.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            searchFriendsTab.FlatStyle = FlatStyle.Flat;
            searchFriendsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            searchFriendsTab.ForeColor = Color.White;
            searchFriendsTab.Location = new Point(-2, 191);
            searchFriendsTab.Name = "searchFriendsTab";
            searchFriendsTab.Size = new Size(100, 100);
            searchFriendsTab.TabIndex = 8;
            searchFriendsTab.Text = "Search friends";
            searchFriendsTab.UseVisualStyleBackColor = false;
            // 
            // contactsTab
            // 
            contactsTab.BackColor = Color.Blue;
            contactsTab.FlatAppearance.BorderColor = Color.Blue;
            contactsTab.FlatStyle = FlatStyle.Flat;
            contactsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            contactsTab.ForeColor = Color.White;
            contactsTab.Location = new Point(-2, 95);
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
            chatsTab.Location = new Point(-2, -2);
            chatsTab.Name = "chatsTab";
            chatsTab.Size = new Size(100, 100);
            chatsTab.TabIndex = 6;
            chatsTab.Text = "Chats";
            chatsTab.UseVisualStyleBackColor = false;
            chatsTab.Click += chatsTab_Click;
            // 
            // instructionLbl
            // 
            instructionLbl.AutoSize = true;
            instructionLbl.FlatStyle = FlatStyle.Flat;
            instructionLbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            instructionLbl.Location = new Point(299, 130);
            instructionLbl.Name = "instructionLbl";
            instructionLbl.Size = new Size(305, 29);
            instructionLbl.TabIndex = 20;
            instructionLbl.Text = "Enter the username of your friend";
            // 
            // friendUsernameTb
            // 
            friendUsernameTb.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            friendUsernameTb.Location = new Point(272, 164);
            friendUsernameTb.Multiline = true;
            friendUsernameTb.Name = "friendUsernameTb";
            friendUsernameTb.Size = new Size(263, 41);
            friendUsernameTb.TabIndex = 21;
            // 
            // searchFriendBtn
            // 
            searchFriendBtn.BackColor = Color.Blue;
            searchFriendBtn.FlatAppearance.BorderColor = Color.Blue;
            searchFriendBtn.FlatStyle = FlatStyle.Flat;
            searchFriendBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            searchFriendBtn.ForeColor = Color.White;
            searchFriendBtn.Location = new Point(541, 164);
            searchFriendBtn.Name = "searchFriendBtn";
            searchFriendBtn.Size = new Size(86, 41);
            searchFriendBtn.TabIndex = 22;
            searchFriendBtn.Text = "Search";
            searchFriendBtn.UseVisualStyleBackColor = false;
            searchFriendBtn.Click += searchFriendBtn_Click;
            // 
            // friendUsernameLbl
            // 
            friendUsernameLbl.Enabled = false;
            friendUsernameLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            friendUsernameLbl.FlatStyle = FlatStyle.Flat;
            friendUsernameLbl.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            friendUsernameLbl.Location = new Point(104, 211);
            friendUsernameLbl.Name = "friendUsernameLbl";
            friendUsernameLbl.Size = new Size(684, 56);
            friendUsernameLbl.TabIndex = 23;
            friendUsernameLbl.Text = "john6998";
            friendUsernameLbl.UseVisualStyleBackColor = true;
            // 
            // addFriendBtn
            // 
            addFriendBtn.BackColor = Color.FromArgb(0, 192, 0);
            addFriendBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            addFriendBtn.FlatStyle = FlatStyle.Flat;
            addFriendBtn.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addFriendBtn.ForeColor = Color.White;
            addFriendBtn.Location = new Point(395, 273);
            addFriendBtn.Name = "addFriendBtn";
            addFriendBtn.Size = new Size(100, 40);
            addFriendBtn.TabIndex = 24;
            addFriendBtn.Text = "Add";
            addFriendBtn.UseVisualStyleBackColor = false;
            addFriendBtn.Click += addFriendBtn_Click;
            // 
            // SearchUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 485);
            Controls.Add(addFriendBtn);
            Controls.Add(friendUsernameLbl);
            Controls.Add(searchFriendBtn);
            Controls.Add(friendUsernameTb);
            Controls.Add(instructionLbl);
            Controls.Add(logoutBtn);
            Controls.Add(profileTab);
            Controls.Add(searchFriendsTab);
            Controls.Add(contactsTab);
            Controls.Add(chatsTab);
            Name = "SearchUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchUser";
            Load += SearchUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutBtn;
        private Button profileTab;
        private Button searchFriendsTab;
        private Button contactsTab;
        private Button chatsTab;
        private Label instructionLbl;
        private TextBox friendUsernameTb;
        private Button searchFriendBtn;
        private Button friendUsernameLbl;
        private Button addFriendBtn;
    }
}
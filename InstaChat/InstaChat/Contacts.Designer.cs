namespace InstaChat
{
    partial class Contacts
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
            friendsContainer = new Panel();
            imagePb2 = new PictureBox();
            friend2 = new Button();
            imagePb1 = new PictureBox();
            noFriendsLbl = new Button();
            friend1 = new Button();
            searchFriendsTb = new TextBox();
            searchFriendsLbl = new Label();
            friendsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagePb1).BeginInit();
            SuspendLayout();
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Red;
            logoutBtn.FlatAppearance.BorderColor = Color.Red;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(-1, 386);
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
            profileTab.Location = new Point(-1, 289);
            profileTab.Name = "profileTab";
            profileTab.Size = new Size(100, 100);
            profileTab.TabIndex = 9;
            profileTab.Text = "Profile";
            profileTab.UseVisualStyleBackColor = false;
            profileTab.Click += profileTab_Click;
            // 
            // searchFriendsTab
            // 
            searchFriendsTab.BackColor = Color.Blue;
            searchFriendsTab.FlatAppearance.BorderColor = Color.Blue;
            searchFriendsTab.FlatStyle = FlatStyle.Flat;
            searchFriendsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            searchFriendsTab.ForeColor = Color.White;
            searchFriendsTab.Location = new Point(-1, 192);
            searchFriendsTab.Name = "searchFriendsTab";
            searchFriendsTab.Size = new Size(100, 100);
            searchFriendsTab.TabIndex = 8;
            searchFriendsTab.Text = "Search friends";
            searchFriendsTab.UseVisualStyleBackColor = false;
            searchFriendsTab.Click += searchFriendsTab_Click;
            // 
            // contactsTab
            // 
            contactsTab.BackColor = Color.FromArgb(0, 0, 192);
            contactsTab.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            contactsTab.FlatStyle = FlatStyle.Flat;
            contactsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            contactsTab.ForeColor = Color.White;
            contactsTab.Location = new Point(-1, 96);
            contactsTab.Name = "contactsTab";
            contactsTab.Size = new Size(100, 100);
            contactsTab.TabIndex = 7;
            contactsTab.Text = "Contacts";
            contactsTab.UseVisualStyleBackColor = false;
            // 
            // chatsTab
            // 
            chatsTab.BackColor = Color.Blue;
            chatsTab.FlatAppearance.BorderColor = Color.Blue;
            chatsTab.FlatStyle = FlatStyle.Flat;
            chatsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chatsTab.ForeColor = Color.White;
            chatsTab.Location = new Point(-1, -1);
            chatsTab.Name = "chatsTab";
            chatsTab.Size = new Size(100, 100);
            chatsTab.TabIndex = 6;
            chatsTab.Text = "Chats";
            chatsTab.UseVisualStyleBackColor = false;
            chatsTab.Click += chatsTab_Click;
            // 
            // friendsContainer
            // 
            friendsContainer.AutoScroll = true;
            friendsContainer.Controls.Add(imagePb2);
            friendsContainer.Controls.Add(friend2);
            friendsContainer.Controls.Add(imagePb1);
            friendsContainer.Controls.Add(noFriendsLbl);
            friendsContainer.Controls.Add(friend1);
            friendsContainer.Location = new Point(98, 46);
            friendsContainer.Name = "friendsContainer";
            friendsContainer.Size = new Size(748, 440);
            friendsContainer.TabIndex = 11;
            // 
            // imagePb2
            // 
            imagePb2.BackColor = Color.Cyan;
            imagePb2.Location = new Point(7, 87);
            imagePb2.Name = "imagePb2";
            imagePb2.Size = new Size(75, 75);
            imagePb2.TabIndex = 15;
            imagePb2.TabStop = false;
            // 
            // friend2
            // 
            friend2.BackColor = Color.White;
            friend2.FlatStyle = FlatStyle.Flat;
            friend2.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            friend2.Location = new Point(0, 83);
            friend2.Name = "friend2";
            friend2.Size = new Size(704, 84);
            friend2.TabIndex = 14;
            friend2.Text = "Friend2";
            friend2.UseVisualStyleBackColor = false;
            // 
            // imagePb1
            // 
            imagePb1.BackColor = Color.Cyan;
            imagePb1.Location = new Point(7, 4);
            imagePb1.Name = "imagePb1";
            imagePb1.Size = new Size(75, 75);
            imagePb1.TabIndex = 13;
            imagePb1.TabStop = false;
            // 
            // noFriendsLbl
            // 
            noFriendsLbl.BackColor = Color.FromArgb(192, 255, 255);
            noFriendsLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            noFriendsLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            noFriendsLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            noFriendsLbl.FlatStyle = FlatStyle.Flat;
            noFriendsLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            noFriendsLbl.ForeColor = Color.Silver;
            noFriendsLbl.Location = new Point(3, 196);
            noFriendsLbl.Name = "noFriendsLbl";
            noFriendsLbl.Size = new Size(701, 83);
            noFriendsLbl.TabIndex = 12;
            noFriendsLbl.Text = "No friends";
            noFriendsLbl.UseVisualStyleBackColor = false;
            // 
            // friend1
            // 
            friend1.BackColor = Color.White;
            friend1.FlatStyle = FlatStyle.Flat;
            friend1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            friend1.Location = new Point(0, 0);
            friend1.Name = "friend1";
            friend1.Size = new Size(704, 84);
            friend1.TabIndex = 1;
            friend1.Text = "Friend1";
            friend1.UseVisualStyleBackColor = false;
            // 
            // searchFriendsTb
            // 
            searchFriendsTb.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchFriendsTb.Location = new Point(167, 12);
            searchFriendsTb.Name = "searchFriendsTb";
            searchFriendsTb.Size = new Size(621, 28);
            searchFriendsTb.TabIndex = 13;
            searchFriendsTb.TextChanged += searchFriendsTb_TextChanged;
            // 
            // searchFriendsLbl
            // 
            searchFriendsLbl.AutoSize = true;
            searchFriendsLbl.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchFriendsLbl.Location = new Point(105, 14);
            searchFriendsLbl.Name = "searchFriendsLbl";
            searchFriendsLbl.Size = new Size(56, 22);
            searchFriendsLbl.TabIndex = 14;
            searchFriendsLbl.Text = "Search";
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 485);
            Controls.Add(searchFriendsLbl);
            Controls.Add(searchFriendsTb);
            Controls.Add(friendsContainer);
            Controls.Add(logoutBtn);
            Controls.Add(profileTab);
            Controls.Add(searchFriendsTab);
            Controls.Add(contactsTab);
            Controls.Add(chatsTab);
            Name = "Contacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            Load += Contacts_Load;
            friendsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagePb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutBtn;
        private Button profileTab;
        private Button searchFriendsTab;
        private Button contactsTab;
        private Button chatsTab;
        private Panel friendsContainer;
        private Button friend1;
        private Button noFriendsLbl;
        private TextBox searchFriendsTb;
        private Label searchFriendsLbl;
        private PictureBox imagePb1;
        private PictureBox imagePb2;
        private Button friend2;
    }
}
namespace InstaChat
{
    partial class Chats
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
            components = new System.ComponentModel.Container();
            chat1 = new Button();
            chatsTab = new Button();
            contactsTab = new Button();
            searchFriendsTab = new Button();
            profileTab = new Button();
            logoutBtn = new Button();
            friendsContainer = new Panel();
            noChatsLbl = new Button();
            messageTb = new TextBox();
            sendMessageBtn = new Button();
            button7 = new Button();
            chatContainer = new Panel();
            startChattingLbl = new Button();
            button8 = new Button();
            friendNameBar = new Button();
            chatFeaturesCb = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            friendsContainer.SuspendLayout();
            chatContainer.SuspendLayout();
            SuspendLayout();
            // 
            // chat1
            // 
            chat1.BackColor = Color.WhiteSmoke;
            chat1.FlatAppearance.BorderColor = Color.Black;
            chat1.FlatStyle = FlatStyle.Flat;
            chat1.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            chat1.Location = new Point(0, 0);
            chat1.Name = "chat1";
            chat1.Size = new Size(394, 83);
            chat1.TabIndex = 0;
            chat1.Text = "Friend1";
            chat1.UseVisualStyleBackColor = false;
            // 
            // chatsTab
            // 
            chatsTab.BackColor = Color.FromArgb(0, 0, 192);
            chatsTab.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            chatsTab.FlatStyle = FlatStyle.Flat;
            chatsTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            chatsTab.ForeColor = Color.White;
            chatsTab.Location = new Point(-3, -2);
            chatsTab.Name = "chatsTab";
            chatsTab.Size = new Size(100, 100);
            chatsTab.TabIndex = 1;
            chatsTab.Text = "Chats";
            chatsTab.UseVisualStyleBackColor = false;
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
            contactsTab.TabIndex = 2;
            contactsTab.Text = "Contacts";
            contactsTab.UseVisualStyleBackColor = false;
            contactsTab.Click += contactsTab_Click;
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
            searchFriendsTab.TabIndex = 3;
            searchFriendsTab.Text = "Search friends";
            searchFriendsTab.UseVisualStyleBackColor = false;
            searchFriendsTab.Click += searchFriendsTab_Click;
            // 
            // profileTab
            // 
            profileTab.BackColor = Color.Blue;
            profileTab.FlatAppearance.BorderColor = Color.Blue;
            profileTab.FlatStyle = FlatStyle.Flat;
            profileTab.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            profileTab.ForeColor = Color.White;
            profileTab.Location = new Point(-3, 288);
            profileTab.Name = "profileTab";
            profileTab.Size = new Size(100, 100);
            profileTab.TabIndex = 4;
            profileTab.Text = "Profile";
            profileTab.UseVisualStyleBackColor = false;
            profileTab.Click += profileTab_Click;
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
            logoutBtn.TabIndex = 5;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // friendsContainer
            // 
            friendsContainer.AutoScroll = true;
            friendsContainer.BackColor = Color.Cyan;
            friendsContainer.Controls.Add(noChatsLbl);
            friendsContainer.Controls.Add(chat1);
            friendsContainer.Location = new Point(94, 1);
            friendsContainer.Name = "friendsContainer";
            friendsContainer.Size = new Size(394, 484);
            friendsContainer.TabIndex = 13;
            // 
            // noChatsLbl
            // 
            noChatsLbl.BackColor = Color.Cyan;
            noChatsLbl.FlatAppearance.BorderColor = Color.Cyan;
            noChatsLbl.FlatAppearance.MouseDownBackColor = Color.Cyan;
            noChatsLbl.FlatAppearance.MouseOverBackColor = Color.Cyan;
            noChatsLbl.FlatStyle = FlatStyle.Flat;
            noChatsLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            noChatsLbl.ForeColor = Color.Silver;
            noChatsLbl.Location = new Point(3, 201);
            noChatsLbl.Name = "noChatsLbl";
            noChatsLbl.Size = new Size(391, 83);
            noChatsLbl.TabIndex = 1;
            noChatsLbl.Text = "No chats";
            noChatsLbl.UseVisualStyleBackColor = false;
            // 
            // messageTb
            // 
            messageTb.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            messageTb.Location = new Point(487, 444);
            messageTb.Multiline = true;
            messageTb.Name = "messageTb";
            messageTb.Size = new Size(351, 41);
            messageTb.TabIndex = 14;
            // 
            // sendMessageBtn
            // 
            sendMessageBtn.BackColor = Color.Blue;
            sendMessageBtn.FlatAppearance.BorderColor = Color.Blue;
            sendMessageBtn.FlatStyle = FlatStyle.Flat;
            sendMessageBtn.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            sendMessageBtn.ForeColor = Color.White;
            sendMessageBtn.Location = new Point(833, 444);
            sendMessageBtn.Name = "sendMessageBtn";
            sendMessageBtn.Size = new Size(86, 41);
            sendMessageBtn.TabIndex = 15;
            sendMessageBtn.Text = "Send";
            sendMessageBtn.UseVisualStyleBackColor = false;
            sendMessageBtn.Click += sendMessageBtn_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.FlatAppearance.BorderColor = Color.Lime;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(306, 11);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 16;
            button7.Text = "Hello";
            button7.UseVisualStyleBackColor = false;
            // 
            // chatContainer
            // 
            chatContainer.AutoScroll = true;
            chatContainer.BackColor = Color.FromArgb(192, 255, 255);
            chatContainer.Controls.Add(startChattingLbl);
            chatContainer.Controls.Add(button8);
            chatContainer.Controls.Add(button7);
            chatContainer.Location = new Point(487, 31);
            chatContainer.Name = "chatContainer";
            chatContainer.Size = new Size(465, 407);
            chatContainer.TabIndex = 17;
            // 
            // startChattingLbl
            // 
            startChattingLbl.BackColor = Color.FromArgb(192, 255, 255);
            startChattingLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            startChattingLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            startChattingLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            startChattingLbl.FlatStyle = FlatStyle.Flat;
            startChattingLbl.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            startChattingLbl.ForeColor = Color.Silver;
            startChattingLbl.Location = new Point(3, 170);
            startChattingLbl.Name = "startChattingLbl";
            startChattingLbl.Size = new Size(429, 83);
            startChattingLbl.TabIndex = 19;
            startChattingLbl.Text = "Start chatting!";
            startChattingLbl.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(224, 224, 224);
            button8.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(7, 63);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 17;
            button8.Text = "Hey!";
            button8.UseVisualStyleBackColor = false;
            // 
            // friendNameBar
            // 
            friendNameBar.BackColor = Color.White;
            friendNameBar.FlatAppearance.BorderColor = Color.Black;
            friendNameBar.FlatStyle = FlatStyle.Flat;
            friendNameBar.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point);
            friendNameBar.Location = new Point(487, 1);
            friendNameBar.Name = "friendNameBar";
            friendNameBar.Size = new Size(407, 33);
            friendNameBar.TabIndex = 13;
            friendNameBar.Text = "Friend1";
            friendNameBar.UseVisualStyleBackColor = false;
            // 
            // chatFeaturesCb
            // 
            chatFeaturesCb.DropDownStyle = ComboBoxStyle.DropDownList;
            chatFeaturesCb.FormattingEnabled = true;
            chatFeaturesCb.Items.AddRange(new object[] { "Clear chat", "Delete chat" });
            chatFeaturesCb.Location = new Point(793, 1);
            chatFeaturesCb.Name = "chatFeaturesCb";
            chatFeaturesCb.Size = new Size(126, 33);
            chatFeaturesCb.TabIndex = 18;
            chatFeaturesCb.SelectionChangeCommitted += chatFeaturesCb_SelectionChangeCommitted;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Chats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(917, 485);
            Controls.Add(friendNameBar);
            Controls.Add(chatContainer);
            Controls.Add(sendMessageBtn);
            Controls.Add(messageTb);
            Controls.Add(friendsContainer);
            Controls.Add(logoutBtn);
            Controls.Add(profileTab);
            Controls.Add(searchFriendsTab);
            Controls.Add(contactsTab);
            Controls.Add(chatsTab);
            Controls.Add(chatFeaturesCb);
            Name = "Chats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chats";
            Load += Chats_Load;
            friendsContainer.ResumeLayout(false);
            chatContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chat1;
        private Button chatsTab;
        private Button contactsTab;
        private Button searchFriendsTab;
        private Button profileTab;
        private Button logoutBtn;
        private Panel friendsContainer;
        private TextBox messageTb;
        private Button sendMessageBtn;
        private Button button7;
        private Panel chatContainer;
        private Button button8;
        private Button friendNameBar;
        private ComboBox chatFeaturesCb;
        private System.Windows.Forms.Timer timer1;
        private Button noChatsLbl;
        private Button startChattingLbl;
    }
}
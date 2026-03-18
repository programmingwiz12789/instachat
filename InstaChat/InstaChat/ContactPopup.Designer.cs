namespace InstaChat
{
    partial class ContactPopup
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
            friendUsernameLbl = new Button();
            friendNameLbl = new Button();
            chatBtn = new Button();
            blockFriendBtn = new Button();
            deleteFriendBtn = new Button();
            SuspendLayout();
            // 
            // friendUsernameLbl
            // 
            friendUsernameLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            friendUsernameLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            friendUsernameLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            friendUsernameLbl.FlatStyle = FlatStyle.Flat;
            friendUsernameLbl.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point);
            friendUsernameLbl.Location = new Point(12, 96);
            friendUsernameLbl.Name = "friendUsernameLbl";
            friendUsernameLbl.Size = new Size(312, 56);
            friendUsernameLbl.TabIndex = 24;
            friendUsernameLbl.Text = "john6998";
            friendUsernameLbl.UseVisualStyleBackColor = true;
            // 
            // friendNameLbl
            // 
            friendNameLbl.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            friendNameLbl.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            friendNameLbl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            friendNameLbl.FlatStyle = FlatStyle.Flat;
            friendNameLbl.Font = new Font("Arial Narrow", 28F, FontStyle.Bold, GraphicsUnit.Point);
            friendNameLbl.Location = new Point(12, 12);
            friendNameLbl.Name = "friendNameLbl";
            friendNameLbl.Size = new Size(312, 78);
            friendNameLbl.TabIndex = 25;
            friendNameLbl.Text = "John";
            friendNameLbl.UseVisualStyleBackColor = true;
            // 
            // chatBtn
            // 
            chatBtn.BackColor = Color.Blue;
            chatBtn.FlatStyle = FlatStyle.Flat;
            chatBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chatBtn.ForeColor = Color.White;
            chatBtn.Location = new Point(12, 158);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(100, 100);
            chatBtn.TabIndex = 26;
            chatBtn.Text = "Chat";
            chatBtn.UseVisualStyleBackColor = false;
            chatBtn.Click += chatBtn_Click;
            // 
            // blockFriendBtn
            // 
            blockFriendBtn.BackColor = Color.Red;
            blockFriendBtn.FlatStyle = FlatStyle.Flat;
            blockFriendBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            blockFriendBtn.ForeColor = Color.White;
            blockFriendBtn.Location = new Point(118, 158);
            blockFriendBtn.Name = "blockFriendBtn";
            blockFriendBtn.Size = new Size(100, 100);
            blockFriendBtn.TabIndex = 27;
            blockFriendBtn.Text = "Block";
            blockFriendBtn.UseVisualStyleBackColor = false;
            blockFriendBtn.Click += blockFriendBtn_Click;
            // 
            // deleteFriendBtn
            // 
            deleteFriendBtn.BackColor = Color.Red;
            deleteFriendBtn.FlatStyle = FlatStyle.Flat;
            deleteFriendBtn.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteFriendBtn.ForeColor = Color.White;
            deleteFriendBtn.Location = new Point(224, 158);
            deleteFriendBtn.Name = "deleteFriendBtn";
            deleteFriendBtn.Size = new Size(100, 100);
            deleteFriendBtn.TabIndex = 28;
            deleteFriendBtn.Text = "Delete";
            deleteFriendBtn.UseVisualStyleBackColor = false;
            deleteFriendBtn.Click += deleteFriendBtn_Click;
            // 
            // ContactPopup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(337, 275);
            Controls.Add(deleteFriendBtn);
            Controls.Add(blockFriendBtn);
            Controls.Add(chatBtn);
            Controls.Add(friendNameLbl);
            Controls.Add(friendUsernameLbl);
            Name = "ContactPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactPopup";
            Load += ContactPopup_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button friendUsernameLbl;
        private Button friendNameLbl;
        private Button chatBtn;
        private Button blockFriendBtn;
        private Button deleteFriendBtn;
    }
}
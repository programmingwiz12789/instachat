using System.Data;
using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class Chats : Form
    {
        private MySqlConnection conn;
        private User user, chosenFriend;
        private Button clickedBtn, friendBtn;
        private CustomPanel chatPanel;
        private int friendId, chosenChatId, scrollValue;
        private bool fullScroll;
        
        public Chats(User user, int friendId = -1)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.user = user;
            this.friendId = friendId;
            fullScroll = true;
        }

        private void loadForm()
        {
            while (chatPanel.Controls.Count > 0)
            {
                chatPanel.Controls.RemoveAt(0);
            }
            chatPanel.Controls.Add(startChattingLbl);
            timer1.Enabled = true;
            friendNameBar.Enabled = false;
            friendNameBar.Visible = false;
            chatFeaturesCb.Visible = false;
            messageTb.Visible = false;
            sendMessageBtn.Visible = false;
            loadChats();
        }

        private void Chats_Load(object sender, EventArgs e)
        {
            chatPanel = new CustomPanel();
            chatPanel.Name = "chatContainer";
            chatPanel.Width = 465;
            chatPanel.Height = 407;
            chatPanel.Left = 487;
            chatPanel.Top = 31;
            chatPanel.BackColor = Color.FromArgb(192, 255, 255);
            chatPanel.AutoScroll = true;
            chatPanel.MouseWheel += chatContainer_MouseWheel;
            this.Controls.Remove(chatContainer);
            this.Controls.Add(chatPanel);
            scrollValue = chatPanel.DisplayRectangle.Height;
            loadForm();
        }

        private void contactsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacts contactsForm = new Contacts(user);
            contactsForm.ShowDialog();
            this.Close();
        }

        private void searchFriendsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUser searchUserForm = new SearchUser(user);
            searchUserForm.ShowDialog();
            this.Close();
        }

        private void profileTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profileForm = new Profile(user);
            profileForm.ShowDialog();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void loadColor()
        {
            foreach (Control btn in friendsContainer.Controls)
            {
                if (btn is Button)
                {
                    btn.BackColor = Color.White;
                }
            }
        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            string image = ((PictureBox)sender).ImageLocation;
            ProfileImage profileImage = new ProfileImage(image, Color.FromArgb(192, 255, 255));
            profileImage.ShowDialog();
        }

        private void loadChats()
        {
            while (friendsContainer.Controls.Count > 0)
            {
                friendsContainer.Controls.RemoveAt(0);
            }
            MySqlCommand cmd = new MySqlCommand($"SELECT c.id AS chat_id, u.* FROM chats c JOIN users u ON c.friend_id = u.id JOIN friends f ON f.user_id = c.user_id WHERE c.user_id = {user.Id} AND f.blocked = 0", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            int ctr = 1;
            while (reader.Read())
            {
                User friend = new User(
                    reader.GetString("name"),
                    reader.GetString("email"),
                    reader.GetString("username"),
                    reader.GetString("password")
                );
                friend.Id = reader.GetInt32("id");
                friend.ProfileImage = reader.GetString("profile_image");
                if (friend.Id != user.Id)
                {
                    int chat_id = reader.GetInt32("chat_id");
                    Button button = new Button();
                    button.Name = "chat-" + chat_id.ToString() + "-" + friend.Id.ToString();
                    button.Text = friend.Name;
                    button.Width = 394;
                    button.Height = 83;
                    button.Left = 0;
                    button.Top = button.Height * (ctr - 1);
                    button.BackColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Black;
                    FontStyle fontStyle = FontStyle.Bold;
                    Font font = new Font("Arial", 20, fontStyle);
                    button.Font = font;
                    button.Click += chat_Click;
                    friendsContainer.Controls.Add(button);
                    PictureBox pb = new PictureBox();
                    pb.Name = "profileImage" + friend.Id.ToString();
                    pb.Width = 75;
                    pb.Height = 75;
                    pb.Left = 7;
                    pb.Top = button.Height * (ctr - 1) + 5;
                    pb.BackColor = Color.FromArgb(192, 255, 255);
                    pb.ImageLocation = friend.ProfileImage;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += profileImage_Click;
                    friendsContainer.Controls.Add(pb);
                    button.SendToBack();
                    if (friend.Id == friendId)
                    {
                        friendBtn = button;
                    }
                    ctr++;
                }
            }
            reader.Close();
            if (ctr <= 1)
            {
                friendsContainer.Controls.Add(noChatsLbl);
            }
            if (friendId != -1)
            {
                loadMessages(friendBtn);
            }
        }

        private void loadMessages(object sender)
        {
            while (chatPanel.Controls.Count > 0)
            {
                chatPanel.Controls.RemoveAt(0);
            }
            if (sender != null)
            {
                startChattingLbl.Visible = false;
                friendNameBar.Visible = true;
                chatFeaturesCb.Visible = true;
                messageTb.Visible = true;
                sendMessageBtn.Visible = true;
                loadColor();
                clickedBtn = (Button)sender;
                clickedBtn.BackColor = Color.WhiteSmoke;
                string senderName = clickedBtn.Name;
                string[] split = senderName.Split('-');
                friendId = int.Parse(split[2]);
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users WHERE id = {friendId}", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                User friend = new User(
                    dt.Rows[0]["name"].ToString(),
                    dt.Rows[0]["username"].ToString(),
                    dt.Rows[0]["email"].ToString(),
                    dt.Rows[0]["password"].ToString()
                );
                friend.Id = (int)dt.Rows[0]["id"];
                chosenFriend = friend;
                friendNameBar.Text = friend.Name;
                int chatId = int.Parse(split[1]);
                chosenChatId = chatId;
                cmd = new MySqlCommand($"SELECT * FROM messages WHERE chat_id = {chosenChatId}", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int top = 0;
                while (reader.Read())
                {
                    Message message = new Message(
                        reader.GetInt32("chat_id"),
                        reader.GetString("content"),
                        reader.GetInt32("sender")
                    );
                    message.Id = reader.GetInt32("id");
                    Button button = new Button();
                    button.Text = message.Content;
                    button.Enabled = false;
                    string content = button.Text;
                    button.Width = 112;
                    button.Height = 34 + 34 * (content.Length / 9);
                    button.Top = top + 10;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Black;
                    Font font = new Font("Arial", 9);
                    button.Font = font;
                    if (message.Sender == user.Id)
                    {
                        button.BackColor = Color.Lime;
                        button.FlatAppearance.BorderColor = Color.Lime;
                        button.Left = 310;
                    }
                    else
                    {
                        button.BackColor = Color.WhiteSmoke;
                        button.FlatAppearance.BorderColor = Color.WhiteSmoke;
                        button.Left = 7;
                    }
                    chatPanel.Controls.Add(button);
                    top += (button.Height + 10);
                }
                reader.Close();
                if (fullScroll)
                {
                    scrollValue = chatPanel.DisplayRectangle.Height;
                }
                chatPanel.AutoScrollPosition = new Point(0, scrollValue);
            }
            else
            {
                startChattingLbl.Visible = true;
                friendNameBar.Visible = false;
                chatFeaturesCb.Visible = false;
                messageTb.Visible = false;
                sendMessageBtn.Visible = false;
            }
        }

        private void chat_Click(object sender, EventArgs e)
        {
            scrollValue = chatPanel.DisplayRectangle.Height;
            clickedBtn = (Button)sender;
            loadMessages(clickedBtn);
        }

        private void chatContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            scrollValue = chatPanel.VerticalScroll.Value;
            if (chatPanel.Height + scrollValue < chatPanel.DisplayRectangle.Height)
            {
                fullScroll = false;
            }
            else
            {
                fullScroll = true;
            }
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            string content = messageTb.Text;
            if (content.Trim() != "")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM chats WHERE user_id = {user.Id} AND friend_id = {chosenFriend.Id}", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Chat chat = new Chat(
                    (int)dt.Rows[0]["user_id"],
                    (int)dt.Rows[0]["friend_id"]
                );
                chat.Id = (int)dt.Rows[0]["id"];
                cmd = new MySqlCommand($"INSERT INTO messages VALUES (0, {chat.Id}, @content, {user.Id})", conn);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand($"SELECT blocked FROM friends WHERE user_id = {chosenFriend.Id} AND friend_id = {user.Id}", conn);
                bool blocked = (bool)cmd.ExecuteScalar();
                if (!blocked)
                {
                    cmd = new MySqlCommand($"SELECT * FROM chats WHERE user_id = {chosenFriend.Id} AND friend_id = {user.Id}", conn);
                    da = new MySqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    chat = null;
                    if (dt.Rows.Count > 0)
                    {
                        chat = new Chat(
                            (int)dt.Rows[0]["user_id"],
                            (int)dt.Rows[0]["friend_id"]
                        );
                        chat.Id = (int)dt.Rows[0]["id"];
                    }
                    if (chat == null)
                    {
                        cmd = new MySqlCommand($"INSERT INTO chats VALUES (0, {chosenFriend.Id}, {user.Id})", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new MySqlCommand($"SELECT * FROM chats WHERE user_id = {chosenFriend.Id} AND friend_id = {user.Id}", conn);
                        da = new MySqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        chat = new Chat(
                            (int)dt.Rows[0]["user_id"],
                            (int)dt.Rows[0]["friend_id"]
                        );
                        chat.Id = (int)dt.Rows[0]["id"];
                    }
                    cmd = new MySqlCommand($"INSERT INTO messages VALUES (0, {chat.Id}, @content, {user.Id})", conn);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.ExecuteNonQuery();
                }
                messageTb.Text = "";
                loadMessages(clickedBtn);
                chatPanel.AutoScrollPosition = new Point(0, scrollValue);
            }
        }

        private void chatFeaturesCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string option = (string)chatFeaturesCb.SelectedItem;
            if (option == "Clear chat")
            {
                if (MessageBox.Show("Are you sure you want clear chat with " + chosenFriend.Username + "?", "Clear chat confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM messages WHERE chat_id = {chosenChatId}", conn);
                    cmd.ExecuteNonQuery();
                    chosenChatId = -1;
                    loadMessages(clickedBtn);
                }
            }
            else if (option == "Delete chat")
            {
                if (MessageBox.Show("Are you sure you want delete chat with " + chosenFriend.Username + "?", "Delete chat confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM chats WHERE id = {chosenChatId}", conn);
                    cmd.ExecuteNonQuery();
                    friendId = -1;
                    chosenChatId = -1;
                    clickedBtn = null;
                    loadMessages(clickedBtn);
                    loadForm();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clickedBtn != null)
            {
                loadMessages(clickedBtn);
            }
        }
    }
}

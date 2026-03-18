using System.Data;
using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class Contacts : Form
    {
        private MySqlConnection conn;
        private User user;
        public Contacts(User user)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.user = user;
        }

        public void load(string search = "")
        {
            while (friendsContainer.Controls.Count > 0)
            {
                friendsContainer.Controls.RemoveAt(0);
            }
            MySqlCommand cmd = new MySqlCommand($"SELECT u.*, f.blocked FROM friends f JOIN users u ON f.friend_id = u.id WHERE f.user_id = {user.Id} AND u.name LIKE @search", conn);
            cmd.Parameters.AddWithValue("@search", "%" + search + "%");
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
                sbyte blocked = reader.GetSByte("blocked");
                Button button = new Button();
                button.Name = "friend-" + friend.Id.ToString();
                button.Text = friend.Name;
                if (blocked == 1)
                {
                    button.Text += " (Blocked)";
                }
                button.Width = 704;
                button.Height = 84;
                button.Left = 0;
                button.Top = button.Height * (ctr - 1) + 1;
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Black;
                FontStyle fontStyle = FontStyle.Bold;
                Font font = new Font("Arial", 20, fontStyle);
                button.Font = font;
                button.Click += friend_Click;
                friendsContainer.Controls.Add(button);
                PictureBox pb = new PictureBox();
                pb.Name = "profileImage" + friend.Id.ToString();
                pb.Width = 75;
                pb.Height = 75;
                pb.Left = 7;
                pb.Top = button.Height * (ctr - 1) + 5;
                pb.BackColor = Color.Cyan;
                pb.ImageLocation = friend.ProfileImage;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click += profileImage_Click;
                friendsContainer.Controls.Add(pb);
                button.SendToBack();
                ctr++;
            }
            reader.Close();
            if (ctr <= 1)
            {
                friendsContainer.Controls.Add(noFriendsLbl);
            }
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            load();
        }

        private void chatsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chats chatsForm = new Chats(user);
            chatsForm.ShowDialog();
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

        private void friend_Click(object sender, EventArgs e)
        {
            string senderName = ((Button)sender).Name;
            string[] split = senderName.Split('-');
            int friendId = int.Parse(split[1]);
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users WHERE id = {friendId}", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            User friend = null;
            if (dt.Rows.Count > 0)
            {
                friend = new User(
                    dt.Rows[0]["name"].ToString(),
                    dt.Rows[0]["username"].ToString(),
                    dt.Rows[0]["email"].ToString(),
                    dt.Rows[0]["password"].ToString()
                );
                friend.Id = (int)dt.Rows[0]["id"];
            };
            ContactPopup contactPopup = new ContactPopup(this, user, friend);
            contactPopup.ShowDialog();
        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            string image = ((PictureBox)sender).ImageLocation;
            ProfileImage profileImage = new ProfileImage(image, Color.Cyan);
            profileImage.ShowDialog();
        }

        private void searchFriendsTb_TextChanged(object sender, EventArgs e)
        {
            load(searchFriendsTb.Text);
        }
    }
}

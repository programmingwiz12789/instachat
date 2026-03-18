using System.Data;
using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class SearchUser : Form
    {
        private MySqlConnection conn;
        private User user;
        private int addFriendId;
        public SearchUser(User user)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.user = user;
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            friendUsernameLbl.Text = "";
            addFriendBtn.Visible = false;
            addFriendId = -1;
        }

        private void chatsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chats chatsForm = new Chats(user);
            chatsForm.ShowDialog();
            this.Close();
        }

        private void contactsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacts contactsForm = new Contacts(user);
            contactsForm.ShowDialog();
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

        private void searchFriendBtn_Click(object sender, EventArgs e)
        {
            string friendUsername = friendUsernameTb.Text;
            if (friendUsername.Trim() != "")
            {
                friendUsernameLbl.Text = "Loading...";
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users WHERE username = @friendUsername AND username != @username", conn);
                cmd.Parameters.AddWithValue("@friendUsername", friendUsername);
                cmd.Parameters.AddWithValue("@username", user.Username);
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
                }
                if (friend != null)
                {
                    friendUsernameLbl.Text = friend.Username;
                    addFriendBtn.Visible = true;
                    cmd = new MySqlCommand($"SELECT COUNT(*) FROM friends WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
                    Int64 count = (Int64)cmd.ExecuteScalar();
                    if (count <= 0)
                    {
                        addFriendId = friend.Id;
                        addFriendBtn.Text = "Add";
                        addFriendBtn.Enabled = true;
                    }
                    else
                    {
                        addFriendId = -1;
                        addFriendBtn.Text = "Added";
                        addFriendBtn.Enabled = false;
                    }
                }
                else
                {
                    friendUsernameLbl.Text = "Username not found";
                    addFriendBtn.Visible = false;
                    addFriendId = -1;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void addFriendBtn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO friends VALUES (0, {user.Id}, {addFriendId}, 0)", conn);
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand($"INSERT INTO friends VALUES (0, {addFriendId}, {user.Id}, 0)", conn);
            cmd.ExecuteNonQuery();
            addFriendId = -1;
            addFriendBtn.Text = "Added";
            addFriendBtn.Enabled = false;
            MessageBox.Show("Friend added successfully");
        }
    }
}

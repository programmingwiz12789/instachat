using System.Data;
using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class ContactPopup : Form
    {
        private MySqlConnection conn;
        private Contacts contactForm;
        private User user, friend;
        private bool blocked;
        public ContactPopup(Contacts contactForm, User user, User friend)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.contactForm = contactForm;
            this.user = user;
            this.friend = friend;
        }

        private void ContactPopup_Load(object sender, EventArgs e)
        {
            friendNameLbl.Text = friend.Name;
            friendUsernameLbl.Text = friend.Username;
            MySqlCommand cmd = new MySqlCommand($"SELECT blocked FROM friends WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
            blocked = (bool)cmd.ExecuteScalar();
            if (blocked)
            {
                chatBtn.Enabled = false;
                blockFriendBtn.Text = "Unblock";
            }
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM chats WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Chat chat = null;
            if (dt.Rows.Count > 0)
            {
                chat = new Chat(
                    (int)dt.Rows[0]["user_id"],
                    (int)dt.Rows[0]["friend_id"]
                );
            }
            if (chat == null)
            {
                cmd = new MySqlCommand($"INSERT INTO chats VALUES (0, {user.Id}, {friend.Id})", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand($"INSERT INTO chats VALUES (0, {friend.Id}, {user.Id})", conn);
                cmd.ExecuteNonQuery();
            }
            this.Close();
            contactForm.Hide();
            Chats chats = new Chats(user, friend.Id);
            chats.ShowDialog();
            contactForm.Close();
        }

        private void blockFriendBtn_Click(object sender, EventArgs e)
        {
            if (!blocked)
            {
                if (MessageBox.Show("Are you sure you want to block friend " + friend.Username + "?", "Block friend confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE friends SET blocked = 1 WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand($"DELETE FROM chats WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
                    cmd.ExecuteNonQuery();
                    this.Close();
                    contactForm.load();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to unblock friend " + friend.Username + "?", "Unblock friend confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"UPDATE friends SET blocked = 0 WHERE user_id = {user.Id} AND friend_id = {friend.Id}", conn);
                    cmd.ExecuteNonQuery();
                    this.Close();
                    contactForm.load();
                }
            }
        }

        private void deleteFriendBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete friend " + friend.Username + "?", "Delete friend confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM friends WHERE (user_id = {user.Id} AND friend_id = {friend.Id}) OR (user_id = {friend.Id} AND friend_id = {user.Id})", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand($"DELETE FROM chats WHERE (user_id = {user.Id} AND friend_id = {friend.Id}) OR (user_id = {friend.Id} AND friend_id = {user.Id})", conn);
                cmd.ExecuteNonQuery();
                this.Close();
                contactForm.load();
            }
        }
    }
}

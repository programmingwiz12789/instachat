using System.Data;
using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class Login : Form
    {
        private MySqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = DB.Connect();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTb.Text;
            string password = passwordTb.Text;
            if (email.Trim() != "" && password.Trim() != "")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM users WHERE email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                User user = null;
                if (dt.Rows.Count > 0)
                {
                    user = new User(
                        dt.Rows[0]["name"].ToString(),
                        dt.Rows[0]["username"].ToString(),
                        dt.Rows[0]["email"].ToString(),
                        dt.Rows[0]["password"].ToString()
                    );
                    user.Id = (int)dt.Rows[0]["id"];
                    user.Birthdate = dt.Rows[0]["birthdate"].ToString();
                    user.Bio = dt.Rows[0]["bio"].ToString();
                    user.Gender = sbyte.Parse(dt.Rows[0]["gender"].ToString());
                    user.StatusMessage = dt.Rows[0]["status_message"].ToString();
                    user.ProfileImage = dt.Rows[0]["profile_image"].ToString();
                }
                if (user != null)
                {
                    if (Utils.hashPassword(password) == user.Password)
                    {
                        this.Hide();
                        Chats chats = new Chats(user);
                        chats.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                }
                else
                {
                    MessageBox.Show("Email not found");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void hereLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regForm = new Register();
            regForm.ShowDialog();
            this.Close();
        }

        private void here2Lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterEmail enterPhoneNumber = new EnterEmail();
            enterPhoneNumber.ShowDialog();
            this.Close();
        }
    }
}
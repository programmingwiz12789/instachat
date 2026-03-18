using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class Register : Form
    {
        private MySqlConnection conn;
        public Register()
        {
            InitializeComponent();
            conn = DB.Connect();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string name = nameTb.Text;
            string username = usernameTb.Text;
            string email = emailTb.Text;
            string password = passwordTb.Text;
            string confirmPassword = confirmPasswordTb.Text;
            if (name.Trim() != "" && username.Trim() != "" && email.Trim() != "" && password.Trim() != "")
            {
                if (name.Length <= 30 && username.Length <= 30 && password.Length <= 30)
                {
                    if (email.Length >= 10 && email.Length <= 40)
                    {
                        if (password == confirmPassword)
                        {
                            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM users WHERE username = @username", conn);
                            cmd.Parameters.AddWithValue("@username", username);
                            Int64 count = (Int64)cmd.ExecuteScalar();
                            if (count <= 0)
                            {
                                cmd = new MySqlCommand($"SELECT COUNT(*) FROM users WHERE email = @email", conn);
                                cmd.Parameters.AddWithValue("@email", email);
                                count = (Int64)cmd.ExecuteScalar();
                                if (count <= 0)
                                {
                                    User unverifiedUser = new User(name, username, email, password);
                                    string code = "";
                                    for (int i = 0; i < 4; i++)
                                    {
                                        Random rn = new Random();
                                        char digit = (char)(rn.Next(0, 10) + '0');
                                        code += digit;
                                    }
                                    Utils.sendMessage(email, "Verification Code", "Verification code: " + code);
                                    this.Hide();
                                    EnterCode enterCode = new EnterCode(unverifiedUser, code);
                                    enterCode.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Email number already registered");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already registered");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email must be 10-40 characters");
                    }
                }
                else
                {
                    MessageBox.Show("Name, username, and password must be at most 30 characters");
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
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}

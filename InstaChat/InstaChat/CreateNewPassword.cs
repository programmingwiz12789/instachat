using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class CreateNewPassword : Form
    {
        private MySqlConnection conn;
        private string email;
        public CreateNewPassword(string email)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.email = email;
        }

        private void CreateNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string password = newPasswordTb.Text;
            string confirmPassword = confirmPasswordTb.Text;
            if (password.Trim() != "")
            {
                if (password == confirmPassword)
                {
                    if (password.Length <= 30)
                    {
                        MySqlCommand cmd = new MySqlCommand($"UPDATE users SET password = @password WHERE email = @email", conn);
                        cmd.Parameters.AddWithValue("@password", Utils.hashPassword(password));
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                        this.Hide();
                        Login loginForm = new Login();
                        loginForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password must be at most 30 characters");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}

using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class EnterCode : Form
    {
        private MySqlConnection conn;
        private User unverifiedUser;
        private string code;
        public EnterCode(User unverifiedUser, string code)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.unverifiedUser = unverifiedUser;
            this.code = code;
        }

        private void EnterCode_Load(object sender, EventArgs e)
        {
            this.ActiveControl = digit1;
        }

        private void digit1_TextChanged(object sender, EventArgs e)
        {
            string text = digit1.Text;
            if (text.Length == 1 && text[0] >= '0' && text[0] <= '9')
            {
                digit2.Focus();
            }
            else if (text == "")
            {
                
            }
            else
            {
                digit1.Text = digit1.Text.Substring(0, 1);
            }
        }

        private void digit2_TextChanged(object sender, EventArgs e)
        {
            string text = digit2.Text;
            if (text.Length == 1 && text[0] >= '0' && text[0] <= '9')
            {
                digit3.Focus();
            }
            else if (text == "")
            {
                digit1.Focus();
            }
            else
            {
                digit2.Text = digit2.Text.Substring(0, 1);
            }
        }

        private void digit3_TextChanged(object sender, EventArgs e)
        {
            string text = digit3.Text;
            if (text.Length == 1 && text[0] >= '0' && text[0] <= '9')
            {
                digit4.Focus();
            }
            else if (text == "")
            {
                digit2.Focus();
            }
            else
            {
                digit3.Text = digit3.Text.Substring(0, 1);
            }
        }

        private void digit4_TextChanged(object sender, EventArgs e)
        {
            string text = digit4.Text;
            if (text.Length == 1 && text[0] >= '0' && text[0] <= '9')
            {
                
            }
            else if (text == "")
            {
                digit3.Focus();
            }
            else
            {
                digit4.Text = digit4.Text.Substring(0, 1);
            }
        }

        private void digit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (digit2.Focused)
                {
                    digit1.Focus();
                }
                else if (digit3.Focused)
                {
                    digit2.Focus();
                }
                else if (digit4.Focused)
                {
                    digit3.Focus();
                }
            }
        }

        private void verifyCodeBtn_Click(object sender, EventArgs e)
        {
            string enteredCode = digit1.Text + digit2.Text + digit3.Text + digit4.Text;
            if (enteredCode.Length == 4)
            {
                if (enteredCode == code)
                {
                    MySqlCommand cmd = new MySqlCommand($"INSERT INTO users VALUES (0, @name, @username, @email, @password, '', '', -1, '', '')", conn);
                    cmd.Parameters.AddWithValue("@name", unverifiedUser.Name);
                    cmd.Parameters.AddWithValue("@username", unverifiedUser.Username);
                    cmd.Parameters.AddWithValue("@email", unverifiedUser.Email);
                    cmd.Parameters.AddWithValue("@password", Utils.hashPassword(unverifiedUser.Password));
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Code does not match");
                }
            }
            else
            {
                MessageBox.Show("Please enter the verification code");
            }
        }
    }
}

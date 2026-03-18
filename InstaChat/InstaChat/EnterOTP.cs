using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class EnterOTP : Form
    {
        private MySqlConnection conn;
        private string email, otp;
        public EnterOTP(string email, string otp)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.email = email;
            this.otp = otp;
        }

        private void EnterOTP_Load(object sender, EventArgs e)
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

        private void verifyOTPBtn_Click(object sender, EventArgs e)
        {
            string enteredOTP = digit1.Text + digit2.Text + digit3.Text + digit4.Text;
            if (enteredOTP.Length == 4)
            {
                if (enteredOTP == otp)
                {
                    this.Hide();
                    CreateNewPassword createNewPassword = new CreateNewPassword(email);
                    createNewPassword.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("OTP does not match");
                }
            }
            else
            {
                MessageBox.Show("Please enter the OTP");
            }
        }
    }
}

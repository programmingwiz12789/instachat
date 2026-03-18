using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class EnterEmail : Form
    {
        private MySqlConnection conn;
        public EnterEmail()
        {
            InitializeComponent();
            conn = DB.Connect();
        }

        private void EnterEmail_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string email = enterEmailTb.Text;
            if (email.Trim() != "")
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM users WHERE email = @email", conn);
                cmd.Parameters.AddWithValue("@email", email);
                Int64 count = (Int64)cmd.ExecuteScalar();
                if (count > 0)
                {
                    string otp = "";
                    for (int i = 0; i < 4; i++)
                    {
                        Random rn = new Random();
                        char digit = (char)(rn.Next(0, 10) + '0');
                        otp += digit;
                    }
                    Utils.sendMessage(email, "OTP Code", "OTP: " + otp);
                    this.Hide();
                    EnterOTP enterOTP = new EnterOTP(email, otp);
                    enterOTP.ShowDialog();
                    this.Close();
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
    }
}

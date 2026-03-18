using MySql.Data.MySqlClient;

namespace InstaChat
{
    public partial class Profile : Form
    {
        private MySqlConnection conn;
        private User user;
        public Profile(User user)
        {
            InitializeComponent();
            conn = DB.Connect();
            this.user = user;
        }

        private void load(bool b)
        {
            nameTb.Enabled = b;
            birthdateDtp.Enabled = b;
            genderGb.Enabled = b;
            statusMessageTb.Enabled = b;
            bioTb.Enabled = b;
            chooseImageBtn.Enabled = b;
            editProfileBtn.Enabled = !b;
            saveProfileChangesBtn.Enabled = b;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            load(false);
            usernameTb.Enabled = false;
            emailTb.Enabled = false;
            nameTb.Text = user.Name;
            usernameTb.Text = user.Username;
            emailTb.Text = user.Email;
            if (user.Birthdate != "")
            {
                string[] split = user.Birthdate.Split('/');
                int month = int.Parse(split[0]);
                int day = int.Parse(split[1]);
                int year = int.Parse(split[2]);
                DateTime dt = new DateTime(year, month, day);
                birthdateDtp.Value = dt;
            }
            if (user.Gender == 0)
            {
                maleRb.Checked = true;
            }
            else if (user.Gender == 1)
            {
                femaleRb.Checked = true;
            }
            statusMessageTb.Text = user.StatusMessage;
            bioTb.Text = user.Bio;
            imagePb.ImageLocation = user.ProfileImage;
            imagePb.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void searchFriendsTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUser searchUserForm = new SearchUser(user);
            searchUserForm.ShowDialog();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            load(true);
        }

        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            chooseImageFd.InitialDirectory = "C://Desktop";
            chooseImageFd.Title = "Select image to upload";
            chooseImageFd.Filter = "Select Valid Document(*.jpeg; *.jpg; *.png; *.gif)|*.jpeg; *.jpg; *.png; *.gif";
            chooseImageFd.FilterIndex = 2;
            try
            {
                if (chooseImageFd.ShowDialog() == DialogResult.OK)
                {
                    if (chooseImageFd.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(chooseImageFd.FileName);
                        imagePb.ImageLocation = path;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveProfileChangesBtn_Click(object sender, EventArgs e)
        {
            string name = nameTb.Text;
            DateTime dt = birthdateDtp.Value;
            DateTime now = DateTime.Now;
            string birthdate = "";
            if (dt.Month != now.Month || dt.Day != now.Day || dt.Year != now.Year)
            {
                birthdate = dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString();
            }
            int gender = -1;
            if (maleRb.Checked)
            {
                gender = 0;
            }
            else if (femaleRb.Checked)
            {
                gender = 1;
            }
            string statusMessage = statusMessageTb.Text;
            string bio = bioTb.Text;
            string profileImage = imagePb.ImageLocation;
            if (name.Trim() != "")
            {
                if (name.Length <= 30)
                {
                    if (statusMessage.Length <= 40)
                    {
                        if (bio.Length <= 50)
                        {
                            MySqlCommand cmd = new MySqlCommand($"UPDATE users SET name = @name, birthdate = @birthdate, bio = @bio, gender = {gender}, status_message = @status_message, profile_image = @profileImage WHERE id = {user.Id}", conn);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@birthdate", birthdate);
                            cmd.Parameters.AddWithValue("@bio", bio);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@status_message", statusMessage);
                            cmd.Parameters.AddWithValue("@profileImage", profileImage);
                            cmd.ExecuteNonQuery();
                            user.Name = name;
                            user.Birthdate = birthdate;
                            user.Bio = bio;
                            user.Gender = gender;
                            user.StatusMessage = statusMessage;
                            user.ProfileImage = profileImage;
                            load(false);
                            MessageBox.Show("Updated profile successfully");
                        }
                        else
                        {
                            MessageBox.Show("Bio must be at most 50 characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Status message must be at most 40 characters");
                    }
                }
                else
                {
                    MessageBox.Show("Name must be at most 30 characters");
                }
            }
            else
            {
                MessageBox.Show("Name is required");
            }
        }
    }
}

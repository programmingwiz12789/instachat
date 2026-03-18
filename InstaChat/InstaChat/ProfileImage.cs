namespace InstaChat
{
    public partial class ProfileImage : Form
    {
        public ProfileImage(string profileImage, Color color)
        {
            InitializeComponent();
            this.BackColor = color;
            profileImagePb.BackColor = color;
            profileImagePb.ImageLocation = profileImage;
            profileImagePb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ProfileImage_Load(object sender, EventArgs e)
        {

        }
    }
}

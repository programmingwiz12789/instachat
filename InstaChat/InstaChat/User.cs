namespace InstaChat
{
    public class User
    {
        private int id, gender;
        private string name, username, email, password, birthdate, bio, statusMessage, profileImage;
    
        public User(string name, string username, string email, string password)
        {
            this.name = name;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public int Gender { get => gender; set => gender = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Bio { get => bio; set => bio = value; }
        public string StatusMessage { get => statusMessage; set => statusMessage = value; }
        public string ProfileImage { get => profileImage; set => profileImage = value; }
    }
}

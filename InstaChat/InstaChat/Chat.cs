namespace InstaChat
{
    internal class Chat
    {
        private int id, userId, friendId;
        public Chat(int userId, int friendId)
        {
            this.userId = userId;
            this.friendId = friendId;
        }

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public int FriendId { get => friendId; set => friendId = value; }
    }
}

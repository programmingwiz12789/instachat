namespace InstaChat
{
    internal class Message
    {
        private int id, chatId, sender;
        private string content;
        public Message(int chatId, string content, int sender)
        {
            this.chatId = chatId;
            this.content = content;
            this.sender = sender;
        }

        public int Id { get => id; set => id = value; }
        public int ChatId { get => chatId; set => chatId = value; }
        public int Sender { get => sender; set => sender = value; }
        public string Content { get => content; set => content = value; }
    }
}

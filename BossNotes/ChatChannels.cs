namespace BossNotes
{
    public class ChatChannel
    {
        public ChatChannel(string name, string prefix)
        {
            DisplayName = name;
            ChatPrefix = prefix;
        }

        public string DisplayName { get; }
        public string ChatPrefix { get; }

        public string FormatMessage(string message)
        {
            return $"/{ChatPrefix} {message}";
        }
    }
}
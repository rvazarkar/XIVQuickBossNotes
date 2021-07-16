using XivCommon.Functions;

namespace BossNotes
{
    public class ChatChannel
    {
        public string DisplayName { get; private set; }
        public string ChatPrefix { get; private set; }

        public ChatChannel(string name, string prefix)
        {
            DisplayName = name;
            ChatPrefix = prefix;
        }

        public string FormatMessage(string message)
        {
            return $"/{ChatPrefix} {message}";
        }
    }
}
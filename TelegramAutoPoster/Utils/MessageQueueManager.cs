using System.Text.Json;
using TelegramAutoPoster.Models;

namespace TelegramAutoPoster.Utils
{
    public static class MessageQueueManager
    {
        private const string FileName = "messages.json";
        public static List<ScheduledMessage> LoadMessages()
        {
            try
            {
                if (!File.Exists(FileName))
                    return new List<ScheduledMessage>();
                string json = File.ReadAllText(FileName);
                if (string.IsNullOrWhiteSpace(json))
                    return new List<ScheduledMessage>();
                return JsonSerializer.Deserialize<List<ScheduledMessage>>(json) ?? new List<ScheduledMessage>();
            }
            catch
            {
                return new List<ScheduledMessage>();
            }
        }
        public static void SaveMessages(List<ScheduledMessage> messages)
        {
            try
            {
                string json = JsonSerializer.Serialize(messages, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FileName, json);
            }
            catch { }
        }
    }
}

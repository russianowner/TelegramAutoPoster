namespace TelegramAutoPoster.Models
{
    public class AppSettings
    {
        public string? BotToken { get; set; }
        public string? ChatId { get; set; }
        public int IntervalMinutes { get; set; } = 5;
        public bool AutoEnabled { get; set; }
    }
}

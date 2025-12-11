namespace TelegramAutoPoster.Models
{
    public class ScheduledMessage
    {
        public string Text { get; set; } = "";
        public int IntervalMinutes { get; set; } = 5; 
    }
}

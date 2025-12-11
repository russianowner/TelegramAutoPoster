using System.Text;
using System.Text.Json;

namespace TelegramAutoPoster.Services
{
    public static class TelegramService
    {
        private static readonly HttpClient http = new HttpClient();
        public static async Task<bool> SendMessageAsync(string token, string chatId, string text)
        {
            string url = $"https://api.telegram.org/bot{token}/sendMessage";
            var payload = new
            {
                chat_id = chatId,
                text = text,
                parse_mode = "HTML",
                disable_web_page_preview = true
            };
            string json = JsonSerializer.Serialize(payload);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(15));
            var resp = await http.PostAsync(url, content, cts.Token);
            string respText = await resp.Content.ReadAsStringAsync();
            if (!resp.IsSuccessStatusCode)
                throw new Exception();
            return true;
        }
    }
}

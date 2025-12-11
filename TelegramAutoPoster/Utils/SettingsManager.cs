using System;
using System.IO;
using System.Text.Json;
using TelegramAutoPoster.Models;

namespace TelegramAutoPoster.Utils
{
    public static class SettingsManager
    {
        private const string FileName = "settings.json";

        public static AppSettings Load()
        {
            try
            {
                if (!File.Exists(FileName))
                    return new AppSettings();
                string json = File.ReadAllText(FileName);
                if (string.IsNullOrWhiteSpace(json))
                    return new AppSettings();
                return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
            }
            catch
            {
                return new AppSettings();
            }
        }
        public static void Save(AppSettings settings)
        {
            try
            {
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FileName, json);
            }
            catch
            {
            }
        }
    }
}

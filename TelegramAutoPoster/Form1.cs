using TelegramAutoPoster.Models;
using TelegramAutoPoster.Services;
using TelegramAutoPoster.Utils;

namespace TelegramAutoPoster
{
    public partial class Form1 : Form
    {
        private AppSettings settings;
        private List<ScheduledMessage> messages;
        private bool autoRunning = false;

        public Form1()
        {
            InitializeComponent();
            settings = SettingsManager.Load();
            messages = MessageQueueManager.LoadMessages();
            ApplySettingsToUI();
            RefreshMessageList();
        }

        private void ApplySettingsToUI()
        {
            txtToken.Text = settings.BotToken;
            txtChatId.Text = settings.ChatId;
            if (settings.AutoEnabled && messages.Count > 0)
                StartAuto();
            UpdateAutoButton();
        }
        private void SaveSettings()
        {
            settings.BotToken = txtToken.Text.Trim();
            settings.ChatId = txtChatId.Text.Trim();
            settings.AutoEnabled = autoRunning;
            SettingsManager.Save(settings);
        }
        private void RefreshMessageList()
        {
            lstMessages.Items.Clear();
            foreach (var msg in messages)
                lstMessages.Items.Add($"[{msg.IntervalMinutes} мин] {msg.Text}");
        }
        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            string text = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;
            int interval = (int)numInterval.Value;
            messages.Add(new ScheduledMessage { Text = text, IntervalMinutes = interval });
            MessageQueueManager.SaveMessages(messages);
            RefreshMessageList();
            txtMessage.Clear();
        }
        private void btnRemoveMessage_Click(object sender, EventArgs e)
        {
            int index = lstMessages.SelectedIndex;
            if (index >= 0 && index < messages.Count)
            {
                messages.RemoveAt(index);
                MessageQueueManager.SaveMessages(messages);
                RefreshMessageList();
            }
        }
        private void btnToggleAuto_Click(object sender, EventArgs e)
        {
            if (autoRunning)
                StopAuto();
            else
                StartAuto();
            UpdateAutoButton();
            SaveSettings();
        }

        private void UpdateAutoButton()
        {
            btnToggleAuto.Text = autoRunning ? "Выключить авто-постинг" : "Включить авто-постинг";
        }
        private void StartAuto()
        {
            if (messages.Count == 0 || autoRunning) return;
            autoRunning = true;
            _ = AutoPostLoop();
        }
        private async Task AutoPostLoop()
        {
            while (autoRunning && messages.Count > 0)
            {
                var msg = messages[0];
                try
                {
                    await TelegramService.SendMessageAsync(txtToken.Text, txtChatId.Text, msg.Text);
                }
                catch { }
                messages.RemoveAt(0);
                MessageQueueManager.SaveMessages(messages);
                this.Invoke(RefreshMessageList);
                await Task.Delay(msg.IntervalMinutes * 60000);
            }
            StopAuto();
            this.Invoke(UpdateAutoButton);
        }
        private void StopAuto()
        {
            autoRunning = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}

# Telegram Auto Poster
---
- Приложение для автоматической отправки сообщений в Telegram через бота
---
- An application for automatically sending messages to Telegram via a bot
---
## Функциональность
- Добавление и удаление сообщений
- Настройка интервала автопостинга для каждого сообщения
- История сообщений сохраняется между запусками
- Поддержка автопостинга с циклической отправкой сообщений
- Настройки бота (Token и Chat ID) сохраняются
---
## Functionality
- Adding and deleting messages
- Setting the auto-posting interval for each message
- Message history is saved between launches
- Support for autoposting with cyclic message sending
- Bot settings (Token and Chat ID) are saved
---
## Использование
1. Получите токен Telegram-бота через [BotFather](https://t.me/botfather)
2. Узнайте `chat_id` пользователя, группы или канала
3. Запустите приложение и введите:
   - Bot Token
   - Chat ID
   - Сообщение
   - Интервал отправки
4. Нажмите **Добавить** для добавления сообщения в очередь
5. Включите автопостинг кнопкой **Включить авто-постинг**
6. Сообщения будут отправляться по очереди с указанным интервалом
---
## Usage
1. Get a Telegram bot token via [BotFather](https://t.me/botfather )
2. Find out the `chat_id` of the user, group, or channel
3. Launch the application and enter:
   - Bot Token
   - Chat ID
   - Message
   - Sending interval
4. Click **Add** to add a message to the queue.
5. Turn on auto-posting by clicking **Turn on auto-posting**
6. Messages will be sent in turn at the specified interval.
---
## Файлы
- `Form1.cs` — основная логика UI и автопостинга
- `Form1.Designer.cs` — дизайн формы
- `Models/` — модели сообщений и настроек
- `Services/TelegramService.cs` — работа с API Telegram
- `Utils/SettingsManager.cs` и `MessageQueueManager.cs` — сохранение настроек и очереди сообщений
- `messages.json` и `settings.json` — локальное хранение данных (не коммитятся в git)
---
## Files
- `Form1.cs` — the main logic of UI and autoposting
- `Form1.Designer.cs` — form design
- `Models/` — models of messages and settings
- `Services/TelegramService.cs` — working with the Telegram API
- `Utils/SettingsManager.cs` and `MessageQueueManager.cs` — saving settings and message queues
- `messages.json` and `settings.json` — local data storage (not committed in git)
---

![Интерфейс](screenshots/2.png)

---
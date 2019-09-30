using Telegram.Bot;
using Telegram.Bot.Types;

namespace HeraldBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            long chatId = message.Chat.Id;
            int messageId = message.MessageId;

            await client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}
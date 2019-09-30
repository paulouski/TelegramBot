using Telegram.Bot;
using Telegram.Bot.Types;

namespace HeraldBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override void Execute(Message message, TelegramBotClient client)
        {
            long chatId = message.Chat.Id;
            int messageId = message.MessageId;

            client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messageId);
        }
    }
}
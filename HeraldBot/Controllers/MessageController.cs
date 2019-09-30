using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using HeraldBot.Models;
using HeraldBot.Models.Commands;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace HeraldBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")]
        public async Task<OkResult> Update([FromBody]Update update)
        {
            IReadOnlyList<Command> commands = Bot.Commands;
            Message message = update.Message;
            TelegramBotClient client = await Bot.Get();

            foreach (Command command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}

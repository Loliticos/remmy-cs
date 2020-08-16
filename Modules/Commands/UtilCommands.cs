using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace Remmy.Modules.Commands
{
    public class UtilCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Comi o cu de quem tá lendo :/")
                .ConfigureAwait(false);
        }
    }
}

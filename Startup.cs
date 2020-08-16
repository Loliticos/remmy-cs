using DSharpPlus;
using DSharpPlus.CommandsNext;
using Remmy.Modules.Commands;
using System.Threading.Tasks;

namespace Remmy
{
    class Startup
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }

        public async Task StartAsync ()
        {
            DotNetEnv.Env.Load();

            var config = new DiscordConfiguration
            {
                Token = DotNetEnv.Env.GetString("DISCORD_TOKEN"),
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                LogLevel = LogLevel.Info,
                UseInternalLogHandler = true
            };

            Client = new DiscordClient(config);

            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { "=" },
                EnableMentionPrefix = true,
                IgnoreExtraArguments = true
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            /* Registering Commands */
            Commands.RegisterCommands<UtilCommands>();

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }
    }

    public interface ITest
    {
        string id { get; }
    }
}

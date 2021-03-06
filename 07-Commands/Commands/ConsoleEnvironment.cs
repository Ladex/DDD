using System.Collections.Generic;
using Commands.Commands;

namespace Commands
{
    public static class ConsoleEnvironment
    {
        public static Dictionary<string, IConsoleCommand> Commands { get; private set; }
        public static CommandHandler CommandHandler { get; private set; }

        public static void Build()
        {
            Commands = new Dictionary<string, IConsoleCommand>();
            CommandHandler = new CommandHandler();

            RegisterCommands();
            RegisterSpecifications();
        }

        static void RegisterCommands()
        {
            RegisterCommand(new PrintConsoleCommand());
            RegisterCommand(new AddNumbersConsoleCommand());
        }

        static void RegisterCommand(IConsoleCommand command)
        {
            foreach (var key in command.Keys)
            {
                Commands.Add(key, command);
            }
        }

        static void RegisterSpecifications()
        {
            CommandHandler.AddCommandSpecification(new NoSwearWords());
            CommandHandler.AddCommandSpecification(new SumNotGreaterThanOneThousand());
            CommandHandler.AddCommandSpecification(new SumNotDivisibleByOneHundred());
        }
    }
}
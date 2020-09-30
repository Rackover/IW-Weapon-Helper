using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Help : Command
    {
        public override string HelpMessage => "Gives a short description of each command";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            var commands = cli.Commands;
            foreach (var command in commands) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"    {command.name}");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"{(command.command.HelpfulArguments == string.Empty ? string.Empty : $" {command.command.HelpfulArguments}")}");
                Console.Write(" => ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(command.command.HelpMessage);
                Console.WriteLine();
            }
            remainder = arguments;
            return true;
        }
    }
}

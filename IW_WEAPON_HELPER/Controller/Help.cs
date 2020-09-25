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
                cli.Log($"{command.name}{(command.command.HelpfulArguments == string.Empty ? string.Empty : $" {command.command.HelpfulArguments} ")} => {command.command.HelpMessage}");
            }
            remainder = arguments;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Exit : Command
    {
        public override string HelpMessage => "Exits the program gracefully";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            Environment.Exit(0);
            remainder = string.Empty;
            return true;
        }
    }
}

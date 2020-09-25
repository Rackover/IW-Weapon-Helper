using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER
{
    public abstract class Command
    {
        public abstract string HelpMessage { get; }
        public abstract string HelpfulArguments { get; }
        public abstract bool Execute(CommandLineInterface cli, string arguments, out string remainder);
    }
}

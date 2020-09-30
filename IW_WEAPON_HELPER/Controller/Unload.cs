using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Unload : Command
    {
        public override string HelpMessage => "Unloads the loaded RAW file";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            if (cli.currentRawFile == null)
            {
                cli.Warn("No rawfile was loaded! Nothing was unloaded.");
            }

            cli.currentRawFile?.Dispose();
            cli.currentRawFile = null;

            cli.Log($"Unloaded rawfile {cli.currentRawFilePath}");

            cli.currentRawFilePath = null;

            remainder = arguments;

            return true;
        }
    }
}

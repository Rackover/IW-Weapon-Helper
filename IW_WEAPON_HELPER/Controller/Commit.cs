using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Commit : Command
    {
        public override string HelpMessage => "Commits the change in the RAW file to disk";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            if (cli.currentRawFile == null)
            {
                cli.Warn("No rawfile was loaded! Nothing to commit.");
                remainder = string.Empty;
                return false;
            }
            else
            {
                cli.currentRawFile.Dispose();
                cli.currentRawFile = ZipFile.Open(cli.currentRawFilePath, ZipArchiveMode.Update);
                cli.Log($"Committed all changes to rawfile {cli.currentRawFilePath}");
            }

            remainder = arguments;

            return true;
        }
    }
}

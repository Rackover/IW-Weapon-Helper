using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Load : Command
    {
        public override string HelpMessage => "Loads a rawfile (IWD) in memory";
        public override string HelpfulArguments => "<path/to/raw/file>";

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            string rawFilePath = CommandLineInterface.GetFirstString(arguments, out remainder);

            try
            {
                cli.currentRawFile = ZipFile.Open(rawFilePath, ZipArchiveMode.Update);
                cli.currentRawFilePath = rawFilePath;
                cli.Log($"Successfully opened {rawFilePath} for import/export operations");
            }
            catch(System.IO.IOException e)
            {
                cli.Err(e.ToString());
                return false;
            }

            return true;
        }
    }
}

using LouveSystems.CommandLineInterface;
using System.IO.Compression;

namespace IW_WEAPON_HELPER.Controller
{
    class Load : Command
    {
        public override string HelpMessage => "Loads an IWD in memory";
        public override string HelpfulArguments => "<path/to/iwd/file>";

        public override bool Execute(LouveSystems.CommandLineInterface.CommandLineInterface cli, string arguments, out string remainder)
        {
            return Execute(cli as Interface, arguments, out remainder);
        }

        bool Execute(Interface cli, string arguments, out string remainder)
        {
            string rawFilePath = cli.GetFirstString(arguments, out remainder);

            if (rawFilePath.Length == 0)
            {
                cli.Err("Please specify a path to load.");
                return false;
            }

            try
            {
                cli.currentRawFile = ZipFile.Open(rawFilePath, ZipArchiveMode.Update);
                cli.currentRawFilePath = rawFilePath;
                cli.Log($"Successfully opened {rawFilePath} for import/export operations");
            }
            catch (System.IO.IOException e)
            {
                cli.Err(e.ToString());
                return false;
            }

            return true;
        }
    }
}

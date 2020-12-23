using LouveSystems.CommandLineInterface;
using System.IO.Compression;

namespace IW_WEAPON_HELPER.Controller
{
    class Commit : Command
    {
        public override string HelpMessage => "Commits the change in the IWD file to disk";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            return Execute(cli as Interface, arguments, out remainder);
        }

        bool Execute(Interface cli, string arguments, out string remainder)
        {
            if (cli.currentRawFile == null)
            {
                cli.Warn("No iwd file was loaded! Nothing to commit.");
                remainder = string.Empty;
                return false;
            }
            else
            {
                cli.currentRawFile.Dispose();
                cli.currentRawFile = ZipFile.Open(cli.currentRawFilePath, ZipArchiveMode.Update);
                cli.Log($"Committed all changes to iwd file {cli.currentRawFilePath}");
            }

            remainder = arguments;

            return true;
        }
    }
}

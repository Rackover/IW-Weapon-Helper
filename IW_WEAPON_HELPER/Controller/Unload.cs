using LouveSystems.CommandLineInterface;

namespace IW_WEAPON_HELPER.Controller
{
    class Unload : Command
    {
        public override string HelpMessage => "Unloads the loaded IWD file and writes the change on disk";
        public override string HelpfulArguments => string.Empty;

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            return Execute(cli as Interface, arguments, out remainder);
        }

        bool Execute(Interface cli, string arguments, out string remainder)
        {
            if (cli.currentRawFile == null)
            {
                cli.Warn("No iwd file was loaded! Nothing was unloaded.");
            }

            cli.currentRawFile?.Dispose();
            cli.currentRawFile = null;

            cli.Log($"Unloaded iwd file {cli.currentRawFilePath}");

            cli.currentRawFilePath = null;

            remainder = arguments;

            return true;
        }
    }
}

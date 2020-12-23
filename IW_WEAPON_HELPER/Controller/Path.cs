using LouveSystems.CommandLineInterface;
using System.IO;

namespace IW_WEAPON_HELPER.Controller
{
    class Path : Command
    {
        public override string HelpMessage => "Shows the current directory path, or changes it";
        public override string HelpfulArguments => "[<new/path>]";

        public override bool Execute(LouveSystems.CommandLineInterface.CommandLineInterface cli, string arguments, out string remainder)
        {
            if (arguments.Length == 0)
            {
                cli.Log($"We are currently in {Directory.GetCurrentDirectory()}");
                remainder = arguments;
            }
            else
            {
                var newPath = cli.GetFirstString(arguments, out remainder);

                try
                {
                    Directory.SetCurrentDirectory(newPath);
                    cli.Log($"We are now in {Directory.GetCurrentDirectory()}");
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    cli.Err($"The directory or a part of the directory {newPath} could not be found.");
                    return false;
                }
            }
            return true;
        }
    }
}

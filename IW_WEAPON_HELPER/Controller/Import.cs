using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IW_WEAPON_HELPER.Controller
{
    class Import : Command
    {
        public override string HelpMessage => "Imports the given weapon from either XML or JSON";
        public override string HelpfulArguments => $"<path/to/exported/file> <path/in/raw/file>";

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            string weaponPath = CommandLineInterface.GetFirstString(arguments, out remainder);
            string writePath = CommandLineInterface.GetFirstString(remainder, out remainder);

            Model.Weapon weapon;
            if (!File.Exists(weaponPath))
            {
                cli.Err($"Could not find the file {weaponPath}");
                return false;
            }
            string allText = File.ReadAllText(weaponPath);

            switch (System.IO.Path.GetExtension(weaponPath).ToUpper())
            {
                case ".XML":
                    weapon = Model.Weapon.FromXML(allText);
                    break;

                case ".JSON":
                    weapon = Model.Weapon.FromJSON(allText);
                    break;

                default:
                    cli.Err($"Unknown format {System.IO.Path.GetExtension(weaponPath)}, will not read it.");
                    return false;
            }

            var finalPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(weaponPath), System.IO.Path.GetFileNameWithoutExtension(weaponPath));
            var contents = weapon.SerializeToIW();

            if (cli.currentRawFile == null)
            {
                File.WriteAllText(finalPath, contents);
            }
            else
            {
                cli.currentRawFile.GetEntry(writePath).Delete();
                var entry = cli.currentRawFile.CreateEntry(writePath);
                using (var stream = entry.Open())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(contents);
                    }
                }
            }

            cli.Log($"Successfully wrote output file to {finalPath}. Don't forget to COMMIT to validate the changes.");
            return true;
        }
    }
}

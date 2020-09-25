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
        public override string HelpfulArguments => $@"{"\""}<path\to\weapon\file.json/xml>{"\""}";

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            string weaponPath = arguments.Split('"')[1];
            remainder = arguments.Substring(arguments.IndexOf('"', arguments.IndexOf('"')+1)+1);

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

            var finalPath = Path.Combine(Path.GetDirectoryName(weaponPath), Path.GetFileNameWithoutExtension(weaponPath));
            var contents = weapon.SerializeToIW();

            File.WriteAllText(finalPath, contents);

            cli.Log($"Successfully wrote output file to {finalPath}");
            return true;
        }
    }
}

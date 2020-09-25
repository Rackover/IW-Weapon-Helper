using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER.Controller
{
    class Export : Command
    {
        public override string HelpMessage => "Exports the given weapon to either XML or JSON";
        public override string HelpfulArguments => $@"{"\""}<path\to\weapon\file>{"\""} <format>";

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            string weaponPath = arguments.Split('"')[1];
            remainder = arguments.Substring(arguments.IndexOf('"', arguments.IndexOf('"') + 1) + 2);
            int remains = remainder.IndexOf(' ');
            string format = remains < 0 ? remainder : remainder.Substring(0, remains);
            remainder = remains < 0 ? string.Empty : remainder.Substring(format.Length+1);

            Model.Weapon weapon;
            if (!File.Exists(weaponPath))
            {
                cli.Err($"Could not find the file {weaponPath}");
                return false;
            }

            if (System.IO.Path.GetExtension(weaponPath).Length > 0)
            {
                cli.Err($"Wrong format for file {System.IO.Path.GetFileName(weaponPath)}");
                return false;
            }

            string allText = File.ReadAllText(weaponPath);

            weapon = Model.Weapon.FromIW(allText, cli.Warn);
            cli.Log($"Successfully loaded {Path.GetFileName(weaponPath)}");

            var finalPath = weaponPath + "." + format;
            switch (format.ToUpper())
            {
                case "XML":
                    File.WriteAllText(finalPath, weapon.SerializeToXML());
                    break;

                case "JSON":
                    File.WriteAllText(finalPath, weapon.SerializeToJSON());
                    break;

                default:
                    cli.Err($"No valid output format given for {System.IO.Path.GetFileName(weaponPath)}, will not write anything to disk.");
                    return false;
            }

            cli.Log($"Successfully wrote output file to {finalPath}");
            return true;
        }
    }
}

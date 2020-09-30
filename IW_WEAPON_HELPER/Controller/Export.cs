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
        public override string HelpfulArguments => $"<path/to/weapon/inside/iwd> <format>";

        public override bool Execute(CommandLineInterface cli, string arguments, out string remainder)
        {
            string weaponPath = CommandLineInterface.GetFirstString(arguments, out remainder);
            if (weaponPath.Length == 0)
            {
                cli.Err("Please specify a weapon path to export");
                return false;
            }

            string format = CommandLineInterface.GetFirstString(remainder, out remainder);
            if (format.Length == 0)
            {
                cli.Err("Please specify a format for the exported file, either XML or JSON");
                return false;
            }

            /*
            if (arguments.Length <= secondMarker + 1)
            {
                cli.Err("Please supply a valid format for the exported file");
                remainder = string.Empty;
                return false;
            }

            remainder = arguments.Substring(secondMarker + 2);
            */


            Model.Weapon weapon;
            string allText;
            if (cli.currentRawFile != null)
            {
                var entry = cli.currentRawFile.GetEntry(weaponPath); 
                if (entry == null)
                {
                    cli.Err($"Could not find the file {weaponPath} in loaded iwd file");
                    return false;
                }
                else
                {
                    using (var stream = cli.currentRawFile.GetEntry(weaponPath).Open())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            allText = reader.ReadToEnd();
                        }
                    }
                }
            }
            else
            {
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

                allText = File.ReadAllText(weaponPath);

            }


            weapon = Model.Weapon.FromIW(allText, cli.Warn);
            cli.Log($"Successfully loaded {System.IO.Path.GetFileName(weaponPath)}");

            var finalPath = System.IO.Path.GetFileName(weaponPath) + "." + format;
            string output;
            switch (format.ToUpper())
            {
                case "XML":
                    output = weapon.SerializeToXML();
                    break;

                case "JSON":
                    output = weapon.SerializeToJSON();
                    break;

                default:
                    cli.Err($"No valid output format given for {System.IO.Path.GetFileName(weaponPath)} ({format}), will not write anything to disk.");
                    return false;
            }

            File.WriteAllText(finalPath, output);

            cli.Log($"Successfully wrote output file to {finalPath}");
            return true;
        }
    }
}

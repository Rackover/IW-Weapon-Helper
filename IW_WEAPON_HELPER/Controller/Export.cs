using LouveSystems.CommandLineInterface;
using System.IO;

namespace IW_WEAPON_HELPER.Controller
{
    class Export : Command
    {
        public override string HelpMessage => "Exports the given weapon to either XML or JSON";
        public override string HelpfulArguments => $"<path/to/weapon/inside/iwd> <format>";

        public override bool Execute(LouveSystems.CommandLineInterface.CommandLineInterface cli, string arguments, out string remainder)
        {
            return Execute(cli as Interface, arguments, out remainder);
        }

        bool Execute(Interface cli, string arguments, out string remainder)
        {
            string weaponPath = cli.GetFirstString(arguments, out remainder);
            if (weaponPath.Length == 0)
            {
                cli.Err("Please specify a weapon path to export");
                return false;
            }

            string format = cli.GetFirstString(remainder, out remainder);
            if (format.Length == 0)
            {
                cli.Err("Please specify a format for the exported file, either XML or JSON");
                return false;
            }

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

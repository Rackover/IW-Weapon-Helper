using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER
{
    public class CommandLineInterface
    {
        const string WELCOME_MESSAGE = 
@"Welcome to the IW Weapon Helper command interface! Type HELP to get a list of commands.
Press ENTER to submit a command.
rackover@louve.systems (2020)";

        const char STRING_ENCLOSURE = '"';
        const char ARGUMENT_SEPARATOR = ' ';
        const char COMMAND_SEPARATOR = ' ';

        public ZipArchive currentRawFile;
        public string currentRawFilePath;

        public IReadOnlyList<(string name, Command command)> Commands
        {
            get
            {
                return commands.Select(o => (o.Key, o.Value)).ToList().AsReadOnly();
            }
        }

        static Dictionary<string, Command> commands = new Dictionary<string, Command>();

        public CommandLineInterface(params string[] args)
        {
            commands.Add("HELP", new Controller.Help());
            commands.Add("PATH", new Controller.Path());
            commands.Add("EXIT", new Controller.Exit());
            commands.Add("EXPORT", new Controller.Export());
            commands.Add("IMPORT", new Controller.Import());
            commands.Add("LOAD", new Controller.Load());
            commands.Add("UNLOAD", new Controller.Unload());
            commands.Add("COMMIT", new Controller.Commit());

            commands.Add("?", commands["HELP"]);

            string initialCommand = args.Length <= 1 ? null : string.Join(""+ARGUMENT_SEPARATOR, args.Skip(1));
            Run(initialCommand);
        }

        void Run(string initialCommand = null)
        {
            Log(WELCOME_MESSAGE);

            // Block thread
            while (true)
            {
                Console.Write("> ");
                string typedCommand = initialCommand ?? Console.ReadLine();
                if (initialCommand == null) Log();
                initialCommand = null;
                typedCommand.Replace('\n', COMMAND_SEPARATOR);

                while (typedCommand.Length > 0)
                {
                    var spacePosition = typedCommand.IndexOf(COMMAND_SEPARATOR);
                    string arguments = string.Empty;
                    if (spacePosition > 0)
                    {
                        arguments = typedCommand.Substring(spacePosition+1);
                        typedCommand = typedCommand.Substring(0, spacePosition);
                    }

                    if (commands.TryGetValue(typedCommand.ToUpper(), out Command command))
                    {
                        /*
                        try
                        {
                        */
                            if (!command.Execute(this, arguments, out typedCommand))
                            {
                                typedCommand = string.Empty;
                            }
                        /*
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Err("Please make sure all given paths are enclosed with \" characters. Execution stopped.");
                            typedCommand = string.Empty;
                        }
                        catch(Exception e)
                        {
                            Err(e.ToString());
                            typedCommand = string.Empty;
                        }
                        */
                    }
                    else
                    {
                        Err($"Command not found: {typedCommand.ToUpper()}. Type HELP to get a list of commands.");
                        typedCommand = string.Empty;
                        Log();
                    }
                }
            }
        }

        public void Err(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {message}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"WARNING: {message}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Log(string message="")
        {
            Console.WriteLine(message);
        }

        public static string GetFirstString(string argumentString, out string remainder)
        {
            StringBuilder argumentBuilder = new StringBuilder();
            bool inString = false;
            int limitIndex;
            for (limitIndex = 0; limitIndex < argumentString.Length; limitIndex++)
            {
                char currentCharacter = argumentString[limitIndex];
                if (currentCharacter == ARGUMENT_SEPARATOR)
                {
                    if (!inString)
                    {
                        break;
                    }
                }
                else if (currentCharacter == STRING_ENCLOSURE)
                {
                    if (inString)
                    {
                        inString = false;
                        break;
                    }
                    else
                    {
                        inString = true;
                        continue;
                    }
                }

                argumentBuilder.Append(currentCharacter);
            }

            string firstString = argumentBuilder.ToString();
            remainder = limitIndex == argumentString.Length ? string.Empty : argumentString.Substring(limitIndex+1);

            return firstString;
        }
    }
}

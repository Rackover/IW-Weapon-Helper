using System;
using System.Collections.Generic;
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
            commands.Add("EXIT", new Controller.Exit());
            commands.Add("EXPORT", new Controller.Export());
            commands.Add("IMPORT", new Controller.Import());

            commands.Add("?", commands["HELP"]);

            string initialCommand = args.Length <= 1 ? null : string.Join(" ", args.Skip(1));
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
                initialCommand = null;
                typedCommand.Replace('\n', ' ');

                while (typedCommand.Length > 0)
                {
                    var spacePosition = typedCommand.IndexOf(' ');
                    string arguments = string.Empty;
                    if (spacePosition > 0)
                    {
                        arguments = typedCommand.Substring(spacePosition+1);
                        typedCommand = typedCommand.Substring(0, spacePosition);
                    }

                    if (commands.TryGetValue(typedCommand.ToUpper(), out Command command))
                    {
                        Log();
                        if (!command.Execute(this, arguments, out typedCommand))
                        {
                            typedCommand = string.Empty;
                        }
                        Log();
                    }
                    else
                    {
                        Log();
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
    }
}

using LouveSystems.CommandLineInterface;
using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace IW_WEAPON_HELPER
{
    public class Interface : CommandLineInterface
    {
        public ZipArchive currentRawFile;
        public string currentRawFilePath;


        private static List<(string name, Command command)> commands = new List<(string name, Command command)>()
        {
            (name:"PATH", command:new Controller.Path()),
            (name:"EXPORT", command:new Controller.Export()),
            (name:"IMPORT", command:new Controller.Import()),
            (name:"LOAD", command:new Controller.Load()),
            (name:"UNLOAD", command:new Controller.Unload()),
            (name:"COMMIT", command:new Controller.Commit())
        };

        public Interface(string initialCommand) : base("IW4 WEAPON HELPER CLI", commands: commands, clearDefaultCommands: false)
        {
            SetDefaultCommand("HELP");
            SetDefaultCommand("EXIT");
            Run(initialCommand == null || initialCommand.Length <= 0 ? null : initialCommand);
        }
    }
}

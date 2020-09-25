using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW_WEAPON_HELPER
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Dictionary<string, string> stats = new Dictionary<string, string>();

            var path = @"D:\PROJECTS\IW_WEAPON_HELPER\mp";
            var files = Directory.GetFiles(path);
            float a = 0;
            foreach (var file in files)
            {
                a++;
                Console.WriteLine(file + " "+Math.Floor((a/files.Length)*100)+"%");
                var lines = System.IO.File.ReadAllLines(file);
                if (lines.Length < 2)
                {
                    Console.WriteLine("SKIPPED!");
                    continue;
                }
                var lastLine = lines.Last();

                var elementsList = lastLine.Split(' ');
                var elements = new Queue<string>(elementsList);
                elements.Dequeue();

                var statsLine = string.Join(" ", elements).Substring(elementsList[0].Length + 1);

                var statsArr = statsLine.Split('\\');

                for (int i = 0; i < statsArr.Length - 1; i += 2)
                {
                    try
                    {
                        if (!stats.ContainsKey(statsArr[i]))
                        {
                            Console.WriteLine(statsArr[i] + " => " + statsArr[i + 1]);
                            stats.Add(statsArr[i], statsArr[i + 1]);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine(statsArr.Length);
                    }
                }
            }

            Console.WriteLine("OK");
            Console.WriteLine(stats.Count);

            StringBuilder generatedClass = new StringBuilder();

            foreach (var stat in stats)
            {
                var type = "string";
                if (float.TryParse(stat.Value, out float _)) type = "float?";

                generatedClass.AppendLine("public "+type+" "+stat.Key+";");
            }

            System.IO.File.WriteAllText("output.txt", generatedClass.ToString());

            Console.ReadLine();
            */
            new CommandLineInterface(args);
        }
    }
}

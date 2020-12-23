using System;
using System.Linq;

namespace IW_WEAPON_HELPER
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialCommand = string.Join(" ", args.Skip(1).ToArray());
            new IW_WEAPON_HELPER.Interface(initialCommand);
        }
    }
}

using System;
using System.Linq;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            args = new string[0];

            if(args.Any() && args[0] == "--version")
            {
                Console.WriteLine("0.0.1");
            }
            Console.WriteLine("Hello World!");
        }
    }
}

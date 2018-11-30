using DiscordBot.Storage.Implementations;
using System;
using System.Linq;

namespace DiscordBot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, mom!");

            var ds = new InMemoryStorage();

            IDataStorage ids = ds;
        }
    }
}

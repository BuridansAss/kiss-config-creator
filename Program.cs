using System;
using App;

namespace configs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            ConfigFile.Create(path);
        }
    }
}

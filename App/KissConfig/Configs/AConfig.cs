using System;

namespace App.KissConfig.Configs
{
    public class AConfig : IConfig
    {
        protected readonly string fileName;

        public AConfig(string fileName)
        {
            this.fileName = fileName;
            Console.WriteLine(this.fileName);
        }

        public void work()
        {
            System.Console.WriteLine("its' alive: " + this.fileName);
        }
    }
}
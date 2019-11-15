using System.IO;
using System;

namespace App
{
    public class ConfigFile
    {
        private Stream stream;
        private string path;

        public string Path
        {
            get
            {
                return this.path;
            }

            protected set
            {
                this.path = value;
            }
        }

        protected ConfigFile(string path)
        {
            this.path = path;
            this.stream = File.Create(path);
        }

        public static ConfigFile Create(string path)
        {
            if (isFileExists(path))
            {   
                if (deleteDialog())
                {
                    File.Delete(path);
                }
            }

            ConfigFile file = new ConfigFile(@path);
            
            return file;
        }

        private static bool isFileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }

            return false;
        }

        /**
        * если пользователь ответит ["нет", "н", "no", "n"]
        */
        private static bool deleteDialog()
        {
            Console.WriteLine("такой файл существует, я удаляю текущий?");
            string answer = Console.ReadLine();
            if (AnswerChecker.isNegativeAnswer(answer))
            {
                System.Environment.Exit(1);
            }

            return true;
        }
    }
}
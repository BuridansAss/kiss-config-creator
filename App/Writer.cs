using System.IO;

namespace App
{
    public class Writer
    {
        private StreamWriter sw;

        public StreamWriter Stream
        {
            get
            {
                return this.sw;
            }
        }

        public Writer(string pathToFile)
        {
            this.sw = new StreamWriter(@pathToFile,  true);
        }

        public void printLine(string line)
        {
            
        }

        public void Close()
        {
            this.sw.Close();
        }

        ~Writer()
        {
            this.sw.Close();
        }
    }
}
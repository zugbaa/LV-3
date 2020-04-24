using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Logger
    {
        private static Logger instance;
        private string file;

        public string File
        {   set
            {
                this.file = value;
            }
            get
            {
                return this.file;
            }
        }


        private Logger()
        {
            this.file = (@"C:\Users\dnzug\OneDrive\Desktop\csv.txt");
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void WriteToFile(string message)
        {
            using (StreamWriter writer = new System.IO.StreamWriter(this.file))
            {
                writer.WriteLine(message);
            }
        }
    }

}


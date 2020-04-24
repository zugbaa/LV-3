using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface Prototip
    {
        Prototip Clone();
        Prototip CloneDeep();

        void Print();
    }
    class Dataset : Prototip
    {
        private List<List<string>> data; //list of lists of strings

        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public Dataset(Dataset dataToCopy) : this()
        {

            foreach (List<string> line in dataToCopy.data)
            {
                List<string> rowCopy = new List<string>();
                foreach (string word in line)
                {
                    rowCopy.Add(word);
                }
                this.data.Add(rowCopy);
            }

        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }

        public Prototip Clone()
        {
            return (Prototip)this.MemberwiseClone();
        }

        public Prototip CloneDeep()
        {
            Dataset prototype = new Dataset(this);
            return prototype;
        }
     
        public void Print()
        {
            foreach (List<string> line in this.data)
            {
                foreach (string word in line)
                {
                    Console.WriteLine(word);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.zadatak
            //Dataset data = new Dataset();
            //data.LoadDataFromCSV(@"C:\Users\dnzug\OneDrive\Desktop\csv.txt");

            //Prototip prototype = data;
            //Prototip deepCloned = prototype.CloneDeep();
            //Prototip cloned = prototype.Clone();

            //prototype.Print();
            //deepCloned.Print();



            //2.zadatak
            //int red = Convert.ToInt32(Console.ReadLine());
            //int stupac = Convert.ToInt32(Console.ReadLine());


            //double[][] matrix = new double[red][];
            //double[][] matrix2 = new double[red][];

            //MatricaGenerator matrixGenerator = MatricaGenerator.GetInstance();

            //matrix = matrixGenerator.NapraviMatricu(red, stupac);
            //matrix2 = matrixGenerator.NapraviMatricu(red, stupac);

            //PrintMatricu.Print(matrix);
            //Console.WriteLine();
            //PrintMatricu.Print(matrix2);



            //3.zadatak
            Logger logger = Logger.GetInstance();
            

            logger.WriteToFile("zugbaa");
            


        }
    }
}

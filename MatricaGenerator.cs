using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MatricaGenerator
    {
        private static MatricaGenerator instance;
        private Random generator;
        private MatricaGenerator()
        {
            this.generator = new Random();
        }
        public static MatricaGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatricaGenerator();
            }
            return instance;
        }

        public double[][] NapraviMatricu(int red, int stupac)
        {
            double[][] matrica = new double[red][];
            for (int i = 0; i < red; i++)
            {
                matrica[i] = new double[stupac];
            }

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stupac; j++)
                    matrica[i][j] = generator.NextDouble();
            }

            return matrica;


        }

        

    }
    class PrintMatricu
    {
        public static void Print(double[][] matrica)
        {
            foreach (double[] red in matrica)
            {
                foreach (double broj in red)
                {
                    Console.Write(broj);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

}

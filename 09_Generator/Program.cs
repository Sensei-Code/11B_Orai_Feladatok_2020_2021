using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(10, 100);
                    Console.Write("{0};",matrix[i, j]);
                }
                Console.WriteLine();


            }

            Console.ReadLine();
        }
    }
}

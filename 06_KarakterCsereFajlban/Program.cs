using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozat_BM
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = "minta.txt";
            string file2 = "minta-csere.txt";
            StreamReader sr = new StreamReader(file);
            StreamWriter sw = new StreamWriter(file2);

            Console.Write("\n\nMelyik karatert cseréljem le: ");
            char mirol = char.Parse(Console.ReadLine());

            Console.Write("Mire cseréljem le: ");
            char mire = char.Parse(Console.ReadLine());

            string sor;
            while (sr.EndOfStream == false)
            {

                sor = sr.ReadLine();
                sor = sor.Replace(mirol, mire);
                Console.WriteLine(sor);
                sw.WriteLine(sor);
            }

            sr.Close();
            sw.Close();

            Console.ReadLine();

        }
    }
}

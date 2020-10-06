using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_FajlOlvasas
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajl = "teszt.txt";
            StreamReader sr = new StreamReader(fajl);

            string elso = sr.ReadLine();
            string masodik = sr.ReadLine();

            sr.Close();

            string[] sor;
            sor = elso.Split(',');

            Console.WriteLine(elso);
            Console.WriteLine(masodik);
            Console.ReadLine();



        }
    }
}

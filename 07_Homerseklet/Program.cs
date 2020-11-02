using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07_Homerseklet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napok = new string[] { "Hétfő", "Kedd", "Szerda",
                "Csütörtök", "Péntek", "Szombat", "Vasárnap" };

            string file = "homerseklet.txt";
            int[] homerseklet = new int[7];
            int index = 0;
            StreamReader sr = new StreamReader(file);

            while (sr.EndOfStream == false)
            {
                homerseklet[index] = int.Parse(sr.ReadLine());
                index++;
            }

            sr.Close();
            Console.WriteLine("Heti átlaghőmérséklet napi bontásban: \n\n");

            for (int i = 0; i < homerseklet.Length; i++)
                Console.WriteLine(napok[i] + ": " + homerseklet[i]);

            double osszeg = 0;
            int min = int.MaxValue;
            int minindex = 0;
            int max = 0;
            int maxindex = 0;

            for (int i = 0; i < homerseklet.Length; i++)
            {
                osszeg += homerseklet[i];
                if (homerseklet[i] < min) {
                    min = homerseklet[i];
                    minindex = i;
                }
                if (homerseklet[i] > max)
                {
                    max = homerseklet[i];
                    maxindex = i;
                }

            }

            Console.WriteLine("\nHeti átlaghőmérséklet: {0}", Math.Round(osszeg / homerseklet.Length, 2));
            Console.WriteLine("A legmelegebb nap: {0}, {1}", napok[maxindex], max);
            Console.WriteLine("A leghidegebb nap: {0}, {1}", napok[minindex], min);

            if (min < 0)
                Console.WriteLine("Ekkor fagyott: {0}",napok[minindex]);
            else
                Console.WriteLine("A hét fagymentes volt");

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08_BevetelZsebpenz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bevetel = new int[5];
            string file = "bevetel.txt";
            int index = 0;

            StreamReader sr = new StreamReader(file);

            while (sr.EndOfStream == false)
            {
                bevetel[index] = int.Parse(sr.ReadLine());
                index++;
            }

            sr.Close();

            int osszeg = 0;
            int max = 0;
            int maxindex = 0;
            int minindex = 0;
            int min = int.MaxValue;

            for (int i = 0; i < bevetel.Length; i++)
            {
                osszeg += bevetel[i];
                if (bevetel[i] > max)
                {
                    max = bevetel[i];
                    maxindex = i;
                }

                if (bevetel[i] < min)
                {
                    min = bevetel[i];
                    minindex = i;
                }

                Console.WriteLine("{0}. nap: {1} Ft",i+1,bevetel[i]);
            }

            Console.WriteLine("\nKati a legkevesebb zsebpénzt a(z) {0}. napon kapta: {1} Ft",minindex+1, bevetel[minindex]);
            Console.WriteLine("\nKati a legtöbb zsebpénzt a(z) {0}. napon kapta: {1} Ft.", maxindex + 1, bevetel[maxindex]);

            Console.Write("\nMit gondolsz, mennyi pénzt gyűjtött össze Kati az 5 nap alatt: ");
            int tipp = int.Parse(Console.ReadLine());

            if(tipp == osszeg)
                Console.WriteLine("\nGratulálok! Eltaláltad!");
            else            
                Console.WriteLine("\nSajnos ezt nem sikerült eltalálnod!");

            Console.WriteLine("\nKati az 5 nap alatt {0} Ft-ot gyűjtött össze!",osszeg);

            Console.ReadLine();

        }
    }
}

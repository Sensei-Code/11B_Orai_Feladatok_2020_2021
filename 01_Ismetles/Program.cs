using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hibas_bekeres = true;
            int meret = 0;

            do
            {
                hibas_bekeres = false;
                Console.Write("Mekkora legyen a tömb mérete:");

                meret = int.Parse(Console.ReadLine());

                if (meret < 10 || meret > 50)
                {
                    Console.WriteLine("Ez a szám hibás! Próbáld újra!");
                    hibas_bekeres = true;
                }

            } while (hibas_bekeres);

            int[] t = new int[meret];

            Random rnd = new Random();
            int osszeg = 0;
            int db_oszthato = 0;


            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(100, 1000);
                osszeg += t[i];
                // osszeg = osszeg + t[i];

                if (t[i] % 7 == 0) db_oszthato++;

                Console.Write("{0} ",t[i]);
            }

            Console.WriteLine("\n\nA tömbben lévő számok összege: {0}",osszeg);
            Console.WriteLine("A tömbben {0} db 7-tel osztható szám van!\n\n", db_oszthato);

            double[] t_negyzet = new double[meret];

            Console.WriteLine("A tömb elemei négyzetre emelve: \n");

            for (int i = 0; i < t.Length; i++)
            {
                t_negyzet[i] = Math.Pow(t[i], 2);
                Console.Write("{0} ", t_negyzet[i]);
            }

            Console.ReadLine();
        }
    }
}

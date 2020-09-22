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

            Console.Write("Kérek egy számot, megnézem eleme-e a tömbnek: ");
            int be = int.Parse(Console.ReadLine());

            int[] t = new int[meret];

            Random rnd = new Random();
            int osszeg = 0;
            int db_oszthato = 0;
            int min = int.MaxValue;
            int min_index = 0;
            int max_index = 0;
            int max = 0;
            bool talalt = false;

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(100, 1000);
                osszeg += t[i];          

                if (t[i] % 7 == 0) db_oszthato++;

                if (min > t[i])
                {
                    min = t[i];
                    min_index = i;
                }

                if (max < t[i])
                {
                    max = t[i];
                    max_index = i;
                }
                if (t[i] == be) talalt = true;

                Console.Write("{0} ",t[i]);
            }

            Console.WriteLine("\n\nA tömbben lévő számok összege: {0}",osszeg);
            Console.WriteLine("A tömbben {0} db 7-tel osztható szám van!\n\n", db_oszthato);
            Console.WriteLine("A tömb legnagyobb eleme {0} ami a tömb {1}. eleme!",max,max_index);
            Console.WriteLine("A tömb legkisebb eleme {0} ami a tömb {1}. eleme",min,min_index);

            if (talalt)
                Console.WriteLine("A megadott szám ({0}) SZEREPEL a tömbben",be);
            else
                Console.WriteLine("A megadott szám ({0}) NEM SZEREPEL a tömbben", be);

            double[] t_negyzet = new double[meret];

            Console.WriteLine("\nA tömb elemei négyzetre emelve: ");

            for (int i = 0; i < t.Length; i++)
            {
                t_negyzet[i] = Math.Pow(t[i], 2);
                Console.Write("{0} ", t_negyzet[i]);
            }

            Console.ReadLine();
        }
    }
}

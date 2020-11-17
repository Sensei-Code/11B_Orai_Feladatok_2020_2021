using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_MatrixFajlba
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Feladatleírás
            /*Írjatok egy programot ami egy 20x20 -as mátrixot feltölt kétjegyű véletlen 
             * számokkal és minden sornak kiszámolja az átlagát és megkeresi benne a legkisebb 
             * illetve a legnagyobb számot.Ezeket az eredményeket írassátok ki egy szöveges 
             * állományba úgy, hogy egy sorba egy sor átlaga és minimum illetve maximum értékei 
             * kerüljenek. Pl.

                1.sor átlaga: 54,21 Min: 13 Max: 97
                2.sor átlaga: 65,43 Min: 15 Max: 86
                .
                .
                20 átlaga: 63,65 Min: 17 Max: 67
            */
            #endregion

            StreamWriter sw = new StreamWriter("megoldas.txt");
            int[,] matrix = new int[20, 20];
            Random rnd = new Random();
            int velszam = 0;
            int min = int.MaxValue;
            int max = 0;
            double osszeg = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    velszam = rnd.Next(10, 100);
                    matrix[i, j] = velszam;
                    Console.Write("{0} ", velszam);
                    if (velszam > max) max = velszam;
                    if (velszam < min) min = velszam;
                    osszeg += velszam;
                }
                sw.WriteLine("{0}. sor átlaga: {1} Min: {2} Max: {3}",i+1,Math.Round(osszeg/20,2),min,max);
                min = int.MaxValue;
                max = 0;
                osszeg = 0;
                Console.WriteLine();
            }

            sw.Close();
            Console.ReadLine();

        }
    }
}

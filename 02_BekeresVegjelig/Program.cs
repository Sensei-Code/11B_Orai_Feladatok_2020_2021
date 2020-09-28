using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BekeresVegjelig
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 végjelig kérjünk be maximum 10 db számot 1 és 100 közötti tartományból. Ha rossz tartomány
            //ból adjuk meg a számot (pl. -3, 132) akkor a program figyelmeztessen erre! Ha elérjük
            //a 10 elemszámot vagy 0-át ütünk akkor írjuk ki a megadott számok összegét és átlagát!

            int[] t = new int[10];
            int be = 0;
            int db = 0;
            double osszeg = 0;

            do
            {
                Console.Write("Kérem a {0}. számot: ", db + 1);
                be = int.Parse(Console.ReadLine());
                if (be >= 1 && be <= 100)
                {
                    t[db] = be;
                    db++;
                }
            }
            while ((be != 0) && (db < 10));

            for (int i = 0; i < db; i++)
            {
                osszeg += t[i];
            }

            Console.WriteLine("A tömb összege: {0}",osszeg);
            Console.WriteLine("A tömb átlaga: {0}", osszeg / db);
            Console.ReadLine();



        }
    }
}
